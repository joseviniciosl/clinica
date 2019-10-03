/*
               File: Caja
        Description: Cajas
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:5:31.58
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
   public class caja : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_5") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A252ResolucionCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A252ResolucionCodigo", A252ResolucionCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_5( A41ClinicaCodigo, A252ResolucionCodigo) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridcaja_cajacorrelativo") == 0 )
         {
            nRC_Gridcaja_cajacorrelativo = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            nGXsfl_70_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_70_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGridcaja_cajacorrelativo_newrow( nRC_Gridcaja_cajacorrelativo, nGXsfl_70_idx, sGXsfl_70_idx) ;
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
         cmbCajaEstado.Name = "CAJAESTADO" ;
         cmbCajaEstado.WebTags = "" ;
         cmbCajaEstado.addItem("0", "De baja", 0);
         cmbCajaEstado.addItem("1", "Activo", 0);
         if ( ( cmbCajaEstado.ItemCount > 0 ) && (0==A134CajaEstado) )
         {
            A134CajaEstado = (short)(NumberUtil.Val( cmbCajaEstado.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A134CajaEstado", StringUtil.Str( (decimal)(A134CajaEstado), 1, 0));
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Cajas", 0) ;
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

      public caja( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public caja( IGxContext context )
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
         cmbCajaEstado = new GXCombobox();
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
            wb_table1_2_0S36( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0S36e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0S36( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0S36( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0S36e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Cajas"+"</legend>") ;
            wb_table3_27_0S36( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0S36e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0S36e( true) ;
         }
         else
         {
            wb_table1_2_0S36e( false) ;
         }
      }

      protected void wb_table3_27_0S36( bool wbgen )
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
            wb_table4_33_0S36( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0S36e( bool wbgen )
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Caja.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Caja.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Caja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0S36e( true) ;
         }
         else
         {
            wb_table3_27_0S36e( false) ;
         }
      }

      protected void wb_table4_33_0S36( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", lblTextblockclinicacodigo_Visible, 1, 0, "HLP_Caja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", edtClinicaCodigo_Visible, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Caja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcajacodigo_Internalname, "Caja", "", "", lblTextblockcajacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Caja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCajaCodigo_Internalname, StringUtil.RTrim( A132CajaCodigo), StringUtil.RTrim( context.localUtil.Format( A132CajaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtCajaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtCajaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Caja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcajadescripcion_Internalname, "Descripción", "", "", lblTextblockcajadescripcion_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Caja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A133CajaDescripcion", A133CajaDescripcion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCajaDescripcion_Internalname, StringUtil.RTrim( A133CajaDescripcion), StringUtil.RTrim( context.localUtil.Format( A133CajaDescripcion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", "", "", "", edtCajaDescripcion_Jsonclick, 0, ClassString, StyleString, "", 1, edtCajaDescripcion_Enabled, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_Caja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockresolucioncodigo_Internalname, "Resolución", "", "", lblTextblockresolucioncodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Caja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A252ResolucionCodigo", A252ResolucionCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtResolucionCodigo_Internalname, StringUtil.RTrim( A252ResolucionCodigo), StringUtil.RTrim( context.localUtil.Format( A252ResolucionCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "", "", "", "", edtResolucionCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtResolucionCodigo_Enabled, 0, 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, true, "left", "HLP_Caja.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_252_Internalname, "prompt.gif", imgprompt_41_252_Link, "", "", "Fantastic", imgprompt_41_252_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Caja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcajerocodigo_Internalname, "Cajero", "", "", lblTextblockcajerocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Caja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259CajeroCodigo", A259CajeroCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCajeroCodigo_Internalname, StringUtil.RTrim( A259CajeroCodigo), StringUtil.RTrim( context.localUtil.Format( A259CajeroCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", "", "", "", "", edtCajeroCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtCajeroCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Caja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcajaestado_Internalname, "Estado", "", "", lblTextblockcajaestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Caja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A134CajaEstado", StringUtil.Str( (decimal)(A134CajaEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbCajaEstado, cmbCajaEstado_Internalname, StringUtil.Str( (decimal)(A134CajaEstado), 1, 0), 1, cmbCajaEstado_Jsonclick, 0, "", "int", "", 1, cmbCajaEstado.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", "", true, "HLP_Caja.htm");
            cmbCajaEstado.CurrentValue = StringUtil.Str( (decimal)(A134CajaEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCajaEstado_Internalname, "Values", (String)(cmbCajaEstado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "<br>") ;
            wb_table5_66_0S36( true) ;
         }
         return  ;
      }

      protected void wb_table5_66_0S36e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<hr class=\"HRDefault\">") ;
            /*  Grid Control  */
            Gridcaja_cajacorrelativoContainer.AddObjectProperty("GridName", "Gridcaja_cajacorrelativo");
            Gridcaja_cajacorrelativoContainer.AddObjectProperty("Class", "Grid");
            Gridcaja_cajacorrelativoContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Gridcaja_cajacorrelativoContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Gridcaja_cajacorrelativoContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcaja_cajacorrelativo_Backcolorstyle), 1, 0, ".", "")));
            Gridcaja_cajacorrelativoContainer.AddObjectProperty("CmpContext", "");
            Gridcaja_cajacorrelativoContainer.AddObjectProperty("InMasterPage", "false");
            Gridcaja_cajacorrelativoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcaja_cajacorrelativoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A135CajaAnio), 4, 0, ".", "")));
            Gridcaja_cajacorrelativoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCajaAnio_Enabled), 5, 0, ".", "")));
            Gridcaja_cajacorrelativoContainer.AddColumnProperties(Gridcaja_cajacorrelativoColumn);
            Gridcaja_cajacorrelativoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcaja_cajacorrelativoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A136CajaSiguiente), 9, 0, ".", "")));
            Gridcaja_cajacorrelativoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCajaSiguiente_Enabled), 5, 0, ".", "")));
            Gridcaja_cajacorrelativoContainer.AddColumnProperties(Gridcaja_cajacorrelativoColumn);
            Gridcaja_cajacorrelativoContainer.AddObjectProperty("Allowselection", "false");
            Gridcaja_cajacorrelativoContainer.AddObjectProperty("Allowcollapsing", ((subGridcaja_cajacorrelativo_Allowcollapsing==1) ? "true" : "false"));
            Gridcaja_cajacorrelativoContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcaja_cajacorrelativo_Collapsed), 9, 0, ".", "")));
            nGXsfl_70_idx = 0 ;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount37 = 5 ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_37 = 1 ;
                  ScanStart0S37( ) ;
                  while ( RcdFound37 != 0 )
                  {
                     init_level_properties37( ) ;
                     getByPrimaryKey0S37( ) ;
                     AddRow0S37( ) ;
                     ScanNext0S37( ) ;
                  }
                  ScanEnd0S37( ) ;
                  nBlankRcdCount37 = 5 ;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               standaloneNotModal0S37( ) ;
               standaloneModal0S37( ) ;
               sMode37 = Gx_mode ;
               while ( nGXsfl_70_idx < nRC_Gridcaja_cajacorrelativo )
               {
                  ReadRow0S37( ) ;
                  edtCajaAnio_Enabled = (int)(context.localUtil.CToN( cgiGet( "CAJAANIO_"+sGXsfl_70_idx+"Enabled"), ".", ",")) ;
                  edtCajaSiguiente_Enabled = (int)(context.localUtil.CToN( cgiGet( "CAJASIGUIENTE_"+sGXsfl_70_idx+"Enabled"), ".", ",")) ;
                  if ( ( nRcdExists_37 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal0S37( ) ;
                  }
                  SendRow0S37( ) ;
               }
               Gx_mode = sMode37 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount37 = 5 ;
               nRcdExists_37 = 1 ;
               ScanStart0S37( ) ;
               while ( RcdFound37 != 0 )
               {
                  init_level_properties37( ) ;
                  getByPrimaryKey0S37( ) ;
                  standaloneNotModal0S37( ) ;
                  standaloneModal0S37( ) ;
                  AddRow0S37( ) ;
                  ScanNext0S37( ) ;
               }
               ScanEnd0S37( ) ;
            }
            /* Initialize fields for 'new' records and send them. */
            sMode37 = Gx_mode ;
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            InitAll0S37( ) ;
            init_level_properties37( ) ;
            standaloneNotModal0S37( ) ;
            standaloneModal0S37( ) ;
            nRcdExists_37 = 0 ;
            nIsMod_37 = 0 ;
            nBlankRcdCount37 = (short)(nBlankRcdUsr37+nBlankRcdCount37) ;
            fRowAdded = 0 ;
            while ( nBlankRcdCount37 > 0 )
            {
               AddRow0S37( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1 ;
                  GX_FocusControl = edtCajaAnio_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount37 = (short)(nBlankRcdCount37-1) ;
            }
            Gx_mode = sMode37 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            sStyleString = " style=\"display:none;\"" ;
            sStyleString = "" ;
            context.WriteHtmlText( "<div id=\""+"Gridcaja_cajacorrelativoContainer"+"Div\" "+sStyleString+">"+"</div>") ;
            context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridcaja_cajacorrelativo", (Object)(Gridcaja_cajacorrelativoContainer));
            GxWebStd.gx_hidden_field( context, "Gridcaja_cajacorrelativoContainerData", Gridcaja_cajacorrelativoContainer.ToJavascriptSource());
            if ( context.isAjaxRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Gridcaja_cajacorrelativoContainerData"+"V", Gridcaja_cajacorrelativoContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridcaja_cajacorrelativoContainerData"+"V"+"\" value='"+Gridcaja_cajacorrelativoContainer.GridValuesHidden()+"'>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0S36e( true) ;
         }
         else
         {
            wb_table4_33_0S36e( false) ;
         }
      }

      protected void wb_table5_66_0S36( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTitlecajacorrelativo_Internalname, "Correlativos de cortes de caja", "", "", lblTitlecajacorrelativo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Caja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_66_0S36e( true) ;
         }
         else
         {
            wb_table5_66_0S36e( false) ;
         }
      }

      protected void wb_table2_5_0S36( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Caja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Caja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Caja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Caja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Caja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Caja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Caja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Caja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0100.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CAJACODIGO"+"'), id:'"+"CAJACODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Caja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0100.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CAJACODIGO"+"'), id:'"+"CAJACODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Caja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Caja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Caja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Caja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Caja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Caja.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Caja.htm");
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
            wb_table2_5_0S36e( true) ;
         }
         else
         {
            wb_table2_5_0S36e( false) ;
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
         /* Execute user event: E110S2 */
         E110S2 ();
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
               A133CajaDescripcion = cgiGet( edtCajaDescripcion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A133CajaDescripcion", A133CajaDescripcion);
               A252ResolucionCodigo = cgiGet( edtResolucionCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A252ResolucionCodigo", A252ResolucionCodigo);
               A259CajeroCodigo = cgiGet( edtCajeroCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259CajeroCodigo", A259CajeroCodigo);
               cmbCajaEstado.Name = cmbCajaEstado_Internalname ;
               cmbCajaEstado.CurrentValue = cgiGet( cmbCajaEstado_Internalname) ;
               A134CajaEstado = (short)(NumberUtil.Val( cgiGet( cmbCajaEstado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A134CajaEstado", StringUtil.Str( (decimal)(A134CajaEstado), 1, 0));
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z132CajaCodigo = cgiGet( "Z132CajaCodigo") ;
               Z133CajaDescripcion = cgiGet( "Z133CajaDescripcion") ;
               Z259CajeroCodigo = cgiGet( "Z259CajeroCodigo") ;
               Z134CajaEstado = (short)(context.localUtil.CToN( cgiGet( "Z134CajaEstado"), ".", ",")) ;
               Z252ResolucionCodigo = cgiGet( "Z252ResolucionCodigo") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               nRC_Gridcaja_cajacorrelativo = (short)(context.localUtil.CToN( cgiGet( "nRC_Gridcaja_cajacorrelativo"), ".", ",")) ;
               AV8ClinicaCodigo = cgiGet( "vCLINICACODIGO") ;
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
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E110S2 */
                           E110S2 ();
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
               InitAll0S36( ) ;
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
         DisableAttributes0S36( ) ;
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

      protected void CONFIRM_0S37( )
      {
         nGXsfl_70_idx = 0 ;
         while ( nGXsfl_70_idx < nRC_Gridcaja_cajacorrelativo )
         {
            ReadRow0S37( ) ;
            if ( ( nRcdExists_37 != 0 ) || ( nIsMod_37 != 0 ) )
            {
               GetKey0S37( ) ;
               if ( ( nRcdExists_37 == 0 ) && ( nRcdDeleted_37 == 0 ) )
               {
                  if ( RcdFound37 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate0S37( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0S37( ) ;
                        CloseExtendedTableCursors0S37( ) ;
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
                     GX_FocusControl = edtCajaAnio_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound37 != 0 )
                  {
                     if ( nRcdDeleted_37 != 0 )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey0S37( ) ;
                        Load0S37( ) ;
                        BeforeValidate0S37( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0S37( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_37 != 0 )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate0S37( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0S37( ) ;
                              CloseExtendedTableCursors0S37( ) ;
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
                     if ( nRcdDeleted_37 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtCajaAnio_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtCajaAnio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A135CajaAnio), 4, 0, ".", ""))) ;
            ChangePostValue( edtCajaSiguiente_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A136CajaSiguiente), 9, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z135CajaAnio_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z135CajaAnio), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z136CajaSiguiente_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z136CajaSiguiente), 9, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_37_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_37), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_37_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_37), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_37_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_37), 4, 0, ".", ""))) ;
            if ( nIsMod_37 != 0 )
            {
               ChangePostValue( "CAJAANIO_"+sGXsfl_70_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCajaAnio_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CAJASIGUIENTE_"+sGXsfl_70_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCajaSiguiente_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption0S0( )
      {
      }

      protected void E110S2( )
      {
         /* Start Routine */
         GXt_SdtParametros6 = AV7Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros6) ;
         AV7Parametros = GXt_SdtParametros6 ;
         AV8ClinicaCodigo = AV7Parametros.gxTpr_Pclinicacodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClinicaCodigo", AV8ClinicaCodigo);
      }

      protected void ZM0S36( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z133CajaDescripcion = T000S5_A133CajaDescripcion[0] ;
               Z259CajeroCodigo = T000S5_A259CajeroCodigo[0] ;
               Z134CajaEstado = T000S5_A134CajaEstado[0] ;
               Z252ResolucionCodigo = T000S5_A252ResolucionCodigo[0] ;
            }
            else
            {
               Z133CajaDescripcion = A133CajaDescripcion ;
               Z259CajeroCodigo = A259CajeroCodigo ;
               Z134CajaEstado = A134CajaEstado ;
               Z252ResolucionCodigo = A252ResolucionCodigo ;
            }
         }
         if ( GX_JID == -4 )
         {
            Z132CajaCodigo = A132CajaCodigo ;
            Z133CajaDescripcion = A133CajaDescripcion ;
            Z259CajeroCodigo = A259CajeroCodigo ;
            Z134CajaEstado = A134CajaEstado ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z252ResolucionCodigo = A252ResolucionCodigo ;
         }
      }

      protected void standaloneNotModal( )
      {
         lblTextblockclinicacodigo_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTextblockclinicacodigo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblTextblockclinicacodigo_Visible), 5, 0)));
         edtClinicaCodigo_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Visible), 5, 0)));
         imgprompt_41_252_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx01p0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"RESOLUCIONCODIGO"+"'), id:'"+"RESOLUCIONCODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
         A41ClinicaCodigo = AV8ClinicaCodigo ;
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
      }

      protected void Load0S36( )
      {
         /* Using cursor T000S7 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A132CajaCodigo});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound36 = 1 ;
            A133CajaDescripcion = T000S7_A133CajaDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A133CajaDescripcion", A133CajaDescripcion);
            A259CajeroCodigo = T000S7_A259CajeroCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259CajeroCodigo", A259CajeroCodigo);
            A134CajaEstado = T000S7_A134CajaEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A134CajaEstado", StringUtil.Str( (decimal)(A134CajaEstado), 1, 0));
            A252ResolucionCodigo = T000S7_A252ResolucionCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A252ResolucionCodigo", A252ResolucionCodigo);
            ZM0S36( -4) ;
         }
         pr_default.close(5);
         OnLoadActions0S36( ) ;
      }

      protected void OnLoadActions0S36( )
      {
      }

      protected void CheckExtendedTable0S36( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T000S6 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo, A252ResolucionCodigo});
         if ( (pr_default.getStatus(4) == 101) )
         {
            AnyError41 = 1 ;
            AnyError252 = 1 ;
            GX_msglist.addItem("No existe 'Resoluciones de Facturas SAT'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError252 == 0 ) )
         {
         }
         pr_default.close(4);
      }

      protected void CloseExtendedTableCursors0S36( )
      {
         pr_default.close(4);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_5( String A41ClinicaCodigo ,
                               String A252ResolucionCodigo )
      {
         /* Using cursor T000S8 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, A252ResolucionCodigo});
         if ( (pr_default.getStatus(6) == 101) )
         {
            AnyError41 = 1 ;
            AnyError252 = 1 ;
            GX_msglist.addItem("No existe 'Resoluciones de Facturas SAT'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError252 == 0 ) )
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

      protected void GetKey0S36( )
      {
         /* Using cursor T000S9 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A132CajaCodigo});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound36 = 1 ;
         }
         else
         {
            RcdFound36 = 0 ;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000S5 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A132CajaCodigo});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM0S36( 4) ;
            RcdFound36 = 1 ;
            A132CajaCodigo = T000S5_A132CajaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
            A133CajaDescripcion = T000S5_A133CajaDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A133CajaDescripcion", A133CajaDescripcion);
            A259CajeroCodigo = T000S5_A259CajeroCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259CajeroCodigo", A259CajeroCodigo);
            A134CajaEstado = T000S5_A134CajaEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A134CajaEstado", StringUtil.Str( (decimal)(A134CajaEstado), 1, 0));
            A41ClinicaCodigo = T000S5_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A252ResolucionCodigo = T000S5_A252ResolucionCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A252ResolucionCodigo", A252ResolucionCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z132CajaCodigo = A132CajaCodigo ;
            sMode36 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0S36( ) ;
            Gx_mode = sMode36 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound36 = 0 ;
            InitializeNonKey0S36( ) ;
            sMode36 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode36 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey0S36( ) ;
         if ( RcdFound36 == 0 )
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
         RcdFound36 = 0 ;
         /* Using cursor T000S10 */
         pr_default.execute(8, new Object[] {A41ClinicaCodigo, A132CajaCodigo});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000S10_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000S10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000S10_A132CajaCodigo[0], A132CajaCodigo) < 0 ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000S10_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000S10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000S10_A132CajaCodigo[0], A132CajaCodigo) > 0 ) ) )
            {
               A41ClinicaCodigo = T000S10_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A132CajaCodigo = T000S10_A132CajaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
               RcdFound36 = 1 ;
            }
         }
         pr_default.close(3);
      }

      protected void move_previous( )
      {
         RcdFound36 = 0 ;
         /* Using cursor T000S11 */
         pr_default.execute(9, new Object[] {A41ClinicaCodigo, A132CajaCodigo});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T000S11_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000S11_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000S11_A132CajaCodigo[0], A132CajaCodigo) > 0 ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T000S11_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000S11_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000S11_A132CajaCodigo[0], A132CajaCodigo) < 0 ) ) )
            {
               A41ClinicaCodigo = T000S11_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A132CajaCodigo = T000S11_A132CajaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
               RcdFound36 = 1 ;
            }
         }
         pr_default.close(2);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0S36( ) ;
         if ( RcdFound36 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A132CajaCodigo, Z132CajaCodigo) != 0 ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A132CajaCodigo = Z132CajaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
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
               Update0S36( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A132CajaCodigo, Z132CajaCodigo) != 0 ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert0S36( ) ;
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
                  Insert0S36( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A132CajaCodigo, Z132CajaCodigo) != 0 ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A132CajaCodigo = Z132CajaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
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
         if ( RcdFound36 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtCajaDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0S36( ) ;
         if ( RcdFound36 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCajaDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0S36( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound36 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCajaDescripcion_Internalname ;
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
         if ( RcdFound36 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCajaDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0S36( ) ;
         if ( RcdFound36 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound36 != 0 )
            {
               ScanNext0S36( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCajaDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0S36( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0S36( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000S12 */
            pr_default.execute(10, new Object[] {A41ClinicaCodigo, A132CajaCodigo});
            if ( (pr_default.getStatus(10) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Caja"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(10) == 101) || ( StringUtil.StrCmp(Z133CajaDescripcion, T000S12_A133CajaDescripcion[0]) != 0 ) || ( StringUtil.StrCmp(Z259CajeroCodigo, T000S12_A259CajeroCodigo[0]) != 0 ) || ( Z134CajaEstado != T000S12_A134CajaEstado[0] ) || ( StringUtil.StrCmp(Z252ResolucionCodigo, T000S12_A252ResolucionCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Caja"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0S36( )
      {
         BeforeValidate0S36( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0S36( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0S36( 0) ;
            CheckOptimisticConcurrency0S36( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0S36( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0S36( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000S13 */
                     pr_default.execute(11, new Object[] {A132CajaCodigo, A133CajaDescripcion, A259CajeroCodigo, A134CajaEstado, A41ClinicaCodigo, A252ResolucionCodigo});
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
                           ProcessLevel0S36( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                              ResetCaption0S0( ) ;
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
               Load0S36( ) ;
            }
            EndLevel0S36( ) ;
         }
         CloseExtendedTableCursors0S36( ) ;
      }

      protected void Update0S36( )
      {
         BeforeValidate0S36( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0S36( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0S36( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0S36( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0S36( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000S14 */
                     pr_default.execute(12, new Object[] {A133CajaDescripcion, A259CajeroCodigo, A134CajaEstado, A252ResolucionCodigo, A41ClinicaCodigo, A132CajaCodigo});
                     pr_default.close(12);
                     if ( (pr_default.getStatus(12) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Caja"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0S36( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0S36( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                              ResetCaption0S0( ) ;
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
            EndLevel0S36( ) ;
         }
         CloseExtendedTableCursors0S36( ) ;
      }

      protected void DeferredUpdate0S36( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0S36( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0S36( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0S36( ) ;
            AfterConfirm0S36( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0S36( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart0S37( ) ;
                  while ( RcdFound37 != 0 )
                  {
                     getByPrimaryKey0S37( ) ;
                     Delete0S37( ) ;
                     ScanNext0S37( ) ;
                  }
                  ScanEnd0S37( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000S15 */
                     pr_default.execute(13, new Object[] {A41ClinicaCodigo, A132CajaCodigo});
                     pr_default.close(13);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound36 == 0 )
                           {
                              InitAll0S36( ) ;
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
                           ResetCaption0S0( ) ;
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
         sMode36 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0S36( ) ;
         Gx_mode = sMode36 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0S36( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000S16 */
            pr_default.execute(14, new Object[] {A41ClinicaCodigo, A132CajaCodigo});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Factura a Pacientes"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(14);
            /* Using cursor T000S17 */
            pr_default.execute(15, new Object[] {A41ClinicaCodigo, A132CajaCodigo});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Cortes de Caja"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(15);
         }
      }

      protected void ProcessNestedLevel0S37( )
      {
         nGXsfl_70_idx = 0 ;
         while ( nGXsfl_70_idx < nRC_Gridcaja_cajacorrelativo )
         {
            ReadRow0S37( ) ;
            if ( ( nRcdExists_37 != 0 ) || ( nIsMod_37 != 0 ) )
            {
               standaloneNotModal0S37( ) ;
               GetKey0S37( ) ;
               if ( ( nRcdExists_37 == 0 ) && ( nRcdDeleted_37 == 0 ) )
               {
                  if ( RcdFound37 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Insert0S37( ) ;
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtCajaAnio_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound37 != 0 )
                  {
                     if ( ( nRcdDeleted_37 != 0 ) && ( nRcdExists_37 != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete0S37( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_37 != 0 ) && ( nRcdExists_37 != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update0S37( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_37 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtCajaAnio_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtCajaAnio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A135CajaAnio), 4, 0, ".", ""))) ;
            ChangePostValue( edtCajaSiguiente_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A136CajaSiguiente), 9, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z135CajaAnio_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z135CajaAnio), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z136CajaSiguiente_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z136CajaSiguiente), 9, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_37_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_37), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_37_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_37), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_37_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_37), 4, 0, ".", ""))) ;
            if ( nIsMod_37 != 0 )
            {
               ChangePostValue( "CAJAANIO_"+sGXsfl_70_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCajaAnio_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CAJASIGUIENTE_"+sGXsfl_70_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCajaSiguiente_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0S37( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_37 = 0 ;
         nIsMod_37 = 0 ;
         nRcdDeleted_37 = 0 ;
      }

      protected void ProcessLevel0S36( )
      {
         /* Save parent mode. */
         sMode36 = Gx_mode ;
         ProcessNestedLevel0S37( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode36 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel0S36( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0S36( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(9);
            pr_default.close(8);
            pr_default.close(1);
            pr_default.close(0);
            context.CommitDataStores("Caja");
            if ( AnyError == 0 )
            {
               ConfirmValues0S0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(9);
            pr_default.close(8);
            pr_default.close(1);
            pr_default.close(0);
            context.RollbackDataStores("Caja");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0S36( )
      {
         /* Using cursor T000S18 */
         pr_default.execute(16);
         RcdFound36 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound36 = 1 ;
            A41ClinicaCodigo = T000S18_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A132CajaCodigo = T000S18_A132CajaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0S36( )
      {
         pr_default.readNext(16);
         RcdFound36 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound36 = 1 ;
            A41ClinicaCodigo = T000S18_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A132CajaCodigo = T000S18_A132CajaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
         }
      }

      protected void ScanEnd0S36( )
      {
      }

      protected void AfterConfirm0S36( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0S36( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0S36( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0S36( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0S36( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0S36( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0S36( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtCajaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCajaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCajaCodigo_Enabled), 5, 0)));
         edtCajaDescripcion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCajaDescripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCajaDescripcion_Enabled), 5, 0)));
         edtResolucionCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtResolucionCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtResolucionCodigo_Enabled), 5, 0)));
         edtCajeroCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCajeroCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCajeroCodigo_Enabled), 5, 0)));
         cmbCajaEstado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCajaEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbCajaEstado.Enabled), 5, 0)));
      }

      protected void ZM0S37( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z136CajaSiguiente = T000S3_A136CajaSiguiente[0] ;
            }
            else
            {
               Z136CajaSiguiente = A136CajaSiguiente ;
            }
         }
         if ( GX_JID == -6 )
         {
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z132CajaCodigo = A132CajaCodigo ;
            Z135CajaAnio = A135CajaAnio ;
            Z136CajaSiguiente = A136CajaSiguiente ;
         }
      }

      protected void standaloneNotModal0S37( )
      {
      }

      protected void standaloneModal0S37( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtCajaAnio_Enabled = 0 ;
         }
         else
         {
            edtCajaAnio_Enabled = 1 ;
         }
         if ( ( StringUtil.StrCmp(sMode37, "DSP") == 0 ) || ( StringUtil.StrCmp(sMode37, "DLT") == 0 ) )
         {
            DisableAttributes0S37( ) ;
         }
      }

      protected void Load0S37( )
      {
         /* Using cursor T000S19 */
         pr_default.execute(17, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A135CajaAnio});
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound37 = 1 ;
            A136CajaSiguiente = T000S19_A136CajaSiguiente[0] ;
            ZM0S37( -6) ;
         }
         pr_default.close(17);
         OnLoadActions0S37( ) ;
      }

      protected void OnLoadActions0S37( )
      {
      }

      protected void CheckExtendedTable0S37( )
      {
         Gx_BScreen = 1 ;
         standaloneModal0S37( ) ;
      }

      protected void CloseExtendedTableCursors0S37( )
      {
      }

      protected void enableDisable0S37( )
      {
      }

      protected void GetKey0S37( )
      {
         /* Using cursor T000S20 */
         pr_default.execute(18, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A135CajaAnio});
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound37 = 1 ;
         }
         else
         {
            RcdFound37 = 0 ;
         }
         pr_default.close(18);
      }

      protected void getByPrimaryKey0S37( )
      {
         /* Using cursor T000S3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A135CajaAnio});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0S37( 6) ;
            RcdFound37 = 1 ;
            InitializeNonKey0S37( ) ;
            A135CajaAnio = T000S3_A135CajaAnio[0] ;
            A136CajaSiguiente = T000S3_A136CajaSiguiente[0] ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z132CajaCodigo = A132CajaCodigo ;
            Z135CajaAnio = A135CajaAnio ;
            sMode37 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0S37( ) ;
            Load0S37( ) ;
            Gx_mode = sMode37 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound37 = 0 ;
            InitializeNonKey0S37( ) ;
            sMode37 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0S37( ) ;
            Gx_mode = sMode37 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0S37( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000S2 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A135CajaAnio});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CajaCorrelativo"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z136CajaSiguiente != T000S2_A136CajaSiguiente[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"CajaCorrelativo"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0S37( )
      {
         BeforeValidate0S37( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0S37( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0S37( 0) ;
            CheckOptimisticConcurrency0S37( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0S37( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0S37( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000S21 */
                     pr_default.execute(19, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A135CajaAnio, A136CajaSiguiente});
                     pr_default.close(19);
                     if ( (pr_default.getStatus(19) == 1) )
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
               Load0S37( ) ;
            }
            EndLevel0S37( ) ;
         }
         CloseExtendedTableCursors0S37( ) ;
      }

      protected void Update0S37( )
      {
         BeforeValidate0S37( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0S37( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0S37( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0S37( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0S37( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000S22 */
                     pr_default.execute(20, new Object[] {A136CajaSiguiente, A41ClinicaCodigo, A132CajaCodigo, A135CajaAnio});
                     pr_default.close(20);
                     if ( (pr_default.getStatus(20) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CajaCorrelativo"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0S37( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0S37( ) ;
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
            EndLevel0S37( ) ;
         }
         CloseExtendedTableCursors0S37( ) ;
      }

      protected void DeferredUpdate0S37( )
      {
      }

      protected void Delete0S37( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0S37( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0S37( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0S37( ) ;
            AfterConfirm0S37( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0S37( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000S23 */
                  pr_default.execute(21, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A135CajaAnio});
                  pr_default.close(21);
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
         sMode37 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0S37( ) ;
         Gx_mode = sMode37 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0S37( )
      {
         standaloneModal0S37( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0S37( )
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

      protected void ScanStart0S37( )
      {
         /* Using cursor T000S24 */
         pr_default.execute(22, new Object[] {A41ClinicaCodigo, A132CajaCodigo});
         RcdFound37 = 0 ;
         if ( (pr_default.getStatus(22) != 101) )
         {
            RcdFound37 = 1 ;
            A135CajaAnio = T000S24_A135CajaAnio[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0S37( )
      {
         pr_default.readNext(22);
         RcdFound37 = 0 ;
         if ( (pr_default.getStatus(22) != 101) )
         {
            RcdFound37 = 1 ;
            A135CajaAnio = T000S24_A135CajaAnio[0] ;
         }
      }

      protected void ScanEnd0S37( )
      {
         pr_default.close(1);
      }

      protected void AfterConfirm0S37( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0S37( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0S37( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0S37( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0S37( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0S37( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0S37( )
      {
         edtCajaAnio_Enabled = 0 ;
         edtCajaSiguiente_Enabled = 0 ;
      }

      protected void AddRow0S37( )
      {
         nGXsfl_70_idx = (short)(nGXsfl_70_idx+1) ;
         sGXsfl_70_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_70_idx), 4, 0)), 4, "0") ;
         edtCajaAnio_Internalname = "CAJAANIO_"+sGXsfl_70_idx ;
         edtCajaSiguiente_Internalname = "CAJASIGUIENTE_"+sGXsfl_70_idx ;
         SendRow0S37( ) ;
      }

      protected void SendRow0S37( )
      {
         Gridcaja_cajacorrelativoRow = GXWebRow.GetNew(context) ;
         if ( subGridcaja_cajacorrelativo_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridcaja_cajacorrelativo_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGridcaja_cajacorrelativo_Class, "") != 0 )
            {
               subGridcaja_cajacorrelativo_Linesclass = subGridcaja_cajacorrelativo_Class+"Odd" ;
            }
         }
         else if ( subGridcaja_cajacorrelativo_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridcaja_cajacorrelativo_Backstyle = 0 ;
            subGridcaja_cajacorrelativo_Backcolor = subGridcaja_cajacorrelativo_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridcaja_cajacorrelativoContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridcaja_cajacorrelativo_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGridcaja_cajacorrelativo_Class, "") != 0 )
            {
               subGridcaja_cajacorrelativo_Linesclass = subGridcaja_cajacorrelativo_Class+"Uniform" ;
            }
         }
         else if ( subGridcaja_cajacorrelativo_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridcaja_cajacorrelativo_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGridcaja_cajacorrelativo_Class, "") != 0 )
            {
               subGridcaja_cajacorrelativo_Linesclass = subGridcaja_cajacorrelativo_Class+"Odd" ;
            }
            subGridcaja_cajacorrelativo_Backcolor = (int)(0xFFFFFF) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridcaja_cajacorrelativoContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridcaja_cajacorrelativo_Backcolor), 9, 0)));
         }
         else if ( subGridcaja_cajacorrelativo_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridcaja_cajacorrelativo_Backstyle = 1 ;
            if ( ((int)(nGXsfl_70_idx) % (2)) == 0 )
            {
               subGridcaja_cajacorrelativo_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridcaja_cajacorrelativoContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridcaja_cajacorrelativo_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridcaja_cajacorrelativo_Class, "") != 0 )
               {
                  subGridcaja_cajacorrelativo_Linesclass = subGridcaja_cajacorrelativo_Class+"Even" ;
               }
            }
            else
            {
               subGridcaja_cajacorrelativo_Backcolor = (int)(0xFFFFFF) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridcaja_cajacorrelativoContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridcaja_cajacorrelativo_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridcaja_cajacorrelativo_Class, "") != 0 )
               {
                  subGridcaja_cajacorrelativo_Linesclass = subGridcaja_cajacorrelativo_Class+"Odd" ;
               }
            }
         }
         /* * Property Link not supported in */
         /* * Property Link not supported in */
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_37_" + sGXsfl_70_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_70_idx + "',70)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridcaja_cajacorrelativoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCajaAnio_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A135CajaAnio), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A135CajaAnio), "ZZZ9")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(71);\"",(String)"",(String)"",(String)"",(String)"",(String)edtCajaAnio_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtCajaAnio_Enabled,(short)1,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)70,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_37_" + sGXsfl_70_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 72,'',false,'" + sGXsfl_70_idx + "',70)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridcaja_cajacorrelativoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCajaSiguiente_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A136CajaSiguiente), 9, 0, ".", "")),((edtCajaSiguiente_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A136CajaSiguiente), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A136CajaSiguiente), "ZZZZZZZZ9")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(72);\"",(String)"",(String)"",(String)"",(String)"",(String)edtCajaSiguiente_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtCajaSiguiente_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)70,(short)1,(short)-1,(bool)true,(String)"right"});
         context.httpAjaxContext.ajax_sending_grid_row(Gridcaja_cajacorrelativoRow);
         GXCCtl = "Z135CajaAnio_" + sGXsfl_70_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z135CajaAnio), 4, 0, ".", "")));
         GXCCtl = "Z136CajaSiguiente_" + sGXsfl_70_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z136CajaSiguiente), 9, 0, ".", "")));
         GXCCtl = "nRcdDeleted_37_" + sGXsfl_70_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_37), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_37_" + sGXsfl_70_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_37), 4, 0, ".", "")));
         GXCCtl = "nIsMod_37_" + sGXsfl_70_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_37), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CAJAANIO_"+sGXsfl_70_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCajaAnio_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CAJASIGUIENTE_"+sGXsfl_70_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCajaSiguiente_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridcaja_cajacorrelativoContainer.AddRow(Gridcaja_cajacorrelativoRow);
      }

      protected void ReadRow0S37( )
      {
         nGXsfl_70_idx = (short)(nGXsfl_70_idx+1) ;
         sGXsfl_70_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_70_idx), 4, 0)), 4, "0") ;
         edtCajaAnio_Internalname = "CAJAANIO_"+sGXsfl_70_idx ;
         edtCajaSiguiente_Internalname = "CAJASIGUIENTE_"+sGXsfl_70_idx ;
         edtCajaAnio_Enabled = (int)(context.localUtil.CToN( cgiGet( "CAJAANIO_"+sGXsfl_70_idx+"Enabled"), ".", ",")) ;
         edtCajaSiguiente_Enabled = (int)(context.localUtil.CToN( cgiGet( "CAJASIGUIENTE_"+sGXsfl_70_idx+"Enabled"), ".", ",")) ;
         if ( ( ( context.localUtil.CToN( cgiGet( edtCajaAnio_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCajaAnio_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CAJAANIO");
            AnyError = 1 ;
            GX_FocusControl = edtCajaAnio_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A135CajaAnio = 0 ;
         }
         else
         {
            A135CajaAnio = (short)(context.localUtil.CToN( cgiGet( edtCajaAnio_Internalname), ".", ",")) ;
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtCajaSiguiente_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCajaSiguiente_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CAJASIGUIENTE");
            AnyError = 1 ;
            GX_FocusControl = edtCajaSiguiente_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A136CajaSiguiente = 0 ;
         }
         else
         {
            A136CajaSiguiente = (int)(context.localUtil.CToN( cgiGet( edtCajaSiguiente_Internalname), ".", ",")) ;
         }
         GXCCtl = "Z135CajaAnio_" + sGXsfl_70_idx ;
         Z135CajaAnio = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "Z136CajaSiguiente_" + sGXsfl_70_idx ;
         Z136CajaSiguiente = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdDeleted_37_" + sGXsfl_70_idx ;
         nRcdDeleted_37 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdExists_37_" + sGXsfl_70_idx ;
         nRcdExists_37 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nIsMod_37_" + sGXsfl_70_idx ;
         nIsMod_37 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
      }

      protected void assign_properties_default( )
      {
         defedtCajaAnio_Enabled = edtCajaAnio_Enabled ;
      }

      protected void ConfirmValues0S0( )
      {
         nGXsfl_70_idx = 0 ;
         sGXsfl_70_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_70_idx), 4, 0)), 4, "0") ;
         edtCajaAnio_Internalname = "CAJAANIO_"+sGXsfl_70_idx ;
         edtCajaSiguiente_Internalname = "CAJASIGUIENTE_"+sGXsfl_70_idx ;
         while ( nGXsfl_70_idx < nRC_Gridcaja_cajacorrelativo )
         {
            nGXsfl_70_idx = (short)(nGXsfl_70_idx+1) ;
            sGXsfl_70_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_70_idx), 4, 0)), 4, "0") ;
            edtCajaAnio_Internalname = "CAJAANIO_"+sGXsfl_70_idx ;
            edtCajaSiguiente_Internalname = "CAJASIGUIENTE_"+sGXsfl_70_idx ;
            ChangePostValue( "Z135CajaAnio_"+sGXsfl_70_idx, cgiGet( "ZT_"+"Z135CajaAnio_"+sGXsfl_70_idx)) ;
            DeletePostValue( "ZT_"+"Z135CajaAnio_"+sGXsfl_70_idx) ;
            ChangePostValue( "Z136CajaSiguiente_"+sGXsfl_70_idx, cgiGet( "ZT_"+"Z136CajaSiguiente_"+sGXsfl_70_idx)) ;
            DeletePostValue( "ZT_"+"Z136CajaSiguiente_"+sGXsfl_70_idx) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("caja.aspx") +"\" class=\""+"Form"+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z133CajaDescripcion", StringUtil.RTrim( Z133CajaDescripcion));
         GxWebStd.gx_hidden_field( context, "Z259CajeroCodigo", StringUtil.RTrim( Z259CajeroCodigo));
         GxWebStd.gx_hidden_field( context, "Z134CajaEstado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z134CajaEstado), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z252ResolucionCodigo", StringUtil.RTrim( Z252ResolucionCodigo));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_Gridcaja_cajacorrelativo", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_70_idx), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vCLINICACODIGO", StringUtil.RTrim( AV8ClinicaCodigo));
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
         return "Caja" ;
      }

      public override String GetPgmdesc( )
      {
         return "Cajas" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("caja.aspx")  ;
      }

      protected void InitializeNonKey0S36( )
      {
         A133CajaDescripcion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A133CajaDescripcion", A133CajaDescripcion);
         A252ResolucionCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A252ResolucionCodigo", A252ResolucionCodigo);
         A259CajeroCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259CajeroCodigo", A259CajeroCodigo);
         A134CajaEstado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A134CajaEstado", StringUtil.Str( (decimal)(A134CajaEstado), 1, 0));
      }

      protected void InitAll0S36( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A132CajaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
         InitializeNonKey0S36( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0S37( )
      {
         A136CajaSiguiente = 0 ;
      }

      protected void InitAll0S37( )
      {
         A135CajaAnio = 0 ;
         InitializeNonKey0S37( ) ;
      }

      protected void StandaloneModalInsert0S37( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1553386");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("caja.js", "?1553386");
         /* End function include_jscripts */
      }

      protected void init_level_properties37( )
      {
         edtCajaAnio_Enabled = defedtCajaAnio_Enabled ;
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
         lblTextblockcajadescripcion_Internalname = "TEXTBLOCKCAJADESCRIPCION" ;
         edtCajaDescripcion_Internalname = "CAJADESCRIPCION" ;
         lblTextblockresolucioncodigo_Internalname = "TEXTBLOCKRESOLUCIONCODIGO" ;
         edtResolucionCodigo_Internalname = "RESOLUCIONCODIGO" ;
         lblTextblockcajerocodigo_Internalname = "TEXTBLOCKCAJEROCODIGO" ;
         edtCajeroCodigo_Internalname = "CAJEROCODIGO" ;
         lblTextblockcajaestado_Internalname = "TEXTBLOCKCAJAESTADO" ;
         cmbCajaEstado_Internalname = "CAJAESTADO" ;
         lblTitlecajacorrelativo_Internalname = "TITLECAJACORRELATIVO" ;
         tblTable3_Internalname = "TABLE3" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_252_Internalname = "PROMPT_41_252" ;
         subGridcaja_cajacorrelativo_Internalname = "GRIDCAJA_CAJACORRELATIVO" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Cajas" ;
         edtCajaSiguiente_Jsonclick = "" ;
         edtCajaAnio_Jsonclick = "" ;
         subGridcaja_cajacorrelativo_Class = "Grid" ;
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
         subGridcaja_cajacorrelativo_Allowcollapsing = 0 ;
         edtCajaSiguiente_Enabled = 1 ;
         edtCajaAnio_Enabled = 1 ;
         subGridcaja_cajacorrelativo_Backcolorstyle = 2 ;
         cmbCajaEstado_Jsonclick = "" ;
         cmbCajaEstado.Enabled = 1 ;
         edtCajeroCodigo_Jsonclick = "" ;
         edtCajeroCodigo_Enabled = 1 ;
         imgprompt_41_252_Visible = 1 ;
         imgprompt_41_252_Link = "" ;
         edtResolucionCodigo_Jsonclick = "" ;
         edtResolucionCodigo_Enabled = 1 ;
         edtCajaDescripcion_Jsonclick = "" ;
         edtCajaDescripcion_Enabled = 1 ;
         edtCajaCodigo_Jsonclick = "" ;
         edtCajaCodigo_Enabled = 1 ;
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

      protected void gxnrGridcaja_cajacorrelativo_newrow( short nRC_Gridcaja_cajacorrelativo ,
                                                          short nGXsfl_70_idx ,
                                                          String sGXsfl_70_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         edtCajaAnio_Internalname = "CAJAANIO_"+sGXsfl_70_idx ;
         edtCajaSiguiente_Internalname = "CAJASIGUIENTE_"+sGXsfl_70_idx ;
         while ( nGXsfl_70_idx <= nRC_Gridcaja_cajacorrelativo )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0S37( ) ;
            standaloneModal0S37( ) ;
            cmbCajaEstado.Name = "CAJAESTADO" ;
            cmbCajaEstado.WebTags = "" ;
            cmbCajaEstado.addItem("0", "De baja", 0);
            cmbCajaEstado.addItem("1", "Activo", 0);
            if ( ( cmbCajaEstado.ItemCount > 0 ) && (0==A134CajaEstado) )
            {
               A134CajaEstado = (short)(NumberUtil.Val( cmbCajaEstado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A134CajaEstado", StringUtil.Str( (decimal)(A134CajaEstado), 1, 0));
            }
            dynload_actions( ) ;
            SendRow0S37( ) ;
            nGXsfl_70_idx = (short)(nGXsfl_70_idx+1) ;
            sGXsfl_70_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_70_idx), 4, 0)), 4, "0") ;
            edtCajaAnio_Internalname = "CAJAANIO_"+sGXsfl_70_idx ;
            edtCajaSiguiente_Internalname = "CAJASIGUIENTE_"+sGXsfl_70_idx ;
         }
         context.GX_webresponse.AddString(Gridcaja_cajacorrelativoContainer.ToJavascriptSource());
         /* End function gxnrGridcaja_cajacorrelativo_newrow */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         GX_FocusControl = edtCajaDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Cajacodigo( String GX_Parm1 ,
                                    String GX_Parm2 ,
                                    String GX_Parm3 ,
                                    String GX_Parm4 ,
                                    String GX_Parm5 ,
                                    GXCombobox cmbGX_Parm6 ,
                                    String GX_Parm7 )
      {
         AV8ClinicaCodigo = GX_Parm1 ;
         A41ClinicaCodigo = GX_Parm2 ;
         A132CajaCodigo = GX_Parm3 ;
         A133CajaDescripcion = GX_Parm4 ;
         A259CajeroCodigo = GX_Parm5 ;
         cmbCajaEstado = cmbGX_Parm6 ;
         A134CajaEstado = (short)(NumberUtil.Val( cmbCajaEstado.CurrentValue, ".")) ;
         cmbCajaEstado.CurrentValue = StringUtil.Str( (decimal)(A134CajaEstado), 1, 0) ;
         A252ResolucionCodigo = GX_Parm7 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A133CajaDescripcion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A252ResolucionCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A259CajeroCodigo)));
         cmbCajaEstado.CurrentValue = StringUtil.Str( (decimal)(A134CajaEstado), 1, 0) ;
         isValidOutput.Add((Object)(cmbCajaEstado));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z132CajaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z133CajaDescripcion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z252ResolucionCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z259CajeroCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z134CajaEstado), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(Gridcaja_cajacorrelativoContainer));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Resolucioncodigo( String GX_Parm1 ,
                                          String GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A252ResolucionCodigo = GX_Parm2 ;
         /* Using cursor T000S25 */
         pr_default.execute(23, new Object[] {A41ClinicaCodigo, A252ResolucionCodigo});
         if ( (pr_default.getStatus(23) == 101) )
         {
            AnyError41 = 1 ;
            AnyError252 = 1 ;
            GX_msglist.addItem("No existe 'Resoluciones de Facturas SAT'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError252 == 0 ) )
         {
         }
         pr_default.close(23);
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
         pr_default.close(22);
         pr_default.close(16);
         pr_default.close(9);
         pr_default.close(8);
         pr_default.close(23);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
         A252ResolucionCodigo = "" ;
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
         A132CajaCodigo = "" ;
         lblTextblockcajadescripcion_Jsonclick = "" ;
         A133CajaDescripcion = "" ;
         lblTextblockresolucioncodigo_Jsonclick = "" ;
         lblTextblockcajerocodigo_Jsonclick = "" ;
         A259CajeroCodigo = "" ;
         lblTextblockcajaestado_Jsonclick = "" ;
         Gridcaja_cajacorrelativoContainer = new GXWebGrid( context);
         Gridcaja_cajacorrelativoColumn = new GXWebColumn();
         Gx_mode = "" ;
         sMode37 = "" ;
         edtCajaAnio_Internalname = "" ;
         lblTitlecajacorrelativo_Jsonclick = "" ;
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
         Z133CajaDescripcion = "" ;
         Z259CajeroCodigo = "" ;
         Z252ResolucionCodigo = "" ;
         AV8ClinicaCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtCajaSiguiente_Internalname = "" ;
         AV7Parametros = new SdtParametros(context);
         GXt_SdtParametros6 = new SdtParametros(context);
         T000S7_A132CajaCodigo = new String[] {""} ;
         T000S7_A133CajaDescripcion = new String[] {""} ;
         T000S7_A259CajeroCodigo = new String[] {""} ;
         T000S7_A134CajaEstado = new short[1] ;
         T000S7_A41ClinicaCodigo = new String[] {""} ;
         T000S7_A252ResolucionCodigo = new String[] {""} ;
         T000S6_A41ClinicaCodigo = new String[] {""} ;
         T000S8_A41ClinicaCodigo = new String[] {""} ;
         T000S9_A41ClinicaCodigo = new String[] {""} ;
         T000S9_A132CajaCodigo = new String[] {""} ;
         T000S5_A132CajaCodigo = new String[] {""} ;
         T000S5_A133CajaDescripcion = new String[] {""} ;
         T000S5_A259CajeroCodigo = new String[] {""} ;
         T000S5_A134CajaEstado = new short[1] ;
         T000S5_A41ClinicaCodigo = new String[] {""} ;
         T000S5_A252ResolucionCodigo = new String[] {""} ;
         sMode36 = "" ;
         T000S10_A41ClinicaCodigo = new String[] {""} ;
         T000S10_A132CajaCodigo = new String[] {""} ;
         T000S11_A41ClinicaCodigo = new String[] {""} ;
         T000S11_A132CajaCodigo = new String[] {""} ;
         T000S12_A132CajaCodigo = new String[] {""} ;
         T000S12_A133CajaDescripcion = new String[] {""} ;
         T000S12_A259CajeroCodigo = new String[] {""} ;
         T000S12_A134CajaEstado = new short[1] ;
         T000S12_A41ClinicaCodigo = new String[] {""} ;
         T000S12_A252ResolucionCodigo = new String[] {""} ;
         T000S16_A41ClinicaCodigo = new String[] {""} ;
         T000S16_A185FacturaId = new int[1] ;
         T000S17_A41ClinicaCodigo = new String[] {""} ;
         T000S17_A132CajaCodigo = new String[] {""} ;
         T000S17_A153CorteCajaId = new int[1] ;
         T000S18_A41ClinicaCodigo = new String[] {""} ;
         T000S18_A132CajaCodigo = new String[] {""} ;
         T000S19_A41ClinicaCodigo = new String[] {""} ;
         T000S19_A132CajaCodigo = new String[] {""} ;
         T000S19_A135CajaAnio = new short[1] ;
         T000S19_A136CajaSiguiente = new int[1] ;
         T000S20_A41ClinicaCodigo = new String[] {""} ;
         T000S20_A132CajaCodigo = new String[] {""} ;
         T000S20_A135CajaAnio = new short[1] ;
         T000S3_A41ClinicaCodigo = new String[] {""} ;
         T000S3_A132CajaCodigo = new String[] {""} ;
         T000S3_A135CajaAnio = new short[1] ;
         T000S3_A136CajaSiguiente = new int[1] ;
         T000S2_A41ClinicaCodigo = new String[] {""} ;
         T000S2_A132CajaCodigo = new String[] {""} ;
         T000S2_A135CajaAnio = new short[1] ;
         T000S2_A136CajaSiguiente = new int[1] ;
         T000S24_A41ClinicaCodigo = new String[] {""} ;
         T000S24_A132CajaCodigo = new String[] {""} ;
         T000S24_A135CajaAnio = new short[1] ;
         Gridcaja_cajacorrelativoRow = new GXWebRow();
         subGridcaja_cajacorrelativo_Linesclass = "" ;
         ROClassString = "" ;
         GXCCtl = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char7 = "" ;
         GXt_char5 = "" ;
         GXt_char8 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         T000S25_A41ClinicaCodigo = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.caja__default(),
            new Object[][] {
                new Object[] {
               T000S2_A41ClinicaCodigo, T000S2_A132CajaCodigo, T000S2_A135CajaAnio, T000S2_A136CajaSiguiente
               }
               , new Object[] {
               T000S3_A41ClinicaCodigo, T000S3_A132CajaCodigo, T000S3_A135CajaAnio, T000S3_A136CajaSiguiente
               }
               , new Object[] {
               T000S4_A132CajaCodigo, T000S4_A133CajaDescripcion, T000S4_A259CajeroCodigo, T000S4_A134CajaEstado, T000S4_A41ClinicaCodigo, T000S4_A252ResolucionCodigo
               }
               , new Object[] {
               T000S5_A132CajaCodigo, T000S5_A133CajaDescripcion, T000S5_A259CajeroCodigo, T000S5_A134CajaEstado, T000S5_A41ClinicaCodigo, T000S5_A252ResolucionCodigo
               }
               , new Object[] {
               T000S6_A41ClinicaCodigo
               }
               , new Object[] {
               T000S7_A132CajaCodigo, T000S7_A133CajaDescripcion, T000S7_A259CajeroCodigo, T000S7_A134CajaEstado, T000S7_A41ClinicaCodigo, T000S7_A252ResolucionCodigo
               }
               , new Object[] {
               T000S8_A41ClinicaCodigo
               }
               , new Object[] {
               T000S9_A41ClinicaCodigo, T000S9_A132CajaCodigo
               }
               , new Object[] {
               T000S10_A41ClinicaCodigo, T000S10_A132CajaCodigo
               }
               , new Object[] {
               T000S11_A41ClinicaCodigo, T000S11_A132CajaCodigo
               }
               , new Object[] {
               T000S12_A132CajaCodigo, T000S12_A133CajaDescripcion, T000S12_A259CajeroCodigo, T000S12_A134CajaEstado, T000S12_A41ClinicaCodigo, T000S12_A252ResolucionCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000S16_A41ClinicaCodigo, T000S16_A185FacturaId
               }
               , new Object[] {
               T000S17_A41ClinicaCodigo, T000S17_A132CajaCodigo, T000S17_A153CorteCajaId
               }
               , new Object[] {
               T000S18_A41ClinicaCodigo, T000S18_A132CajaCodigo
               }
               , new Object[] {
               T000S19_A41ClinicaCodigo, T000S19_A132CajaCodigo, T000S19_A135CajaAnio, T000S19_A136CajaSiguiente
               }
               , new Object[] {
               T000S20_A41ClinicaCodigo, T000S20_A132CajaCodigo, T000S20_A135CajaAnio
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000S24_A41ClinicaCodigo, T000S24_A132CajaCodigo, T000S24_A135CajaAnio
               }
               , new Object[] {
               T000S25_A41ClinicaCodigo
               }
            }
         );
      }

      private short GxWebError ;
      private short nRC_Gridcaja_cajacorrelativo ;
      private short nGXsfl_70_idx=1 ;
      private short gxcookieaux ;
      private short A134CajaEstado ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGridcaja_cajacorrelativo_Backcolorstyle ;
      private short A135CajaAnio ;
      private short subGridcaja_cajacorrelativo_Allowcollapsing ;
      private short subGridcaja_cajacorrelativo_Collapsed ;
      private short nBlankRcdCount37 ;
      private short nRcdExists_37 ;
      private short RcdFound37 ;
      private short nIsMod_37 ;
      private short nBlankRcdUsr37 ;
      private short Z134CajaEstado ;
      private short nRcdDeleted_37 ;
      private short Z135CajaAnio ;
      private short GX_JID ;
      private short RcdFound36 ;
      private short Gx_BScreen ;
      private short subGridcaja_cajacorrelativo_Backstyle ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int lblTextblockclinicacodigo_Visible ;
      private int edtClinicaCodigo_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int edtCajaCodigo_Enabled ;
      private int edtCajaDescripcion_Enabled ;
      private int edtResolucionCodigo_Enabled ;
      private int imgprompt_41_252_Visible ;
      private int edtCajeroCodigo_Enabled ;
      private int edtCajaAnio_Enabled ;
      private int A136CajaSiguiente ;
      private int edtCajaSiguiente_Enabled ;
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
      private int GRIDCAJA_CAJACORRELATIVO_nFirstRecordOnPage ;
      private int Z136CajaSiguiente ;
      private int AnyError41 ;
      private int AnyError252 ;
      private int subGridcaja_cajacorrelativo_Backcolor ;
      private int subGridcaja_cajacorrelativo_Allbackcolor ;
      private int defedtCajaAnio_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_70_idx="0001" ;
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
      private String lblTextblockcajadescripcion_Internalname ;
      private String lblTextblockcajadescripcion_Jsonclick ;
      private String edtCajaDescripcion_Internalname ;
      private String edtCajaDescripcion_Jsonclick ;
      private String lblTextblockresolucioncodigo_Internalname ;
      private String lblTextblockresolucioncodigo_Jsonclick ;
      private String edtResolucionCodigo_Internalname ;
      private String edtResolucionCodigo_Jsonclick ;
      private String imgprompt_41_252_Internalname ;
      private String imgprompt_41_252_Link ;
      private String lblTextblockcajerocodigo_Internalname ;
      private String lblTextblockcajerocodigo_Jsonclick ;
      private String edtCajeroCodigo_Internalname ;
      private String edtCajeroCodigo_Jsonclick ;
      private String lblTextblockcajaestado_Internalname ;
      private String lblTextblockcajaestado_Jsonclick ;
      private String cmbCajaEstado_Internalname ;
      private String cmbCajaEstado_Jsonclick ;
      private String Gx_mode ;
      private String sMode37 ;
      private String edtCajaAnio_Internalname ;
      private String tblTable3_Internalname ;
      private String lblTitlecajacorrelativo_Internalname ;
      private String lblTitlecajacorrelativo_Jsonclick ;
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
      private String edtCajaSiguiente_Internalname ;
      private String sMode36 ;
      private String subGridcaja_cajacorrelativo_Class ;
      private String subGridcaja_cajacorrelativo_Linesclass ;
      private String ROClassString ;
      private String edtCajaAnio_Jsonclick ;
      private String edtCajaSiguiente_Jsonclick ;
      private String GXCCtl ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char7 ;
      private String GXt_char5 ;
      private String subGridcaja_cajacorrelativo_Internalname ;
      private String GXt_char8 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A41ClinicaCodigo ;
      private String A252ResolucionCodigo ;
      private String A132CajaCodigo ;
      private String A133CajaDescripcion ;
      private String A259CajeroCodigo ;
      private String Z41ClinicaCodigo ;
      private String Z132CajaCodigo ;
      private String Z133CajaDescripcion ;
      private String Z259CajeroCodigo ;
      private String Z252ResolucionCodigo ;
      private String AV8ClinicaCodigo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Gridcaja_cajacorrelativoContainer ;
      private GXWebRow Gridcaja_cajacorrelativoRow ;
      private GXWebColumn Gridcaja_cajacorrelativoColumn ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbCajaEstado ;
      private IDataStoreProvider pr_default ;
      private String[] T000S7_A132CajaCodigo ;
      private String[] T000S7_A133CajaDescripcion ;
      private String[] T000S7_A259CajeroCodigo ;
      private short[] T000S7_A134CajaEstado ;
      private String[] T000S7_A41ClinicaCodigo ;
      private String[] T000S7_A252ResolucionCodigo ;
      private String[] T000S6_A41ClinicaCodigo ;
      private String[] T000S8_A41ClinicaCodigo ;
      private String[] T000S9_A41ClinicaCodigo ;
      private String[] T000S9_A132CajaCodigo ;
      private String[] T000S5_A132CajaCodigo ;
      private String[] T000S5_A133CajaDescripcion ;
      private String[] T000S5_A259CajeroCodigo ;
      private short[] T000S5_A134CajaEstado ;
      private String[] T000S5_A41ClinicaCodigo ;
      private String[] T000S5_A252ResolucionCodigo ;
      private String[] T000S10_A41ClinicaCodigo ;
      private String[] T000S10_A132CajaCodigo ;
      private String[] T000S11_A41ClinicaCodigo ;
      private String[] T000S11_A132CajaCodigo ;
      private String[] T000S12_A132CajaCodigo ;
      private String[] T000S12_A133CajaDescripcion ;
      private String[] T000S12_A259CajeroCodigo ;
      private short[] T000S12_A134CajaEstado ;
      private String[] T000S12_A41ClinicaCodigo ;
      private String[] T000S12_A252ResolucionCodigo ;
      private String[] T000S16_A41ClinicaCodigo ;
      private int[] T000S16_A185FacturaId ;
      private String[] T000S17_A41ClinicaCodigo ;
      private String[] T000S17_A132CajaCodigo ;
      private int[] T000S17_A153CorteCajaId ;
      private String[] T000S18_A41ClinicaCodigo ;
      private String[] T000S18_A132CajaCodigo ;
      private String[] T000S19_A41ClinicaCodigo ;
      private String[] T000S19_A132CajaCodigo ;
      private short[] T000S19_A135CajaAnio ;
      private int[] T000S19_A136CajaSiguiente ;
      private String[] T000S20_A41ClinicaCodigo ;
      private String[] T000S20_A132CajaCodigo ;
      private short[] T000S20_A135CajaAnio ;
      private String[] T000S3_A41ClinicaCodigo ;
      private String[] T000S3_A132CajaCodigo ;
      private short[] T000S3_A135CajaAnio ;
      private int[] T000S3_A136CajaSiguiente ;
      private String[] T000S2_A41ClinicaCodigo ;
      private String[] T000S2_A132CajaCodigo ;
      private short[] T000S2_A135CajaAnio ;
      private int[] T000S2_A136CajaSiguiente ;
      private String[] T000S24_A41ClinicaCodigo ;
      private String[] T000S24_A132CajaCodigo ;
      private short[] T000S24_A135CajaAnio ;
      private String[] T000S25_A41ClinicaCodigo ;
      private String[] T000S4_A132CajaCodigo ;
      private String[] T000S4_A133CajaDescripcion ;
      private String[] T000S4_A259CajeroCodigo ;
      private short[] T000S4_A134CajaEstado ;
      private String[] T000S4_A41ClinicaCodigo ;
      private String[] T000S4_A252ResolucionCodigo ;
      private GXWebForm Form ;
      private SdtParametros AV7Parametros ;
      private SdtParametros GXt_SdtParametros6 ;
   }

   public class caja__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new UpdateCursor(def[20])
         ,new UpdateCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000S4 ;
          prmT000S4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000S7 ;
          prmT000S7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000S6 ;
          prmT000S6 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ResolucionCodigo",SqlDbType.VarChar,20,0}
          } ;
          Object[] prmT000S8 ;
          prmT000S8 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ResolucionCodigo",SqlDbType.VarChar,20,0}
          } ;
          Object[] prmT000S9 ;
          prmT000S9 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000S5 ;
          prmT000S5 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000S10 ;
          prmT000S10 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000S11 ;
          prmT000S11 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000S12 ;
          prmT000S12 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000S13 ;
          prmT000S13 = new Object[] {
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@CajeroCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ResolucionCodigo",SqlDbType.VarChar,20,0}
          } ;
          Object[] prmT000S14 ;
          prmT000S14 = new Object[] {
          new Object[] {"@CajaDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@CajeroCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ResolucionCodigo",SqlDbType.VarChar,20,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000S15 ;
          prmT000S15 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000S16 ;
          prmT000S16 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000S17 ;
          prmT000S17 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000S18 ;
          prmT000S18 = new Object[] {
          } ;
          Object[] prmT000S19 ;
          prmT000S19 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S20 ;
          prmT000S20 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S3 ;
          prmT000S3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S2 ;
          prmT000S2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S21 ;
          prmT000S21 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CajaSiguiente",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000S22 ;
          prmT000S22 = new Object[] {
          new Object[] {"@CajaSiguiente",SqlDbType.Int,9,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S23 ;
          prmT000S23 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S24 ;
          prmT000S24 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000S25 ;
          prmT000S25 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ResolucionCodigo",SqlDbType.VarChar,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000S2", "SELECT [ClinicaCodigo], [CajaCodigo], [CajaAnio], [CajaSiguiente] FROM [CajaCorrelativo] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo AND [CajaAnio] = @CajaAnio ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S2,1,0,true,false )
             ,new CursorDef("T000S3", "SELECT [ClinicaCodigo], [CajaCodigo], [CajaAnio], [CajaSiguiente] FROM [CajaCorrelativo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo AND [CajaAnio] = @CajaAnio ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S3,1,0,true,false )
             ,new CursorDef("T000S4", "SELECT [CajaCodigo], [CajaDescripcion], [CajeroCodigo], [CajaEstado], [ClinicaCodigo], [ResolucionCodigo] FROM [Caja] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S4,1,0,true,false )
             ,new CursorDef("T000S5", "SELECT [CajaCodigo], [CajaDescripcion], [CajeroCodigo], [CajaEstado], [ClinicaCodigo], [ResolucionCodigo] FROM [Caja] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S5,1,0,true,false )
             ,new CursorDef("T000S6", "SELECT [ClinicaCodigo] FROM [ResolucionSAT] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ResolucionCodigo] = @ResolucionCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S6,1,0,true,false )
             ,new CursorDef("T000S7", "SELECT TM1.[CajaCodigo], TM1.[CajaDescripcion], TM1.[CajeroCodigo], TM1.[CajaEstado], TM1.[ClinicaCodigo], TM1.[ResolucionCodigo] FROM [Caja] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[CajaCodigo] = @CajaCodigo ORDER BY TM1.[ClinicaCodigo], TM1.[CajaCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000S7,100,0,true,false )
             ,new CursorDef("T000S8", "SELECT [ClinicaCodigo] FROM [ResolucionSAT] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ResolucionCodigo] = @ResolucionCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S8,1,0,true,false )
             ,new CursorDef("T000S9", "SELECT [ClinicaCodigo], [CajaCodigo] FROM [Caja] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000S9,1,0,true,false )
             ,new CursorDef("T000S10", "SELECT TOP 1 [ClinicaCodigo], [CajaCodigo] FROM [Caja] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [CajaCodigo] > @CajaCodigo) ORDER BY [ClinicaCodigo], [CajaCodigo]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000S10,1,0,true,true )
             ,new CursorDef("T000S11", "SELECT TOP 1 [ClinicaCodigo], [CajaCodigo] FROM [Caja] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [CajaCodigo] < @CajaCodigo) ORDER BY [ClinicaCodigo] DESC, [CajaCodigo] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000S11,1,0,true,true )
             ,new CursorDef("T000S12", "SELECT [CajaCodigo], [CajaDescripcion], [CajeroCodigo], [CajaEstado], [ClinicaCodigo], [ResolucionCodigo] FROM [Caja] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S12,1,0,true,false )
             ,new CursorDef("T000S13", "INSERT INTO [Caja] ([CajaCodigo], [CajaDescripcion], [CajeroCodigo], [CajaEstado], [ClinicaCodigo], [ResolucionCodigo]) VALUES (@CajaCodigo, @CajaDescripcion, @CajeroCodigo, @CajaEstado, @ClinicaCodigo, @ResolucionCodigo)", GxErrorMask.GX_NOMASK,prmT000S13)
             ,new CursorDef("T000S14", "UPDATE [Caja] SET [CajaDescripcion]=@CajaDescripcion, [CajeroCodigo]=@CajeroCodigo, [CajaEstado]=@CajaEstado, [ResolucionCodigo]=@ResolucionCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo", GxErrorMask.GX_NOMASK,prmT000S14)
             ,new CursorDef("T000S15", "DELETE FROM [Caja]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo", GxErrorMask.GX_NOMASK,prmT000S15)
             ,new CursorDef("T000S16", "SELECT TOP 1 [ClinicaCodigo], [FacturaId] FROM [Factura] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S16,1,0,true,true )
             ,new CursorDef("T000S17", "SELECT TOP 1 [ClinicaCodigo], [CajaCodigo], [CorteCajaId] FROM [CorteCaja] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S17,1,0,true,true )
             ,new CursorDef("T000S18", "SELECT [ClinicaCodigo], [CajaCodigo] FROM [Caja] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [CajaCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000S18,100,0,true,false )
             ,new CursorDef("T000S19", "SELECT [ClinicaCodigo], [CajaCodigo], [CajaAnio], [CajaSiguiente] FROM [CajaCorrelativo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [CajaCodigo] = @CajaCodigo and [CajaAnio] = @CajaAnio ORDER BY [ClinicaCodigo], [CajaCodigo], [CajaAnio] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S19,11,0,true,false )
             ,new CursorDef("T000S20", "SELECT [ClinicaCodigo], [CajaCodigo], [CajaAnio] FROM [CajaCorrelativo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo AND [CajaAnio] = @CajaAnio ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S20,1,0,true,false )
             ,new CursorDef("T000S21", "INSERT INTO [CajaCorrelativo] ([ClinicaCodigo], [CajaCodigo], [CajaAnio], [CajaSiguiente]) VALUES (@ClinicaCodigo, @CajaCodigo, @CajaAnio, @CajaSiguiente)", GxErrorMask.GX_NOMASK,prmT000S21)
             ,new CursorDef("T000S22", "UPDATE [CajaCorrelativo] SET [CajaSiguiente]=@CajaSiguiente  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo AND [CajaAnio] = @CajaAnio", GxErrorMask.GX_NOMASK,prmT000S22)
             ,new CursorDef("T000S23", "DELETE FROM [CajaCorrelativo]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo AND [CajaAnio] = @CajaAnio", GxErrorMask.GX_NOMASK,prmT000S23)
             ,new CursorDef("T000S24", "SELECT [ClinicaCodigo], [CajaCodigo], [CajaAnio] FROM [CajaCorrelativo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [CajaCodigo] = @CajaCodigo ORDER BY [ClinicaCodigo], [CajaCodigo], [CajaAnio] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S24,11,0,true,false )
             ,new CursorDef("T000S25", "SELECT [ClinicaCodigo] FROM [ResolucionSAT] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ResolucionCodigo] = @ResolucionCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S25,1,0,true,false )
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
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 23 :
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
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 15 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 17 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 18 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 19 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 20 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 21 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 22 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 23 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
