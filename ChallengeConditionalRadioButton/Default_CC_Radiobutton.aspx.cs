using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeConditionalRadioButton
{
    public partial class Default_CC_Radiobutton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton1_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";

            if (pencilRadioButton.Checked)
            {
                prefImage.ImageUrl = "https://openclipart.org/download/216413/coniglio_rabbit_small.svg";
                resultLabel.Text = "You selected Pencil.";
            }
            else if (penRadioButton.Checked)
            {
                prefImage.ImageUrl = "https://openclipart.org/download/214840/smallgroup.svg";
                resultLabel.Text = "You selected Pen.";
            }
            else if (phoneRadioButton.Checked)
            {
                prefImage.ImageUrl = "https://openclipart.org/download/214840/smallgroup.svg";
                resultLabel.Text = "You selected Phone.";
            }
            else if (tabletRadioButton.Checked)
            {
                prefImage.ImageUrl = "https://openclipart.org/download/214840/smallgroup.svg";
                resultLabel.Text = "You selected Tablet.";
            }
            else
            {
                resultLabel.Text = "Select an option.";
            }


        }
    }
}