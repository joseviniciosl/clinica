/*
               File: CorteCaja
        Description: Cortes de Caja
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:5:48.26
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
   public class cortecaja : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_4") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A132CajaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_4( A41ClinicaCodigo, A132CajaCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_5") == 0 )
         {
            A4UsuarioCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_5( A4UsuarioCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_7") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A65FormaPagoCodigo = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_7( A41ClinicaCodigo, A65FormaPagoCodigo) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridcortecaja_formapago") == 0 )
         {
            nRC_Gridcortecaja_formapago = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            nGXsfl_70_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_70_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGridcortecaja_formapago_newrow( nRC_Gridcortecaja_formapago, nGXsfl_70_idx, sGXsfl_70_idx) ;
            return  ;
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
         Form.Meta.addItem("Description", "Cortes de Caja", 0) ;
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

      public cortecaja( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public cortecaja( IGxContext context )
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
            wb_table1_2_0Y43( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0Y43e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0Y43( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0Y43( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0Y43e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Cortes de Caja"+"</legend>") ;
            wb_table3_27_0Y43( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0Y43e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0Y43e( true) ;
         }
         else
         {
            wb_table1_2_0Y43e( false) ;
         }
      }

      protected void wb_table3_27_0Y43( bool wbgen )
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
            wb_table4_33_0Y43( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0Y43e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_CorteCaja.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_CorteCaja.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_CorteCaja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0Y43e( true) ;
         }
         else
         {
            wb_table3_27_0Y43e( false) ;
         }
      }

      protected void wb_table4_33_0Y43( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CorteCaja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_CorteCaja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcajacodigo_Internalname, "Caja", "", "", lblTextblockcajacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CorteCaja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCajaCodigo_Internalname, StringUtil.RTrim( A132CajaCodigo), StringUtil.RTrim( context.localUtil.Format( A132CajaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtCajaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtCajaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_CorteCaja.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_132_Internalname, "prompt.gif", imgprompt_41_132_Link, "", "", "Fantastic", imgprompt_41_132_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_CorteCaja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcortecajaid_Internalname, "Corte", "", "", lblTextblockcortecajaid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CorteCaja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153CorteCajaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A153CorteCajaId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCorteCajaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A153CorteCajaId), 9, 0, ".", "")), ((edtCorteCajaId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A153CorteCajaId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A153CorteCajaId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(48);\"", "", "", "", "", edtCorteCajaId_Jsonclick, 0, ClassString, StyleString, "", 1, edtCorteCajaId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_CorteCaja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcortecajafechad_Internalname, "Del", "", "", lblTextblockcortecajafechad_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CorteCaja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A278CorteCajaFechaD", context.localUtil.TToC( A278CorteCajaFechaD, 8, 5, 0, 3, "/", ":", " "));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtCorteCajaFechaD_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtCorteCajaFechaD_Internalname, context.localUtil.Format(A278CorteCajaFechaD, "99/99/99 99:99"), context.localUtil.Format( A278CorteCajaFechaD, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(53);\"", "", "", "", "", edtCorteCajaFechaD_Jsonclick, 0, ClassString, StyleString, "", 1, edtCorteCajaFechaD_Enabled, 0, 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, true, "right", "HLP_CorteCaja.htm");
            GxWebStd.gx_bitmap( context, edtCorteCajaFechaD_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtCorteCajaFechaD_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_CorteCaja.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcortecajafechaa_Internalname, "Al", "", "", lblTextblockcortecajafechaa_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CorteCaja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279CorteCajaFechaA", context.localUtil.TToC( A279CorteCajaFechaA, 8, 5, 0, 3, "/", ":", " "));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtCorteCajaFechaA_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtCorteCajaFechaA_Internalname, context.localUtil.Format(A279CorteCajaFechaA, "99/99/99 99:99"), context.localUtil.Format( A279CorteCajaFechaA, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(58);\"", "", "", "", "", edtCorteCajaFechaA_Jsonclick, 0, ClassString, StyleString, "", 1, edtCorteCajaFechaA_Enabled, 0, 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, true, "right", "HLP_CorteCaja.htm");
            GxWebStd.gx_bitmap( context, edtCorteCajaFechaA_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtCorteCajaFechaA_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_CorteCaja.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusuariocodigo_Internalname, "Usuario", "", "", lblTextblockusuariocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CorteCaja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUsuarioCodigo_Internalname, StringUtil.RTrim( A4UsuarioCodigo), StringUtil.RTrim( context.localUtil.Format( A4UsuarioCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", "", "", "", "", edtUsuarioCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtUsuarioCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_CorteCaja.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_4_Internalname, "prompt.gif", imgprompt_4_Link, "", "", "Fantastic", imgprompt_4_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_CorteCaja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "<br>") ;
            wb_table5_66_0Y43( true) ;
         }
         return  ;
      }

      protected void wb_table5_66_0Y43e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<hr class=\"HRDefault\">") ;
            /*  Grid Control  */
            Gridcortecaja_formapagoContainer.AddObjectProperty("GridName", "Gridcortecaja_formapago");
            Gridcortecaja_formapagoContainer.AddObjectProperty("Class", "Grid");
            Gridcortecaja_formapagoContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Gridcortecaja_formapagoContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Gridcortecaja_formapagoContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcortecaja_formapago_Backcolorstyle), 1, 0, ".", "")));
            Gridcortecaja_formapagoContainer.AddObjectProperty("CmpContext", "");
            Gridcortecaja_formapagoContainer.AddObjectProperty("InMasterPage", "false");
            Gridcortecaja_formapagoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcortecaja_formapagoColumn.AddObjectProperty("Value", StringUtil.RTrim( A65FormaPagoCodigo));
            Gridcortecaja_formapagoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFormaPagoCodigo_Enabled), 5, 0, ".", "")));
            Gridcortecaja_formapagoContainer.AddColumnProperties(Gridcortecaja_formapagoColumn);
            Gridcortecaja_formapagoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcortecaja_formapagoContainer.AddColumnProperties(Gridcortecaja_formapagoColumn);
            Gridcortecaja_formapagoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcortecaja_formapagoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A156CorteCajaValor, 17, 2, ".", "")));
            Gridcortecaja_formapagoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCorteCajaValor_Enabled), 5, 0, ".", "")));
            Gridcortecaja_formapagoContainer.AddColumnProperties(Gridcortecaja_formapagoColumn);
            Gridcortecaja_formapagoContainer.AddObjectProperty("Allowselection", "false");
            Gridcortecaja_formapagoContainer.AddObjectProperty("Allowcollapsing", ((subGridcortecaja_formapago_Allowcollapsing==1) ? "true" : "false"));
            Gridcortecaja_formapagoContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcortecaja_formapago_Collapsed), 9, 0, ".", "")));
            nGXsfl_70_idx = 0 ;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount44 = 5 ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_44 = 1 ;
                  ScanStart0Y44( ) ;
                  while ( RcdFound44 != 0 )
                  {
                     init_level_properties44( ) ;
                     getByPrimaryKey0Y44( ) ;
                     AddRow0Y44( ) ;
                     ScanNext0Y44( ) ;
                  }
                  ScanEnd0Y44( ) ;
                  nBlankRcdCount44 = 5 ;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               standaloneNotModal0Y44( ) ;
               standaloneModal0Y44( ) ;
               sMode44 = Gx_mode ;
               while ( nGXsfl_70_idx < nRC_Gridcortecaja_formapago )
               {
                  ReadRow0Y44( ) ;
                  edtFormaPagoCodigo_Enabled = (int)(context.localUtil.CToN( cgiGet( "FORMAPAGOCODIGO_"+sGXsfl_70_idx+"Enabled"), ".", ",")) ;
                  edtCorteCajaValor_Enabled = (int)(context.localUtil.CToN( cgiGet( "CORTECAJAVALOR_"+sGXsfl_70_idx+"Enabled"), ".", ",")) ;
                  imgprompt_41_132_Link = cgiGet( "PROMPT_65_"+sGXsfl_70_idx+"Link") ;
                  if ( ( nRcdExists_44 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal0Y44( ) ;
                  }
                  SendRow0Y44( ) ;
               }
               Gx_mode = sMode44 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount44 = 5 ;
               nRcdExists_44 = 1 ;
               ScanStart0Y44( ) ;
               while ( RcdFound44 != 0 )
               {
                  init_level_properties44( ) ;
                  getByPrimaryKey0Y44( ) ;
                  standaloneNotModal0Y44( ) ;
                  standaloneModal0Y44( ) ;
                  AddRow0Y44( ) ;
                  ScanNext0Y44( ) ;
               }
               ScanEnd0Y44( ) ;
            }
            /* Initialize fields for 'new' records and send them. */
            sMode44 = Gx_mode ;
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            InitAll0Y44( ) ;
            init_level_properties44( ) ;
            standaloneNotModal0Y44( ) ;
            standaloneModal0Y44( ) ;
            nRcdExists_44 = 0 ;
            nIsMod_44 = 0 ;
            nBlankRcdCount44 = (short)(nBlankRcdUsr44+nBlankRcdCount44) ;
            fRowAdded = 0 ;
            while ( nBlankRcdCount44 > 0 )
            {
               AddRow0Y44( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1 ;
                  GX_FocusControl = edtFormaPagoCodigo_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount44 = (short)(nBlankRcdCount44-1) ;
            }
            Gx_mode = sMode44 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            sStyleString = " style=\"display:none;\"" ;
            sStyleString = "" ;
            context.WriteHtmlText( "<div id=\""+"Gridcortecaja_formapagoContainer"+"Div\" "+sStyleString+">"+"</div>") ;
            context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridcortecaja_formapago", (Object)(Gridcortecaja_formapagoContainer));
            GxWebStd.gx_hidden_field( context, "Gridcortecaja_formapagoContainerData", Gridcortecaja_formapagoContainer.ToJavascriptSource());
            if ( context.isAjaxRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Gridcortecaja_formapagoContainerData"+"V", Gridcortecaja_formapagoContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridcortecaja_formapagoContainerData"+"V"+"\" value='"+Gridcortecaja_formapagoContainer.GridValuesHidden()+"'>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0Y43e( true) ;
         }
         else
         {
            wb_table4_33_0Y43e( false) ;
         }
      }

      protected void wb_table5_66_0Y43( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table95", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class=\"SubTitle\" >") ;
            /* Text block */
            ClassString = "" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTitleformapago_Internalname, "Forma Pago", "", "", lblTitleformapago_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CorteCaja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_66_0Y43e( true) ;
         }
         else
         {
            wb_table5_66_0Y43e( false) ;
         }
      }

      protected void wb_table2_5_0Y43( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CorteCaja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CorteCaja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CorteCaja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CorteCaja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CorteCaja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CorteCaja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CorteCaja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CorteCaja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0170.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CAJACODIGO"+"'), id:'"+"CAJACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CORTECAJAID"+"'), id:'"+"CORTECAJAID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_CorteCaja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0170.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CAJACODIGO"+"'), id:'"+"CAJACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CORTECAJAID"+"'), id:'"+"CORTECAJAID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_CorteCaja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CorteCaja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CorteCaja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CorteCaja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CorteCaja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CorteCaja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CorteCaja.htm");
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
            wb_table2_5_0Y43e( true) ;
         }
         else
         {
            wb_table2_5_0Y43e( false) ;
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
               A132CajaCodigo = cgiGet( edtCajaCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
               if ( ( ( context.localUtil.CToN( cgiGet( edtCorteCajaId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCorteCajaId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CORTECAJAID");
                  AnyError = 1 ;
                  GX_FocusControl = edtCorteCajaId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A153CorteCajaId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153CorteCajaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A153CorteCajaId), 9, 0)));
               }
               else
               {
                  A153CorteCajaId = (int)(context.localUtil.CToN( cgiGet( edtCorteCajaId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153CorteCajaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A153CorteCajaId), 9, 0)));
               }
               if ( context.localUtil.VCDateTime( cgiGet( edtCorteCajaFechaD_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Fecha_Del"}), 1, "CORTECAJAFECHAD");
                  AnyError = 1 ;
                  GX_FocusControl = edtCorteCajaFechaD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A278CorteCajaFechaD = (DateTime)(DateTime.MinValue) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A278CorteCajaFechaD", context.localUtil.TToC( A278CorteCajaFechaD, 8, 5, 0, 3, "/", ":", " "));
               }
               else
               {
                  A278CorteCajaFechaD = context.localUtil.CToT( cgiGet( edtCorteCajaFechaD_Internalname)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A278CorteCajaFechaD", context.localUtil.TToC( A278CorteCajaFechaD, 8, 5, 0, 3, "/", ":", " "));
               }
               if ( context.localUtil.VCDateTime( cgiGet( edtCorteCajaFechaA_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Fecha_Al"}), 1, "CORTECAJAFECHAA");
                  AnyError = 1 ;
                  GX_FocusControl = edtCorteCajaFechaA_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A279CorteCajaFechaA = (DateTime)(DateTime.MinValue) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279CorteCajaFechaA", context.localUtil.TToC( A279CorteCajaFechaA, 8, 5, 0, 3, "/", ":", " "));
               }
               else
               {
                  A279CorteCajaFechaA = context.localUtil.CToT( cgiGet( edtCorteCajaFechaA_Internalname)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279CorteCajaFechaA", context.localUtil.TToC( A279CorteCajaFechaA, 8, 5, 0, 3, "/", ":", " "));
               }
               A4UsuarioCodigo = cgiGet( edtUsuarioCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z132CajaCodigo = cgiGet( "Z132CajaCodigo") ;
               Z153CorteCajaId = (int)(context.localUtil.CToN( cgiGet( "Z153CorteCajaId"), ".", ",")) ;
               Z278CorteCajaFechaD = context.localUtil.CToT( cgiGet( "Z278CorteCajaFechaD"), 0) ;
               Z279CorteCajaFechaA = context.localUtil.CToT( cgiGet( "Z279CorteCajaFechaA"), 0) ;
               Z4UsuarioCodigo = cgiGet( "Z4UsuarioCodigo") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               nRC_Gridcortecaja_formapago = (short)(context.localUtil.CToN( cgiGet( "nRC_Gridcortecaja_formapago"), ".", ",")) ;
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
                  A132CajaCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
                  A153CorteCajaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153CorteCajaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A153CorteCajaId), 9, 0)));
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
               /* Check if conditions changed and reset current page numbers */
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
                        sEvtType = StringUtil.Right( sEvt, 4) ;
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
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
               InitAll0Y43( ) ;
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
         DisableAttributes0Y43( ) ;
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

      protected void CONFIRM_0Y44( )
      {
         nGXsfl_70_idx = 0 ;
         while ( nGXsfl_70_idx < nRC_Gridcortecaja_formapago )
         {
            ReadRow0Y44( ) ;
            if ( ( nRcdExists_44 != 0 ) || ( nIsMod_44 != 0 ) )
            {
               GetKey0Y44( ) ;
               if ( ( nRcdExists_44 == 0 ) && ( nRcdDeleted_44 == 0 ) )
               {
                  if ( RcdFound44 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate0Y44( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0Y44( ) ;
                        CloseExtendedTableCursors0Y44( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1 ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtFormaPagoCodigo_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound44 != 0 )
                  {
                     if ( nRcdDeleted_44 != 0 )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey0Y44( ) ;
                        Load0Y44( ) ;
                        BeforeValidate0Y44( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0Y44( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_44 != 0 )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate0Y44( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0Y44( ) ;
                              CloseExtendedTableCursors0Y44( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1 ;
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_44 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtFormaPagoCodigo_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtFormaPagoCodigo_Internalname, StringUtil.RTrim( A65FormaPagoCodigo)) ;
            ChangePostValue( edtCorteCajaValor_Internalname, StringUtil.LTrim( StringUtil.NToC( A156CorteCajaValor, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z65FormaPagoCodigo_"+sGXsfl_70_idx, StringUtil.RTrim( Z65FormaPagoCodigo)) ;
            ChangePostValue( "ZT_"+"Z156CorteCajaValor_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( Z156CorteCajaValor, 17, 2, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_44_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_44), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_44_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_44), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_44_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_44), 4, 0, ".", ""))) ;
            if ( nIsMod_44 != 0 )
            {
               ChangePostValue( "FORMAPAGOCODIGO_"+sGXsfl_70_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFormaPagoCodigo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CORTECAJAVALOR_"+sGXsfl_70_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCorteCajaValor_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption0Y0( )
      {
      }

      protected void ZM0Y43( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z278CorteCajaFechaD = T000Y6_A278CorteCajaFechaD[0] ;
               Z279CorteCajaFechaA = T000Y6_A279CorteCajaFechaA[0] ;
               Z4UsuarioCodigo = T000Y6_A4UsuarioCodigo[0] ;
            }
            else
            {
               Z278CorteCajaFechaD = A278CorteCajaFechaD ;
               Z279CorteCajaFechaA = A279CorteCajaFechaA ;
               Z4UsuarioCodigo = A4UsuarioCodigo ;
            }
         }
         if ( GX_JID == -3 )
         {
            Z153CorteCajaId = A153CorteCajaId ;
            Z278CorteCajaFechaD = A278CorteCajaFechaD ;
            Z279CorteCajaFechaA = A279CorteCajaFechaA ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z132CajaCodigo = A132CajaCodigo ;
            Z4UsuarioCodigo = A4UsuarioCodigo ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_41_132_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0100.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CAJACODIGO"+"'), id:'"+"CAJACODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"true"+");") ;
         imgprompt_4_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0020.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USUARIOCODIGO"+"'), id:'"+"USUARIOCODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
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

      protected void Load0Y43( )
      {
         /* Using cursor T000Y9 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A153CorteCajaId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound43 = 1 ;
            A278CorteCajaFechaD = T000Y9_A278CorteCajaFechaD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A278CorteCajaFechaD", context.localUtil.TToC( A278CorteCajaFechaD, 8, 5, 0, 3, "/", ":", " "));
            A279CorteCajaFechaA = T000Y9_A279CorteCajaFechaA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279CorteCajaFechaA", context.localUtil.TToC( A279CorteCajaFechaA, 8, 5, 0, 3, "/", ":", " "));
            A4UsuarioCodigo = T000Y9_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            ZM0Y43( -3) ;
         }
         pr_default.close(7);
         OnLoadActions0Y43( ) ;
      }

      protected void OnLoadActions0Y43( )
      {
      }

      protected void CheckExtendedTable0Y43( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T000Y7 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A132CajaCodigo});
         if ( (pr_default.getStatus(5) == 101) )
         {
            AnyError41 = 1 ;
            AnyError132 = 1 ;
            GX_msglist.addItem("No existe 'Cajas'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError132 == 0 ) )
         {
         }
         pr_default.close(5);
         if ( ! ( (DateTime.MinValue==A278CorteCajaFechaD) || ( A278CorteCajaFechaD >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Fecha_Del fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A279CorteCajaFechaA) || ( A279CorteCajaFechaA >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Fecha_Al fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         /* Using cursor T000Y8 */
         pr_default.execute(6, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(6) == 101) )
         {
            AnyError4 = 1 ;
            GX_msglist.addItem("No existe 'Usuarios'.", "ForeignKeyNotFound", 1, "USUARIOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtUsuarioCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError4 == 0 )
         {
         }
         pr_default.close(6);
      }

      protected void CloseExtendedTableCursors0Y43( )
      {
         pr_default.close(5);
         pr_default.close(6);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_4( String A41ClinicaCodigo ,
                               String A132CajaCodigo )
      {
         /* Using cursor T000Y10 */
         pr_default.execute(8, new Object[] {A41ClinicaCodigo, A132CajaCodigo});
         if ( (pr_default.getStatus(8) == 101) )
         {
            AnyError41 = 1 ;
            AnyError132 = 1 ;
            GX_msglist.addItem("No existe 'Cajas'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError132 == 0 ) )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(8) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(8);
      }

      protected void gxLoad_5( String A4UsuarioCodigo )
      {
         /* Using cursor T000Y11 */
         pr_default.execute(9, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(9) == 101) )
         {
            AnyError4 = 1 ;
            GX_msglist.addItem("No existe 'Usuarios'.", "ForeignKeyNotFound", 1, "USUARIOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtUsuarioCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError4 == 0 )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(9) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(9);
      }

      protected void GetKey0Y43( )
      {
         /* Using cursor T000Y12 */
         pr_default.execute(10, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A153CorteCajaId});
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound43 = 1 ;
         }
         else
         {
            RcdFound43 = 0 ;
         }
         pr_default.close(10);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000Y6 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A153CorteCajaId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM0Y43( 3) ;
            RcdFound43 = 1 ;
            A153CorteCajaId = T000Y6_A153CorteCajaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153CorteCajaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A153CorteCajaId), 9, 0)));
            A278CorteCajaFechaD = T000Y6_A278CorteCajaFechaD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A278CorteCajaFechaD", context.localUtil.TToC( A278CorteCajaFechaD, 8, 5, 0, 3, "/", ":", " "));
            A279CorteCajaFechaA = T000Y6_A279CorteCajaFechaA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279CorteCajaFechaA", context.localUtil.TToC( A279CorteCajaFechaA, 8, 5, 0, 3, "/", ":", " "));
            A41ClinicaCodigo = T000Y6_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A132CajaCodigo = T000Y6_A132CajaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
            A4UsuarioCodigo = T000Y6_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z132CajaCodigo = A132CajaCodigo ;
            Z153CorteCajaId = A153CorteCajaId ;
            sMode43 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0Y43( ) ;
            Gx_mode = sMode43 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound43 = 0 ;
            InitializeNonKey0Y43( ) ;
            sMode43 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode43 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey0Y43( ) ;
         if ( RcdFound43 == 0 )
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
         RcdFound43 = 0 ;
         /* Using cursor T000Y13 */
         pr_default.execute(11, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A153CorteCajaId});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( StringUtil.StrCmp(T000Y13_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000Y13_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000Y13_A132CajaCodigo[0], A132CajaCodigo) < 0 ) || ( StringUtil.StrCmp(T000Y13_A132CajaCodigo[0], A132CajaCodigo) == 0 ) && ( StringUtil.StrCmp(T000Y13_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000Y13_A153CorteCajaId[0] < A153CorteCajaId ) ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( StringUtil.StrCmp(T000Y13_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000Y13_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000Y13_A132CajaCodigo[0], A132CajaCodigo) > 0 ) || ( StringUtil.StrCmp(T000Y13_A132CajaCodigo[0], A132CajaCodigo) == 0 ) && ( StringUtil.StrCmp(T000Y13_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000Y13_A153CorteCajaId[0] > A153CorteCajaId ) ) )
            {
               A41ClinicaCodigo = T000Y13_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A132CajaCodigo = T000Y13_A132CajaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
               A153CorteCajaId = T000Y13_A153CorteCajaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153CorteCajaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A153CorteCajaId), 9, 0)));
               RcdFound43 = 1 ;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound43 = 0 ;
         /* Using cursor T000Y14 */
         pr_default.execute(12, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A153CorteCajaId});
         if ( (pr_default.getStatus(12) != 101) )
         {
            while ( (pr_default.getStatus(12) != 101) && ( ( StringUtil.StrCmp(T000Y14_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000Y14_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000Y14_A132CajaCodigo[0], A132CajaCodigo) > 0 ) || ( StringUtil.StrCmp(T000Y14_A132CajaCodigo[0], A132CajaCodigo) == 0 ) && ( StringUtil.StrCmp(T000Y14_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000Y14_A153CorteCajaId[0] > A153CorteCajaId ) ) )
            {
               pr_default.readNext(12);
            }
            if ( (pr_default.getStatus(12) != 101) && ( ( StringUtil.StrCmp(T000Y14_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000Y14_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000Y14_A132CajaCodigo[0], A132CajaCodigo) < 0 ) || ( StringUtil.StrCmp(T000Y14_A132CajaCodigo[0], A132CajaCodigo) == 0 ) && ( StringUtil.StrCmp(T000Y14_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000Y14_A153CorteCajaId[0] < A153CorteCajaId ) ) )
            {
               A41ClinicaCodigo = T000Y14_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A132CajaCodigo = T000Y14_A132CajaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
               A153CorteCajaId = T000Y14_A153CorteCajaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153CorteCajaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A153CorteCajaId), 9, 0)));
               RcdFound43 = 1 ;
            }
         }
         pr_default.close(3);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0Y43( ) ;
         if ( RcdFound43 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A132CajaCodigo, Z132CajaCodigo) != 0 ) || ( A153CorteCajaId != Z153CorteCajaId ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A132CajaCodigo = Z132CajaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
               A153CorteCajaId = Z153CorteCajaId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153CorteCajaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A153CorteCajaId), 9, 0)));
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
               Update0Y43( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A132CajaCodigo, Z132CajaCodigo) != 0 ) || ( A153CorteCajaId != Z153CorteCajaId ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert0Y43( ) ;
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
                  Insert0Y43( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A132CajaCodigo, Z132CajaCodigo) != 0 ) || ( A153CorteCajaId != Z153CorteCajaId ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A132CajaCodigo = Z132CajaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
            A153CorteCajaId = Z153CorteCajaId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153CorteCajaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A153CorteCajaId), 9, 0)));
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
         if ( RcdFound43 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtCorteCajaFechaD_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0Y43( ) ;
         if ( RcdFound43 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCorteCajaFechaD_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0Y43( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound43 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCorteCajaFechaD_Internalname ;
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
         if ( RcdFound43 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCorteCajaFechaD_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0Y43( ) ;
         if ( RcdFound43 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound43 != 0 )
            {
               ScanNext0Y43( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCorteCajaFechaD_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0Y43( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0Y43( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000Y15 */
            pr_default.execute(13, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A153CorteCajaId});
            if ( (pr_default.getStatus(13) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CorteCaja"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(13) == 101) || ( Z278CorteCajaFechaD != T000Y15_A278CorteCajaFechaD[0] ) || ( Z279CorteCajaFechaA != T000Y15_A279CorteCajaFechaA[0] ) || ( StringUtil.StrCmp(Z4UsuarioCodigo, T000Y15_A4UsuarioCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"CorteCaja"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0Y43( )
      {
         BeforeValidate0Y43( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Y43( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0Y43( 0) ;
            CheckOptimisticConcurrency0Y43( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Y43( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0Y43( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Y16 */
                     pr_default.execute(14, new Object[] {A153CorteCajaId, A278CorteCajaFechaD, A279CorteCajaFechaA, A41ClinicaCodigo, A132CajaCodigo, A4UsuarioCodigo});
                     pr_default.close(14);
                     if ( (pr_default.getStatus(14) == 1) )
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
                           ProcessLevel0Y43( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                              ResetCaption0Y0( ) ;
                           }
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
               Load0Y43( ) ;
            }
            EndLevel0Y43( ) ;
         }
         CloseExtendedTableCursors0Y43( ) ;
      }

      protected void Update0Y43( )
      {
         BeforeValidate0Y43( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Y43( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Y43( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Y43( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0Y43( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Y17 */
                     pr_default.execute(15, new Object[] {A278CorteCajaFechaD, A279CorteCajaFechaA, A4UsuarioCodigo, A41ClinicaCodigo, A132CajaCodigo, A153CorteCajaId});
                     pr_default.close(15);
                     if ( (pr_default.getStatus(15) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CorteCaja"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0Y43( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0Y43( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                              ResetCaption0Y0( ) ;
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
            }
            EndLevel0Y43( ) ;
         }
         CloseExtendedTableCursors0Y43( ) ;
      }

      protected void DeferredUpdate0Y43( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0Y43( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Y43( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0Y43( ) ;
            AfterConfirm0Y43( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0Y43( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart0Y44( ) ;
                  while ( RcdFound44 != 0 )
                  {
                     getByPrimaryKey0Y44( ) ;
                     Delete0Y44( ) ;
                     ScanNext0Y44( ) ;
                  }
                  ScanEnd0Y44( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Y18 */
                     pr_default.execute(16, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A153CorteCajaId});
                     pr_default.close(16);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound43 == 0 )
                           {
                              InitAll0Y43( ) ;
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
                           ResetCaption0Y0( ) ;
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
         }
         sMode43 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0Y43( ) ;
         Gx_mode = sMode43 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0Y43( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void ProcessNestedLevel0Y44( )
      {
         nGXsfl_70_idx = 0 ;
         while ( nGXsfl_70_idx < nRC_Gridcortecaja_formapago )
         {
            ReadRow0Y44( ) ;
            if ( ( nRcdExists_44 != 0 ) || ( nIsMod_44 != 0 ) )
            {
               standaloneNotModal0Y44( ) ;
               GetKey0Y44( ) ;
               if ( ( nRcdExists_44 == 0 ) && ( nRcdDeleted_44 == 0 ) )
               {
                  if ( RcdFound44 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Insert0Y44( ) ;
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtFormaPagoCodigo_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound44 != 0 )
                  {
                     if ( ( nRcdDeleted_44 != 0 ) && ( nRcdExists_44 != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete0Y44( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_44 != 0 ) && ( nRcdExists_44 != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update0Y44( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_44 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtFormaPagoCodigo_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtFormaPagoCodigo_Internalname, StringUtil.RTrim( A65FormaPagoCodigo)) ;
            ChangePostValue( edtCorteCajaValor_Internalname, StringUtil.LTrim( StringUtil.NToC( A156CorteCajaValor, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z65FormaPagoCodigo_"+sGXsfl_70_idx, StringUtil.RTrim( Z65FormaPagoCodigo)) ;
            ChangePostValue( "ZT_"+"Z156CorteCajaValor_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( Z156CorteCajaValor, 17, 2, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_44_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_44), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_44_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_44), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_44_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_44), 4, 0, ".", ""))) ;
            if ( nIsMod_44 != 0 )
            {
               ChangePostValue( "FORMAPAGOCODIGO_"+sGXsfl_70_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFormaPagoCodigo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CORTECAJAVALOR_"+sGXsfl_70_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCorteCajaValor_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0Y44( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_44 = 0 ;
         nIsMod_44 = 0 ;
         nRcdDeleted_44 = 0 ;
      }

      protected void ProcessLevel0Y43( )
      {
         /* Save parent mode. */
         sMode43 = Gx_mode ;
         ProcessNestedLevel0Y44( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode43 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel0Y43( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(13);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0Y43( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(12);
            pr_default.close(11);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(2);
            context.CommitDataStores("CorteCaja");
            if ( AnyError == 0 )
            {
               ConfirmValues0Y0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(12);
            pr_default.close(11);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(2);
            context.RollbackDataStores("CorteCaja");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0Y43( )
      {
         /* Using cursor T000Y19 */
         pr_default.execute(17);
         RcdFound43 = 0 ;
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound43 = 1 ;
            A41ClinicaCodigo = T000Y19_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A132CajaCodigo = T000Y19_A132CajaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
            A153CorteCajaId = T000Y19_A153CorteCajaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153CorteCajaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A153CorteCajaId), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0Y43( )
      {
         pr_default.readNext(17);
         RcdFound43 = 0 ;
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound43 = 1 ;
            A41ClinicaCodigo = T000Y19_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A132CajaCodigo = T000Y19_A132CajaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
            A153CorteCajaId = T000Y19_A153CorteCajaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153CorteCajaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A153CorteCajaId), 9, 0)));
         }
      }

      protected void ScanEnd0Y43( )
      {
      }

      protected void AfterConfirm0Y43( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0Y43( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0Y43( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0Y43( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0Y43( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0Y43( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0Y43( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtCajaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCajaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCajaCodigo_Enabled), 5, 0)));
         edtCorteCajaId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCorteCajaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCorteCajaId_Enabled), 5, 0)));
         edtCorteCajaFechaD_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCorteCajaFechaD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCorteCajaFechaD_Enabled), 5, 0)));
         edtCorteCajaFechaA_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCorteCajaFechaA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCorteCajaFechaA_Enabled), 5, 0)));
         edtUsuarioCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioCodigo_Enabled), 5, 0)));
      }

      protected void ZM0Y44( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z156CorteCajaValor = T000Y3_A156CorteCajaValor[0] ;
            }
            else
            {
               Z156CorteCajaValor = A156CorteCajaValor ;
            }
         }
         if ( GX_JID == -6 )
         {
            Z132CajaCodigo = A132CajaCodigo ;
            Z153CorteCajaId = A153CorteCajaId ;
            Z156CorteCajaValor = A156CorteCajaValor ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z65FormaPagoCodigo = A65FormaPagoCodigo ;
         }
      }

      protected void standaloneNotModal0Y44( )
      {
      }

      protected void standaloneModal0Y44( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtFormaPagoCodigo_Enabled = 0 ;
         }
         else
         {
            edtFormaPagoCodigo_Enabled = 1 ;
         }
         if ( ( StringUtil.StrCmp(sMode44, "DSP") == 0 ) || ( StringUtil.StrCmp(sMode44, "DLT") == 0 ) )
         {
            DisableAttributes0Y44( ) ;
         }
      }

      protected void Load0Y44( )
      {
         /* Using cursor T000Y20 */
         pr_default.execute(18, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A153CorteCajaId, A65FormaPagoCodigo});
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound44 = 1 ;
            A156CorteCajaValor = T000Y20_A156CorteCajaValor[0] ;
            ZM0Y44( -6) ;
         }
         pr_default.close(18);
         OnLoadActions0Y44( ) ;
      }

      protected void OnLoadActions0Y44( )
      {
      }

      protected void CheckExtendedTable0Y44( )
      {
         Gx_BScreen = 1 ;
         standaloneModal0Y44( ) ;
         /* Using cursor T000Y4 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo, A65FormaPagoCodigo});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError41 = 1 ;
            AnyError65 = 1 ;
            GX_msglist.addItem("No existe 'Formas de pago'.", "ForeignKeyNotFound", 1, "FORMAPAGOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtFormaPagoCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError65 == 0 ) )
         {
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0Y44( )
      {
         pr_default.close(2);
      }

      protected void enableDisable0Y44( )
      {
      }

      protected void gxLoad_7( String A41ClinicaCodigo ,
                               String A65FormaPagoCodigo )
      {
         /* Using cursor T000Y21 */
         pr_default.execute(19, new Object[] {A41ClinicaCodigo, A65FormaPagoCodigo});
         if ( (pr_default.getStatus(19) == 101) )
         {
            AnyError41 = 1 ;
            AnyError65 = 1 ;
            GX_msglist.addItem("No existe 'Formas de pago'.", "ForeignKeyNotFound", 1, "FORMAPAGOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtFormaPagoCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError65 == 0 ) )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(19) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(19);
      }

      protected void GetKey0Y44( )
      {
         /* Using cursor T000Y22 */
         pr_default.execute(20, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A153CorteCajaId, A65FormaPagoCodigo});
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound44 = 1 ;
         }
         else
         {
            RcdFound44 = 0 ;
         }
         pr_default.close(20);
      }

      protected void getByPrimaryKey0Y44( )
      {
         /* Using cursor T000Y3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A153CorteCajaId, A65FormaPagoCodigo});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0Y44( 6) ;
            RcdFound44 = 1 ;
            InitializeNonKey0Y44( ) ;
            A156CorteCajaValor = T000Y3_A156CorteCajaValor[0] ;
            A65FormaPagoCodigo = T000Y3_A65FormaPagoCodigo[0] ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z132CajaCodigo = A132CajaCodigo ;
            Z153CorteCajaId = A153CorteCajaId ;
            Z65FormaPagoCodigo = A65FormaPagoCodigo ;
            sMode44 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0Y44( ) ;
            Load0Y44( ) ;
            Gx_mode = sMode44 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound44 = 0 ;
            InitializeNonKey0Y44( ) ;
            sMode44 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0Y44( ) ;
            Gx_mode = sMode44 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0Y44( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000Y2 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A153CorteCajaId, A65FormaPagoCodigo});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CorteCajaDet"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z156CorteCajaValor != T000Y2_A156CorteCajaValor[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"CorteCajaDet"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0Y44( )
      {
         BeforeValidate0Y44( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Y44( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0Y44( 0) ;
            CheckOptimisticConcurrency0Y44( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Y44( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0Y44( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Y23 */
                     pr_default.execute(21, new Object[] {A132CajaCodigo, A153CorteCajaId, A156CorteCajaValor, A41ClinicaCodigo, A65FormaPagoCodigo});
                     pr_default.close(21);
                     if ( (pr_default.getStatus(21) == 1) )
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
               Load0Y44( ) ;
            }
            EndLevel0Y44( ) ;
         }
         CloseExtendedTableCursors0Y44( ) ;
      }

      protected void Update0Y44( )
      {
         BeforeValidate0Y44( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Y44( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Y44( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Y44( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0Y44( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Y24 */
                     pr_default.execute(22, new Object[] {A156CorteCajaValor, A41ClinicaCodigo, A132CajaCodigo, A153CorteCajaId, A65FormaPagoCodigo});
                     pr_default.close(22);
                     if ( (pr_default.getStatus(22) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CorteCajaDet"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0Y44( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0Y44( ) ;
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
            EndLevel0Y44( ) ;
         }
         CloseExtendedTableCursors0Y44( ) ;
      }

      protected void DeferredUpdate0Y44( )
      {
      }

      protected void Delete0Y44( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0Y44( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Y44( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0Y44( ) ;
            AfterConfirm0Y44( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0Y44( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000Y25 */
                  pr_default.execute(23, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A153CorteCajaId, A65FormaPagoCodigo});
                  pr_default.close(23);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
         }
         sMode44 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0Y44( ) ;
         Gx_mode = sMode44 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0Y44( )
      {
         standaloneModal0Y44( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0Y44( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0Y44( )
      {
         /* Using cursor T000Y26 */
         pr_default.execute(24, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A153CorteCajaId});
         RcdFound44 = 0 ;
         if ( (pr_default.getStatus(24) != 101) )
         {
            RcdFound44 = 1 ;
            A65FormaPagoCodigo = T000Y26_A65FormaPagoCodigo[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0Y44( )
      {
         pr_default.readNext(24);
         RcdFound44 = 0 ;
         if ( (pr_default.getStatus(24) != 101) )
         {
            RcdFound44 = 1 ;
            A65FormaPagoCodigo = T000Y26_A65FormaPagoCodigo[0] ;
         }
      }

      protected void ScanEnd0Y44( )
      {
         pr_default.close(1);
      }

      protected void AfterConfirm0Y44( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0Y44( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0Y44( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0Y44( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0Y44( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0Y44( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0Y44( )
      {
         edtFormaPagoCodigo_Enabled = 0 ;
         edtCorteCajaValor_Enabled = 0 ;
      }

      protected void AddRow0Y44( )
      {
         nGXsfl_70_idx = (short)(nGXsfl_70_idx+1) ;
         sGXsfl_70_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_70_idx), 4, 0)), 4, "0") ;
         edtFormaPagoCodigo_Internalname = "FORMAPAGOCODIGO_"+sGXsfl_70_idx ;
         imgprompt_65_Internalname = "PROMPT_65_"+sGXsfl_70_idx ;
         edtCorteCajaValor_Internalname = "CORTECAJAVALOR_"+sGXsfl_70_idx ;
         SendRow0Y44( ) ;
      }

      protected void SendRow0Y44( )
      {
         Gridcortecaja_formapagoRow = GXWebRow.GetNew(context) ;
         if ( subGridcortecaja_formapago_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridcortecaja_formapago_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGridcortecaja_formapago_Class, "") != 0 )
            {
               subGridcortecaja_formapago_Linesclass = subGridcortecaja_formapago_Class+"Odd" ;
            }
         }
         else if ( subGridcortecaja_formapago_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridcortecaja_formapago_Backstyle = 0 ;
            subGridcortecaja_formapago_Backcolor = subGridcortecaja_formapago_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridcortecaja_formapagoContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridcortecaja_formapago_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGridcortecaja_formapago_Class, "") != 0 )
            {
               subGridcortecaja_formapago_Linesclass = subGridcortecaja_formapago_Class+"Uniform" ;
            }
         }
         else if ( subGridcortecaja_formapago_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridcortecaja_formapago_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGridcortecaja_formapago_Class, "") != 0 )
            {
               subGridcortecaja_formapago_Linesclass = subGridcortecaja_formapago_Class+"Odd" ;
            }
            subGridcortecaja_formapago_Backcolor = (int)(0xFFFFFF) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridcortecaja_formapagoContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridcortecaja_formapago_Backcolor), 9, 0)));
         }
         else if ( subGridcortecaja_formapago_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridcortecaja_formapago_Backstyle = 1 ;
            if ( ((int)(nGXsfl_70_idx) % (2)) == 0 )
            {
               subGridcortecaja_formapago_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridcortecaja_formapagoContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridcortecaja_formapago_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridcortecaja_formapago_Class, "") != 0 )
               {
                  subGridcortecaja_formapago_Linesclass = subGridcortecaja_formapago_Class+"Even" ;
               }
            }
            else
            {
               subGridcortecaja_formapago_Backcolor = (int)(0xFFFFFF) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridcortecaja_formapagoContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridcortecaja_formapago_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridcortecaja_formapago_Class, "") != 0 )
               {
                  subGridcortecaja_formapago_Linesclass = subGridcortecaja_formapago_Class+"Odd" ;
               }
            }
         }
         imgprompt_65_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0)||(StringUtil.StrCmp(Gx_mode, "UPD")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00m1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+"}"+","+"{Ctrl:gx.dom.el('"+"FORMAPAGOCODIGO_"+sGXsfl_70_idx+"'), id:'"+"FORMAPAGOCODIGO_"+sGXsfl_70_idx+"'"+",isOut: true}"+"],"+"gx.dom.form()."+"nIsMod_44_"+sGXsfl_70_idx+","+"'', false"+","+"false"+");") ;
         /* * Property Link not supported in */
         /* * Property Link not supported in */
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_44_" + sGXsfl_70_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_70_idx + "',70)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridcortecaja_formapagoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtFormaPagoCodigo_Internalname,StringUtil.RTrim( A65FormaPagoCodigo),(String)"",TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(71);\"",(String)"",(String)"",(String)"",(String)"",(String)edtFormaPagoCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtFormaPagoCodigo_Enabled,(short)1,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)70,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "Image" ;
         StyleString = "" ;
         Gridcortecaja_formapagoRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_65_Internalname,"prompt.gif",(String)imgprompt_65_Link,(String)"",(String)"",(String)"Fantastic",(int)imgprompt_65_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_44_" + sGXsfl_70_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 72,'',false,'" + sGXsfl_70_idx + "',70)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridcortecaja_formapagoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCorteCajaValor_Internalname,StringUtil.LTrim( StringUtil.NToC( A156CorteCajaValor, 17, 2, ".", "")),((edtCorteCajaValor_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A156CorteCajaValor, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A156CorteCajaValor, "ZZZZZZZZZZZZZ9.99")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(72);\"",(String)"",(String)"",(String)"",(String)"",(String)edtCorteCajaValor_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtCorteCajaValor_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)70,(short)1,(short)-1,(bool)true,(String)"right"});
         context.httpAjaxContext.ajax_sending_grid_row(Gridcortecaja_formapagoRow);
         GXCCtl = "Z65FormaPagoCodigo_" + sGXsfl_70_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z65FormaPagoCodigo));
         GXCCtl = "Z156CorteCajaValor_" + sGXsfl_70_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z156CorteCajaValor, 17, 2, ".", "")));
         GXCCtl = "nRcdDeleted_44_" + sGXsfl_70_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_44), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_44_" + sGXsfl_70_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_44), 4, 0, ".", "")));
         GXCCtl = "nIsMod_44_" + sGXsfl_70_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_44), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "FORMAPAGOCODIGO_"+sGXsfl_70_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFormaPagoCodigo_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CORTECAJAVALOR_"+sGXsfl_70_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCorteCajaValor_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_65_"+sGXsfl_70_idx+"Link", StringUtil.RTrim( imgprompt_65_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridcortecaja_formapagoContainer.AddRow(Gridcortecaja_formapagoRow);
      }

      protected void ReadRow0Y44( )
      {
         nGXsfl_70_idx = (short)(nGXsfl_70_idx+1) ;
         sGXsfl_70_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_70_idx), 4, 0)), 4, "0") ;
         edtFormaPagoCodigo_Internalname = "FORMAPAGOCODIGO_"+sGXsfl_70_idx ;
         imgprompt_65_Internalname = "PROMPT_65_"+sGXsfl_70_idx ;
         edtCorteCajaValor_Internalname = "CORTECAJAVALOR_"+sGXsfl_70_idx ;
         edtFormaPagoCodigo_Enabled = (int)(context.localUtil.CToN( cgiGet( "FORMAPAGOCODIGO_"+sGXsfl_70_idx+"Enabled"), ".", ",")) ;
         edtCorteCajaValor_Enabled = (int)(context.localUtil.CToN( cgiGet( "CORTECAJAVALOR_"+sGXsfl_70_idx+"Enabled"), ".", ",")) ;
         imgprompt_41_132_Link = cgiGet( "PROMPT_65_"+sGXsfl_70_idx+"Link") ;
         A65FormaPagoCodigo = cgiGet( edtFormaPagoCodigo_Internalname) ;
         if ( ( ( context.localUtil.CToN( cgiGet( edtCorteCajaValor_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCorteCajaValor_Internalname), ".", ",") > 99999999999999.99m ) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CORTECAJAVALOR");
            AnyError = 1 ;
            GX_FocusControl = edtCorteCajaValor_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A156CorteCajaValor = 0 ;
         }
         else
         {
            A156CorteCajaValor = context.localUtil.CToN( cgiGet( edtCorteCajaValor_Internalname), ".", ",") ;
         }
         GXCCtl = "Z65FormaPagoCodigo_" + sGXsfl_70_idx ;
         Z65FormaPagoCodigo = cgiGet( GXCCtl) ;
         GXCCtl = "Z156CorteCajaValor_" + sGXsfl_70_idx ;
         Z156CorteCajaValor = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",") ;
         GXCCtl = "nRcdDeleted_44_" + sGXsfl_70_idx ;
         nRcdDeleted_44 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdExists_44_" + sGXsfl_70_idx ;
         nRcdExists_44 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nIsMod_44_" + sGXsfl_70_idx ;
         nIsMod_44 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
      }

      protected void assign_properties_default( )
      {
         defedtFormaPagoCodigo_Enabled = edtFormaPagoCodigo_Enabled ;
      }

      protected void ConfirmValues0Y0( )
      {
         nGXsfl_70_idx = 0 ;
         sGXsfl_70_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_70_idx), 4, 0)), 4, "0") ;
         edtFormaPagoCodigo_Internalname = "FORMAPAGOCODIGO_"+sGXsfl_70_idx ;
         imgprompt_65_Internalname = "PROMPT_65_"+sGXsfl_70_idx ;
         edtCorteCajaValor_Internalname = "CORTECAJAVALOR_"+sGXsfl_70_idx ;
         while ( nGXsfl_70_idx < nRC_Gridcortecaja_formapago )
         {
            nGXsfl_70_idx = (short)(nGXsfl_70_idx+1) ;
            sGXsfl_70_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_70_idx), 4, 0)), 4, "0") ;
            edtFormaPagoCodigo_Internalname = "FORMAPAGOCODIGO_"+sGXsfl_70_idx ;
            imgprompt_65_Internalname = "PROMPT_65_"+sGXsfl_70_idx ;
            edtCorteCajaValor_Internalname = "CORTECAJAVALOR_"+sGXsfl_70_idx ;
            ChangePostValue( "Z65FormaPagoCodigo_"+sGXsfl_70_idx, cgiGet( "ZT_"+"Z65FormaPagoCodigo_"+sGXsfl_70_idx)) ;
            DeletePostValue( "ZT_"+"Z65FormaPagoCodigo_"+sGXsfl_70_idx) ;
            ChangePostValue( "Z156CorteCajaValor_"+sGXsfl_70_idx, cgiGet( "ZT_"+"Z156CorteCajaValor_"+sGXsfl_70_idx)) ;
            DeletePostValue( "ZT_"+"Z156CorteCajaValor_"+sGXsfl_70_idx) ;
         }
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("cortecaja.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z132CajaCodigo", StringUtil.RTrim( Z132CajaCodigo));
         GxWebStd.gx_hidden_field( context, "Z153CorteCajaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z153CorteCajaId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z278CorteCajaFechaD", context.localUtil.TToC( Z278CorteCajaFechaD, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z279CorteCajaFechaA", context.localUtil.TToC( Z279CorteCajaFechaA, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z4UsuarioCodigo", StringUtil.RTrim( Z4UsuarioCodigo));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_Gridcortecaja_formapago", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_70_idx), 4, 0, ".", "")));
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
         return "CorteCaja" ;
      }

      public override String GetPgmdesc( )
      {
         return "Cortes de Caja" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("cortecaja.aspx")  ;
      }

      protected void InitializeNonKey0Y43( )
      {
         A278CorteCajaFechaD = (DateTime)(DateTime.MinValue) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A278CorteCajaFechaD", context.localUtil.TToC( A278CorteCajaFechaD, 8, 5, 0, 3, "/", ":", " "));
         A279CorteCajaFechaA = (DateTime)(DateTime.MinValue) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279CorteCajaFechaA", context.localUtil.TToC( A279CorteCajaFechaA, 8, 5, 0, 3, "/", ":", " "));
         A4UsuarioCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
      }

      protected void InitAll0Y43( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A132CajaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
         A153CorteCajaId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153CorteCajaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A153CorteCajaId), 9, 0)));
         InitializeNonKey0Y43( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0Y44( )
      {
         A156CorteCajaValor = 0 ;
      }

      protected void InitAll0Y44( )
      {
         A65FormaPagoCodigo = "" ;
         InitializeNonKey0Y44( ) ;
      }

      protected void StandaloneModalInsert0Y44( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?75080");
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1555088");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("cortecaja.js", "?1555088");
         /* End function include_jscripts */
      }

      protected void init_level_properties44( )
      {
         edtFormaPagoCodigo_Enabled = defedtFormaPagoCodigo_Enabled ;
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
         lblTextblockcajacodigo_Internalname = "TEXTBLOCKCAJACODIGO" ;
         edtCajaCodigo_Internalname = "CAJACODIGO" ;
         lblTextblockcortecajaid_Internalname = "TEXTBLOCKCORTECAJAID" ;
         edtCorteCajaId_Internalname = "CORTECAJAID" ;
         lblTextblockcortecajafechad_Internalname = "TEXTBLOCKCORTECAJAFECHAD" ;
         edtCorteCajaFechaD_Internalname = "CORTECAJAFECHAD" ;
         lblTextblockcortecajafechaa_Internalname = "TEXTBLOCKCORTECAJAFECHAA" ;
         edtCorteCajaFechaA_Internalname = "CORTECAJAFECHAA" ;
         lblTextblockusuariocodigo_Internalname = "TEXTBLOCKUSUARIOCODIGO" ;
         edtUsuarioCodigo_Internalname = "USUARIOCODIGO" ;
         lblTitleformapago_Internalname = "TITLEFORMAPAGO" ;
         tblTable3_Internalname = "TABLE3" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_132_Internalname = "PROMPT_41_132" ;
         imgprompt_4_Internalname = "PROMPT_4" ;
         subGridcortecaja_formapago_Internalname = "GRIDCORTECAJA_FORMAPAGO" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Cortes de Caja" ;
         edtCorteCajaValor_Jsonclick = "" ;
         imgprompt_65_Visible = 1 ;
         imgprompt_65_Link = "" ;
         imgprompt_41_132_Visible = 1 ;
         edtFormaPagoCodigo_Jsonclick = "" ;
         subGridcortecaja_formapago_Class = "Grid" ;
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
         subGridcortecaja_formapago_Allowcollapsing = 0 ;
         edtCorteCajaValor_Enabled = 1 ;
         edtFormaPagoCodigo_Enabled = 1 ;
         subGridcortecaja_formapago_Backcolorstyle = 2 ;
         imgprompt_4_Visible = 1 ;
         imgprompt_4_Link = "" ;
         edtUsuarioCodigo_Jsonclick = "" ;
         edtUsuarioCodigo_Enabled = 1 ;
         edtCorteCajaFechaA_Jsonclick = "" ;
         edtCorteCajaFechaA_Enabled = 1 ;
         edtCorteCajaFechaD_Jsonclick = "" ;
         edtCorteCajaFechaD_Enabled = 1 ;
         edtCorteCajaId_Jsonclick = "" ;
         edtCorteCajaId_Enabled = 1 ;
         imgprompt_41_132_Visible = 1 ;
         imgprompt_41_132_Link = "" ;
         edtCajaCodigo_Jsonclick = "" ;
         edtCajaCodigo_Enabled = 1 ;
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

      protected void gxnrGridcortecaja_formapago_newrow( short nRC_Gridcortecaja_formapago ,
                                                         short nGXsfl_70_idx ,
                                                         String sGXsfl_70_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         edtFormaPagoCodigo_Internalname = "FORMAPAGOCODIGO_"+sGXsfl_70_idx ;
         imgprompt_65_Internalname = "PROMPT_65_"+sGXsfl_70_idx ;
         edtCorteCajaValor_Internalname = "CORTECAJAVALOR_"+sGXsfl_70_idx ;
         while ( nGXsfl_70_idx <= nRC_Gridcortecaja_formapago )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0Y44( ) ;
            standaloneModal0Y44( ) ;
            dynload_actions( ) ;
            SendRow0Y44( ) ;
            nGXsfl_70_idx = (short)(nGXsfl_70_idx+1) ;
            sGXsfl_70_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_70_idx), 4, 0)), 4, "0") ;
            edtFormaPagoCodigo_Internalname = "FORMAPAGOCODIGO_"+sGXsfl_70_idx ;
            imgprompt_65_Internalname = "PROMPT_65_"+sGXsfl_70_idx ;
            edtCorteCajaValor_Internalname = "CORTECAJAVALOR_"+sGXsfl_70_idx ;
         }
         context.GX_webresponse.AddString(Gridcortecaja_formapagoContainer.ToJavascriptSource());
         /* End function gxnrGridcortecaja_formapago_newrow */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         /* Using cursor T000Y27 */
         pr_default.execute(25, new Object[] {A41ClinicaCodigo, A132CajaCodigo});
         if ( (pr_default.getStatus(25) == 101) )
         {
            AnyError41 = 1 ;
            AnyError132 = 1 ;
            GX_msglist.addItem("No existe 'Cajas'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError132 == 0 ) )
         {
         }
         pr_default.close(25);
         GX_FocusControl = edtCorteCajaFechaD_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Cajacodigo( String GX_Parm1 ,
                                    String GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A132CajaCodigo = GX_Parm2 ;
         /* Using cursor T000Y27 */
         pr_default.execute(25, new Object[] {A41ClinicaCodigo, A132CajaCodigo});
         if ( (pr_default.getStatus(25) == 101) )
         {
            AnyError41 = 1 ;
            AnyError132 = 1 ;
            GX_msglist.addItem("No existe 'Cajas'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError132 == 0 ) )
         {
         }
         pr_default.close(25);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Cortecajaid( String GX_Parm1 ,
                                     String GX_Parm2 ,
                                     int GX_Parm3 ,
                                     DateTime GX_Parm4 ,
                                     DateTime GX_Parm5 ,
                                     String GX_Parm6 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A132CajaCodigo = GX_Parm2 ;
         A153CorteCajaId = GX_Parm3 ;
         A278CorteCajaFechaD = GX_Parm4 ;
         A279CorteCajaFechaA = GX_Parm5 ;
         A4UsuarioCodigo = GX_Parm6 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(context.localUtil.Format(A278CorteCajaFechaD, "99/99/99 99:99")));
         isValidOutput.Add((Object)(context.localUtil.Format(A279CorteCajaFechaA, "99/99/99 99:99")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A4UsuarioCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z132CajaCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z153CorteCajaId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(context.localUtil.TToC( Z278CorteCajaFechaD, 10, 8, 0, 0, "/", ":", " ")));
         isValidOutput.Add((Object)(context.localUtil.TToC( Z279CorteCajaFechaA, 10, 8, 0, 0, "/", ":", " ")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z4UsuarioCodigo)));
         isValidOutput.Add((Object)(Gridcortecaja_formapagoContainer));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Usuariocodigo( String GX_Parm1 )
      {
         A4UsuarioCodigo = GX_Parm1 ;
         /* Using cursor T000Y28 */
         pr_default.execute(26, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(26) == 101) )
         {
            AnyError4 = 1 ;
            GX_msglist.addItem("No existe 'Usuarios'.", "ForeignKeyNotFound", 1, "USUARIOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtUsuarioCodigo_Internalname ;
         }
         if ( AnyError4 == 0 )
         {
         }
         pr_default.close(26);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Formapagocodigo( String GX_Parm1 ,
                                         String GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A65FormaPagoCodigo = GX_Parm2 ;
         /* Using cursor T000Y29 */
         pr_default.execute(27, new Object[] {A41ClinicaCodigo, A65FormaPagoCodigo});
         if ( (pr_default.getStatus(27) == 101) )
         {
            AnyError41 = 1 ;
            AnyError65 = 1 ;
            GX_msglist.addItem("No existe 'Formas de pago'.", "ForeignKeyNotFound", 1, "FORMAPAGOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtFormaPagoCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError65 == 0 ) )
         {
         }
         pr_default.close(27);
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
         pr_default.close(24);
         pr_default.close(27);
         pr_default.close(17);
         pr_default.close(12);
         pr_default.close(11);
         pr_default.close(25);
         pr_default.close(26);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
         A132CajaCodigo = "" ;
         A4UsuarioCodigo = "" ;
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
         lblTextblockcajacodigo_Jsonclick = "" ;
         lblTextblockcortecajaid_Jsonclick = "" ;
         lblTextblockcortecajafechad_Jsonclick = "" ;
         A278CorteCajaFechaD = (DateTime)(DateTime.MinValue) ;
         lblTextblockcortecajafechaa_Jsonclick = "" ;
         A279CorteCajaFechaA = (DateTime)(DateTime.MinValue) ;
         lblTextblockusuariocodigo_Jsonclick = "" ;
         Gridcortecaja_formapagoContainer = new GXWebGrid( context);
         Gridcortecaja_formapagoColumn = new GXWebColumn();
         Gx_mode = "" ;
         sMode44 = "" ;
         edtFormaPagoCodigo_Internalname = "" ;
         lblTitleformapago_Jsonclick = "" ;
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
         Z132CajaCodigo = "" ;
         Z278CorteCajaFechaD = (DateTime)(DateTime.MinValue) ;
         Z279CorteCajaFechaA = (DateTime)(DateTime.MinValue) ;
         Z4UsuarioCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtCorteCajaValor_Internalname = "" ;
         Z65FormaPagoCodigo = "" ;
         T000Y9_A153CorteCajaId = new int[1] ;
         T000Y9_A278CorteCajaFechaD = new DateTime[] {DateTime.MinValue} ;
         T000Y9_A279CorteCajaFechaA = new DateTime[] {DateTime.MinValue} ;
         T000Y9_A41ClinicaCodigo = new String[] {""} ;
         T000Y9_A132CajaCodigo = new String[] {""} ;
         T000Y9_A4UsuarioCodigo = new String[] {""} ;
         T000Y7_A41ClinicaCodigo = new String[] {""} ;
         T000Y8_A4UsuarioCodigo = new String[] {""} ;
         T000Y10_A41ClinicaCodigo = new String[] {""} ;
         T000Y11_A4UsuarioCodigo = new String[] {""} ;
         T000Y12_A41ClinicaCodigo = new String[] {""} ;
         T000Y12_A132CajaCodigo = new String[] {""} ;
         T000Y12_A153CorteCajaId = new int[1] ;
         T000Y6_A153CorteCajaId = new int[1] ;
         T000Y6_A278CorteCajaFechaD = new DateTime[] {DateTime.MinValue} ;
         T000Y6_A279CorteCajaFechaA = new DateTime[] {DateTime.MinValue} ;
         T000Y6_A41ClinicaCodigo = new String[] {""} ;
         T000Y6_A132CajaCodigo = new String[] {""} ;
         T000Y6_A4UsuarioCodigo = new String[] {""} ;
         sMode43 = "" ;
         T000Y13_A41ClinicaCodigo = new String[] {""} ;
         T000Y13_A132CajaCodigo = new String[] {""} ;
         T000Y13_A153CorteCajaId = new int[1] ;
         T000Y14_A41ClinicaCodigo = new String[] {""} ;
         T000Y14_A132CajaCodigo = new String[] {""} ;
         T000Y14_A153CorteCajaId = new int[1] ;
         T000Y15_A153CorteCajaId = new int[1] ;
         T000Y15_A278CorteCajaFechaD = new DateTime[] {DateTime.MinValue} ;
         T000Y15_A279CorteCajaFechaA = new DateTime[] {DateTime.MinValue} ;
         T000Y15_A41ClinicaCodigo = new String[] {""} ;
         T000Y15_A132CajaCodigo = new String[] {""} ;
         T000Y15_A4UsuarioCodigo = new String[] {""} ;
         T000Y19_A41ClinicaCodigo = new String[] {""} ;
         T000Y19_A132CajaCodigo = new String[] {""} ;
         T000Y19_A153CorteCajaId = new int[1] ;
         T000Y20_A132CajaCodigo = new String[] {""} ;
         T000Y20_A153CorteCajaId = new int[1] ;
         T000Y20_A156CorteCajaValor = new decimal[1] ;
         T000Y20_A41ClinicaCodigo = new String[] {""} ;
         T000Y20_A65FormaPagoCodigo = new String[] {""} ;
         T000Y4_A41ClinicaCodigo = new String[] {""} ;
         T000Y21_A41ClinicaCodigo = new String[] {""} ;
         T000Y22_A41ClinicaCodigo = new String[] {""} ;
         T000Y22_A132CajaCodigo = new String[] {""} ;
         T000Y22_A153CorteCajaId = new int[1] ;
         T000Y22_A65FormaPagoCodigo = new String[] {""} ;
         T000Y3_A132CajaCodigo = new String[] {""} ;
         T000Y3_A153CorteCajaId = new int[1] ;
         T000Y3_A156CorteCajaValor = new decimal[1] ;
         T000Y3_A41ClinicaCodigo = new String[] {""} ;
         T000Y3_A65FormaPagoCodigo = new String[] {""} ;
         T000Y2_A132CajaCodigo = new String[] {""} ;
         T000Y2_A153CorteCajaId = new int[1] ;
         T000Y2_A156CorteCajaValor = new decimal[1] ;
         T000Y2_A41ClinicaCodigo = new String[] {""} ;
         T000Y2_A65FormaPagoCodigo = new String[] {""} ;
         T000Y26_A41ClinicaCodigo = new String[] {""} ;
         T000Y26_A132CajaCodigo = new String[] {""} ;
         T000Y26_A153CorteCajaId = new int[1] ;
         T000Y26_A65FormaPagoCodigo = new String[] {""} ;
         imgprompt_65_Internalname = "" ;
         Gridcortecaja_formapagoRow = new GXWebRow();
         subGridcortecaja_formapago_Linesclass = "" ;
         ROClassString = "" ;
         GXCCtl = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         GXt_char7 = "" ;
         T000Y27_A41ClinicaCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         T000Y28_A4UsuarioCodigo = new String[] {""} ;
         T000Y29_A41ClinicaCodigo = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cortecaja__default(),
            new Object[][] {
                new Object[] {
               T000Y2_A132CajaCodigo, T000Y2_A153CorteCajaId, T000Y2_A156CorteCajaValor, T000Y2_A41ClinicaCodigo, T000Y2_A65FormaPagoCodigo
               }
               , new Object[] {
               T000Y3_A132CajaCodigo, T000Y3_A153CorteCajaId, T000Y3_A156CorteCajaValor, T000Y3_A41ClinicaCodigo, T000Y3_A65FormaPagoCodigo
               }
               , new Object[] {
               T000Y4_A41ClinicaCodigo
               }
               , new Object[] {
               T000Y5_A153CorteCajaId, T000Y5_A278CorteCajaFechaD, T000Y5_A279CorteCajaFechaA, T000Y5_A41ClinicaCodigo, T000Y5_A132CajaCodigo, T000Y5_A4UsuarioCodigo
               }
               , new Object[] {
               T000Y6_A153CorteCajaId, T000Y6_A278CorteCajaFechaD, T000Y6_A279CorteCajaFechaA, T000Y6_A41ClinicaCodigo, T000Y6_A132CajaCodigo, T000Y6_A4UsuarioCodigo
               }
               , new Object[] {
               T000Y7_A41ClinicaCodigo
               }
               , new Object[] {
               T000Y8_A4UsuarioCodigo
               }
               , new Object[] {
               T000Y9_A153CorteCajaId, T000Y9_A278CorteCajaFechaD, T000Y9_A279CorteCajaFechaA, T000Y9_A41ClinicaCodigo, T000Y9_A132CajaCodigo, T000Y9_A4UsuarioCodigo
               }
               , new Object[] {
               T000Y10_A41ClinicaCodigo
               }
               , new Object[] {
               T000Y11_A4UsuarioCodigo
               }
               , new Object[] {
               T000Y12_A41ClinicaCodigo, T000Y12_A132CajaCodigo, T000Y12_A153CorteCajaId
               }
               , new Object[] {
               T000Y13_A41ClinicaCodigo, T000Y13_A132CajaCodigo, T000Y13_A153CorteCajaId
               }
               , new Object[] {
               T000Y14_A41ClinicaCodigo, T000Y14_A132CajaCodigo, T000Y14_A153CorteCajaId
               }
               , new Object[] {
               T000Y15_A153CorteCajaId, T000Y15_A278CorteCajaFechaD, T000Y15_A279CorteCajaFechaA, T000Y15_A41ClinicaCodigo, T000Y15_A132CajaCodigo, T000Y15_A4UsuarioCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000Y19_A41ClinicaCodigo, T000Y19_A132CajaCodigo, T000Y19_A153CorteCajaId
               }
               , new Object[] {
               T000Y20_A132CajaCodigo, T000Y20_A153CorteCajaId, T000Y20_A156CorteCajaValor, T000Y20_A41ClinicaCodigo, T000Y20_A65FormaPagoCodigo
               }
               , new Object[] {
               T000Y21_A41ClinicaCodigo
               }
               , new Object[] {
               T000Y22_A41ClinicaCodigo, T000Y22_A132CajaCodigo, T000Y22_A153CorteCajaId, T000Y22_A65FormaPagoCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000Y26_A41ClinicaCodigo, T000Y26_A132CajaCodigo, T000Y26_A153CorteCajaId, T000Y26_A65FormaPagoCodigo
               }
               , new Object[] {
               T000Y27_A41ClinicaCodigo
               }
               , new Object[] {
               T000Y28_A4UsuarioCodigo
               }
               , new Object[] {
               T000Y29_A41ClinicaCodigo
               }
            }
         );
      }

      private short nIsMod_44 ;
      private short GxWebError ;
      private short nRC_Gridcortecaja_formapago ;
      private short nGXsfl_70_idx=1 ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGridcortecaja_formapago_Backcolorstyle ;
      private short subGridcortecaja_formapago_Allowcollapsing ;
      private short subGridcortecaja_formapago_Collapsed ;
      private short nBlankRcdCount44 ;
      private short nRcdExists_44 ;
      private short RcdFound44 ;
      private short nBlankRcdUsr44 ;
      private short nRcdDeleted_44 ;
      private short GX_JID ;
      private short RcdFound43 ;
      private short Gx_BScreen ;
      private short subGridcortecaja_formapago_Backstyle ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int edtCajaCodigo_Enabled ;
      private int imgprompt_41_132_Visible ;
      private int A153CorteCajaId ;
      private int edtCorteCajaId_Enabled ;
      private int edtCorteCajaFechaD_Enabled ;
      private int edtCorteCajaFechaA_Enabled ;
      private int edtUsuarioCodigo_Enabled ;
      private int imgprompt_4_Visible ;
      private int edtFormaPagoCodigo_Enabled ;
      private int edtCorteCajaValor_Enabled ;
      private int fRowAdded ;
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
      private int Z153CorteCajaId ;
      private int GRIDCORTECAJA_FORMAPAGO_nFirstRecordOnPage ;
      private int AnyError41 ;
      private int AnyError132 ;
      private int AnyError4 ;
      private int AnyError65 ;
      private int subGridcortecaja_formapago_Backcolor ;
      private int subGridcortecaja_formapago_Allbackcolor ;
      private int imgprompt_65_Visible ;
      private int defedtFormaPagoCodigo_Enabled ;
      private int idxLst ;
      private decimal A156CorteCajaValor ;
      private decimal Z156CorteCajaValor ;
      private String sPrefix ;
      private String sGXsfl_70_idx="0001" ;
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
      private String lblTextblockcajacodigo_Internalname ;
      private String lblTextblockcajacodigo_Jsonclick ;
      private String edtCajaCodigo_Internalname ;
      private String edtCajaCodigo_Jsonclick ;
      private String imgprompt_41_132_Internalname ;
      private String imgprompt_41_132_Link ;
      private String lblTextblockcortecajaid_Internalname ;
      private String lblTextblockcortecajaid_Jsonclick ;
      private String edtCorteCajaId_Internalname ;
      private String edtCorteCajaId_Jsonclick ;
      private String lblTextblockcortecajafechad_Internalname ;
      private String lblTextblockcortecajafechad_Jsonclick ;
      private String edtCorteCajaFechaD_Internalname ;
      private String edtCorteCajaFechaD_Jsonclick ;
      private String lblTextblockcortecajafechaa_Internalname ;
      private String lblTextblockcortecajafechaa_Jsonclick ;
      private String edtCorteCajaFechaA_Internalname ;
      private String edtCorteCajaFechaA_Jsonclick ;
      private String lblTextblockusuariocodigo_Internalname ;
      private String lblTextblockusuariocodigo_Jsonclick ;
      private String edtUsuarioCodigo_Internalname ;
      private String edtUsuarioCodigo_Jsonclick ;
      private String imgprompt_4_Internalname ;
      private String imgprompt_4_Link ;
      private String Gx_mode ;
      private String sMode44 ;
      private String edtFormaPagoCodigo_Internalname ;
      private String tblTable3_Internalname ;
      private String lblTitleformapago_Internalname ;
      private String lblTitleformapago_Jsonclick ;
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
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtCorteCajaValor_Internalname ;
      private String sMode43 ;
      private String imgprompt_65_Internalname ;
      private String subGridcortecaja_formapago_Class ;
      private String subGridcortecaja_formapago_Linesclass ;
      private String imgprompt_65_Link ;
      private String ROClassString ;
      private String edtFormaPagoCodigo_Jsonclick ;
      private String edtCorteCajaValor_Jsonclick ;
      private String GXCCtl ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String subGridcortecaja_formapago_Internalname ;
      private String GXt_char7 ;
      private DateTime A278CorteCajaFechaD ;
      private DateTime A279CorteCajaFechaA ;
      private DateTime Z278CorteCajaFechaD ;
      private DateTime Z279CorteCajaFechaA ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A41ClinicaCodigo ;
      private String A132CajaCodigo ;
      private String A4UsuarioCodigo ;
      private String A65FormaPagoCodigo ;
      private String Z41ClinicaCodigo ;
      private String Z132CajaCodigo ;
      private String Z4UsuarioCodigo ;
      private String Z65FormaPagoCodigo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Gridcortecaja_formapagoContainer ;
      private GXWebRow Gridcortecaja_formapagoRow ;
      private GXWebColumn Gridcortecaja_formapagoColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T000Y9_A153CorteCajaId ;
      private DateTime[] T000Y9_A278CorteCajaFechaD ;
      private DateTime[] T000Y9_A279CorteCajaFechaA ;
      private String[] T000Y9_A41ClinicaCodigo ;
      private String[] T000Y9_A132CajaCodigo ;
      private String[] T000Y9_A4UsuarioCodigo ;
      private String[] T000Y7_A41ClinicaCodigo ;
      private String[] T000Y8_A4UsuarioCodigo ;
      private String[] T000Y10_A41ClinicaCodigo ;
      private String[] T000Y11_A4UsuarioCodigo ;
      private String[] T000Y12_A41ClinicaCodigo ;
      private String[] T000Y12_A132CajaCodigo ;
      private int[] T000Y12_A153CorteCajaId ;
      private int[] T000Y6_A153CorteCajaId ;
      private DateTime[] T000Y6_A278CorteCajaFechaD ;
      private DateTime[] T000Y6_A279CorteCajaFechaA ;
      private String[] T000Y6_A41ClinicaCodigo ;
      private String[] T000Y6_A132CajaCodigo ;
      private String[] T000Y6_A4UsuarioCodigo ;
      private String[] T000Y13_A41ClinicaCodigo ;
      private String[] T000Y13_A132CajaCodigo ;
      private int[] T000Y13_A153CorteCajaId ;
      private String[] T000Y14_A41ClinicaCodigo ;
      private String[] T000Y14_A132CajaCodigo ;
      private int[] T000Y14_A153CorteCajaId ;
      private int[] T000Y15_A153CorteCajaId ;
      private DateTime[] T000Y15_A278CorteCajaFechaD ;
      private DateTime[] T000Y15_A279CorteCajaFechaA ;
      private String[] T000Y15_A41ClinicaCodigo ;
      private String[] T000Y15_A132CajaCodigo ;
      private String[] T000Y15_A4UsuarioCodigo ;
      private String[] T000Y19_A41ClinicaCodigo ;
      private String[] T000Y19_A132CajaCodigo ;
      private int[] T000Y19_A153CorteCajaId ;
      private String[] T000Y20_A132CajaCodigo ;
      private int[] T000Y20_A153CorteCajaId ;
      private decimal[] T000Y20_A156CorteCajaValor ;
      private String[] T000Y20_A41ClinicaCodigo ;
      private String[] T000Y20_A65FormaPagoCodigo ;
      private String[] T000Y4_A41ClinicaCodigo ;
      private String[] T000Y21_A41ClinicaCodigo ;
      private String[] T000Y22_A41ClinicaCodigo ;
      private String[] T000Y22_A132CajaCodigo ;
      private int[] T000Y22_A153CorteCajaId ;
      private String[] T000Y22_A65FormaPagoCodigo ;
      private String[] T000Y3_A132CajaCodigo ;
      private int[] T000Y3_A153CorteCajaId ;
      private decimal[] T000Y3_A156CorteCajaValor ;
      private String[] T000Y3_A41ClinicaCodigo ;
      private String[] T000Y3_A65FormaPagoCodigo ;
      private String[] T000Y2_A132CajaCodigo ;
      private int[] T000Y2_A153CorteCajaId ;
      private decimal[] T000Y2_A156CorteCajaValor ;
      private String[] T000Y2_A41ClinicaCodigo ;
      private String[] T000Y2_A65FormaPagoCodigo ;
      private String[] T000Y26_A41ClinicaCodigo ;
      private String[] T000Y26_A132CajaCodigo ;
      private int[] T000Y26_A153CorteCajaId ;
      private String[] T000Y26_A65FormaPagoCodigo ;
      private String[] T000Y27_A41ClinicaCodigo ;
      private String[] T000Y28_A4UsuarioCodigo ;
      private String[] T000Y29_A41ClinicaCodigo ;
      private int[] T000Y5_A153CorteCajaId ;
      private DateTime[] T000Y5_A278CorteCajaFechaD ;
      private DateTime[] T000Y5_A279CorteCajaFechaA ;
      private String[] T000Y5_A41ClinicaCodigo ;
      private String[] T000Y5_A132CajaCodigo ;
      private String[] T000Y5_A4UsuarioCodigo ;
      private GXWebForm Form ;
   }

   public class cortecaja__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new UpdateCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new UpdateCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new UpdateCursor(def[21])
         ,new UpdateCursor(def[22])
         ,new UpdateCursor(def[23])
         ,new ForEachCursor(def[24])
         ,new ForEachCursor(def[25])
         ,new ForEachCursor(def[26])
         ,new ForEachCursor(def[27])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000Y5 ;
          prmT000Y5 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Y9 ;
          prmT000Y9 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Y7 ;
          prmT000Y7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Y8 ;
          prmT000Y8 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Y10 ;
          prmT000Y10 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Y11 ;
          prmT000Y11 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Y12 ;
          prmT000Y12 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Y6 ;
          prmT000Y6 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Y13 ;
          prmT000Y13 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Y14 ;
          prmT000Y14 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Y15 ;
          prmT000Y15 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Y16 ;
          prmT000Y16 = new Object[] {
          new Object[] {"@CorteCajaId",SqlDbType.Int,9,0} ,
          new Object[] {"@CorteCajaFechaD",SqlDbType.DateTime,8,5} ,
          new Object[] {"@CorteCajaFechaA",SqlDbType.DateTime,8,5} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Y17 ;
          prmT000Y17 = new Object[] {
          new Object[] {"@CorteCajaFechaD",SqlDbType.DateTime,8,5} ,
          new Object[] {"@CorteCajaFechaA",SqlDbType.DateTime,8,5} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Y18 ;
          prmT000Y18 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Y19 ;
          prmT000Y19 = new Object[] {
          } ;
          Object[] prmT000Y20 ;
          prmT000Y20 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FormaPagoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Y4 ;
          prmT000Y4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FormaPagoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Y21 ;
          prmT000Y21 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FormaPagoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Y22 ;
          prmT000Y22 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FormaPagoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Y3 ;
          prmT000Y3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FormaPagoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Y2 ;
          prmT000Y2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FormaPagoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Y23 ;
          prmT000Y23 = new Object[] {
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaId",SqlDbType.Int,9,0} ,
          new Object[] {"@CorteCajaValor",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FormaPagoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Y24 ;
          prmT000Y24 = new Object[] {
          new Object[] {"@CorteCajaValor",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FormaPagoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Y25 ;
          prmT000Y25 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FormaPagoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Y26 ;
          prmT000Y26 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Y27 ;
          prmT000Y27 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Y28 ;
          prmT000Y28 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Y29 ;
          prmT000Y29 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FormaPagoCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000Y2", "SELECT [CajaCodigo], [CorteCajaId], [CorteCajaValor], [ClinicaCodigo], [FormaPagoCodigo] FROM [CorteCajaDet] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo AND [CorteCajaId] = @CorteCajaId AND [FormaPagoCodigo] = @FormaPagoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y2,1,0,true,false )
             ,new CursorDef("T000Y3", "SELECT [CajaCodigo], [CorteCajaId], [CorteCajaValor], [ClinicaCodigo], [FormaPagoCodigo] FROM [CorteCajaDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo AND [CorteCajaId] = @CorteCajaId AND [FormaPagoCodigo] = @FormaPagoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y3,1,0,true,false )
             ,new CursorDef("T000Y4", "SELECT [ClinicaCodigo] FROM [FormaPago] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FormaPagoCodigo] = @FormaPagoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y4,1,0,true,false )
             ,new CursorDef("T000Y5", "SELECT [CorteCajaId], [CorteCajaFechaD], [CorteCajaFechaA], [ClinicaCodigo], [CajaCodigo], [UsuarioCodigo] FROM [CorteCaja] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo AND [CorteCajaId] = @CorteCajaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y5,1,0,true,false )
             ,new CursorDef("T000Y6", "SELECT [CorteCajaId], [CorteCajaFechaD], [CorteCajaFechaA], [ClinicaCodigo], [CajaCodigo], [UsuarioCodigo] FROM [CorteCaja] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo AND [CorteCajaId] = @CorteCajaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y6,1,0,true,false )
             ,new CursorDef("T000Y7", "SELECT [ClinicaCodigo] FROM [Caja] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y7,1,0,true,false )
             ,new CursorDef("T000Y8", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y8,1,0,true,false )
             ,new CursorDef("T000Y9", "SELECT TM1.[CorteCajaId], TM1.[CorteCajaFechaD], TM1.[CorteCajaFechaA], TM1.[ClinicaCodigo], TM1.[CajaCodigo], TM1.[UsuarioCodigo] FROM [CorteCaja] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[CajaCodigo] = @CajaCodigo and TM1.[CorteCajaId] = @CorteCajaId ORDER BY TM1.[ClinicaCodigo], TM1.[CajaCodigo], TM1.[CorteCajaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y9,100,0,true,false )
             ,new CursorDef("T000Y10", "SELECT [ClinicaCodigo] FROM [Caja] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y10,1,0,true,false )
             ,new CursorDef("T000Y11", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y11,1,0,true,false )
             ,new CursorDef("T000Y12", "SELECT [ClinicaCodigo], [CajaCodigo], [CorteCajaId] FROM [CorteCaja] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo AND [CorteCajaId] = @CorteCajaId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y12,1,0,true,false )
             ,new CursorDef("T000Y13", "SELECT TOP 1 [ClinicaCodigo], [CajaCodigo], [CorteCajaId] FROM [CorteCaja] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [CajaCodigo] > @CajaCodigo or [CajaCodigo] = @CajaCodigo and [ClinicaCodigo] = @ClinicaCodigo and [CorteCajaId] > @CorteCajaId) ORDER BY [ClinicaCodigo], [CajaCodigo], [CorteCajaId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y13,1,0,true,true )
             ,new CursorDef("T000Y14", "SELECT TOP 1 [ClinicaCodigo], [CajaCodigo], [CorteCajaId] FROM [CorteCaja] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [CajaCodigo] < @CajaCodigo or [CajaCodigo] = @CajaCodigo and [ClinicaCodigo] = @ClinicaCodigo and [CorteCajaId] < @CorteCajaId) ORDER BY [ClinicaCodigo] DESC, [CajaCodigo] DESC, [CorteCajaId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y14,1,0,true,true )
             ,new CursorDef("T000Y15", "SELECT [CorteCajaId], [CorteCajaFechaD], [CorteCajaFechaA], [ClinicaCodigo], [CajaCodigo], [UsuarioCodigo] FROM [CorteCaja] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo AND [CorteCajaId] = @CorteCajaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y15,1,0,true,false )
             ,new CursorDef("T000Y16", "INSERT INTO [CorteCaja] ([CorteCajaId], [CorteCajaFechaD], [CorteCajaFechaA], [ClinicaCodigo], [CajaCodigo], [UsuarioCodigo]) VALUES (@CorteCajaId, @CorteCajaFechaD, @CorteCajaFechaA, @ClinicaCodigo, @CajaCodigo, @UsuarioCodigo)", GxErrorMask.GX_NOMASK,prmT000Y16)
             ,new CursorDef("T000Y17", "UPDATE [CorteCaja] SET [CorteCajaFechaD]=@CorteCajaFechaD, [CorteCajaFechaA]=@CorteCajaFechaA, [UsuarioCodigo]=@UsuarioCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo AND [CorteCajaId] = @CorteCajaId", GxErrorMask.GX_NOMASK,prmT000Y17)
             ,new CursorDef("T000Y18", "DELETE FROM [CorteCaja]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo AND [CorteCajaId] = @CorteCajaId", GxErrorMask.GX_NOMASK,prmT000Y18)
             ,new CursorDef("T000Y19", "SELECT [ClinicaCodigo], [CajaCodigo], [CorteCajaId] FROM [CorteCaja] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [CajaCodigo], [CorteCajaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y19,100,0,true,false )
             ,new CursorDef("T000Y20", "SELECT [CajaCodigo], [CorteCajaId], [CorteCajaValor], [ClinicaCodigo], [FormaPagoCodigo] FROM [CorteCajaDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [CajaCodigo] = @CajaCodigo and [CorteCajaId] = @CorteCajaId and [FormaPagoCodigo] = @FormaPagoCodigo ORDER BY [ClinicaCodigo], [CajaCodigo], [CorteCajaId], [FormaPagoCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y20,11,0,true,false )
             ,new CursorDef("T000Y21", "SELECT [ClinicaCodigo] FROM [FormaPago] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FormaPagoCodigo] = @FormaPagoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y21,1,0,true,false )
             ,new CursorDef("T000Y22", "SELECT [ClinicaCodigo], [CajaCodigo], [CorteCajaId], [FormaPagoCodigo] FROM [CorteCajaDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo AND [CorteCajaId] = @CorteCajaId AND [FormaPagoCodigo] = @FormaPagoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y22,1,0,true,false )
             ,new CursorDef("T000Y23", "INSERT INTO [CorteCajaDet] ([CajaCodigo], [CorteCajaId], [CorteCajaValor], [ClinicaCodigo], [FormaPagoCodigo]) VALUES (@CajaCodigo, @CorteCajaId, @CorteCajaValor, @ClinicaCodigo, @FormaPagoCodigo)", GxErrorMask.GX_NOMASK,prmT000Y23)
             ,new CursorDef("T000Y24", "UPDATE [CorteCajaDet] SET [CorteCajaValor]=@CorteCajaValor  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo AND [CorteCajaId] = @CorteCajaId AND [FormaPagoCodigo] = @FormaPagoCodigo", GxErrorMask.GX_NOMASK,prmT000Y24)
             ,new CursorDef("T000Y25", "DELETE FROM [CorteCajaDet]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo AND [CorteCajaId] = @CorteCajaId AND [FormaPagoCodigo] = @FormaPagoCodigo", GxErrorMask.GX_NOMASK,prmT000Y25)
             ,new CursorDef("T000Y26", "SELECT [ClinicaCodigo], [CajaCodigo], [CorteCajaId], [FormaPagoCodigo] FROM [CorteCajaDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [CajaCodigo] = @CajaCodigo and [CorteCajaId] = @CorteCajaId ORDER BY [ClinicaCodigo], [CajaCodigo], [CorteCajaId], [FormaPagoCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y26,11,0,true,false )
             ,new CursorDef("T000Y27", "SELECT [ClinicaCodigo] FROM [Caja] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y27,1,0,true,false )
             ,new CursorDef("T000Y28", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y28,1,0,true,false )
             ,new CursorDef("T000Y29", "SELECT [ClinicaCodigo] FROM [FormaPago] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FormaPagoCodigo] = @FormaPagoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y29,1,0,true,false )
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 13 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                break;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                break;
             case 24 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                break;
             case 25 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 26 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 27 :
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
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
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 14 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
             case 15 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                break;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 18 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 19 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 20 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 21 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                break;
             case 22 :
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                break;
             case 23 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 24 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 25 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 26 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 27 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
