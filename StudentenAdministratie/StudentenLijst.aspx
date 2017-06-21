<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentenLijst.aspx.cs" Inherits="StudentenAdministratie.StudentenLijst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 352px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinkButton ID="lbtnVakken" runat="server" OnClick="lbtnVakken_Click">Vakken Lijst</asp:LinkButton>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Studenten"></asp:Label>
        <asp:Button ID="btnNewStudent" runat="server" OnClick="btnNewStudent_Click" Text="Nieuwe student" />
        <asp:GridView ID="gvStudenten" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" style="height: 133px; width: 233px">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:BoundField HeaderText="Student ID" DataField="studentID" />
                
                <asp:BoundField HeaderText="Achternaam" DataField="achterNaam" />
                <asp:BoundField HeaderText="Voornaam" DataField="voorNaam" />
                <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="lbtnBewerk" runat="server" CausesValidation="false" 
                        CommandName="" PostBackUrl='<%# "http://localhost:60445/EditStudent.aspx?id=" + Eval("studentID") %>' Text='bewerken'></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
        <asp:DropDownList ID="ddlStudenten" runat="server">
        </asp:DropDownList>
        <asp:Button ID="btnShowVakken" runat="server" Text="Toon vakken" OnClick="btnShowVakken_Click" />
        <asp:Button ID="btnEditStudent" runat="server" OnClick="btnEditStudent_Click" Text="Student wijzigen" />
    </form>
</body>
</html>
