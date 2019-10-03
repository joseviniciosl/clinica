/*
               File: TipoPartida
        Description: Tipos de Partidas Contables
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:6:16.73
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
   public class tipopartida : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_5( A41ClinicaCodigo) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridtipopartida_tipopartidadetalle") == 0 )
         {
            nRC_Gridtipopartida_tipopartidadetalle = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            nGXsfl_70_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_70_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGridtipopartida_tipopartidadetalle_newrow( nRC_Gridtipopartida_tipopartidadetalle, nGXsfl_70_idx, sGXsfl_70_idx) ;
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
         cmbTipoParAuxiliar.Name = "TIPOPARAUXILIAR" ;
         cmbTipoParAuxiliar.WebTags = "" ;
         cmbTipoParAuxiliar.addItem("1", "Contabilidad", 0);
         cmbTipoParAuxiliar.addItem("2", "Inventario", 0);
         cmbTipoParAuxiliar.addItem("3", "Facturación", 0);
         if ( ( cmbTipoParAuxiliar.ItemCount > 0 ) && (0==A201TipoParAuxiliar) )
         {
            A201TipoParAuxiliar = (short)(NumberUtil.Val( cmbTipoParAuxiliar.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201TipoParAuxiliar", StringUtil.Str( (decimal)(A201TipoParAuxiliar), 1, 0));
         }
         cmbTipoParMayoriza.Name = "TIPOPARMAYORIZA" ;
         cmbTipoParMayoriza.WebTags = "" ;
         cmbTipoParMayoriza.addItem("0", "No", 0);
         cmbTipoParMayoriza.addItem("1", "Si", 0);
         if ( ( cmbTipoParMayoriza.ItemCount > 0 ) && (0==A202TipoParMayoriza) )
         {
            A202TipoParMayoriza = (short)(NumberUtil.Val( cmbTipoParMayoriza.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A202TipoParMayoriza", StringUtil.Str( (decimal)(A202TipoParMayoriza), 1, 0));
         }
         cmbTipoParEstado.Name = "TIPOPARESTADO" ;
         cmbTipoParEstado.WebTags = "" ;
         cmbTipoParEstado.addItem("0", "De baja", 0);
         cmbTipoParEstado.addItem("1", "Activo", 0);
         if ( ( cmbTipoParEstado.ItemCount > 0 ) && (0==A203TipoParEstado) )
         {
            A203TipoParEstado = (short)(NumberUtil.Val( cmbTipoParEstado.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A203TipoParEstado", StringUtil.Str( (decimal)(A203TipoParEstado), 1, 0));
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Tipos de Partidas Contables", 0) ;
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

      public tipopartida( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public tipopartida( IGxContext context )
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
         cmbTipoParAuxiliar = new GXCombobox();
         cmbTipoParMayoriza = new GXCombobox();
         cmbTipoParEstado = new GXCombobox();
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
            wb_table1_2_1451( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1451e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1451( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1451( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1451e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Tipos de Partidas Contables"+"</legend>") ;
            wb_table3_27_1451( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_1451e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1451e( true) ;
         }
         else
         {
            wb_table1_2_1451e( false) ;
         }
      }

      protected void wb_table3_27_1451( bool wbgen )
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
            wb_table4_33_1451( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_1451e( bool wbgen )
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_TipoPartida.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_TipoPartida.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_TipoPartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_1451e( true) ;
         }
         else
         {
            wb_table3_27_1451e( false) ;
         }
      }

      protected void wb_table4_33_1451( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", lblTextblockclinicacodigo_Visible, 1, 0, "HLP_TipoPartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", edtClinicaCodigo_Visible, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_TipoPartida.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_Internalname, "prompt.gif", imgprompt_41_Link, "", "", "Fantastic", imgprompt_41_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TipoPartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipoparcodigo_Internalname, "Partida", "", "", lblTextblocktipoparcodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_TipoPartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTipoParCodigo_Internalname, StringUtil.RTrim( A199TipoParCodigo), StringUtil.RTrim( context.localUtil.Format( A199TipoParCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtTipoParCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtTipoParCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_TipoPartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipoparnombre_Internalname, "Nombre", "", "", lblTextblocktipoparnombre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_TipoPartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A200TipoParNombre", A200TipoParNombre);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTipoParNombre_Internalname, StringUtil.RTrim( A200TipoParNombre), StringUtil.RTrim( context.localUtil.Format( A200TipoParNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", "", "", "", edtTipoParNombre_Jsonclick, 0, ClassString, StyleString, "", 1, edtTipoParNombre_Enabled, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_TipoPartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipoparauxiliar_Internalname, "Auxiliar", "", "", lblTextblocktipoparauxiliar_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_TipoPartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201TipoParAuxiliar", StringUtil.Str( (decimal)(A201TipoParAuxiliar), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbTipoParAuxiliar, cmbTipoParAuxiliar_Internalname, StringUtil.Str( (decimal)(A201TipoParAuxiliar), 1, 0), 1, cmbTipoParAuxiliar_Jsonclick, 0, "", "int", "", 1, cmbTipoParAuxiliar.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "", true, "HLP_TipoPartida.htm");
            cmbTipoParAuxiliar.CurrentValue = StringUtil.Str( (decimal)(A201TipoParAuxiliar), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoParAuxiliar_Internalname, "Values", (String)(cmbTipoParAuxiliar.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipoparmayoriza_Internalname, "Mayoriza?", "", "", lblTextblocktipoparmayoriza_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_TipoPartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A202TipoParMayoriza", StringUtil.Str( (decimal)(A202TipoParMayoriza), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbTipoParMayoriza, cmbTipoParMayoriza_Internalname, StringUtil.Str( (decimal)(A202TipoParMayoriza), 1, 0), 1, cmbTipoParMayoriza_Jsonclick, 0, "", "int", "", 1, cmbTipoParMayoriza.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", "", true, "HLP_TipoPartida.htm");
            cmbTipoParMayoriza.CurrentValue = StringUtil.Str( (decimal)(A202TipoParMayoriza), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoParMayoriza_Internalname, "Values", (String)(cmbTipoParMayoriza.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipoparestado_Internalname, "Estado", "", "", lblTextblocktipoparestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_TipoPartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A203TipoParEstado", StringUtil.Str( (decimal)(A203TipoParEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbTipoParEstado, cmbTipoParEstado_Internalname, StringUtil.Str( (decimal)(A203TipoParEstado), 1, 0), 1, cmbTipoParEstado_Jsonclick, 0, "", "int", "", 1, cmbTipoParEstado.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", "", true, "HLP_TipoPartida.htm");
            cmbTipoParEstado.CurrentValue = StringUtil.Str( (decimal)(A203TipoParEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoParEstado_Internalname, "Values", (String)(cmbTipoParEstado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "<br>") ;
            wb_table5_66_1451( true) ;
         }
         return  ;
      }

      protected void wb_table5_66_1451e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<hr class=\"HRDefault\">") ;
            /*  Grid Control  */
            Gridtipopartida_tipopartidadetalleContainer.AddObjectProperty("GridName", "Gridtipopartida_tipopartidadetalle");
            Gridtipopartida_tipopartidadetalleContainer.AddObjectProperty("Class", "Grid");
            Gridtipopartida_tipopartidadetalleContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Gridtipopartida_tipopartidadetalleContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Gridtipopartida_tipopartidadetalleContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtipopartida_tipopartidadetalle_Backcolorstyle), 1, 0, ".", "")));
            Gridtipopartida_tipopartidadetalleContainer.AddObjectProperty("CmpContext", "");
            Gridtipopartida_tipopartidadetalleContainer.AddObjectProperty("InMasterPage", "false");
            Gridtipopartida_tipopartidadetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridtipopartida_tipopartidadetalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A204TipoParAnio), 4, 0, ".", "")));
            Gridtipopartida_tipopartidadetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoParAnio_Enabled), 5, 0, ".", "")));
            Gridtipopartida_tipopartidadetalleContainer.AddColumnProperties(Gridtipopartida_tipopartidadetalleColumn);
            Gridtipopartida_tipopartidadetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridtipopartida_tipopartidadetalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A205TipoParSiguiente), 9, 0, ".", "")));
            Gridtipopartida_tipopartidadetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoParSiguiente_Enabled), 5, 0, ".", "")));
            Gridtipopartida_tipopartidadetalleContainer.AddColumnProperties(Gridtipopartida_tipopartidadetalleColumn);
            Gridtipopartida_tipopartidadetalleContainer.AddObjectProperty("Allowselection", "false");
            Gridtipopartida_tipopartidadetalleContainer.AddObjectProperty("Allowcollapsing", ((subGridtipopartida_tipopartidadetalle_Allowcollapsing==1) ? "true" : "false"));
            Gridtipopartida_tipopartidadetalleContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtipopartida_tipopartidadetalle_Collapsed), 9, 0, ".", "")));
            nGXsfl_70_idx = 0 ;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount52 = 5 ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_52 = 1 ;
                  ScanStart1452( ) ;
                  while ( RcdFound52 != 0 )
                  {
                     init_level_properties52( ) ;
                     getByPrimaryKey1452( ) ;
                     AddRow1452( ) ;
                     ScanNext1452( ) ;
                  }
                  ScanEnd1452( ) ;
                  nBlankRcdCount52 = 5 ;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               standaloneNotModal1452( ) ;
               standaloneModal1452( ) ;
               sMode52 = Gx_mode ;
               while ( nGXsfl_70_idx < nRC_Gridtipopartida_tipopartidadetalle )
               {
                  ReadRow1452( ) ;
                  edtTipoParAnio_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPOPARANIO_"+sGXsfl_70_idx+"Enabled"), ".", ",")) ;
                  edtTipoParSiguiente_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPOPARSIGUIENTE_"+sGXsfl_70_idx+"Enabled"), ".", ",")) ;
                  if ( ( nRcdExists_52 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal1452( ) ;
                  }
                  SendRow1452( ) ;
               }
               Gx_mode = sMode52 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount52 = 5 ;
               nRcdExists_52 = 1 ;
               ScanStart1452( ) ;
               while ( RcdFound52 != 0 )
               {
                  init_level_properties52( ) ;
                  getByPrimaryKey1452( ) ;
                  standaloneNotModal1452( ) ;
                  standaloneModal1452( ) ;
                  AddRow1452( ) ;
                  ScanNext1452( ) ;
               }
               ScanEnd1452( ) ;
            }
            /* Initialize fields for 'new' records and send them. */
            sMode52 = Gx_mode ;
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            InitAll1452( ) ;
            init_level_properties52( ) ;
            standaloneNotModal1452( ) ;
            standaloneModal1452( ) ;
            nRcdExists_52 = 0 ;
            nIsMod_52 = 0 ;
            nBlankRcdCount52 = (short)(nBlankRcdUsr52+nBlankRcdCount52) ;
            fRowAdded = 0 ;
            while ( nBlankRcdCount52 > 0 )
            {
               AddRow1452( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1 ;
                  GX_FocusControl = edtTipoParAnio_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount52 = (short)(nBlankRcdCount52-1) ;
            }
            Gx_mode = sMode52 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            sStyleString = " style=\"display:none;\"" ;
            sStyleString = "" ;
            context.WriteHtmlText( "<div id=\""+"Gridtipopartida_tipopartidadetalleContainer"+"Div\" "+sStyleString+">"+"</div>") ;
            context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridtipopartida_tipopartidadetalle", (Object)(Gridtipopartida_tipopartidadetalleContainer));
            GxWebStd.gx_hidden_field( context, "Gridtipopartida_tipopartidadetalleContainerData", Gridtipopartida_tipopartidadetalleContainer.ToJavascriptSource());
            if ( context.isAjaxRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Gridtipopartida_tipopartidadetalleContainerData"+"V", Gridtipopartida_tipopartidadetalleContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridtipopartida_tipopartidadetalleContainerData"+"V"+"\" value='"+Gridtipopartida_tipopartidadetalleContainer.GridValuesHidden()+"'>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_1451e( true) ;
         }
         else
         {
            wb_table4_33_1451e( false) ;
         }
      }

      protected void wb_table5_66_1451( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTitletipopartidadetalle_Internalname, "Tipo Partida Detalle", "", "", lblTitletipopartidadetalle_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_TipoPartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_66_1451e( true) ;
         }
         else
         {
            wb_table5_66_1451e( false) ;
         }
      }

      protected void wb_table2_5_1451( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoPartida.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoPartida.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoPartida.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoPartida.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoPartida.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoPartida.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoPartida.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoPartida.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01f0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"TIPOPARCODIGO"+"'), id:'"+"TIPOPARCODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_TipoPartida.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01f0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"TIPOPARCODIGO"+"'), id:'"+"TIPOPARCODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_TipoPartida.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoPartida.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoPartida.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoPartida.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoPartida.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoPartida.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoPartida.htm");
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
            wb_table2_5_1451e( true) ;
         }
         else
         {
            wb_table2_5_1451e( false) ;
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
         /* Execute user event: E11142 */
         E11142 ();
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
               A200TipoParNombre = cgiGet( edtTipoParNombre_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A200TipoParNombre", A200TipoParNombre);
               cmbTipoParAuxiliar.Name = cmbTipoParAuxiliar_Internalname ;
               cmbTipoParAuxiliar.CurrentValue = cgiGet( cmbTipoParAuxiliar_Internalname) ;
               A201TipoParAuxiliar = (short)(NumberUtil.Val( cgiGet( cmbTipoParAuxiliar_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201TipoParAuxiliar", StringUtil.Str( (decimal)(A201TipoParAuxiliar), 1, 0));
               cmbTipoParMayoriza.Name = cmbTipoParMayoriza_Internalname ;
               cmbTipoParMayoriza.CurrentValue = cgiGet( cmbTipoParMayoriza_Internalname) ;
               A202TipoParMayoriza = (short)(NumberUtil.Val( cgiGet( cmbTipoParMayoriza_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A202TipoParMayoriza", StringUtil.Str( (decimal)(A202TipoParMayoriza), 1, 0));
               cmbTipoParEstado.Name = cmbTipoParEstado_Internalname ;
               cmbTipoParEstado.CurrentValue = cgiGet( cmbTipoParEstado_Internalname) ;
               A203TipoParEstado = (short)(NumberUtil.Val( cgiGet( cmbTipoParEstado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A203TipoParEstado", StringUtil.Str( (decimal)(A203TipoParEstado), 1, 0));
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z199TipoParCodigo = cgiGet( "Z199TipoParCodigo") ;
               Z200TipoParNombre = cgiGet( "Z200TipoParNombre") ;
               Z201TipoParAuxiliar = (short)(context.localUtil.CToN( cgiGet( "Z201TipoParAuxiliar"), ".", ",")) ;
               Z202TipoParMayoriza = (short)(context.localUtil.CToN( cgiGet( "Z202TipoParMayoriza"), ".", ",")) ;
               Z203TipoParEstado = (short)(context.localUtil.CToN( cgiGet( "Z203TipoParEstado"), ".", ",")) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               nRC_Gridtipopartida_tipopartidadetalle = (short)(context.localUtil.CToN( cgiGet( "nRC_Gridtipopartida_tipopartidadetalle"), ".", ",")) ;
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
                  A199TipoParCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
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
                           /* Execute user event: E11142 */
                           E11142 ();
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
               InitAll1451( ) ;
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
         DisableAttributes1451( ) ;
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

      protected void CONFIRM_1452( )
      {
         nGXsfl_70_idx = 0 ;
         while ( nGXsfl_70_idx < nRC_Gridtipopartida_tipopartidadetalle )
         {
            ReadRow1452( ) ;
            if ( ( nRcdExists_52 != 0 ) || ( nIsMod_52 != 0 ) )
            {
               GetKey1452( ) ;
               if ( ( nRcdExists_52 == 0 ) && ( nRcdDeleted_52 == 0 ) )
               {
                  if ( RcdFound52 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate1452( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable1452( ) ;
                        CloseExtendedTableCursors1452( ) ;
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
                     GX_FocusControl = edtTipoParAnio_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound52 != 0 )
                  {
                     if ( nRcdDeleted_52 != 0 )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey1452( ) ;
                        Load1452( ) ;
                        BeforeValidate1452( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls1452( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_52 != 0 )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate1452( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable1452( ) ;
                              CloseExtendedTableCursors1452( ) ;
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
                     if ( nRcdDeleted_52 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtTipoParAnio_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtTipoParAnio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A204TipoParAnio), 4, 0, ".", ""))) ;
            ChangePostValue( edtTipoParSiguiente_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A205TipoParSiguiente), 9, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z204TipoParAnio_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z204TipoParAnio), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z205TipoParSiguiente_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z205TipoParSiguiente), 9, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_52_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_52), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_52_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_52), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_52_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_52), 4, 0, ".", ""))) ;
            if ( nIsMod_52 != 0 )
            {
               ChangePostValue( "TIPOPARANIO_"+sGXsfl_70_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoParAnio_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPOPARSIGUIENTE_"+sGXsfl_70_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoParSiguiente_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption140( )
      {
      }

      protected void E11142( )
      {
         /* Start Routine */
         GXt_SdtParametros6 = AV7Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros6) ;
         AV7Parametros = GXt_SdtParametros6 ;
         AV8ClinicaCodigo = AV7Parametros.gxTpr_Pclinicacodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClinicaCodigo", AV8ClinicaCodigo);
      }

      protected void ZM1451( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z200TipoParNombre = T00145_A200TipoParNombre[0] ;
               Z201TipoParAuxiliar = T00145_A201TipoParAuxiliar[0] ;
               Z202TipoParMayoriza = T00145_A202TipoParMayoriza[0] ;
               Z203TipoParEstado = T00145_A203TipoParEstado[0] ;
            }
            else
            {
               Z200TipoParNombre = A200TipoParNombre ;
               Z201TipoParAuxiliar = A201TipoParAuxiliar ;
               Z202TipoParMayoriza = A202TipoParMayoriza ;
               Z203TipoParEstado = A203TipoParEstado ;
            }
         }
         if ( GX_JID == -4 )
         {
            Z199TipoParCodigo = A199TipoParCodigo ;
            Z200TipoParNombre = A200TipoParNombre ;
            Z201TipoParAuxiliar = A201TipoParAuxiliar ;
            Z202TipoParMayoriza = A202TipoParMayoriza ;
            Z203TipoParEstado = A203TipoParEstado ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
         }
      }

      protected void standaloneNotModal( )
      {
         lblTextblockclinicacodigo_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTextblockclinicacodigo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblTextblockclinicacodigo_Visible), 5, 0)));
         edtClinicaCodigo_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Visible), 5, 0)));
         imgprompt_41_Visible = edtClinicaCodigo_Visible ;
         imgprompt_41_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00g0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"true"+");") ;
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

      protected void Load1451( )
      {
         /* Using cursor T00147 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A199TipoParCodigo});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound51 = 1 ;
            A200TipoParNombre = T00147_A200TipoParNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A200TipoParNombre", A200TipoParNombre);
            A201TipoParAuxiliar = T00147_A201TipoParAuxiliar[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201TipoParAuxiliar", StringUtil.Str( (decimal)(A201TipoParAuxiliar), 1, 0));
            A202TipoParMayoriza = T00147_A202TipoParMayoriza[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A202TipoParMayoriza", StringUtil.Str( (decimal)(A202TipoParMayoriza), 1, 0));
            A203TipoParEstado = T00147_A203TipoParEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A203TipoParEstado", StringUtil.Str( (decimal)(A203TipoParEstado), 1, 0));
            ZM1451( -4) ;
         }
         pr_default.close(5);
         OnLoadActions1451( ) ;
      }

      protected void OnLoadActions1451( )
      {
      }

      protected void CheckExtendedTable1451( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T00146 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(4) == 101) )
         {
            AnyError41 = 1 ;
            GX_msglist.addItem("No existe 'Clínica Médica'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError41 == 0 )
         {
         }
         pr_default.close(4);
      }

      protected void CloseExtendedTableCursors1451( )
      {
         pr_default.close(4);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_5( String A41ClinicaCodigo )
      {
         /* Using cursor T00148 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(6) == 101) )
         {
            AnyError41 = 1 ;
            GX_msglist.addItem("No existe 'Clínica Médica'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError41 == 0 )
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

      protected void GetKey1451( )
      {
         /* Using cursor T00149 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A199TipoParCodigo});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound51 = 1 ;
         }
         else
         {
            RcdFound51 = 0 ;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00145 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A199TipoParCodigo});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM1451( 4) ;
            RcdFound51 = 1 ;
            A199TipoParCodigo = T00145_A199TipoParCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
            A200TipoParNombre = T00145_A200TipoParNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A200TipoParNombre", A200TipoParNombre);
            A201TipoParAuxiliar = T00145_A201TipoParAuxiliar[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201TipoParAuxiliar", StringUtil.Str( (decimal)(A201TipoParAuxiliar), 1, 0));
            A202TipoParMayoriza = T00145_A202TipoParMayoriza[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A202TipoParMayoriza", StringUtil.Str( (decimal)(A202TipoParMayoriza), 1, 0));
            A203TipoParEstado = T00145_A203TipoParEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A203TipoParEstado", StringUtil.Str( (decimal)(A203TipoParEstado), 1, 0));
            A41ClinicaCodigo = T00145_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z199TipoParCodigo = A199TipoParCodigo ;
            sMode51 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1451( ) ;
            Gx_mode = sMode51 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound51 = 0 ;
            InitializeNonKey1451( ) ;
            sMode51 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode51 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey1451( ) ;
         if ( RcdFound51 == 0 )
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
         RcdFound51 = 0 ;
         /* Using cursor T001410 */
         pr_default.execute(8, new Object[] {A41ClinicaCodigo, A199TipoParCodigo});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T001410_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001410_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001410_A199TipoParCodigo[0], A199TipoParCodigo) < 0 ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T001410_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001410_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001410_A199TipoParCodigo[0], A199TipoParCodigo) > 0 ) ) )
            {
               A41ClinicaCodigo = T001410_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A199TipoParCodigo = T001410_A199TipoParCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
               RcdFound51 = 1 ;
            }
         }
         pr_default.close(3);
      }

      protected void move_previous( )
      {
         RcdFound51 = 0 ;
         /* Using cursor T001411 */
         pr_default.execute(9, new Object[] {A41ClinicaCodigo, A199TipoParCodigo});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T001411_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001411_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001411_A199TipoParCodigo[0], A199TipoParCodigo) > 0 ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T001411_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001411_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001411_A199TipoParCodigo[0], A199TipoParCodigo) < 0 ) ) )
            {
               A41ClinicaCodigo = T001411_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A199TipoParCodigo = T001411_A199TipoParCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
               RcdFound51 = 1 ;
            }
         }
         pr_default.close(2);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1451( ) ;
         if ( RcdFound51 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A199TipoParCodigo, Z199TipoParCodigo) != 0 ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A199TipoParCodigo = Z199TipoParCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
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
               Update1451( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A199TipoParCodigo, Z199TipoParCodigo) != 0 ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert1451( ) ;
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
                  Insert1451( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A199TipoParCodigo, Z199TipoParCodigo) != 0 ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A199TipoParCodigo = Z199TipoParCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
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
         if ( RcdFound51 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtTipoParNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1451( ) ;
         if ( RcdFound51 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTipoParNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1451( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound51 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTipoParNombre_Internalname ;
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
         if ( RcdFound51 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTipoParNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1451( ) ;
         if ( RcdFound51 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound51 != 0 )
            {
               ScanNext1451( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTipoParNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1451( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1451( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001412 */
            pr_default.execute(10, new Object[] {A41ClinicaCodigo, A199TipoParCodigo});
            if ( (pr_default.getStatus(10) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TipoPartida"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(10) == 101) || ( StringUtil.StrCmp(Z200TipoParNombre, T001412_A200TipoParNombre[0]) != 0 ) || ( Z201TipoParAuxiliar != T001412_A201TipoParAuxiliar[0] ) || ( Z202TipoParMayoriza != T001412_A202TipoParMayoriza[0] ) || ( Z203TipoParEstado != T001412_A203TipoParEstado[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TipoPartida"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1451( )
      {
         BeforeValidate1451( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1451( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1451( 0) ;
            CheckOptimisticConcurrency1451( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1451( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1451( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001413 */
                     pr_default.execute(11, new Object[] {A199TipoParCodigo, A200TipoParNombre, A201TipoParAuxiliar, A202TipoParMayoriza, A203TipoParEstado, A41ClinicaCodigo});
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
                           ProcessLevel1451( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                              ResetCaption140( ) ;
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
               Load1451( ) ;
            }
            EndLevel1451( ) ;
         }
         CloseExtendedTableCursors1451( ) ;
      }

      protected void Update1451( )
      {
         BeforeValidate1451( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1451( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1451( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1451( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1451( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001414 */
                     pr_default.execute(12, new Object[] {A200TipoParNombre, A201TipoParAuxiliar, A202TipoParMayoriza, A203TipoParEstado, A41ClinicaCodigo, A199TipoParCodigo});
                     pr_default.close(12);
                     if ( (pr_default.getStatus(12) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TipoPartida"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1451( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel1451( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                              ResetCaption140( ) ;
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
            EndLevel1451( ) ;
         }
         CloseExtendedTableCursors1451( ) ;
      }

      protected void DeferredUpdate1451( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1451( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1451( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1451( ) ;
            AfterConfirm1451( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1451( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart1452( ) ;
                  while ( RcdFound52 != 0 )
                  {
                     getByPrimaryKey1452( ) ;
                     Delete1452( ) ;
                     ScanNext1452( ) ;
                  }
                  ScanEnd1452( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001415 */
                     pr_default.execute(13, new Object[] {A41ClinicaCodigo, A199TipoParCodigo});
                     pr_default.close(13);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound51 == 0 )
                           {
                              InitAll1451( ) ;
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
                           ResetCaption140( ) ;
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
         sMode51 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1451( ) ;
         Gx_mode = sMode51 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1451( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T001416 */
            pr_default.execute(14, new Object[] {A41ClinicaCodigo, A199TipoParCodigo});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Movimiento Contable Reversado"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(14);
            /* Using cursor T001417 */
            pr_default.execute(15, new Object[] {A41ClinicaCodigo, A199TipoParCodigo});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Movimiento mayorizado de partidas contables"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(15);
            /* Using cursor T001418 */
            pr_default.execute(16, new Object[] {A41ClinicaCodigo, A199TipoParCodigo});
            if ( (pr_default.getStatus(16) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Encabezado de partida contable"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(16);
         }
      }

      protected void ProcessNestedLevel1452( )
      {
         nGXsfl_70_idx = 0 ;
         while ( nGXsfl_70_idx < nRC_Gridtipopartida_tipopartidadetalle )
         {
            ReadRow1452( ) ;
            if ( ( nRcdExists_52 != 0 ) || ( nIsMod_52 != 0 ) )
            {
               standaloneNotModal1452( ) ;
               GetKey1452( ) ;
               if ( ( nRcdExists_52 == 0 ) && ( nRcdDeleted_52 == 0 ) )
               {
                  if ( RcdFound52 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Insert1452( ) ;
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtTipoParAnio_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound52 != 0 )
                  {
                     if ( ( nRcdDeleted_52 != 0 ) && ( nRcdExists_52 != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete1452( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_52 != 0 ) && ( nRcdExists_52 != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update1452( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_52 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtTipoParAnio_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtTipoParAnio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A204TipoParAnio), 4, 0, ".", ""))) ;
            ChangePostValue( edtTipoParSiguiente_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A205TipoParSiguiente), 9, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z204TipoParAnio_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z204TipoParAnio), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z205TipoParSiguiente_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z205TipoParSiguiente), 9, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_52_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_52), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_52_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_52), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_52_"+sGXsfl_70_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_52), 4, 0, ".", ""))) ;
            if ( nIsMod_52 != 0 )
            {
               ChangePostValue( "TIPOPARANIO_"+sGXsfl_70_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoParAnio_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPOPARSIGUIENTE_"+sGXsfl_70_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoParSiguiente_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll1452( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_52 = 0 ;
         nIsMod_52 = 0 ;
         nRcdDeleted_52 = 0 ;
      }

      protected void ProcessLevel1451( )
      {
         /* Save parent mode. */
         sMode51 = Gx_mode ;
         ProcessNestedLevel1452( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode51 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel1451( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1451( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(9);
            pr_default.close(8);
            pr_default.close(1);
            pr_default.close(0);
            context.CommitDataStores("TipoPartida");
            if ( AnyError == 0 )
            {
               ConfirmValues140( ) ;
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
            context.RollbackDataStores("TipoPartida");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1451( )
      {
         /* Using cursor T001419 */
         pr_default.execute(17);
         RcdFound51 = 0 ;
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound51 = 1 ;
            A41ClinicaCodigo = T001419_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A199TipoParCodigo = T001419_A199TipoParCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1451( )
      {
         pr_default.readNext(17);
         RcdFound51 = 0 ;
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound51 = 1 ;
            A41ClinicaCodigo = T001419_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A199TipoParCodigo = T001419_A199TipoParCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
         }
      }

      protected void ScanEnd1451( )
      {
      }

      protected void AfterConfirm1451( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1451( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1451( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1451( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1451( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1451( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1451( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtTipoParCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoParCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoParCodigo_Enabled), 5, 0)));
         edtTipoParNombre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoParNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoParNombre_Enabled), 5, 0)));
         cmbTipoParAuxiliar.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoParAuxiliar_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTipoParAuxiliar.Enabled), 5, 0)));
         cmbTipoParMayoriza.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoParMayoriza_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTipoParMayoriza.Enabled), 5, 0)));
         cmbTipoParEstado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoParEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTipoParEstado.Enabled), 5, 0)));
      }

      protected void ZM1452( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z205TipoParSiguiente = T00143_A205TipoParSiguiente[0] ;
            }
            else
            {
               Z205TipoParSiguiente = A205TipoParSiguiente ;
            }
         }
         if ( GX_JID == -6 )
         {
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z199TipoParCodigo = A199TipoParCodigo ;
            Z204TipoParAnio = A204TipoParAnio ;
            Z205TipoParSiguiente = A205TipoParSiguiente ;
         }
      }

      protected void standaloneNotModal1452( )
      {
      }

      protected void standaloneModal1452( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtTipoParAnio_Enabled = 0 ;
         }
         else
         {
            edtTipoParAnio_Enabled = 1 ;
         }
         if ( ( StringUtil.StrCmp(sMode52, "DSP") == 0 ) || ( StringUtil.StrCmp(sMode52, "DLT") == 0 ) )
         {
            DisableAttributes1452( ) ;
         }
      }

      protected void Load1452( )
      {
         /* Using cursor T001420 */
         pr_default.execute(18, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A204TipoParAnio});
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound52 = 1 ;
            A205TipoParSiguiente = T001420_A205TipoParSiguiente[0] ;
            ZM1452( -6) ;
         }
         pr_default.close(18);
         OnLoadActions1452( ) ;
      }

      protected void OnLoadActions1452( )
      {
      }

      protected void CheckExtendedTable1452( )
      {
         Gx_BScreen = 1 ;
         standaloneModal1452( ) ;
      }

      protected void CloseExtendedTableCursors1452( )
      {
      }

      protected void enableDisable1452( )
      {
      }

      protected void GetKey1452( )
      {
         /* Using cursor T001421 */
         pr_default.execute(19, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A204TipoParAnio});
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound52 = 1 ;
         }
         else
         {
            RcdFound52 = 0 ;
         }
         pr_default.close(19);
      }

      protected void getByPrimaryKey1452( )
      {
         /* Using cursor T00143 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A204TipoParAnio});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1452( 6) ;
            RcdFound52 = 1 ;
            InitializeNonKey1452( ) ;
            A204TipoParAnio = T00143_A204TipoParAnio[0] ;
            A205TipoParSiguiente = T00143_A205TipoParSiguiente[0] ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z199TipoParCodigo = A199TipoParCodigo ;
            Z204TipoParAnio = A204TipoParAnio ;
            sMode52 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal1452( ) ;
            Load1452( ) ;
            Gx_mode = sMode52 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound52 = 0 ;
            InitializeNonKey1452( ) ;
            sMode52 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal1452( ) ;
            Gx_mode = sMode52 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency1452( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00142 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A204TipoParAnio});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TipoPartidaDetalle"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z205TipoParSiguiente != T00142_A205TipoParSiguiente[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TipoPartidaDetalle"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1452( )
      {
         BeforeValidate1452( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1452( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1452( 0) ;
            CheckOptimisticConcurrency1452( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1452( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1452( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001422 */
                     pr_default.execute(20, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A204TipoParAnio, A205TipoParSiguiente});
                     pr_default.close(20);
                     if ( (pr_default.getStatus(20) == 1) )
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
               Load1452( ) ;
            }
            EndLevel1452( ) ;
         }
         CloseExtendedTableCursors1452( ) ;
      }

      protected void Update1452( )
      {
         BeforeValidate1452( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1452( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1452( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1452( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1452( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001423 */
                     pr_default.execute(21, new Object[] {A205TipoParSiguiente, A41ClinicaCodigo, A199TipoParCodigo, A204TipoParAnio});
                     pr_default.close(21);
                     if ( (pr_default.getStatus(21) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TipoPartidaDetalle"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1452( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey1452( ) ;
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
            EndLevel1452( ) ;
         }
         CloseExtendedTableCursors1452( ) ;
      }

      protected void DeferredUpdate1452( )
      {
      }

      protected void Delete1452( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1452( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1452( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1452( ) ;
            AfterConfirm1452( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1452( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001424 */
                  pr_default.execute(22, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A204TipoParAnio});
                  pr_default.close(22);
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
         sMode52 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1452( ) ;
         Gx_mode = sMode52 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1452( )
      {
         standaloneModal1452( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1452( )
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

      protected void ScanStart1452( )
      {
         /* Using cursor T001425 */
         pr_default.execute(23, new Object[] {A41ClinicaCodigo, A199TipoParCodigo});
         RcdFound52 = 0 ;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound52 = 1 ;
            A204TipoParAnio = T001425_A204TipoParAnio[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1452( )
      {
         pr_default.readNext(23);
         RcdFound52 = 0 ;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound52 = 1 ;
            A204TipoParAnio = T001425_A204TipoParAnio[0] ;
         }
      }

      protected void ScanEnd1452( )
      {
         pr_default.close(1);
      }

      protected void AfterConfirm1452( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1452( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1452( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1452( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1452( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1452( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1452( )
      {
         edtTipoParAnio_Enabled = 0 ;
         edtTipoParSiguiente_Enabled = 0 ;
      }

      protected void AddRow1452( )
      {
         nGXsfl_70_idx = (short)(nGXsfl_70_idx+1) ;
         sGXsfl_70_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_70_idx), 4, 0)), 4, "0") ;
         edtTipoParAnio_Internalname = "TIPOPARANIO_"+sGXsfl_70_idx ;
         edtTipoParSiguiente_Internalname = "TIPOPARSIGUIENTE_"+sGXsfl_70_idx ;
         SendRow1452( ) ;
      }

      protected void SendRow1452( )
      {
         Gridtipopartida_tipopartidadetalleRow = GXWebRow.GetNew(context) ;
         if ( subGridtipopartida_tipopartidadetalle_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridtipopartida_tipopartidadetalle_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGridtipopartida_tipopartidadetalle_Class, "") != 0 )
            {
               subGridtipopartida_tipopartidadetalle_Linesclass = subGridtipopartida_tipopartidadetalle_Class+"Odd" ;
            }
         }
         else if ( subGridtipopartida_tipopartidadetalle_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridtipopartida_tipopartidadetalle_Backstyle = 0 ;
            subGridtipopartida_tipopartidadetalle_Backcolor = subGridtipopartida_tipopartidadetalle_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridtipopartida_tipopartidadetalleContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridtipopartida_tipopartidadetalle_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGridtipopartida_tipopartidadetalle_Class, "") != 0 )
            {
               subGridtipopartida_tipopartidadetalle_Linesclass = subGridtipopartida_tipopartidadetalle_Class+"Uniform" ;
            }
         }
         else if ( subGridtipopartida_tipopartidadetalle_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridtipopartida_tipopartidadetalle_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGridtipopartida_tipopartidadetalle_Class, "") != 0 )
            {
               subGridtipopartida_tipopartidadetalle_Linesclass = subGridtipopartida_tipopartidadetalle_Class+"Odd" ;
            }
            subGridtipopartida_tipopartidadetalle_Backcolor = (int)(0xFFFFFF) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridtipopartida_tipopartidadetalleContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridtipopartida_tipopartidadetalle_Backcolor), 9, 0)));
         }
         else if ( subGridtipopartida_tipopartidadetalle_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridtipopartida_tipopartidadetalle_Backstyle = 1 ;
            if ( ((int)(nGXsfl_70_idx) % (2)) == 0 )
            {
               subGridtipopartida_tipopartidadetalle_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridtipopartida_tipopartidadetalleContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridtipopartida_tipopartidadetalle_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridtipopartida_tipopartidadetalle_Class, "") != 0 )
               {
                  subGridtipopartida_tipopartidadetalle_Linesclass = subGridtipopartida_tipopartidadetalle_Class+"Even" ;
               }
            }
            else
            {
               subGridtipopartida_tipopartidadetalle_Backcolor = (int)(0xFFFFFF) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridtipopartida_tipopartidadetalleContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridtipopartida_tipopartidadetalle_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridtipopartida_tipopartidadetalle_Class, "") != 0 )
               {
                  subGridtipopartida_tipopartidadetalle_Linesclass = subGridtipopartida_tipopartidadetalle_Class+"Odd" ;
               }
            }
         }
         /* * Property Link not supported in */
         /* * Property Link not supported in */
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_52_" + sGXsfl_70_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_70_idx + "',70)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridtipopartida_tipopartidadetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoParAnio_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A204TipoParAnio), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A204TipoParAnio), "ZZZ9")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(71);\"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoParAnio_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtTipoParAnio_Enabled,(short)1,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)70,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_52_" + sGXsfl_70_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 72,'',false,'" + sGXsfl_70_idx + "',70)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridtipopartida_tipopartidadetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoParSiguiente_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A205TipoParSiguiente), 9, 0, ".", "")),((edtTipoParSiguiente_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A205TipoParSiguiente), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A205TipoParSiguiente), "ZZZZZZZZ9")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(72);\"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoParSiguiente_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtTipoParSiguiente_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)70,(short)1,(short)-1,(bool)true,(String)"right"});
         context.httpAjaxContext.ajax_sending_grid_row(Gridtipopartida_tipopartidadetalleRow);
         GXCCtl = "Z204TipoParAnio_" + sGXsfl_70_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z204TipoParAnio), 4, 0, ".", "")));
         GXCCtl = "Z205TipoParSiguiente_" + sGXsfl_70_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z205TipoParSiguiente), 9, 0, ".", "")));
         GXCCtl = "nRcdDeleted_52_" + sGXsfl_70_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_52), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_52_" + sGXsfl_70_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_52), 4, 0, ".", "")));
         GXCCtl = "nIsMod_52_" + sGXsfl_70_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_52), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TIPOPARANIO_"+sGXsfl_70_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoParAnio_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TIPOPARSIGUIENTE_"+sGXsfl_70_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoParSiguiente_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridtipopartida_tipopartidadetalleContainer.AddRow(Gridtipopartida_tipopartidadetalleRow);
      }

      protected void ReadRow1452( )
      {
         nGXsfl_70_idx = (short)(nGXsfl_70_idx+1) ;
         sGXsfl_70_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_70_idx), 4, 0)), 4, "0") ;
         edtTipoParAnio_Internalname = "TIPOPARANIO_"+sGXsfl_70_idx ;
         edtTipoParSiguiente_Internalname = "TIPOPARSIGUIENTE_"+sGXsfl_70_idx ;
         edtTipoParAnio_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPOPARANIO_"+sGXsfl_70_idx+"Enabled"), ".", ",")) ;
         edtTipoParSiguiente_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPOPARSIGUIENTE_"+sGXsfl_70_idx+"Enabled"), ".", ",")) ;
         if ( ( ( context.localUtil.CToN( cgiGet( edtTipoParAnio_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtTipoParAnio_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "TIPOPARANIO");
            AnyError = 1 ;
            GX_FocusControl = edtTipoParAnio_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A204TipoParAnio = 0 ;
         }
         else
         {
            A204TipoParAnio = (short)(context.localUtil.CToN( cgiGet( edtTipoParAnio_Internalname), ".", ",")) ;
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtTipoParSiguiente_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtTipoParSiguiente_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "TIPOPARSIGUIENTE");
            AnyError = 1 ;
            GX_FocusControl = edtTipoParSiguiente_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A205TipoParSiguiente = 0 ;
         }
         else
         {
            A205TipoParSiguiente = (int)(context.localUtil.CToN( cgiGet( edtTipoParSiguiente_Internalname), ".", ",")) ;
         }
         GXCCtl = "Z204TipoParAnio_" + sGXsfl_70_idx ;
         Z204TipoParAnio = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "Z205TipoParSiguiente_" + sGXsfl_70_idx ;
         Z205TipoParSiguiente = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdDeleted_52_" + sGXsfl_70_idx ;
         nRcdDeleted_52 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdExists_52_" + sGXsfl_70_idx ;
         nRcdExists_52 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nIsMod_52_" + sGXsfl_70_idx ;
         nIsMod_52 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
      }

      protected void assign_properties_default( )
      {
         defedtTipoParAnio_Enabled = edtTipoParAnio_Enabled ;
      }

      protected void ConfirmValues140( )
      {
         nGXsfl_70_idx = 0 ;
         sGXsfl_70_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_70_idx), 4, 0)), 4, "0") ;
         edtTipoParAnio_Internalname = "TIPOPARANIO_"+sGXsfl_70_idx ;
         edtTipoParSiguiente_Internalname = "TIPOPARSIGUIENTE_"+sGXsfl_70_idx ;
         while ( nGXsfl_70_idx < nRC_Gridtipopartida_tipopartidadetalle )
         {
            nGXsfl_70_idx = (short)(nGXsfl_70_idx+1) ;
            sGXsfl_70_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_70_idx), 4, 0)), 4, "0") ;
            edtTipoParAnio_Internalname = "TIPOPARANIO_"+sGXsfl_70_idx ;
            edtTipoParSiguiente_Internalname = "TIPOPARSIGUIENTE_"+sGXsfl_70_idx ;
            ChangePostValue( "Z204TipoParAnio_"+sGXsfl_70_idx, cgiGet( "ZT_"+"Z204TipoParAnio_"+sGXsfl_70_idx)) ;
            DeletePostValue( "ZT_"+"Z204TipoParAnio_"+sGXsfl_70_idx) ;
            ChangePostValue( "Z205TipoParSiguiente_"+sGXsfl_70_idx, cgiGet( "ZT_"+"Z205TipoParSiguiente_"+sGXsfl_70_idx)) ;
            DeletePostValue( "ZT_"+"Z205TipoParSiguiente_"+sGXsfl_70_idx) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tipopartida.aspx") +"\" class=\""+"Form"+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z200TipoParNombre", StringUtil.RTrim( Z200TipoParNombre));
         GxWebStd.gx_hidden_field( context, "Z201TipoParAuxiliar", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z201TipoParAuxiliar), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z202TipoParMayoriza", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z202TipoParMayoriza), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z203TipoParEstado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z203TipoParEstado), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_Gridtipopartida_tipopartidadetalle", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_70_idx), 4, 0, ".", "")));
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
         return "TipoPartida" ;
      }

      public override String GetPgmdesc( )
      {
         return "Tipos de Partidas Contables" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("tipopartida.aspx")  ;
      }

      protected void InitializeNonKey1451( )
      {
         A200TipoParNombre = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A200TipoParNombre", A200TipoParNombre);
         A201TipoParAuxiliar = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201TipoParAuxiliar", StringUtil.Str( (decimal)(A201TipoParAuxiliar), 1, 0));
         A202TipoParMayoriza = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A202TipoParMayoriza", StringUtil.Str( (decimal)(A202TipoParMayoriza), 1, 0));
         A203TipoParEstado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A203TipoParEstado", StringUtil.Str( (decimal)(A203TipoParEstado), 1, 0));
      }

      protected void InitAll1451( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A199TipoParCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
         InitializeNonKey1451( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey1452( )
      {
         A205TipoParSiguiente = 0 ;
      }

      protected void InitAll1452( )
      {
         A204TipoParAnio = 0 ;
         InitializeNonKey1452( ) ;
      }

      protected void StandaloneModalInsert1452( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1561925");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("tipopartida.js", "?1561926");
         /* End function include_jscripts */
      }

      protected void init_level_properties52( )
      {
         edtTipoParAnio_Enabled = defedtTipoParAnio_Enabled ;
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
         lblTextblocktipoparnombre_Internalname = "TEXTBLOCKTIPOPARNOMBRE" ;
         edtTipoParNombre_Internalname = "TIPOPARNOMBRE" ;
         lblTextblocktipoparauxiliar_Internalname = "TEXTBLOCKTIPOPARAUXILIAR" ;
         cmbTipoParAuxiliar_Internalname = "TIPOPARAUXILIAR" ;
         lblTextblocktipoparmayoriza_Internalname = "TEXTBLOCKTIPOPARMAYORIZA" ;
         cmbTipoParMayoriza_Internalname = "TIPOPARMAYORIZA" ;
         lblTextblocktipoparestado_Internalname = "TEXTBLOCKTIPOPARESTADO" ;
         cmbTipoParEstado_Internalname = "TIPOPARESTADO" ;
         lblTitletipopartidadetalle_Internalname = "TITLETIPOPARTIDADETALLE" ;
         tblTable3_Internalname = "TABLE3" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_Internalname = "PROMPT_41" ;
         subGridtipopartida_tipopartidadetalle_Internalname = "GRIDTIPOPARTIDA_TIPOPARTIDADETALLE" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Tipos de Partidas Contables" ;
         edtTipoParSiguiente_Jsonclick = "" ;
         edtTipoParAnio_Jsonclick = "" ;
         subGridtipopartida_tipopartidadetalle_Class = "Grid" ;
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
         subGridtipopartida_tipopartidadetalle_Allowcollapsing = 0 ;
         edtTipoParSiguiente_Enabled = 1 ;
         edtTipoParAnio_Enabled = 1 ;
         subGridtipopartida_tipopartidadetalle_Backcolorstyle = 2 ;
         cmbTipoParEstado_Jsonclick = "" ;
         cmbTipoParEstado.Enabled = 1 ;
         cmbTipoParMayoriza_Jsonclick = "" ;
         cmbTipoParMayoriza.Enabled = 1 ;
         cmbTipoParAuxiliar_Jsonclick = "" ;
         cmbTipoParAuxiliar.Enabled = 1 ;
         edtTipoParNombre_Jsonclick = "" ;
         edtTipoParNombre_Enabled = 1 ;
         edtTipoParCodigo_Jsonclick = "" ;
         edtTipoParCodigo_Enabled = 1 ;
         imgprompt_41_Link = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtClinicaCodigo_Enabled = 1 ;
         edtClinicaCodigo_Visible = 1 ;
         lblTextblockclinicacodigo_Visible = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         imgprompt_41_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGridtipopartida_tipopartidadetalle_newrow( short nRC_Gridtipopartida_tipopartidadetalle ,
                                                                    short nGXsfl_70_idx ,
                                                                    String sGXsfl_70_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         edtTipoParAnio_Internalname = "TIPOPARANIO_"+sGXsfl_70_idx ;
         edtTipoParSiguiente_Internalname = "TIPOPARSIGUIENTE_"+sGXsfl_70_idx ;
         while ( nGXsfl_70_idx <= nRC_Gridtipopartida_tipopartidadetalle )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal1452( ) ;
            standaloneModal1452( ) ;
            cmbTipoParAuxiliar.Name = "TIPOPARAUXILIAR" ;
            cmbTipoParAuxiliar.WebTags = "" ;
            cmbTipoParAuxiliar.addItem("1", "Contabilidad", 0);
            cmbTipoParAuxiliar.addItem("2", "Inventario", 0);
            cmbTipoParAuxiliar.addItem("3", "Facturación", 0);
            if ( ( cmbTipoParAuxiliar.ItemCount > 0 ) && (0==A201TipoParAuxiliar) )
            {
               A201TipoParAuxiliar = (short)(NumberUtil.Val( cmbTipoParAuxiliar.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201TipoParAuxiliar", StringUtil.Str( (decimal)(A201TipoParAuxiliar), 1, 0));
            }
            cmbTipoParMayoriza.Name = "TIPOPARMAYORIZA" ;
            cmbTipoParMayoriza.WebTags = "" ;
            cmbTipoParMayoriza.addItem("0", "No", 0);
            cmbTipoParMayoriza.addItem("1", "Si", 0);
            if ( ( cmbTipoParMayoriza.ItemCount > 0 ) && (0==A202TipoParMayoriza) )
            {
               A202TipoParMayoriza = (short)(NumberUtil.Val( cmbTipoParMayoriza.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A202TipoParMayoriza", StringUtil.Str( (decimal)(A202TipoParMayoriza), 1, 0));
            }
            cmbTipoParEstado.Name = "TIPOPARESTADO" ;
            cmbTipoParEstado.WebTags = "" ;
            cmbTipoParEstado.addItem("0", "De baja", 0);
            cmbTipoParEstado.addItem("1", "Activo", 0);
            if ( ( cmbTipoParEstado.ItemCount > 0 ) && (0==A203TipoParEstado) )
            {
               A203TipoParEstado = (short)(NumberUtil.Val( cmbTipoParEstado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A203TipoParEstado", StringUtil.Str( (decimal)(A203TipoParEstado), 1, 0));
            }
            dynload_actions( ) ;
            SendRow1452( ) ;
            nGXsfl_70_idx = (short)(nGXsfl_70_idx+1) ;
            sGXsfl_70_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_70_idx), 4, 0)), 4, "0") ;
            edtTipoParAnio_Internalname = "TIPOPARANIO_"+sGXsfl_70_idx ;
            edtTipoParSiguiente_Internalname = "TIPOPARSIGUIENTE_"+sGXsfl_70_idx ;
         }
         context.GX_webresponse.AddString(Gridtipopartida_tipopartidadetalleContainer.ToJavascriptSource());
         /* End function gxnrGridtipopartida_tipopartidadetalle_newrow */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         /* Using cursor T001426 */
         pr_default.execute(24, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(24) == 101) )
         {
            AnyError41 = 1 ;
            GX_msglist.addItem("No existe 'Clínica Médica'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError41 == 0 )
         {
         }
         pr_default.close(24);
         GX_FocusControl = edtTipoParNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Clinicacodigo( String GX_Parm1 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         /* Using cursor T001426 */
         pr_default.execute(24, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(24) == 101) )
         {
            AnyError41 = 1 ;
            GX_msglist.addItem("No existe 'Clínica Médica'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( AnyError41 == 0 )
         {
         }
         pr_default.close(24);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Tipoparcodigo( String GX_Parm1 ,
                                       String GX_Parm2 ,
                                       String GX_Parm3 ,
                                       String GX_Parm4 ,
                                       GXCombobox cmbGX_Parm5 ,
                                       GXCombobox cmbGX_Parm6 ,
                                       GXCombobox cmbGX_Parm7 )
      {
         AV8ClinicaCodigo = GX_Parm1 ;
         A41ClinicaCodigo = GX_Parm2 ;
         A199TipoParCodigo = GX_Parm3 ;
         A200TipoParNombre = GX_Parm4 ;
         cmbTipoParAuxiliar = cmbGX_Parm5 ;
         A201TipoParAuxiliar = (short)(NumberUtil.Val( cmbTipoParAuxiliar.CurrentValue, ".")) ;
         cmbTipoParAuxiliar.CurrentValue = StringUtil.Str( (decimal)(A201TipoParAuxiliar), 1, 0) ;
         cmbTipoParMayoriza = cmbGX_Parm6 ;
         A202TipoParMayoriza = (short)(NumberUtil.Val( cmbTipoParMayoriza.CurrentValue, ".")) ;
         cmbTipoParMayoriza.CurrentValue = StringUtil.Str( (decimal)(A202TipoParMayoriza), 1, 0) ;
         cmbTipoParEstado = cmbGX_Parm7 ;
         A203TipoParEstado = (short)(NumberUtil.Val( cmbTipoParEstado.CurrentValue, ".")) ;
         cmbTipoParEstado.CurrentValue = StringUtil.Str( (decimal)(A203TipoParEstado), 1, 0) ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A200TipoParNombre)));
         cmbTipoParAuxiliar.CurrentValue = StringUtil.Str( (decimal)(A201TipoParAuxiliar), 1, 0) ;
         isValidOutput.Add((Object)(cmbTipoParAuxiliar));
         cmbTipoParMayoriza.CurrentValue = StringUtil.Str( (decimal)(A202TipoParMayoriza), 1, 0) ;
         isValidOutput.Add((Object)(cmbTipoParMayoriza));
         cmbTipoParEstado.CurrentValue = StringUtil.Str( (decimal)(A203TipoParEstado), 1, 0) ;
         isValidOutput.Add((Object)(cmbTipoParEstado));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z199TipoParCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z200TipoParNombre)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z201TipoParAuxiliar), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z202TipoParMayoriza), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z203TipoParEstado), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(Gridtipopartida_tipopartidadetalleContainer));
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
         pr_default.close(23);
         pr_default.close(17);
         pr_default.close(9);
         pr_default.close(8);
         pr_default.close(24);
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
         lblTextblocktipoparcodigo_Jsonclick = "" ;
         A199TipoParCodigo = "" ;
         lblTextblocktipoparnombre_Jsonclick = "" ;
         A200TipoParNombre = "" ;
         lblTextblocktipoparauxiliar_Jsonclick = "" ;
         lblTextblocktipoparmayoriza_Jsonclick = "" ;
         lblTextblocktipoparestado_Jsonclick = "" ;
         Gridtipopartida_tipopartidadetalleContainer = new GXWebGrid( context);
         Gridtipopartida_tipopartidadetalleColumn = new GXWebColumn();
         Gx_mode = "" ;
         sMode52 = "" ;
         edtTipoParAnio_Internalname = "" ;
         lblTitletipopartidadetalle_Jsonclick = "" ;
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
         Z200TipoParNombre = "" ;
         AV8ClinicaCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtTipoParSiguiente_Internalname = "" ;
         AV7Parametros = new SdtParametros(context);
         GXt_SdtParametros6 = new SdtParametros(context);
         T00147_A199TipoParCodigo = new String[] {""} ;
         T00147_A200TipoParNombre = new String[] {""} ;
         T00147_A201TipoParAuxiliar = new short[1] ;
         T00147_A202TipoParMayoriza = new short[1] ;
         T00147_A203TipoParEstado = new short[1] ;
         T00147_A41ClinicaCodigo = new String[] {""} ;
         T00146_A41ClinicaCodigo = new String[] {""} ;
         T00148_A41ClinicaCodigo = new String[] {""} ;
         T00149_A41ClinicaCodigo = new String[] {""} ;
         T00149_A199TipoParCodigo = new String[] {""} ;
         T00145_A199TipoParCodigo = new String[] {""} ;
         T00145_A200TipoParNombre = new String[] {""} ;
         T00145_A201TipoParAuxiliar = new short[1] ;
         T00145_A202TipoParMayoriza = new short[1] ;
         T00145_A203TipoParEstado = new short[1] ;
         T00145_A41ClinicaCodigo = new String[] {""} ;
         sMode51 = "" ;
         T001410_A41ClinicaCodigo = new String[] {""} ;
         T001410_A199TipoParCodigo = new String[] {""} ;
         T001411_A41ClinicaCodigo = new String[] {""} ;
         T001411_A199TipoParCodigo = new String[] {""} ;
         T001412_A199TipoParCodigo = new String[] {""} ;
         T001412_A200TipoParNombre = new String[] {""} ;
         T001412_A201TipoParAuxiliar = new short[1] ;
         T001412_A202TipoParMayoriza = new short[1] ;
         T001412_A203TipoParEstado = new short[1] ;
         T001412_A41ClinicaCodigo = new String[] {""} ;
         T001416_A41ClinicaCodigo = new String[] {""} ;
         T001416_A199TipoParCodigo = new String[] {""} ;
         T001416_A290MovReversadoId = new int[1] ;
         T001416_A291MovReversadoLinea = new short[1] ;
         T001417_A41ClinicaCodigo = new String[] {""} ;
         T001417_A199TipoParCodigo = new String[] {""} ;
         T001417_A217MovMayorizadoId = new int[1] ;
         T001417_A218MovMayorizadoLinea = new short[1] ;
         T001418_A41ClinicaCodigo = new String[] {""} ;
         T001418_A199TipoParCodigo = new String[] {""} ;
         T001418_A207PartidaId = new int[1] ;
         T001419_A41ClinicaCodigo = new String[] {""} ;
         T001419_A199TipoParCodigo = new String[] {""} ;
         T001420_A41ClinicaCodigo = new String[] {""} ;
         T001420_A199TipoParCodigo = new String[] {""} ;
         T001420_A204TipoParAnio = new short[1] ;
         T001420_A205TipoParSiguiente = new int[1] ;
         T001421_A41ClinicaCodigo = new String[] {""} ;
         T001421_A199TipoParCodigo = new String[] {""} ;
         T001421_A204TipoParAnio = new short[1] ;
         T00143_A41ClinicaCodigo = new String[] {""} ;
         T00143_A199TipoParCodigo = new String[] {""} ;
         T00143_A204TipoParAnio = new short[1] ;
         T00143_A205TipoParSiguiente = new int[1] ;
         T00142_A41ClinicaCodigo = new String[] {""} ;
         T00142_A199TipoParCodigo = new String[] {""} ;
         T00142_A204TipoParAnio = new short[1] ;
         T00142_A205TipoParSiguiente = new int[1] ;
         T001425_A41ClinicaCodigo = new String[] {""} ;
         T001425_A199TipoParCodigo = new String[] {""} ;
         T001425_A204TipoParAnio = new short[1] ;
         Gridtipopartida_tipopartidadetalleRow = new GXWebRow();
         subGridtipopartida_tipopartidadetalle_Linesclass = "" ;
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
         T001426_A41ClinicaCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tipopartida__default(),
            new Object[][] {
                new Object[] {
               T00142_A41ClinicaCodigo, T00142_A199TipoParCodigo, T00142_A204TipoParAnio, T00142_A205TipoParSiguiente
               }
               , new Object[] {
               T00143_A41ClinicaCodigo, T00143_A199TipoParCodigo, T00143_A204TipoParAnio, T00143_A205TipoParSiguiente
               }
               , new Object[] {
               T00144_A199TipoParCodigo, T00144_A200TipoParNombre, T00144_A201TipoParAuxiliar, T00144_A202TipoParMayoriza, T00144_A203TipoParEstado, T00144_A41ClinicaCodigo
               }
               , new Object[] {
               T00145_A199TipoParCodigo, T00145_A200TipoParNombre, T00145_A201TipoParAuxiliar, T00145_A202TipoParMayoriza, T00145_A203TipoParEstado, T00145_A41ClinicaCodigo
               }
               , new Object[] {
               T00146_A41ClinicaCodigo
               }
               , new Object[] {
               T00147_A199TipoParCodigo, T00147_A200TipoParNombre, T00147_A201TipoParAuxiliar, T00147_A202TipoParMayoriza, T00147_A203TipoParEstado, T00147_A41ClinicaCodigo
               }
               , new Object[] {
               T00148_A41ClinicaCodigo
               }
               , new Object[] {
               T00149_A41ClinicaCodigo, T00149_A199TipoParCodigo
               }
               , new Object[] {
               T001410_A41ClinicaCodigo, T001410_A199TipoParCodigo
               }
               , new Object[] {
               T001411_A41ClinicaCodigo, T001411_A199TipoParCodigo
               }
               , new Object[] {
               T001412_A199TipoParCodigo, T001412_A200TipoParNombre, T001412_A201TipoParAuxiliar, T001412_A202TipoParMayoriza, T001412_A203TipoParEstado, T001412_A41ClinicaCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001416_A41ClinicaCodigo, T001416_A199TipoParCodigo, T001416_A290MovReversadoId, T001416_A291MovReversadoLinea
               }
               , new Object[] {
               T001417_A41ClinicaCodigo, T001417_A199TipoParCodigo, T001417_A217MovMayorizadoId, T001417_A218MovMayorizadoLinea
               }
               , new Object[] {
               T001418_A41ClinicaCodigo, T001418_A199TipoParCodigo, T001418_A207PartidaId
               }
               , new Object[] {
               T001419_A41ClinicaCodigo, T001419_A199TipoParCodigo
               }
               , new Object[] {
               T001420_A41ClinicaCodigo, T001420_A199TipoParCodigo, T001420_A204TipoParAnio, T001420_A205TipoParSiguiente
               }
               , new Object[] {
               T001421_A41ClinicaCodigo, T001421_A199TipoParCodigo, T001421_A204TipoParAnio
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001425_A41ClinicaCodigo, T001425_A199TipoParCodigo, T001425_A204TipoParAnio
               }
               , new Object[] {
               T001426_A41ClinicaCodigo
               }
            }
         );
      }

      private short GxWebError ;
      private short nRC_Gridtipopartida_tipopartidadetalle ;
      private short nGXsfl_70_idx=1 ;
      private short gxcookieaux ;
      private short A201TipoParAuxiliar ;
      private short A202TipoParMayoriza ;
      private short A203TipoParEstado ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGridtipopartida_tipopartidadetalle_Backcolorstyle ;
      private short A204TipoParAnio ;
      private short subGridtipopartida_tipopartidadetalle_Allowcollapsing ;
      private short subGridtipopartida_tipopartidadetalle_Collapsed ;
      private short nBlankRcdCount52 ;
      private short nRcdExists_52 ;
      private short RcdFound52 ;
      private short nIsMod_52 ;
      private short nBlankRcdUsr52 ;
      private short Z201TipoParAuxiliar ;
      private short Z202TipoParMayoriza ;
      private short Z203TipoParEstado ;
      private short nRcdDeleted_52 ;
      private short Z204TipoParAnio ;
      private short GX_JID ;
      private short RcdFound51 ;
      private short Gx_BScreen ;
      private short subGridtipopartida_tipopartidadetalle_Backstyle ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int lblTextblockclinicacodigo_Visible ;
      private int edtClinicaCodigo_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int imgprompt_41_Visible ;
      private int edtTipoParCodigo_Enabled ;
      private int edtTipoParNombre_Enabled ;
      private int edtTipoParAnio_Enabled ;
      private int A205TipoParSiguiente ;
      private int edtTipoParSiguiente_Enabled ;
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
      private int GRIDTIPOPARTIDA_TIPOPARTIDADETALLE_nFirstRecordOnPage ;
      private int Z205TipoParSiguiente ;
      private int AnyError41 ;
      private int subGridtipopartida_tipopartidadetalle_Backcolor ;
      private int subGridtipopartida_tipopartidadetalle_Allbackcolor ;
      private int defedtTipoParAnio_Enabled ;
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
      private String imgprompt_41_Internalname ;
      private String imgprompt_41_Link ;
      private String lblTextblocktipoparcodigo_Internalname ;
      private String lblTextblocktipoparcodigo_Jsonclick ;
      private String edtTipoParCodigo_Internalname ;
      private String edtTipoParCodigo_Jsonclick ;
      private String lblTextblocktipoparnombre_Internalname ;
      private String lblTextblocktipoparnombre_Jsonclick ;
      private String edtTipoParNombre_Internalname ;
      private String edtTipoParNombre_Jsonclick ;
      private String lblTextblocktipoparauxiliar_Internalname ;
      private String lblTextblocktipoparauxiliar_Jsonclick ;
      private String cmbTipoParAuxiliar_Internalname ;
      private String cmbTipoParAuxiliar_Jsonclick ;
      private String lblTextblocktipoparmayoriza_Internalname ;
      private String lblTextblocktipoparmayoriza_Jsonclick ;
      private String cmbTipoParMayoriza_Internalname ;
      private String cmbTipoParMayoriza_Jsonclick ;
      private String lblTextblocktipoparestado_Internalname ;
      private String lblTextblocktipoparestado_Jsonclick ;
      private String cmbTipoParEstado_Internalname ;
      private String cmbTipoParEstado_Jsonclick ;
      private String Gx_mode ;
      private String sMode52 ;
      private String edtTipoParAnio_Internalname ;
      private String tblTable3_Internalname ;
      private String lblTitletipopartidadetalle_Internalname ;
      private String lblTitletipopartidadetalle_Jsonclick ;
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
      private String edtTipoParSiguiente_Internalname ;
      private String sMode51 ;
      private String subGridtipopartida_tipopartidadetalle_Class ;
      private String subGridtipopartida_tipopartidadetalle_Linesclass ;
      private String ROClassString ;
      private String edtTipoParAnio_Jsonclick ;
      private String edtTipoParSiguiente_Jsonclick ;
      private String GXCCtl ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char7 ;
      private String GXt_char5 ;
      private String subGridtipopartida_tipopartidadetalle_Internalname ;
      private String GXt_char8 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A41ClinicaCodigo ;
      private String A199TipoParCodigo ;
      private String A200TipoParNombre ;
      private String Z41ClinicaCodigo ;
      private String Z199TipoParCodigo ;
      private String Z200TipoParNombre ;
      private String AV8ClinicaCodigo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Gridtipopartida_tipopartidadetalleContainer ;
      private GXWebRow Gridtipopartida_tipopartidadetalleRow ;
      private GXWebColumn Gridtipopartida_tipopartidadetalleColumn ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbTipoParAuxiliar ;
      private GXCombobox cmbTipoParMayoriza ;
      private GXCombobox cmbTipoParEstado ;
      private IDataStoreProvider pr_default ;
      private String[] T00147_A199TipoParCodigo ;
      private String[] T00147_A200TipoParNombre ;
      private short[] T00147_A201TipoParAuxiliar ;
      private short[] T00147_A202TipoParMayoriza ;
      private short[] T00147_A203TipoParEstado ;
      private String[] T00147_A41ClinicaCodigo ;
      private String[] T00146_A41ClinicaCodigo ;
      private String[] T00148_A41ClinicaCodigo ;
      private String[] T00149_A41ClinicaCodigo ;
      private String[] T00149_A199TipoParCodigo ;
      private String[] T00145_A199TipoParCodigo ;
      private String[] T00145_A200TipoParNombre ;
      private short[] T00145_A201TipoParAuxiliar ;
      private short[] T00145_A202TipoParMayoriza ;
      private short[] T00145_A203TipoParEstado ;
      private String[] T00145_A41ClinicaCodigo ;
      private String[] T001410_A41ClinicaCodigo ;
      private String[] T001410_A199TipoParCodigo ;
      private String[] T001411_A41ClinicaCodigo ;
      private String[] T001411_A199TipoParCodigo ;
      private String[] T001412_A199TipoParCodigo ;
      private String[] T001412_A200TipoParNombre ;
      private short[] T001412_A201TipoParAuxiliar ;
      private short[] T001412_A202TipoParMayoriza ;
      private short[] T001412_A203TipoParEstado ;
      private String[] T001412_A41ClinicaCodigo ;
      private String[] T001416_A41ClinicaCodigo ;
      private String[] T001416_A199TipoParCodigo ;
      private int[] T001416_A290MovReversadoId ;
      private short[] T001416_A291MovReversadoLinea ;
      private String[] T001417_A41ClinicaCodigo ;
      private String[] T001417_A199TipoParCodigo ;
      private int[] T001417_A217MovMayorizadoId ;
      private short[] T001417_A218MovMayorizadoLinea ;
      private String[] T001418_A41ClinicaCodigo ;
      private String[] T001418_A199TipoParCodigo ;
      private int[] T001418_A207PartidaId ;
      private String[] T001419_A41ClinicaCodigo ;
      private String[] T001419_A199TipoParCodigo ;
      private String[] T001420_A41ClinicaCodigo ;
      private String[] T001420_A199TipoParCodigo ;
      private short[] T001420_A204TipoParAnio ;
      private int[] T001420_A205TipoParSiguiente ;
      private String[] T001421_A41ClinicaCodigo ;
      private String[] T001421_A199TipoParCodigo ;
      private short[] T001421_A204TipoParAnio ;
      private String[] T00143_A41ClinicaCodigo ;
      private String[] T00143_A199TipoParCodigo ;
      private short[] T00143_A204TipoParAnio ;
      private int[] T00143_A205TipoParSiguiente ;
      private String[] T00142_A41ClinicaCodigo ;
      private String[] T00142_A199TipoParCodigo ;
      private short[] T00142_A204TipoParAnio ;
      private int[] T00142_A205TipoParSiguiente ;
      private String[] T001425_A41ClinicaCodigo ;
      private String[] T001425_A199TipoParCodigo ;
      private short[] T001425_A204TipoParAnio ;
      private String[] T001426_A41ClinicaCodigo ;
      private String[] T00144_A199TipoParCodigo ;
      private String[] T00144_A200TipoParNombre ;
      private short[] T00144_A201TipoParAuxiliar ;
      private short[] T00144_A202TipoParMayoriza ;
      private short[] T00144_A203TipoParEstado ;
      private String[] T00144_A41ClinicaCodigo ;
      private GXWebForm Form ;
      private SdtParametros AV7Parametros ;
      private SdtParametros GXt_SdtParametros6 ;
   }

   public class tipopartida__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[19])
         ,new UpdateCursor(def[20])
         ,new UpdateCursor(def[21])
         ,new UpdateCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new ForEachCursor(def[24])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00144 ;
          prmT00144 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00147 ;
          prmT00147 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00146 ;
          prmT00146 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00148 ;
          prmT00148 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00149 ;
          prmT00149 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00145 ;
          prmT00145 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001410 ;
          prmT001410 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001411 ;
          prmT001411 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001412 ;
          prmT001412 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001413 ;
          prmT001413 = new Object[] {
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@TipoParAuxiliar",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TipoParMayoriza",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TipoParEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001414 ;
          prmT001414 = new Object[] {
          new Object[] {"@TipoParNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@TipoParAuxiliar",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TipoParMayoriza",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TipoParEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001415 ;
          prmT001415 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001416 ;
          prmT001416 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001417 ;
          prmT001417 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001418 ;
          prmT001418 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001419 ;
          prmT001419 = new Object[] {
          } ;
          Object[] prmT001420 ;
          prmT001420 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001421 ;
          prmT001421 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00143 ;
          prmT00143 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00142 ;
          prmT00142 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001422 ;
          prmT001422 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoParSiguiente",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001423 ;
          prmT001423 = new Object[] {
          new Object[] {"@TipoParSiguiente",SqlDbType.Int,9,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001424 ;
          prmT001424 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001425 ;
          prmT001425 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001426 ;
          prmT001426 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00142", "SELECT [ClinicaCodigo], [TipoParCodigo], [TipoParAnio], [TipoParSiguiente] FROM [TipoPartidaDetalle] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [TipoParAnio] = @TipoParAnio ",true, GxErrorMask.GX_NOMASK, false, this,prmT00142,1,0,true,false )
             ,new CursorDef("T00143", "SELECT [ClinicaCodigo], [TipoParCodigo], [TipoParAnio], [TipoParSiguiente] FROM [TipoPartidaDetalle] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [TipoParAnio] = @TipoParAnio ",true, GxErrorMask.GX_NOMASK, false, this,prmT00143,1,0,true,false )
             ,new CursorDef("T00144", "SELECT [TipoParCodigo], [TipoParNombre], [TipoParAuxiliar], [TipoParMayoriza], [TipoParEstado], [ClinicaCodigo] FROM [TipoPartida] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00144,1,0,true,false )
             ,new CursorDef("T00145", "SELECT [TipoParCodigo], [TipoParNombre], [TipoParAuxiliar], [TipoParMayoriza], [TipoParEstado], [ClinicaCodigo] FROM [TipoPartida] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00145,1,0,true,false )
             ,new CursorDef("T00146", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00146,1,0,true,false )
             ,new CursorDef("T00147", "SELECT TM1.[TipoParCodigo], TM1.[TipoParNombre], TM1.[TipoParAuxiliar], TM1.[TipoParMayoriza], TM1.[TipoParEstado], TM1.[ClinicaCodigo] FROM [TipoPartida] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[TipoParCodigo] = @TipoParCodigo ORDER BY TM1.[ClinicaCodigo], TM1.[TipoParCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00147,100,0,true,false )
             ,new CursorDef("T00148", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00148,1,0,true,false )
             ,new CursorDef("T00149", "SELECT [ClinicaCodigo], [TipoParCodigo] FROM [TipoPartida] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00149,1,0,true,false )
             ,new CursorDef("T001410", "SELECT TOP 1 [ClinicaCodigo], [TipoParCodigo] FROM [TipoPartida] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [TipoParCodigo] > @TipoParCodigo) ORDER BY [ClinicaCodigo], [TipoParCodigo]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001410,1,0,true,true )
             ,new CursorDef("T001411", "SELECT TOP 1 [ClinicaCodigo], [TipoParCodigo] FROM [TipoPartida] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [TipoParCodigo] < @TipoParCodigo) ORDER BY [ClinicaCodigo] DESC, [TipoParCodigo] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001411,1,0,true,true )
             ,new CursorDef("T001412", "SELECT [TipoParCodigo], [TipoParNombre], [TipoParAuxiliar], [TipoParMayoriza], [TipoParEstado], [ClinicaCodigo] FROM [TipoPartida] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001412,1,0,true,false )
             ,new CursorDef("T001413", "INSERT INTO [TipoPartida] ([TipoParCodigo], [TipoParNombre], [TipoParAuxiliar], [TipoParMayoriza], [TipoParEstado], [ClinicaCodigo]) VALUES (@TipoParCodigo, @TipoParNombre, @TipoParAuxiliar, @TipoParMayoriza, @TipoParEstado, @ClinicaCodigo)", GxErrorMask.GX_NOMASK,prmT001413)
             ,new CursorDef("T001414", "UPDATE [TipoPartida] SET [TipoParNombre]=@TipoParNombre, [TipoParAuxiliar]=@TipoParAuxiliar, [TipoParMayoriza]=@TipoParMayoriza, [TipoParEstado]=@TipoParEstado  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo", GxErrorMask.GX_NOMASK,prmT001414)
             ,new CursorDef("T001415", "DELETE FROM [TipoPartida]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo", GxErrorMask.GX_NOMASK,prmT001415)
             ,new CursorDef("T001416", "SELECT TOP 1 [ClinicaCodigo], [TipoParCodigo], [MovReversadoId], [MovReversadoLinea] FROM [MovimientoReversado] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001416,1,0,true,true )
             ,new CursorDef("T001417", "SELECT TOP 1 [ClinicaCodigo], [TipoParCodigo], [MovMayorizadoId], [MovMayorizadoLinea] FROM [MovimientoMayorizado] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001417,1,0,true,true )
             ,new CursorDef("T001418", "SELECT TOP 1 [ClinicaCodigo], [TipoParCodigo], [PartidaId] FROM [PartidaEnc] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001418,1,0,true,true )
             ,new CursorDef("T001419", "SELECT [ClinicaCodigo], [TipoParCodigo] FROM [TipoPartida] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [TipoParCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001419,100,0,true,false )
             ,new CursorDef("T001420", "SELECT [ClinicaCodigo], [TipoParCodigo], [TipoParAnio], [TipoParSiguiente] FROM [TipoPartidaDetalle] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [TipoParCodigo] = @TipoParCodigo and [TipoParAnio] = @TipoParAnio ORDER BY [ClinicaCodigo], [TipoParCodigo], [TipoParAnio] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001420,11,0,true,false )
             ,new CursorDef("T001421", "SELECT [ClinicaCodigo], [TipoParCodigo], [TipoParAnio] FROM [TipoPartidaDetalle] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [TipoParAnio] = @TipoParAnio ",true, GxErrorMask.GX_NOMASK, false, this,prmT001421,1,0,true,false )
             ,new CursorDef("T001422", "INSERT INTO [TipoPartidaDetalle] ([ClinicaCodigo], [TipoParCodigo], [TipoParAnio], [TipoParSiguiente]) VALUES (@ClinicaCodigo, @TipoParCodigo, @TipoParAnio, @TipoParSiguiente)", GxErrorMask.GX_NOMASK,prmT001422)
             ,new CursorDef("T001423", "UPDATE [TipoPartidaDetalle] SET [TipoParSiguiente]=@TipoParSiguiente  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [TipoParAnio] = @TipoParAnio", GxErrorMask.GX_NOMASK,prmT001423)
             ,new CursorDef("T001424", "DELETE FROM [TipoPartidaDetalle]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [TipoParAnio] = @TipoParAnio", GxErrorMask.GX_NOMASK,prmT001424)
             ,new CursorDef("T001425", "SELECT [ClinicaCodigo], [TipoParCodigo], [TipoParAnio] FROM [TipoPartidaDetalle] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [TipoParCodigo] = @TipoParCodigo ORDER BY [ClinicaCodigo], [TipoParCodigo], [TipoParAnio] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001425,11,0,true,false )
             ,new CursorDef("T001426", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001426,1,0,true,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 23 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 24 :
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
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
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
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
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
                break;
             case 20 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 21 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 22 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 23 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 24 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
