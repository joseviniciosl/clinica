/*
               File: Vendedor
        Description: Vendedores
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:7:17.54
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class vendedor : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false ;
         gxfirstwebparm = GetNextPar( ) ;
         gxfirstwebparm_bkp = gxfirstwebparm ;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm, "High") ;
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"TIPOVENDEDORID") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            GXDLATIPOVENDEDORID1M74( A41ClinicaCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_6") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A370TipoVendedorId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370TipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_6( A41ClinicaCodigo, A370TipoVendedorId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = GetNextPar( ) ;
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp ;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         dynTipoVendedorId.Name = "TIPOVENDEDORID" ;
         dynTipoVendedorId.WebTags = "" ;
         cmbVendedorEstado.Name = "VENDEDORESTADO" ;
         cmbVendedorEstado.WebTags = "" ;
         cmbVendedorEstado.addItem("0", "De baja", 0);
         cmbVendedorEstado.addItem("1", "Activo", 0);
         if ( ( cmbVendedorEstado.ItemCount > 0 ) && (0==A325VendedorEstado) )
         {
            A325VendedorEstado = (short)(NumberUtil.Val( cmbVendedorEstado.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A325VendedorEstado", StringUtil.Str( (decimal)(A325VendedorEstado), 1, 0));
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Vendedores", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtClinicaCodigo_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Fantastic");
      }

      public vendedor( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public vendedor( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynTipoVendedorId = new GXCombobox();
         cmbVendedorEstado = new GXCombobox();
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("appmasterpage", "GeneXus.Programs.appmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            MasterPageObj.webExecute();
            if ( context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            wb_table1_2_1M74( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1M74e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1M74( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1M74( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1M74e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Vendedores"+"</legend>") ;
            wb_table3_27_1M74( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_1M74e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1M74e( true) ;
         }
         else
         {
            wb_table1_2_1M74e( false) ;
         }
      }

      protected void wb_table3_27_1M74( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table4_33_1M74( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_1M74e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Vendedor.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Vendedor.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Vendedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_1M74e( true) ;
         }
         else
         {
            wb_table3_27_1M74e( false) ;
         }
      }

      protected void wb_table4_33_1M74( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", lblTextblockclinicacodigo_Visible, 1, 0, "HLP_Vendedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", edtClinicaCodigo_Visible, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Vendedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockvendedorcodigo_Internalname, "Vendedor", "", "", lblTextblockvendedorcodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Vendedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317VendedorCodigo", A317VendedorCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtVendedorCodigo_Internalname, StringUtil.RTrim( A317VendedorCodigo), StringUtil.RTrim( context.localUtil.Format( A317VendedorCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtVendedorCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtVendedorCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Vendedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockvendedornombre_Internalname, "Nombre", "", "", lblTextblockvendedornombre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Vendedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318VendedorNombre", A318VendedorNombre);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtVendedorNombre_Internalname, StringUtil.RTrim( A318VendedorNombre), StringUtil.RTrim( context.localUtil.Format( A318VendedorNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", "", "", "", edtVendedorNombre_Jsonclick, 0, ClassString, StyleString, "", 1, edtVendedorNombre_Enabled, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_Vendedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipovendedorid_Internalname, "Descripción", "", "", lblTextblocktipovendedorid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Vendedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370TipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0)));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynTipoVendedorId, dynTipoVendedorId_Internalname, StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0), 1, dynTipoVendedorId_Jsonclick, 0, "", "int", "", 1, dynTipoVendedorId.Enabled, 0, 0, 70, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "", true, "HLP_Vendedor.htm");
            dynTipoVendedorId.CurrentValue = StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTipoVendedorId_Internalname, "Values", (String)(dynTipoVendedorId.ToJavascriptSource()));
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_370_Internalname, "prompt.gif", imgprompt_41_370_Link, "", "", "Fantastic", imgprompt_41_370_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Vendedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockvendedorestado_Internalname, "Estado", "", "", lblTextblockvendedorestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Vendedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A325VendedorEstado", StringUtil.Str( (decimal)(A325VendedorEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbVendedorEstado, cmbVendedorEstado_Internalname, StringUtil.Str( (decimal)(A325VendedorEstado), 1, 0), 1, cmbVendedorEstado_Jsonclick, 0, "", "int", "", 1, cmbVendedorEstado.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", "", true, "HLP_Vendedor.htm");
            cmbVendedorEstado.CurrentValue = StringUtil.Str( (decimal)(A325VendedorEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbVendedorEstado_Internalname, "Values", (String)(cmbVendedorEstado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_1M74e( true) ;
         }
         else
         {
            wb_table4_33_1M74e( false) ;
         }
      }

      protected void wb_table2_5_1M74( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTabletoolbar_Internalname, tblTabletoolbar_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "<div style=\"WHITE-SPACE: nowrap\" class=\"ToolbarMain\">") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Vendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Vendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Vendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Vendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Vendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Vendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Vendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Vendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0220.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"VENDEDORCODIGO"+"'), id:'"+"VENDEDORCODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Vendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0220.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"VENDEDORCODIGO"+"'), id:'"+"VENDEDORCODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Vendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Vendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Vendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Vendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Vendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Vendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Vendedor.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_1M74e( true) ;
         }
         else
         {
            wb_table2_5_1M74e( false) ;
         }
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E111M2 */
         E111M2 ();
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A317VendedorCodigo = cgiGet( edtVendedorCodigo_Internalname) ;
               n317VendedorCodigo = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317VendedorCodigo", A317VendedorCodigo);
               A318VendedorNombre = cgiGet( edtVendedorNombre_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318VendedorNombre", A318VendedorNombre);
               dynTipoVendedorId.CurrentValue = cgiGet( dynTipoVendedorId_Internalname) ;
               A370TipoVendedorId = (int)(NumberUtil.Val( cgiGet( dynTipoVendedorId_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370TipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0)));
               cmbVendedorEstado.CurrentValue = cgiGet( cmbVendedorEstado_Internalname) ;
               A325VendedorEstado = (short)(NumberUtil.Val( cgiGet( cmbVendedorEstado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A325VendedorEstado", StringUtil.Str( (decimal)(A325VendedorEstado), 1, 0));
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z317VendedorCodigo = cgiGet( "Z317VendedorCodigo") ;
               Z318VendedorNombre = cgiGet( "Z318VendedorNombre") ;
               Z325VendedorEstado = (short)(context.localUtil.CToN( cgiGet( "Z325VendedorEstado"), ".", ",")) ;
               Z370TipoVendedorId = (int)(context.localUtil.CToN( cgiGet( "Z370TipoVendedorId"), ".", ",")) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV7ClinicaCodigo = cgiGet( "vCLINICACODIGO") ;
               Gx_mode = cgiGet( "vMODE") ;
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  A41ClinicaCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
                  A317VendedorCodigo = GetNextPar( ) ;
                  n317VendedorCodigo = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317VendedorCodigo", A317VendedorCodigo);
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons_dsp( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal( ) ;
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName") ;
            EvtGridId = cgiGet( "_EventGridId") ;
            EvtRowId = cgiGet( "_EventRowId") ;
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1) ;
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1) ;
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E111M2 */
                           E111M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_first( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_previous( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_next( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_last( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_select( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_delete( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1 ;
                           AfterKeyLoadScreen( ) ;
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1 ;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll1M74( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            imgBtn_delete2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
      }

      protected void disable_std_buttons_dsp( )
      {
         imgBtn_delete2_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Visible), 5, 0)));
         imgBtn_delete2_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_separator_Visible), 5, 0)));
         bttBtn_delete_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         imgBtn_first_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_first_Visible), 5, 0)));
         imgBtn_first_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_first_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_first_separator_Visible), 5, 0)));
         imgBtn_previous_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_previous_Visible), 5, 0)));
         imgBtn_previous_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_previous_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_previous_separator_Visible), 5, 0)));
         imgBtn_next_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_next_Visible), 5, 0)));
         imgBtn_next_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_next_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_next_separator_Visible), 5, 0)));
         imgBtn_last_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_last_Visible), 5, 0)));
         imgBtn_last_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_last_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_last_separator_Visible), 5, 0)));
         imgBtn_select_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_select_Visible), 5, 0)));
         imgBtn_select_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_select_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_select_separator_Visible), 5, 0)));
         imgBtn_delete2_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Visible), 5, 0)));
         imgBtn_delete2_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_separator_Visible), 5, 0)));
         bttBtn_delete_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            imgBtn_enter2_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Visible), 5, 0)));
            imgBtn_enter2_separator_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_separator_Visible), 5, 0)));
            bttBtn_enter_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
         }
         DisableAttributes1M74( ) ;
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "");
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "");
            }
         }
      }

      protected void ResetCaption1M0( )
      {
      }

      protected void E111M2( )
      {
         /* Start Routine */
         GXt_SdtParametros3 = AV8Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros3) ;
         AV8Parametros = GXt_SdtParametros3 ;
         AV7ClinicaCodigo = AV8Parametros.gxTpr_Pclinicacodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ClinicaCodigo", AV7ClinicaCodigo);
      }

      protected void ZM1M74( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z318VendedorNombre = T001M3_A318VendedorNombre[0] ;
               Z325VendedorEstado = T001M3_A325VendedorEstado[0] ;
               Z370TipoVendedorId = T001M3_A370TipoVendedorId[0] ;
            }
            else
            {
               Z318VendedorNombre = A318VendedorNombre ;
               Z325VendedorEstado = A325VendedorEstado ;
               Z370TipoVendedorId = A370TipoVendedorId ;
            }
         }
         if ( GX_JID == -5 )
         {
            Z317VendedorCodigo = A317VendedorCodigo ;
            Z318VendedorNombre = A318VendedorNombre ;
            Z325VendedorEstado = A325VendedorEstado ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z370TipoVendedorId = A370TipoVendedorId ;
         }
      }

      protected void standaloneNotModal( )
      {
         lblTextblockclinicacodigo_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTextblockclinicacodigo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblTextblockclinicacodigo_Visible), 5, 0)));
         edtClinicaCodigo_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Visible), 5, 0)));
         imgprompt_41_370_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0240.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"TIPOVENDEDORID"+"'), id:'"+"TIPOVENDEDORID"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
         A41ClinicaCodigo = AV7ClinicaCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            imgBtn_delete2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_delete2_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            imgBtn_enter2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_enter2_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            GXATIPOVENDEDORID_html1M74( A41ClinicaCodigo) ;
         }
      }

      protected void Load1M74( )
      {
         /* Using cursor T001M5 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, n317VendedorCodigo, A317VendedorCodigo});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound74 = 1 ;
            A318VendedorNombre = T001M5_A318VendedorNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318VendedorNombre", A318VendedorNombre);
            A325VendedorEstado = T001M5_A325VendedorEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A325VendedorEstado", StringUtil.Str( (decimal)(A325VendedorEstado), 1, 0));
            A370TipoVendedorId = T001M5_A370TipoVendedorId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370TipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0)));
            ZM1M74( -5) ;
         }
         pr_default.close(3);
         OnLoadActions1M74( ) ;
      }

      protected void OnLoadActions1M74( )
      {
         GXATIPOVENDEDORID_html1M74( A41ClinicaCodigo) ;
      }

      protected void CheckExtendedTable1M74( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T001M4 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo, A370TipoVendedorId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError41 = 1 ;
            AnyError370 = 1 ;
            GX_msglist.addItem("No existe 'Tipo Vendedor'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError370 == 0 ) )
         {
         }
         pr_default.close(2);
         GXATIPOVENDEDORID_html1M74( A41ClinicaCodigo) ;
      }

      protected void CloseExtendedTableCursors1M74( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_6( String A41ClinicaCodigo ,
                               int A370TipoVendedorId )
      {
         /* Using cursor T001M6 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo, A370TipoVendedorId});
         if ( (pr_default.getStatus(4) == 101) )
         {
            AnyError41 = 1 ;
            AnyError370 = 1 ;
            GX_msglist.addItem("No existe 'Tipo Vendedor'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError370 == 0 ) )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(4);
      }

      protected void GetKey1M74( )
      {
         /* Using cursor T001M7 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, n317VendedorCodigo, A317VendedorCodigo});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound74 = 1 ;
         }
         else
         {
            RcdFound74 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001M3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, n317VendedorCodigo, A317VendedorCodigo});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1M74( 5) ;
            RcdFound74 = 1 ;
            A317VendedorCodigo = T001M3_A317VendedorCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317VendedorCodigo", A317VendedorCodigo);
            n317VendedorCodigo = T001M3_n317VendedorCodigo[0] ;
            A318VendedorNombre = T001M3_A318VendedorNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318VendedorNombre", A318VendedorNombre);
            A325VendedorEstado = T001M3_A325VendedorEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A325VendedorEstado", StringUtil.Str( (decimal)(A325VendedorEstado), 1, 0));
            A41ClinicaCodigo = T001M3_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A370TipoVendedorId = T001M3_A370TipoVendedorId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370TipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0)));
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z317VendedorCodigo = A317VendedorCodigo ;
            sMode74 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1M74( ) ;
            Gx_mode = sMode74 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound74 = 0 ;
            InitializeNonKey1M74( ) ;
            sMode74 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode74 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1M74( ) ;
         if ( RcdFound74 == 0 )
         {
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound74 = 0 ;
         /* Using cursor T001M8 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, n317VendedorCodigo, A317VendedorCodigo});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T001M8_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001M8_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001M8_A317VendedorCodigo[0], A317VendedorCodigo) < 0 ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T001M8_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001M8_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001M8_A317VendedorCodigo[0], A317VendedorCodigo) > 0 ) ) )
            {
               A41ClinicaCodigo = T001M8_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A317VendedorCodigo = T001M8_A317VendedorCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317VendedorCodigo", A317VendedorCodigo);
               n317VendedorCodigo = T001M8_n317VendedorCodigo[0] ;
               RcdFound74 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound74 = 0 ;
         /* Using cursor T001M9 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, n317VendedorCodigo, A317VendedorCodigo});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T001M9_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001M9_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001M9_A317VendedorCodigo[0], A317VendedorCodigo) > 0 ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T001M9_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001M9_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001M9_A317VendedorCodigo[0], A317VendedorCodigo) < 0 ) ) )
            {
               A41ClinicaCodigo = T001M9_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A317VendedorCodigo = T001M9_A317VendedorCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317VendedorCodigo", A317VendedorCodigo);
               n317VendedorCodigo = T001M9_n317VendedorCodigo[0] ;
               RcdFound74 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1M74( ) ;
         if ( RcdFound74 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A317VendedorCodigo, Z317VendedorCodigo) != 0 ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A317VendedorCodigo = Z317VendedorCodigo ;
               n317VendedorCodigo = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317VendedorCodigo", A317VendedorCodigo);
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               Gx_mode = "UPD" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Update record */
               Update1M74( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A317VendedorCodigo, Z317VendedorCodigo) != 0 ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert1M74( ) ;
               if ( AnyError == 1 )
               {
                  GX_FocusControl = "" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "CLINICACODIGO");
                  AnyError = 1 ;
                  GX_FocusControl = edtClinicaCodigo_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtClinicaCodigo_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1M74( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A317VendedorCodigo, Z317VendedorCodigo) != 0 ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A317VendedorCodigo = Z317VendedorCodigo ;
            n317VendedorCodigo = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317VendedorCodigo", A317VendedorCodigo);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         if ( RcdFound74 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtVendedorNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1M74( ) ;
         if ( RcdFound74 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtVendedorNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1M74( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound74 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtVendedorNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_next( ) ;
         if ( RcdFound74 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtVendedorNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1M74( ) ;
         if ( RcdFound74 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound74 != 0 )
            {
               ScanNext1M74( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtVendedorNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1M74( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1M74( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001M10 */
            pr_default.execute(8, new Object[] {A41ClinicaCodigo, n317VendedorCodigo, A317VendedorCodigo});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Vendedor"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(8) == 101) || ( StringUtil.StrCmp(Z318VendedorNombre, T001M10_A318VendedorNombre[0]) != 0 ) || ( Z325VendedorEstado != T001M10_A325VendedorEstado[0] ) || ( Z370TipoVendedorId != T001M10_A370TipoVendedorId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Vendedor"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1M74( )
      {
         BeforeValidate1M74( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1M74( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1M74( 0) ;
            CheckOptimisticConcurrency1M74( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1M74( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1M74( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001M11 */
                     pr_default.execute(9, new Object[] {n317VendedorCodigo, A317VendedorCodigo, A318VendedorNombre, A325VendedorEstado, A41ClinicaCodigo, A370TipoVendedorId});
                     pr_default.close(9);
                     if ( (pr_default.getStatus(9) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1 ;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                           ResetCaption1M0( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
            else
            {
               Load1M74( ) ;
            }
            EndLevel1M74( ) ;
         }
         CloseExtendedTableCursors1M74( ) ;
      }

      protected void Update1M74( )
      {
         BeforeValidate1M74( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1M74( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1M74( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1M74( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1M74( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001M12 */
                     pr_default.execute(10, new Object[] {A318VendedorNombre, A325VendedorEstado, A370TipoVendedorId, A41ClinicaCodigo, n317VendedorCodigo, A317VendedorCodigo});
                     pr_default.close(10);
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Vendedor"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1M74( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                           ResetCaption1M0( ) ;
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
            EndLevel1M74( ) ;
         }
         CloseExtendedTableCursors1M74( ) ;
      }

      protected void DeferredUpdate1M74( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1M74( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1M74( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1M74( ) ;
            AfterConfirm1M74( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1M74( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001M13 */
                  pr_default.execute(11, new Object[] {A41ClinicaCodigo, n317VendedorCodigo, A317VendedorCodigo});
                  pr_default.close(11);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound74 == 0 )
                        {
                           InitAll1M74( ) ;
                           Gx_mode = "INS" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), 0, "");
                        ResetCaption1M0( ) ;
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
         }
         sMode74 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1M74( ) ;
         Gx_mode = sMode74 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1M74( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            GXATIPOVENDEDORID_html1M74( A41ClinicaCodigo) ;
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T001M14 */
            pr_default.execute(12, new Object[] {A41ClinicaCodigo, n317VendedorCodigo, A317VendedorCodigo});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Nota de ingreso del paciente"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(12);
         }
      }

      protected void EndLevel1M74( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1M74( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(6);
            context.CommitDataStores("Vendedor");
            if ( AnyError == 0 )
            {
               ConfirmValues1M0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(6);
            context.RollbackDataStores("Vendedor");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1M74( )
      {
         /* Using cursor T001M15 */
         pr_default.execute(13);
         RcdFound74 = 0 ;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound74 = 1 ;
            A41ClinicaCodigo = T001M15_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A317VendedorCodigo = T001M15_A317VendedorCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317VendedorCodigo", A317VendedorCodigo);
            n317VendedorCodigo = T001M15_n317VendedorCodigo[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1M74( )
      {
         pr_default.readNext(13);
         RcdFound74 = 0 ;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound74 = 1 ;
            A41ClinicaCodigo = T001M15_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A317VendedorCodigo = T001M15_A317VendedorCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317VendedorCodigo", A317VendedorCodigo);
            n317VendedorCodigo = T001M15_n317VendedorCodigo[0] ;
         }
      }

      protected void ScanEnd1M74( )
      {
      }

      protected void AfterConfirm1M74( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1M74( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1M74( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1M74( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1M74( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1M74( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1M74( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtVendedorCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVendedorCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVendedorCodigo_Enabled), 5, 0)));
         edtVendedorNombre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVendedorNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVendedorNombre_Enabled), 5, 0)));
         dynTipoVendedorId.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTipoVendedorId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynTipoVendedorId.Enabled), 5, 0)));
         cmbVendedorEstado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbVendedorEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbVendedorEstado.Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1M0( )
      {
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      public override void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ! context.isSmartDevice( ) )
         {
            context.AddJavascriptSource("gxgral.js", "?58720");
            context.AddJavascriptSource("gxcfg.js", "?58720");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?58720");
            context.AddJavascriptSource("gxfxSD.js", "?58720");
            context.AddJavascriptSource("gxtypesSD.js", "?58720");
            context.AddJavascriptSource("gxpopupSD.js", "?58720");
            context.AddJavascriptSource("gxfrmutlSD.js", "?58720");
            context.AddJavascriptSource("gxgridSD.js", "?58720");
            context.AddJavascriptSource("JavaScripTableSD.js", "?58720");
            context.AddJavascriptSource("rijndaelSD.js", "?58720");
            context.AddJavascriptSource("gxgralSD.js", "?58720");
            context.AddJavascriptSource("gxcfg.js", "?58720");
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+";") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background-image:url("+context.convertURL( Form.Background)+")") ;
         }
         context.WriteHtmlText( "\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("vendedor.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z317VendedorCodigo", StringUtil.RTrim( Z317VendedorCodigo));
         GxWebStd.gx_hidden_field( context, "Z318VendedorNombre", StringUtil.RTrim( Z318VendedorNombre));
         GxWebStd.gx_hidden_field( context, "Z325VendedorEstado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z325VendedorEstado), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z370TipoVendedorId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z370TipoVendedorId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vCLINICACODIGO", StringUtil.RTrim( AV7ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         Draw( ) ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Vendedor" ;
      }

      public override String GetPgmdesc( )
      {
         return "Vendedores" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("vendedor.aspx")  ;
      }

      protected void InitializeNonKey1M74( )
      {
         A318VendedorNombre = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318VendedorNombre", A318VendedorNombre);
         A370TipoVendedorId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370TipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0)));
         A325VendedorEstado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A325VendedorEstado", StringUtil.Str( (decimal)(A325VendedorEstado), 1, 0));
      }

      protected void InitAll1M74( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A317VendedorCodigo = "" ;
         n317VendedorCodigo = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317VendedorCodigo", A317VendedorCodigo);
         InitializeNonKey1M74( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?157196");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("vendedor.js", "?157196");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         imgBtn_first_Internalname = "BTN_FIRST" ;
         imgBtn_first_separator_Internalname = "BTN_FIRST_SEPARATOR" ;
         imgBtn_previous_Internalname = "BTN_PREVIOUS" ;
         imgBtn_previous_separator_Internalname = "BTN_PREVIOUS_SEPARATOR" ;
         imgBtn_next_Internalname = "BTN_NEXT" ;
         imgBtn_next_separator_Internalname = "BTN_NEXT_SEPARATOR" ;
         imgBtn_last_Internalname = "BTN_LAST" ;
         imgBtn_last_separator_Internalname = "BTN_LAST_SEPARATOR" ;
         imgBtn_select_Internalname = "BTN_SELECT" ;
         imgBtn_select_separator_Internalname = "BTN_SELECT_SEPARATOR" ;
         imgBtn_enter2_Internalname = "BTN_ENTER2" ;
         imgBtn_enter2_separator_Internalname = "BTN_ENTER2_SEPARATOR" ;
         imgBtn_cancel2_Internalname = "BTN_CANCEL2" ;
         imgBtn_cancel2_separator_Internalname = "BTN_CANCEL2_SEPARATOR" ;
         imgBtn_delete2_Internalname = "BTN_DELETE2" ;
         imgBtn_delete2_separator_Internalname = "BTN_DELETE2_SEPARATOR" ;
         tblTabletoolbar_Internalname = "TABLETOOLBAR" ;
         lblTextblockclinicacodigo_Internalname = "TEXTBLOCKCLINICACODIGO" ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO" ;
         lblTextblockvendedorcodigo_Internalname = "TEXTBLOCKVENDEDORCODIGO" ;
         edtVendedorCodigo_Internalname = "VENDEDORCODIGO" ;
         lblTextblockvendedornombre_Internalname = "TEXTBLOCKVENDEDORNOMBRE" ;
         edtVendedorNombre_Internalname = "VENDEDORNOMBRE" ;
         lblTextblocktipovendedorid_Internalname = "TEXTBLOCKTIPOVENDEDORID" ;
         dynTipoVendedorId_Internalname = "TIPOVENDEDORID" ;
         lblTextblockvendedorestado_Internalname = "TEXTBLOCKVENDEDORESTADO" ;
         cmbVendedorEstado_Internalname = "VENDEDORESTADO" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_370_Internalname = "PROMPT_41_370" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Vendedores" ;
         imgBtn_delete2_separator_Visible = 1 ;
         imgBtn_delete2_Enabled = 1 ;
         imgBtn_delete2_Visible = 1 ;
         imgBtn_cancel2_separator_Visible = 1 ;
         imgBtn_cancel2_Visible = 1 ;
         imgBtn_enter2_separator_Visible = 1 ;
         imgBtn_enter2_Enabled = 1 ;
         imgBtn_enter2_Visible = 1 ;
         imgBtn_select_separator_Visible = 1 ;
         imgBtn_select_Visible = 1 ;
         imgBtn_last_separator_Visible = 1 ;
         imgBtn_last_Visible = 1 ;
         imgBtn_next_separator_Visible = 1 ;
         imgBtn_next_Visible = 1 ;
         imgBtn_previous_separator_Visible = 1 ;
         imgBtn_previous_Visible = 1 ;
         imgBtn_first_separator_Visible = 1 ;
         imgBtn_first_Visible = 1 ;
         cmbVendedorEstado_Jsonclick = "" ;
         cmbVendedorEstado.Enabled = 1 ;
         imgprompt_41_370_Visible = 1 ;
         imgprompt_41_370_Link = "" ;
         dynTipoVendedorId_Jsonclick = "" ;
         dynTipoVendedorId.Enabled = 1 ;
         edtVendedorNombre_Jsonclick = "" ;
         edtVendedorNombre_Enabled = 1 ;
         edtVendedorCodigo_Jsonclick = "" ;
         edtVendedorCodigo_Enabled = 1 ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtClinicaCodigo_Enabled = 1 ;
         edtClinicaCodigo_Visible = 1 ;
         lblTextblockclinicacodigo_Visible = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         GXATIPOVENDEDORID_html1M74( A41ClinicaCodigo) ;
         /* End function dynload_actions */
      }

      protected void GXDLATIPOVENDEDORID1M74( String A41ClinicaCodigo )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLATIPOVENDEDORID_data1M74( A41ClinicaCodigo) ;
         gxdynajaxindex = 1 ;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( gxdynajaxctrlcodr.Item(gxdynajaxindex))+"\",d:\""+GXUtil.EncodeJSConstant( gxdynajaxctrldescr.Item(gxdynajaxindex))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
            gxwrpcisep = "," ;
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXATIPOVENDEDORID_html1M74( String A41ClinicaCodigo )
      {
         int gxdynajaxvalue ;
         GXDLATIPOVENDEDORID_data1M74( A41ClinicaCodigo) ;
         gxdynajaxindex = 1 ;
         dynTipoVendedorId.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (int)(NumberUtil.Val( gxdynajaxctrlcodr.Item(gxdynajaxindex), ".")) ;
            dynTipoVendedorId.addItem(StringUtil.Str( (decimal)(gxdynajaxvalue), 9, 0), gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
      }

      protected void GXDLATIPOVENDEDORID_data1M74( String A41ClinicaCodigo )
      {
         /* Using cursor T001M16 */
         pr_default.execute(14, new Object[] {A41ClinicaCodigo});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(14) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T001M16_A370TipoVendedorId[0]), 9, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T001M16_A371TipoVendedorNombre[0]));
            pr_default.readNext(14);
         }
         pr_default.close(14);
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         GX_FocusControl = edtVendedorNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Clinicacodigo( String GX_Parm1 ,
                                       GXCombobox dynGX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         dynTipoVendedorId = dynGX_Parm2 ;
         A370TipoVendedorId = (int)(NumberUtil.Val( dynTipoVendedorId.CurrentValue, ".")) ;
         GXATIPOVENDEDORID_html1M74( A41ClinicaCodigo) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         dynTipoVendedorId.CurrentValue = StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0) ;
         isValidOutput.Add((Object)(dynTipoVendedorId));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Vendedorcodigo( String GX_Parm1 ,
                                        String GX_Parm2 ,
                                        String GX_Parm3 ,
                                        String GX_Parm4 ,
                                        GXCombobox cmbGX_Parm5 ,
                                        GXCombobox dynGX_Parm6 )
      {
         AV7ClinicaCodigo = GX_Parm1 ;
         A41ClinicaCodigo = GX_Parm2 ;
         A317VendedorCodigo = GX_Parm3 ;
         n317VendedorCodigo = false ;
         A318VendedorNombre = GX_Parm4 ;
         cmbVendedorEstado = cmbGX_Parm5 ;
         A325VendedorEstado = (short)(NumberUtil.Val( cmbVendedorEstado.CurrentValue, ".")) ;
         cmbVendedorEstado.CurrentValue = StringUtil.Str( (decimal)(A325VendedorEstado), 1, 0) ;
         dynTipoVendedorId = dynGX_Parm6 ;
         A370TipoVendedorId = (int)(NumberUtil.Val( dynTipoVendedorId.CurrentValue, ".")) ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         dynTipoVendedorId.CurrentValue = StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0) ;
         isValidOutput.Add((Object)(StringUtil.RTrim( A318VendedorNombre)));
         cmbVendedorEstado.CurrentValue = StringUtil.Str( (decimal)(A325VendedorEstado), 1, 0) ;
         isValidOutput.Add((Object)(cmbVendedorEstado));
         if ( (0==A370TipoVendedorId) )
         {
            if ( ( dynTipoVendedorId.ItemCount > 0 ) && (0==A370TipoVendedorId) )
            {
               A370TipoVendedorId = (int)(NumberUtil.Val( dynTipoVendedorId.getItemValue(1), ".")) ;
            }
         }
         dynTipoVendedorId.CurrentValue = StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0) ;
         isValidOutput.Add((Object)(dynTipoVendedorId));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z317VendedorCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z318VendedorNombre)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z325VendedorEstado), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z370TipoVendedorId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Tipovendedorid( String GX_Parm1 ,
                                        GXCombobox dynGX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         dynTipoVendedorId = dynGX_Parm2 ;
         A370TipoVendedorId = (int)(NumberUtil.Val( dynTipoVendedorId.CurrentValue, ".")) ;
         /* Using cursor T001M17 */
         pr_default.execute(15, new Object[] {A41ClinicaCodigo, A370TipoVendedorId});
         if ( (pr_default.getStatus(15) == 101) )
         {
            AnyError41 = 1 ;
            AnyError370 = 1 ;
            GX_msglist.addItem("No existe 'Tipo Vendedor'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError370 == 0 ) )
         {
         }
         pr_default.close(15);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(13);
         pr_default.close(7);
         pr_default.close(6);
         pr_default.close(15);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
         GXKey = "" ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         TempTags = "" ;
         bttBtn_enter_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         bttBtn_delete_Jsonclick = "" ;
         lblTextblockclinicacodigo_Jsonclick = "" ;
         lblTextblockvendedorcodigo_Jsonclick = "" ;
         A317VendedorCodigo = "" ;
         lblTextblockvendedornombre_Jsonclick = "" ;
         A318VendedorNombre = "" ;
         lblTextblocktipovendedorid_Jsonclick = "" ;
         lblTextblockvendedorestado_Jsonclick = "" ;
         imgBtn_first_Jsonclick = "" ;
         imgBtn_first_separator_Jsonclick = "" ;
         imgBtn_previous_Jsonclick = "" ;
         imgBtn_previous_separator_Jsonclick = "" ;
         imgBtn_next_Jsonclick = "" ;
         imgBtn_next_separator_Jsonclick = "" ;
         imgBtn_last_Jsonclick = "" ;
         imgBtn_last_separator_Jsonclick = "" ;
         imgBtn_select_Jsonclick = "" ;
         imgBtn_select_separator_Jsonclick = "" ;
         imgBtn_enter2_Jsonclick = "" ;
         imgBtn_enter2_separator_Jsonclick = "" ;
         imgBtn_cancel2_Jsonclick = "" ;
         imgBtn_cancel2_separator_Jsonclick = "" ;
         imgBtn_delete2_Jsonclick = "" ;
         imgBtn_delete2_separator_Jsonclick = "" ;
         Z41ClinicaCodigo = "" ;
         Z317VendedorCodigo = "" ;
         Z318VendedorNombre = "" ;
         Gx_mode = "" ;
         AV7ClinicaCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV8Parametros = new SdtParametros(context);
         GXt_SdtParametros3 = new SdtParametros(context);
         T001M5_A317VendedorCodigo = new String[] {""} ;
         T001M5_n317VendedorCodigo = new bool[] {false} ;
         T001M5_A318VendedorNombre = new String[] {""} ;
         T001M5_A325VendedorEstado = new short[1] ;
         T001M5_A41ClinicaCodigo = new String[] {""} ;
         T001M5_A370TipoVendedorId = new int[1] ;
         T001M4_A41ClinicaCodigo = new String[] {""} ;
         T001M6_A41ClinicaCodigo = new String[] {""} ;
         T001M7_A41ClinicaCodigo = new String[] {""} ;
         T001M7_A317VendedorCodigo = new String[] {""} ;
         T001M7_n317VendedorCodigo = new bool[] {false} ;
         T001M3_A317VendedorCodigo = new String[] {""} ;
         T001M3_n317VendedorCodigo = new bool[] {false} ;
         T001M3_A318VendedorNombre = new String[] {""} ;
         T001M3_A325VendedorEstado = new short[1] ;
         T001M3_A41ClinicaCodigo = new String[] {""} ;
         T001M3_A370TipoVendedorId = new int[1] ;
         sMode74 = "" ;
         T001M8_A41ClinicaCodigo = new String[] {""} ;
         T001M8_A317VendedorCodigo = new String[] {""} ;
         T001M8_n317VendedorCodigo = new bool[] {false} ;
         T001M9_A41ClinicaCodigo = new String[] {""} ;
         T001M9_A317VendedorCodigo = new String[] {""} ;
         T001M9_n317VendedorCodigo = new bool[] {false} ;
         T001M10_A317VendedorCodigo = new String[] {""} ;
         T001M10_n317VendedorCodigo = new bool[] {false} ;
         T001M10_A318VendedorNombre = new String[] {""} ;
         T001M10_A325VendedorEstado = new short[1] ;
         T001M10_A41ClinicaCodigo = new String[] {""} ;
         T001M10_A370TipoVendedorId = new int[1] ;
         T001M14_A41ClinicaCodigo = new String[] {""} ;
         T001M14_A327NPacienteId = new int[1] ;
         T001M15_A41ClinicaCodigo = new String[] {""} ;
         T001M15_A317VendedorCodigo = new String[] {""} ;
         T001M15_n317VendedorCodigo = new bool[] {false} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         GXt_char4 = "" ;
         T001M16_A41ClinicaCodigo = new String[] {""} ;
         T001M16_A370TipoVendedorId = new int[1] ;
         T001M16_A371TipoVendedorNombre = new String[] {""} ;
         T001M16_A372TipoVendedorEstado = new short[1] ;
         isValidOutput = new GxUnknownObjectCollection();
         T001M17_A41ClinicaCodigo = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.vendedor__default(),
            new Object[][] {
                new Object[] {
               T001M2_A317VendedorCodigo, T001M2_A318VendedorNombre, T001M2_A325VendedorEstado, T001M2_A41ClinicaCodigo, T001M2_A370TipoVendedorId
               }
               , new Object[] {
               T001M3_A317VendedorCodigo, T001M3_A318VendedorNombre, T001M3_A325VendedorEstado, T001M3_A41ClinicaCodigo, T001M3_A370TipoVendedorId
               }
               , new Object[] {
               T001M4_A41ClinicaCodigo
               }
               , new Object[] {
               T001M5_A317VendedorCodigo, T001M5_A318VendedorNombre, T001M5_A325VendedorEstado, T001M5_A41ClinicaCodigo, T001M5_A370TipoVendedorId
               }
               , new Object[] {
               T001M6_A41ClinicaCodigo
               }
               , new Object[] {
               T001M7_A41ClinicaCodigo, T001M7_A317VendedorCodigo
               }
               , new Object[] {
               T001M8_A41ClinicaCodigo, T001M8_A317VendedorCodigo
               }
               , new Object[] {
               T001M9_A41ClinicaCodigo, T001M9_A317VendedorCodigo
               }
               , new Object[] {
               T001M10_A317VendedorCodigo, T001M10_A318VendedorNombre, T001M10_A325VendedorEstado, T001M10_A41ClinicaCodigo, T001M10_A370TipoVendedorId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001M14_A41ClinicaCodigo, T001M14_A327NPacienteId
               }
               , new Object[] {
               T001M15_A41ClinicaCodigo, T001M15_A317VendedorCodigo
               }
               , new Object[] {
               T001M16_A41ClinicaCodigo, T001M16_A370TipoVendedorId, T001M16_A371TipoVendedorNombre, T001M16_A372TipoVendedorEstado
               }
               , new Object[] {
               T001M17_A41ClinicaCodigo
               }
            }
         );
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short A325VendedorEstado ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Z325VendedorEstado ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short RcdFound74 ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int A370TipoVendedorId ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int lblTextblockclinicacodigo_Visible ;
      private int edtClinicaCodigo_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int edtVendedorCodigo_Enabled ;
      private int edtVendedorNombre_Enabled ;
      private int imgprompt_41_370_Visible ;
      private int imgBtn_first_Visible ;
      private int imgBtn_first_separator_Visible ;
      private int imgBtn_previous_Visible ;
      private int imgBtn_previous_separator_Visible ;
      private int imgBtn_next_Visible ;
      private int imgBtn_next_separator_Visible ;
      private int imgBtn_last_Visible ;
      private int imgBtn_last_separator_Visible ;
      private int imgBtn_select_Visible ;
      private int imgBtn_select_separator_Visible ;
      private int imgBtn_enter2_Visible ;
      private int imgBtn_enter2_Enabled ;
      private int imgBtn_enter2_separator_Visible ;
      private int imgBtn_cancel2_Visible ;
      private int imgBtn_cancel2_separator_Visible ;
      private int imgBtn_delete2_Visible ;
      private int imgBtn_delete2_Enabled ;
      private int imgBtn_delete2_separator_Visible ;
      private int Z370TipoVendedorId ;
      private int AnyError41 ;
      private int AnyError370 ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtClinicaCodigo_Internalname ;
      private String sStyleString ;
      private String tblTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroupdata_Internalname ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockclinicacodigo_Internalname ;
      private String lblTextblockclinicacodigo_Jsonclick ;
      private String edtClinicaCodigo_Jsonclick ;
      private String lblTextblockvendedorcodigo_Internalname ;
      private String lblTextblockvendedorcodigo_Jsonclick ;
      private String edtVendedorCodigo_Internalname ;
      private String edtVendedorCodigo_Jsonclick ;
      private String lblTextblockvendedornombre_Internalname ;
      private String lblTextblockvendedornombre_Jsonclick ;
      private String edtVendedorNombre_Internalname ;
      private String edtVendedorNombre_Jsonclick ;
      private String lblTextblocktipovendedorid_Internalname ;
      private String lblTextblocktipovendedorid_Jsonclick ;
      private String dynTipoVendedorId_Internalname ;
      private String dynTipoVendedorId_Jsonclick ;
      private String imgprompt_41_370_Internalname ;
      private String imgprompt_41_370_Link ;
      private String lblTextblockvendedorestado_Internalname ;
      private String lblTextblockvendedorestado_Jsonclick ;
      private String cmbVendedorEstado_Internalname ;
      private String cmbVendedorEstado_Jsonclick ;
      private String tblTabletoolbar_Internalname ;
      private String imgBtn_first_Internalname ;
      private String imgBtn_first_Jsonclick ;
      private String imgBtn_first_separator_Internalname ;
      private String imgBtn_first_separator_Jsonclick ;
      private String imgBtn_previous_Internalname ;
      private String imgBtn_previous_Jsonclick ;
      private String imgBtn_previous_separator_Internalname ;
      private String imgBtn_previous_separator_Jsonclick ;
      private String imgBtn_next_Internalname ;
      private String imgBtn_next_Jsonclick ;
      private String imgBtn_next_separator_Internalname ;
      private String imgBtn_next_separator_Jsonclick ;
      private String imgBtn_last_Internalname ;
      private String imgBtn_last_Jsonclick ;
      private String imgBtn_last_separator_Internalname ;
      private String imgBtn_last_separator_Jsonclick ;
      private String imgBtn_select_Internalname ;
      private String imgBtn_select_Jsonclick ;
      private String imgBtn_select_separator_Internalname ;
      private String imgBtn_select_separator_Jsonclick ;
      private String imgBtn_enter2_Internalname ;
      private String imgBtn_enter2_Jsonclick ;
      private String imgBtn_enter2_separator_Internalname ;
      private String imgBtn_enter2_separator_Jsonclick ;
      private String imgBtn_cancel2_Internalname ;
      private String imgBtn_cancel2_Jsonclick ;
      private String imgBtn_cancel2_separator_Internalname ;
      private String imgBtn_cancel2_separator_Jsonclick ;
      private String imgBtn_delete2_Internalname ;
      private String imgBtn_delete2_Jsonclick ;
      private String imgBtn_delete2_separator_Internalname ;
      private String imgBtn_delete2_separator_Jsonclick ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode74 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String gxwrpcisep ;
      private String GXt_char4 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n317VendedorCodigo ;
      private String A41ClinicaCodigo ;
      private String A317VendedorCodigo ;
      private String A318VendedorNombre ;
      private String Z41ClinicaCodigo ;
      private String Z317VendedorCodigo ;
      private String Z318VendedorNombre ;
      private String AV7ClinicaCodigo ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynTipoVendedorId ;
      private GXCombobox cmbVendedorEstado ;
      private IDataStoreProvider pr_default ;
      private String[] T001M5_A317VendedorCodigo ;
      private bool[] T001M5_n317VendedorCodigo ;
      private String[] T001M5_A318VendedorNombre ;
      private short[] T001M5_A325VendedorEstado ;
      private String[] T001M5_A41ClinicaCodigo ;
      private int[] T001M5_A370TipoVendedorId ;
      private String[] T001M4_A41ClinicaCodigo ;
      private String[] T001M6_A41ClinicaCodigo ;
      private String[] T001M7_A41ClinicaCodigo ;
      private String[] T001M7_A317VendedorCodigo ;
      private bool[] T001M7_n317VendedorCodigo ;
      private String[] T001M3_A317VendedorCodigo ;
      private bool[] T001M3_n317VendedorCodigo ;
      private String[] T001M3_A318VendedorNombre ;
      private short[] T001M3_A325VendedorEstado ;
      private String[] T001M3_A41ClinicaCodigo ;
      private int[] T001M3_A370TipoVendedorId ;
      private String[] T001M8_A41ClinicaCodigo ;
      private String[] T001M8_A317VendedorCodigo ;
      private bool[] T001M8_n317VendedorCodigo ;
      private String[] T001M9_A41ClinicaCodigo ;
      private String[] T001M9_A317VendedorCodigo ;
      private bool[] T001M9_n317VendedorCodigo ;
      private String[] T001M10_A317VendedorCodigo ;
      private bool[] T001M10_n317VendedorCodigo ;
      private String[] T001M10_A318VendedorNombre ;
      private short[] T001M10_A325VendedorEstado ;
      private String[] T001M10_A41ClinicaCodigo ;
      private int[] T001M10_A370TipoVendedorId ;
      private String[] T001M14_A41ClinicaCodigo ;
      private int[] T001M14_A327NPacienteId ;
      private String[] T001M15_A41ClinicaCodigo ;
      private String[] T001M15_A317VendedorCodigo ;
      private bool[] T001M15_n317VendedorCodigo ;
      private String[] T001M16_A41ClinicaCodigo ;
      private int[] T001M16_A370TipoVendedorId ;
      private String[] T001M16_A371TipoVendedorNombre ;
      private short[] T001M16_A372TipoVendedorEstado ;
      private String[] T001M17_A41ClinicaCodigo ;
      private String[] T001M2_A317VendedorCodigo ;
      private String[] T001M2_A318VendedorNombre ;
      private short[] T001M2_A325VendedorEstado ;
      private String[] T001M2_A41ClinicaCodigo ;
      private int[] T001M2_A370TipoVendedorId ;
      private GXWebForm Form ;
      private SdtParametros AV8Parametros ;
      private SdtParametros GXt_SdtParametros3 ;
   }

   public class vendedor__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT001M2 ;
          prmT001M2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@VendedorCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001M5 ;
          prmT001M5 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@VendedorCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001M4 ;
          prmT001M4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001M6 ;
          prmT001M6 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001M7 ;
          prmT001M7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@VendedorCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001M3 ;
          prmT001M3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@VendedorCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001M8 ;
          prmT001M8 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@VendedorCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001M9 ;
          prmT001M9 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@VendedorCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001M10 ;
          prmT001M10 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@VendedorCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001M11 ;
          prmT001M11 = new Object[] {
          new Object[] {"@VendedorCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@VendedorNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@VendedorEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001M12 ;
          prmT001M12 = new Object[] {
          new Object[] {"@VendedorNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@VendedorEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@VendedorCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001M13 ;
          prmT001M13 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@VendedorCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001M14 ;
          prmT001M14 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@VendedorCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001M15 ;
          prmT001M15 = new Object[] {
          } ;
          Object[] prmT001M16 ;
          prmT001M16 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001M17 ;
          prmT001M17 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T001M2", "SELECT [VendedorCodigo], [VendedorNombre], [VendedorEstado], [ClinicaCodigo], [TipoVendedorId] FROM [Vendedor] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [VendedorCodigo] = @VendedorCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001M2,1,0,true,false )
             ,new CursorDef("T001M3", "SELECT [VendedorCodigo], [VendedorNombre], [VendedorEstado], [ClinicaCodigo], [TipoVendedorId] FROM [Vendedor] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [VendedorCodigo] = @VendedorCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001M3,1,0,true,false )
             ,new CursorDef("T001M4", "SELECT [ClinicaCodigo] FROM [TipoVendedor] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoVendedorId] = @TipoVendedorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001M4,1,0,true,false )
             ,new CursorDef("T001M5", "SELECT TM1.[VendedorCodigo], TM1.[VendedorNombre], TM1.[VendedorEstado], TM1.[ClinicaCodigo], TM1.[TipoVendedorId] FROM [Vendedor] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[VendedorCodigo] = @VendedorCodigo ORDER BY TM1.[ClinicaCodigo], TM1.[VendedorCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001M5,100,0,true,false )
             ,new CursorDef("T001M6", "SELECT [ClinicaCodigo] FROM [TipoVendedor] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoVendedorId] = @TipoVendedorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001M6,1,0,true,false )
             ,new CursorDef("T001M7", "SELECT [ClinicaCodigo], [VendedorCodigo] FROM [Vendedor] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [VendedorCodigo] = @VendedorCodigo  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001M7,1,0,true,false )
             ,new CursorDef("T001M8", "SELECT TOP 1 [ClinicaCodigo], [VendedorCodigo] FROM [Vendedor] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [VendedorCodigo] > @VendedorCodigo) ORDER BY [ClinicaCodigo], [VendedorCodigo]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001M8,1,0,true,true )
             ,new CursorDef("T001M9", "SELECT TOP 1 [ClinicaCodigo], [VendedorCodigo] FROM [Vendedor] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [VendedorCodigo] < @VendedorCodigo) ORDER BY [ClinicaCodigo] DESC, [VendedorCodigo] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001M9,1,0,true,true )
             ,new CursorDef("T001M10", "SELECT [VendedorCodigo], [VendedorNombre], [VendedorEstado], [ClinicaCodigo], [TipoVendedorId] FROM [Vendedor] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [VendedorCodigo] = @VendedorCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001M10,1,0,true,false )
             ,new CursorDef("T001M11", "INSERT INTO [Vendedor] ([VendedorCodigo], [VendedorNombre], [VendedorEstado], [ClinicaCodigo], [TipoVendedorId]) VALUES (@VendedorCodigo, @VendedorNombre, @VendedorEstado, @ClinicaCodigo, @TipoVendedorId)", GxErrorMask.GX_NOMASK,prmT001M11)
             ,new CursorDef("T001M12", "UPDATE [Vendedor] SET [VendedorNombre]=@VendedorNombre, [VendedorEstado]=@VendedorEstado, [TipoVendedorId]=@TipoVendedorId  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [VendedorCodigo] = @VendedorCodigo", GxErrorMask.GX_NOMASK,prmT001M12)
             ,new CursorDef("T001M13", "DELETE FROM [Vendedor]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [VendedorCodigo] = @VendedorCodigo", GxErrorMask.GX_NOMASK,prmT001M13)
             ,new CursorDef("T001M14", "SELECT TOP 1 [ClinicaCodigo], [NPacienteId] FROM [NotaPaciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [VendedorCodigo] = @VendedorCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001M14,1,0,true,true )
             ,new CursorDef("T001M15", "SELECT [ClinicaCodigo], [VendedorCodigo] FROM [Vendedor] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [VendedorCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001M15,100,0,true,false )
             ,new CursorDef("T001M16", "SELECT [ClinicaCodigo], [TipoVendedorId], [TipoVendedorNombre], [TipoVendedorEstado] FROM [TipoVendedor] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @ClinicaCodigo) AND ([TipoVendedorEstado] = 1) ORDER BY [TipoVendedorNombre] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001M16,0,0,true,false )
             ,new CursorDef("T001M17", "SELECT [ClinicaCodigo] FROM [TipoVendedor] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoVendedorId] = @TipoVendedorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001M17,1,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                break;
             case 9 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                stmt.SetParameter(2, (String)parms[2]);
                stmt.SetParameter(3, (short)parms[3]);
                stmt.SetParameter(4, (String)parms[4]);
                stmt.SetParameter(5, (int)parms[5]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[5]);
                }
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 15 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
       }
    }

 }

}
