/*
               File: FacturaPago
        Description: Detalle de Pago de Facturas
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:6:40.82
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
   public class facturapago : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_2") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A65FormaPagoCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65FormaPagoCodigo", A65FormaPagoCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_2( A41ClinicaCodigo, A65FormaPagoCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_3") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A185FacturaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_3( A41ClinicaCodigo, A185FacturaId) ;
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
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Detalle de Pago de Facturas", 0) ;
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

      public facturapago( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public facturapago( IGxContext context )
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
            wb_table1_2_1D63( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1D63e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1D63( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1D63( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1D63e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Detalle de Pago de Facturas"+"</legend>") ;
            wb_table3_27_1D63( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_1D63e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1D63e( true) ;
         }
         else
         {
            wb_table1_2_1D63e( false) ;
         }
      }

      protected void wb_table3_27_1D63( bool wbgen )
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
            wb_table4_33_1D63( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_1D63e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_FacturaPago.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_FacturaPago.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_FacturaPago.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_1D63e( true) ;
         }
         else
         {
            wb_table3_27_1D63e( false) ;
         }
      }

      protected void wb_table4_33_1D63( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_FacturaPago.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_FacturaPago.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockfacturaid_Internalname, "Factura", "", "", lblTextblockfacturaid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_FacturaPago.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtFacturaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A185FacturaId), 9, 0, ".", "")), ((edtFacturaId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A185FacturaId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A185FacturaId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(43);\"", "", "", "", "", edtFacturaId_Jsonclick, 0, ClassString, StyleString, "", 1, edtFacturaId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_FacturaPago.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_185_Internalname, "prompt.gif", imgprompt_41_185_Link, "", "", "Fantastic", imgprompt_41_185_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_FacturaPago.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockfacturapid_Internalname, "Línea", "", "", lblTextblockfacturapid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_FacturaPago.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260FacturaPId", StringUtil.LTrim( StringUtil.Str( (decimal)(A260FacturaPId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtFacturaPId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A260FacturaPId), 9, 0, ".", "")), ((edtFacturaPId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A260FacturaPId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A260FacturaPId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(48);\"", "", "", "", "", edtFacturaPId_Jsonclick, 0, ClassString, StyleString, "", 1, edtFacturaPId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_FacturaPago.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockformapagocodigo_Internalname, "Código", "", "", lblTextblockformapagocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_FacturaPago.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65FormaPagoCodigo", A65FormaPagoCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtFormaPagoCodigo_Internalname, StringUtil.RTrim( A65FormaPagoCodigo), StringUtil.RTrim( context.localUtil.Format( A65FormaPagoCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "", "", "", "", edtFormaPagoCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtFormaPagoCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_FacturaPago.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_65_Internalname, "prompt.gif", imgprompt_41_65_Link, "", "", "Fantastic", imgprompt_41_65_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_FacturaPago.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockfacturapmonto_Internalname, "Monto", "", "", lblTextblockfacturapmonto_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_FacturaPago.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A261FacturaPMonto", StringUtil.LTrim( StringUtil.Str( A261FacturaPMonto, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtFacturaPMonto_Internalname, StringUtil.LTrim( StringUtil.NToC( A261FacturaPMonto, 17, 2, ".", "")), ((edtFacturaPMonto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A261FacturaPMonto, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A261FacturaPMonto, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(58);\"", "", "", "", "", edtFacturaPMonto_Jsonclick, 0, ClassString, StyleString, "", 1, edtFacturaPMonto_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_FacturaPago.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockfacturapdocto_Internalname, "Documento", "", "", lblTextblockfacturapdocto_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_FacturaPago.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A262FacturaPDocto", A262FacturaPDocto);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtFacturaPDocto_Internalname, StringUtil.RTrim( A262FacturaPDocto), StringUtil.RTrim( context.localUtil.Format( A262FacturaPDocto, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", "", "", "", "", edtFacturaPDocto_Jsonclick, 0, ClassString, StyleString, "", 1, edtFacturaPDocto_Enabled, 0, 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, true, "left", "HLP_FacturaPago.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockfacturapdetalle_Internalname, "Emisor", "", "", lblTextblockfacturapdetalle_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_FacturaPago.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264FacturaPDetalle", A264FacturaPDetalle);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtFacturaPDetalle_Internalname, StringUtil.RTrim( A264FacturaPDetalle), StringUtil.RTrim( context.localUtil.Format( A264FacturaPDetalle, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", "", "", "", "", edtFacturaPDetalle_Jsonclick, 0, ClassString, StyleString, "", 1, edtFacturaPDetalle_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_FacturaPago.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_1D63e( true) ;
         }
         else
         {
            wb_table4_33_1D63e( false) ;
         }
      }

      protected void wb_table2_5_1D63( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_FacturaPago.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_FacturaPago.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_FacturaPago.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_FacturaPago.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_FacturaPago.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_FacturaPago.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_FacturaPago.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_FacturaPago.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01r0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"FACTURAID"+"'), id:'"+"FACTURAID"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"FACTURAPID"+"'), id:'"+"FACTURAPID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_FacturaPago.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01r0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"FACTURAID"+"'), id:'"+"FACTURAID"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"FACTURAPID"+"'), id:'"+"FACTURAPID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_FacturaPago.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_FacturaPago.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_FacturaPago.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_FacturaPago.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_FacturaPago.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_FacturaPago.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_FacturaPago.htm");
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
            wb_table2_5_1D63e( true) ;
         }
         else
         {
            wb_table2_5_1D63e( false) ;
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtFacturaId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtFacturaId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "FACTURAID");
                  AnyError = 1 ;
                  GX_FocusControl = edtFacturaId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A185FacturaId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
               }
               else
               {
                  A185FacturaId = (int)(context.localUtil.CToN( cgiGet( edtFacturaId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtFacturaPId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtFacturaPId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "FACTURAPID");
                  AnyError = 1 ;
                  GX_FocusControl = edtFacturaPId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A260FacturaPId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260FacturaPId", StringUtil.LTrim( StringUtil.Str( (decimal)(A260FacturaPId), 9, 0)));
               }
               else
               {
                  A260FacturaPId = (int)(context.localUtil.CToN( cgiGet( edtFacturaPId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260FacturaPId", StringUtil.LTrim( StringUtil.Str( (decimal)(A260FacturaPId), 9, 0)));
               }
               A65FormaPagoCodigo = cgiGet( edtFormaPagoCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65FormaPagoCodigo", A65FormaPagoCodigo);
               if ( ( ( context.localUtil.CToN( cgiGet( edtFacturaPMonto_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtFacturaPMonto_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "FACTURAPMONTO");
                  AnyError = 1 ;
                  GX_FocusControl = edtFacturaPMonto_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A261FacturaPMonto = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A261FacturaPMonto", StringUtil.LTrim( StringUtil.Str( A261FacturaPMonto, 17, 2)));
               }
               else
               {
                  A261FacturaPMonto = context.localUtil.CToN( cgiGet( edtFacturaPMonto_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A261FacturaPMonto", StringUtil.LTrim( StringUtil.Str( A261FacturaPMonto, 17, 2)));
               }
               A262FacturaPDocto = cgiGet( edtFacturaPDocto_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A262FacturaPDocto", A262FacturaPDocto);
               A264FacturaPDetalle = cgiGet( edtFacturaPDetalle_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264FacturaPDetalle", A264FacturaPDetalle);
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z185FacturaId = (int)(context.localUtil.CToN( cgiGet( "Z185FacturaId"), ".", ",")) ;
               Z260FacturaPId = (int)(context.localUtil.CToN( cgiGet( "Z260FacturaPId"), ".", ",")) ;
               Z261FacturaPMonto = context.localUtil.CToN( cgiGet( "Z261FacturaPMonto"), ".", ",") ;
               Z262FacturaPDocto = cgiGet( "Z262FacturaPDocto") ;
               Z264FacturaPDetalle = cgiGet( "Z264FacturaPDetalle") ;
               Z65FormaPagoCodigo = cgiGet( "Z65FormaPagoCodigo") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
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
                  A185FacturaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
                  A260FacturaPId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260FacturaPId", StringUtil.LTrim( StringUtil.Str( (decimal)(A260FacturaPId), 9, 0)));
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
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
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
               InitAll1D63( ) ;
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
         DisableAttributes1D63( ) ;
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

      protected void ResetCaption1D0( )
      {
      }

      protected void ZM1D63( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z261FacturaPMonto = T001D3_A261FacturaPMonto[0] ;
               Z262FacturaPDocto = T001D3_A262FacturaPDocto[0] ;
               Z264FacturaPDetalle = T001D3_A264FacturaPDetalle[0] ;
               Z65FormaPagoCodigo = T001D3_A65FormaPagoCodigo[0] ;
            }
            else
            {
               Z261FacturaPMonto = A261FacturaPMonto ;
               Z262FacturaPDocto = A262FacturaPDocto ;
               Z264FacturaPDetalle = A264FacturaPDetalle ;
               Z65FormaPagoCodigo = A65FormaPagoCodigo ;
            }
         }
         if ( GX_JID == -1 )
         {
            Z260FacturaPId = A260FacturaPId ;
            Z261FacturaPMonto = A261FacturaPMonto ;
            Z262FacturaPDocto = A262FacturaPDocto ;
            Z264FacturaPDetalle = A264FacturaPDetalle ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z65FormaPagoCodigo = A65FormaPagoCodigo ;
            Z185FacturaId = A185FacturaId ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_41_185_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx01d0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"FACTURAID"+"'), id:'"+"FACTURAID"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"true"+");") ;
         imgprompt_41_65_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00m0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"FORMAPAGOCODIGO"+"'), id:'"+"FORMAPAGOCODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
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
      }

      protected void Load1D63( )
      {
         /* Using cursor T001D6 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo, A185FacturaId, A260FacturaPId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound63 = 1 ;
            A261FacturaPMonto = T001D6_A261FacturaPMonto[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A261FacturaPMonto", StringUtil.LTrim( StringUtil.Str( A261FacturaPMonto, 17, 2)));
            A262FacturaPDocto = T001D6_A262FacturaPDocto[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A262FacturaPDocto", A262FacturaPDocto);
            A264FacturaPDetalle = T001D6_A264FacturaPDetalle[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264FacturaPDetalle", A264FacturaPDetalle);
            A65FormaPagoCodigo = T001D6_A65FormaPagoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65FormaPagoCodigo", A65FormaPagoCodigo);
            ZM1D63( -1) ;
         }
         pr_default.close(4);
         OnLoadActions1D63( ) ;
      }

      protected void OnLoadActions1D63( )
      {
      }

      protected void CheckExtendedTable1D63( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T001D4 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo, A65FormaPagoCodigo});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError41 = 1 ;
            AnyError65 = 1 ;
            GX_msglist.addItem("No existe 'Formas de pago'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError65 == 0 ) )
         {
         }
         pr_default.close(2);
         /* Using cursor T001D5 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A185FacturaId});
         if ( (pr_default.getStatus(3) == 101) )
         {
            AnyError41 = 1 ;
            AnyError185 = 1 ;
            GX_msglist.addItem("No existe 'Factura a Pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError185 == 0 ) )
         {
         }
         pr_default.close(3);
      }

      protected void CloseExtendedTableCursors1D63( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_2( String A41ClinicaCodigo ,
                               String A65FormaPagoCodigo )
      {
         /* Using cursor T001D7 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A65FormaPagoCodigo});
         if ( (pr_default.getStatus(5) == 101) )
         {
            AnyError41 = 1 ;
            AnyError65 = 1 ;
            GX_msglist.addItem("No existe 'Formas de pago'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError65 == 0 ) )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(5);
      }

      protected void gxLoad_3( String A41ClinicaCodigo ,
                               int A185FacturaId )
      {
         /* Using cursor T001D8 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, A185FacturaId});
         if ( (pr_default.getStatus(6) == 101) )
         {
            AnyError41 = 1 ;
            AnyError185 = 1 ;
            GX_msglist.addItem("No existe 'Factura a Pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError185 == 0 ) )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(6);
      }

      protected void GetKey1D63( )
      {
         /* Using cursor T001D9 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A185FacturaId, A260FacturaPId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound63 = 1 ;
         }
         else
         {
            RcdFound63 = 0 ;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001D3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A185FacturaId, A260FacturaPId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1D63( 1) ;
            RcdFound63 = 1 ;
            A260FacturaPId = T001D3_A260FacturaPId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260FacturaPId", StringUtil.LTrim( StringUtil.Str( (decimal)(A260FacturaPId), 9, 0)));
            A261FacturaPMonto = T001D3_A261FacturaPMonto[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A261FacturaPMonto", StringUtil.LTrim( StringUtil.Str( A261FacturaPMonto, 17, 2)));
            A262FacturaPDocto = T001D3_A262FacturaPDocto[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A262FacturaPDocto", A262FacturaPDocto);
            A264FacturaPDetalle = T001D3_A264FacturaPDetalle[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264FacturaPDetalle", A264FacturaPDetalle);
            A41ClinicaCodigo = T001D3_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A65FormaPagoCodigo = T001D3_A65FormaPagoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65FormaPagoCodigo", A65FormaPagoCodigo);
            A185FacturaId = T001D3_A185FacturaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z185FacturaId = A185FacturaId ;
            Z260FacturaPId = A260FacturaPId ;
            sMode63 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1D63( ) ;
            Gx_mode = sMode63 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound63 = 0 ;
            InitializeNonKey1D63( ) ;
            sMode63 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode63 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1D63( ) ;
         if ( RcdFound63 == 0 )
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
         RcdFound63 = 0 ;
         /* Using cursor T001D10 */
         pr_default.execute(8, new Object[] {A41ClinicaCodigo, A185FacturaId, A260FacturaPId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T001D10_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001D10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001D10_A185FacturaId[0] < A185FacturaId ) || ( T001D10_A185FacturaId[0] == A185FacturaId ) && ( StringUtil.StrCmp(T001D10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001D10_A260FacturaPId[0] < A260FacturaPId ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T001D10_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001D10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001D10_A185FacturaId[0] > A185FacturaId ) || ( T001D10_A185FacturaId[0] == A185FacturaId ) && ( StringUtil.StrCmp(T001D10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001D10_A260FacturaPId[0] > A260FacturaPId ) ) )
            {
               A41ClinicaCodigo = T001D10_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A185FacturaId = T001D10_A185FacturaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
               A260FacturaPId = T001D10_A260FacturaPId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260FacturaPId", StringUtil.LTrim( StringUtil.Str( (decimal)(A260FacturaPId), 9, 0)));
               RcdFound63 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound63 = 0 ;
         /* Using cursor T001D11 */
         pr_default.execute(9, new Object[] {A41ClinicaCodigo, A185FacturaId, A260FacturaPId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T001D11_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001D11_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001D11_A185FacturaId[0] > A185FacturaId ) || ( T001D11_A185FacturaId[0] == A185FacturaId ) && ( StringUtil.StrCmp(T001D11_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001D11_A260FacturaPId[0] > A260FacturaPId ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T001D11_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001D11_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001D11_A185FacturaId[0] < A185FacturaId ) || ( T001D11_A185FacturaId[0] == A185FacturaId ) && ( StringUtil.StrCmp(T001D11_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001D11_A260FacturaPId[0] < A260FacturaPId ) ) )
            {
               A41ClinicaCodigo = T001D11_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A185FacturaId = T001D11_A185FacturaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
               A260FacturaPId = T001D11_A260FacturaPId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260FacturaPId", StringUtil.LTrim( StringUtil.Str( (decimal)(A260FacturaPId), 9, 0)));
               RcdFound63 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1D63( ) ;
         if ( RcdFound63 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A185FacturaId != Z185FacturaId ) || ( A260FacturaPId != Z260FacturaPId ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A185FacturaId = Z185FacturaId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
               A260FacturaPId = Z260FacturaPId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260FacturaPId", StringUtil.LTrim( StringUtil.Str( (decimal)(A260FacturaPId), 9, 0)));
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
               Update1D63( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A185FacturaId != Z185FacturaId ) || ( A260FacturaPId != Z260FacturaPId ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert1D63( ) ;
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
                  Insert1D63( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A185FacturaId != Z185FacturaId ) || ( A260FacturaPId != Z260FacturaPId ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A185FacturaId = Z185FacturaId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
            A260FacturaPId = Z260FacturaPId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260FacturaPId", StringUtil.LTrim( StringUtil.Str( (decimal)(A260FacturaPId), 9, 0)));
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
         if ( RcdFound63 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtFormaPagoCodigo_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1D63( ) ;
         if ( RcdFound63 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtFormaPagoCodigo_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1D63( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound63 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtFormaPagoCodigo_Internalname ;
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
         if ( RcdFound63 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtFormaPagoCodigo_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1D63( ) ;
         if ( RcdFound63 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound63 != 0 )
            {
               ScanNext1D63( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtFormaPagoCodigo_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1D63( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1D63( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001D12 */
            pr_default.execute(10, new Object[] {A41ClinicaCodigo, A185FacturaId, A260FacturaPId});
            if ( (pr_default.getStatus(10) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"FacturaPago"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(10) == 101) || ( Z261FacturaPMonto != T001D12_A261FacturaPMonto[0] ) || ( StringUtil.StrCmp(Z262FacturaPDocto, T001D12_A262FacturaPDocto[0]) != 0 ) || ( StringUtil.StrCmp(Z264FacturaPDetalle, T001D12_A264FacturaPDetalle[0]) != 0 ) || ( StringUtil.StrCmp(Z65FormaPagoCodigo, T001D12_A65FormaPagoCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"FacturaPago"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1D63( )
      {
         BeforeValidate1D63( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1D63( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1D63( 0) ;
            CheckOptimisticConcurrency1D63( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1D63( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1D63( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001D13 */
                     pr_default.execute(11, new Object[] {A260FacturaPId, A261FacturaPMonto, A262FacturaPDocto, A264FacturaPDetalle, A41ClinicaCodigo, A65FormaPagoCodigo, A185FacturaId});
                     pr_default.close(11);
                     if ( (pr_default.getStatus(11) == 1) )
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
                           ResetCaption1D0( ) ;
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
               Load1D63( ) ;
            }
            EndLevel1D63( ) ;
         }
         CloseExtendedTableCursors1D63( ) ;
      }

      protected void Update1D63( )
      {
         BeforeValidate1D63( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1D63( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1D63( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1D63( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1D63( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001D14 */
                     pr_default.execute(12, new Object[] {A261FacturaPMonto, A262FacturaPDocto, A264FacturaPDetalle, A65FormaPagoCodigo, A41ClinicaCodigo, A185FacturaId, A260FacturaPId});
                     pr_default.close(12);
                     if ( (pr_default.getStatus(12) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"FacturaPago"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1D63( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                           ResetCaption1D0( ) ;
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
            EndLevel1D63( ) ;
         }
         CloseExtendedTableCursors1D63( ) ;
      }

      protected void DeferredUpdate1D63( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1D63( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1D63( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1D63( ) ;
            AfterConfirm1D63( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1D63( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001D15 */
                  pr_default.execute(13, new Object[] {A41ClinicaCodigo, A185FacturaId, A260FacturaPId});
                  pr_default.close(13);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound63 == 0 )
                        {
                           InitAll1D63( ) ;
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
                        ResetCaption1D0( ) ;
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
         sMode63 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1D63( ) ;
         Gx_mode = sMode63 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1D63( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1D63( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1D63( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(9);
            pr_default.close(8);
            context.CommitDataStores("FacturaPago");
            if ( AnyError == 0 )
            {
               ConfirmValues1D0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(9);
            pr_default.close(8);
            context.RollbackDataStores("FacturaPago");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1D63( )
      {
         /* Using cursor T001D16 */
         pr_default.execute(14);
         RcdFound63 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound63 = 1 ;
            A41ClinicaCodigo = T001D16_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A185FacturaId = T001D16_A185FacturaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
            A260FacturaPId = T001D16_A260FacturaPId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260FacturaPId", StringUtil.LTrim( StringUtil.Str( (decimal)(A260FacturaPId), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1D63( )
      {
         pr_default.readNext(14);
         RcdFound63 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound63 = 1 ;
            A41ClinicaCodigo = T001D16_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A185FacturaId = T001D16_A185FacturaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
            A260FacturaPId = T001D16_A260FacturaPId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260FacturaPId", StringUtil.LTrim( StringUtil.Str( (decimal)(A260FacturaPId), 9, 0)));
         }
      }

      protected void ScanEnd1D63( )
      {
      }

      protected void AfterConfirm1D63( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1D63( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1D63( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1D63( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1D63( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1D63( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1D63( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtFacturaId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFacturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFacturaId_Enabled), 5, 0)));
         edtFacturaPId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFacturaPId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFacturaPId_Enabled), 5, 0)));
         edtFormaPagoCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFormaPagoCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFormaPagoCodigo_Enabled), 5, 0)));
         edtFacturaPMonto_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFacturaPMonto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFacturaPMonto_Enabled), 5, 0)));
         edtFacturaPDocto_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFacturaPDocto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFacturaPDocto_Enabled), 5, 0)));
         edtFacturaPDetalle_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFacturaPDetalle_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFacturaPDetalle_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1D0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("facturapago.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z185FacturaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z185FacturaId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z260FacturaPId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z260FacturaPId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z261FacturaPMonto", StringUtil.LTrim( StringUtil.NToC( Z261FacturaPMonto, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z262FacturaPDocto", StringUtil.RTrim( Z262FacturaPDocto));
         GxWebStd.gx_hidden_field( context, "Z264FacturaPDetalle", StringUtil.RTrim( Z264FacturaPDetalle));
         GxWebStd.gx_hidden_field( context, "Z65FormaPagoCodigo", StringUtil.RTrim( Z65FormaPagoCodigo));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
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
         return "FacturaPago" ;
      }

      public override String GetPgmdesc( )
      {
         return "Detalle de Pago de Facturas" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("facturapago.aspx")  ;
      }

      protected void InitializeNonKey1D63( )
      {
         A65FormaPagoCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65FormaPagoCodigo", A65FormaPagoCodigo);
         A261FacturaPMonto = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A261FacturaPMonto", StringUtil.LTrim( StringUtil.Str( A261FacturaPMonto, 17, 2)));
         A262FacturaPDocto = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A262FacturaPDocto", A262FacturaPDocto);
         A264FacturaPDetalle = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264FacturaPDetalle", A264FacturaPDetalle);
      }

      protected void InitAll1D63( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A185FacturaId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
         A260FacturaPId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260FacturaPId", StringUtil.LTrim( StringUtil.Str( (decimal)(A260FacturaPId), 9, 0)));
         InitializeNonKey1D63( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1564255");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("facturapago.js", "?1564256");
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
         lblTextblockfacturaid_Internalname = "TEXTBLOCKFACTURAID" ;
         edtFacturaId_Internalname = "FACTURAID" ;
         lblTextblockfacturapid_Internalname = "TEXTBLOCKFACTURAPID" ;
         edtFacturaPId_Internalname = "FACTURAPID" ;
         lblTextblockformapagocodigo_Internalname = "TEXTBLOCKFORMAPAGOCODIGO" ;
         edtFormaPagoCodigo_Internalname = "FORMAPAGOCODIGO" ;
         lblTextblockfacturapmonto_Internalname = "TEXTBLOCKFACTURAPMONTO" ;
         edtFacturaPMonto_Internalname = "FACTURAPMONTO" ;
         lblTextblockfacturapdocto_Internalname = "TEXTBLOCKFACTURAPDOCTO" ;
         edtFacturaPDocto_Internalname = "FACTURAPDOCTO" ;
         lblTextblockfacturapdetalle_Internalname = "TEXTBLOCKFACTURAPDETALLE" ;
         edtFacturaPDetalle_Internalname = "FACTURAPDETALLE" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_185_Internalname = "PROMPT_41_185" ;
         imgprompt_41_65_Internalname = "PROMPT_41_65" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Detalle de Pago de Facturas" ;
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
         edtFacturaPDetalle_Jsonclick = "" ;
         edtFacturaPDetalle_Enabled = 1 ;
         edtFacturaPDocto_Jsonclick = "" ;
         edtFacturaPDocto_Enabled = 1 ;
         edtFacturaPMonto_Jsonclick = "" ;
         edtFacturaPMonto_Enabled = 1 ;
         imgprompt_41_65_Visible = 1 ;
         imgprompt_41_65_Link = "" ;
         edtFormaPagoCodigo_Jsonclick = "" ;
         edtFormaPagoCodigo_Enabled = 1 ;
         edtFacturaPId_Jsonclick = "" ;
         edtFacturaPId_Enabled = 1 ;
         imgprompt_41_185_Visible = 1 ;
         imgprompt_41_185_Link = "" ;
         edtFacturaId_Jsonclick = "" ;
         edtFacturaId_Enabled = 1 ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtClinicaCodigo_Enabled = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         /* Using cursor T001D17 */
         pr_default.execute(15, new Object[] {A41ClinicaCodigo, A185FacturaId});
         if ( (pr_default.getStatus(15) == 101) )
         {
            AnyError41 = 1 ;
            AnyError185 = 1 ;
            GX_msglist.addItem("No existe 'Factura a Pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError185 == 0 ) )
         {
         }
         pr_default.close(15);
         GX_FocusControl = edtFormaPagoCodigo_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Facturaid( String GX_Parm1 ,
                                   int GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A185FacturaId = GX_Parm2 ;
         /* Using cursor T001D17 */
         pr_default.execute(15, new Object[] {A41ClinicaCodigo, A185FacturaId});
         if ( (pr_default.getStatus(15) == 101) )
         {
            AnyError41 = 1 ;
            AnyError185 = 1 ;
            GX_msglist.addItem("No existe 'Factura a Pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError185 == 0 ) )
         {
         }
         pr_default.close(15);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Facturapid( String GX_Parm1 ,
                                    int GX_Parm2 ,
                                    int GX_Parm3 ,
                                    decimal GX_Parm4 ,
                                    String GX_Parm5 ,
                                    String GX_Parm6 ,
                                    String GX_Parm7 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A185FacturaId = GX_Parm2 ;
         A260FacturaPId = GX_Parm3 ;
         A261FacturaPMonto = GX_Parm4 ;
         A262FacturaPDocto = GX_Parm5 ;
         A264FacturaPDetalle = GX_Parm6 ;
         A65FormaPagoCodigo = GX_Parm7 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A65FormaPagoCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A261FacturaPMonto, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A262FacturaPDocto)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A264FacturaPDetalle)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z185FacturaId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z260FacturaPId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z65FormaPagoCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z261FacturaPMonto, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z262FacturaPDocto)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z264FacturaPDetalle)));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Formapagocodigo( String GX_Parm1 ,
                                         String GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A65FormaPagoCodigo = GX_Parm2 ;
         /* Using cursor T001D18 */
         pr_default.execute(16, new Object[] {A41ClinicaCodigo, A65FormaPagoCodigo});
         if ( (pr_default.getStatus(16) == 101) )
         {
            AnyError41 = 1 ;
            AnyError65 = 1 ;
            GX_msglist.addItem("No existe 'Formas de pago'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError65 == 0 ) )
         {
         }
         pr_default.close(16);
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
         pr_default.close(14);
         pr_default.close(9);
         pr_default.close(8);
         pr_default.close(16);
         pr_default.close(15);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
         A65FormaPagoCodigo = "" ;
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
         lblTextblockfacturaid_Jsonclick = "" ;
         lblTextblockfacturapid_Jsonclick = "" ;
         lblTextblockformapagocodigo_Jsonclick = "" ;
         lblTextblockfacturapmonto_Jsonclick = "" ;
         lblTextblockfacturapdocto_Jsonclick = "" ;
         A262FacturaPDocto = "" ;
         lblTextblockfacturapdetalle_Jsonclick = "" ;
         A264FacturaPDetalle = "" ;
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
         Z262FacturaPDocto = "" ;
         Z264FacturaPDetalle = "" ;
         Z65FormaPagoCodigo = "" ;
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T001D6_A260FacturaPId = new int[1] ;
         T001D6_A261FacturaPMonto = new decimal[1] ;
         T001D6_A262FacturaPDocto = new String[] {""} ;
         T001D6_A264FacturaPDetalle = new String[] {""} ;
         T001D6_A41ClinicaCodigo = new String[] {""} ;
         T001D6_A65FormaPagoCodigo = new String[] {""} ;
         T001D6_A185FacturaId = new int[1] ;
         T001D4_A41ClinicaCodigo = new String[] {""} ;
         T001D5_A41ClinicaCodigo = new String[] {""} ;
         T001D7_A41ClinicaCodigo = new String[] {""} ;
         T001D8_A41ClinicaCodigo = new String[] {""} ;
         T001D9_A41ClinicaCodigo = new String[] {""} ;
         T001D9_A185FacturaId = new int[1] ;
         T001D9_A260FacturaPId = new int[1] ;
         T001D3_A260FacturaPId = new int[1] ;
         T001D3_A261FacturaPMonto = new decimal[1] ;
         T001D3_A262FacturaPDocto = new String[] {""} ;
         T001D3_A264FacturaPDetalle = new String[] {""} ;
         T001D3_A41ClinicaCodigo = new String[] {""} ;
         T001D3_A65FormaPagoCodigo = new String[] {""} ;
         T001D3_A185FacturaId = new int[1] ;
         sMode63 = "" ;
         T001D10_A41ClinicaCodigo = new String[] {""} ;
         T001D10_A185FacturaId = new int[1] ;
         T001D10_A260FacturaPId = new int[1] ;
         T001D11_A41ClinicaCodigo = new String[] {""} ;
         T001D11_A185FacturaId = new int[1] ;
         T001D11_A260FacturaPId = new int[1] ;
         T001D12_A260FacturaPId = new int[1] ;
         T001D12_A261FacturaPMonto = new decimal[1] ;
         T001D12_A262FacturaPDocto = new String[] {""} ;
         T001D12_A264FacturaPDetalle = new String[] {""} ;
         T001D12_A41ClinicaCodigo = new String[] {""} ;
         T001D12_A65FormaPagoCodigo = new String[] {""} ;
         T001D12_A185FacturaId = new int[1] ;
         T001D16_A41ClinicaCodigo = new String[] {""} ;
         T001D16_A185FacturaId = new int[1] ;
         T001D16_A260FacturaPId = new int[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         T001D17_A41ClinicaCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         T001D18_A41ClinicaCodigo = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.facturapago__default(),
            new Object[][] {
                new Object[] {
               T001D2_A260FacturaPId, T001D2_A261FacturaPMonto, T001D2_A262FacturaPDocto, T001D2_A264FacturaPDetalle, T001D2_A41ClinicaCodigo, T001D2_A65FormaPagoCodigo, T001D2_A185FacturaId
               }
               , new Object[] {
               T001D3_A260FacturaPId, T001D3_A261FacturaPMonto, T001D3_A262FacturaPDocto, T001D3_A264FacturaPDetalle, T001D3_A41ClinicaCodigo, T001D3_A65FormaPagoCodigo, T001D3_A185FacturaId
               }
               , new Object[] {
               T001D4_A41ClinicaCodigo
               }
               , new Object[] {
               T001D5_A41ClinicaCodigo
               }
               , new Object[] {
               T001D6_A260FacturaPId, T001D6_A261FacturaPMonto, T001D6_A262FacturaPDocto, T001D6_A264FacturaPDetalle, T001D6_A41ClinicaCodigo, T001D6_A65FormaPagoCodigo, T001D6_A185FacturaId
               }
               , new Object[] {
               T001D7_A41ClinicaCodigo
               }
               , new Object[] {
               T001D8_A41ClinicaCodigo
               }
               , new Object[] {
               T001D9_A41ClinicaCodigo, T001D9_A185FacturaId, T001D9_A260FacturaPId
               }
               , new Object[] {
               T001D10_A41ClinicaCodigo, T001D10_A185FacturaId, T001D10_A260FacturaPId
               }
               , new Object[] {
               T001D11_A41ClinicaCodigo, T001D11_A185FacturaId, T001D11_A260FacturaPId
               }
               , new Object[] {
               T001D12_A260FacturaPId, T001D12_A261FacturaPMonto, T001D12_A262FacturaPDocto, T001D12_A264FacturaPDetalle, T001D12_A41ClinicaCodigo, T001D12_A65FormaPagoCodigo, T001D12_A185FacturaId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001D16_A41ClinicaCodigo, T001D16_A185FacturaId, T001D16_A260FacturaPId
               }
               , new Object[] {
               T001D17_A41ClinicaCodigo
               }
               , new Object[] {
               T001D18_A41ClinicaCodigo
               }
            }
         );
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short GX_JID ;
      private short RcdFound63 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int A185FacturaId ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int edtFacturaId_Enabled ;
      private int imgprompt_41_185_Visible ;
      private int A260FacturaPId ;
      private int edtFacturaPId_Enabled ;
      private int edtFormaPagoCodigo_Enabled ;
      private int imgprompt_41_65_Visible ;
      private int edtFacturaPMonto_Enabled ;
      private int edtFacturaPDocto_Enabled ;
      private int edtFacturaPDetalle_Enabled ;
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
      private int Z185FacturaId ;
      private int Z260FacturaPId ;
      private int AnyError41 ;
      private int AnyError65 ;
      private int AnyError185 ;
      private int idxLst ;
      private decimal A261FacturaPMonto ;
      private decimal Z261FacturaPMonto ;
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
      private String lblTextblockfacturaid_Internalname ;
      private String lblTextblockfacturaid_Jsonclick ;
      private String edtFacturaId_Internalname ;
      private String edtFacturaId_Jsonclick ;
      private String imgprompt_41_185_Internalname ;
      private String imgprompt_41_185_Link ;
      private String lblTextblockfacturapid_Internalname ;
      private String lblTextblockfacturapid_Jsonclick ;
      private String edtFacturaPId_Internalname ;
      private String edtFacturaPId_Jsonclick ;
      private String lblTextblockformapagocodigo_Internalname ;
      private String lblTextblockformapagocodigo_Jsonclick ;
      private String edtFormaPagoCodigo_Internalname ;
      private String edtFormaPagoCodigo_Jsonclick ;
      private String imgprompt_41_65_Internalname ;
      private String imgprompt_41_65_Link ;
      private String lblTextblockfacturapmonto_Internalname ;
      private String lblTextblockfacturapmonto_Jsonclick ;
      private String edtFacturaPMonto_Internalname ;
      private String edtFacturaPMonto_Jsonclick ;
      private String lblTextblockfacturapdocto_Internalname ;
      private String lblTextblockfacturapdocto_Jsonclick ;
      private String edtFacturaPDocto_Internalname ;
      private String edtFacturaPDocto_Jsonclick ;
      private String lblTextblockfacturapdetalle_Internalname ;
      private String lblTextblockfacturapdetalle_Jsonclick ;
      private String edtFacturaPDetalle_Internalname ;
      private String edtFacturaPDetalle_Jsonclick ;
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
      private String sMode63 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A41ClinicaCodigo ;
      private String A65FormaPagoCodigo ;
      private String A262FacturaPDocto ;
      private String A264FacturaPDetalle ;
      private String Z41ClinicaCodigo ;
      private String Z262FacturaPDocto ;
      private String Z264FacturaPDetalle ;
      private String Z65FormaPagoCodigo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T001D6_A260FacturaPId ;
      private decimal[] T001D6_A261FacturaPMonto ;
      private String[] T001D6_A262FacturaPDocto ;
      private String[] T001D6_A264FacturaPDetalle ;
      private String[] T001D6_A41ClinicaCodigo ;
      private String[] T001D6_A65FormaPagoCodigo ;
      private int[] T001D6_A185FacturaId ;
      private String[] T001D4_A41ClinicaCodigo ;
      private String[] T001D5_A41ClinicaCodigo ;
      private String[] T001D7_A41ClinicaCodigo ;
      private String[] T001D8_A41ClinicaCodigo ;
      private String[] T001D9_A41ClinicaCodigo ;
      private int[] T001D9_A185FacturaId ;
      private int[] T001D9_A260FacturaPId ;
      private int[] T001D3_A260FacturaPId ;
      private decimal[] T001D3_A261FacturaPMonto ;
      private String[] T001D3_A262FacturaPDocto ;
      private String[] T001D3_A264FacturaPDetalle ;
      private String[] T001D3_A41ClinicaCodigo ;
      private String[] T001D3_A65FormaPagoCodigo ;
      private int[] T001D3_A185FacturaId ;
      private String[] T001D10_A41ClinicaCodigo ;
      private int[] T001D10_A185FacturaId ;
      private int[] T001D10_A260FacturaPId ;
      private String[] T001D11_A41ClinicaCodigo ;
      private int[] T001D11_A185FacturaId ;
      private int[] T001D11_A260FacturaPId ;
      private int[] T001D12_A260FacturaPId ;
      private decimal[] T001D12_A261FacturaPMonto ;
      private String[] T001D12_A262FacturaPDocto ;
      private String[] T001D12_A264FacturaPDetalle ;
      private String[] T001D12_A41ClinicaCodigo ;
      private String[] T001D12_A65FormaPagoCodigo ;
      private int[] T001D12_A185FacturaId ;
      private String[] T001D16_A41ClinicaCodigo ;
      private int[] T001D16_A185FacturaId ;
      private int[] T001D16_A260FacturaPId ;
      private String[] T001D17_A41ClinicaCodigo ;
      private String[] T001D18_A41ClinicaCodigo ;
      private int[] T001D2_A260FacturaPId ;
      private decimal[] T001D2_A261FacturaPMonto ;
      private String[] T001D2_A262FacturaPDocto ;
      private String[] T001D2_A264FacturaPDetalle ;
      private String[] T001D2_A41ClinicaCodigo ;
      private String[] T001D2_A65FormaPagoCodigo ;
      private int[] T001D2_A185FacturaId ;
      private GXWebForm Form ;
   }

   public class facturapago__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new UpdateCursor(def[12])
         ,new UpdateCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT001D2 ;
          prmT001D2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaPId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001D6 ;
          prmT001D6 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaPId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001D4 ;
          prmT001D4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FormaPagoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001D5 ;
          prmT001D5 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001D7 ;
          prmT001D7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FormaPagoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001D8 ;
          prmT001D8 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001D9 ;
          prmT001D9 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaPId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001D3 ;
          prmT001D3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaPId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001D10 ;
          prmT001D10 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaPId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001D11 ;
          prmT001D11 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaPId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001D12 ;
          prmT001D12 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaPId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001D13 ;
          prmT001D13 = new Object[] {
          new Object[] {"@FacturaPId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaPMonto",SqlDbType.Decimal,17,2} ,
          new Object[] {"@FacturaPDocto",SqlDbType.VarChar,60,0} ,
          new Object[] {"@FacturaPDetalle",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FormaPagoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001D14 ;
          prmT001D14 = new Object[] {
          new Object[] {"@FacturaPMonto",SqlDbType.Decimal,17,2} ,
          new Object[] {"@FacturaPDocto",SqlDbType.VarChar,60,0} ,
          new Object[] {"@FacturaPDetalle",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FormaPagoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaPId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001D15 ;
          prmT001D15 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaPId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001D16 ;
          prmT001D16 = new Object[] {
          } ;
          Object[] prmT001D17 ;
          prmT001D17 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001D18 ;
          prmT001D18 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FormaPagoCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T001D2", "SELECT [FacturaPId], [FacturaPMonto], [FacturaPDocto], [FacturaPDetalle], [ClinicaCodigo], [FormaPagoCodigo], [FacturaId] FROM [FacturaPago] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId AND [FacturaPId] = @FacturaPId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001D2,1,0,true,false )
             ,new CursorDef("T001D3", "SELECT [FacturaPId], [FacturaPMonto], [FacturaPDocto], [FacturaPDetalle], [ClinicaCodigo], [FormaPagoCodigo], [FacturaId] FROM [FacturaPago] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId AND [FacturaPId] = @FacturaPId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001D3,1,0,true,false )
             ,new CursorDef("T001D4", "SELECT [ClinicaCodigo] FROM [FormaPago] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FormaPagoCodigo] = @FormaPagoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001D4,1,0,true,false )
             ,new CursorDef("T001D5", "SELECT [ClinicaCodigo] FROM [Factura] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001D5,1,0,true,false )
             ,new CursorDef("T001D6", "SELECT TM1.[FacturaPId], TM1.[FacturaPMonto], TM1.[FacturaPDocto], TM1.[FacturaPDetalle], TM1.[ClinicaCodigo], TM1.[FormaPagoCodigo], TM1.[FacturaId] FROM [FacturaPago] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[FacturaId] = @FacturaId and TM1.[FacturaPId] = @FacturaPId ORDER BY TM1.[ClinicaCodigo], TM1.[FacturaId], TM1.[FacturaPId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001D6,100,0,true,false )
             ,new CursorDef("T001D7", "SELECT [ClinicaCodigo] FROM [FormaPago] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FormaPagoCodigo] = @FormaPagoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001D7,1,0,true,false )
             ,new CursorDef("T001D8", "SELECT [ClinicaCodigo] FROM [Factura] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001D8,1,0,true,false )
             ,new CursorDef("T001D9", "SELECT [ClinicaCodigo], [FacturaId], [FacturaPId] FROM [FacturaPago] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId AND [FacturaPId] = @FacturaPId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001D9,1,0,true,false )
             ,new CursorDef("T001D10", "SELECT TOP 1 [ClinicaCodigo], [FacturaId], [FacturaPId] FROM [FacturaPago] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [FacturaId] > @FacturaId or [FacturaId] = @FacturaId and [ClinicaCodigo] = @ClinicaCodigo and [FacturaPId] > @FacturaPId) ORDER BY [ClinicaCodigo], [FacturaId], [FacturaPId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001D10,1,0,true,true )
             ,new CursorDef("T001D11", "SELECT TOP 1 [ClinicaCodigo], [FacturaId], [FacturaPId] FROM [FacturaPago] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [FacturaId] < @FacturaId or [FacturaId] = @FacturaId and [ClinicaCodigo] = @ClinicaCodigo and [FacturaPId] < @FacturaPId) ORDER BY [ClinicaCodigo] DESC, [FacturaId] DESC, [FacturaPId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001D11,1,0,true,true )
             ,new CursorDef("T001D12", "SELECT [FacturaPId], [FacturaPMonto], [FacturaPDocto], [FacturaPDetalle], [ClinicaCodigo], [FormaPagoCodigo], [FacturaId] FROM [FacturaPago] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId AND [FacturaPId] = @FacturaPId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001D12,1,0,true,false )
             ,new CursorDef("T001D13", "INSERT INTO [FacturaPago] ([FacturaPId], [FacturaPMonto], [FacturaPDocto], [FacturaPDetalle], [ClinicaCodigo], [FormaPagoCodigo], [FacturaId]) VALUES (@FacturaPId, @FacturaPMonto, @FacturaPDocto, @FacturaPDetalle, @ClinicaCodigo, @FormaPagoCodigo, @FacturaId)", GxErrorMask.GX_NOMASK,prmT001D13)
             ,new CursorDef("T001D14", "UPDATE [FacturaPago] SET [FacturaPMonto]=@FacturaPMonto, [FacturaPDocto]=@FacturaPDocto, [FacturaPDetalle]=@FacturaPDetalle, [FormaPagoCodigo]=@FormaPagoCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId AND [FacturaPId] = @FacturaPId", GxErrorMask.GX_NOMASK,prmT001D14)
             ,new CursorDef("T001D15", "DELETE FROM [FacturaPago]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId AND [FacturaPId] = @FacturaPId", GxErrorMask.GX_NOMASK,prmT001D15)
             ,new CursorDef("T001D16", "SELECT [ClinicaCodigo], [FacturaId], [FacturaPId] FROM [FacturaPago] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [FacturaId], [FacturaPId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001D16,100,0,true,false )
             ,new CursorDef("T001D17", "SELECT [ClinicaCodigo] FROM [Factura] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001D17,1,0,true,false )
             ,new CursorDef("T001D18", "SELECT [ClinicaCodigo] FROM [FormaPago] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FormaPagoCodigo] = @FormaPagoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001D18,1,0,true,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 10 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 16 :
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
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 11 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (decimal)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                break;
             case 12 :
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 15 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
