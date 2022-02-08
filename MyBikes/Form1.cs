using ClassLibraryMyBikes;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryData;


namespace MyBikes
{
    public partial class Form1 : Form
    {
        List<Bike> listOfBikes = new List<Bike>();
        List<MountainBike> listOfMountainBikes = new List<MountainBike>();
        List<RoadBike> listOfRoadBikes = new List<RoadBike>();
        

        string[] selectedItem;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EnumColor enumColor;
            Enum.TryParse(comboBoxColor.Text, out enumColor);


            EnumTypes enumType;
            Enum.TryParse(comboBoxBikeType.Text, out enumType);

            if (enumType is EnumTypes.MountainBike)
            {
                bool flag1 = false, flag2 = false;
                
                MountainBike mountainBike = new MountainBike();
                
                try
                {
                    mountainBike.SerialNumber = Convert.ToInt64(textBoxSerialNo.Text);
                    flag1 = true;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Serial No : " + ex.Message, "Error");

                }
                catch (NotInRangeExc ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

                if (flag1)
                {
                    try
                    {

                        mountainBike.Type = enumType;

                        mountainBike.Make = textBoxMake.Text;
                        mountainBike.Model = textBoxModel.Text;
                        mountainBike.Color = enumColor;
                        mountainBike.Date = dateTimePickerMadeDate.Value;
                        mountainBike.Speed = Convert.ToDouble(textBoxSpeed.Text);

                        
                        flag2 = true;
                    }
                    catch (BikeException ex)
                    {
                        MessageBox.Show(ex.Message, "Error");

                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Speed : " + ex.Message, "Error");

                    }
                    catch (NotInRangeExc ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }

                if(flag2)
                {

                    try
                    {
                        mountainBike.SeatHeight = Convert.ToDouble(textBoxSeatHeight.Text);
                        listOfBikes.Add(mountainBike);
                        listOfMountainBikes.Add(mountainBike);
                        Reset();
                        refreshList();

                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Seat Height : " + ex.Message, "Error");
                        
                    }
                    catch (BikeException ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }

                }


            }
            else if (enumType is EnumTypes.RoadBike)
            {
                bool flag1 = false, flag2 = false;
                EnumSuspension enumSuspension;
                

                RoadBike roadBike = new RoadBike();


                try
                {
                    roadBike.SerialNumber = Convert.ToInt64(textBoxSerialNo.Text);
                    flag1 = true;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Serial No : " + ex.Message, "Error");

                }
                catch (NotInRangeExc ex)
                {
                    MessageBox.Show(ex.Message);
                }


                if (flag1)
                {
                    try
                    {
                        roadBike.Make = textBoxMake.Text;
                        roadBike.Model = textBoxModel.Text;
                        roadBike.Color = enumColor;
                        roadBike.Speed = Convert.ToDouble(textBoxSpeed.Text);
                        roadBike.Date = dateTimePickerMadeDate.Value;
                        roadBike.Type = enumType;
                        Enum.TryParse(comboBoxSuspension.Text, out enumSuspension);
                        roadBike.Suspension = enumSuspension;
                        flag2 = true;
                    }
                    catch (BikeException ex)
                    {
                        MessageBox.Show(ex.Message, "Error");

                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Speed : " + ex.Message, "Error");

                    }
                    catch (NotInRangeExc ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }

                if(flag2)
                {
                    try
                    {

                        roadBike.HeightFromGround = Convert.ToDouble(textBoxHeighFromGround.Text);

                        listOfBikes.Add(roadBike);
                        listOfRoadBikes.Add(roadBike);

                        Reset();
                        refreshList();
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Height From Ground : " + ex.Message, "Error");

                    }
                    catch (NotInRangeExc ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }


                
            }
            else
            {
                MessageBox.Show("Please Select a Valid Bike Type", "Error");
                comboBoxBikeType.Focus();
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (EnumTypes type in Enum.GetValues(typeof(EnumTypes)))
            {
                this.comboBoxBikeType.Items.Add(type);
            }
            foreach (EnumColor color in Enum.GetValues(typeof(EnumColor)))
            {
                this.comboBoxColor.Items.Add(color);
            }
            foreach (EnumSuspension suspension in Enum.GetValues(typeof(EnumSuspension)))
            {
                this.comboBoxSuspension.Items.Add(suspension);
            }
            comboBoxBikeType.Text = Convert.ToString(EnumTypes.Undefined);
            comboBoxColor.Text = Convert.ToString(EnumColor.Undefined);
            comboBoxSuspension.Text = Convert.ToString(EnumSuspension.Undefined);
            fillData();
            
           
        }

        private void comboBoxBikeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnumTypes enumType;
            Enum.TryParse(comboBoxBikeType.Text, out enumType);

            if (enumType == EnumTypes.MountainBike)
            {
                textBoxSeatHeight.Enabled = true;
                comboBoxSuspension.Enabled = false;
                textBoxHeighFromGround.Enabled = false;
                

            }
            else if (enumType == EnumTypes.RoadBike)
            {
                textBoxSeatHeight.Enabled = false;
                comboBoxSuspension.Enabled = true;
                textBoxHeighFromGround.Enabled = true;
                
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure to Exit","Close Window",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }

            comboBoxBikeType.Text = Convert.ToString(EnumTypes.Undefined);
            comboBoxColor.Text = Convert.ToString(EnumColor.Undefined);
            comboBoxSuspension.Text = Convert.ToString(EnumSuspension.Undefined);
            listBoxBikeList.Items.Clear();
            textBoxSerialNo.Enabled = true;
           
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            EnumColor enumColor;
            Enum.TryParse(comboBoxColor.Text, out enumColor);

            int rmIndex = 0;

            foreach (Bike abike in listOfBikes)
            {
                if (abike.SerialNumber == Convert.ToInt64(selectedItem[0]))
                {
                    break;
                }
                rmIndex++;
            }


            if (EnumTypes.MountainBike == listOfBikes[rmIndex].Type)
            {
                MountainBike mountainBike = (MountainBike)listOfBikes[rmIndex];
                int idx = listOfMountainBikes.IndexOf(mountainBike);

                mountainBike.Make = textBoxMake.Text;
                mountainBike.Model = textBoxModel.Text;
                mountainBike.Color = enumColor;
                mountainBike.Speed = Convert.ToDouble(textBoxSpeed.Text);
                mountainBike.Date = dateTimePickerMadeDate.Value;
                mountainBike.SeatHeight = Convert.ToDouble(textBoxSeatHeight.Text);

                listOfBikes[rmIndex] = mountainBike;
                listOfMountainBikes[idx] = mountainBike;
                refreshList();
            }
            else if (EnumTypes.RoadBike == listOfBikes[rmIndex].Type)
            {
                EnumSuspension enumSuspension;
                Enum.TryParse(comboBoxSuspension.Text, out enumSuspension);

                RoadBike roadBike = (RoadBike)listOfBikes[rmIndex];
                int rIndex = listOfRoadBikes.IndexOf(roadBike);

                roadBike.Make = textBoxMake.Text;
                roadBike.Model = textBoxModel.Text;
                roadBike.Color = enumColor;
                roadBike.Speed = Convert.ToDouble(textBoxSpeed.Text);
                roadBike.Date = dateTimePickerMadeDate.Value;
                roadBike.Suspension = enumSuspension;
                roadBike.HeightFromGround = Convert.ToDouble(textBoxHeighFromGround.Text);

                listOfBikes[rmIndex] = roadBike;
                listOfRoadBikes[rIndex] = roadBike;

                Reset();
                refreshList();


            }
            else
            {
                MessageBox.Show("Select a record to update!", "Error");
            }

            textBoxSerialNo.Enabled = true;
            comboBoxBikeType.Enabled = true;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            
            int rmIndex = 0;
            foreach (Bike abike in listOfBikes)
            {
                if (abike.SerialNumber == Convert.ToInt64(selectedItem[0]))
                {
                    break;
                }
                rmIndex++;
            }
            if (listOfBikes[rmIndex].Type == EnumTypes.MountainBike)
            {
                MountainBike mountainBike = (MountainBike)listOfBikes[rmIndex];
                int mindex = listOfMountainBikes.IndexOf(mountainBike);
                listOfMountainBikes.RemoveAt(mindex);
                refreshMountainBikesList();
               

            }
            else if (listOfBikes[rmIndex].Type == EnumTypes.RoadBike)
            {
                RoadBike roadBike = (RoadBike)listOfBikes[rmIndex];
                int rindex = listOfRoadBikes.IndexOf(roadBike);
                listOfRoadBikes.RemoveAt(rindex);
                refreshRoadBikesList();
                
            }

            listOfBikes.RemoveAt(rmIndex);
            Reset();
            refreshList();
            MessageBox.Show("Record Removed Successfully", "Done");
            
            
        }

        private void buttonPrintAllBikes_Click(object sender, EventArgs e)
        {
            refreshList();
        }
        private void refreshList()
        {
            listBoxBikeList.Items.Clear();

            foreach (Bike aBike in listOfBikes)
            {
                listBoxBikeList.Items.Add(aBike.GetStringFormat());
            }
        }

        private void buttonPrintMountainBikes_Click(object sender, EventArgs e)
        {
            refreshMountainBikesList();
        }

        private void refreshMountainBikesList()
        {
            listBoxBikeList.Items.Clear();
            foreach (MountainBike mBike in listOfMountainBikes)
            {
                listBoxBikeList.Items.Add(mBike.GetStringFormat());
            }
        }

        private void buttonPrintRoadBikes_Click(object sender, EventArgs e)
        {
            refreshRoadBikesList();
        }

        private void refreshRoadBikesList()
        {
            listBoxBikeList.Items.Clear();
            foreach (RoadBike rbike in listOfRoadBikes)
            {
                listBoxBikeList.Items.Add(rbike.GetStringFormat());
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                long serialNo = Convert.ToInt64(textBoxSearch.Text);
                bool flag = false;

                foreach (Bike bike in listOfBikes)
                {
                    if (bike.SerialNumber == serialNo)
                    {
                        flag = true;
                        listBoxBikeList.Items.Clear();
                        listBoxBikeList.Items.Add(bike.GetStringFormat());
                        textBoxSearch.Clear();
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("No Record found!", "Error");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Search : " + ex.Message, "Error");

            }


            
            
        }

        private void listBoxBikeList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string item = listBoxBikeList.SelectedItem.ToString();
            selectedItem = item.Split(' ');
           
            int rmIndex = 0;

            foreach(Bike abike in listOfBikes)
            {
                if (abike.SerialNumber == Convert.ToInt64(selectedItem[0]))
                {
                    break;
                }
                rmIndex++;
            }


            if (listOfBikes[rmIndex] is MountainBike)
            {
                MountainBike mbike = (MountainBike)listOfBikes[rmIndex];
                int mIndex = listOfMountainBikes.IndexOf(mbike);

                comboBoxBikeType.Text = Convert.ToString(listOfMountainBikes[mIndex].Type);

                textBoxSerialNo.Text = Convert.ToString(listOfMountainBikes[mIndex].SerialNumber);
                textBoxSerialNo.Enabled = false;

                textBoxMake.Text = listOfMountainBikes[mIndex].Make;
                textBoxModel.Text = listOfMountainBikes[mIndex].Model;

                comboBoxColor.Text = Convert.ToString(listOfMountainBikes[mIndex].Color);
                textBoxSpeed.Text = Convert.ToString(listOfMountainBikes[mIndex].Speed);
                dateTimePickerMadeDate.Value = listOfMountainBikes[mIndex].Date;

                textBoxSeatHeight.Text = Convert.ToString(listOfMountainBikes[mIndex].SeatHeight);
                textBoxSeatHeight.Enabled = true;

                textBoxHeighFromGround.Text = "";
                textBoxHeighFromGround.Enabled = false;

                comboBoxSuspension.Text = Convert.ToString(EnumSuspension.Undefined);
                comboBoxSuspension.Enabled = false;

            }

            else if (listOfBikes[rmIndex] is RoadBike)
            {
                RoadBike roadBike = (RoadBike)listOfBikes[rmIndex];
                int rIndex = listOfRoadBikes.IndexOf(roadBike);

                comboBoxBikeType.Text = Convert.ToString(listOfRoadBikes[rIndex].Type);

                textBoxSerialNo.Text = Convert.ToString(listOfRoadBikes[rIndex].SerialNumber);
                textBoxSerialNo.Enabled = false;

                textBoxMake.Text = listOfRoadBikes[rIndex].Make;
                textBoxModel.Text = listOfRoadBikes[rIndex].Model;

                comboBoxColor.Text = Convert.ToString(listOfRoadBikes[rIndex].Color);
                textBoxSpeed.Text = Convert.ToString(listOfRoadBikes[rIndex].Speed);
                dateTimePickerMadeDate.Value = listOfRoadBikes[rIndex].Date;

                textBoxHeighFromGround.Text = Convert.ToString(listOfRoadBikes[rIndex].HeightFromGround);
                comboBoxSuspension.Text = Convert.ToString(listOfRoadBikes[rIndex].Suspension);
                textBoxSeatHeight.Text = "";

            }

        }

        private void buttonWriteData_Click(object sender, EventArgs e)
        {
            FileHandler.WriteToSerializedFile(listOfBikes);
            MessageBox.Show("Record Saved Successfully","Data Saved");
        }

        private void buttonReadData_Click(object sender, EventArgs e)
        {
            listOfBikes.Clear();
            listOfMountainBikes.Clear();
            listOfRoadBikes.Clear();
            listBoxBikeList.Items.Clear();

            fillData();

        }

        private void fillData()
        {
            listOfBikes = FileHandler.ReadFromSerializedFile();

            if (listOfBikes.Count > 0)
            {
                foreach (Bike aBike in listOfBikes)
                {
                    if (aBike is MountainBike)
                    {
                        listOfMountainBikes.Add((MountainBike)aBike);
                        this.listBoxBikeList.Items.Add(aBike);
                    }
                    if (aBike is RoadBike)
                    {
                        listOfRoadBikes.Add((RoadBike)aBike);
                        this.listBoxBikeList.Items.Add(aBike);
                    }
                }
            }
            else
            {
                MessageBox.Show("------No Data Found------", "Error");
            }
        }
    }
}
