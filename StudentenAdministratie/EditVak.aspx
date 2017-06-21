<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditVak.aspx.cs" Inherits="StudentenAdministratie.EditVak" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 252px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinkButton ID="lbtnStudenten" runat="server" OnClick="lbtnStudenten_Click">Studenten Lijst</asp:LinkButton>
        <asp:LinkButton ID="lbtnVakken" runat="server" OnClick="lbtnVakken_Click">Vakken Lijst</asp:LinkButton>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Vaknaam"></asp:Label>
        <asp:TextBox ID="tbVakNaam" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Wijzigen" />
        </p>
    </form>
</body>
</html>
