using System;
using System.Windows.Forms;

namespace FirstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        Employee employee;
        bool newRequestIsClicked = false;
        bool newResponseIsCopyed = false;
        object order = null;

        private void button1_Click(object sender, EventArgs e)
        {
            string menuItem = "";
            int quantity = Convert.ToInt32(txtquantity.Text);

            try
            {
                if (rbnEgg.Checked && quantity > 0 || rbnChicken.Checked && quantity > 0)
                {
                    if (rbnEgg.Checked)
                        menuItem = "egg";

                    else if (rbnChicken.Checked)
                        menuItem = "chicken";

                    employee = new Employee();
                    order = employee.NewRequest(quantity, menuItem);

                    txtquality.Text = employee.Inspect(order);
                    newRequestIsClicked = true;
                }
                else
                    throw new Exception("Please first get the order");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (newRequestIsClicked || newResponseIsCopyed)
                {
                    order = employee.CopyOrder();
                    MessageBox.Show("Order was copied");
                     newRequestIsClicked= newResponseIsCopyed;
                    
                }
                else
                    throw new Exception("Not ordered yet");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (newRequestIsClicked)
                {
                    listBOrder.Items.Add(employee.PrepareFood(order));
                     newRequestIsClicked = false;
                    newResponseIsCopyed = true;
                }
                else
                    throw new Exception("First get order");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
