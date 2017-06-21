<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowVakkenVanStudent.aspx.cs" Inherits="StudentenAdministratie.ShowVakkenVanStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 273px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinkButton ID="lbtnStudenten" runat="server" OnClick="lbtnStudenten_Click" style="right: 715px">Studenten Lijst</asp:LinkButton>
        <asp:LinkButton ID="lbtnVakken" runat="server" OnClick="lbtnVakken_Click" style="width: 95px">Vakken Lijst</asp:LinkButton>
    
    </div>
    
        <asp:Label ID="lblStudentNaam" runat="server" Text="404"></asp:Label>
    
        <asp:GridView ID="gvStudentVakken" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" style="height: 133px; width: 187px">
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
    </form>
</body>
</html>
