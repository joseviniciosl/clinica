/*
               File: CierreMensualC
        Description: Cierre mensual de contabilidad
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:6:30.77
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
   public class cierremensualc : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_3") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A193CtaContableCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_3( A41ClinicaCodigo, A193CtaContableCodigo) ;
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
         Form.Meta.addItem("Description", "Cierre mensual de contabilidad", 0) ;
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

      public cierremensualc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public cierremensualc( IGxContext context )
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
            wb_table1_2_1756( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1756e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1756( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1756( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1756e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Cierre mensual de contabilidad"+"</legend>") ;
            wb_table3_27_1756( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_1756e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1756e( true) ;
         }
         else
         {
            wb_table1_2_1756e( false) ;
         }
      }

      protected void wb_table3_27_1756( bool wbgen )
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
            wb_table4_33_1756( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_1756e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_CierreMensualC.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_CierreMensualC.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_CierreMensualC.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_1756e( true) ;
         }
         else
         {
            wb_table3_27_1756e( false) ;
         }
      }

      protected void wb_table4_33_1756( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CierreMensualC.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_CierreMensualC.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcierremcanio_Internalname, "Año", "", "", lblTextblockcierremcanio_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CierreMensualC.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225CierreMCAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A225CierreMCAnio), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCierreMCAnio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A225CierreMCAnio), 4, 0, ".", "")), ((edtCierreMCAnio_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A225CierreMCAnio), "ZZZ9")) : context.localUtil.Format( (decimal)(A225CierreMCAnio), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(43);\"", "", "", "", "", edtCierreMCAnio_Jsonclick, 0, ClassString, StyleString, "", 1, edtCierreMCAnio_Enabled, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_CierreMensualC.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcierremcmes_Internalname, "Mes", "", "", lblTextblockcierremcmes_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CierreMensualC.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226CierreMCMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A226CierreMCMes), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCierreMCMes_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A226CierreMCMes), 4, 0, ".", "")), ((edtCierreMCMes_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A226CierreMCMes), "ZZZ9")) : context.localUtil.Format( (decimal)(A226CierreMCMes), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(48);\"", "", "", "", "", edtCierreMCMes_Jsonclick, 0, ClassString, StyleString, "", 1, edtCierreMCMes_Enabled, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_CierreMensualC.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockctacontablecodigo_Internalname, "Cta_Contable", "", "", lblTextblockctacontablecodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CierreMensualC.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCtaContableCodigo_Internalname, StringUtil.RTrim( A193CtaContableCodigo), StringUtil.RTrim( context.localUtil.Format( A193CtaContableCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "", "", "", "", edtCtaContableCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtCtaContableCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_CierreMensualC.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_193_Internalname, "prompt.gif", imgprompt_41_193_Link, "", "", "Fantastic", imgprompt_41_193_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_CierreMensualC.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcierremcdebe_Internalname, "Debe", "", "", lblTextblockcierremcdebe_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CierreMensualC.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227CierreMCDebe", StringUtil.LTrim( StringUtil.Str( A227CierreMCDebe, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCierreMCDebe_Internalname, StringUtil.LTrim( StringUtil.NToC( A227CierreMCDebe, 17, 2, ".", "")), ((edtCierreMCDebe_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A227CierreMCDebe, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A227CierreMCDebe, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(58);\"", "", "", "", "", edtCierreMCDebe_Jsonclick, 0, ClassString, StyleString, "", 1, edtCierreMCDebe_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_CierreMensualC.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcierremchaber_Internalname, "Haber", "", "", lblTextblockcierremchaber_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CierreMensualC.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228CierreMCHaber", StringUtil.LTrim( StringUtil.Str( A228CierreMCHaber, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCierreMCHaber_Internalname, StringUtil.LTrim( StringUtil.NToC( A228CierreMCHaber, 17, 2, ".", "")), ((edtCierreMCHaber_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A228CierreMCHaber, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A228CierreMCHaber, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(63);\"", "", "", "", "", edtCierreMCHaber_Jsonclick, 0, ClassString, StyleString, "", 1, edtCierreMCHaber_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_CierreMensualC.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcierremcinicial_Internalname, "Inicial", "", "", lblTextblockcierremcinicial_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CierreMensualC.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A300CierreMCInicial", StringUtil.LTrim( StringUtil.Str( A300CierreMCInicial, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCierreMCInicial_Internalname, StringUtil.LTrim( StringUtil.NToC( A300CierreMCInicial, 17, 2, ".", "")), ((edtCierreMCInicial_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A300CierreMCInicial, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A300CierreMCInicial, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(68);\"", "", "", "", "", edtCierreMCInicial_Jsonclick, 0, ClassString, StyleString, "", 1, edtCierreMCInicial_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_CierreMensualC.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcierremcfinal_Internalname, "Final", "", "", lblTextblockcierremcfinal_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CierreMensualC.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301CierreMCFinal", StringUtil.LTrim( StringUtil.Str( A301CierreMCFinal, 17, 2)));
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCierreMCFinal_Internalname, StringUtil.LTrim( StringUtil.NToC( A301CierreMCFinal, 17, 2, ".", "")), ((edtCierreMCFinal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A301CierreMCFinal, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A301CierreMCFinal, "ZZZZZZZZZZZZZ9.99")), "", "", "", "", "", edtCierreMCFinal_Jsonclick, 0, ClassString, StyleString, "", 1, edtCierreMCFinal_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_CierreMensualC.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_1756e( true) ;
         }
         else
         {
            wb_table4_33_1756e( false) ;
         }
      }

      protected void wb_table2_5_1756( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CierreMensualC.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CierreMensualC.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CierreMensualC.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CierreMensualC.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CierreMensualC.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CierreMensualC.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CierreMensualC.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CierreMensualC.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01k0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CIERREMCANIO"+"'), id:'"+"CIERREMCANIO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CIERREMCMES"+"'), id:'"+"CIERREMCMES"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CTACONTABLECODIGO"+"'), id:'"+"CTACONTABLECODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_CierreMensualC.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01k0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CIERREMCANIO"+"'), id:'"+"CIERREMCANIO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CIERREMCMES"+"'), id:'"+"CIERREMCMES"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CTACONTABLECODIGO"+"'), id:'"+"CTACONTABLECODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_CierreMensualC.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CierreMensualC.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CierreMensualC.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CierreMensualC.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CierreMensualC.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CierreMensualC.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CierreMensualC.htm");
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
            wb_table2_5_1756e( true) ;
         }
         else
         {
            wb_table2_5_1756e( false) ;
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtCierreMCAnio_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCierreMCAnio_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CIERREMCANIO");
                  AnyError = 1 ;
                  GX_FocusControl = edtCierreMCAnio_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A225CierreMCAnio = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225CierreMCAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A225CierreMCAnio), 4, 0)));
               }
               else
               {
                  A225CierreMCAnio = (short)(context.localUtil.CToN( cgiGet( edtCierreMCAnio_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225CierreMCAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A225CierreMCAnio), 4, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtCierreMCMes_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCierreMCMes_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CIERREMCMES");
                  AnyError = 1 ;
                  GX_FocusControl = edtCierreMCMes_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A226CierreMCMes = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226CierreMCMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A226CierreMCMes), 4, 0)));
               }
               else
               {
                  A226CierreMCMes = (short)(context.localUtil.CToN( cgiGet( edtCierreMCMes_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226CierreMCMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A226CierreMCMes), 4, 0)));
               }
               A193CtaContableCodigo = cgiGet( edtCtaContableCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
               if ( ( ( context.localUtil.CToN( cgiGet( edtCierreMCDebe_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCierreMCDebe_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CIERREMCDEBE");
                  AnyError = 1 ;
                  GX_FocusControl = edtCierreMCDebe_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A227CierreMCDebe = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227CierreMCDebe", StringUtil.LTrim( StringUtil.Str( A227CierreMCDebe, 17, 2)));
               }
               else
               {
                  A227CierreMCDebe = context.localUtil.CToN( cgiGet( edtCierreMCDebe_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227CierreMCDebe", StringUtil.LTrim( StringUtil.Str( A227CierreMCDebe, 17, 2)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtCierreMCHaber_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCierreMCHaber_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CIERREMCHABER");
                  AnyError = 1 ;
                  GX_FocusControl = edtCierreMCHaber_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A228CierreMCHaber = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228CierreMCHaber", StringUtil.LTrim( StringUtil.Str( A228CierreMCHaber, 17, 2)));
               }
               else
               {
                  A228CierreMCHaber = context.localUtil.CToN( cgiGet( edtCierreMCHaber_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228CierreMCHaber", StringUtil.LTrim( StringUtil.Str( A228CierreMCHaber, 17, 2)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtCierreMCInicial_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCierreMCInicial_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CIERREMCINICIAL");
                  AnyError = 1 ;
                  GX_FocusControl = edtCierreMCInicial_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A300CierreMCInicial = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A300CierreMCInicial", StringUtil.LTrim( StringUtil.Str( A300CierreMCInicial, 17, 2)));
               }
               else
               {
                  A300CierreMCInicial = context.localUtil.CToN( cgiGet( edtCierreMCInicial_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A300CierreMCInicial", StringUtil.LTrim( StringUtil.Str( A300CierreMCInicial, 17, 2)));
               }
               A301CierreMCFinal = context.localUtil.CToN( cgiGet( edtCierreMCFinal_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301CierreMCFinal", StringUtil.LTrim( StringUtil.Str( A301CierreMCFinal, 17, 2)));
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z225CierreMCAnio = (short)(context.localUtil.CToN( cgiGet( "Z225CierreMCAnio"), ".", ",")) ;
               Z226CierreMCMes = (short)(context.localUtil.CToN( cgiGet( "Z226CierreMCMes"), ".", ",")) ;
               Z193CtaContableCodigo = cgiGet( "Z193CtaContableCodigo") ;
               Z227CierreMCDebe = context.localUtil.CToN( cgiGet( "Z227CierreMCDebe"), ".", ",") ;
               Z228CierreMCHaber = context.localUtil.CToN( cgiGet( "Z228CierreMCHaber"), ".", ",") ;
               Z300CierreMCInicial = context.localUtil.CToN( cgiGet( "Z300CierreMCInicial"), ".", ",") ;
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
                  A225CierreMCAnio = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225CierreMCAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A225CierreMCAnio), 4, 0)));
                  A226CierreMCMes = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226CierreMCMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A226CierreMCMes), 4, 0)));
                  A193CtaContableCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
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
               InitAll1756( ) ;
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
         DisableAttributes1756( ) ;
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

      protected void ResetCaption170( )
      {
      }

      protected void ZM1756( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z227CierreMCDebe = T00173_A227CierreMCDebe[0] ;
               Z228CierreMCHaber = T00173_A228CierreMCHaber[0] ;
               Z300CierreMCInicial = T00173_A300CierreMCInicial[0] ;
            }
            else
            {
               Z227CierreMCDebe = A227CierreMCDebe ;
               Z228CierreMCHaber = A228CierreMCHaber ;
               Z300CierreMCInicial = A300CierreMCInicial ;
            }
         }
         if ( GX_JID == -2 )
         {
            Z225CierreMCAnio = A225CierreMCAnio ;
            Z226CierreMCMes = A226CierreMCMes ;
            Z227CierreMCDebe = A227CierreMCDebe ;
            Z228CierreMCHaber = A228CierreMCHaber ;
            Z300CierreMCInicial = A300CierreMCInicial ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z193CtaContableCodigo = A193CtaContableCodigo ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_41_193_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx01e0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CTACONTABLECODIGO"+"'), id:'"+"CTACONTABLECODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");") ;
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

      protected void Load1756( )
      {
         /* Using cursor T00175 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A225CierreMCAnio, A226CierreMCMes, A193CtaContableCodigo});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound56 = 1 ;
            A227CierreMCDebe = T00175_A227CierreMCDebe[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227CierreMCDebe", StringUtil.LTrim( StringUtil.Str( A227CierreMCDebe, 17, 2)));
            A228CierreMCHaber = T00175_A228CierreMCHaber[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228CierreMCHaber", StringUtil.LTrim( StringUtil.Str( A228CierreMCHaber, 17, 2)));
            A300CierreMCInicial = T00175_A300CierreMCInicial[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A300CierreMCInicial", StringUtil.LTrim( StringUtil.Str( A300CierreMCInicial, 17, 2)));
            ZM1756( -2) ;
         }
         pr_default.close(3);
         OnLoadActions1756( ) ;
      }

      protected void OnLoadActions1756( )
      {
         A301CierreMCFinal = (decimal)(+A300CierreMCInicial+A227CierreMCDebe-A228CierreMCHaber) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301CierreMCFinal", StringUtil.LTrim( StringUtil.Str( A301CierreMCFinal, 17, 2)));
      }

      protected void CheckExtendedTable1756( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T00174 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError41 = 1 ;
            AnyError193 = 1 ;
            GX_msglist.addItem("No existe 'Catálogo de Cuentas Contables'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError193 == 0 ) )
         {
         }
         pr_default.close(2);
         A301CierreMCFinal = (decimal)(+A300CierreMCInicial+A227CierreMCDebe-A228CierreMCHaber) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301CierreMCFinal", StringUtil.LTrim( StringUtil.Str( A301CierreMCFinal, 17, 2)));
      }

      protected void CloseExtendedTableCursors1756( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_3( String A41ClinicaCodigo ,
                               String A193CtaContableCodigo )
      {
         /* Using cursor T00176 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
         if ( (pr_default.getStatus(4) == 101) )
         {
            AnyError41 = 1 ;
            AnyError193 = 1 ;
            GX_msglist.addItem("No existe 'Catálogo de Cuentas Contables'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError193 == 0 ) )
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

      protected void GetKey1756( )
      {
         /* Using cursor T00177 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A225CierreMCAnio, A226CierreMCMes, A193CtaContableCodigo});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound56 = 1 ;
         }
         else
         {
            RcdFound56 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00173 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A225CierreMCAnio, A226CierreMCMes, A193CtaContableCodigo});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1756( 2) ;
            RcdFound56 = 1 ;
            A225CierreMCAnio = T00173_A225CierreMCAnio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225CierreMCAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A225CierreMCAnio), 4, 0)));
            A226CierreMCMes = T00173_A226CierreMCMes[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226CierreMCMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A226CierreMCMes), 4, 0)));
            A227CierreMCDebe = T00173_A227CierreMCDebe[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227CierreMCDebe", StringUtil.LTrim( StringUtil.Str( A227CierreMCDebe, 17, 2)));
            A228CierreMCHaber = T00173_A228CierreMCHaber[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228CierreMCHaber", StringUtil.LTrim( StringUtil.Str( A228CierreMCHaber, 17, 2)));
            A300CierreMCInicial = T00173_A300CierreMCInicial[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A300CierreMCInicial", StringUtil.LTrim( StringUtil.Str( A300CierreMCInicial, 17, 2)));
            A41ClinicaCodigo = T00173_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A193CtaContableCodigo = T00173_A193CtaContableCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z225CierreMCAnio = A225CierreMCAnio ;
            Z226CierreMCMes = A226CierreMCMes ;
            Z193CtaContableCodigo = A193CtaContableCodigo ;
            sMode56 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1756( ) ;
            Gx_mode = sMode56 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound56 = 0 ;
            InitializeNonKey1756( ) ;
            sMode56 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode56 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1756( ) ;
         if ( RcdFound56 == 0 )
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
         RcdFound56 = 0 ;
         /* Using cursor T00178 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, A225CierreMCAnio, A226CierreMCMes, A193CtaContableCodigo});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T00178_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T00178_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T00178_A225CierreMCAnio[0] < A225CierreMCAnio ) || ( T00178_A225CierreMCAnio[0] == A225CierreMCAnio ) && ( StringUtil.StrCmp(T00178_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T00178_A226CierreMCMes[0] < A226CierreMCMes ) || ( T00178_A226CierreMCMes[0] == A226CierreMCMes ) && ( T00178_A225CierreMCAnio[0] == A225CierreMCAnio ) && ( StringUtil.StrCmp(T00178_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T00178_A193CtaContableCodigo[0], A193CtaContableCodigo) < 0 ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T00178_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T00178_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T00178_A225CierreMCAnio[0] > A225CierreMCAnio ) || ( T00178_A225CierreMCAnio[0] == A225CierreMCAnio ) && ( StringUtil.StrCmp(T00178_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T00178_A226CierreMCMes[0] > A226CierreMCMes ) || ( T00178_A226CierreMCMes[0] == A226CierreMCMes ) && ( T00178_A225CierreMCAnio[0] == A225CierreMCAnio ) && ( StringUtil.StrCmp(T00178_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T00178_A193CtaContableCodigo[0], A193CtaContableCodigo) > 0 ) ) )
            {
               A41ClinicaCodigo = T00178_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A225CierreMCAnio = T00178_A225CierreMCAnio[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225CierreMCAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A225CierreMCAnio), 4, 0)));
               A226CierreMCMes = T00178_A226CierreMCMes[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226CierreMCMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A226CierreMCMes), 4, 0)));
               A193CtaContableCodigo = T00178_A193CtaContableCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
               RcdFound56 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound56 = 0 ;
         /* Using cursor T00179 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A225CierreMCAnio, A226CierreMCMes, A193CtaContableCodigo});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T00179_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T00179_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T00179_A225CierreMCAnio[0] > A225CierreMCAnio ) || ( T00179_A225CierreMCAnio[0] == A225CierreMCAnio ) && ( StringUtil.StrCmp(T00179_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T00179_A226CierreMCMes[0] > A226CierreMCMes ) || ( T00179_A226CierreMCMes[0] == A226CierreMCMes ) && ( T00179_A225CierreMCAnio[0] == A225CierreMCAnio ) && ( StringUtil.StrCmp(T00179_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T00179_A193CtaContableCodigo[0], A193CtaContableCodigo) > 0 ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T00179_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T00179_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T00179_A225CierreMCAnio[0] < A225CierreMCAnio ) || ( T00179_A225CierreMCAnio[0] == A225CierreMCAnio ) && ( StringUtil.StrCmp(T00179_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T00179_A226CierreMCMes[0] < A226CierreMCMes ) || ( T00179_A226CierreMCMes[0] == A226CierreMCMes ) && ( T00179_A225CierreMCAnio[0] == A225CierreMCAnio ) && ( StringUtil.StrCmp(T00179_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T00179_A193CtaContableCodigo[0], A193CtaContableCodigo) < 0 ) ) )
            {
               A41ClinicaCodigo = T00179_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A225CierreMCAnio = T00179_A225CierreMCAnio[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225CierreMCAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A225CierreMCAnio), 4, 0)));
               A226CierreMCMes = T00179_A226CierreMCMes[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226CierreMCMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A226CierreMCMes), 4, 0)));
               A193CtaContableCodigo = T00179_A193CtaContableCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
               RcdFound56 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1756( ) ;
         if ( RcdFound56 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A225CierreMCAnio != Z225CierreMCAnio ) || ( A226CierreMCMes != Z226CierreMCMes ) || ( StringUtil.StrCmp(A193CtaContableCodigo, Z193CtaContableCodigo) != 0 ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A225CierreMCAnio = Z225CierreMCAnio ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225CierreMCAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A225CierreMCAnio), 4, 0)));
               A226CierreMCMes = Z226CierreMCMes ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226CierreMCMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A226CierreMCMes), 4, 0)));
               A193CtaContableCodigo = Z193CtaContableCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
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
               Update1756( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A225CierreMCAnio != Z225CierreMCAnio ) || ( A226CierreMCMes != Z226CierreMCMes ) || ( StringUtil.StrCmp(A193CtaContableCodigo, Z193CtaContableCodigo) != 0 ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert1756( ) ;
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
                  Insert1756( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A225CierreMCAnio != Z225CierreMCAnio ) || ( A226CierreMCMes != Z226CierreMCMes ) || ( StringUtil.StrCmp(A193CtaContableCodigo, Z193CtaContableCodigo) != 0 ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A225CierreMCAnio = Z225CierreMCAnio ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225CierreMCAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A225CierreMCAnio), 4, 0)));
            A226CierreMCMes = Z226CierreMCMes ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226CierreMCMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A226CierreMCMes), 4, 0)));
            A193CtaContableCodigo = Z193CtaContableCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
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
         if ( RcdFound56 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtCierreMCDebe_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1756( ) ;
         if ( RcdFound56 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCierreMCDebe_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1756( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound56 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCierreMCDebe_Internalname ;
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
         if ( RcdFound56 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCierreMCDebe_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1756( ) ;
         if ( RcdFound56 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound56 != 0 )
            {
               ScanNext1756( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCierreMCDebe_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1756( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1756( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001710 */
            pr_default.execute(8, new Object[] {A41ClinicaCodigo, A225CierreMCAnio, A226CierreMCMes, A193CtaContableCodigo});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CierreMensualC"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(8) == 101) || ( Z227CierreMCDebe != T001710_A227CierreMCDebe[0] ) || ( Z228CierreMCHaber != T001710_A228CierreMCHaber[0] ) || ( Z300CierreMCInicial != T001710_A300CierreMCInicial[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"CierreMensualC"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1756( )
      {
         BeforeValidate1756( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1756( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1756( 0) ;
            CheckOptimisticConcurrency1756( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1756( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1756( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001711 */
                     pr_default.execute(9, new Object[] {A225CierreMCAnio, A226CierreMCMes, A227CierreMCDebe, A228CierreMCHaber, A300CierreMCInicial, A41ClinicaCodigo, A193CtaContableCodigo});
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
                           ResetCaption170( ) ;
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
               Load1756( ) ;
            }
            EndLevel1756( ) ;
         }
         CloseExtendedTableCursors1756( ) ;
      }

      protected void Update1756( )
      {
         BeforeValidate1756( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1756( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1756( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1756( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1756( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001712 */
                     pr_default.execute(10, new Object[] {A227CierreMCDebe, A228CierreMCHaber, A300CierreMCInicial, A41ClinicaCodigo, A225CierreMCAnio, A226CierreMCMes, A193CtaContableCodigo});
                     pr_default.close(10);
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CierreMensualC"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1756( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                           ResetCaption170( ) ;
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
            EndLevel1756( ) ;
         }
         CloseExtendedTableCursors1756( ) ;
      }

      protected void DeferredUpdate1756( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1756( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1756( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1756( ) ;
            AfterConfirm1756( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1756( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001713 */
                  pr_default.execute(11, new Object[] {A41ClinicaCodigo, A225CierreMCAnio, A226CierreMCMes, A193CtaContableCodigo});
                  pr_default.close(11);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound56 == 0 )
                        {
                           InitAll1756( ) ;
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
                        ResetCaption170( ) ;
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
         sMode56 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1756( ) ;
         Gx_mode = sMode56 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1756( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            A301CierreMCFinal = (decimal)(+A300CierreMCInicial+A227CierreMCDebe-A228CierreMCHaber) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301CierreMCFinal", StringUtil.LTrim( StringUtil.Str( A301CierreMCFinal, 17, 2)));
         }
      }

      protected void EndLevel1756( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1756( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(6);
            context.CommitDataStores("CierreMensualC");
            if ( AnyError == 0 )
            {
               ConfirmValues170( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(6);
            context.RollbackDataStores("CierreMensualC");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1756( )
      {
         /* Using cursor T001714 */
         pr_default.execute(12);
         RcdFound56 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound56 = 1 ;
            A41ClinicaCodigo = T001714_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A225CierreMCAnio = T001714_A225CierreMCAnio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225CierreMCAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A225CierreMCAnio), 4, 0)));
            A226CierreMCMes = T001714_A226CierreMCMes[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226CierreMCMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A226CierreMCMes), 4, 0)));
            A193CtaContableCodigo = T001714_A193CtaContableCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1756( )
      {
         pr_default.readNext(12);
         RcdFound56 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound56 = 1 ;
            A41ClinicaCodigo = T001714_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A225CierreMCAnio = T001714_A225CierreMCAnio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225CierreMCAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A225CierreMCAnio), 4, 0)));
            A226CierreMCMes = T001714_A226CierreMCMes[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226CierreMCMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A226CierreMCMes), 4, 0)));
            A193CtaContableCodigo = T001714_A193CtaContableCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
         }
      }

      protected void ScanEnd1756( )
      {
      }

      protected void AfterConfirm1756( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1756( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1756( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1756( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1756( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1756( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1756( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtCierreMCAnio_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCierreMCAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCierreMCAnio_Enabled), 5, 0)));
         edtCierreMCMes_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCierreMCMes_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCierreMCMes_Enabled), 5, 0)));
         edtCtaContableCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCtaContableCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCtaContableCodigo_Enabled), 5, 0)));
         edtCierreMCDebe_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCierreMCDebe_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCierreMCDebe_Enabled), 5, 0)));
         edtCierreMCHaber_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCierreMCHaber_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCierreMCHaber_Enabled), 5, 0)));
         edtCierreMCInicial_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCierreMCInicial_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCierreMCInicial_Enabled), 5, 0)));
         edtCierreMCFinal_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCierreMCFinal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCierreMCFinal_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues170( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("cierremensualc.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z225CierreMCAnio", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z225CierreMCAnio), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z226CierreMCMes", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z226CierreMCMes), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z193CtaContableCodigo", StringUtil.RTrim( Z193CtaContableCodigo));
         GxWebStd.gx_hidden_field( context, "Z227CierreMCDebe", StringUtil.LTrim( StringUtil.NToC( Z227CierreMCDebe, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z228CierreMCHaber", StringUtil.LTrim( StringUtil.NToC( Z228CierreMCHaber, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z300CierreMCInicial", StringUtil.LTrim( StringUtil.NToC( Z300CierreMCInicial, 17, 2, ".", "")));
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
         return "CierreMensualC" ;
      }

      public override String GetPgmdesc( )
      {
         return "Cierre mensual de contabilidad" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("cierremensualc.aspx")  ;
      }

      protected void InitializeNonKey1756( )
      {
         A301CierreMCFinal = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301CierreMCFinal", StringUtil.LTrim( StringUtil.Str( A301CierreMCFinal, 17, 2)));
         A227CierreMCDebe = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227CierreMCDebe", StringUtil.LTrim( StringUtil.Str( A227CierreMCDebe, 17, 2)));
         A228CierreMCHaber = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228CierreMCHaber", StringUtil.LTrim( StringUtil.Str( A228CierreMCHaber, 17, 2)));
         A300CierreMCInicial = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A300CierreMCInicial", StringUtil.LTrim( StringUtil.Str( A300CierreMCInicial, 17, 2)));
      }

      protected void InitAll1756( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A225CierreMCAnio = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225CierreMCAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A225CierreMCAnio), 4, 0)));
         A226CierreMCMes = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226CierreMCMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A226CierreMCMes), 4, 0)));
         A193CtaContableCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
         InitializeNonKey1756( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1563266");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("cierremensualc.js", "?1563266");
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
         lblTextblockcierremcanio_Internalname = "TEXTBLOCKCIERREMCANIO" ;
         edtCierreMCAnio_Internalname = "CIERREMCANIO" ;
         lblTextblockcierremcmes_Internalname = "TEXTBLOCKCIERREMCMES" ;
         edtCierreMCMes_Internalname = "CIERREMCMES" ;
         lblTextblockctacontablecodigo_Internalname = "TEXTBLOCKCTACONTABLECODIGO" ;
         edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO" ;
         lblTextblockcierremcdebe_Internalname = "TEXTBLOCKCIERREMCDEBE" ;
         edtCierreMCDebe_Internalname = "CIERREMCDEBE" ;
         lblTextblockcierremchaber_Internalname = "TEXTBLOCKCIERREMCHABER" ;
         edtCierreMCHaber_Internalname = "CIERREMCHABER" ;
         lblTextblockcierremcinicial_Internalname = "TEXTBLOCKCIERREMCINICIAL" ;
         edtCierreMCInicial_Internalname = "CIERREMCINICIAL" ;
         lblTextblockcierremcfinal_Internalname = "TEXTBLOCKCIERREMCFINAL" ;
         edtCierreMCFinal_Internalname = "CIERREMCFINAL" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_193_Internalname = "PROMPT_41_193" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Cierre mensual de contabilidad" ;
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
         edtCierreMCFinal_Jsonclick = "" ;
         edtCierreMCFinal_Enabled = 0 ;
         edtCierreMCInicial_Jsonclick = "" ;
         edtCierreMCInicial_Enabled = 1 ;
         edtCierreMCHaber_Jsonclick = "" ;
         edtCierreMCHaber_Enabled = 1 ;
         edtCierreMCDebe_Jsonclick = "" ;
         edtCierreMCDebe_Enabled = 1 ;
         imgprompt_41_193_Visible = 1 ;
         imgprompt_41_193_Link = "" ;
         edtCtaContableCodigo_Jsonclick = "" ;
         edtCtaContableCodigo_Enabled = 1 ;
         edtCierreMCMes_Jsonclick = "" ;
         edtCierreMCMes_Enabled = 1 ;
         edtCierreMCAnio_Jsonclick = "" ;
         edtCierreMCAnio_Enabled = 1 ;
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
         /* Using cursor T001715 */
         pr_default.execute(13, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
         if ( (pr_default.getStatus(13) == 101) )
         {
            AnyError41 = 1 ;
            AnyError193 = 1 ;
            GX_msglist.addItem("No existe 'Catálogo de Cuentas Contables'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError193 == 0 ) )
         {
         }
         pr_default.close(13);
         GX_FocusControl = edtCierreMCDebe_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Ctacontablecodigo( String GX_Parm1 ,
                                           short GX_Parm2 ,
                                           short GX_Parm3 ,
                                           String GX_Parm4 ,
                                           decimal GX_Parm5 ,
                                           decimal GX_Parm6 ,
                                           decimal GX_Parm7 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A225CierreMCAnio = GX_Parm2 ;
         A226CierreMCMes = GX_Parm3 ;
         A193CtaContableCodigo = GX_Parm4 ;
         A227CierreMCDebe = GX_Parm5 ;
         A228CierreMCHaber = GX_Parm6 ;
         A300CierreMCInicial = GX_Parm7 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         /* Using cursor T001715 */
         pr_default.execute(13, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
         if ( (pr_default.getStatus(13) == 101) )
         {
            AnyError41 = 1 ;
            AnyError193 = 1 ;
            GX_msglist.addItem("No existe 'Catálogo de Cuentas Contables'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError193 == 0 ) )
         {
         }
         pr_default.close(13);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A227CierreMCDebe, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A228CierreMCHaber, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A300CierreMCInicial, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A301CierreMCFinal, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z225CierreMCAnio), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z226CierreMCMes), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z193CtaContableCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z227CierreMCDebe, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z228CierreMCHaber, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z300CierreMCInicial, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z301CierreMCFinal, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
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
         pr_default.close(12);
         pr_default.close(7);
         pr_default.close(6);
         pr_default.close(13);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
         A193CtaContableCodigo = "" ;
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
         lblTextblockcierremcanio_Jsonclick = "" ;
         lblTextblockcierremcmes_Jsonclick = "" ;
         lblTextblockctacontablecodigo_Jsonclick = "" ;
         lblTextblockcierremcdebe_Jsonclick = "" ;
         lblTextblockcierremchaber_Jsonclick = "" ;
         lblTextblockcierremcinicial_Jsonclick = "" ;
         lblTextblockcierremcfinal_Jsonclick = "" ;
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
         Z193CtaContableCodigo = "" ;
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T00175_A225CierreMCAnio = new short[1] ;
         T00175_A226CierreMCMes = new short[1] ;
         T00175_A227CierreMCDebe = new decimal[1] ;
         T00175_A228CierreMCHaber = new decimal[1] ;
         T00175_A300CierreMCInicial = new decimal[1] ;
         T00175_A41ClinicaCodigo = new String[] {""} ;
         T00175_A193CtaContableCodigo = new String[] {""} ;
         T00174_A41ClinicaCodigo = new String[] {""} ;
         T00176_A41ClinicaCodigo = new String[] {""} ;
         T00177_A41ClinicaCodigo = new String[] {""} ;
         T00177_A225CierreMCAnio = new short[1] ;
         T00177_A226CierreMCMes = new short[1] ;
         T00177_A193CtaContableCodigo = new String[] {""} ;
         T00173_A225CierreMCAnio = new short[1] ;
         T00173_A226CierreMCMes = new short[1] ;
         T00173_A227CierreMCDebe = new decimal[1] ;
         T00173_A228CierreMCHaber = new decimal[1] ;
         T00173_A300CierreMCInicial = new decimal[1] ;
         T00173_A41ClinicaCodigo = new String[] {""} ;
         T00173_A193CtaContableCodigo = new String[] {""} ;
         sMode56 = "" ;
         T00178_A41ClinicaCodigo = new String[] {""} ;
         T00178_A225CierreMCAnio = new short[1] ;
         T00178_A226CierreMCMes = new short[1] ;
         T00178_A193CtaContableCodigo = new String[] {""} ;
         T00179_A41ClinicaCodigo = new String[] {""} ;
         T00179_A225CierreMCAnio = new short[1] ;
         T00179_A226CierreMCMes = new short[1] ;
         T00179_A193CtaContableCodigo = new String[] {""} ;
         T001710_A225CierreMCAnio = new short[1] ;
         T001710_A226CierreMCMes = new short[1] ;
         T001710_A227CierreMCDebe = new decimal[1] ;
         T001710_A228CierreMCHaber = new decimal[1] ;
         T001710_A300CierreMCInicial = new decimal[1] ;
         T001710_A41ClinicaCodigo = new String[] {""} ;
         T001710_A193CtaContableCodigo = new String[] {""} ;
         T001714_A41ClinicaCodigo = new String[] {""} ;
         T001714_A225CierreMCAnio = new short[1] ;
         T001714_A226CierreMCMes = new short[1] ;
         T001714_A193CtaContableCodigo = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         T001715_A41ClinicaCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cierremensualc__default(),
            new Object[][] {
                new Object[] {
               T00172_A225CierreMCAnio, T00172_A226CierreMCMes, T00172_A227CierreMCDebe, T00172_A228CierreMCHaber, T00172_A300CierreMCInicial, T00172_A41ClinicaCodigo, T00172_A193CtaContableCodigo
               }
               , new Object[] {
               T00173_A225CierreMCAnio, T00173_A226CierreMCMes, T00173_A227CierreMCDebe, T00173_A228CierreMCHaber, T00173_A300CierreMCInicial, T00173_A41ClinicaCodigo, T00173_A193CtaContableCodigo
               }
               , new Object[] {
               T00174_A41ClinicaCodigo
               }
               , new Object[] {
               T00175_A225CierreMCAnio, T00175_A226CierreMCMes, T00175_A227CierreMCDebe, T00175_A228CierreMCHaber, T00175_A300CierreMCInicial, T00175_A41ClinicaCodigo, T00175_A193CtaContableCodigo
               }
               , new Object[] {
               T00176_A41ClinicaCodigo
               }
               , new Object[] {
               T00177_A41ClinicaCodigo, T00177_A225CierreMCAnio, T00177_A226CierreMCMes, T00177_A193CtaContableCodigo
               }
               , new Object[] {
               T00178_A41ClinicaCodigo, T00178_A225CierreMCAnio, T00178_A226CierreMCMes, T00178_A193CtaContableCodigo
               }
               , new Object[] {
               T00179_A41ClinicaCodigo, T00179_A225CierreMCAnio, T00179_A226CierreMCMes, T00179_A193CtaContableCodigo
               }
               , new Object[] {
               T001710_A225CierreMCAnio, T001710_A226CierreMCMes, T001710_A227CierreMCDebe, T001710_A228CierreMCHaber, T001710_A300CierreMCInicial, T001710_A41ClinicaCodigo, T001710_A193CtaContableCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001714_A41ClinicaCodigo, T001714_A225CierreMCAnio, T001714_A226CierreMCMes, T001714_A193CtaContableCodigo
               }
               , new Object[] {
               T001715_A41ClinicaCodigo
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
      private short A225CierreMCAnio ;
      private short A226CierreMCMes ;
      private short Z225CierreMCAnio ;
      private short Z226CierreMCMes ;
      private short GX_JID ;
      private short RcdFound56 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int edtCierreMCAnio_Enabled ;
      private int edtCierreMCMes_Enabled ;
      private int edtCtaContableCodigo_Enabled ;
      private int imgprompt_41_193_Visible ;
      private int edtCierreMCDebe_Enabled ;
      private int edtCierreMCHaber_Enabled ;
      private int edtCierreMCInicial_Enabled ;
      private int edtCierreMCFinal_Enabled ;
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
      private int AnyError41 ;
      private int AnyError193 ;
      private int idxLst ;
      private decimal A227CierreMCDebe ;
      private decimal A228CierreMCHaber ;
      private decimal A300CierreMCInicial ;
      private decimal A301CierreMCFinal ;
      private decimal Z227CierreMCDebe ;
      private decimal Z228CierreMCHaber ;
      private decimal Z300CierreMCInicial ;
      private decimal Z301CierreMCFinal ;
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
      private String lblTextblockcierremcanio_Internalname ;
      private String lblTextblockcierremcanio_Jsonclick ;
      private String edtCierreMCAnio_Internalname ;
      private String edtCierreMCAnio_Jsonclick ;
      private String lblTextblockcierremcmes_Internalname ;
      private String lblTextblockcierremcmes_Jsonclick ;
      private String edtCierreMCMes_Internalname ;
      private String edtCierreMCMes_Jsonclick ;
      private String lblTextblockctacontablecodigo_Internalname ;
      private String lblTextblockctacontablecodigo_Jsonclick ;
      private String edtCtaContableCodigo_Internalname ;
      private String edtCtaContableCodigo_Jsonclick ;
      private String imgprompt_41_193_Internalname ;
      private String imgprompt_41_193_Link ;
      private String lblTextblockcierremcdebe_Internalname ;
      private String lblTextblockcierremcdebe_Jsonclick ;
      private String edtCierreMCDebe_Internalname ;
      private String edtCierreMCDebe_Jsonclick ;
      private String lblTextblockcierremchaber_Internalname ;
      private String lblTextblockcierremchaber_Jsonclick ;
      private String edtCierreMCHaber_Internalname ;
      private String edtCierreMCHaber_Jsonclick ;
      private String lblTextblockcierremcinicial_Internalname ;
      private String lblTextblockcierremcinicial_Jsonclick ;
      private String edtCierreMCInicial_Internalname ;
      private String edtCierreMCInicial_Jsonclick ;
      private String lblTextblockcierremcfinal_Internalname ;
      private String lblTextblockcierremcfinal_Jsonclick ;
      private String edtCierreMCFinal_Internalname ;
      private String edtCierreMCFinal_Jsonclick ;
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
      private String sMode56 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A41ClinicaCodigo ;
      private String A193CtaContableCodigo ;
      private String Z41ClinicaCodigo ;
      private String Z193CtaContableCodigo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00175_A225CierreMCAnio ;
      private short[] T00175_A226CierreMCMes ;
      private decimal[] T00175_A227CierreMCDebe ;
      private decimal[] T00175_A228CierreMCHaber ;
      private decimal[] T00175_A300CierreMCInicial ;
      private String[] T00175_A41ClinicaCodigo ;
      private String[] T00175_A193CtaContableCodigo ;
      private String[] T00174_A41ClinicaCodigo ;
      private String[] T00176_A41ClinicaCodigo ;
      private String[] T00177_A41ClinicaCodigo ;
      private short[] T00177_A225CierreMCAnio ;
      private short[] T00177_A226CierreMCMes ;
      private String[] T00177_A193CtaContableCodigo ;
      private short[] T00173_A225CierreMCAnio ;
      private short[] T00173_A226CierreMCMes ;
      private decimal[] T00173_A227CierreMCDebe ;
      private decimal[] T00173_A228CierreMCHaber ;
      private decimal[] T00173_A300CierreMCInicial ;
      private String[] T00173_A41ClinicaCodigo ;
      private String[] T00173_A193CtaContableCodigo ;
      private String[] T00178_A41ClinicaCodigo ;
      private short[] T00178_A225CierreMCAnio ;
      private short[] T00178_A226CierreMCMes ;
      private String[] T00178_A193CtaContableCodigo ;
      private String[] T00179_A41ClinicaCodigo ;
      private short[] T00179_A225CierreMCAnio ;
      private short[] T00179_A226CierreMCMes ;
      private String[] T00179_A193CtaContableCodigo ;
      private short[] T001710_A225CierreMCAnio ;
      private short[] T001710_A226CierreMCMes ;
      private decimal[] T001710_A227CierreMCDebe ;
      private decimal[] T001710_A228CierreMCHaber ;
      private decimal[] T001710_A300CierreMCInicial ;
      private String[] T001710_A41ClinicaCodigo ;
      private String[] T001710_A193CtaContableCodigo ;
      private String[] T001714_A41ClinicaCodigo ;
      private short[] T001714_A225CierreMCAnio ;
      private short[] T001714_A226CierreMCMes ;
      private String[] T001714_A193CtaContableCodigo ;
      private String[] T001715_A41ClinicaCodigo ;
      private short[] T00172_A225CierreMCAnio ;
      private short[] T00172_A226CierreMCMes ;
      private decimal[] T00172_A227CierreMCDebe ;
      private decimal[] T00172_A228CierreMCHaber ;
      private decimal[] T00172_A300CierreMCInicial ;
      private String[] T00172_A41ClinicaCodigo ;
      private String[] T00172_A193CtaContableCodigo ;
      private GXWebForm Form ;
   }

   public class cierremensualc__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00172 ;
          prmT00172 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CierreMCAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CierreMCMes",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00175 ;
          prmT00175 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CierreMCAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CierreMCMes",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00174 ;
          prmT00174 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00176 ;
          prmT00176 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00177 ;
          prmT00177 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CierreMCAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CierreMCMes",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00173 ;
          prmT00173 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CierreMCAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CierreMCMes",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00178 ;
          prmT00178 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CierreMCAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CierreMCMes",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00179 ;
          prmT00179 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CierreMCAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CierreMCMes",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001710 ;
          prmT001710 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CierreMCAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CierreMCMes",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001711 ;
          prmT001711 = new Object[] {
          new Object[] {"@CierreMCAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CierreMCMes",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CierreMCDebe",SqlDbType.Decimal,17,2} ,
          new Object[] {"@CierreMCHaber",SqlDbType.Decimal,17,2} ,
          new Object[] {"@CierreMCInicial",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001712 ;
          prmT001712 = new Object[] {
          new Object[] {"@CierreMCDebe",SqlDbType.Decimal,17,2} ,
          new Object[] {"@CierreMCHaber",SqlDbType.Decimal,17,2} ,
          new Object[] {"@CierreMCInicial",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CierreMCAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CierreMCMes",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001713 ;
          prmT001713 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CierreMCAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CierreMCMes",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001714 ;
          prmT001714 = new Object[] {
          } ;
          Object[] prmT001715 ;
          prmT001715 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00172", "SELECT [CierreMCAnio], [CierreMCMes], [CierreMCDebe], [CierreMCHaber], [CierreMCInicial], [ClinicaCodigo], [CtaContableCodigo] FROM [CierreMensualC] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CierreMCAnio] = @CierreMCAnio AND [CierreMCMes] = @CierreMCMes AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00172,1,0,true,false )
             ,new CursorDef("T00173", "SELECT [CierreMCAnio], [CierreMCMes], [CierreMCDebe], [CierreMCHaber], [CierreMCInicial], [ClinicaCodigo], [CtaContableCodigo] FROM [CierreMensualC] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CierreMCAnio] = @CierreMCAnio AND [CierreMCMes] = @CierreMCMes AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00173,1,0,true,false )
             ,new CursorDef("T00174", "SELECT [ClinicaCodigo] FROM [CuentaContable] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00174,1,0,true,false )
             ,new CursorDef("T00175", "SELECT TM1.[CierreMCAnio], TM1.[CierreMCMes], TM1.[CierreMCDebe], TM1.[CierreMCHaber], TM1.[CierreMCInicial], TM1.[ClinicaCodigo], TM1.[CtaContableCodigo] FROM [CierreMensualC] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[CierreMCAnio] = @CierreMCAnio and TM1.[CierreMCMes] = @CierreMCMes and TM1.[CtaContableCodigo] = @CtaContableCodigo ORDER BY TM1.[ClinicaCodigo], TM1.[CierreMCAnio], TM1.[CierreMCMes], TM1.[CtaContableCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00175,100,0,true,false )
             ,new CursorDef("T00176", "SELECT [ClinicaCodigo] FROM [CuentaContable] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00176,1,0,true,false )
             ,new CursorDef("T00177", "SELECT [ClinicaCodigo], [CierreMCAnio], [CierreMCMes], [CtaContableCodigo] FROM [CierreMensualC] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CierreMCAnio] = @CierreMCAnio AND [CierreMCMes] = @CierreMCMes AND [CtaContableCodigo] = @CtaContableCodigo  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00177,1,0,true,false )
             ,new CursorDef("T00178", "SELECT TOP 1 [ClinicaCodigo], [CierreMCAnio], [CierreMCMes], [CtaContableCodigo] FROM [CierreMensualC] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [CierreMCAnio] > @CierreMCAnio or [CierreMCAnio] = @CierreMCAnio and [ClinicaCodigo] = @ClinicaCodigo and [CierreMCMes] > @CierreMCMes or [CierreMCMes] = @CierreMCMes and [CierreMCAnio] = @CierreMCAnio and [ClinicaCodigo] = @ClinicaCodigo and [CtaContableCodigo] > @CtaContableCodigo) ORDER BY [ClinicaCodigo], [CierreMCAnio], [CierreMCMes], [CtaContableCodigo]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00178,1,0,true,true )
             ,new CursorDef("T00179", "SELECT TOP 1 [ClinicaCodigo], [CierreMCAnio], [CierreMCMes], [CtaContableCodigo] FROM [CierreMensualC] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [CierreMCAnio] < @CierreMCAnio or [CierreMCAnio] = @CierreMCAnio and [ClinicaCodigo] = @ClinicaCodigo and [CierreMCMes] < @CierreMCMes or [CierreMCMes] = @CierreMCMes and [CierreMCAnio] = @CierreMCAnio and [ClinicaCodigo] = @ClinicaCodigo and [CtaContableCodigo] < @CtaContableCodigo) ORDER BY [ClinicaCodigo] DESC, [CierreMCAnio] DESC, [CierreMCMes] DESC, [CtaContableCodigo] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00179,1,0,true,true )
             ,new CursorDef("T001710", "SELECT [CierreMCAnio], [CierreMCMes], [CierreMCDebe], [CierreMCHaber], [CierreMCInicial], [ClinicaCodigo], [CtaContableCodigo] FROM [CierreMensualC] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CierreMCAnio] = @CierreMCAnio AND [CierreMCMes] = @CierreMCMes AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001710,1,0,true,false )
             ,new CursorDef("T001711", "INSERT INTO [CierreMensualC] ([CierreMCAnio], [CierreMCMes], [CierreMCDebe], [CierreMCHaber], [CierreMCInicial], [ClinicaCodigo], [CtaContableCodigo]) VALUES (@CierreMCAnio, @CierreMCMes, @CierreMCDebe, @CierreMCHaber, @CierreMCInicial, @ClinicaCodigo, @CtaContableCodigo)", GxErrorMask.GX_NOMASK,prmT001711)
             ,new CursorDef("T001712", "UPDATE [CierreMensualC] SET [CierreMCDebe]=@CierreMCDebe, [CierreMCHaber]=@CierreMCHaber, [CierreMCInicial]=@CierreMCInicial  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CierreMCAnio] = @CierreMCAnio AND [CierreMCMes] = @CierreMCMes AND [CtaContableCodigo] = @CtaContableCodigo", GxErrorMask.GX_NOMASK,prmT001712)
             ,new CursorDef("T001713", "DELETE FROM [CierreMensualC]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CierreMCAnio] = @CierreMCAnio AND [CierreMCMes] = @CierreMCMes AND [CtaContableCodigo] = @CtaContableCodigo", GxErrorMask.GX_NOMASK,prmT001713)
             ,new CursorDef("T001714", "SELECT [ClinicaCodigo], [CierreMCAnio], [CierreMCMes], [CtaContableCodigo] FROM [CierreMensualC] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [CierreMCAnio], [CierreMCMes], [CtaContableCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001714,100,0,true,false )
             ,new CursorDef("T001715", "SELECT [ClinicaCodigo] FROM [CuentaContable] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001715,1,0,true,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                break;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                break;
             case 13 :
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 10 :
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (decimal)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
