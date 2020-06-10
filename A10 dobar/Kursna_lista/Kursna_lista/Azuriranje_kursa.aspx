<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Azuriranje_kursa.aspx.cs" Inherits="Kursna_lista.Azuriranje_kursa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Calendar ID="Calendar1" runat="server" style="z-index: 1; left: 70px; top: 83px; position: absolute; height: 188px; width: 259px"></asp:Calendar>
<p>
</p>
<asp:Label ID="Label1" runat="server" style="z-index: 1; left: 14px; top: 90px; position: absolute" Text="Datum:"></asp:Label>
<asp:Label ID="Label2" runat="server" style="z-index: 1; left: 357px; top: 89px; position: absolute" Text="Valuta:"></asp:Label>
<asp:DropDownList ID="DropDownListValuta" runat="server" style="z-index: 1; left: 417px; top: 89px; position: absolute">
</asp:DropDownList>
<asp:Label ID="Label3" runat="server" style="z-index: 1; left: 358px; top: 130px; position: absolute" Text="Kurs:"></asp:Label>
<asp:TextBox ID="TextBoxKurs" runat="server" style="z-index: 1; left: 418px; top: 130px; position: absolute; width: 67px" CssClass="dugme"></asp:TextBox>
<asp:Button ID="ButtonUpisi" runat="server" OnClick="ButtonUpisi_Click" style="z-index: 1; left: 383px; top: 207px; position: absolute" Text="Upisi kurs" CssClass="dugme" />
</asp:Content>
