<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowStudentenVanVak.aspx.cs" Inherits="StudentenAdministratie.ShowStudentenVanVak" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 424px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" Text="404" style="z-index: 1; left: 10px; top: 34px; position: absolute"></asp:Label>
    <div>
    
    </div>
        <asp:GridView ID="gvStuVaLijst" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" style="z-index: 1; left: 16px; top: 56px; position: absolute; height: 133px; width: 187px; right: 625px">
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
        <asp:LinkButton ID="lbtnVakken" runat="server" OnClick="lbtnVakken_Click" style="z-index: 1; top: 16px; position: absolute; width: 100px; left: 111px">Vakken Lijst</asp:LinkButton>
        <asp:LinkButton ID="lbtnStudenten" runat="server" OnClick="lbtnStudenten_Click" style="z-index: 1; top: 16px; position: absolute; left: 10px">Studenten Lijst</asp:LinkButton>
    </form>
</body>
</html>
