<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Program.aspx.cs" Inherits="TV_program.Program" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 20px; top: 65px; position: absolute" Text="Datum:"></asp:Label>
<p style="height: 250px; width: 587px">
</p>
<asp:Label ID="Label2" runat="server" style="z-index: 1; left: 21px; top: 112px; position: absolute" Text="Tip emisije:"></asp:Label>
<asp:DropDownList ID="DropDownListDatum" runat="server" style="z-index: 1; left: 130px; top: 62px; position: absolute">
    <asp:ListItem>18.05.2020</asp:ListItem>
    <asp:ListItem>19.05.2020</asp:ListItem>
</asp:DropDownList>
<asp:DropDownList ID="DropDownListTip" runat="server" style="z-index: 1; left: 129px; top: 109px; position: absolute">
    <asp:ListItem>Crtani</asp:ListItem>
    <asp:ListItem>Dokumentarac</asp:ListItem>
    <asp:ListItem>Film</asp:ListItem>
    <asp:ListItem>Serija</asp:ListItem>
    <asp:ListItem>Reality</asp:ListItem>
</asp:DropDownList>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 318px; top: 65px; position: absolute; height: 133px; width: 187px">
    <Columns>
        <asp:BoundField DataField="Vreme" HeaderText="Vreme emitovanja" />
        <asp:BoundField DataField="Emisija" HeaderText="Emisija" />
        <asp:ImageField DataImageUrlField="Slika" HeaderText="Tip emisije">
        </asp:ImageField>
    </Columns>
</asp:GridView>
<asp:Button ID="ButtonTrazi" runat="server" OnClick="ButtonTrazi_Click" style="z-index: 1; left: 102px; top: 177px; position: absolute" Text="Trazi" CssClass="dugme" />
</asp:Content>
