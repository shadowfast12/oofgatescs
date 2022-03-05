using oofgates.attributes;
using System;
using System.Windows.Forms;

namespace oofgates
{
    public partial class Main : Form
    {
        private int curr_event;
        private player user;

        public Main()
        {
            InitializeComponent();
            set(0);
            user = new player(100,10,2,1,10,5,5);
        }
        public Boolean set(int event_num)
        {
            curr_event=event_num;
            if (curr_event==0)
            {
                set_event_text("You have fallen into the world of oofgates... You find a Rock, Sword, & Dagger. Pick One");
                set_buttons("Rock", "Rusty Sword", "Dagger");
                return true;
            }
            if (curr_event == 1)
            {
                set_event_text("A Black Man has approached you with ihs sword drawn and demands that you give him all your money or die!");
                set_buttons("Attack","Give the Money");
                return true;
            }
            if (curr_event==2)
            {
                set_event_text("Welcome to Wuhan City, you can go to:");
                set_buttons("Shop","Forest","Casino","Arena");
            }
            return false;
        }
        private void set_buttons(string text1,string text2)
        {
            option1.Visible = true;
            option2.Visible = true;

            option1.Text = text1;
            option2.Text = text2;
        }
        private void set_buttons(string text1,string text2,string text3)
        {
            option1.Visible = true;
            option2.Visible = true;
            option3.Visible = true;

            option1.Text= text1;
            option2.Text= text2;
            option3.Text= text3;
            option4.Visible= false;
        }
        private void set_buttons(string text1,string text2,string text3,string text4)
        {
            option1.Visible= true;
            option2.Visible= true;
            option3.Visible= true;
            option4.Visible= true;

            option1.Text=text1;
            option2.Text= text2;
            option3.Text = text3;
            option4.Text= text4;
        }
        private void set_event_text(string text)
        {
            event_text.Text = text;
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void event_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void option1_Click(object sender, EventArgs e)
        {
            set_option1("JOEEEE");
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
