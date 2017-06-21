<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertVak.aspx.cs" Inherits="StudentenAdministratie.InsertVak" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 118px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinkButton ID="lbtnStudenten" runat="server" style="width: 95px" OnClick="lbtnStudenten_Click">Studenten Lijst</asp:LinkButton>
    
        <asp:LinkButton ID="lbtnVakken" runat="server" style="width: 90px" OnClick="lbtnVakken_Click">Vakken Lijst</asp:LinkButton>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Vaknaam"></asp:Label>
        <asp:TextBox ID="tbVakNaam" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Vak toevoegen" />
        </p>
    </form>
</body>
</html>
