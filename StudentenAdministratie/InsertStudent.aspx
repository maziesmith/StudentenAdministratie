<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertStudent.aspx.cs" Inherits="StudentenAdministratie.InsertStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text2 {
            margin-left: 27px;
        }
        #inpAchterNaam {
            margin-left: 27px;
        }
        #form1 {
            height: 418px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinkButton ID="lbtnStudenten" runat="server" OnClick="lbtnStudenten_Click">Studenten Lijst</asp:LinkButton>
        <asp:LinkButton ID="lbtnVakken" runat="server" OnClick="lbtnVakken_Click">Vakken Lijst</asp:LinkButton>
    
    </div>
        <p>
            <asp:Label ID="lblVoorNaam" runat="server" Text="Voornaam"></asp:Label>
            <asp:TextBox ID="tbVoorNaam" runat="server" style="margin-left: 45px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblAchterNaam" runat="server" Text="Achternaam"></asp:Label>
            <asp:TextBox ID="tbAchterNaam" runat="server" style="margin-left: 34px"></asp:TextBox>
        </p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Voegtoe" />
    </form>
</body>
</html>
