using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

  

    protected void onClick(object sender, EventArgs e)
    {
        Button element = sender as Button;

        result.Text = result.Text + element.Label;

    }

    protected void onClearClick(object sender, EventArgs e)
    {
        result.Text = "";
    }


    protected void onDotClick(object sender, EventArgs e)
    {
        result.Text = result.Text + " " + (sender as Button).Label + " ";
    }

    protected void onEqualClick(object sender, EventArgs e)
    {
        //handle();
    }


    private bool handle()
    {
        string query = result.Text;
        string[] temp = query.Split(' ');
        try
        {
            int n1 = int.Parse(temp[0]);
            int n2 = int.Parse(temp[2]);
            string operation = temp[1];
            if(operation == ".")
            {

            }
            double resultOperator = 0;
            switch (operation)
            {
                case "-":
                    {
                        resultOperator = n1 - n2;      
                        break;
                    }
                case "+":
                    {
                        resultOperator = n1 + n2;
                        break;
                    }
                case "x":
                    {
                        resultOperator = n1 * n2;
                        break;
                    }
                case ":": 
                    {
                        resultOperator = n1 / n2;
                        break;
                    }
            }
            result.Text = resultOperator.ToString();
            return true;
            
        }catch(Exception e) {
            Console.WriteLine(e.ToString());
            return false;
        }

    }

    protected void onOperatorClick(object sender, EventArgs e)
    {
        //handle();
            result.Text = result.Text + " " + (sender as Button).Label + " ";    
    }
}
