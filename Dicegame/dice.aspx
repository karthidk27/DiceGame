<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dice.aspx.cs" Inherits="dice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
               text-align:center;
               background-image:url('img/bp.jpg');
               background-repeat: no-repeat;
               background-size: 100% 100%;
               background-attachment: fixed;
             }
        #Button1
        {
            border: none;
            color: white;
            padding: 15px 32px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            margin: 4px 2px;
            cursor: pointer;
            background-color: #e7e7e7; 
            color: black;
            margin-top:15%;
        }
        
        #Image2
        {
            margin-left:10%;
        }
        
    </style>
</head>
<body>
     <form id="form1" runat="server" >
            <h1><asp:Label ID="Title" runat="server" Text="Dice Game" style="color:green;"></asp:Label></h1>
            <br />
            <asp:Image ID="Image1" runat="server" ImageUrl="~/img/1.jpg" />
            <asp:Image ID="Image2" runat="server" ImageUrl="~/img/1.jpg" />
            <br />



            <h2><asp:Label ID="Status" runat="server" style="color:brown;"></asp:Label></h2>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Roll the Dice" style="" />
   
        
    </form>
</body>
</html>
