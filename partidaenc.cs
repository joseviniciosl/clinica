/*
               File: PartidaEnc
        Description: Encabezado de partida contable
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:6:21.16
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
   public class partidaenc : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A199TipoParCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_3( A41ClinicaCodigo, A199TipoParCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_4") == 0 )
         {
            A4UsuarioCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_4( A4UsuarioCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_6") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A193CtaContableCodigo = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_6( A41ClinicaCodigo, A193CtaContableCodigo) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridpartidaenc_partidadet") == 0 )
         {
            nRC_Gridpartidaenc_partidadet = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            nGXsfl_90_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_90_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGridpartidaenc_partidadet_newrow( nRC_Gridpartidaenc_partidadet, nGXsfl_90_idx, sGXsfl_90_idx) ;
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
         cmbPartidaMayorizada.Name = "PARTIDAMAYORIZADA" ;
         cmbPartidaMayorizada.WebTags = "" ;
         cmbPartidaMayorizada.addItem("0", "No", 0);
         cmbPartidaMayorizada.addItem("1", "Si", 0);
         if ( ( cmbPartidaMayorizada.ItemCount > 0 ) && (0==A211PartidaMayorizada) )
         {
            A211PartidaMayorizada = (short)(NumberUtil.Val( cmbPartidaMayorizada.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A211PartidaMayorizada", StringUtil.Str( (decimal)(A211PartidaMayorizada), 1, 0));
         }
         cmbPartidaEstado.Name = "PARTIDAESTADO" ;
         cmbPartidaEstado.WebTags = "" ;
         cmbPartidaEstado.addItem("0", "Creada", 0);
         cmbPartidaEstado.addItem("1", "Emitida", 0);
         cmbPartidaEstado.addItem("2", "Cancelada", 0);
         if ( ( cmbPartidaEstado.ItemCount > 0 ) && (0==A289PartidaEstado) )
         {
            A289PartidaEstado = (short)(NumberUtil.Val( cmbPartidaEstado.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PartidaEstado", StringUtil.Str( (decimal)(A289PartidaEstado), 1, 0));
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Encabezado de partida contable", 0) ;
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

      public partidaenc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public partidaenc( IGxContext context )
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
         cmbPartidaMayorizada = new GXCombobox();
         cmbPartidaEstado = new GXCombobox();
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
            wb_table1_2_1553( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1553e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1553( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1553( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1553e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Encabezado de partida contable"+"</legend>") ;
            wb_table3_27_1553( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_1553e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1553e( true) ;
         }
         else
         {
            wb_table1_2_1553e( false) ;
         }
      }

      protected void wb_table3_27_1553( bool wbgen )
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
            wb_table4_33_1553( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_1553e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 97,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_PartidaEnc.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_PartidaEnc.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_PartidaEnc.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_1553e( true) ;
         }
         else
         {
            wb_table3_27_1553e( false) ;
         }
      }

      protected void wb_table4_33_1553( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_PartidaEnc.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_PartidaEnc.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipoparcodigo_Internalname, "Tipo_Partida", "", "", lblTextblocktipoparcodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_PartidaEnc.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTipoParCodigo_Internalname, StringUtil.RTrim( A199TipoParCodigo), StringUtil.RTrim( context.localUtil.Format( A199TipoParCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtTipoParCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtTipoParCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_PartidaEnc.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_199_Internalname, "prompt.gif", imgprompt_41_199_Link, "", "", "Fantastic", imgprompt_41_199_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_PartidaEnc.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpartidaid_Internalname, "Partida", "", "", lblTextblockpartidaid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_PartidaEnc.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PartidaId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPartidaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A207PartidaId), 9, 0, ".", "")), ((edtPartidaId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A207PartidaId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A207PartidaId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(48);\"", "", "", "", "", edtPartidaId_Jsonclick, 0, ClassString, StyleString, "", 1, edtPartidaId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_PartidaEnc.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpartidafecha_Internalname, "Fecha", "", "", lblTextblockpartidafecha_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_PartidaEnc.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A208PartidaFecha", context.localUtil.Format(A208PartidaFecha, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtPartidaFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtPartidaFecha_Internalname, context.localUtil.Format(A208PartidaFecha, "99/99/99"), context.localUtil.Format( A208PartidaFecha, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(53);\"", "", "", "", "", edtPartidaFecha_Jsonclick, 0, ClassString, StyleString, "", 1, edtPartidaFecha_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_PartidaEnc.htm");
            GxWebStd.gx_bitmap( context, edtPartidaFecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtPartidaFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_PartidaEnc.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpartidahora_Internalname, "Hora", "", "", lblTextblockpartidahora_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_PartidaEnc.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A209PartidaHora", A209PartidaHora);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPartidaHora_Internalname, StringUtil.RTrim( A209PartidaHora), StringUtil.RTrim( context.localUtil.Format( A209PartidaHora, "XXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", "", "", "", "", edtPartidaHora_Jsonclick, 0, ClassString, StyleString, "", 1, edtPartidaHora_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "left", "HLP_PartidaEnc.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpartidaobs_Internalname, "Observaciones", "", "", lblTextblockpartidaobs_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_PartidaEnc.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210PartidaObs", A210PartidaObs);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtPartidaObs_Internalname, StringUtil.RTrim( A210PartidaObs), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", 0, 1, edtPartidaObs_Enabled, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_PartidaEnc.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpartidamayorizada_Internalname, "Mayorizada", "", "", lblTextblockpartidamayorizada_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_PartidaEnc.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A211PartidaMayorizada", StringUtil.Str( (decimal)(A211PartidaMayorizada), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbPartidaMayorizada, cmbPartidaMayorizada_Internalname, StringUtil.Str( (decimal)(A211PartidaMayorizada), 1, 0), 1, cmbPartidaMayorizada_Jsonclick, 0, "", "int", "", 1, cmbPartidaMayorizada.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", "", true, "HLP_PartidaEnc.htm");
            cmbPartidaMayorizada.CurrentValue = StringUtil.Str( (decimal)(A211PartidaMayorizada), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPartidaMayorizada_Internalname, "Values", (String)(cmbPartidaMayorizada.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpartidareferencia_Internalname, "Referencia", "", "", lblTextblockpartidareferencia_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_PartidaEnc.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A212PartidaReferencia", A212PartidaReferencia);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPartidaReferencia_Internalname, StringUtil.RTrim( A212PartidaReferencia), StringUtil.RTrim( context.localUtil.Format( A212PartidaReferencia, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(73);\"", "", "", "", "", edtPartidaReferencia_Jsonclick, 0, ClassString, StyleString, "", 1, edtPartidaReferencia_Enabled, 0, 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, true, "left", "HLP_PartidaEnc.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusuariocodigo_Internalname, "Usuario", "", "", lblTextblockusuariocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_PartidaEnc.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUsuarioCodigo_Internalname, StringUtil.RTrim( A4UsuarioCodigo), StringUtil.RTrim( context.localUtil.Format( A4UsuarioCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(78);\"", "", "", "", "", edtUsuarioCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtUsuarioCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_PartidaEnc.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_4_Internalname, "prompt.gif", imgprompt_4_Link, "", "", "Fantastic", imgprompt_4_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_PartidaEnc.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpartidaestado_Internalname, "Estado", "", "", lblTextblockpartidaestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_PartidaEnc.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PartidaEstado", StringUtil.Str( (decimal)(A289PartidaEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbPartidaEstado, cmbPartidaEstado_Internalname, StringUtil.Str( (decimal)(A289PartidaEstado), 1, 0), 1, cmbPartidaEstado_Jsonclick, 0, "", "int", "", 1, cmbPartidaEstado.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(83);\"", "", true, "HLP_PartidaEnc.htm");
            cmbPartidaEstado.CurrentValue = StringUtil.Str( (decimal)(A289PartidaEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPartidaEstado_Internalname, "Values", (String)(cmbPartidaEstado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "<br>") ;
            wb_table5_86_1553( true) ;
         }
         return  ;
      }

      protected void wb_table5_86_1553e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<hr class=\"HRDefault\">") ;
            /*  Grid Control  */
            Gridpartidaenc_partidadetContainer.AddObjectProperty("GridName", "Gridpartidaenc_partidadet");
            Gridpartidaenc_partidadetContainer.AddObjectProperty("Class", "Grid");
            Gridpartidaenc_partidadetContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Gridpartidaenc_partidadetContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Gridpartidaenc_partidadetContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridpartidaenc_partidadet_Backcolorstyle), 1, 0, ".", "")));
            Gridpartidaenc_partidadetContainer.AddObjectProperty("CmpContext", "");
            Gridpartidaenc_partidadetContainer.AddObjectProperty("InMasterPage", "false");
            Gridpartidaenc_partidadetColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridpartidaenc_partidadetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A214PartidaLinea), 4, 0, ".", "")));
            Gridpartidaenc_partidadetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPartidaLinea_Enabled), 5, 0, ".", "")));
            Gridpartidaenc_partidadetContainer.AddColumnProperties(Gridpartidaenc_partidadetColumn);
            Gridpartidaenc_partidadetColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridpartidaenc_partidadetColumn.AddObjectProperty("Value", StringUtil.RTrim( A193CtaContableCodigo));
            Gridpartidaenc_partidadetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCtaContableCodigo_Enabled), 5, 0, ".", "")));
            Gridpartidaenc_partidadetContainer.AddColumnProperties(Gridpartidaenc_partidadetColumn);
            Gridpartidaenc_partidadetColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridpartidaenc_partidadetContainer.AddColumnProperties(Gridpartidaenc_partidadetColumn);
            Gridpartidaenc_partidadetColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridpartidaenc_partidadetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A215PartidaDebe, 17, 2, ".", "")));
            Gridpartidaenc_partidadetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPartidaDebe_Enabled), 5, 0, ".", "")));
            Gridpartidaenc_partidadetContainer.AddColumnProperties(Gridpartidaenc_partidadetColumn);
            Gridpartidaenc_partidadetColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridpartidaenc_partidadetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A216PartidaHaber, 17, 2, ".", "")));
            Gridpartidaenc_partidadetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPartidaHaber_Enabled), 5, 0, ".", "")));
            Gridpartidaenc_partidadetContainer.AddColumnProperties(Gridpartidaenc_partidadetColumn);
            Gridpartidaenc_partidadetContainer.AddObjectProperty("Allowselection", "false");
            Gridpartidaenc_partidadetContainer.AddObjectProperty("Allowcollapsing", ((subGridpartidaenc_partidadet_Allowcollapsing==1) ? "true" : "false"));
            Gridpartidaenc_partidadetContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridpartidaenc_partidadet_Collapsed), 9, 0, ".", "")));
            nGXsfl_90_idx = 0 ;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount54 = 5 ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_54 = 1 ;
                  ScanStart1554( ) ;
                  while ( RcdFound54 != 0 )
                  {
                     init_level_properties54( ) ;
                     getByPrimaryKey1554( ) ;
                     AddRow1554( ) ;
                     ScanNext1554( ) ;
                  }
                  ScanEnd1554( ) ;
                  nBlankRcdCount54 = 5 ;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               standaloneNotModal1554( ) ;
               standaloneModal1554( ) ;
               sMode54 = Gx_mode ;
               while ( nGXsfl_90_idx < nRC_Gridpartidaenc_partidadet )
               {
                  ReadRow1554( ) ;
                  edtPartidaLinea_Enabled = (int)(context.localUtil.CToN( cgiGet( "PARTIDALINEA_"+sGXsfl_90_idx+"Enabled"), ".", ",")) ;
                  edtCtaContableCodigo_Enabled = (int)(context.localUtil.CToN( cgiGet( "CTACONTABLECODIGO_"+sGXsfl_90_idx+"Enabled"), ".", ",")) ;
                  edtPartidaDebe_Enabled = (int)(context.localUtil.CToN( cgiGet( "PARTIDADEBE_"+sGXsfl_90_idx+"Enabled"), ".", ",")) ;
                  edtPartidaHaber_Enabled = (int)(context.localUtil.CToN( cgiGet( "PARTIDAHABER_"+sGXsfl_90_idx+"Enabled"), ".", ",")) ;
                  imgprompt_41_199_Link = cgiGet( "PROMPT_193_"+sGXsfl_90_idx+"Link") ;
                  if ( ( nRcdExists_54 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal1554( ) ;
                  }
                  SendRow1554( ) ;
               }
               Gx_mode = sMode54 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount54 = 5 ;
               nRcdExists_54 = 1 ;
               ScanStart1554( ) ;
               while ( RcdFound54 != 0 )
               {
                  init_level_properties54( ) ;
                  getByPrimaryKey1554( ) ;
                  standaloneNotModal1554( ) ;
                  standaloneModal1554( ) ;
                  AddRow1554( ) ;
                  ScanNext1554( ) ;
               }
               ScanEnd1554( ) ;
            }
            /* Initialize fields for 'new' records and send them. */
            sMode54 = Gx_mode ;
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            InitAll1554( ) ;
            init_level_properties54( ) ;
            standaloneNotModal1554( ) ;
            standaloneModal1554( ) ;
            nRcdExists_54 = 0 ;
            nIsMod_54 = 0 ;
            nBlankRcdCount54 = (short)(nBlankRcdUsr54+nBlankRcdCount54) ;
            fRowAdded = 0 ;
            while ( nBlankRcdCount54 > 0 )
            {
               AddRow1554( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1 ;
                  GX_FocusControl = edtPartidaLinea_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount54 = (short)(nBlankRcdCount54-1) ;
            }
            Gx_mode = sMode54 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            sStyleString = " style=\"display:none;\"" ;
            sStyleString = "" ;
            context.WriteHtmlText( "<div id=\""+"Gridpartidaenc_partidadetContainer"+"Div\" "+sStyleString+">"+"</div>") ;
            context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridpartidaenc_partidadet", (Object)(Gridpartidaenc_partidadetContainer));
            GxWebStd.gx_hidden_field( context, "Gridpartidaenc_partidadetContainerData", Gridpartidaenc_partidadetContainer.ToJavascriptSource());
            if ( context.isAjaxRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Gridpartidaenc_partidadetContainerData"+"V", Gridpartidaenc_partidadetContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridpartidaenc_partidadetContainerData"+"V"+"\" value='"+Gridpartidaenc_partidadetContainer.GridValuesHidden()+"'>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_1553e( true) ;
         }
         else
         {
            wb_table4_33_1553e( false) ;
         }
      }

      protected void wb_table5_86_1553( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTitlepartidadet_Internalname, "Detalle de partida contable", "", "", lblTitlepartidadet_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_PartidaEnc.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_86_1553e( true) ;
         }
         else
         {
            wb_table5_86_1553e( false) ;
         }
      }

      protected void wb_table2_5_1553( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_PartidaEnc.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_PartidaEnc.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_PartidaEnc.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_PartidaEnc.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_PartidaEnc.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_PartidaEnc.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_PartidaEnc.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_PartidaEnc.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01h0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"TIPOPARCODIGO"+"'), id:'"+"TIPOPARCODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"PARTIDAID"+"'), id:'"+"PARTIDAID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_PartidaEnc.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01h0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"TIPOPARCODIGO"+"'), id:'"+"TIPOPARCODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"PARTIDAID"+"'), id:'"+"PARTIDAID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_PartidaEnc.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_PartidaEnc.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_PartidaEnc.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_PartidaEnc.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_PartidaEnc.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_PartidaEnc.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_PartidaEnc.htm");
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
            wb_table2_5_1553e( true) ;
         }
         else
         {
            wb_table2_5_1553e( false) ;
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
               A199TipoParCodigo = cgiGet( edtTipoParCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
               if ( ( ( context.localUtil.CToN( cgiGet( edtPartidaId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPartidaId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PARTIDAID");
                  AnyError = 1 ;
                  GX_FocusControl = edtPartidaId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A207PartidaId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PartidaId), 9, 0)));
               }
               else
               {
                  A207PartidaId = (int)(context.localUtil.CToN( cgiGet( edtPartidaId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PartidaId), 9, 0)));
               }
               if ( context.localUtil.VCDate( cgiGet( edtPartidaFecha_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, "PARTIDAFECHA");
                  AnyError = 1 ;
                  GX_FocusControl = edtPartidaFecha_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A208PartidaFecha = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A208PartidaFecha", context.localUtil.Format(A208PartidaFecha, "99/99/99"));
               }
               else
               {
                  A208PartidaFecha = context.localUtil.CToD( cgiGet( edtPartidaFecha_Internalname), 2) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A208PartidaFecha", context.localUtil.Format(A208PartidaFecha, "99/99/99"));
               }
               A209PartidaHora = cgiGet( edtPartidaHora_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A209PartidaHora", A209PartidaHora);
               A210PartidaObs = cgiGet( edtPartidaObs_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210PartidaObs", A210PartidaObs);
               cmbPartidaMayorizada.Name = cmbPartidaMayorizada_Internalname ;
               cmbPartidaMayorizada.CurrentValue = cgiGet( cmbPartidaMayorizada_Internalname) ;
               A211PartidaMayorizada = (short)(NumberUtil.Val( cgiGet( cmbPartidaMayorizada_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A211PartidaMayorizada", StringUtil.Str( (decimal)(A211PartidaMayorizada), 1, 0));
               A212PartidaReferencia = cgiGet( edtPartidaReferencia_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A212PartidaReferencia", A212PartidaReferencia);
               A4UsuarioCodigo = cgiGet( edtUsuarioCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
               cmbPartidaEstado.Name = cmbPartidaEstado_Internalname ;
               cmbPartidaEstado.CurrentValue = cgiGet( cmbPartidaEstado_Internalname) ;
               A289PartidaEstado = (short)(NumberUtil.Val( cgiGet( cmbPartidaEstado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PartidaEstado", StringUtil.Str( (decimal)(A289PartidaEstado), 1, 0));
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z199TipoParCodigo = cgiGet( "Z199TipoParCodigo") ;
               Z207PartidaId = (int)(context.localUtil.CToN( cgiGet( "Z207PartidaId"), ".", ",")) ;
               Z208PartidaFecha = context.localUtil.CToD( cgiGet( "Z208PartidaFecha"), 0) ;
               Z209PartidaHora = cgiGet( "Z209PartidaHora") ;
               Z210PartidaObs = cgiGet( "Z210PartidaObs") ;
               Z211PartidaMayorizada = (short)(context.localUtil.CToN( cgiGet( "Z211PartidaMayorizada"), ".", ",")) ;
               Z212PartidaReferencia = cgiGet( "Z212PartidaReferencia") ;
               Z289PartidaEstado = (short)(context.localUtil.CToN( cgiGet( "Z289PartidaEstado"), ".", ",")) ;
               Z4UsuarioCodigo = cgiGet( "Z4UsuarioCodigo") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               nRC_Gridpartidaenc_partidadet = (short)(context.localUtil.CToN( cgiGet( "nRC_Gridpartidaenc_partidadet"), ".", ",")) ;
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
                  A199TipoParCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
                  A207PartidaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PartidaId), 9, 0)));
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
               InitAll1553( ) ;
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
         DisableAttributes1553( ) ;
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

      protected void CONFIRM_1554( )
      {
         nGXsfl_90_idx = 0 ;
         while ( nGXsfl_90_idx < nRC_Gridpartidaenc_partidadet )
         {
            ReadRow1554( ) ;
            if ( ( nRcdExists_54 != 0 ) || ( nIsMod_54 != 0 ) )
            {
               GetKey1554( ) ;
               if ( ( nRcdExists_54 == 0 ) && ( nRcdDeleted_54 == 0 ) )
               {
                  if ( RcdFound54 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate1554( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable1554( ) ;
                        CloseExtendedTableCursors1554( ) ;
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
                     GX_FocusControl = edtPartidaLinea_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound54 != 0 )
                  {
                     if ( nRcdDeleted_54 != 0 )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey1554( ) ;
                        Load1554( ) ;
                        BeforeValidate1554( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls1554( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_54 != 0 )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate1554( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable1554( ) ;
                              CloseExtendedTableCursors1554( ) ;
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
                     if ( nRcdDeleted_54 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtPartidaLinea_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtPartidaLinea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A214PartidaLinea), 4, 0, ".", ""))) ;
            ChangePostValue( edtCtaContableCodigo_Internalname, StringUtil.RTrim( A193CtaContableCodigo)) ;
            ChangePostValue( edtPartidaDebe_Internalname, StringUtil.LTrim( StringUtil.NToC( A215PartidaDebe, 17, 2, ".", ""))) ;
            ChangePostValue( edtPartidaHaber_Internalname, StringUtil.LTrim( StringUtil.NToC( A216PartidaHaber, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z214PartidaLinea_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z214PartidaLinea), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z215PartidaDebe_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( Z215PartidaDebe, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z216PartidaHaber_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( Z216PartidaHaber, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z193CtaContableCodigo_"+sGXsfl_90_idx, StringUtil.RTrim( Z193CtaContableCodigo)) ;
            ChangePostValue( "nRcdDeleted_54_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_54), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_54_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_54), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_54_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_54), 4, 0, ".", ""))) ;
            if ( nIsMod_54 != 0 )
            {
               ChangePostValue( "PARTIDALINEA_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPartidaLinea_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CTACONTABLECODIGO_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCtaContableCodigo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PARTIDADEBE_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPartidaDebe_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PARTIDAHABER_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPartidaHaber_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption150( )
      {
      }

      protected void ZM1553( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z208PartidaFecha = T00156_A208PartidaFecha[0] ;
               Z209PartidaHora = T00156_A209PartidaHora[0] ;
               Z210PartidaObs = T00156_A210PartidaObs[0] ;
               Z211PartidaMayorizada = T00156_A211PartidaMayorizada[0] ;
               Z212PartidaReferencia = T00156_A212PartidaReferencia[0] ;
               Z289PartidaEstado = T00156_A289PartidaEstado[0] ;
               Z4UsuarioCodigo = T00156_A4UsuarioCodigo[0] ;
            }
            else
            {
               Z208PartidaFecha = A208PartidaFecha ;
               Z209PartidaHora = A209PartidaHora ;
               Z210PartidaObs = A210PartidaObs ;
               Z211PartidaMayorizada = A211PartidaMayorizada ;
               Z212PartidaReferencia = A212PartidaReferencia ;
               Z289PartidaEstado = A289PartidaEstado ;
               Z4UsuarioCodigo = A4UsuarioCodigo ;
            }
         }
         if ( GX_JID == -2 )
         {
            Z207PartidaId = A207PartidaId ;
            Z208PartidaFecha = A208PartidaFecha ;
            Z209PartidaHora = A209PartidaHora ;
            Z210PartidaObs = A210PartidaObs ;
            Z211PartidaMayorizada = A211PartidaMayorizada ;
            Z212PartidaReferencia = A212PartidaReferencia ;
            Z289PartidaEstado = A289PartidaEstado ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z199TipoParCodigo = A199TipoParCodigo ;
            Z4UsuarioCodigo = A4UsuarioCodigo ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_41_199_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx01f0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"TIPOPARCODIGO"+"'), id:'"+"TIPOPARCODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"true"+");") ;
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

      protected void Load1553( )
      {
         /* Using cursor T00159 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound53 = 1 ;
            A208PartidaFecha = T00159_A208PartidaFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A208PartidaFecha", context.localUtil.Format(A208PartidaFecha, "99/99/99"));
            A209PartidaHora = T00159_A209PartidaHora[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A209PartidaHora", A209PartidaHora);
            A210PartidaObs = T00159_A210PartidaObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210PartidaObs", A210PartidaObs);
            A211PartidaMayorizada = T00159_A211PartidaMayorizada[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A211PartidaMayorizada", StringUtil.Str( (decimal)(A211PartidaMayorizada), 1, 0));
            A212PartidaReferencia = T00159_A212PartidaReferencia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A212PartidaReferencia", A212PartidaReferencia);
            A289PartidaEstado = T00159_A289PartidaEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PartidaEstado", StringUtil.Str( (decimal)(A289PartidaEstado), 1, 0));
            A4UsuarioCodigo = T00159_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            ZM1553( -2) ;
         }
         pr_default.close(7);
         OnLoadActions1553( ) ;
      }

      protected void OnLoadActions1553( )
      {
      }

      protected void CheckExtendedTable1553( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T00157 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A199TipoParCodigo});
         if ( (pr_default.getStatus(5) == 101) )
         {
            AnyError41 = 1 ;
            AnyError199 = 1 ;
            GX_msglist.addItem("No existe 'Tipos de Partidas Contables'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError199 == 0 ) )
         {
         }
         pr_default.close(5);
         if ( ! ( (DateTime.MinValue==A208PartidaFecha) || ( A208PartidaFecha >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         /* Using cursor T00158 */
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

      protected void CloseExtendedTableCursors1553( )
      {
         pr_default.close(5);
         pr_default.close(6);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_3( String A41ClinicaCodigo ,
                               String A199TipoParCodigo )
      {
         /* Using cursor T001510 */
         pr_default.execute(8, new Object[] {A41ClinicaCodigo, A199TipoParCodigo});
         if ( (pr_default.getStatus(8) == 101) )
         {
            AnyError41 = 1 ;
            AnyError199 = 1 ;
            GX_msglist.addItem("No existe 'Tipos de Partidas Contables'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError199 == 0 ) )
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

      protected void gxLoad_4( String A4UsuarioCodigo )
      {
         /* Using cursor T001511 */
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

      protected void GetKey1553( )
      {
         /* Using cursor T001512 */
         pr_default.execute(10, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId});
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound53 = 1 ;
         }
         else
         {
            RcdFound53 = 0 ;
         }
         pr_default.close(10);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00156 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM1553( 2) ;
            RcdFound53 = 1 ;
            A207PartidaId = T00156_A207PartidaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PartidaId), 9, 0)));
            A208PartidaFecha = T00156_A208PartidaFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A208PartidaFecha", context.localUtil.Format(A208PartidaFecha, "99/99/99"));
            A209PartidaHora = T00156_A209PartidaHora[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A209PartidaHora", A209PartidaHora);
            A210PartidaObs = T00156_A210PartidaObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210PartidaObs", A210PartidaObs);
            A211PartidaMayorizada = T00156_A211PartidaMayorizada[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A211PartidaMayorizada", StringUtil.Str( (decimal)(A211PartidaMayorizada), 1, 0));
            A212PartidaReferencia = T00156_A212PartidaReferencia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A212PartidaReferencia", A212PartidaReferencia);
            A289PartidaEstado = T00156_A289PartidaEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PartidaEstado", StringUtil.Str( (decimal)(A289PartidaEstado), 1, 0));
            A41ClinicaCodigo = T00156_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A199TipoParCodigo = T00156_A199TipoParCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
            A4UsuarioCodigo = T00156_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z199TipoParCodigo = A199TipoParCodigo ;
            Z207PartidaId = A207PartidaId ;
            sMode53 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1553( ) ;
            Gx_mode = sMode53 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound53 = 0 ;
            InitializeNonKey1553( ) ;
            sMode53 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode53 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey1553( ) ;
         if ( RcdFound53 == 0 )
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
         RcdFound53 = 0 ;
         /* Using cursor T001513 */
         pr_default.execute(11, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( StringUtil.StrCmp(T001513_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001513_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001513_A199TipoParCodigo[0], A199TipoParCodigo) < 0 ) || ( StringUtil.StrCmp(T001513_A199TipoParCodigo[0], A199TipoParCodigo) == 0 ) && ( StringUtil.StrCmp(T001513_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001513_A207PartidaId[0] < A207PartidaId ) ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( StringUtil.StrCmp(T001513_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001513_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001513_A199TipoParCodigo[0], A199TipoParCodigo) > 0 ) || ( StringUtil.StrCmp(T001513_A199TipoParCodigo[0], A199TipoParCodigo) == 0 ) && ( StringUtil.StrCmp(T001513_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001513_A207PartidaId[0] > A207PartidaId ) ) )
            {
               A41ClinicaCodigo = T001513_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A199TipoParCodigo = T001513_A199TipoParCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
               A207PartidaId = T001513_A207PartidaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PartidaId), 9, 0)));
               RcdFound53 = 1 ;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound53 = 0 ;
         /* Using cursor T001514 */
         pr_default.execute(12, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId});
         if ( (pr_default.getStatus(12) != 101) )
         {
            while ( (pr_default.getStatus(12) != 101) && ( ( StringUtil.StrCmp(T001514_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001514_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001514_A199TipoParCodigo[0], A199TipoParCodigo) > 0 ) || ( StringUtil.StrCmp(T001514_A199TipoParCodigo[0], A199TipoParCodigo) == 0 ) && ( StringUtil.StrCmp(T001514_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001514_A207PartidaId[0] > A207PartidaId ) ) )
            {
               pr_default.readNext(12);
            }
            if ( (pr_default.getStatus(12) != 101) && ( ( StringUtil.StrCmp(T001514_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001514_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001514_A199TipoParCodigo[0], A199TipoParCodigo) < 0 ) || ( StringUtil.StrCmp(T001514_A199TipoParCodigo[0], A199TipoParCodigo) == 0 ) && ( StringUtil.StrCmp(T001514_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001514_A207PartidaId[0] < A207PartidaId ) ) )
            {
               A41ClinicaCodigo = T001514_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A199TipoParCodigo = T001514_A199TipoParCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
               A207PartidaId = T001514_A207PartidaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PartidaId), 9, 0)));
               RcdFound53 = 1 ;
            }
         }
         pr_default.close(3);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1553( ) ;
         if ( RcdFound53 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A199TipoParCodigo, Z199TipoParCodigo) != 0 ) || ( A207PartidaId != Z207PartidaId ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A199TipoParCodigo = Z199TipoParCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
               A207PartidaId = Z207PartidaId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PartidaId), 9, 0)));
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
               Update1553( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A199TipoParCodigo, Z199TipoParCodigo) != 0 ) || ( A207PartidaId != Z207PartidaId ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert1553( ) ;
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
                  Insert1553( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A199TipoParCodigo, Z199TipoParCodigo) != 0 ) || ( A207PartidaId != Z207PartidaId ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A199TipoParCodigo = Z199TipoParCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
            A207PartidaId = Z207PartidaId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PartidaId), 9, 0)));
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
         if ( RcdFound53 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtPartidaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1553( ) ;
         if ( RcdFound53 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtPartidaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1553( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound53 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtPartidaFecha_Internalname ;
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
         if ( RcdFound53 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtPartidaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1553( ) ;
         if ( RcdFound53 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound53 != 0 )
            {
               ScanNext1553( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtPartidaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1553( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1553( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001515 */
            pr_default.execute(13, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId});
            if ( (pr_default.getStatus(13) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PartidaEnc"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(13) == 101) || ( Z208PartidaFecha != T001515_A208PartidaFecha[0] ) || ( StringUtil.StrCmp(Z209PartidaHora, T001515_A209PartidaHora[0]) != 0 ) || ( StringUtil.StrCmp(Z210PartidaObs, T001515_A210PartidaObs[0]) != 0 ) || ( Z211PartidaMayorizada != T001515_A211PartidaMayorizada[0] ) || ( StringUtil.StrCmp(Z212PartidaReferencia, T001515_A212PartidaReferencia[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z289PartidaEstado != T001515_A289PartidaEstado[0] ) || ( StringUtil.StrCmp(Z4UsuarioCodigo, T001515_A4UsuarioCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"PartidaEnc"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1553( )
      {
         BeforeValidate1553( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1553( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1553( 0) ;
            CheckOptimisticConcurrency1553( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1553( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1553( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001516 */
                     pr_default.execute(14, new Object[] {A207PartidaId, A208PartidaFecha, A209PartidaHora, A210PartidaObs, A211PartidaMayorizada, A212PartidaReferencia, A289PartidaEstado, A41ClinicaCodigo, A199TipoParCodigo, A4UsuarioCodigo});
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
                           ProcessLevel1553( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                              ResetCaption150( ) ;
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
               Load1553( ) ;
            }
            EndLevel1553( ) ;
         }
         CloseExtendedTableCursors1553( ) ;
      }

      protected void Update1553( )
      {
         BeforeValidate1553( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1553( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1553( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1553( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1553( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001517 */
                     pr_default.execute(15, new Object[] {A208PartidaFecha, A209PartidaHora, A210PartidaObs, A211PartidaMayorizada, A212PartidaReferencia, A289PartidaEstado, A4UsuarioCodigo, A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId});
                     pr_default.close(15);
                     if ( (pr_default.getStatus(15) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PartidaEnc"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1553( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel1553( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                              ResetCaption150( ) ;
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
            EndLevel1553( ) ;
         }
         CloseExtendedTableCursors1553( ) ;
      }

      protected void DeferredUpdate1553( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1553( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1553( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1553( ) ;
            AfterConfirm1553( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1553( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart1554( ) ;
                  while ( RcdFound54 != 0 )
                  {
                     getByPrimaryKey1554( ) ;
                     Delete1554( ) ;
                     ScanNext1554( ) ;
                  }
                  ScanEnd1554( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001518 */
                     pr_default.execute(16, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId});
                     pr_default.close(16);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound53 == 0 )
                           {
                              InitAll1553( ) ;
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
                           ResetCaption150( ) ;
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
         sMode53 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1553( ) ;
         Gx_mode = sMode53 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1553( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void ProcessNestedLevel1554( )
      {
         nGXsfl_90_idx = 0 ;
         while ( nGXsfl_90_idx < nRC_Gridpartidaenc_partidadet )
         {
            ReadRow1554( ) ;
            if ( ( nRcdExists_54 != 0 ) || ( nIsMod_54 != 0 ) )
            {
               standaloneNotModal1554( ) ;
               GetKey1554( ) ;
               if ( ( nRcdExists_54 == 0 ) && ( nRcdDeleted_54 == 0 ) )
               {
                  if ( RcdFound54 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Insert1554( ) ;
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtPartidaLinea_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound54 != 0 )
                  {
                     if ( ( nRcdDeleted_54 != 0 ) && ( nRcdExists_54 != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete1554( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_54 != 0 ) && ( nRcdExists_54 != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update1554( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_54 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtPartidaLinea_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtPartidaLinea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A214PartidaLinea), 4, 0, ".", ""))) ;
            ChangePostValue( edtCtaContableCodigo_Internalname, StringUtil.RTrim( A193CtaContableCodigo)) ;
            ChangePostValue( edtPartidaDebe_Internalname, StringUtil.LTrim( StringUtil.NToC( A215PartidaDebe, 17, 2, ".", ""))) ;
            ChangePostValue( edtPartidaHaber_Internalname, StringUtil.LTrim( StringUtil.NToC( A216PartidaHaber, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z214PartidaLinea_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z214PartidaLinea), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z215PartidaDebe_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( Z215PartidaDebe, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z216PartidaHaber_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( Z216PartidaHaber, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z193CtaContableCodigo_"+sGXsfl_90_idx, StringUtil.RTrim( Z193CtaContableCodigo)) ;
            ChangePostValue( "nRcdDeleted_54_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_54), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_54_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_54), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_54_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_54), 4, 0, ".", ""))) ;
            if ( nIsMod_54 != 0 )
            {
               ChangePostValue( "PARTIDALINEA_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPartidaLinea_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CTACONTABLECODIGO_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCtaContableCodigo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PARTIDADEBE_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPartidaDebe_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PARTIDAHABER_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPartidaHaber_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll1554( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_54 = 0 ;
         nIsMod_54 = 0 ;
         nRcdDeleted_54 = 0 ;
      }

      protected void ProcessLevel1553( )
      {
         /* Save parent mode. */
         sMode53 = Gx_mode ;
         ProcessNestedLevel1554( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode53 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel1553( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(13);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1553( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(12);
            pr_default.close(11);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(2);
            context.CommitDataStores("PartidaEnc");
            if ( AnyError == 0 )
            {
               ConfirmValues150( ) ;
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
            context.RollbackDataStores("PartidaEnc");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1553( )
      {
         /* Using cursor T001519 */
         pr_default.execute(17);
         RcdFound53 = 0 ;
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound53 = 1 ;
            A41ClinicaCodigo = T001519_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A199TipoParCodigo = T001519_A199TipoParCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
            A207PartidaId = T001519_A207PartidaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PartidaId), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1553( )
      {
         pr_default.readNext(17);
         RcdFound53 = 0 ;
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound53 = 1 ;
            A41ClinicaCodigo = T001519_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A199TipoParCodigo = T001519_A199TipoParCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
            A207PartidaId = T001519_A207PartidaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PartidaId), 9, 0)));
         }
      }

      protected void ScanEnd1553( )
      {
      }

      protected void AfterConfirm1553( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1553( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1553( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1553( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1553( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1553( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1553( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtTipoParCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoParCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoParCodigo_Enabled), 5, 0)));
         edtPartidaId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPartidaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPartidaId_Enabled), 5, 0)));
         edtPartidaFecha_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPartidaFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPartidaFecha_Enabled), 5, 0)));
         edtPartidaHora_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPartidaHora_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPartidaHora_Enabled), 5, 0)));
         edtPartidaObs_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPartidaObs_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPartidaObs_Enabled), 5, 0)));
         cmbPartidaMayorizada.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPartidaMayorizada_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbPartidaMayorizada.Enabled), 5, 0)));
         edtPartidaReferencia_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPartidaReferencia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPartidaReferencia_Enabled), 5, 0)));
         edtUsuarioCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioCodigo_Enabled), 5, 0)));
         cmbPartidaEstado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPartidaEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbPartidaEstado.Enabled), 5, 0)));
      }

      protected void ZM1554( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z215PartidaDebe = T00153_A215PartidaDebe[0] ;
               Z216PartidaHaber = T00153_A216PartidaHaber[0] ;
               Z193CtaContableCodigo = T00153_A193CtaContableCodigo[0] ;
            }
            else
            {
               Z215PartidaDebe = A215PartidaDebe ;
               Z216PartidaHaber = A216PartidaHaber ;
               Z193CtaContableCodigo = A193CtaContableCodigo ;
            }
         }
         if ( GX_JID == -5 )
         {
            Z199TipoParCodigo = A199TipoParCodigo ;
            Z207PartidaId = A207PartidaId ;
            Z214PartidaLinea = A214PartidaLinea ;
            Z215PartidaDebe = A215PartidaDebe ;
            Z216PartidaHaber = A216PartidaHaber ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z193CtaContableCodigo = A193CtaContableCodigo ;
         }
      }

      protected void standaloneNotModal1554( )
      {
      }

      protected void standaloneModal1554( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtPartidaLinea_Enabled = 0 ;
         }
         else
         {
            edtPartidaLinea_Enabled = 1 ;
         }
         if ( ( StringUtil.StrCmp(sMode54, "DSP") == 0 ) || ( StringUtil.StrCmp(sMode54, "DLT") == 0 ) )
         {
            DisableAttributes1554( ) ;
         }
      }

      protected void Load1554( )
      {
         /* Using cursor T001520 */
         pr_default.execute(18, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId, A214PartidaLinea});
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound54 = 1 ;
            A215PartidaDebe = T001520_A215PartidaDebe[0] ;
            A216PartidaHaber = T001520_A216PartidaHaber[0] ;
            A193CtaContableCodigo = T001520_A193CtaContableCodigo[0] ;
            ZM1554( -5) ;
         }
         pr_default.close(18);
         OnLoadActions1554( ) ;
      }

      protected void OnLoadActions1554( )
      {
      }

      protected void CheckExtendedTable1554( )
      {
         Gx_BScreen = 1 ;
         standaloneModal1554( ) ;
         /* Using cursor T00154 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError41 = 1 ;
            AnyError193 = 1 ;
            GX_msglist.addItem("No existe 'Catálogo de Cuentas Contables'.", "ForeignKeyNotFound", 1, "CTACONTABLECODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtCtaContableCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError193 == 0 ) )
         {
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors1554( )
      {
         pr_default.close(2);
      }

      protected void enableDisable1554( )
      {
      }

      protected void gxLoad_6( String A41ClinicaCodigo ,
                               String A193CtaContableCodigo )
      {
         /* Using cursor T001521 */
         pr_default.execute(19, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
         if ( (pr_default.getStatus(19) == 101) )
         {
            AnyError41 = 1 ;
            AnyError193 = 1 ;
            GX_msglist.addItem("No existe 'Catálogo de Cuentas Contables'.", "ForeignKeyNotFound", 1, "CTACONTABLECODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtCtaContableCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError193 == 0 ) )
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

      protected void GetKey1554( )
      {
         /* Using cursor T001522 */
         pr_default.execute(20, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId, A214PartidaLinea});
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound54 = 1 ;
         }
         else
         {
            RcdFound54 = 0 ;
         }
         pr_default.close(20);
      }

      protected void getByPrimaryKey1554( )
      {
         /* Using cursor T00153 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId, A214PartidaLinea});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1554( 5) ;
            RcdFound54 = 1 ;
            InitializeNonKey1554( ) ;
            A214PartidaLinea = T00153_A214PartidaLinea[0] ;
            A215PartidaDebe = T00153_A215PartidaDebe[0] ;
            A216PartidaHaber = T00153_A216PartidaHaber[0] ;
            A193CtaContableCodigo = T00153_A193CtaContableCodigo[0] ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z199TipoParCodigo = A199TipoParCodigo ;
            Z207PartidaId = A207PartidaId ;
            Z214PartidaLinea = A214PartidaLinea ;
            sMode54 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal1554( ) ;
            Load1554( ) ;
            Gx_mode = sMode54 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound54 = 0 ;
            InitializeNonKey1554( ) ;
            sMode54 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal1554( ) ;
            Gx_mode = sMode54 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency1554( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00152 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId, A214PartidaLinea});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PartidaDet"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z215PartidaDebe != T00152_A215PartidaDebe[0] ) || ( Z216PartidaHaber != T00152_A216PartidaHaber[0] ) || ( StringUtil.StrCmp(Z193CtaContableCodigo, T00152_A193CtaContableCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"PartidaDet"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1554( )
      {
         BeforeValidate1554( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1554( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1554( 0) ;
            CheckOptimisticConcurrency1554( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1554( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1554( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001523 */
                     pr_default.execute(21, new Object[] {A199TipoParCodigo, A207PartidaId, A214PartidaLinea, A215PartidaDebe, A216PartidaHaber, A41ClinicaCodigo, A193CtaContableCodigo});
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
               Load1554( ) ;
            }
            EndLevel1554( ) ;
         }
         CloseExtendedTableCursors1554( ) ;
      }

      protected void Update1554( )
      {
         BeforeValidate1554( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1554( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1554( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1554( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1554( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001524 */
                     pr_default.execute(22, new Object[] {A215PartidaDebe, A216PartidaHaber, A193CtaContableCodigo, A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId, A214PartidaLinea});
                     pr_default.close(22);
                     if ( (pr_default.getStatus(22) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PartidaDet"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1554( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey1554( ) ;
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
            EndLevel1554( ) ;
         }
         CloseExtendedTableCursors1554( ) ;
      }

      protected void DeferredUpdate1554( )
      {
      }

      protected void Delete1554( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1554( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1554( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1554( ) ;
            AfterConfirm1554( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1554( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001525 */
                  pr_default.execute(23, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId, A214PartidaLinea});
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
         sMode54 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1554( ) ;
         Gx_mode = sMode54 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1554( )
      {
         standaloneModal1554( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1554( )
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

      protected void ScanStart1554( )
      {
         /* Using cursor T001526 */
         pr_default.execute(24, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId});
         RcdFound54 = 0 ;
         if ( (pr_default.getStatus(24) != 101) )
         {
            RcdFound54 = 1 ;
            A214PartidaLinea = T001526_A214PartidaLinea[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1554( )
      {
         pr_default.readNext(24);
         RcdFound54 = 0 ;
         if ( (pr_default.getStatus(24) != 101) )
         {
            RcdFound54 = 1 ;
            A214PartidaLinea = T001526_A214PartidaLinea[0] ;
         }
      }

      protected void ScanEnd1554( )
      {
         pr_default.close(1);
      }

      protected void AfterConfirm1554( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1554( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1554( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1554( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1554( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1554( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1554( )
      {
         edtPartidaLinea_Enabled = 0 ;
         edtCtaContableCodigo_Enabled = 0 ;
         edtPartidaDebe_Enabled = 0 ;
         edtPartidaHaber_Enabled = 0 ;
      }

      protected void AddRow1554( )
      {
         nGXsfl_90_idx = (short)(nGXsfl_90_idx+1) ;
         sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0") ;
         edtPartidaLinea_Internalname = "PARTIDALINEA_"+sGXsfl_90_idx ;
         edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_90_idx ;
         imgprompt_193_Internalname = "PROMPT_193_"+sGXsfl_90_idx ;
         edtPartidaDebe_Internalname = "PARTIDADEBE_"+sGXsfl_90_idx ;
         edtPartidaHaber_Internalname = "PARTIDAHABER_"+sGXsfl_90_idx ;
         SendRow1554( ) ;
      }

      protected void SendRow1554( )
      {
         Gridpartidaenc_partidadetRow = GXWebRow.GetNew(context) ;
         if ( subGridpartidaenc_partidadet_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridpartidaenc_partidadet_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGridpartidaenc_partidadet_Class, "") != 0 )
            {
               subGridpartidaenc_partidadet_Linesclass = subGridpartidaenc_partidadet_Class+"Odd" ;
            }
         }
         else if ( subGridpartidaenc_partidadet_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridpartidaenc_partidadet_Backstyle = 0 ;
            subGridpartidaenc_partidadet_Backcolor = subGridpartidaenc_partidadet_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridpartidaenc_partidadetContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridpartidaenc_partidadet_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGridpartidaenc_partidadet_Class, "") != 0 )
            {
               subGridpartidaenc_partidadet_Linesclass = subGridpartidaenc_partidadet_Class+"Uniform" ;
            }
         }
         else if ( subGridpartidaenc_partidadet_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridpartidaenc_partidadet_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGridpartidaenc_partidadet_Class, "") != 0 )
            {
               subGridpartidaenc_partidadet_Linesclass = subGridpartidaenc_partidadet_Class+"Odd" ;
            }
            subGridpartidaenc_partidadet_Backcolor = (int)(0xFFFFFF) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridpartidaenc_partidadetContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridpartidaenc_partidadet_Backcolor), 9, 0)));
         }
         else if ( subGridpartidaenc_partidadet_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridpartidaenc_partidadet_Backstyle = 1 ;
            if ( ((int)(nGXsfl_90_idx) % (2)) == 0 )
            {
               subGridpartidaenc_partidadet_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridpartidaenc_partidadetContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridpartidaenc_partidadet_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridpartidaenc_partidadet_Class, "") != 0 )
               {
                  subGridpartidaenc_partidadet_Linesclass = subGridpartidaenc_partidadet_Class+"Even" ;
               }
            }
            else
            {
               subGridpartidaenc_partidadet_Backcolor = (int)(0xFFFFFF) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridpartidaenc_partidadetContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridpartidaenc_partidadet_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridpartidaenc_partidadet_Class, "") != 0 )
               {
                  subGridpartidaenc_partidadet_Linesclass = subGridpartidaenc_partidadet_Class+"Odd" ;
               }
            }
         }
         imgprompt_193_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx01e1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+"}"+","+"{Ctrl:gx.dom.el('"+"CTACONTABLECODIGO_"+sGXsfl_90_idx+"'), id:'"+"CTACONTABLECODIGO_"+sGXsfl_90_idx+"'"+",isOut: true}"+"],"+"gx.dom.form()."+"nIsMod_54_"+sGXsfl_90_idx+","+"'', false"+","+"false"+");") ;
         /* * Property Link not supported in */
         /* * Property Link not supported in */
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_54_" + sGXsfl_90_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 91,'',false,'" + sGXsfl_90_idx + "',90)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridpartidaenc_partidadetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPartidaLinea_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A214PartidaLinea), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A214PartidaLinea), "ZZZ9")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(91);\"",(String)"",(String)"",(String)"",(String)"",(String)edtPartidaLinea_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtPartidaLinea_Enabled,(short)1,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)90,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_54_" + sGXsfl_90_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 92,'',false,'" + sGXsfl_90_idx + "',90)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridpartidaenc_partidadetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCtaContableCodigo_Internalname,StringUtil.RTrim( A193CtaContableCodigo),(String)"",TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(92);\"",(String)"",(String)"",(String)"",(String)"",(String)edtCtaContableCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtCtaContableCodigo_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)90,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "Image" ;
         StyleString = "" ;
         Gridpartidaenc_partidadetRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_193_Internalname,"prompt.gif",(String)imgprompt_193_Link,(String)"",(String)"",(String)"Fantastic",(int)imgprompt_193_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_54_" + sGXsfl_90_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 93,'',false,'" + sGXsfl_90_idx + "',90)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridpartidaenc_partidadetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPartidaDebe_Internalname,StringUtil.LTrim( StringUtil.NToC( A215PartidaDebe, 17, 2, ".", "")),((edtPartidaDebe_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A215PartidaDebe, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A215PartidaDebe, "ZZZZZZZZZZZZZ9.99")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(93);\"",(String)"",(String)"",(String)"",(String)"",(String)edtPartidaDebe_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtPartidaDebe_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)90,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_54_" + sGXsfl_90_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 94,'',false,'" + sGXsfl_90_idx + "',90)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridpartidaenc_partidadetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPartidaHaber_Internalname,StringUtil.LTrim( StringUtil.NToC( A216PartidaHaber, 17, 2, ".", "")),((edtPartidaHaber_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A216PartidaHaber, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A216PartidaHaber, "ZZZZZZZZZZZZZ9.99")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(94);\"",(String)"",(String)"",(String)"",(String)"",(String)edtPartidaHaber_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtPartidaHaber_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)90,(short)1,(short)-1,(bool)true,(String)"right"});
         context.httpAjaxContext.ajax_sending_grid_row(Gridpartidaenc_partidadetRow);
         GXCCtl = "Z214PartidaLinea_" + sGXsfl_90_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z214PartidaLinea), 4, 0, ".", "")));
         GXCCtl = "Z215PartidaDebe_" + sGXsfl_90_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z215PartidaDebe, 17, 2, ".", "")));
         GXCCtl = "Z216PartidaHaber_" + sGXsfl_90_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z216PartidaHaber, 17, 2, ".", "")));
         GXCCtl = "Z193CtaContableCodigo_" + sGXsfl_90_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z193CtaContableCodigo));
         GXCCtl = "nRcdDeleted_54_" + sGXsfl_90_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_54), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_54_" + sGXsfl_90_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_54), 4, 0, ".", "")));
         GXCCtl = "nIsMod_54_" + sGXsfl_90_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_54), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PARTIDALINEA_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPartidaLinea_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CTACONTABLECODIGO_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCtaContableCodigo_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PARTIDADEBE_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPartidaDebe_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PARTIDAHABER_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPartidaHaber_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_193_"+sGXsfl_90_idx+"Link", StringUtil.RTrim( imgprompt_193_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridpartidaenc_partidadetContainer.AddRow(Gridpartidaenc_partidadetRow);
      }

      protected void ReadRow1554( )
      {
         nGXsfl_90_idx = (short)(nGXsfl_90_idx+1) ;
         sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0") ;
         edtPartidaLinea_Internalname = "PARTIDALINEA_"+sGXsfl_90_idx ;
         edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_90_idx ;
         imgprompt_193_Internalname = "PROMPT_193_"+sGXsfl_90_idx ;
         edtPartidaDebe_Internalname = "PARTIDADEBE_"+sGXsfl_90_idx ;
         edtPartidaHaber_Internalname = "PARTIDAHABER_"+sGXsfl_90_idx ;
         edtPartidaLinea_Enabled = (int)(context.localUtil.CToN( cgiGet( "PARTIDALINEA_"+sGXsfl_90_idx+"Enabled"), ".", ",")) ;
         edtCtaContableCodigo_Enabled = (int)(context.localUtil.CToN( cgiGet( "CTACONTABLECODIGO_"+sGXsfl_90_idx+"Enabled"), ".", ",")) ;
         edtPartidaDebe_Enabled = (int)(context.localUtil.CToN( cgiGet( "PARTIDADEBE_"+sGXsfl_90_idx+"Enabled"), ".", ",")) ;
         edtPartidaHaber_Enabled = (int)(context.localUtil.CToN( cgiGet( "PARTIDAHABER_"+sGXsfl_90_idx+"Enabled"), ".", ",")) ;
         imgprompt_41_199_Link = cgiGet( "PROMPT_193_"+sGXsfl_90_idx+"Link") ;
         if ( ( ( context.localUtil.CToN( cgiGet( edtPartidaLinea_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPartidaLinea_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PARTIDALINEA");
            AnyError = 1 ;
            GX_FocusControl = edtPartidaLinea_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A214PartidaLinea = 0 ;
         }
         else
         {
            A214PartidaLinea = (short)(context.localUtil.CToN( cgiGet( edtPartidaLinea_Internalname), ".", ",")) ;
         }
         A193CtaContableCodigo = cgiGet( edtCtaContableCodigo_Internalname) ;
         if ( ( ( context.localUtil.CToN( cgiGet( edtPartidaDebe_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPartidaDebe_Internalname), ".", ",") > 99999999999999.99m ) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PARTIDADEBE");
            AnyError = 1 ;
            GX_FocusControl = edtPartidaDebe_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A215PartidaDebe = 0 ;
         }
         else
         {
            A215PartidaDebe = context.localUtil.CToN( cgiGet( edtPartidaDebe_Internalname), ".", ",") ;
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtPartidaHaber_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPartidaHaber_Internalname), ".", ",") > 99999999999999.99m ) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PARTIDAHABER");
            AnyError = 1 ;
            GX_FocusControl = edtPartidaHaber_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A216PartidaHaber = 0 ;
         }
         else
         {
            A216PartidaHaber = context.localUtil.CToN( cgiGet( edtPartidaHaber_Internalname), ".", ",") ;
         }
         GXCCtl = "Z214PartidaLinea_" + sGXsfl_90_idx ;
         Z214PartidaLinea = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "Z215PartidaDebe_" + sGXsfl_90_idx ;
         Z215PartidaDebe = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",") ;
         GXCCtl = "Z216PartidaHaber_" + sGXsfl_90_idx ;
         Z216PartidaHaber = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",") ;
         GXCCtl = "Z193CtaContableCodigo_" + sGXsfl_90_idx ;
         Z193CtaContableCodigo = cgiGet( GXCCtl) ;
         GXCCtl = "nRcdDeleted_54_" + sGXsfl_90_idx ;
         nRcdDeleted_54 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdExists_54_" + sGXsfl_90_idx ;
         nRcdExists_54 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nIsMod_54_" + sGXsfl_90_idx ;
         nIsMod_54 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
      }

      protected void assign_properties_default( )
      {
         defedtPartidaLinea_Enabled = edtPartidaLinea_Enabled ;
      }

      protected void ConfirmValues150( )
      {
         nGXsfl_90_idx = 0 ;
         sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0") ;
         edtPartidaLinea_Internalname = "PARTIDALINEA_"+sGXsfl_90_idx ;
         edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_90_idx ;
         imgprompt_193_Internalname = "PROMPT_193_"+sGXsfl_90_idx ;
         edtPartidaDebe_Internalname = "PARTIDADEBE_"+sGXsfl_90_idx ;
         edtPartidaHaber_Internalname = "PARTIDAHABER_"+sGXsfl_90_idx ;
         while ( nGXsfl_90_idx < nRC_Gridpartidaenc_partidadet )
         {
            nGXsfl_90_idx = (short)(nGXsfl_90_idx+1) ;
            sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0") ;
            edtPartidaLinea_Internalname = "PARTIDALINEA_"+sGXsfl_90_idx ;
            edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_90_idx ;
            imgprompt_193_Internalname = "PROMPT_193_"+sGXsfl_90_idx ;
            edtPartidaDebe_Internalname = "PARTIDADEBE_"+sGXsfl_90_idx ;
            edtPartidaHaber_Internalname = "PARTIDAHABER_"+sGXsfl_90_idx ;
            ChangePostValue( "Z214PartidaLinea_"+sGXsfl_90_idx, cgiGet( "ZT_"+"Z214PartidaLinea_"+sGXsfl_90_idx)) ;
            DeletePostValue( "ZT_"+"Z214PartidaLinea_"+sGXsfl_90_idx) ;
            ChangePostValue( "Z215PartidaDebe_"+sGXsfl_90_idx, cgiGet( "ZT_"+"Z215PartidaDebe_"+sGXsfl_90_idx)) ;
            DeletePostValue( "ZT_"+"Z215PartidaDebe_"+sGXsfl_90_idx) ;
            ChangePostValue( "Z216PartidaHaber_"+sGXsfl_90_idx, cgiGet( "ZT_"+"Z216PartidaHaber_"+sGXsfl_90_idx)) ;
            DeletePostValue( "ZT_"+"Z216PartidaHaber_"+sGXsfl_90_idx) ;
            ChangePostValue( "Z193CtaContableCodigo_"+sGXsfl_90_idx, cgiGet( "ZT_"+"Z193CtaContableCodigo_"+sGXsfl_90_idx)) ;
            DeletePostValue( "ZT_"+"Z193CtaContableCodigo_"+sGXsfl_90_idx) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("partidaenc.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z199TipoParCodigo", StringUtil.RTrim( Z199TipoParCodigo));
         GxWebStd.gx_hidden_field( context, "Z207PartidaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z207PartidaId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z208PartidaFecha", context.localUtil.DToC( Z208PartidaFecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z209PartidaHora", StringUtil.RTrim( Z209PartidaHora));
         GxWebStd.gx_hidden_field( context, "Z210PartidaObs", StringUtil.RTrim( Z210PartidaObs));
         GxWebStd.gx_hidden_field( context, "Z211PartidaMayorizada", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z211PartidaMayorizada), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z212PartidaReferencia", StringUtil.RTrim( Z212PartidaReferencia));
         GxWebStd.gx_hidden_field( context, "Z289PartidaEstado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z289PartidaEstado), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z4UsuarioCodigo", StringUtil.RTrim( Z4UsuarioCodigo));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_Gridpartidaenc_partidadet", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_90_idx), 4, 0, ".", "")));
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
         return "PartidaEnc" ;
      }

      public override String GetPgmdesc( )
      {
         return "Encabezado de partida contable" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("partidaenc.aspx")  ;
      }

      protected void InitializeNonKey1553( )
      {
         A208PartidaFecha = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A208PartidaFecha", context.localUtil.Format(A208PartidaFecha, "99/99/99"));
         A209PartidaHora = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A209PartidaHora", A209PartidaHora);
         A210PartidaObs = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210PartidaObs", A210PartidaObs);
         A211PartidaMayorizada = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A211PartidaMayorizada", StringUtil.Str( (decimal)(A211PartidaMayorizada), 1, 0));
         A212PartidaReferencia = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A212PartidaReferencia", A212PartidaReferencia);
         A4UsuarioCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
         A289PartidaEstado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PartidaEstado", StringUtil.Str( (decimal)(A289PartidaEstado), 1, 0));
      }

      protected void InitAll1553( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A199TipoParCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
         A207PartidaId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PartidaId), 9, 0)));
         InitializeNonKey1553( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey1554( )
      {
         A193CtaContableCodigo = "" ;
         A215PartidaDebe = 0 ;
         A216PartidaHaber = 0 ;
      }

      protected void InitAll1554( )
      {
         A214PartidaLinea = 0 ;
         InitializeNonKey1554( ) ;
      }

      protected void StandaloneModalInsert1554( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?75080");
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1562461");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("partidaenc.js", "?1562461");
         /* End function include_jscripts */
      }

      protected void init_level_properties54( )
      {
         edtPartidaLinea_Enabled = defedtPartidaLinea_Enabled ;
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
         lblTextblocktipoparcodigo_Internalname = "TEXTBLOCKTIPOPARCODIGO" ;
         edtTipoParCodigo_Internalname = "TIPOPARCODIGO" ;
         lblTextblockpartidaid_Internalname = "TEXTBLOCKPARTIDAID" ;
         edtPartidaId_Internalname = "PARTIDAID" ;
         lblTextblockpartidafecha_Internalname = "TEXTBLOCKPARTIDAFECHA" ;
         edtPartidaFecha_Internalname = "PARTIDAFECHA" ;
         lblTextblockpartidahora_Internalname = "TEXTBLOCKPARTIDAHORA" ;
         edtPartidaHora_Internalname = "PARTIDAHORA" ;
         lblTextblockpartidaobs_Internalname = "TEXTBLOCKPARTIDAOBS" ;
         edtPartidaObs_Internalname = "PARTIDAOBS" ;
         lblTextblockpartidamayorizada_Internalname = "TEXTBLOCKPARTIDAMAYORIZADA" ;
         cmbPartidaMayorizada_Internalname = "PARTIDAMAYORIZADA" ;
         lblTextblockpartidareferencia_Internalname = "TEXTBLOCKPARTIDAREFERENCIA" ;
         edtPartidaReferencia_Internalname = "PARTIDAREFERENCIA" ;
         lblTextblockusuariocodigo_Internalname = "TEXTBLOCKUSUARIOCODIGO" ;
         edtUsuarioCodigo_Internalname = "USUARIOCODIGO" ;
         lblTextblockpartidaestado_Internalname = "TEXTBLOCKPARTIDAESTADO" ;
         cmbPartidaEstado_Internalname = "PARTIDAESTADO" ;
         lblTitlepartidadet_Internalname = "TITLEPARTIDADET" ;
         tblTable3_Internalname = "TABLE3" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_199_Internalname = "PROMPT_41_199" ;
         imgprompt_4_Internalname = "PROMPT_4" ;
         subGridpartidaenc_partidadet_Internalname = "GRIDPARTIDAENC_PARTIDADET" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Encabezado de partida contable" ;
         edtPartidaHaber_Jsonclick = "" ;
         edtPartidaDebe_Jsonclick = "" ;
         imgprompt_193_Visible = 1 ;
         imgprompt_193_Link = "" ;
         imgprompt_41_199_Visible = 1 ;
         edtCtaContableCodigo_Jsonclick = "" ;
         edtPartidaLinea_Jsonclick = "" ;
         subGridpartidaenc_partidadet_Class = "Grid" ;
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
         subGridpartidaenc_partidadet_Allowcollapsing = 0 ;
         edtPartidaHaber_Enabled = 1 ;
         edtPartidaDebe_Enabled = 1 ;
         edtCtaContableCodigo_Enabled = 1 ;
         edtPartidaLinea_Enabled = 1 ;
         subGridpartidaenc_partidadet_Backcolorstyle = 2 ;
         cmbPartidaEstado_Jsonclick = "" ;
         cmbPartidaEstado.Enabled = 1 ;
         imgprompt_4_Visible = 1 ;
         imgprompt_4_Link = "" ;
         edtUsuarioCodigo_Jsonclick = "" ;
         edtUsuarioCodigo_Enabled = 1 ;
         edtPartidaReferencia_Jsonclick = "" ;
         edtPartidaReferencia_Enabled = 1 ;
         cmbPartidaMayorizada_Jsonclick = "" ;
         cmbPartidaMayorizada.Enabled = 1 ;
         edtPartidaObs_Enabled = 1 ;
         edtPartidaHora_Jsonclick = "" ;
         edtPartidaHora_Enabled = 1 ;
         edtPartidaFecha_Jsonclick = "" ;
         edtPartidaFecha_Enabled = 1 ;
         edtPartidaId_Jsonclick = "" ;
         edtPartidaId_Enabled = 1 ;
         imgprompt_41_199_Visible = 1 ;
         imgprompt_41_199_Link = "" ;
         edtTipoParCodigo_Jsonclick = "" ;
         edtTipoParCodigo_Enabled = 1 ;
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

      protected void gxnrGridpartidaenc_partidadet_newrow( short nRC_Gridpartidaenc_partidadet ,
                                                           short nGXsfl_90_idx ,
                                                           String sGXsfl_90_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         edtPartidaLinea_Internalname = "PARTIDALINEA_"+sGXsfl_90_idx ;
         edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_90_idx ;
         imgprompt_193_Internalname = "PROMPT_193_"+sGXsfl_90_idx ;
         edtPartidaDebe_Internalname = "PARTIDADEBE_"+sGXsfl_90_idx ;
         edtPartidaHaber_Internalname = "PARTIDAHABER_"+sGXsfl_90_idx ;
         while ( nGXsfl_90_idx <= nRC_Gridpartidaenc_partidadet )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal1554( ) ;
            standaloneModal1554( ) ;
            cmbPartidaMayorizada.Name = "PARTIDAMAYORIZADA" ;
            cmbPartidaMayorizada.WebTags = "" ;
            cmbPartidaMayorizada.addItem("0", "No", 0);
            cmbPartidaMayorizada.addItem("1", "Si", 0);
            if ( ( cmbPartidaMayorizada.ItemCount > 0 ) && (0==A211PartidaMayorizada) )
            {
               A211PartidaMayorizada = (short)(NumberUtil.Val( cmbPartidaMayorizada.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A211PartidaMayorizada", StringUtil.Str( (decimal)(A211PartidaMayorizada), 1, 0));
            }
            cmbPartidaEstado.Name = "PARTIDAESTADO" ;
            cmbPartidaEstado.WebTags = "" ;
            cmbPartidaEstado.addItem("0", "Creada", 0);
            cmbPartidaEstado.addItem("1", "Emitida", 0);
            cmbPartidaEstado.addItem("2", "Cancelada", 0);
            if ( ( cmbPartidaEstado.ItemCount > 0 ) && (0==A289PartidaEstado) )
            {
               A289PartidaEstado = (short)(NumberUtil.Val( cmbPartidaEstado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PartidaEstado", StringUtil.Str( (decimal)(A289PartidaEstado), 1, 0));
            }
            dynload_actions( ) ;
            SendRow1554( ) ;
            nGXsfl_90_idx = (short)(nGXsfl_90_idx+1) ;
            sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0") ;
            edtPartidaLinea_Internalname = "PARTIDALINEA_"+sGXsfl_90_idx ;
            edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_90_idx ;
            imgprompt_193_Internalname = "PROMPT_193_"+sGXsfl_90_idx ;
            edtPartidaDebe_Internalname = "PARTIDADEBE_"+sGXsfl_90_idx ;
            edtPartidaHaber_Internalname = "PARTIDAHABER_"+sGXsfl_90_idx ;
         }
         context.GX_webresponse.AddString(Gridpartidaenc_partidadetContainer.ToJavascriptSource());
         /* End function gxnrGridpartidaenc_partidadet_newrow */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         /* Using cursor T001527 */
         pr_default.execute(25, new Object[] {A41ClinicaCodigo, A199TipoParCodigo});
         if ( (pr_default.getStatus(25) == 101) )
         {
            AnyError41 = 1 ;
            AnyError199 = 1 ;
            GX_msglist.addItem("No existe 'Tipos de Partidas Contables'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError199 == 0 ) )
         {
         }
         pr_default.close(25);
         GX_FocusControl = edtPartidaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Tipoparcodigo( String GX_Parm1 ,
                                       String GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A199TipoParCodigo = GX_Parm2 ;
         /* Using cursor T001527 */
         pr_default.execute(25, new Object[] {A41ClinicaCodigo, A199TipoParCodigo});
         if ( (pr_default.getStatus(25) == 101) )
         {
            AnyError41 = 1 ;
            AnyError199 = 1 ;
            GX_msglist.addItem("No existe 'Tipos de Partidas Contables'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError199 == 0 ) )
         {
         }
         pr_default.close(25);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Partidaid( String GX_Parm1 ,
                                   String GX_Parm2 ,
                                   int GX_Parm3 ,
                                   DateTime GX_Parm4 ,
                                   String GX_Parm5 ,
                                   String GX_Parm6 ,
                                   GXCombobox cmbGX_Parm7 ,
                                   String GX_Parm8 ,
                                   GXCombobox cmbGX_Parm9 ,
                                   String GX_Parm10 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A199TipoParCodigo = GX_Parm2 ;
         A207PartidaId = GX_Parm3 ;
         A208PartidaFecha = GX_Parm4 ;
         A209PartidaHora = GX_Parm5 ;
         A210PartidaObs = GX_Parm6 ;
         cmbPartidaMayorizada = cmbGX_Parm7 ;
         A211PartidaMayorizada = (short)(NumberUtil.Val( cmbPartidaMayorizada.CurrentValue, ".")) ;
         cmbPartidaMayorizada.CurrentValue = StringUtil.Str( (decimal)(A211PartidaMayorizada), 1, 0) ;
         A212PartidaReferencia = GX_Parm8 ;
         cmbPartidaEstado = cmbGX_Parm9 ;
         A289PartidaEstado = (short)(NumberUtil.Val( cmbPartidaEstado.CurrentValue, ".")) ;
         cmbPartidaEstado.CurrentValue = StringUtil.Str( (decimal)(A289PartidaEstado), 1, 0) ;
         A4UsuarioCodigo = GX_Parm10 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(context.localUtil.Format(A208PartidaFecha, "99/99/99")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A209PartidaHora)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A210PartidaObs)));
         cmbPartidaMayorizada.CurrentValue = StringUtil.Str( (decimal)(A211PartidaMayorizada), 1, 0) ;
         isValidOutput.Add((Object)(cmbPartidaMayorizada));
         isValidOutput.Add((Object)(StringUtil.RTrim( A212PartidaReferencia)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A4UsuarioCodigo)));
         cmbPartidaEstado.CurrentValue = StringUtil.Str( (decimal)(A289PartidaEstado), 1, 0) ;
         isValidOutput.Add((Object)(cmbPartidaEstado));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z199TipoParCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z207PartidaId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z208PartidaFecha, 0, "/")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z209PartidaHora)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z210PartidaObs)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z211PartidaMayorizada), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z212PartidaReferencia)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z4UsuarioCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z289PartidaEstado), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(Gridpartidaenc_partidadetContainer));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Usuariocodigo( String GX_Parm1 )
      {
         A4UsuarioCodigo = GX_Parm1 ;
         /* Using cursor T001528 */
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

      public void Valid_Ctacontablecodigo( String GX_Parm1 ,
                                           String GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A193CtaContableCodigo = GX_Parm2 ;
         /* Using cursor T001529 */
         pr_default.execute(27, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
         if ( (pr_default.getStatus(27) == 101) )
         {
            AnyError41 = 1 ;
            AnyError193 = 1 ;
            GX_msglist.addItem("No existe 'Catálogo de Cuentas Contables'.", "ForeignKeyNotFound", 1, "CTACONTABLECODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtCtaContableCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError193 == 0 ) )
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
         A199TipoParCodigo = "" ;
         A4UsuarioCodigo = "" ;
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
         lblTextblocktipoparcodigo_Jsonclick = "" ;
         lblTextblockpartidaid_Jsonclick = "" ;
         lblTextblockpartidafecha_Jsonclick = "" ;
         A208PartidaFecha = DateTime.MinValue ;
         lblTextblockpartidahora_Jsonclick = "" ;
         A209PartidaHora = "" ;
         lblTextblockpartidaobs_Jsonclick = "" ;
         A210PartidaObs = "" ;
         lblTextblockpartidamayorizada_Jsonclick = "" ;
         lblTextblockpartidareferencia_Jsonclick = "" ;
         A212PartidaReferencia = "" ;
         lblTextblockusuariocodigo_Jsonclick = "" ;
         lblTextblockpartidaestado_Jsonclick = "" ;
         Gridpartidaenc_partidadetContainer = new GXWebGrid( context);
         Gridpartidaenc_partidadetColumn = new GXWebColumn();
         Gx_mode = "" ;
         sMode54 = "" ;
         edtPartidaLinea_Internalname = "" ;
         lblTitlepartidadet_Jsonclick = "" ;
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
         Z199TipoParCodigo = "" ;
         Z208PartidaFecha = DateTime.MinValue ;
         Z209PartidaHora = "" ;
         Z210PartidaObs = "" ;
         Z212PartidaReferencia = "" ;
         Z4UsuarioCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtCtaContableCodigo_Internalname = "" ;
         edtPartidaDebe_Internalname = "" ;
         edtPartidaHaber_Internalname = "" ;
         Z193CtaContableCodigo = "" ;
         T00159_A207PartidaId = new int[1] ;
         T00159_A208PartidaFecha = new DateTime[] {DateTime.MinValue} ;
         T00159_A209PartidaHora = new String[] {""} ;
         T00159_A210PartidaObs = new String[] {""} ;
         T00159_A211PartidaMayorizada = new short[1] ;
         T00159_A212PartidaReferencia = new String[] {""} ;
         T00159_A289PartidaEstado = new short[1] ;
         T00159_A41ClinicaCodigo = new String[] {""} ;
         T00159_A199TipoParCodigo = new String[] {""} ;
         T00159_A4UsuarioCodigo = new String[] {""} ;
         T00157_A41ClinicaCodigo = new String[] {""} ;
         T00158_A4UsuarioCodigo = new String[] {""} ;
         T001510_A41ClinicaCodigo = new String[] {""} ;
         T001511_A4UsuarioCodigo = new String[] {""} ;
         T001512_A41ClinicaCodigo = new String[] {""} ;
         T001512_A199TipoParCodigo = new String[] {""} ;
         T001512_A207PartidaId = new int[1] ;
         T00156_A207PartidaId = new int[1] ;
         T00156_A208PartidaFecha = new DateTime[] {DateTime.MinValue} ;
         T00156_A209PartidaHora = new String[] {""} ;
         T00156_A210PartidaObs = new String[] {""} ;
         T00156_A211PartidaMayorizada = new short[1] ;
         T00156_A212PartidaReferencia = new String[] {""} ;
         T00156_A289PartidaEstado = new short[1] ;
         T00156_A41ClinicaCodigo = new String[] {""} ;
         T00156_A199TipoParCodigo = new String[] {""} ;
         T00156_A4UsuarioCodigo = new String[] {""} ;
         sMode53 = "" ;
         T001513_A41ClinicaCodigo = new String[] {""} ;
         T001513_A199TipoParCodigo = new String[] {""} ;
         T001513_A207PartidaId = new int[1] ;
         T001514_A41ClinicaCodigo = new String[] {""} ;
         T001514_A199TipoParCodigo = new String[] {""} ;
         T001514_A207PartidaId = new int[1] ;
         T001515_A207PartidaId = new int[1] ;
         T001515_A208PartidaFecha = new DateTime[] {DateTime.MinValue} ;
         T001515_A209PartidaHora = new String[] {""} ;
         T001515_A210PartidaObs = new String[] {""} ;
         T001515_A211PartidaMayorizada = new short[1] ;
         T001515_A212PartidaReferencia = new String[] {""} ;
         T001515_A289PartidaEstado = new short[1] ;
         T001515_A41ClinicaCodigo = new String[] {""} ;
         T001515_A199TipoParCodigo = new String[] {""} ;
         T001515_A4UsuarioCodigo = new String[] {""} ;
         T001519_A41ClinicaCodigo = new String[] {""} ;
         T001519_A199TipoParCodigo = new String[] {""} ;
         T001519_A207PartidaId = new int[1] ;
         T001520_A199TipoParCodigo = new String[] {""} ;
         T001520_A207PartidaId = new int[1] ;
         T001520_A214PartidaLinea = new short[1] ;
         T001520_A215PartidaDebe = new decimal[1] ;
         T001520_A216PartidaHaber = new decimal[1] ;
         T001520_A41ClinicaCodigo = new String[] {""} ;
         T001520_A193CtaContableCodigo = new String[] {""} ;
         T00154_A41ClinicaCodigo = new String[] {""} ;
         T001521_A41ClinicaCodigo = new String[] {""} ;
         T001522_A41ClinicaCodigo = new String[] {""} ;
         T001522_A199TipoParCodigo = new String[] {""} ;
         T001522_A207PartidaId = new int[1] ;
         T001522_A214PartidaLinea = new short[1] ;
         T00153_A199TipoParCodigo = new String[] {""} ;
         T00153_A207PartidaId = new int[1] ;
         T00153_A214PartidaLinea = new short[1] ;
         T00153_A215PartidaDebe = new decimal[1] ;
         T00153_A216PartidaHaber = new decimal[1] ;
         T00153_A41ClinicaCodigo = new String[] {""} ;
         T00153_A193CtaContableCodigo = new String[] {""} ;
         T00152_A199TipoParCodigo = new String[] {""} ;
         T00152_A207PartidaId = new int[1] ;
         T00152_A214PartidaLinea = new short[1] ;
         T00152_A215PartidaDebe = new decimal[1] ;
         T00152_A216PartidaHaber = new decimal[1] ;
         T00152_A41ClinicaCodigo = new String[] {""} ;
         T00152_A193CtaContableCodigo = new String[] {""} ;
         T001526_A41ClinicaCodigo = new String[] {""} ;
         T001526_A199TipoParCodigo = new String[] {""} ;
         T001526_A207PartidaId = new int[1] ;
         T001526_A214PartidaLinea = new short[1] ;
         imgprompt_193_Internalname = "" ;
         Gridpartidaenc_partidadetRow = new GXWebRow();
         subGridpartidaenc_partidadet_Linesclass = "" ;
         ROClassString = "" ;
         GXCCtl = "" ;
         GXt_char7 = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char8 = "" ;
         GXt_char9 = "" ;
         GXt_char10 = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char12 = "" ;
         GXt_char11 = "" ;
         GXt_char13 = "" ;
         T001527_A41ClinicaCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         T001528_A4UsuarioCodigo = new String[] {""} ;
         T001529_A41ClinicaCodigo = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.partidaenc__default(),
            new Object[][] {
                new Object[] {
               T00152_A199TipoParCodigo, T00152_A207PartidaId, T00152_A214PartidaLinea, T00152_A215PartidaDebe, T00152_A216PartidaHaber, T00152_A41ClinicaCodigo, T00152_A193CtaContableCodigo
               }
               , new Object[] {
               T00153_A199TipoParCodigo, T00153_A207PartidaId, T00153_A214PartidaLinea, T00153_A215PartidaDebe, T00153_A216PartidaHaber, T00153_A41ClinicaCodigo, T00153_A193CtaContableCodigo
               }
               , new Object[] {
               T00154_A41ClinicaCodigo
               }
               , new Object[] {
               T00155_A207PartidaId, T00155_A208PartidaFecha, T00155_A209PartidaHora, T00155_A210PartidaObs, T00155_A211PartidaMayorizada, T00155_A212PartidaReferencia, T00155_A289PartidaEstado, T00155_A41ClinicaCodigo, T00155_A199TipoParCodigo, T00155_A4UsuarioCodigo
               }
               , new Object[] {
               T00156_A207PartidaId, T00156_A208PartidaFecha, T00156_A209PartidaHora, T00156_A210PartidaObs, T00156_A211PartidaMayorizada, T00156_A212PartidaReferencia, T00156_A289PartidaEstado, T00156_A41ClinicaCodigo, T00156_A199TipoParCodigo, T00156_A4UsuarioCodigo
               }
               , new Object[] {
               T00157_A41ClinicaCodigo
               }
               , new Object[] {
               T00158_A4UsuarioCodigo
               }
               , new Object[] {
               T00159_A207PartidaId, T00159_A208PartidaFecha, T00159_A209PartidaHora, T00159_A210PartidaObs, T00159_A211PartidaMayorizada, T00159_A212PartidaReferencia, T00159_A289PartidaEstado, T00159_A41ClinicaCodigo, T00159_A199TipoParCodigo, T00159_A4UsuarioCodigo
               }
               , new Object[] {
               T001510_A41ClinicaCodigo
               }
               , new Object[] {
               T001511_A4UsuarioCodigo
               }
               , new Object[] {
               T001512_A41ClinicaCodigo, T001512_A199TipoParCodigo, T001512_A207PartidaId
               }
               , new Object[] {
               T001513_A41ClinicaCodigo, T001513_A199TipoParCodigo, T001513_A207PartidaId
               }
               , new Object[] {
               T001514_A41ClinicaCodigo, T001514_A199TipoParCodigo, T001514_A207PartidaId
               }
               , new Object[] {
               T001515_A207PartidaId, T001515_A208PartidaFecha, T001515_A209PartidaHora, T001515_A210PartidaObs, T001515_A211PartidaMayorizada, T001515_A212PartidaReferencia, T001515_A289PartidaEstado, T001515_A41ClinicaCodigo, T001515_A199TipoParCodigo, T001515_A4UsuarioCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001519_A41ClinicaCodigo, T001519_A199TipoParCodigo, T001519_A207PartidaId
               }
               , new Object[] {
               T001520_A199TipoParCodigo, T001520_A207PartidaId, T001520_A214PartidaLinea, T001520_A215PartidaDebe, T001520_A216PartidaHaber, T001520_A41ClinicaCodigo, T001520_A193CtaContableCodigo
               }
               , new Object[] {
               T001521_A41ClinicaCodigo
               }
               , new Object[] {
               T001522_A41ClinicaCodigo, T001522_A199TipoParCodigo, T001522_A207PartidaId, T001522_A214PartidaLinea
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001526_A41ClinicaCodigo, T001526_A199TipoParCodigo, T001526_A207PartidaId, T001526_A214PartidaLinea
               }
               , new Object[] {
               T001527_A41ClinicaCodigo
               }
               , new Object[] {
               T001528_A4UsuarioCodigo
               }
               , new Object[] {
               T001529_A41ClinicaCodigo
               }
            }
         );
      }

      private short nIsMod_54 ;
      private short GxWebError ;
      private short nRC_Gridpartidaenc_partidadet ;
      private short nGXsfl_90_idx=1 ;
      private short gxcookieaux ;
      private short A211PartidaMayorizada ;
      private short A289PartidaEstado ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGridpartidaenc_partidadet_Backcolorstyle ;
      private short A214PartidaLinea ;
      private short subGridpartidaenc_partidadet_Allowcollapsing ;
      private short subGridpartidaenc_partidadet_Collapsed ;
      private short nBlankRcdCount54 ;
      private short nRcdExists_54 ;
      private short RcdFound54 ;
      private short nBlankRcdUsr54 ;
      private short Z211PartidaMayorizada ;
      private short Z289PartidaEstado ;
      private short nRcdDeleted_54 ;
      private short Z214PartidaLinea ;
      private short GX_JID ;
      private short RcdFound53 ;
      private short Gx_BScreen ;
      private short subGridpartidaenc_partidadet_Backstyle ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int edtTipoParCodigo_Enabled ;
      private int imgprompt_41_199_Visible ;
      private int A207PartidaId ;
      private int edtPartidaId_Enabled ;
      private int edtPartidaFecha_Enabled ;
      private int edtPartidaHora_Enabled ;
      private int edtPartidaObs_Enabled ;
      private int edtPartidaReferencia_Enabled ;
      private int edtUsuarioCodigo_Enabled ;
      private int imgprompt_4_Visible ;
      private int edtPartidaLinea_Enabled ;
      private int edtCtaContableCodigo_Enabled ;
      private int edtPartidaDebe_Enabled ;
      private int edtPartidaHaber_Enabled ;
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
      private int Z207PartidaId ;
      private int GRIDPARTIDAENC_PARTIDADET_nFirstRecordOnPage ;
      private int AnyError41 ;
      private int AnyError199 ;
      private int AnyError4 ;
      private int AnyError193 ;
      private int subGridpartidaenc_partidadet_Backcolor ;
      private int subGridpartidaenc_partidadet_Allbackcolor ;
      private int imgprompt_193_Visible ;
      private int defedtPartidaLinea_Enabled ;
      private int idxLst ;
      private decimal A215PartidaDebe ;
      private decimal A216PartidaHaber ;
      private decimal Z215PartidaDebe ;
      private decimal Z216PartidaHaber ;
      private String sPrefix ;
      private String sGXsfl_90_idx="0001" ;
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
      private String lblTextblocktipoparcodigo_Internalname ;
      private String lblTextblocktipoparcodigo_Jsonclick ;
      private String edtTipoParCodigo_Internalname ;
      private String edtTipoParCodigo_Jsonclick ;
      private String imgprompt_41_199_Internalname ;
      private String imgprompt_41_199_Link ;
      private String lblTextblockpartidaid_Internalname ;
      private String lblTextblockpartidaid_Jsonclick ;
      private String edtPartidaId_Internalname ;
      private String edtPartidaId_Jsonclick ;
      private String lblTextblockpartidafecha_Internalname ;
      private String lblTextblockpartidafecha_Jsonclick ;
      private String edtPartidaFecha_Internalname ;
      private String edtPartidaFecha_Jsonclick ;
      private String lblTextblockpartidahora_Internalname ;
      private String lblTextblockpartidahora_Jsonclick ;
      private String A209PartidaHora ;
      private String edtPartidaHora_Internalname ;
      private String edtPartidaHora_Jsonclick ;
      private String lblTextblockpartidaobs_Internalname ;
      private String lblTextblockpartidaobs_Jsonclick ;
      private String edtPartidaObs_Internalname ;
      private String lblTextblockpartidamayorizada_Internalname ;
      private String lblTextblockpartidamayorizada_Jsonclick ;
      private String cmbPartidaMayorizada_Internalname ;
      private String cmbPartidaMayorizada_Jsonclick ;
      private String lblTextblockpartidareferencia_Internalname ;
      private String lblTextblockpartidareferencia_Jsonclick ;
      private String edtPartidaReferencia_Internalname ;
      private String edtPartidaReferencia_Jsonclick ;
      private String lblTextblockusuariocodigo_Internalname ;
      private String lblTextblockusuariocodigo_Jsonclick ;
      private String edtUsuarioCodigo_Internalname ;
      private String edtUsuarioCodigo_Jsonclick ;
      private String imgprompt_4_Internalname ;
      private String imgprompt_4_Link ;
      private String lblTextblockpartidaestado_Internalname ;
      private String lblTextblockpartidaestado_Jsonclick ;
      private String cmbPartidaEstado_Internalname ;
      private String cmbPartidaEstado_Jsonclick ;
      private String Gx_mode ;
      private String sMode54 ;
      private String edtPartidaLinea_Internalname ;
      private String tblTable3_Internalname ;
      private String lblTitlepartidadet_Internalname ;
      private String lblTitlepartidadet_Jsonclick ;
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
      private String Z209PartidaHora ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtCtaContableCodigo_Internalname ;
      private String edtPartidaDebe_Internalname ;
      private String edtPartidaHaber_Internalname ;
      private String sMode53 ;
      private String imgprompt_193_Internalname ;
      private String subGridpartidaenc_partidadet_Class ;
      private String subGridpartidaenc_partidadet_Linesclass ;
      private String imgprompt_193_Link ;
      private String ROClassString ;
      private String edtPartidaLinea_Jsonclick ;
      private String edtCtaContableCodigo_Jsonclick ;
      private String edtPartidaDebe_Jsonclick ;
      private String edtPartidaHaber_Jsonclick ;
      private String GXCCtl ;
      private String GXt_char7 ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char8 ;
      private String GXt_char9 ;
      private String GXt_char10 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char12 ;
      private String GXt_char11 ;
      private String subGridpartidaenc_partidadet_Internalname ;
      private String GXt_char13 ;
      private DateTime A208PartidaFecha ;
      private DateTime Z208PartidaFecha ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool Gx_longc ;
      private String A41ClinicaCodigo ;
      private String A199TipoParCodigo ;
      private String A4UsuarioCodigo ;
      private String A193CtaContableCodigo ;
      private String A210PartidaObs ;
      private String A212PartidaReferencia ;
      private String Z41ClinicaCodigo ;
      private String Z199TipoParCodigo ;
      private String Z210PartidaObs ;
      private String Z212PartidaReferencia ;
      private String Z4UsuarioCodigo ;
      private String Z193CtaContableCodigo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Gridpartidaenc_partidadetContainer ;
      private GXWebRow Gridpartidaenc_partidadetRow ;
      private GXWebColumn Gridpartidaenc_partidadetColumn ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbPartidaMayorizada ;
      private GXCombobox cmbPartidaEstado ;
      private IDataStoreProvider pr_default ;
      private int[] T00159_A207PartidaId ;
      private DateTime[] T00159_A208PartidaFecha ;
      private String[] T00159_A209PartidaHora ;
      private String[] T00159_A210PartidaObs ;
      private short[] T00159_A211PartidaMayorizada ;
      private String[] T00159_A212PartidaReferencia ;
      private short[] T00159_A289PartidaEstado ;
      private String[] T00159_A41ClinicaCodigo ;
      private String[] T00159_A199TipoParCodigo ;
      private String[] T00159_A4UsuarioCodigo ;
      private String[] T00157_A41ClinicaCodigo ;
      private String[] T00158_A4UsuarioCodigo ;
      private String[] T001510_A41ClinicaCodigo ;
      private String[] T001511_A4UsuarioCodigo ;
      private String[] T001512_A41ClinicaCodigo ;
      private String[] T001512_A199TipoParCodigo ;
      private int[] T001512_A207PartidaId ;
      private int[] T00156_A207PartidaId ;
      private DateTime[] T00156_A208PartidaFecha ;
      private String[] T00156_A209PartidaHora ;
      private String[] T00156_A210PartidaObs ;
      private short[] T00156_A211PartidaMayorizada ;
      private String[] T00156_A212PartidaReferencia ;
      private short[] T00156_A289PartidaEstado ;
      private String[] T00156_A41ClinicaCodigo ;
      private String[] T00156_A199TipoParCodigo ;
      private String[] T00156_A4UsuarioCodigo ;
      private String[] T001513_A41ClinicaCodigo ;
      private String[] T001513_A199TipoParCodigo ;
      private int[] T001513_A207PartidaId ;
      private String[] T001514_A41ClinicaCodigo ;
      private String[] T001514_A199TipoParCodigo ;
      private int[] T001514_A207PartidaId ;
      private int[] T001515_A207PartidaId ;
      private DateTime[] T001515_A208PartidaFecha ;
      private String[] T001515_A209PartidaHora ;
      private String[] T001515_A210PartidaObs ;
      private short[] T001515_A211PartidaMayorizada ;
      private String[] T001515_A212PartidaReferencia ;
      private short[] T001515_A289PartidaEstado ;
      private String[] T001515_A41ClinicaCodigo ;
      private String[] T001515_A199TipoParCodigo ;
      private String[] T001515_A4UsuarioCodigo ;
      private String[] T001519_A41ClinicaCodigo ;
      private String[] T001519_A199TipoParCodigo ;
      private int[] T001519_A207PartidaId ;
      private String[] T001520_A199TipoParCodigo ;
      private int[] T001520_A207PartidaId ;
      private short[] T001520_A214PartidaLinea ;
      private decimal[] T001520_A215PartidaDebe ;
      private decimal[] T001520_A216PartidaHaber ;
      private String[] T001520_A41ClinicaCodigo ;
      private String[] T001520_A193CtaContableCodigo ;
      private String[] T00154_A41ClinicaCodigo ;
      private String[] T001521_A41ClinicaCodigo ;
      private String[] T001522_A41ClinicaCodigo ;
      private String[] T001522_A199TipoParCodigo ;
      private int[] T001522_A207PartidaId ;
      private short[] T001522_A214PartidaLinea ;
      private String[] T00153_A199TipoParCodigo ;
      private int[] T00153_A207PartidaId ;
      private short[] T00153_A214PartidaLinea ;
      private decimal[] T00153_A215PartidaDebe ;
      private decimal[] T00153_A216PartidaHaber ;
      private String[] T00153_A41ClinicaCodigo ;
      private String[] T00153_A193CtaContableCodigo ;
      private String[] T00152_A199TipoParCodigo ;
      private int[] T00152_A207PartidaId ;
      private short[] T00152_A214PartidaLinea ;
      private decimal[] T00152_A215PartidaDebe ;
      private decimal[] T00152_A216PartidaHaber ;
      private String[] T00152_A41ClinicaCodigo ;
      private String[] T00152_A193CtaContableCodigo ;
      private String[] T001526_A41ClinicaCodigo ;
      private String[] T001526_A199TipoParCodigo ;
      private int[] T001526_A207PartidaId ;
      private short[] T001526_A214PartidaLinea ;
      private String[] T001527_A41ClinicaCodigo ;
      private String[] T001528_A4UsuarioCodigo ;
      private String[] T001529_A41ClinicaCodigo ;
      private int[] T00155_A207PartidaId ;
      private DateTime[] T00155_A208PartidaFecha ;
      private String[] T00155_A209PartidaHora ;
      private String[] T00155_A210PartidaObs ;
      private short[] T00155_A211PartidaMayorizada ;
      private String[] T00155_A212PartidaReferencia ;
      private short[] T00155_A289PartidaEstado ;
      private String[] T00155_A41ClinicaCodigo ;
      private String[] T00155_A199TipoParCodigo ;
      private String[] T00155_A4UsuarioCodigo ;
      private GXWebForm Form ;
   }

   public class partidaenc__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT00155 ;
          prmT00155 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00159 ;
          prmT00159 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00157 ;
          prmT00157 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00158 ;
          prmT00158 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001510 ;
          prmT001510 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001511 ;
          prmT001511 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001512 ;
          prmT001512 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00156 ;
          prmT00156 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001513 ;
          prmT001513 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001514 ;
          prmT001514 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001515 ;
          prmT001515 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001516 ;
          prmT001516 = new Object[] {
          new Object[] {"@PartidaId",SqlDbType.Int,9,0} ,
          new Object[] {"@PartidaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PartidaHora",SqlDbType.Char,8,0} ,
          new Object[] {"@PartidaObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@PartidaMayorizada",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@PartidaReferencia",SqlDbType.VarChar,40,0} ,
          new Object[] {"@PartidaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001517 ;
          prmT001517 = new Object[] {
          new Object[] {"@PartidaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PartidaHora",SqlDbType.Char,8,0} ,
          new Object[] {"@PartidaObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@PartidaMayorizada",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@PartidaReferencia",SqlDbType.VarChar,40,0} ,
          new Object[] {"@PartidaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001518 ;
          prmT001518 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001519 ;
          prmT001519 = new Object[] {
          } ;
          Object[] prmT001520 ;
          prmT001520 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0} ,
          new Object[] {"@PartidaLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00154 ;
          prmT00154 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001521 ;
          prmT001521 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001522 ;
          prmT001522 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0} ,
          new Object[] {"@PartidaLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00153 ;
          prmT00153 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0} ,
          new Object[] {"@PartidaLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00152 ;
          prmT00152 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0} ,
          new Object[] {"@PartidaLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001523 ;
          prmT001523 = new Object[] {
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0} ,
          new Object[] {"@PartidaLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PartidaDebe",SqlDbType.Decimal,17,2} ,
          new Object[] {"@PartidaHaber",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001524 ;
          prmT001524 = new Object[] {
          new Object[] {"@PartidaDebe",SqlDbType.Decimal,17,2} ,
          new Object[] {"@PartidaHaber",SqlDbType.Decimal,17,2} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0} ,
          new Object[] {"@PartidaLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001525 ;
          prmT001525 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0} ,
          new Object[] {"@PartidaLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001526 ;
          prmT001526 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001527 ;
          prmT001527 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001528 ;
          prmT001528 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001529 ;
          prmT001529 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00152", "SELECT [TipoParCodigo], [PartidaId], [PartidaLinea], [PartidaDebe], [PartidaHaber], [ClinicaCodigo], [CtaContableCodigo] FROM [PartidaDet] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [PartidaId] = @PartidaId AND [PartidaLinea] = @PartidaLinea ",true, GxErrorMask.GX_NOMASK, false, this,prmT00152,1,0,true,false )
             ,new CursorDef("T00153", "SELECT [TipoParCodigo], [PartidaId], [PartidaLinea], [PartidaDebe], [PartidaHaber], [ClinicaCodigo], [CtaContableCodigo] FROM [PartidaDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [PartidaId] = @PartidaId AND [PartidaLinea] = @PartidaLinea ",true, GxErrorMask.GX_NOMASK, false, this,prmT00153,1,0,true,false )
             ,new CursorDef("T00154", "SELECT [ClinicaCodigo] FROM [CuentaContable] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00154,1,0,true,false )
             ,new CursorDef("T00155", "SELECT [PartidaId], [PartidaFecha], [PartidaHora], [PartidaObs], [PartidaMayorizada], [PartidaReferencia], [PartidaEstado], [ClinicaCodigo], [TipoParCodigo], [UsuarioCodigo] FROM [PartidaEnc] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [PartidaId] = @PartidaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00155,1,0,true,false )
             ,new CursorDef("T00156", "SELECT [PartidaId], [PartidaFecha], [PartidaHora], [PartidaObs], [PartidaMayorizada], [PartidaReferencia], [PartidaEstado], [ClinicaCodigo], [TipoParCodigo], [UsuarioCodigo] FROM [PartidaEnc] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [PartidaId] = @PartidaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00156,1,0,true,false )
             ,new CursorDef("T00157", "SELECT [ClinicaCodigo] FROM [TipoPartida] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00157,1,0,true,false )
             ,new CursorDef("T00158", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00158,1,0,true,false )
             ,new CursorDef("T00159", "SELECT TM1.[PartidaId], TM1.[PartidaFecha], TM1.[PartidaHora], TM1.[PartidaObs], TM1.[PartidaMayorizada], TM1.[PartidaReferencia], TM1.[PartidaEstado], TM1.[ClinicaCodigo], TM1.[TipoParCodigo], TM1.[UsuarioCodigo] FROM [PartidaEnc] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[TipoParCodigo] = @TipoParCodigo and TM1.[PartidaId] = @PartidaId ORDER BY TM1.[ClinicaCodigo], TM1.[TipoParCodigo], TM1.[PartidaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00159,100,0,true,false )
             ,new CursorDef("T001510", "SELECT [ClinicaCodigo] FROM [TipoPartida] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001510,1,0,true,false )
             ,new CursorDef("T001511", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001511,1,0,true,false )
             ,new CursorDef("T001512", "SELECT [ClinicaCodigo], [TipoParCodigo], [PartidaId] FROM [PartidaEnc] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [PartidaId] = @PartidaId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001512,1,0,true,false )
             ,new CursorDef("T001513", "SELECT TOP 1 [ClinicaCodigo], [TipoParCodigo], [PartidaId] FROM [PartidaEnc] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [TipoParCodigo] > @TipoParCodigo or [TipoParCodigo] = @TipoParCodigo and [ClinicaCodigo] = @ClinicaCodigo and [PartidaId] > @PartidaId) ORDER BY [ClinicaCodigo], [TipoParCodigo], [PartidaId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001513,1,0,true,true )
             ,new CursorDef("T001514", "SELECT TOP 1 [ClinicaCodigo], [TipoParCodigo], [PartidaId] FROM [PartidaEnc] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [TipoParCodigo] < @TipoParCodigo or [TipoParCodigo] = @TipoParCodigo and [ClinicaCodigo] = @ClinicaCodigo and [PartidaId] < @PartidaId) ORDER BY [ClinicaCodigo] DESC, [TipoParCodigo] DESC, [PartidaId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001514,1,0,true,true )
             ,new CursorDef("T001515", "SELECT [PartidaId], [PartidaFecha], [PartidaHora], [PartidaObs], [PartidaMayorizada], [PartidaReferencia], [PartidaEstado], [ClinicaCodigo], [TipoParCodigo], [UsuarioCodigo] FROM [PartidaEnc] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [PartidaId] = @PartidaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001515,1,0,true,false )
             ,new CursorDef("T001516", "INSERT INTO [PartidaEnc] ([PartidaId], [PartidaFecha], [PartidaHora], [PartidaObs], [PartidaMayorizada], [PartidaReferencia], [PartidaEstado], [ClinicaCodigo], [TipoParCodigo], [UsuarioCodigo]) VALUES (@PartidaId, @PartidaFecha, @PartidaHora, @PartidaObs, @PartidaMayorizada, @PartidaReferencia, @PartidaEstado, @ClinicaCodigo, @TipoParCodigo, @UsuarioCodigo)", GxErrorMask.GX_NOMASK,prmT001516)
             ,new CursorDef("T001517", "UPDATE [PartidaEnc] SET [PartidaFecha]=@PartidaFecha, [PartidaHora]=@PartidaHora, [PartidaObs]=@PartidaObs, [PartidaMayorizada]=@PartidaMayorizada, [PartidaReferencia]=@PartidaReferencia, [PartidaEstado]=@PartidaEstado, [UsuarioCodigo]=@UsuarioCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [PartidaId] = @PartidaId", GxErrorMask.GX_NOMASK,prmT001517)
             ,new CursorDef("T001518", "DELETE FROM [PartidaEnc]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [PartidaId] = @PartidaId", GxErrorMask.GX_NOMASK,prmT001518)
             ,new CursorDef("T001519", "SELECT [ClinicaCodigo], [TipoParCodigo], [PartidaId] FROM [PartidaEnc] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [TipoParCodigo], [PartidaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001519,100,0,true,false )
             ,new CursorDef("T001520", "SELECT [TipoParCodigo], [PartidaId], [PartidaLinea], [PartidaDebe], [PartidaHaber], [ClinicaCodigo], [CtaContableCodigo] FROM [PartidaDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [TipoParCodigo] = @TipoParCodigo and [PartidaId] = @PartidaId and [PartidaLinea] = @PartidaLinea ORDER BY [ClinicaCodigo], [TipoParCodigo], [PartidaId], [PartidaLinea] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001520,11,0,true,false )
             ,new CursorDef("T001521", "SELECT [ClinicaCodigo] FROM [CuentaContable] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001521,1,0,true,false )
             ,new CursorDef("T001522", "SELECT [ClinicaCodigo], [TipoParCodigo], [PartidaId], [PartidaLinea] FROM [PartidaDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [PartidaId] = @PartidaId AND [PartidaLinea] = @PartidaLinea ",true, GxErrorMask.GX_NOMASK, false, this,prmT001522,1,0,true,false )
             ,new CursorDef("T001523", "INSERT INTO [PartidaDet] ([TipoParCodigo], [PartidaId], [PartidaLinea], [PartidaDebe], [PartidaHaber], [ClinicaCodigo], [CtaContableCodigo]) VALUES (@TipoParCodigo, @PartidaId, @PartidaLinea, @PartidaDebe, @PartidaHaber, @ClinicaCodigo, @CtaContableCodigo)", GxErrorMask.GX_NOMASK,prmT001523)
             ,new CursorDef("T001524", "UPDATE [PartidaDet] SET [PartidaDebe]=@PartidaDebe, [PartidaHaber]=@PartidaHaber, [CtaContableCodigo]=@CtaContableCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [PartidaId] = @PartidaId AND [PartidaLinea] = @PartidaLinea", GxErrorMask.GX_NOMASK,prmT001524)
             ,new CursorDef("T001525", "DELETE FROM [PartidaDet]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [PartidaId] = @PartidaId AND [PartidaLinea] = @PartidaLinea", GxErrorMask.GX_NOMASK,prmT001525)
             ,new CursorDef("T001526", "SELECT [ClinicaCodigo], [TipoParCodigo], [PartidaId], [PartidaLinea] FROM [PartidaDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [TipoParCodigo] = @TipoParCodigo and [PartidaId] = @PartidaId ORDER BY [ClinicaCodigo], [TipoParCodigo], [PartidaId], [PartidaLinea] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001526,11,0,true,false )
             ,new CursorDef("T001527", "SELECT [ClinicaCodigo] FROM [TipoPartida] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001527,1,0,true,false )
             ,new CursorDef("T001528", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001528,1,0,true,false )
             ,new CursorDef("T001529", "SELECT [ClinicaCodigo] FROM [CuentaContable] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001529,1,0,true,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 24 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
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
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
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
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                break;
             case 15 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (int)parms[9]);
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
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 19 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 20 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 21 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 22 :
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (decimal)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
             case 23 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
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
