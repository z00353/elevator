using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lift_Assignment_1
{
    public partial class Form1 : Form
    {
        /* CLIENT VARIABLES */
        private string action = " ";
        private int shaft_top = 12;
        private int shaft_bottom = 272;
        private int left_door_close = 224;
        private int left_door_open = 116;
        private int right_door_close = 338;
        private int right_door_open = 446;
        private bool move_up = false;
        private bool move_down = false;

        /* BACK-END VARIABLES*/
        private string dbconnection;
        private string dbcommand;
        private OleDbConnection conn;
        private OleDbCommand comm;
        private OleDbDataAdapter adapter;
        private OleDbCommandBuilder builder;
        private DataSet ds = new DataSet("ElevatorLog");


        /// <summary>
        /// ******************** CLIENT ********************
        /// </summary>
        
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Upon loadig the form
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            try// Start try-catch block
            {
                dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=LiftDatabase.accdb;";// Connection string
                dbcommand = "Select * from ElevatorLog;";// SQL query command string
                conn = new OleDbConnection(dbconnection);// Initializing connection variable with method parameter the connection string
                comm = new OleDbCommand(dbcommand, conn);// Initializing command variable with method parameter connection and the SQL command string
                adapter = new OleDbDataAdapter(comm);// Initializing the adapter variable to work with the connection above
                builder = new OleDbCommandBuilder(adapter);// Builder to work with the adapter above
            }
            catch (Exception e1)// Catch an exception likely to occure
            {
                MessageBox.Show("Problems with connection");// Pop-up message
                string message = "Check the strings for connection and command. Check db file path" + e1.ToString();// System-user feedback message
                string caption = "Error! " + e1.ToString();// Capion of system-user feedback message
                MessageBoxButtons buttons = MessageBoxButtons.OK;// Initializing button OK
                DialogResult result;// Variable to hold all messages in dialog result
                result = MessageBox.Show(message, caption, buttons);// Dialog result includes the three method parameters upon showing
            }// End try-catch block

            // If there were no exceptions to catch, proceed:
            btn_display.Enabled = false;// Hide Display button
            lbl_action_display.Enabled = false;// Hide label
            load_data_from_db_to_ds();// Call method which loads data from database
            update_listbox();// Call method which updates listbox
        }

        /// <summary>
        /// TIMERS
        /// </summary>

        /// <summary>
        /// Private methods belonging to this form only, void does not return value 
        /// </summary>
        
        /// 1. MOVE DOWN CABIN COTROL
        private void tmr_move_down_cabin_Tick(object sender, EventArgs e)// Cabin object vertical movement, down
        {
            if ((picBox_cabin.Top <= shaft_bottom)// If cabin object position is less than, or equals 272 pix from top of the Form
                && (cabin_right_door.Top <= shaft_bottom && cabin_left_door.Top <= shaft_bottom))// and same applies to the elevator doors,
            {// Proceed:
                picBox_cabin.Top += 1;// Add 1 pix for cabin position till value reaches 272 pix (bottom of Form) 
                cabin_right_door.Top += 1;// Same applies to cabin right door
                cabin_left_door.Top += 1;// Same applies to cabin left door
                btn_to_move_up.Enabled = false;// Disabled request button to avoid mishaps
                btn_delete_all.Enabled = false;// Disabled request button to avoid mishaps
            }
            else// If the above does not apply, proceed:
            {
                tmr_move_down_cabin.Enabled = false;// Timer to move down, OFF
                btn_to_move_up.Enabled = true;// Outer request button moving lift up, ON
                btn_to_move_down.Enabled = true;// Outer request button moving lift down, ON
                btn_1.Enabled = true;// Cabin button 1, ON
                btn_delete_all.Enabled = true;// Button to delete data, ON
                btn_to_move_down.BackColor = Color.White;// Outer request button moving lift down, reminds unchanged (colour white)
                btn_to_move_up.BackColor = Color.White;// Outer request button moving lift up, reimnds unchanged (colour white)
                btn_G.BackColor = Color.White;// Cabin button G, reimnds unchanged (colour white)
                lbl_display_floor.Text = " G";// Label displays floor, G
                open_down_doors();// Calling method to open floor G shaft doors
            }
        }

        /// 2. MOVE UP CABIN CONTROL
        private void tmr_move_up_cabin_Tick(object sender, EventArgs e)// Cabin object vertical movement, up
        {
            if ((picBox_cabin.Top >= shaft_top)// If cabin object position is greater than, or equals 272 pix from top of the Form
                && (cabin_right_door.Top >= shaft_top && cabin_left_door.Top >= shaft_top))// and same applies to the elevator doors,
            {// Proceed:
                picBox_cabin.Top -= 1;// Substract 1 pix for cabin position till value reaches 12 pix (top of Form) 
                cabin_right_door.Top -= 1;// Same applies to cabin right door
                cabin_left_door.Top -= 1;// Same applies to cabin left door
                btn_to_move_down.Enabled = false;// Disabled request button to avoid mishaps
                btn_delete_all.Enabled = false;// Disabled request button to avoid mishaps
            }
            else// If the above does not apply, proceed:
            {
                tmr_move_up_cabin.Enabled = false;// Timer to move up, OFF
                btn_to_move_up.Enabled = true;// Outer request button moving lift up, ON
                btn_to_move_down.Enabled = true;// Outer request button moving lift down, ON
                btn_G.Enabled = true;// Cabin button G, ON
                btn_delete_all.Enabled = true;// Button to delete data, ON
                btn_to_move_down.BackColor = Color.White;// Outer request button moving lift down, reminds unchanged (colour white)
                btn_to_move_up.BackColor = Color.White;// Outer request button moving lift up, reimnds unchanged (colour white)
                btn_1.BackColor = Color.White;// Cabin button 1, reimnds unchanged (colour white)
                lbl_display_floor.Text = " 1";// Label displays floor, 1
                open_upper_doors();// Calling method to open floor 1 shaft doors
            }
        }

        /// 3. (G FLOOR) OPEN DOORS CONTROL
        private void tmr_open_doors_G_floor_Tick(object sender, EventArgs e)// Door objects horizontal movement, open
        {   // If all left door objects are on position greater or equal to 116 pix away from left border of the Form
            // and all right door objects are on position less than or equal to 446 pix,
            if ((shaft_down_left_door.Left >= left_door_open && shaft_down_right_door.Left <= right_door_open)
                 && (cabin_left_door.Left >= left_door_open && cabin_right_door.Left <= right_door_open))
            {// Proceed:
                shaft_down_left_door.Left -= 1;// Substract 1 pix from position till value reaches "open" (116 pix from left border of Form) 
                shaft_down_right_door.Left += 1;// Add 1 pix to position till value reaches "open" (446 pix from left border of Form) 
                cabin_left_door.Left -= 1;// Substract 1 pix from position till value reaches "open" (116 pix from left border of Form) 
                cabin_right_door.Left += 1;// Add 1 pix to position till value reaches "open"(446 pix from left border of Form) 
            }
            else// If the above does not apply, proceed:
            {
                tmr_open_doors_G_floor.Enabled = false;// Timer to open up floor G doors, OFF
                close_down_doors();// Calling method to close floor G shaft doors
            }   
        }

        /// 4. (G FLOOR) CLOSE DOORS CONTROL
        private void tmr_close_doors_G_floor_Tick(object sender, EventArgs e)// Door objects horizontal movement, close
        {   // If all left door objects are on position less or equal to 224 pix away from left border of the Form
            // and all right door objects are on position greater than or equal to 338 pix,
            if ((shaft_down_left_door.Left <= left_door_close && shaft_down_right_door.Left >= right_door_close)
                && (cabin_left_door.Left <= left_door_close && cabin_right_door.Left >= right_door_close))
            {// Proceed:
                shaft_down_left_door.Left += 1;// Add 1 pix to position till value reaches "close" ( 224 pix from left border of Form) 
                shaft_down_right_door.Left -= 1;// Substract 1 pix from position till value reaches "close" (338 pix from left border of Form)
                cabin_left_door.Left += 1;// Add 1 pix to position till value reaches "close" ( 224 pix from left border of Form) 
                cabin_right_door.Left -= 1;// Substract 1 pix from position till value reaches "close" (338 pix from left border of Form)
            }
            else// If the above does not apply, proceed:
            {
                tmr_close_doors_G_floor.Enabled = false;// Timer to close floor G doors, OFF
                if (move_up == true)// If movement towards top occurs,
                {
                    tmr_move_up_cabin.Enabled = true;// Timer to move up, ON
                    move_up = false;// End move
                }
            }
        }

        /// 5. (1 FLOOR) OPEN DOORS CONTROL
        private void tmr_open_doors_1_floor_Tick(object sender, EventArgs e)
        {   // If all left door objects are on position greater or equal to 116 pix away from left border of the Form
            // and all right door objects are on position less than or equal to 446 pix,
            if ((shaft_up_left_door.Left >= left_door_open && shaft_up_right_door.Left <= right_door_open)
                && (cabin_left_door.Left >= left_door_open && cabin_right_door.Left <= right_door_open))
            {// Proceed:
                shaft_up_left_door.Left -= 1;// Substract 1 pix from position till value reaches "open" (116 pix from left border of Form) 
                shaft_up_right_door.Left += 1;// Add 1 pix to position till value reaches "open" (446 pix from left border of Form) 
                cabin_left_door.Left -= 1;// Substract 1 pix from position till value reaches "open" (116 pix from left border of Form) 
                cabin_right_door.Left += 1;// Add 1 pix to position till value reaches "open" (446 pix from left border of Form) 
            }
            else// If the above does not apply, proceed:
            {
                tmr_open_doors_1_floor.Enabled = false;// Timer to open up floor 1 doors, OFF
                close_upper_doors();// Calling method to close floor 1 shaft doors
            }
        }

        /// 6. (1 FLOOR) CLOSE DOORS CONTROL
        private void tmr_close_doors_1_floor_Tick(object sender, EventArgs e)
        {   // If all left door objects are on position less or equal to 224 pix away from left border of the Form
            // and all right door objects are on position greater than or equal to 338 pix,
            if ((shaft_up_left_door.Left <= left_door_close && shaft_up_right_door.Left >= right_door_close)
                && (cabin_left_door.Left <= left_door_close && cabin_right_door.Left >= right_door_close))
            {// Proceed:
                shaft_up_left_door.Left += 1;// Add 1 pix to position till value reaches "close" ( 224 pix from left border of Form) 
                shaft_up_right_door.Left -= 1;// Substract 1 pix from position till value reaches "close" (338 pix from left border of Form)
                cabin_left_door.Left += 1;// Add 1 pix to position till value reaches "close" ( 224 pix from left border of Form) 
                cabin_right_door.Left -= 1;// Substract 1 pix from position till value reaches "close" (338 pix from left border of Form)
            }
            else// If the above does not apply, proceed:
            {
                tmr_open_doors_1_floor.Enabled = false;// Timer to close floor 1 doors, OFF
                if (move_down == true)// If movement towards bottom occurs,
                {
                    tmr_move_down_cabin.Enabled = true;// Timer to move down, ON
                    move_down = false;// End move
                }
            }
        }

        /// <summary>
        /// METHODS
        /// </summary>

        /// <summary>
        /// Private scope methods belonging to this form only, void does not return value
        /// </summary>

        // LIFT MOVEMENT
        private void going_up()// Define actions during elevator movement UP
        {
            move_up = true;// Allow move up boolean variable
            btn_G.Enabled = false;// Button to move towards floor G, OFF
            btn_to_move_up.Enabled = false;// Button to move towards floor 1, OFF
            close_down_doors();// Calling method to close doors on floor G
            action = "On Floor 1";// Value string, for action to be recorded and displayed
            insert_record_into_ds();// Calling method to insert recorded data into dataset
        }

        private void going_down()// Define actions during elevator movement DOWN 
        {
            move_down = true;// Allow move down boolean variable
            btn_1.Enabled = false;// Button to move towards floor 1, OFF
            btn_to_move_down.Enabled = false;// Button to move towards floor G, OFF
            close_upper_doors();// Calling method to close doors on floor 1
            action = "On Floor 0";// Value string, for action to be recorded and displayed
            insert_record_into_ds();// Calling method to insert recorded data into dataset
        }

        // DONW DOORS
        private void close_down_doors()// Define actions during doors closing on floor G
        {
            tmr_close_doors_G_floor.Enabled = true;// Timer to close floor G doors, ON
            tmr_open_doors_G_floor.Enabled = false;// Timer to open floor G doors, OFF
            btn_delete_all.Enabled = true;// Buton to delete data from database, ON
            action = "Doors Closed Floor 0";// Value string, for action to be recorded and displayed
            insert_record_into_ds();// Calling method to insert recorded data into dataset
        }

        private void open_down_doors()// Define actions during doors opening on floor G
        {
            tmr_close_doors_G_floor.Enabled = false;// Timer to close floor G doors, OFF
            tmr_open_doors_G_floor.Enabled = true;// Timer to open floor G doors, ON
            btn_delete_all.Enabled = false;// Buton to delete data from database, OFF
            action = "Doors Opened Floor 0";// Value string, for action to be recorded and displayed 
            insert_record_into_ds();// Calling method to insert recorded data into dataset
        }

        // UPPER DOORS
        private void close_upper_doors()// Define actions during doors closing on floor 1
        {
            tmr_close_doors_1_floor.Enabled = true;// Timer to close floor 1 doors, ON
            tmr_open_doors_1_floor.Enabled = false;// Timer to open floor 1 doors, OFF
            btn_delete_all.Enabled = true;// Buton to delete data from database, ON
            action = "Doors Closed Floor 1";// Value string, for action to be recorded and displayed
            insert_record_into_ds();// Calling method to insert recorded data into dataset
        }

        private void open_upper_doors()// Define actions during doors opening on floor 1
        {
            tmr_close_doors_1_floor.Enabled = false;// Timer to close floor 1 doors, OFF
            tmr_open_doors_1_floor.Enabled = true;// Timer to open floor 1 doors, ON
            btn_delete_all.Enabled = false;// Buton to delete data from database, OFF
            action = "Doors Opened Floor 1";// Value string, for action to be recorded and displayed 
            insert_record_into_ds();// Calling method to insert recorded data into dataset
        }


        /// <summary>
        /// ******************** BACK END ********************
        /// </summary>
        

        /// <summary>
        /// Public scope methods, to be reached from outside the form, void does not return value
        /// </summary>

        /// <summary>
        /// Insert records into the database
        /// </summary>
        public void insert_record_into_ds()
        {
            string date = DateTime.Now.ToShortDateString();// Get the date
            string time = DateTime.Now.ToLongTimeString();// Get the time
           
            DataRow newRow = ds.Tables[0].NewRow();// Define new record in the dataset and place it into a new DataRow
            newRow["DateLog"] = date;// Parameter to allocate value "date" to a row with column name "DateLog"
            newRow["TimeLog"] = time;// Parameter to allocate value "time" to a row with column name "TimeLog"
            newRow["ActionLog"] = action;// Parameter to allocate value "action" to a row with column name "ActionLog"

            ds.Tables[0].Rows.Add(newRow);// Add the new DataRow to DataTable 
            save_data_into_db();// Save change to the database
            update_listbox();// Update listBox
        }

        /// <summary>
        /// Save changes from dataset into the database
        /// </summary>
        public void save_data_into_db()
        {
            int number_of_row_updated = 0;// variable to hold the value of number of rows updated in the database

            if (ds.Tables[0].Rows.Count != 0)// Check if the dataset is already intitalized 
            {// If initialized, proceed:

                try// Try-catsh block start
                {
                    conn.Open();// Open connection

                    // Update database
                    DataSet dataSetChanges = ds.GetChanges();// Get copy of the dataset that was changed 
                    number_of_row_updated = adapter.Update(dataSetChanges);// Update database 
                    ds.Tables[0].AcceptChanges();// Accept changes for dataset
                }
                catch (Exception e2)// Catch exception likely to occur
                {
                    MessageBox.Show("No data saved in to database. " + e2.ToString());// Pop-up message converting the exception "e2" into string
                    string msg = "Check connection sting. " + e2.ToString();// System-user feedback message
                    string caption = "error! " + e2.ToString();// Capion of system-user feedback message
                    MessageBoxButtons buttons = MessageBoxButtons.OK;// Initializing button OK
                    DialogResult result;// Variable to hold all messages in dialog result
                    result = MessageBox.Show(msg, caption, buttons);// Dialog result includes the three method parameters upon showing
                }// Try-catsh block end

                conn.Close();// Closing connection
            }

            if (number_of_row_updated < 1)// If the database is not updated as expected due to unexpected reasons,
            {
                reload_data_from_db_to_ds();// Load the local copy again from the database
            }
        }

        /// <summary>
        /// Load data from the database into the dataset
        /// </summary>
        public void load_data_from_db_to_ds()
        {
            bool filled = false;// Boolean variable to hold vaule for filled-up data, set to false
            try
            {
                conn.Open();// Open Connection
                while (filled == false)// While dataset not filled-up
                {
                    adapter.Fill(ds);// Fill dataset with adaptor
                    filled = true;// Status, dataset filled-up
                }
            }
            catch (Exception e3)// Exception handling
            {
                MessageBox.Show("No data loaded from db to ds. " + e3.ToString());
                string msg = "Check connection. " + e3.ToString();
                string caption = "Error!" + e3.ToString();
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(msg, caption, buttons);
            }
            conn.Close();// Close connestion
        }

        /// <summary>
        /// Force reload the data into the dataset
        /// </summary>
        public void reload_data_from_db_to_ds()
        {
            ds.Clear();// Clear dataset before loading from database
            load_data_from_db_to_ds();// Load data from database to dataset
        }

        /// <summary>
        /// Update listBox1
        /// </summary>
        public void update_listbox()
        {
            listBox1.Items.Clear();// Clear items before updating
            foreach (DataRow row in ds.Tables[0].Rows)// For each dataset row
            {
                listBox1.Items.Add(row["DateLog"] + "\t " + row["TimeLog"] + "\t\t " + row["ActionLog"] + ";");// Add rows
            }
        }

        /// <summary>
        /// Methods with specific signature to be encapsulated in delegates in class Form1 in Form1.Designer.cs
        /// </summary>

        /// <summary>
        /// Responds to btn_display in publishing class Form1
        /// Assigned to delegate in Form1.Designer.cs, Line: 161
        /// </summary>
        public void Display(object sender, EventArgs e)
        {
            btn_display.Enabled = false;
            lbl_action_display.Enabled = true;
            listBox1.Items.Clear();
            load_data_from_db_to_ds();
            update_listbox();
        }

        /// <summary>
        /// Responds to btn_reset in publishing class Form1
        /// Assigned to delegate in Form1.Designer.cs, Line: 342
        /// </summary>
        public void Reset_Record(object s, EventArgs e)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                ds.Tables[0].Rows.Clear();
            }
            listBox1.Items.Clear();
            btn_display.Enabled = true;
            lbl_action_display.Enabled = false;
        }

        /// <summary>
        /// Responds to butn_delete in publising class Form1
        /// Assigned to delegate in Form1.Designer.cs, Line: 352
        /// </summary>
        public void Delete_All_Records(object s, EventArgs e)
        {
            string dbcommand2 = "Delete * from ElevatorLog;";// SQL query to delete all records from the database
            OleDbConnection conn_2 = new OleDbConnection(dbconnection);// New db connection preparatopn for deleting data from database
            OleDbCommand comm_2 = new OleDbCommand(dbcommand2, conn_2);// New db command preparation
            OleDbDataAdapter adapter_delete = new OleDbDataAdapter(comm_2);// New adapter preparation

            MessageBox.Show("           Warning!");// Warning message pop-up
            string messageDel = "Press No to cancel or Yes to proceed.";
            string captionDel = "This will permanently delete your data from the database!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(messageDel, captionDel, buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn_2.Open();// Open second connection
                    comm_2.ExecuteNonQuery();// Execute query
                }
                catch (Exception e4)
                {
                    MessageBox.Show(e4.ToString());
                }
                conn_2.Close();// Close connection
                ds.Tables[0].Rows.Clear();
                listBox1.Items.Clear();
                MessageBox.Show("      Your data has been deleted.");// System - user feedback
            }
        }

        /// <summary>
        /// Buttons
        /// </summary>

        /// Button Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            conn.Dispose();// Releases all used resources
            Application.Exit();// Closes application
        }

        /// groupBox1 for request pannel buttons UP and DOWN on relevant floors
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        /// Button to call the lift DOWN
        private void btn_to_moveDown_Click(object sender, EventArgs e)
        {
            going_down();
            btn_to_move_down.BackColor = Color.Yellow;
            btn_to_move_up.BackColor = Color.White;
            btn_G.BackColor = Color.Yellow;
        }

        /// Button to call the lift UP
        private void btn_to_moveUP_Click(object sender, EventArgs e)
        {
            btn_to_move_up.BackColor = Color.Yellow;
            btn_to_move_down.BackColor = Color.White;
            btn_1.BackColor = Color.Yellow;
            going_up();
        }

        /// groupBox2 for control panel buttons 1 and G inside the cabin
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        /// Button 1
        private void btn_1_Click(object sender, EventArgs e)
        {
            btn_1.BackColor = Color.Yellow;
            btn_to_move_up.BackColor = Color.Yellow;
            going_up();
        }

        /// Button G
        private void btn_G_Click(object sender, EventArgs e)
        {
            btn_G.BackColor = Color.Yellow;
            btn_to_move_down.BackColor = Color.Yellow;
            going_down();
        }

        /// <summary>
        /// Shaft components
        /// </summary>
        private void picBox_shaft_Click(object sender, EventArgs e)
        {

        }

        private void shaft_up_right_door_Click(object sender, EventArgs e)
        {

        }

        private void shaft_up_left_door_Click(object sender, EventArgs e)
        {

        }

        private void shaft_down_right_door_Click(object sender, EventArgs e)
        {

        }

        private void shaft_down_left_door_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Cabin components
        /// </summary>
        private void picBox_cabin_Click(object sender, EventArgs e)
        {

        }

        private void cabin_right_door_Click(object sender, EventArgs e)
        {

        }

        private void cabin_left_door_Click(object sender, EventArgs e)
        {

        }

        private void lbl_display_floor_Click(object sender, EventArgs e)
        {

        }

        private void lbl_action_display_Click(object sender, EventArgs e)
        {

        }
    }
}
