using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Devil
{
    class DataWorker
    {
        private string GetBetweenString(string TotalString, string FirstString, string LastString)
        {
            int num = TotalString.IndexOf(FirstString) + FirstString.Length;
            int num2 = TotalString.IndexOf(LastString);
            return TotalString.Substring(num, num2 - num);
        }

        public string GetData(string DataName, string FileName)
        {
            if (File.Exists(FileName))
            {
                string allData = File.ReadAllText(FileName);
                if (allData.Contains("<" + DataName + ">") && allData.Contains("</" + DataName + ">"))
                {
                    foreach (string curLine in allData.Split('\n'))
                    {
                        if (curLine.Contains("<" + DataName + ">") && curLine.Contains("</" + DataName + ">") && curLine.StartsWith("<" + DataName + ">") && curLine.EndsWith("</" + DataName + ">"))
                        {
                            string tempRem = curLine.Remove(0, DataName.Length + 2);
                            return tempRem.Remove((tempRem.Length - (DataName.Length + 3)), (DataName.Length + 3));
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

            return null;
        }

        public void SetData(string DataName, string DataValue, string FileName)
        {
            if (File.Exists(FileName))
            {
                string allData = File.ReadAllText(FileName);
                if (allData.Contains("<" + DataName + ">") && allData.Contains("</" + DataName + ">"))
                {
                    allData = allData.Replace("<" + DataName + ">" + GetBetweenString(allData, "<" + DataName + ">", "</" + DataName + ">") + "</" + DataName + ">", "<" + DataName + ">" + DataValue + "</" + DataName + ">");
                    File.WriteAllText(FileName, allData);
                }
                else
                {
                    if (allData == "")
                    {
                        allData += "<" + DataName + ">" + DataValue + "</" + DataName + ">";
                    }
                    else
                    {
                        allData += "\n<" + DataName + ">" + DataValue + "</" + DataName + ">";
                    }

                    File.WriteAllText(FileName, allData);
                }
            }
            else
            {
                File.WriteAllText(FileName, "<" + DataName + ">" + DataValue + "</" + DataName + ">");
            }
        }
    }

    public class UXWorker
    {
        private Control PasswordEffect_EyeButton;

        private TextBox PasswordEffect_PasswordBox;

        private TextBox CaptionEffect_TargetBox;

        private Color CaptionEffect_CaptionColor;

        private Color CaptionEffect_OldColor;

        private string CaptionEffect_CaptionText;

        private Form CaptionEffect_CurrentForm;

        private bool CustomFormMover_Dragging;

        private Point CustomFormMover_Offset;

        private Control CustomFormMover_TargetControl;

        private Form CustomFormMover_FormToMove;

        private Control InfoViewer_TargetControl;

        private string InfoViewer_InfoText;

        public void PasswordEffect(Control EyeButton, TextBox PasswordBox)
        {
            PasswordEffect_EyeButton = EyeButton;
            PasswordEffect_PasswordBox = PasswordBox;
            PasswordBox.UseSystemPasswordChar = true;
            EyeButton.MouseDown += EyeButton_MouseDown;
            EyeButton.MouseUp += EyeButton_MouseUp;
        }

        private void EyeButton_MouseUp(object sender, MouseEventArgs e)
        {
            PasswordEffect_PasswordBox.UseSystemPasswordChar = true;
        }

        private void EyeButton_MouseDown(object sender, MouseEventArgs e)
        {
            PasswordEffect_PasswordBox.UseSystemPasswordChar = false;
        }

        public void CaptionEffect(TextBox TargetBox, Color CaptionColor, string CaptionText, Form CurrentForm)
        {
            CaptionEffect_TargetBox = TargetBox;
            CaptionEffect_CaptionColor = CaptionColor;
            CaptionEffect_OldColor = TargetBox.ForeColor;
            CaptionEffect_CaptionText = CaptionText;
            CaptionEffect_CurrentForm = CurrentForm;
            TargetBox.ForeColor = CaptionColor;
            TargetBox.Text = CaptionText;
            TargetBox.Click += TargetBox_Click;
            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 1;
            timer.Tick += Checker_Tick;
            timer.Start();
        }

        private void Checker_Tick(object sender, EventArgs e)
        {
            if (CaptionEffect_CurrentForm.ActiveControl != CaptionEffect_TargetBox && CaptionEffect_TargetBox.Text == "")
            {
                CaptionEffect_TargetBox.ForeColor = CaptionEffect_CaptionColor;
                CaptionEffect_TargetBox.Text = CaptionEffect_CaptionText;
            }
        }

        private void TargetBox_Click(object sender, EventArgs e)
        {
            if (CaptionEffect_TargetBox.Text == CaptionEffect_CaptionText && CaptionEffect_TargetBox.ForeColor == CaptionEffect_CaptionColor)
            {
                CaptionEffect_TargetBox.ForeColor = CaptionEffect_OldColor;
                CaptionEffect_TargetBox.Text = "";
            }
        }

        public void CustomFormMover(Control TargetControl, Form FormToMove)
        {
            CustomFormMover_TargetControl = TargetControl;
            CustomFormMover_FormToMove = FormToMove;
            TargetControl.MouseDown += TargetControl_MouseDown;
            TargetControl.MouseUp += TargetControl_MouseUp;
            TargetControl.MouseMove += TargetControl_MouseMove;
            //FormToMove.LocationChanged += FormToMove_LocationChanged;
        }

        private void FormToMove_LocationChanged(object sender, EventArgs e)
        {
            /*if (!CustomFormMover_Dragging)
            {
				if (CustomFormMover_FormToMove.Location.X <= 0)
				{
					CustomFormMover_FormToMove.Location = new Point(0, CustomFormMover_FormToMove.Location.Y);
				}
				if (CustomFormMover_FormToMove.Location.Y <= 0)
				{
					CustomFormMover_FormToMove.Location = new Point(CustomFormMover_FormToMove.Location.X, 0);
				}


				if (CustomFormMover_FormToMove.Location.X >= Screen.PrimaryScreen.Bounds.Width - CustomFormMover_FormToMove.Width)
				{
					CustomFormMover_FormToMove.Location = new Point(Screen.PrimaryScreen.Bounds.Width - CustomFormMover_FormToMove.Width, CustomFormMover_FormToMove.Location.Y);
				}
				if (CustomFormMover_FormToMove.Location.Y >= Screen.PrimaryScreen.Bounds.Height - CustomFormMover_FormToMove.Height)
				{
					CustomFormMover_FormToMove.Location = new Point(CustomFormMover_FormToMove.Location.X, Screen.PrimaryScreen.Bounds.Height - CustomFormMover_FormToMove.Height);
				}
			}*/
        }

        private void TargetControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (CustomFormMover_Dragging)
            {
                Point point = CustomFormMover_FormToMove.PointToScreen(e.Location);
                CustomFormMover_FormToMove.Location = new Point(point.X - CustomFormMover_Offset.X, point.Y - CustomFormMover_Offset.Y);
            }
        }

        private void TargetControl_MouseUp(object sender, MouseEventArgs e)
        {
            CustomFormMover_Dragging = false;
            if (CustomFormMover_FormToMove.Location.X <= 0)
            {
                CustomFormMover_FormToMove.Location = new Point(0, CustomFormMover_FormToMove.Location.Y);
            }
            if (CustomFormMover_FormToMove.Location.Y <= 0)
            {
                CustomFormMover_FormToMove.Location = new Point(CustomFormMover_FormToMove.Location.X, 0);
            }


            if (CustomFormMover_FormToMove.Location.X >= Screen.PrimaryScreen.Bounds.Width - CustomFormMover_FormToMove.Width)
            {
                CustomFormMover_FormToMove.Location = new Point(Screen.PrimaryScreen.Bounds.Width - CustomFormMover_FormToMove.Width, CustomFormMover_FormToMove.Location.Y);
            }
            if (CustomFormMover_FormToMove.Location.Y >= Screen.PrimaryScreen.Bounds.Height - CustomFormMover_FormToMove.Height)
            {
                CustomFormMover_FormToMove.Location = new Point(CustomFormMover_FormToMove.Location.X, Screen.PrimaryScreen.Bounds.Height - CustomFormMover_FormToMove.Height);
            }
        }

        private void TargetControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (CustomFormMover_FormToMove.WindowState == FormWindowState.Maximized)
            {
                CustomFormMover_FormToMove.WindowState = FormWindowState.Normal;
            }
            CustomFormMover_Dragging = true;
            CustomFormMover_Offset = e.Location;
            CustomFormMover_FormToMove.BringToFront();
        }

        public void InfoViewer(Control TargetControl, string InfoText)
        {
            InfoViewer_TargetControl = TargetControl;
            InfoViewer_InfoText = InfoText;
            TargetControl.MouseHover += TargetControl_MouseHover;
        }

        private void TargetControl_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Info : ";
            toolTip.SetToolTip(InfoViewer_TargetControl, InfoViewer_InfoText);
        }
    }
}
