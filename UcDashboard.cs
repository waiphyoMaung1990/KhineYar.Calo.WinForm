using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhineYar.Calo.WinForm
{
    public partial class UcDashboard : UserControl
    {
        public UcDashboard()
        {
            InitializeComponent();

            // Disable all panels initially
            DisableAllPanels();
        }

        private void DisableAllPanels()
        {
            // Disable all panels
            pnswimming.Enabled = false;
            pncycling.Enabled = false;
            pnrunning.Enabled = false;
            pnrowing.Enabled = false;
            pnyoga.Enabled = false;
            pnwalking.Enabled = false;
            // Add other panels here
        }

        private void chkswimming_CheckedChanged_1(object sender, EventArgs e)
        {
            pnswimming.Enabled = chkswimming.Checked;
        }

        private void chkwalking_CheckedChanged(object sender, EventArgs e)
        {
            pnwalking.Enabled = chkwalking.Checked;
        }

        private void chkcycling_CheckedChanged_1(object sender, EventArgs e)
        {
            pncycling.Enabled = chkcycling.Checked;
        }

        private void chkyoga_CheckedChanged(object sender, EventArgs e)
        {
            pnyoga.Enabled = chkyoga.Checked;
        }

        private void chkrowing_CheckedChanged(object sender, EventArgs e)
        {
            pnrowing.Enabled = chkrowing.Checked;
        }

        private void chkrunning_CheckedChanged(object sender, EventArgs e)
        {
            pnrunning.Enabled = chkrunning.Checked;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Panel paint event
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int targetCalories = Convert.ToInt32(txtTarget.Text);
            int totalCaloriesBurned = 0;

            // Calculate calories burned for each activity and add to the total
            if (pnswimming.Enabled)
            {
                Swimming swimmingActivity = new Swimming();
                swimmingActivity.TimeTaken = TimeSpan.Parse(txtswimtime.Text);
                totalCaloriesBurned += CalculateSwimmingCalories(swimmingActivity);
            }

            if (pnwalking.Enabled)
            {
                Walking walkingActivity = new Walking();
                walkingActivity.Distance = Convert.ToDouble(txtwalkingdistance.Text);
                walkingActivity.TimeTaken = TimeSpan.Parse(txtwalkingtime.Text);
                totalCaloriesBurned += CalculateWalkingCalories(walkingActivity);
            }

            if (pncycling.Enabled)
            {
                Cycling cyclingActivity = new Cycling();
                cyclingActivity.AverageSpeed = Convert.ToDouble(txtavgspeed.Text);
                cyclingActivity.Duration = TimeSpan.Parse(txtcyclingduration.Text);
                cyclingActivity.Distance = Convert.ToDouble(txtcyclingdistance.Text);
                totalCaloriesBurned += CalculateCyclingCalories(cyclingActivity);
            }

            if (pnyoga.Enabled)
            {
                Yoga yogaActivity = new Yoga();
                yogaActivity.Duration = TimeSpan.Parse(txtyogaduration.Text);
                yogaActivity.IntensityLevel = Convert.ToInt32(txtintensity.Text);
                totalCaloriesBurned += CalculateYogaCalories(yogaActivity);
            }

            if (pnrowing.Enabled)
            {
                Rowing rowingActivity = new Rowing();
                rowingActivity.Duration = TimeSpan.Parse(txtrowingduration.Text);
                rowingActivity.StrokesPerMinute = Convert.ToInt32(txtstockperminute.Text);
                 totalCaloriesBurned += CalculateRowingCalories(rowingActivity);
            }

            if (pnrunning.Enabled)
            {
                Running runningActivity = new Running();
                runningActivity.Distance = Convert.ToDouble(txtrunningdistance.Text);
                runningActivity.Duration = TimeSpan.Parse(txtrunningduration.Text);
                runningActivity.AveragePace = TimeSpan.Parse(txtrunningavgpace.Text);
                totalCaloriesBurned += CalculateRunningCalories(runningActivity);
            }

            // Calculate remaining calories
            int remainingCalories = targetCalories - totalCaloriesBurned;
            lblcaloriesburn.Text = totalCaloriesBurned.ToString();
            // Display the remaining calories
            lblRemainingCalories.Text = remainingCalories.ToString();
        }

        private int CalculateSwimmingCalories(Swimming activity)
        {
            // Assuming a constant calorie burn rate for swimming
            double calorieBurnRatePerHour = 500;

            // Calculate the duration of swimming in minutes
            double durationInMinutes = activity.TimeTaken.TotalMinutes;

            // Calculate the total calories burned for swimming
            double calorieBurn = (calorieBurnRatePerHour * durationInMinutes) / 60;
            return (int)calorieBurn;
        }

        private int CalculateWalkingCalories(Walking activity)
        {
            // Assuming a constant calorie burn rate for walking
            double calorieBurnRatePerHour = 250;

            // Calculate the duration of walking in minutes
            double durationInMinutes = activity.TimeTaken.TotalMinutes;

            // Calculate the total calories burned for walking
            double calorieBurn = (calorieBurnRatePerHour * durationInMinutes) / 60;
            return (int)calorieBurn;
        }

        private int CalculateCyclingCalories(Cycling activity)
        {
            // Assuming a constant calorie burn rate for cycling
            double calorieBurnRatePerHour = 600;

            // Calculate the duration of cycling in minutes
            double durationInMinutes = activity.Duration.TotalMinutes;

            // Calculate the total calories burned for cycling
            double calorieBurn = (calorieBurnRatePerHour * durationInMinutes) / 60;
            return (int)calorieBurn;
        }

        private int CalculateYogaCalories(Yoga activity)
        {
            double MET;

            if (activity.IntensityLevel == 1)
            {
                MET = 2.5;
            }
            else if (activity.IntensityLevel == 2)
            {
                MET = 4.0;
            }
            else
            {
                MET = 6.0;
            }

            // Add numPoses to MET calculation
            MET += 0.1 * activity.Poses;

            // Calculate the duration of yoga in minutes
            double durationInMinutes = activity.Duration.TotalMinutes;

            // Calculate the total calories burned for yoga
            double calorieBurn = (MET * durationInMinutes) / 60;
            return (int)calorieBurn;
        }

        private int CalculateRowingCalories(Rowing activity)
        {
            // Assuming a constant calorie burn rate for rowing
            double calorieBurnRatePerHour = 700;

            // Calculate the duration of rowing in minutes
            double durationInMinutes = activity.Duration.TotalMinutes;

            // Calculate the total calories burned for rowing
            double calorieBurn = (calorieBurnRatePerHour * durationInMinutes) / 60;
            return (int)calorieBurn;
        }

        private int CalculateRunningCalories(Running activity)
        {
            // Assuming a constant calorie burn rate for running
            double calorieBurnRatePerHour = 700;

            // Calculate the duration of running in minutes
            double durationInMinutes = activity.Duration.TotalMinutes;

            // Calculate the total calories burned for running
            double calorieBurn = (calorieBurnRatePerHour * durationInMinutes) / 60;
            return (int)calorieBurn;
        }
    }
}
