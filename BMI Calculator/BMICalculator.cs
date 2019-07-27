using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class MainForm : Form
    {
        //Properties
        public string outputString { get; set; }
        public bool decimalExists { get; set; }
        public int KeyPadOriginYLocation {get; set;}
        public double EnteredValue { get; set; }
        public TextBox ActiveTextBox { get; set; }

        public Animation animationState;
        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load event for the MainForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            Size = new Size(320, 480);
            ActiveTextBox = null; //instantiates the starting active textBox
            animationState = Animation.IDLE;
            KeyPadOriginYLocation = KeyPadTable.Location.Y;
            ResultMessageLabel.Hide();
        }

        /// <summary>
        /// Event handler for Calculate BMI button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            StartCalculation();

        }
        /// <summary>
        /// Gets the entered values and initiates the calculation
        /// </summary>
        private void StartCalculation()
        {
            double weight = Convert.ToDouble(WeightTextBox.Text);
            double height = Convert.ToDouble(HeightTextBox.Text);
            double BMI;

            BMI = CalculateBMI(weight, height);

            RoundUpBMI(BMI);
        }

        /// <summary>
        /// Calculates BMI depending on selected Imperial/Metric Radio button
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        private double CalculateBMI(double weight, double height)
        {
            double BMI;
            if (MetricRadioButton.Checked == true)
            {
                BMI = weight / (height * height);
            }
            else
            {
                BMI = (weight * 703) / (height * height);
            }

            DisplayBMIResultMessage(BMI);

            return BMI;
        }

        /// <summary>
        /// Enters the result message into the appropriate label 
        /// </summary>
        /// <param name="BMI"></param>
        private void DisplayBMIResultMessage(double BMI)
        {
            BMIResultTimer.Enabled = true;
            ResultMessageLabel.Show();
            if (BMI < 18.5)
            {
                ResultMessageLabel.Text = "You are Underweight";
            }
            else if (18.5 <= BMI & BMI <= 24.9)
            {
                ResultMessageLabel.Text = "You have a Normal weight";
            }
            else if (25 <= BMI & BMI <= 29.9)
            {
                ResultMessageLabel.Text = "You are Overweight";
            }
            else
            {
                ResultMessageLabel.Text = "You are Obese";
            }
        }
        private void BMIResultTimer_Tick(object sender, EventArgs e)
        {
            BMIResultTimer.Enabled = false;
            ResultMessageLabel.Hide();
        }
        /// <summary>
        /// This method rounds up the BMI to two decimals  (ROUNDING UP MISSING FOR THE CASE OF X>5)
        /// </summary>
        /// <param name="BMI"></param>
        private void RoundUpBMI(double BMI)
        {
            string BMIString = Convert.ToString(BMI);
            char[] BMIArray = BMIString.ToCharArray();
            if (BMIArray.Contains('.'))
            {
                int decimalPosition = BMIString.IndexOf('.');
                int maximumLength = decimalPosition + 2;
                
                    if (BMIArray[maximumLength] >= 5)
                    {
                        BMI = Convert.ToDouble(BMIString) + 0.1;
                        BMIString = Convert.ToString(BMI);
                        BMIString = BMIString.Remove(maximumLength);
                    }
               
                
                    
                    ResultTextBox.Text = BMIString;
                
                
            }
            else
            {
                ResultTextBox.Text = BMIString;
            }
        }

       
        

       

        
        /// <summary>
        /// These change unit labels according to the Imperial/Metric Radio buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            WeightTextBox.Text = "0";
            HeightTextBox.Text = "0";
            WeightUnitLabel.Text = "kg";
            HeightUnitLabel.Text = "m";
        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            WeightTextBox.Text = "0";
            HeightTextBox.Text = "0";
            WeightUnitLabel.Text = "£";
            HeightUnitLabel.Text = "in";
        }
        /// <summary>
        /// Event handler for all KeyPad Buttons click events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyPadButton_Click(object sender, EventArgs e)
        {
            Button TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            int numericValue=0;

            bool numericResult = int.TryParse(tag, out numericValue);

            if (numericResult)
            {
                int maxSize = (decimalExists)? 5:3;
                if (outputString == "0")
                {
                    outputString = tag;
                }
                else
                {
                    if (outputString.Length < maxSize)
                    {
                        outputString += tag;
                    }
                                      
                }

                try//exception handled- whilst the animation was not inserted, clicking the KeyPad buttons would initiate a null-refrence error
                {
                    ActiveTextBox.Text = outputString;
                }
                catch
                {

                }
            }
            else
            {
                switch (tag)
                {
                    case "back":
                        backSpace();
                        break;
                    case "done":
                        if (outputString.IndexOf('.') > -1)
                        {
                            outputString = outputString.Remove(outputString.IndexOf('.') + 2);
                        }
                        
                        EnteredValue = Convert.ToDouble(ActiveTextBox.Text);
                        if (EnteredValue < 0.1)
                        {
                            outputString = "0.1";
                        }
                        ActiveTextBox.Text = outputString;
                        KeyPadAnimationTimer.Enabled = true;
                        animationState = Animation.DOWN;
                        ActiveTextBox.BackColor = Color.White;
                        break;
                    case "clear":
                        ClearKeyPad();
                        break;
                    case "decimal":
                        if (!decimalExists)
                        {
                            outputString += ".";
                            decimalExists = true;
                        }                       
                        break;
                        
                }
            }
        }

        private void backSpace()
        {
            var lastCharacter = outputString.Substring(outputString.Length - 1);
            if (lastCharacter == ".")
            {
                decimalExists = false;
            }
            outputString = outputString.Remove(outputString.Length - 1);
            if (outputString.Length == 0)
            {
                outputString = "0";
            }
            ActiveTextBox.Text = outputString;
        }

        /// <summary>
        /// This Method clears the entered number using the keypad
        /// </summary>
        private void ClearKeyPad()
        {
            ActiveTextBox.Text = "0";
            outputString = "0";
            decimalExists = false;
        }

        /// <summary>
        /// This assigns active label to the clicked label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ActiveTextBox_Click(object sender, EventArgs e)
        {
            //if (ActiveTextBox != null)
            //{
            //    ActiveTextBox.BackColor = Color.White;
               
            //}
            var SenderTextBox = sender as TextBox;
            ActiveTextBox = SenderTextBox;
            ActiveTextBox.BackColor = Color.Yellow;
            outputString= SenderTextBox.Text;

            KeyPadTable.BringToFront();
            KeyPadAnimationTimer.Enabled = true;
            KeyPadTable.Visible = true;
            animationState = Animation.UP;
        }

        /// <summary>
        /// Event Handler for KeyPadAnimation tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyPadAnimationTimer_Tick(object sender, EventArgs e)
        {
            switch (animationState)
            {
                case (Animation.IDLE):
                    break;
                case (Animation.UP):
                    MoveKeyPadUp();
                    break;
                case (Animation.DOWN):
                    MoveKeyPadDown();
                    break;
               
            }
           
        }

        private void MoveKeyPadUp()
        {
            var currentLocation = KeyPadTable.Location;

            currentLocation = new Point(currentLocation.X, currentLocation.Y - 30);
            KeyPadTable.Location = currentLocation;

            if (currentLocation.Y <= ActiveTextBox.Location.Y + 55)
            {
                KeyPadTable.Location = new Point(currentLocation.X, ActiveTextBox.Location.Y + 55);
                KeyPadAnimationTimer.Enabled = false;
                animationState = Animation.IDLE;
            }
        }

        private void MoveKeyPadDown()
        {
            var currentLocation = KeyPadTable.Location;

            currentLocation = new Point(currentLocation.X, currentLocation.Y + 30);
            KeyPadTable.Location = currentLocation;

            if (currentLocation.Y >= KeyPadOriginYLocation)
            {
                KeyPadTable.Location = new Point(currentLocation.X, KeyPadOriginYLocation);
                KeyPadAnimationTimer.Enabled = false;
                animationState = Animation.IDLE;
                KeyPadTable.Visible = false;
            }
        }

       
    }
}
