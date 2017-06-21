<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditStudent.aspx.cs" Inherits="StudentenAdministratie.EditStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 374px;
        }
    </style>
</head>
<body style="position: relative">
    <form id="form1" runat="server">
    <div>
    
        <asp:LinkButton ID="lbtnStudenten" runat="server" OnClick="lbtnStudenten_Click">Studenten Lijst</asp:LinkButton>
        <asp:LinkButton ID="lbtnVakken" runat="server" OnClick="lbtnVakken_Click">Vakken Lijst</asp:LinkButton>
    
    </div>
        <asp:Label ID="lblVoorNaam" runat="server" Text="Voornaam"></asp:Label>
        <asp:TextBox ID="tbVoorNaam" runat="server"></asp:TextBox>
        <asp:Label ID="lblAchterNaam" runat="server" Text="Achternaam"></asp:Label>
        <asp:TextBox ID="tbAchterNaam" runat="server" style="height: 20px"></asp:TextBox>
        <asp:Button ID="btnEditName" runat="server" style="bottom: -59px" Text="Naam bewerken" />
        <p>
            <asp:Label ID="Label3" runat="server" style="font-weight: 700" Text="Vakken"></asp:Label>
            <asp:GridView ID="gvVakken" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" style="height: 100px; width: 187px; margin-top: 0px; margin-bottom: 0px">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
        </p>
        <asp:DropDownList ID="ddlVakken" runat="server" style="height: -5px">
        </asp:DropDownList>
        <asp:Button ID="btnVoegVak" runat="server" OnClick="btnVoegVak_Click" Text="Voeg vak toe" />
    </form>
</body>
</html>
