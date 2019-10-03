/*
               File: DepositoBancario
        Description: Depósitos Bancarios de Caja
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:6:55.48
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
   public class depositobancario : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_9") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A128CuentaBancariaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_9( A41ClinicaCodigo, A128CuentaBancariaCodigo) ;
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
         Form.Meta.addItem("Description", "Depósitos Bancarios de Caja", 0) ;
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

      public depositobancario( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public depositobancario( IGxContext context )
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
            wb_table1_2_1H69( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1H69e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1H69( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1H69( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1H69e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Depósitos Bancarios de Caja"+"</legend>") ;
            wb_table3_27_1H69( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_1H69e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1H69e( true) ;
         }
         else
         {
            wb_table1_2_1H69e( false) ;
         }
      }

      protected void wb_table3_27_1H69( bool wbgen )
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
            wb_table4_33_1H69( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_1H69e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_DepositoBancario.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_DepositoBancario.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_DepositoBancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_1H69e( true) ;
         }
         else
         {
            wb_table3_27_1H69e( false) ;
         }
      }

      protected void wb_table4_33_1H69( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", lblTextblockclinicacodigo_Visible, 1, 0, "HLP_DepositoBancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", edtClinicaCodigo_Visible, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_DepositoBancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbancocodigo_Internalname, "Código", "", "", lblTextblockbancocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_DepositoBancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BancoCodigo", A126BancoCodigo);
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBancoCodigo_Internalname, StringUtil.RTrim( A126BancoCodigo), StringUtil.RTrim( context.localUtil.Format( A126BancoCodigo, "")), "", "", "", "", "", edtBancoCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtBancoCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_DepositoBancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcuentabancariacodigo_Internalname, "Código", "", "", lblTextblockcuentabancariacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_DepositoBancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCuentaBancariaCodigo_Internalname, StringUtil.RTrim( A128CuentaBancariaCodigo), StringUtil.RTrim( context.localUtil.Format( A128CuentaBancariaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", "", "", "", edtCuentaBancariaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtCuentaBancariaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_DepositoBancario.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_128_Internalname, "prompt.gif", imgprompt_41_128_Link, "", "", "Fantastic", imgprompt_41_128_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_DepositoBancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockdepositoid_Internalname, "Depósito", "", "", lblTextblockdepositoid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_DepositoBancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A282DepositoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A282DepositoId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtDepositoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A282DepositoId), 9, 0, ".", "")), ((edtDepositoId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A282DepositoId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A282DepositoId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(53);\"", "", "", "", "", edtDepositoId_Jsonclick, 0, ClassString, StyleString, "", 1, edtDepositoId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_DepositoBancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockdepositofecha_Internalname, "Fecha", "", "", lblTextblockdepositofecha_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_DepositoBancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A283DepositoFecha", context.localUtil.Format(A283DepositoFecha, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtDepositoFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtDepositoFecha_Internalname, context.localUtil.Format(A283DepositoFecha, "99/99/99"), context.localUtil.Format( A283DepositoFecha, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(58);\"", "", "", "", "", edtDepositoFecha_Jsonclick, 0, ClassString, StyleString, "", 1, edtDepositoFecha_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_DepositoBancario.htm");
            GxWebStd.gx_bitmap( context, edtDepositoFecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtDepositoFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_DepositoBancario.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockdepositoefectivo_Internalname, "Efectivo", "", "", lblTextblockdepositoefectivo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_DepositoBancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A284DepositoEfectivo", StringUtil.LTrim( StringUtil.Str( A284DepositoEfectivo, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtDepositoEfectivo_Internalname, StringUtil.LTrim( StringUtil.NToC( A284DepositoEfectivo, 17, 2, ".", "")), ((edtDepositoEfectivo_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A284DepositoEfectivo, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A284DepositoEfectivo, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(63);\"", "", "", "", "", edtDepositoEfectivo_Jsonclick, 0, ClassString, StyleString, "", 1, edtDepositoEfectivo_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_DepositoBancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockdepositocheque_Internalname, "Cheques", "", "", lblTextblockdepositocheque_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_DepositoBancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A285DepositoCheque", StringUtil.LTrim( StringUtil.Str( A285DepositoCheque, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtDepositoCheque_Internalname, StringUtil.LTrim( StringUtil.NToC( A285DepositoCheque, 17, 2, ".", "")), ((edtDepositoCheque_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A285DepositoCheque, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A285DepositoCheque, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(68);\"", "", "", "", "", edtDepositoCheque_Jsonclick, 0, ClassString, StyleString, "", 1, edtDepositoCheque_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_DepositoBancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockdepositototal_Internalname, "Total", "", "", lblTextblockdepositototal_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_DepositoBancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286DepositoTotal", StringUtil.LTrim( StringUtil.Str( A286DepositoTotal, 17, 2)));
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtDepositoTotal_Internalname, StringUtil.LTrim( StringUtil.NToC( A286DepositoTotal, 17, 2, ".", "")), ((edtDepositoTotal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A286DepositoTotal, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A286DepositoTotal, "ZZZZZZZZZZZZZ9.99")), "", "", "", "", "", edtDepositoTotal_Jsonclick, 0, ClassString, StyleString, "", 1, edtDepositoTotal_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_DepositoBancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusuariocodigo_Internalname, "Usuario", "", "", lblTextblockusuariocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_DepositoBancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUsuarioCodigo_Internalname, StringUtil.RTrim( A4UsuarioCodigo), StringUtil.RTrim( context.localUtil.Format( A4UsuarioCodigo, "")), "", "", "", "", "", edtUsuarioCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtUsuarioCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_DepositoBancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_1H69e( true) ;
         }
         else
         {
            wb_table4_33_1H69e( false) ;
         }
      }

      protected void wb_table2_5_1H69( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_DepositoBancario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_DepositoBancario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_DepositoBancario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_DepositoBancario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_DepositoBancario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_DepositoBancario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_DepositoBancario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_DepositoBancario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01x0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CUENTABANCARIACODIGO"+"'), id:'"+"CUENTABANCARIACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"DEPOSITOID"+"'), id:'"+"DEPOSITOID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_DepositoBancario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01x0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CUENTABANCARIACODIGO"+"'), id:'"+"CUENTABANCARIACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"DEPOSITOID"+"'), id:'"+"DEPOSITOID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_DepositoBancario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_DepositoBancario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_DepositoBancario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_DepositoBancario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_DepositoBancario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_DepositoBancario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_DepositoBancario.htm");
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
            wb_table2_5_1H69e( true) ;
         }
         else
         {
            wb_table2_5_1H69e( false) ;
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
         /* Execute user event: E111H2 */
         E111H2 ();
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
               A126BancoCodigo = cgiGet( edtBancoCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BancoCodigo", A126BancoCodigo);
               A128CuentaBancariaCodigo = cgiGet( edtCuentaBancariaCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
               if ( ( ( context.localUtil.CToN( cgiGet( edtDepositoId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtDepositoId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "DEPOSITOID");
                  AnyError = 1 ;
                  GX_FocusControl = edtDepositoId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A282DepositoId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A282DepositoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A282DepositoId), 9, 0)));
               }
               else
               {
                  A282DepositoId = (int)(context.localUtil.CToN( cgiGet( edtDepositoId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A282DepositoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A282DepositoId), 9, 0)));
               }
               if ( context.localUtil.VCDate( cgiGet( edtDepositoFecha_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, "DEPOSITOFECHA");
                  AnyError = 1 ;
                  GX_FocusControl = edtDepositoFecha_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A283DepositoFecha = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A283DepositoFecha", context.localUtil.Format(A283DepositoFecha, "99/99/99"));
               }
               else
               {
                  A283DepositoFecha = context.localUtil.CToD( cgiGet( edtDepositoFecha_Internalname), 2) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A283DepositoFecha", context.localUtil.Format(A283DepositoFecha, "99/99/99"));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtDepositoEfectivo_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtDepositoEfectivo_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "DEPOSITOEFECTIVO");
                  AnyError = 1 ;
                  GX_FocusControl = edtDepositoEfectivo_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A284DepositoEfectivo = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A284DepositoEfectivo", StringUtil.LTrim( StringUtil.Str( A284DepositoEfectivo, 17, 2)));
               }
               else
               {
                  A284DepositoEfectivo = context.localUtil.CToN( cgiGet( edtDepositoEfectivo_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A284DepositoEfectivo", StringUtil.LTrim( StringUtil.Str( A284DepositoEfectivo, 17, 2)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtDepositoCheque_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtDepositoCheque_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "DEPOSITOCHEQUE");
                  AnyError = 1 ;
                  GX_FocusControl = edtDepositoCheque_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A285DepositoCheque = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A285DepositoCheque", StringUtil.LTrim( StringUtil.Str( A285DepositoCheque, 17, 2)));
               }
               else
               {
                  A285DepositoCheque = context.localUtil.CToN( cgiGet( edtDepositoCheque_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A285DepositoCheque", StringUtil.LTrim( StringUtil.Str( A285DepositoCheque, 17, 2)));
               }
               A286DepositoTotal = context.localUtil.CToN( cgiGet( edtDepositoTotal_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286DepositoTotal", StringUtil.LTrim( StringUtil.Str( A286DepositoTotal, 17, 2)));
               A4UsuarioCodigo = cgiGet( edtUsuarioCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z128CuentaBancariaCodigo = cgiGet( "Z128CuentaBancariaCodigo") ;
               Z282DepositoId = (int)(context.localUtil.CToN( cgiGet( "Z282DepositoId"), ".", ",")) ;
               Z283DepositoFecha = context.localUtil.CToD( cgiGet( "Z283DepositoFecha"), 0) ;
               Z284DepositoEfectivo = context.localUtil.CToN( cgiGet( "Z284DepositoEfectivo"), ".", ",") ;
               Z285DepositoCheque = context.localUtil.CToN( cgiGet( "Z285DepositoCheque"), ".", ",") ;
               Z4UsuarioCodigo = cgiGet( "Z4UsuarioCodigo") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV9ClinicaCodigo = cgiGet( "vCLINICACODIGO") ;
               AV11UsuarioCodigo = cgiGet( "vUSUARIOCODIGO") ;
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
                  A128CuentaBancariaCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
                  A282DepositoId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A282DepositoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A282DepositoId), 9, 0)));
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
                           /* Execute user event: E111H2 */
                           E111H2 ();
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
               InitAll1H69( ) ;
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
         DisableAttributes1H69( ) ;
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

      protected void ResetCaption1H0( )
      {
      }

      protected void E111H2( )
      {
         /* Start Routine */
         GXt_SdtParametros4 = AV10Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros4) ;
         AV10Parametros = GXt_SdtParametros4 ;
         AV9ClinicaCodigo = AV10Parametros.gxTpr_Pclinicacodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ClinicaCodigo", AV9ClinicaCodigo);
         AV11UsuarioCodigo = AV10Parametros.gxTpr_Pusuariocodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11UsuarioCodigo", AV11UsuarioCodigo);
      }

      protected void ZM1H69( short GX_JID )
      {
         if ( ( GX_JID == 8 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z283DepositoFecha = T001H3_A283DepositoFecha[0] ;
               Z284DepositoEfectivo = T001H3_A284DepositoEfectivo[0] ;
               Z285DepositoCheque = T001H3_A285DepositoCheque[0] ;
               Z4UsuarioCodigo = T001H3_A4UsuarioCodigo[0] ;
            }
            else
            {
               Z283DepositoFecha = A283DepositoFecha ;
               Z284DepositoEfectivo = A284DepositoEfectivo ;
               Z285DepositoCheque = A285DepositoCheque ;
               Z4UsuarioCodigo = A4UsuarioCodigo ;
            }
         }
         if ( GX_JID == -8 )
         {
            Z282DepositoId = A282DepositoId ;
            Z283DepositoFecha = A283DepositoFecha ;
            Z284DepositoEfectivo = A284DepositoEfectivo ;
            Z285DepositoCheque = A285DepositoCheque ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z128CuentaBancariaCodigo = A128CuentaBancariaCodigo ;
            Z4UsuarioCodigo = A4UsuarioCodigo ;
            Z126BancoCodigo = A126BancoCodigo ;
         }
      }

      protected void standaloneNotModal( )
      {
         lblTextblockclinicacodigo_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTextblockclinicacodigo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblTextblockclinicacodigo_Visible), 5, 0)));
         edtClinicaCodigo_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Visible), 5, 0)));
         edtUsuarioCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioCodigo_Enabled), 5, 0)));
         imgprompt_41_128_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00z0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CUENTABANCARIACODIGO"+"'), id:'"+"CUENTABANCARIACODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"true"+");") ;
         edtUsuarioCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioCodigo_Enabled), 5, 0)));
         A41ClinicaCodigo = AV9ClinicaCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
      }

      protected void standaloneModal( )
      {
         A4UsuarioCodigo = AV11UsuarioCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
         /* Using cursor T001H5 */
         pr_default.execute(3, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(3) == 101) )
         {
            AnyError4 = 1 ;
            GX_msglist.addItem("No existe 'Usuarios'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1 ;
         }
         if ( AnyError4 == 0 )
         {
         }
         pr_default.close(3);
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

      protected void Load1H69( )
      {
         /* Using cursor T001H6 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo, A128CuentaBancariaCodigo, A282DepositoId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound69 = 1 ;
            A283DepositoFecha = T001H6_A283DepositoFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A283DepositoFecha", context.localUtil.Format(A283DepositoFecha, "99/99/99"));
            A284DepositoEfectivo = T001H6_A284DepositoEfectivo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A284DepositoEfectivo", StringUtil.LTrim( StringUtil.Str( A284DepositoEfectivo, 17, 2)));
            A285DepositoCheque = T001H6_A285DepositoCheque[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A285DepositoCheque", StringUtil.LTrim( StringUtil.Str( A285DepositoCheque, 17, 2)));
            A126BancoCodigo = T001H6_A126BancoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BancoCodigo", A126BancoCodigo);
            A4UsuarioCodigo = T001H6_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            ZM1H69( -8) ;
         }
         pr_default.close(4);
         OnLoadActions1H69( ) ;
      }

      protected void OnLoadActions1H69( )
      {
         A286DepositoTotal = (decimal)(A284DepositoEfectivo+A285DepositoCheque) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286DepositoTotal", StringUtil.LTrim( StringUtil.Str( A286DepositoTotal, 17, 2)));
      }

      protected void CheckExtendedTable1H69( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T001H4 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo, A128CuentaBancariaCodigo});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError41 = 1 ;
            AnyError128 = 1 ;
            GX_msglist.addItem("No existe 'Cuentas Bancarias'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError128 == 0 ) )
         {
            A126BancoCodigo = T001H4_A126BancoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BancoCodigo", A126BancoCodigo);
         }
         pr_default.close(2);
         if ( ! ( (DateTime.MinValue==A283DepositoFecha) || ( A283DepositoFecha >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         A286DepositoTotal = (decimal)(A284DepositoEfectivo+A285DepositoCheque) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286DepositoTotal", StringUtil.LTrim( StringUtil.Str( A286DepositoTotal, 17, 2)));
      }

      protected void CloseExtendedTableCursors1H69( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_9( String A41ClinicaCodigo ,
                               String A128CuentaBancariaCodigo )
      {
         /* Using cursor T001H7 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A128CuentaBancariaCodigo});
         if ( (pr_default.getStatus(5) == 101) )
         {
            AnyError41 = 1 ;
            AnyError128 = 1 ;
            GX_msglist.addItem("No existe 'Cuentas Bancarias'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError128 == 0 ) )
         {
            A126BancoCodigo = T001H7_A126BancoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BancoCodigo", A126BancoCodigo);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A126BancoCodigo))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(5);
      }

      protected void GetKey1H69( )
      {
         /* Using cursor T001H8 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, A128CuentaBancariaCodigo, A282DepositoId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound69 = 1 ;
         }
         else
         {
            RcdFound69 = 0 ;
         }
         pr_default.close(6);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001H3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A128CuentaBancariaCodigo, A282DepositoId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1H69( 8) ;
            RcdFound69 = 1 ;
            A282DepositoId = T001H3_A282DepositoId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A282DepositoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A282DepositoId), 9, 0)));
            A283DepositoFecha = T001H3_A283DepositoFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A283DepositoFecha", context.localUtil.Format(A283DepositoFecha, "99/99/99"));
            A284DepositoEfectivo = T001H3_A284DepositoEfectivo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A284DepositoEfectivo", StringUtil.LTrim( StringUtil.Str( A284DepositoEfectivo, 17, 2)));
            A285DepositoCheque = T001H3_A285DepositoCheque[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A285DepositoCheque", StringUtil.LTrim( StringUtil.Str( A285DepositoCheque, 17, 2)));
            A41ClinicaCodigo = T001H3_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A128CuentaBancariaCodigo = T001H3_A128CuentaBancariaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
            A4UsuarioCodigo = T001H3_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z128CuentaBancariaCodigo = A128CuentaBancariaCodigo ;
            Z282DepositoId = A282DepositoId ;
            sMode69 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1H69( ) ;
            Gx_mode = sMode69 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound69 = 0 ;
            InitializeNonKey1H69( ) ;
            sMode69 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode69 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1H69( ) ;
         if ( RcdFound69 == 0 )
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
         RcdFound69 = 0 ;
         /* Using cursor T001H9 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A128CuentaBancariaCodigo, A282DepositoId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T001H9_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001H9_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001H9_A128CuentaBancariaCodigo[0], A128CuentaBancariaCodigo) < 0 ) || ( StringUtil.StrCmp(T001H9_A128CuentaBancariaCodigo[0], A128CuentaBancariaCodigo) == 0 ) && ( StringUtil.StrCmp(T001H9_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001H9_A282DepositoId[0] < A282DepositoId ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T001H9_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001H9_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001H9_A128CuentaBancariaCodigo[0], A128CuentaBancariaCodigo) > 0 ) || ( StringUtil.StrCmp(T001H9_A128CuentaBancariaCodigo[0], A128CuentaBancariaCodigo) == 0 ) && ( StringUtil.StrCmp(T001H9_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001H9_A282DepositoId[0] > A282DepositoId ) ) )
            {
               A41ClinicaCodigo = T001H9_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A128CuentaBancariaCodigo = T001H9_A128CuentaBancariaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
               A282DepositoId = T001H9_A282DepositoId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A282DepositoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A282DepositoId), 9, 0)));
               RcdFound69 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound69 = 0 ;
         /* Using cursor T001H10 */
         pr_default.execute(8, new Object[] {A41ClinicaCodigo, A128CuentaBancariaCodigo, A282DepositoId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T001H10_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001H10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001H10_A128CuentaBancariaCodigo[0], A128CuentaBancariaCodigo) > 0 ) || ( StringUtil.StrCmp(T001H10_A128CuentaBancariaCodigo[0], A128CuentaBancariaCodigo) == 0 ) && ( StringUtil.StrCmp(T001H10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001H10_A282DepositoId[0] > A282DepositoId ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T001H10_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001H10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001H10_A128CuentaBancariaCodigo[0], A128CuentaBancariaCodigo) < 0 ) || ( StringUtil.StrCmp(T001H10_A128CuentaBancariaCodigo[0], A128CuentaBancariaCodigo) == 0 ) && ( StringUtil.StrCmp(T001H10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001H10_A282DepositoId[0] < A282DepositoId ) ) )
            {
               A41ClinicaCodigo = T001H10_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A128CuentaBancariaCodigo = T001H10_A128CuentaBancariaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
               A282DepositoId = T001H10_A282DepositoId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A282DepositoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A282DepositoId), 9, 0)));
               RcdFound69 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1H69( ) ;
         if ( RcdFound69 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A128CuentaBancariaCodigo, Z128CuentaBancariaCodigo) != 0 ) || ( A282DepositoId != Z282DepositoId ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A128CuentaBancariaCodigo = Z128CuentaBancariaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
               A282DepositoId = Z282DepositoId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A282DepositoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A282DepositoId), 9, 0)));
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
               Update1H69( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A128CuentaBancariaCodigo, Z128CuentaBancariaCodigo) != 0 ) || ( A282DepositoId != Z282DepositoId ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert1H69( ) ;
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
                  Insert1H69( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A128CuentaBancariaCodigo, Z128CuentaBancariaCodigo) != 0 ) || ( A282DepositoId != Z282DepositoId ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A128CuentaBancariaCodigo = Z128CuentaBancariaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
            A282DepositoId = Z282DepositoId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A282DepositoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A282DepositoId), 9, 0)));
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
         if ( RcdFound69 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtDepositoFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1H69( ) ;
         if ( RcdFound69 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtDepositoFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1H69( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound69 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtDepositoFecha_Internalname ;
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
         if ( RcdFound69 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtDepositoFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1H69( ) ;
         if ( RcdFound69 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound69 != 0 )
            {
               ScanNext1H69( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtDepositoFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1H69( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1H69( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001H11 */
            pr_default.execute(9, new Object[] {A41ClinicaCodigo, A128CuentaBancariaCodigo, A282DepositoId});
            if ( (pr_default.getStatus(9) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"DepositoBancario"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(9) == 101) || ( Z283DepositoFecha != T001H11_A283DepositoFecha[0] ) || ( Z284DepositoEfectivo != T001H11_A284DepositoEfectivo[0] ) || ( Z285DepositoCheque != T001H11_A285DepositoCheque[0] ) || ( StringUtil.StrCmp(Z4UsuarioCodigo, T001H11_A4UsuarioCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"DepositoBancario"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1H69( )
      {
         BeforeValidate1H69( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1H69( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1H69( 0) ;
            CheckOptimisticConcurrency1H69( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1H69( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1H69( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001H12 */
                     pr_default.execute(10, new Object[] {A282DepositoId, A283DepositoFecha, A284DepositoEfectivo, A285DepositoCheque, A41ClinicaCodigo, A128CuentaBancariaCodigo, A4UsuarioCodigo});
                     pr_default.close(10);
                     if ( (pr_default.getStatus(10) == 1) )
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
                           ResetCaption1H0( ) ;
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
               Load1H69( ) ;
            }
            EndLevel1H69( ) ;
         }
         CloseExtendedTableCursors1H69( ) ;
      }

      protected void Update1H69( )
      {
         BeforeValidate1H69( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1H69( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1H69( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1H69( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1H69( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001H13 */
                     pr_default.execute(11, new Object[] {A283DepositoFecha, A284DepositoEfectivo, A285DepositoCheque, A4UsuarioCodigo, A41ClinicaCodigo, A128CuentaBancariaCodigo, A282DepositoId});
                     pr_default.close(11);
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"DepositoBancario"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1H69( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                           ResetCaption1H0( ) ;
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
            EndLevel1H69( ) ;
         }
         CloseExtendedTableCursors1H69( ) ;
      }

      protected void DeferredUpdate1H69( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1H69( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1H69( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1H69( ) ;
            AfterConfirm1H69( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1H69( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001H14 */
                  pr_default.execute(12, new Object[] {A41ClinicaCodigo, A128CuentaBancariaCodigo, A282DepositoId});
                  pr_default.close(12);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound69 == 0 )
                        {
                           InitAll1H69( ) ;
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
                        ResetCaption1H0( ) ;
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
         sMode69 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1H69( ) ;
         Gx_mode = sMode69 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1H69( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T001H15 */
            pr_default.execute(13, new Object[] {A41ClinicaCodigo, A128CuentaBancariaCodigo});
            A126BancoCodigo = T001H15_A126BancoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BancoCodigo", A126BancoCodigo);
            pr_default.close(13);
            A286DepositoTotal = (decimal)(A284DepositoEfectivo+A285DepositoCheque) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286DepositoTotal", StringUtil.LTrim( StringUtil.Str( A286DepositoTotal, 17, 2)));
         }
      }

      protected void EndLevel1H69( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(9);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1H69( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(8);
            pr_default.close(7);
            pr_default.close(13);
            context.CommitDataStores("DepositoBancario");
            if ( AnyError == 0 )
            {
               ConfirmValues1H0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(8);
            pr_default.close(7);
            pr_default.close(13);
            context.RollbackDataStores("DepositoBancario");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1H69( )
      {
         /* Using cursor T001H16 */
         pr_default.execute(14);
         RcdFound69 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound69 = 1 ;
            A41ClinicaCodigo = T001H16_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A128CuentaBancariaCodigo = T001H16_A128CuentaBancariaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
            A282DepositoId = T001H16_A282DepositoId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A282DepositoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A282DepositoId), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1H69( )
      {
         pr_default.readNext(14);
         RcdFound69 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound69 = 1 ;
            A41ClinicaCodigo = T001H16_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A128CuentaBancariaCodigo = T001H16_A128CuentaBancariaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
            A282DepositoId = T001H16_A282DepositoId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A282DepositoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A282DepositoId), 9, 0)));
         }
      }

      protected void ScanEnd1H69( )
      {
      }

      protected void AfterConfirm1H69( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1H69( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1H69( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1H69( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1H69( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1H69( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1H69( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtBancoCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBancoCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBancoCodigo_Enabled), 5, 0)));
         edtCuentaBancariaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCuentaBancariaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCuentaBancariaCodigo_Enabled), 5, 0)));
         edtDepositoId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDepositoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDepositoId_Enabled), 5, 0)));
         edtDepositoFecha_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDepositoFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDepositoFecha_Enabled), 5, 0)));
         edtDepositoEfectivo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDepositoEfectivo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDepositoEfectivo_Enabled), 5, 0)));
         edtDepositoCheque_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDepositoCheque_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDepositoCheque_Enabled), 5, 0)));
         edtDepositoTotal_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDepositoTotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDepositoTotal_Enabled), 5, 0)));
         edtUsuarioCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioCodigo_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1H0( )
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
         context.AddJavascriptSource("calendar.js", "?58720");
         context.AddJavascriptSource("calendar-setup.js", "?58720");
         context.AddJavascriptSource("calendar-es.js", "?58720");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("depositobancario.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z128CuentaBancariaCodigo", StringUtil.RTrim( Z128CuentaBancariaCodigo));
         GxWebStd.gx_hidden_field( context, "Z282DepositoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z282DepositoId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z283DepositoFecha", context.localUtil.DToC( Z283DepositoFecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z284DepositoEfectivo", StringUtil.LTrim( StringUtil.NToC( Z284DepositoEfectivo, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z285DepositoCheque", StringUtil.LTrim( StringUtil.NToC( Z285DepositoCheque, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z4UsuarioCodigo", StringUtil.RTrim( Z4UsuarioCodigo));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vCLINICACODIGO", StringUtil.RTrim( AV9ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "vUSUARIOCODIGO", StringUtil.RTrim( AV11UsuarioCodigo));
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
         return "DepositoBancario" ;
      }

      public override String GetPgmdesc( )
      {
         return "Depósitos Bancarios de Caja" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("depositobancario.aspx")  ;
      }

      protected void InitializeNonKey1H69( )
      {
         A4UsuarioCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
         A286DepositoTotal = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286DepositoTotal", StringUtil.LTrim( StringUtil.Str( A286DepositoTotal, 17, 2)));
         A126BancoCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BancoCodigo", A126BancoCodigo);
         A283DepositoFecha = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A283DepositoFecha", context.localUtil.Format(A283DepositoFecha, "99/99/99"));
         A284DepositoEfectivo = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A284DepositoEfectivo", StringUtil.LTrim( StringUtil.Str( A284DepositoEfectivo, 17, 2)));
         A285DepositoCheque = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A285DepositoCheque", StringUtil.LTrim( StringUtil.Str( A285DepositoCheque, 17, 2)));
      }

      protected void InitAll1H69( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A128CuentaBancariaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
         A282DepositoId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A282DepositoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A282DepositoId), 9, 0)));
         InitializeNonKey1H69( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?75080");
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1565748");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("depositobancario.js", "?1565748");
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
         lblTextblockbancocodigo_Internalname = "TEXTBLOCKBANCOCODIGO" ;
         edtBancoCodigo_Internalname = "BANCOCODIGO" ;
         lblTextblockcuentabancariacodigo_Internalname = "TEXTBLOCKCUENTABANCARIACODIGO" ;
         edtCuentaBancariaCodigo_Internalname = "CUENTABANCARIACODIGO" ;
         lblTextblockdepositoid_Internalname = "TEXTBLOCKDEPOSITOID" ;
         edtDepositoId_Internalname = "DEPOSITOID" ;
         lblTextblockdepositofecha_Internalname = "TEXTBLOCKDEPOSITOFECHA" ;
         edtDepositoFecha_Internalname = "DEPOSITOFECHA" ;
         lblTextblockdepositoefectivo_Internalname = "TEXTBLOCKDEPOSITOEFECTIVO" ;
         edtDepositoEfectivo_Internalname = "DEPOSITOEFECTIVO" ;
         lblTextblockdepositocheque_Internalname = "TEXTBLOCKDEPOSITOCHEQUE" ;
         edtDepositoCheque_Internalname = "DEPOSITOCHEQUE" ;
         lblTextblockdepositototal_Internalname = "TEXTBLOCKDEPOSITOTOTAL" ;
         edtDepositoTotal_Internalname = "DEPOSITOTOTAL" ;
         lblTextblockusuariocodigo_Internalname = "TEXTBLOCKUSUARIOCODIGO" ;
         edtUsuarioCodigo_Internalname = "USUARIOCODIGO" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_128_Internalname = "PROMPT_41_128" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Depósitos Bancarios de Caja" ;
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
         edtUsuarioCodigo_Jsonclick = "" ;
         edtUsuarioCodigo_Enabled = 0 ;
         edtDepositoTotal_Jsonclick = "" ;
         edtDepositoTotal_Enabled = 0 ;
         edtDepositoCheque_Jsonclick = "" ;
         edtDepositoCheque_Enabled = 1 ;
         edtDepositoEfectivo_Jsonclick = "" ;
         edtDepositoEfectivo_Enabled = 1 ;
         edtDepositoFecha_Jsonclick = "" ;
         edtDepositoFecha_Enabled = 1 ;
         edtDepositoId_Jsonclick = "" ;
         edtDepositoId_Enabled = 1 ;
         imgprompt_41_128_Visible = 1 ;
         imgprompt_41_128_Link = "" ;
         edtCuentaBancariaCodigo_Jsonclick = "" ;
         edtCuentaBancariaCodigo_Enabled = 1 ;
         edtBancoCodigo_Jsonclick = "" ;
         edtBancoCodigo_Enabled = 0 ;
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
         /* End function dynload_actions */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         /* Using cursor T001H15 */
         pr_default.execute(13, new Object[] {A41ClinicaCodigo, A128CuentaBancariaCodigo});
         if ( (pr_default.getStatus(13) == 101) )
         {
            AnyError41 = 1 ;
            AnyError128 = 1 ;
            GX_msglist.addItem("No existe 'Cuentas Bancarias'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError128 == 0 ) )
         {
            A126BancoCodigo = T001H15_A126BancoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BancoCodigo", A126BancoCodigo);
         }
         pr_default.close(13);
         GX_FocusControl = edtDepositoFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Cuentabancariacodigo( String GX_Parm1 ,
                                              String GX_Parm2 ,
                                              String GX_Parm3 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A128CuentaBancariaCodigo = GX_Parm2 ;
         A126BancoCodigo = GX_Parm3 ;
         /* Using cursor T001H15 */
         pr_default.execute(13, new Object[] {A41ClinicaCodigo, A128CuentaBancariaCodigo});
         if ( (pr_default.getStatus(13) == 101) )
         {
            AnyError41 = 1 ;
            AnyError128 = 1 ;
            GX_msglist.addItem("No existe 'Cuentas Bancarias'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError128 == 0 ) )
         {
            A126BancoCodigo = T001H15_A126BancoCodigo[0] ;
         }
         pr_default.close(13);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A126BancoCodigo = "" ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A126BancoCodigo)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Depositoid( String GX_Parm1 ,
                                    String GX_Parm2 ,
                                    String GX_Parm3 ,
                                    String GX_Parm4 ,
                                    int GX_Parm5 ,
                                    DateTime GX_Parm6 ,
                                    decimal GX_Parm7 ,
                                    decimal GX_Parm8 ,
                                    String GX_Parm9 )
      {
         AV9ClinicaCodigo = GX_Parm1 ;
         AV11UsuarioCodigo = GX_Parm2 ;
         A41ClinicaCodigo = GX_Parm3 ;
         A128CuentaBancariaCodigo = GX_Parm4 ;
         A282DepositoId = GX_Parm5 ;
         A283DepositoFecha = GX_Parm6 ;
         A284DepositoEfectivo = GX_Parm7 ;
         A285DepositoCheque = GX_Parm8 ;
         A4UsuarioCodigo = GX_Parm9 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A126BancoCodigo = "" ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A4UsuarioCodigo)));
         isValidOutput.Add((Object)(context.localUtil.Format(A283DepositoFecha, "99/99/99")));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A284DepositoEfectivo, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A285DepositoCheque, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A126BancoCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A286DepositoTotal, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z128CuentaBancariaCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z282DepositoId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z4UsuarioCodigo)));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z283DepositoFecha, 0, "/")));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z284DepositoEfectivo, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z285DepositoCheque, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z126BancoCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z286DepositoTotal, 17, 2, ".", ""))));
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
         pr_default.close(14);
         pr_default.close(8);
         pr_default.close(7);
         pr_default.close(13);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
         A128CuentaBancariaCodigo = "" ;
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
         lblTextblockbancocodigo_Jsonclick = "" ;
         A126BancoCodigo = "" ;
         lblTextblockcuentabancariacodigo_Jsonclick = "" ;
         lblTextblockdepositoid_Jsonclick = "" ;
         lblTextblockdepositofecha_Jsonclick = "" ;
         A283DepositoFecha = DateTime.MinValue ;
         lblTextblockdepositoefectivo_Jsonclick = "" ;
         lblTextblockdepositocheque_Jsonclick = "" ;
         lblTextblockdepositototal_Jsonclick = "" ;
         lblTextblockusuariocodigo_Jsonclick = "" ;
         A4UsuarioCodigo = "" ;
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
         Z128CuentaBancariaCodigo = "" ;
         Z283DepositoFecha = DateTime.MinValue ;
         Z4UsuarioCodigo = "" ;
         Gx_mode = "" ;
         AV9ClinicaCodigo = "" ;
         AV11UsuarioCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV10Parametros = new SdtParametros(context);
         GXt_SdtParametros4 = new SdtParametros(context);
         Z126BancoCodigo = "" ;
         T001H5_A4UsuarioCodigo = new String[] {""} ;
         T001H6_A282DepositoId = new int[1] ;
         T001H6_A283DepositoFecha = new DateTime[] {DateTime.MinValue} ;
         T001H6_A284DepositoEfectivo = new decimal[1] ;
         T001H6_A285DepositoCheque = new decimal[1] ;
         T001H6_A41ClinicaCodigo = new String[] {""} ;
         T001H6_A128CuentaBancariaCodigo = new String[] {""} ;
         T001H6_A126BancoCodigo = new String[] {""} ;
         T001H6_A4UsuarioCodigo = new String[] {""} ;
         T001H4_A126BancoCodigo = new String[] {""} ;
         T001H7_A126BancoCodigo = new String[] {""} ;
         T001H8_A41ClinicaCodigo = new String[] {""} ;
         T001H8_A128CuentaBancariaCodigo = new String[] {""} ;
         T001H8_A282DepositoId = new int[1] ;
         T001H3_A282DepositoId = new int[1] ;
         T001H3_A283DepositoFecha = new DateTime[] {DateTime.MinValue} ;
         T001H3_A284DepositoEfectivo = new decimal[1] ;
         T001H3_A285DepositoCheque = new decimal[1] ;
         T001H3_A41ClinicaCodigo = new String[] {""} ;
         T001H3_A128CuentaBancariaCodigo = new String[] {""} ;
         T001H3_A4UsuarioCodigo = new String[] {""} ;
         sMode69 = "" ;
         T001H9_A41ClinicaCodigo = new String[] {""} ;
         T001H9_A128CuentaBancariaCodigo = new String[] {""} ;
         T001H9_A282DepositoId = new int[1] ;
         T001H10_A41ClinicaCodigo = new String[] {""} ;
         T001H10_A128CuentaBancariaCodigo = new String[] {""} ;
         T001H10_A282DepositoId = new int[1] ;
         T001H11_A282DepositoId = new int[1] ;
         T001H11_A283DepositoFecha = new DateTime[] {DateTime.MinValue} ;
         T001H11_A284DepositoEfectivo = new decimal[1] ;
         T001H11_A285DepositoCheque = new decimal[1] ;
         T001H11_A41ClinicaCodigo = new String[] {""} ;
         T001H11_A128CuentaBancariaCodigo = new String[] {""} ;
         T001H11_A4UsuarioCodigo = new String[] {""} ;
         T001H15_A126BancoCodigo = new String[] {""} ;
         T001H16_A41ClinicaCodigo = new String[] {""} ;
         T001H16_A128CuentaBancariaCodigo = new String[] {""} ;
         T001H16_A282DepositoId = new int[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.depositobancario__default(),
            new Object[][] {
                new Object[] {
               T001H2_A282DepositoId, T001H2_A283DepositoFecha, T001H2_A284DepositoEfectivo, T001H2_A285DepositoCheque, T001H2_A41ClinicaCodigo, T001H2_A128CuentaBancariaCodigo, T001H2_A4UsuarioCodigo
               }
               , new Object[] {
               T001H3_A282DepositoId, T001H3_A283DepositoFecha, T001H3_A284DepositoEfectivo, T001H3_A285DepositoCheque, T001H3_A41ClinicaCodigo, T001H3_A128CuentaBancariaCodigo, T001H3_A4UsuarioCodigo
               }
               , new Object[] {
               T001H4_A126BancoCodigo
               }
               , new Object[] {
               T001H5_A4UsuarioCodigo
               }
               , new Object[] {
               T001H6_A282DepositoId, T001H6_A283DepositoFecha, T001H6_A284DepositoEfectivo, T001H6_A285DepositoCheque, T001H6_A41ClinicaCodigo, T001H6_A128CuentaBancariaCodigo, T001H6_A126BancoCodigo, T001H6_A4UsuarioCodigo
               }
               , new Object[] {
               T001H7_A126BancoCodigo
               }
               , new Object[] {
               T001H8_A41ClinicaCodigo, T001H8_A128CuentaBancariaCodigo, T001H8_A282DepositoId
               }
               , new Object[] {
               T001H9_A41ClinicaCodigo, T001H9_A128CuentaBancariaCodigo, T001H9_A282DepositoId
               }
               , new Object[] {
               T001H10_A41ClinicaCodigo, T001H10_A128CuentaBancariaCodigo, T001H10_A282DepositoId
               }
               , new Object[] {
               T001H11_A282DepositoId, T001H11_A283DepositoFecha, T001H11_A284DepositoEfectivo, T001H11_A285DepositoCheque, T001H11_A41ClinicaCodigo, T001H11_A128CuentaBancariaCodigo, T001H11_A4UsuarioCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001H15_A126BancoCodigo
               }
               , new Object[] {
               T001H16_A41ClinicaCodigo, T001H16_A128CuentaBancariaCodigo, T001H16_A282DepositoId
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
      private short RcdFound69 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int lblTextblockclinicacodigo_Visible ;
      private int edtClinicaCodigo_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int edtBancoCodigo_Enabled ;
      private int edtCuentaBancariaCodigo_Enabled ;
      private int imgprompt_41_128_Visible ;
      private int A282DepositoId ;
      private int edtDepositoId_Enabled ;
      private int edtDepositoFecha_Enabled ;
      private int edtDepositoEfectivo_Enabled ;
      private int edtDepositoCheque_Enabled ;
      private int edtDepositoTotal_Enabled ;
      private int edtUsuarioCodigo_Enabled ;
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
      private int Z282DepositoId ;
      private int AnyError4 ;
      private int AnyError41 ;
      private int AnyError128 ;
      private int idxLst ;
      private decimal A284DepositoEfectivo ;
      private decimal A285DepositoCheque ;
      private decimal A286DepositoTotal ;
      private decimal Z284DepositoEfectivo ;
      private decimal Z285DepositoCheque ;
      private decimal Z286DepositoTotal ;
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
      private String lblTextblockbancocodigo_Internalname ;
      private String lblTextblockbancocodigo_Jsonclick ;
      private String edtBancoCodigo_Internalname ;
      private String edtBancoCodigo_Jsonclick ;
      private String lblTextblockcuentabancariacodigo_Internalname ;
      private String lblTextblockcuentabancariacodigo_Jsonclick ;
      private String edtCuentaBancariaCodigo_Internalname ;
      private String edtCuentaBancariaCodigo_Jsonclick ;
      private String imgprompt_41_128_Internalname ;
      private String imgprompt_41_128_Link ;
      private String lblTextblockdepositoid_Internalname ;
      private String lblTextblockdepositoid_Jsonclick ;
      private String edtDepositoId_Internalname ;
      private String edtDepositoId_Jsonclick ;
      private String lblTextblockdepositofecha_Internalname ;
      private String lblTextblockdepositofecha_Jsonclick ;
      private String edtDepositoFecha_Internalname ;
      private String edtDepositoFecha_Jsonclick ;
      private String lblTextblockdepositoefectivo_Internalname ;
      private String lblTextblockdepositoefectivo_Jsonclick ;
      private String edtDepositoEfectivo_Internalname ;
      private String edtDepositoEfectivo_Jsonclick ;
      private String lblTextblockdepositocheque_Internalname ;
      private String lblTextblockdepositocheque_Jsonclick ;
      private String edtDepositoCheque_Internalname ;
      private String edtDepositoCheque_Jsonclick ;
      private String lblTextblockdepositototal_Internalname ;
      private String lblTextblockdepositototal_Jsonclick ;
      private String edtDepositoTotal_Internalname ;
      private String edtDepositoTotal_Jsonclick ;
      private String lblTextblockusuariocodigo_Internalname ;
      private String lblTextblockusuariocodigo_Jsonclick ;
      private String edtUsuarioCodigo_Internalname ;
      private String edtUsuarioCodigo_Jsonclick ;
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
      private String sMode69 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private DateTime A283DepositoFecha ;
      private DateTime Z283DepositoFecha ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A41ClinicaCodigo ;
      private String A128CuentaBancariaCodigo ;
      private String A126BancoCodigo ;
      private String A4UsuarioCodigo ;
      private String Z41ClinicaCodigo ;
      private String Z128CuentaBancariaCodigo ;
      private String Z4UsuarioCodigo ;
      private String AV9ClinicaCodigo ;
      private String AV11UsuarioCodigo ;
      private String Z126BancoCodigo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T001H5_A4UsuarioCodigo ;
      private int[] T001H6_A282DepositoId ;
      private DateTime[] T001H6_A283DepositoFecha ;
      private decimal[] T001H6_A284DepositoEfectivo ;
      private decimal[] T001H6_A285DepositoCheque ;
      private String[] T001H6_A41ClinicaCodigo ;
      private String[] T001H6_A128CuentaBancariaCodigo ;
      private String[] T001H6_A126BancoCodigo ;
      private String[] T001H6_A4UsuarioCodigo ;
      private String[] T001H4_A126BancoCodigo ;
      private String[] T001H7_A126BancoCodigo ;
      private String[] T001H8_A41ClinicaCodigo ;
      private String[] T001H8_A128CuentaBancariaCodigo ;
      private int[] T001H8_A282DepositoId ;
      private int[] T001H3_A282DepositoId ;
      private DateTime[] T001H3_A283DepositoFecha ;
      private decimal[] T001H3_A284DepositoEfectivo ;
      private decimal[] T001H3_A285DepositoCheque ;
      private String[] T001H3_A41ClinicaCodigo ;
      private String[] T001H3_A128CuentaBancariaCodigo ;
      private String[] T001H3_A4UsuarioCodigo ;
      private String[] T001H9_A41ClinicaCodigo ;
      private String[] T001H9_A128CuentaBancariaCodigo ;
      private int[] T001H9_A282DepositoId ;
      private String[] T001H10_A41ClinicaCodigo ;
      private String[] T001H10_A128CuentaBancariaCodigo ;
      private int[] T001H10_A282DepositoId ;
      private int[] T001H11_A282DepositoId ;
      private DateTime[] T001H11_A283DepositoFecha ;
      private decimal[] T001H11_A284DepositoEfectivo ;
      private decimal[] T001H11_A285DepositoCheque ;
      private String[] T001H11_A41ClinicaCodigo ;
      private String[] T001H11_A128CuentaBancariaCodigo ;
      private String[] T001H11_A4UsuarioCodigo ;
      private String[] T001H15_A126BancoCodigo ;
      private String[] T001H16_A41ClinicaCodigo ;
      private String[] T001H16_A128CuentaBancariaCodigo ;
      private int[] T001H16_A282DepositoId ;
      private int[] T001H2_A282DepositoId ;
      private DateTime[] T001H2_A283DepositoFecha ;
      private decimal[] T001H2_A284DepositoEfectivo ;
      private decimal[] T001H2_A285DepositoCheque ;
      private String[] T001H2_A41ClinicaCodigo ;
      private String[] T001H2_A128CuentaBancariaCodigo ;
      private String[] T001H2_A4UsuarioCodigo ;
      private GXWebForm Form ;
      private SdtParametros AV10Parametros ;
      private SdtParametros GXt_SdtParametros4 ;
   }

   public class depositobancario__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new UpdateCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT001H2 ;
          prmT001H2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepositoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001H5 ;
          prmT001H5 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001H6 ;
          prmT001H6 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepositoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001H4 ;
          prmT001H4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001H7 ;
          prmT001H7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001H8 ;
          prmT001H8 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepositoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001H3 ;
          prmT001H3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepositoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001H9 ;
          prmT001H9 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepositoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001H10 ;
          prmT001H10 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepositoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001H11 ;
          prmT001H11 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepositoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001H12 ;
          prmT001H12 = new Object[] {
          new Object[] {"@DepositoId",SqlDbType.Int,9,0} ,
          new Object[] {"@DepositoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@DepositoEfectivo",SqlDbType.Decimal,17,2} ,
          new Object[] {"@DepositoCheque",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001H13 ;
          prmT001H13 = new Object[] {
          new Object[] {"@DepositoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@DepositoEfectivo",SqlDbType.Decimal,17,2} ,
          new Object[] {"@DepositoCheque",SqlDbType.Decimal,17,2} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepositoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001H14 ;
          prmT001H14 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepositoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001H16 ;
          prmT001H16 = new Object[] {
          } ;
          Object[] prmT001H15 ;
          prmT001H15 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T001H2", "SELECT [DepositoId], [DepositoFecha], [DepositoEfectivo], [DepositoCheque], [ClinicaCodigo], [CuentaBancariaCodigo], [UsuarioCodigo] FROM [DepositoBancario] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CuentaBancariaCodigo] = @CuentaBancariaCodigo AND [DepositoId] = @DepositoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001H2,1,0,true,false )
             ,new CursorDef("T001H3", "SELECT [DepositoId], [DepositoFecha], [DepositoEfectivo], [DepositoCheque], [ClinicaCodigo], [CuentaBancariaCodigo], [UsuarioCodigo] FROM [DepositoBancario] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CuentaBancariaCodigo] = @CuentaBancariaCodigo AND [DepositoId] = @DepositoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001H3,1,0,true,false )
             ,new CursorDef("T001H4", "SELECT [BancoCodigo] FROM [CuentaBancaria] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CuentaBancariaCodigo] = @CuentaBancariaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001H4,1,0,true,false )
             ,new CursorDef("T001H5", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001H5,1,0,true,false )
             ,new CursorDef("T001H6", "SELECT TM1.[DepositoId], TM1.[DepositoFecha], TM1.[DepositoEfectivo], TM1.[DepositoCheque], TM1.[ClinicaCodigo], TM1.[CuentaBancariaCodigo], T2.[BancoCodigo], TM1.[UsuarioCodigo] FROM ([DepositoBancario] TM1 WITH (NOLOCK) INNER JOIN [CuentaBancaria] T2 WITH (NOLOCK) ON T2.[ClinicaCodigo] = TM1.[ClinicaCodigo] AND T2.[CuentaBancariaCodigo] = TM1.[CuentaBancariaCodigo]) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[CuentaBancariaCodigo] = @CuentaBancariaCodigo and TM1.[DepositoId] = @DepositoId ORDER BY TM1.[ClinicaCodigo], TM1.[CuentaBancariaCodigo], TM1.[DepositoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001H6,100,0,true,false )
             ,new CursorDef("T001H7", "SELECT [BancoCodigo] FROM [CuentaBancaria] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CuentaBancariaCodigo] = @CuentaBancariaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001H7,1,0,true,false )
             ,new CursorDef("T001H8", "SELECT [ClinicaCodigo], [CuentaBancariaCodigo], [DepositoId] FROM [DepositoBancario] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CuentaBancariaCodigo] = @CuentaBancariaCodigo AND [DepositoId] = @DepositoId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001H8,1,0,true,false )
             ,new CursorDef("T001H9", "SELECT TOP 1 [ClinicaCodigo], [CuentaBancariaCodigo], [DepositoId] FROM [DepositoBancario] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [CuentaBancariaCodigo] > @CuentaBancariaCodigo or [CuentaBancariaCodigo] = @CuentaBancariaCodigo and [ClinicaCodigo] = @ClinicaCodigo and [DepositoId] > @DepositoId) ORDER BY [ClinicaCodigo], [CuentaBancariaCodigo], [DepositoId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001H9,1,0,true,true )
             ,new CursorDef("T001H10", "SELECT TOP 1 [ClinicaCodigo], [CuentaBancariaCodigo], [DepositoId] FROM [DepositoBancario] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [CuentaBancariaCodigo] < @CuentaBancariaCodigo or [CuentaBancariaCodigo] = @CuentaBancariaCodigo and [ClinicaCodigo] = @ClinicaCodigo and [DepositoId] < @DepositoId) ORDER BY [ClinicaCodigo] DESC, [CuentaBancariaCodigo] DESC, [DepositoId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001H10,1,0,true,true )
             ,new CursorDef("T001H11", "SELECT [DepositoId], [DepositoFecha], [DepositoEfectivo], [DepositoCheque], [ClinicaCodigo], [CuentaBancariaCodigo], [UsuarioCodigo] FROM [DepositoBancario] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CuentaBancariaCodigo] = @CuentaBancariaCodigo AND [DepositoId] = @DepositoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001H11,1,0,true,false )
             ,new CursorDef("T001H12", "INSERT INTO [DepositoBancario] ([DepositoId], [DepositoFecha], [DepositoEfectivo], [DepositoCheque], [ClinicaCodigo], [CuentaBancariaCodigo], [UsuarioCodigo]) VALUES (@DepositoId, @DepositoFecha, @DepositoEfectivo, @DepositoCheque, @ClinicaCodigo, @CuentaBancariaCodigo, @UsuarioCodigo)", GxErrorMask.GX_NOMASK,prmT001H12)
             ,new CursorDef("T001H13", "UPDATE [DepositoBancario] SET [DepositoFecha]=@DepositoFecha, [DepositoEfectivo]=@DepositoEfectivo, [DepositoCheque]=@DepositoCheque, [UsuarioCodigo]=@UsuarioCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CuentaBancariaCodigo] = @CuentaBancariaCodigo AND [DepositoId] = @DepositoId", GxErrorMask.GX_NOMASK,prmT001H13)
             ,new CursorDef("T001H14", "DELETE FROM [DepositoBancario]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CuentaBancariaCodigo] = @CuentaBancariaCodigo AND [DepositoId] = @DepositoId", GxErrorMask.GX_NOMASK,prmT001H14)
             ,new CursorDef("T001H15", "SELECT [BancoCodigo] FROM [CuentaBancaria] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CuentaBancariaCodigo] = @CuentaBancariaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001H15,1,0,true,false )
             ,new CursorDef("T001H16", "SELECT [ClinicaCodigo], [CuentaBancariaCodigo], [DepositoId] FROM [DepositoBancario] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [CuentaBancariaCodigo], [DepositoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001H16,100,0,true,false )
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 10 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 11 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (decimal)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
