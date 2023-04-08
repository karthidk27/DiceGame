using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class dice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Status.Text = "Match Result";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Random random = new Random();
        int Rnd1 = random.Next(1, 6);
        if (Rnd1 == 1)
        {
            Image1.ImageUrl = "~/img/1.jpg";
        }
        else if (Rnd1 == 2)
        {
            Image1.ImageUrl = "~/img/2.jpg";
        }
        else if (Rnd1 == 3)
        {
            Image1.ImageUrl = "~/img/3.jpg";
        }
        else if (Rnd1 == 4)
        {
            Image1.ImageUrl = "~/img/4.jpg";
        }
        else if (Rnd1 == 5)
        {
            Image1.ImageUrl = "~/img/5.jpg";
        }
        else
        {
            Image1.ImageUrl = "~/img/6.jpg";
        }
       
        int Rnd2 = random.Next(1, 6);
        if (Rnd2 == 1)
        {
            Image2.ImageUrl = "~/img/1.jpg";
        }
        else if (Rnd2 == 2)
        {
            Image2.ImageUrl = "~/img/2.jpg";
        }
        else if (Rnd2 == 3)
        {
            Image2.ImageUrl = "~/img/3.jpg";
        }
        else if (Rnd2 == 4)
        {
            Image2.ImageUrl = "~/img/4.jpg";
        }
        else if (Rnd2 == 5)
        {
            Image2.ImageUrl = "~/img/5.jpg";
        }
        else
        {
            Image2.ImageUrl = "~/img/6.jpg";
        }
        if (Rnd1 > Rnd2)
        {
            Status.Text = "Player 1 wins";
        }
        else if (Rnd2 > Rnd1)
        {
            Status.Text = "Player 2 Wins";
        }
        else
        {
            Status.Text = "Match draw";
        }
    }
}