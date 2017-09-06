<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default_CC_Radiobutton.aspx.cs" Inherits="ChallengeConditionalRadioButton.Default_CC_Radiobutton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your Note Taking Preferences<br />
            <br />
            <asp:RadioButton ID="pencilRadioButton" runat="server" GroupName="noteTaking" Text="Pencil" />
            <br />
            <asp:RadioButton ID="penRadioButton" runat="server" GroupName="noteTaking" Text="Pen" />
            <br />
            <asp:RadioButton ID="phoneRadioButton" runat="server" GroupName="noteTaking" Text="Phone" />
            <br />
            <asp:RadioButton ID="tabletRadioButton" runat="server" GroupName="noteTaking" Text="Tablet" />
            <br />
            <br />
            <asp:Button ID="okButton1" runat="server" OnClick="okButton1_Click" Text="OK" />
            <br />
            <br />
            <asp:Image ID="prefImage" runat="server" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
