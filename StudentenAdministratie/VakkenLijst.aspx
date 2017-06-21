<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VakkenLijst.aspx.cs" Inherits="StudentenAdministratie.VakkenLijst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinkButton ID="lbtnStudenten" runat="server" OnClick="lbtnStudenten_Click">Studenten Lijst</asp:LinkButton>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Vakken"></asp:Label>
        <asp:Button ID="btnNieuweVak" runat="server" OnClick="btnNieuweVak_Click" Text="Nieuwe Vak" />
        <asp:GridView ID="gvVakken" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
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
        <asp:DropDownList ID="ddlVakken" runat="server">
        </asp:DropDownList>
        <asp:Button ID="btnSelectVak" runat="server" OnClick="btnSelectVak_Click" Text="Toon klas" />
        <asp:Button ID="btnEditVak" runat="server" OnClick="btnEditVak_Click" Text="Vak bewerken" />
    </form>
</body>
</html>
