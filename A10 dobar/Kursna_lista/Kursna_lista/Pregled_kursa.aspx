<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Pregled_kursa.aspx.cs" Inherits="Kursna_lista.Pregled_kursa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Calendar ID="Calendar1" runat="server" style="z-index: 1; left: 74px; top: 83px; position: absolute; height: 188px; width: 259px"></asp:Calendar>
<p>
</p>
<asp:DropDownList ID="DropDownListValuta" runat="server" style="z-index: 1; left: 419px; top: 80px; position: absolute">
</asp:DropDownList>
<asp:Label ID="Label1" runat="server" style="z-index: 1; left: 12px; top: 83px; position: absolute" Text="Datum:"></asp:Label>
<asp:Label ID="Label2" runat="server" style="z-index: 1; left: 362px; top: 82px; position: absolute" Text="Valuta:"></asp:Label>
<asp:Label ID="LabelKurs" runat="server" style="z-index: 1; left: 22px; top: 303px; position: absolute"></asp:Label>
<asp:Button ID="ButtonPrikazi" runat="server" style="z-index: 1; left: 405px; top: 177px; position: absolute" Text="Prikazi kurs" OnClick="ButtonPrikazi_Click" CssClass="dugme" />
</asp:Content>
