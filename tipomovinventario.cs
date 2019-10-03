/*
               File: TipoMovInventario
        Description: Tipos de Movimientos de Inventario
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:5:14.24
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
   public class tipomovinventario : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridtipomovinventario_tipomovinventariodet") == 0 )
         {
            nRC_Gridtipomovinventario_tipomovinventariodet = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            nGXsfl_75_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_75_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGridtipomovinventario_tipomovinventariodet_newrow( nRC_Gridtipomovinventario_tipomovinventariodet, nGXsfl_75_idx, sGXsfl_75_idx) ;
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
         cmbTipoMIOperacion.Name = "TIPOMIOPERACION" ;
         cmbTipoMIOperacion.WebTags = "" ;
         cmbTipoMIOperacion.addItem("0", "Resta", 0);
         cmbTipoMIOperacion.addItem("1", "Suma", 0);
         if ( ( cmbTipoMIOperacion.ItemCount > 0 ) && (0==A116TipoMIOperacion) )
         {
            A116TipoMIOperacion = (short)(NumberUtil.Val( cmbTipoMIOperacion.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116TipoMIOperacion", StringUtil.Str( (decimal)(A116TipoMIOperacion), 1, 0));
         }
         cmbTipoMIAfectaCosto.Name = "TIPOMIAFECTACOSTO" ;
         cmbTipoMIAfectaCosto.WebTags = "" ;
         cmbTipoMIAfectaCosto.addItem("0", "No", 0);
         cmbTipoMIAfectaCosto.addItem("1", "Si", 0);
         if ( ( cmbTipoMIAfectaCosto.ItemCount > 0 ) && (0==A117TipoMIAfectaCosto) )
         {
            A117TipoMIAfectaCosto = (short)(NumberUtil.Val( cmbTipoMIAfectaCosto.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117TipoMIAfectaCosto", StringUtil.Str( (decimal)(A117TipoMIAfectaCosto), 1, 0));
         }
         cmbTipoMIEstado.Name = "TIPOMIESTADO" ;
         cmbTipoMIEstado.WebTags = "" ;
         cmbTipoMIEstado.addItem("0", "De baja", 0);
         cmbTipoMIEstado.addItem("1", "Activo", 0);
         if ( ( cmbTipoMIEstado.ItemCount > 0 ) && (0==A118TipoMIEstado) )
         {
            A118TipoMIEstado = (short)(NumberUtil.Val( cmbTipoMIEstado.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118TipoMIEstado", StringUtil.Str( (decimal)(A118TipoMIEstado), 1, 0));
         }
         cmbTipoMIRestringe.Name = "TIPOMIRESTRINGE" ;
         cmbTipoMIRestringe.WebTags = "" ;
         cmbTipoMIRestringe.addItem("0", "No", 0);
         cmbTipoMIRestringe.addItem("1", "Si", 0);
         if ( ( cmbTipoMIRestringe.ItemCount > 0 ) && (0==A287TipoMIRestringe) )
         {
            A287TipoMIRestringe = (short)(NumberUtil.Val( cmbTipoMIRestringe.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A287TipoMIRestringe", StringUtil.Str( (decimal)(A287TipoMIRestringe), 1, 0));
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Tipos de Movimientos de Inventario", 0) ;
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

      public tipomovinventario( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public tipomovinventario( IGxContext context )
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
         cmbTipoMIOperacion = new GXCombobox();
         cmbTipoMIAfectaCosto = new GXCombobox();
         cmbTipoMIEstado = new GXCombobox();
         cmbTipoMIRestringe = new GXCombobox();
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
            wb_table1_2_0L28( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0L28e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0L28( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0L28( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0L28e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Tipos de Movimientos de Inventario"+"</legend>") ;
            wb_table3_27_0L28( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0L28e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0L28e( true) ;
         }
         else
         {
            wb_table1_2_0L28e( false) ;
         }
      }

      protected void wb_table3_27_0L28( bool wbgen )
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
            wb_table4_33_0L28( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0L28e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_TipoMovInventario.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_TipoMovInventario.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_TipoMovInventario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0L28e( true) ;
         }
         else
         {
            wb_table3_27_0L28e( false) ;
         }
      }

      protected void wb_table4_33_0L28( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", lblTextblockclinicacodigo_Visible, 1, 0, "HLP_TipoMovInventario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", edtClinicaCodigo_Visible, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_TipoMovInventario.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_Internalname, "prompt.gif", imgprompt_41_Link, "", "", "Fantastic", imgprompt_41_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TipoMovInventario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipomicodigo_Internalname, "Movimiento", "", "", lblTextblocktipomicodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_TipoMovInventario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTipoMICodigo_Internalname, StringUtil.RTrim( A114TipoMICodigo), StringUtil.RTrim( context.localUtil.Format( A114TipoMICodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtTipoMICodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtTipoMICodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_TipoMovInventario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipomidescripcion_Internalname, "Descripción", "", "", lblTextblocktipomidescripcion_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_TipoMovInventario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A115TipoMIDescripcion", A115TipoMIDescripcion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTipoMIDescripcion_Internalname, StringUtil.RTrim( A115TipoMIDescripcion), StringUtil.RTrim( context.localUtil.Format( A115TipoMIDescripcion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", "", "", "", edtTipoMIDescripcion_Jsonclick, 0, ClassString, StyleString, "", 1, edtTipoMIDescripcion_Enabled, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_TipoMovInventario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipomioperacion_Internalname, "Operación", "", "", lblTextblocktipomioperacion_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_TipoMovInventario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116TipoMIOperacion", StringUtil.Str( (decimal)(A116TipoMIOperacion), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbTipoMIOperacion, cmbTipoMIOperacion_Internalname, StringUtil.Str( (decimal)(A116TipoMIOperacion), 1, 0), 1, cmbTipoMIOperacion_Jsonclick, 0, "", "int", "", 1, cmbTipoMIOperacion.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "", true, "HLP_TipoMovInventario.htm");
            cmbTipoMIOperacion.CurrentValue = StringUtil.Str( (decimal)(A116TipoMIOperacion), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoMIOperacion_Internalname, "Values", (String)(cmbTipoMIOperacion.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipomiafectacosto_Internalname, "Costo", "", "", lblTextblocktipomiafectacosto_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_TipoMovInventario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117TipoMIAfectaCosto", StringUtil.Str( (decimal)(A117TipoMIAfectaCosto), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbTipoMIAfectaCosto, cmbTipoMIAfectaCosto_Internalname, StringUtil.Str( (decimal)(A117TipoMIAfectaCosto), 1, 0), 1, cmbTipoMIAfectaCosto_Jsonclick, 0, "", "int", "", 1, cmbTipoMIAfectaCosto.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", "", true, "HLP_TipoMovInventario.htm");
            cmbTipoMIAfectaCosto.CurrentValue = StringUtil.Str( (decimal)(A117TipoMIAfectaCosto), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoMIAfectaCosto_Internalname, "Values", (String)(cmbTipoMIAfectaCosto.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipomiestado_Internalname, "Estado", "", "", lblTextblocktipomiestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_TipoMovInventario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118TipoMIEstado", StringUtil.Str( (decimal)(A118TipoMIEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbTipoMIEstado, cmbTipoMIEstado_Internalname, StringUtil.Str( (decimal)(A118TipoMIEstado), 1, 0), 1, cmbTipoMIEstado_Jsonclick, 0, "", "int", "", 1, cmbTipoMIEstado.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", "", true, "HLP_TipoMovInventario.htm");
            cmbTipoMIEstado.CurrentValue = StringUtil.Str( (decimal)(A118TipoMIEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoMIEstado_Internalname, "Values", (String)(cmbTipoMIEstado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipomirestringe_Internalname, "Restringe", "", "", lblTextblocktipomirestringe_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_TipoMovInventario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A287TipoMIRestringe", StringUtil.Str( (decimal)(A287TipoMIRestringe), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbTipoMIRestringe, cmbTipoMIRestringe_Internalname, StringUtil.Str( (decimal)(A287TipoMIRestringe), 1, 0), 1, cmbTipoMIRestringe_Jsonclick, 0, "", "int", "", 1, cmbTipoMIRestringe.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", "", true, "HLP_TipoMovInventario.htm");
            cmbTipoMIRestringe.CurrentValue = StringUtil.Str( (decimal)(A287TipoMIRestringe), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoMIRestringe_Internalname, "Values", (String)(cmbTipoMIRestringe.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "<br>") ;
            wb_table5_71_0L28( true) ;
         }
         return  ;
      }

      protected void wb_table5_71_0L28e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<hr class=\"HRDefault\">") ;
            /*  Grid Control  */
            Gridtipomovinventario_tipomovinventariodetContainer.AddObjectProperty("GridName", "Gridtipomovinventario_tipomovinventariodet");
            Gridtipomovinventario_tipomovinventariodetContainer.AddObjectProperty("Class", "Grid");
            Gridtipomovinventario_tipomovinventariodetContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Gridtipomovinventario_tipomovinventariodetContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Gridtipomovinventario_tipomovinventariodetContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtipomovinventario_tipomovinventariodet_Backcolorstyle), 1, 0, ".", "")));
            Gridtipomovinventario_tipomovinventariodetContainer.AddObjectProperty("CmpContext", "");
            Gridtipomovinventario_tipomovinventariodetContainer.AddObjectProperty("InMasterPage", "false");
            Gridtipomovinventario_tipomovinventariodetColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridtipomovinventario_tipomovinventariodetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A119TipoMIAnio), 4, 0, ".", "")));
            Gridtipomovinventario_tipomovinventariodetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoMIAnio_Enabled), 5, 0, ".", "")));
            Gridtipomovinventario_tipomovinventariodetContainer.AddColumnProperties(Gridtipomovinventario_tipomovinventariodetColumn);
            Gridtipomovinventario_tipomovinventariodetColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridtipomovinventario_tipomovinventariodetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A120TipoMICorrelativo), 9, 0, ".", "")));
            Gridtipomovinventario_tipomovinventariodetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoMICorrelativo_Enabled), 5, 0, ".", "")));
            Gridtipomovinventario_tipomovinventariodetContainer.AddColumnProperties(Gridtipomovinventario_tipomovinventariodetColumn);
            Gridtipomovinventario_tipomovinventariodetContainer.AddObjectProperty("Allowselection", "false");
            Gridtipomovinventario_tipomovinventariodetContainer.AddObjectProperty("Allowcollapsing", ((subGridtipomovinventario_tipomovinventariodet_Allowcollapsing==1) ? "true" : "false"));
            Gridtipomovinventario_tipomovinventariodetContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtipomovinventario_tipomovinventariodet_Collapsed), 9, 0, ".", "")));
            nGXsfl_75_idx = 0 ;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount29 = 5 ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_29 = 1 ;
                  ScanStart0L29( ) ;
                  while ( RcdFound29 != 0 )
                  {
                     init_level_properties29( ) ;
                     getByPrimaryKey0L29( ) ;
                     AddRow0L29( ) ;
                     ScanNext0L29( ) ;
                  }
                  ScanEnd0L29( ) ;
                  nBlankRcdCount29 = 5 ;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               standaloneNotModal0L29( ) ;
               standaloneModal0L29( ) ;
               sMode29 = Gx_mode ;
               while ( nGXsfl_75_idx < nRC_Gridtipomovinventario_tipomovinventariodet )
               {
                  ReadRow0L29( ) ;
                  edtTipoMIAnio_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPOMIANIO_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
                  edtTipoMICorrelativo_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPOMICORRELATIVO_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
                  if ( ( nRcdExists_29 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal0L29( ) ;
                  }
                  SendRow0L29( ) ;
               }
               Gx_mode = sMode29 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount29 = 5 ;
               nRcdExists_29 = 1 ;
               ScanStart0L29( ) ;
               while ( RcdFound29 != 0 )
               {
                  init_level_properties29( ) ;
                  getByPrimaryKey0L29( ) ;
                  standaloneNotModal0L29( ) ;
                  standaloneModal0L29( ) ;
                  AddRow0L29( ) ;
                  ScanNext0L29( ) ;
               }
               ScanEnd0L29( ) ;
            }
            /* Initialize fields for 'new' records and send them. */
            sMode29 = Gx_mode ;
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            InitAll0L29( ) ;
            init_level_properties29( ) ;
            standaloneNotModal0L29( ) ;
            standaloneModal0L29( ) ;
            nRcdExists_29 = 0 ;
            nIsMod_29 = 0 ;
            nBlankRcdCount29 = (short)(nBlankRcdUsr29+nBlankRcdCount29) ;
            fRowAdded = 0 ;
            while ( nBlankRcdCount29 > 0 )
            {
               AddRow0L29( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1 ;
                  GX_FocusControl = edtTipoMIAnio_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount29 = (short)(nBlankRcdCount29-1) ;
            }
            Gx_mode = sMode29 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            sStyleString = " style=\"display:none;\"" ;
            sStyleString = "" ;
            context.WriteHtmlText( "<div id=\""+"Gridtipomovinventario_tipomovinventariodetContainer"+"Div\" "+sStyleString+">"+"</div>") ;
            context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridtipomovinventario_tipomovinventariodet", (Object)(Gridtipomovinventario_tipomovinventariodetContainer));
            GxWebStd.gx_hidden_field( context, "Gridtipomovinventario_tipomovinventariodetContainerData", Gridtipomovinventario_tipomovinventariodetContainer.ToJavascriptSource());
            if ( context.isAjaxRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Gridtipomovinventario_tipomovinventariodetContainerData"+"V", Gridtipomovinventario_tipomovinventariodetContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridtipomovinventario_tipomovinventariodetContainerData"+"V"+"\" value='"+Gridtipomovinventario_tipomovinventariodetContainer.GridValuesHidden()+"'>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0L28e( true) ;
         }
         else
         {
            wb_table4_33_0L28e( false) ;
         }
      }

      protected void wb_table5_71_0L28( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTitletipomovinventariodet_Internalname, "Correlativo del Tipo de Movimiento de Inventario", "", "", lblTitletipomovinventariodet_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_TipoMovInventario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_71_0L28e( true) ;
         }
         else
         {
            wb_table5_71_0L28e( false) ;
         }
      }

      protected void wb_table2_5_0L28( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoMovInventario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoMovInventario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoMovInventario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoMovInventario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoMovInventario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoMovInventario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoMovInventario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoMovInventario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00s0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"TIPOMICODIGO"+"'), id:'"+"TIPOMICODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_TipoMovInventario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00s0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"TIPOMICODIGO"+"'), id:'"+"TIPOMICODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_TipoMovInventario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoMovInventario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoMovInventario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoMovInventario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoMovInventario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoMovInventario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoMovInventario.htm");
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
            wb_table2_5_0L28e( true) ;
         }
         else
         {
            wb_table2_5_0L28e( false) ;
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
         /* Execute user event: E110L2 */
         E110L2 ();
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
               A114TipoMICodigo = cgiGet( edtTipoMICodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
               A115TipoMIDescripcion = cgiGet( edtTipoMIDescripcion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A115TipoMIDescripcion", A115TipoMIDescripcion);
               cmbTipoMIOperacion.Name = cmbTipoMIOperacion_Internalname ;
               cmbTipoMIOperacion.CurrentValue = cgiGet( cmbTipoMIOperacion_Internalname) ;
               A116TipoMIOperacion = (short)(NumberUtil.Val( cgiGet( cmbTipoMIOperacion_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116TipoMIOperacion", StringUtil.Str( (decimal)(A116TipoMIOperacion), 1, 0));
               cmbTipoMIAfectaCosto.Name = cmbTipoMIAfectaCosto_Internalname ;
               cmbTipoMIAfectaCosto.CurrentValue = cgiGet( cmbTipoMIAfectaCosto_Internalname) ;
               A117TipoMIAfectaCosto = (short)(NumberUtil.Val( cgiGet( cmbTipoMIAfectaCosto_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117TipoMIAfectaCosto", StringUtil.Str( (decimal)(A117TipoMIAfectaCosto), 1, 0));
               cmbTipoMIEstado.Name = cmbTipoMIEstado_Internalname ;
               cmbTipoMIEstado.CurrentValue = cgiGet( cmbTipoMIEstado_Internalname) ;
               A118TipoMIEstado = (short)(NumberUtil.Val( cgiGet( cmbTipoMIEstado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118TipoMIEstado", StringUtil.Str( (decimal)(A118TipoMIEstado), 1, 0));
               cmbTipoMIRestringe.Name = cmbTipoMIRestringe_Internalname ;
               cmbTipoMIRestringe.CurrentValue = cgiGet( cmbTipoMIRestringe_Internalname) ;
               A287TipoMIRestringe = (short)(NumberUtil.Val( cgiGet( cmbTipoMIRestringe_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A287TipoMIRestringe", StringUtil.Str( (decimal)(A287TipoMIRestringe), 1, 0));
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z114TipoMICodigo = cgiGet( "Z114TipoMICodigo") ;
               Z115TipoMIDescripcion = cgiGet( "Z115TipoMIDescripcion") ;
               Z116TipoMIOperacion = (short)(context.localUtil.CToN( cgiGet( "Z116TipoMIOperacion"), ".", ",")) ;
               Z117TipoMIAfectaCosto = (short)(context.localUtil.CToN( cgiGet( "Z117TipoMIAfectaCosto"), ".", ",")) ;
               Z118TipoMIEstado = (short)(context.localUtil.CToN( cgiGet( "Z118TipoMIEstado"), ".", ",")) ;
               Z287TipoMIRestringe = (short)(context.localUtil.CToN( cgiGet( "Z287TipoMIRestringe"), ".", ",")) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               nRC_Gridtipomovinventario_tipomovinventariodet = (short)(context.localUtil.CToN( cgiGet( "nRC_Gridtipomovinventario_tipomovinventariodet"), ".", ",")) ;
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
                  A114TipoMICodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
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
                           /* Execute user event: E110L2 */
                           E110L2 ();
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
               InitAll0L28( ) ;
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
         DisableAttributes0L28( ) ;
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

      protected void CONFIRM_0L29( )
      {
         nGXsfl_75_idx = 0 ;
         while ( nGXsfl_75_idx < nRC_Gridtipomovinventario_tipomovinventariodet )
         {
            ReadRow0L29( ) ;
            if ( ( nRcdExists_29 != 0 ) || ( nIsMod_29 != 0 ) )
            {
               GetKey0L29( ) ;
               if ( ( nRcdExists_29 == 0 ) && ( nRcdDeleted_29 == 0 ) )
               {
                  if ( RcdFound29 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate0L29( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0L29( ) ;
                        CloseExtendedTableCursors0L29( ) ;
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
                     GX_FocusControl = edtTipoMIAnio_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound29 != 0 )
                  {
                     if ( nRcdDeleted_29 != 0 )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey0L29( ) ;
                        Load0L29( ) ;
                        BeforeValidate0L29( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0L29( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_29 != 0 )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate0L29( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0L29( ) ;
                              CloseExtendedTableCursors0L29( ) ;
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
                     if ( nRcdDeleted_29 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtTipoMIAnio_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtTipoMIAnio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A119TipoMIAnio), 4, 0, ".", ""))) ;
            ChangePostValue( edtTipoMICorrelativo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A120TipoMICorrelativo), 9, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z119TipoMIAnio_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z119TipoMIAnio), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z120TipoMICorrelativo_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z120TipoMICorrelativo), 9, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_29_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_29), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_29_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_29), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_29_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_29), 4, 0, ".", ""))) ;
            if ( nIsMod_29 != 0 )
            {
               ChangePostValue( "TIPOMIANIO_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoMIAnio_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPOMICORRELATIVO_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoMICorrelativo_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption0L0( )
      {
      }

      protected void E110L2( )
      {
         /* Start Routine */
         GXt_SdtParametros6 = AV7Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros6) ;
         AV7Parametros = GXt_SdtParametros6 ;
         AV8ClinicaCodigo = AV7Parametros.gxTpr_Pclinicacodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClinicaCodigo", AV8ClinicaCodigo);
      }

      protected void ZM0L28( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z115TipoMIDescripcion = T000L5_A115TipoMIDescripcion[0] ;
               Z116TipoMIOperacion = T000L5_A116TipoMIOperacion[0] ;
               Z117TipoMIAfectaCosto = T000L5_A117TipoMIAfectaCosto[0] ;
               Z118TipoMIEstado = T000L5_A118TipoMIEstado[0] ;
               Z287TipoMIRestringe = T000L5_A287TipoMIRestringe[0] ;
            }
            else
            {
               Z115TipoMIDescripcion = A115TipoMIDescripcion ;
               Z116TipoMIOperacion = A116TipoMIOperacion ;
               Z117TipoMIAfectaCosto = A117TipoMIAfectaCosto ;
               Z118TipoMIEstado = A118TipoMIEstado ;
               Z287TipoMIRestringe = A287TipoMIRestringe ;
            }
         }
         if ( GX_JID == -4 )
         {
            Z114TipoMICodigo = A114TipoMICodigo ;
            Z115TipoMIDescripcion = A115TipoMIDescripcion ;
            Z116TipoMIOperacion = A116TipoMIOperacion ;
            Z117TipoMIAfectaCosto = A117TipoMIAfectaCosto ;
            Z118TipoMIEstado = A118TipoMIEstado ;
            Z287TipoMIRestringe = A287TipoMIRestringe ;
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

      protected void Load0L28( )
      {
         /* Using cursor T000L7 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A114TipoMICodigo});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound28 = 1 ;
            A115TipoMIDescripcion = T000L7_A115TipoMIDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A115TipoMIDescripcion", A115TipoMIDescripcion);
            A116TipoMIOperacion = T000L7_A116TipoMIOperacion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116TipoMIOperacion", StringUtil.Str( (decimal)(A116TipoMIOperacion), 1, 0));
            A117TipoMIAfectaCosto = T000L7_A117TipoMIAfectaCosto[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117TipoMIAfectaCosto", StringUtil.Str( (decimal)(A117TipoMIAfectaCosto), 1, 0));
            A118TipoMIEstado = T000L7_A118TipoMIEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118TipoMIEstado", StringUtil.Str( (decimal)(A118TipoMIEstado), 1, 0));
            A287TipoMIRestringe = T000L7_A287TipoMIRestringe[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A287TipoMIRestringe", StringUtil.Str( (decimal)(A287TipoMIRestringe), 1, 0));
            ZM0L28( -4) ;
         }
         pr_default.close(5);
         OnLoadActions0L28( ) ;
      }

      protected void OnLoadActions0L28( )
      {
      }

      protected void CheckExtendedTable0L28( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T000L6 */
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

      protected void CloseExtendedTableCursors0L28( )
      {
         pr_default.close(4);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_5( String A41ClinicaCodigo )
      {
         /* Using cursor T000L8 */
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

      protected void GetKey0L28( )
      {
         /* Using cursor T000L9 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A114TipoMICodigo});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound28 = 1 ;
         }
         else
         {
            RcdFound28 = 0 ;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000L5 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A114TipoMICodigo});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM0L28( 4) ;
            RcdFound28 = 1 ;
            A114TipoMICodigo = T000L5_A114TipoMICodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
            A115TipoMIDescripcion = T000L5_A115TipoMIDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A115TipoMIDescripcion", A115TipoMIDescripcion);
            A116TipoMIOperacion = T000L5_A116TipoMIOperacion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116TipoMIOperacion", StringUtil.Str( (decimal)(A116TipoMIOperacion), 1, 0));
            A117TipoMIAfectaCosto = T000L5_A117TipoMIAfectaCosto[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117TipoMIAfectaCosto", StringUtil.Str( (decimal)(A117TipoMIAfectaCosto), 1, 0));
            A118TipoMIEstado = T000L5_A118TipoMIEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118TipoMIEstado", StringUtil.Str( (decimal)(A118TipoMIEstado), 1, 0));
            A287TipoMIRestringe = T000L5_A287TipoMIRestringe[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A287TipoMIRestringe", StringUtil.Str( (decimal)(A287TipoMIRestringe), 1, 0));
            A41ClinicaCodigo = T000L5_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z114TipoMICodigo = A114TipoMICodigo ;
            sMode28 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0L28( ) ;
            Gx_mode = sMode28 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound28 = 0 ;
            InitializeNonKey0L28( ) ;
            sMode28 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode28 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey0L28( ) ;
         if ( RcdFound28 == 0 )
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
         RcdFound28 = 0 ;
         /* Using cursor T000L10 */
         pr_default.execute(8, new Object[] {A41ClinicaCodigo, A114TipoMICodigo});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000L10_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000L10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000L10_A114TipoMICodigo[0], A114TipoMICodigo) < 0 ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000L10_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000L10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000L10_A114TipoMICodigo[0], A114TipoMICodigo) > 0 ) ) )
            {
               A41ClinicaCodigo = T000L10_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A114TipoMICodigo = T000L10_A114TipoMICodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
               RcdFound28 = 1 ;
            }
         }
         pr_default.close(3);
      }

      protected void move_previous( )
      {
         RcdFound28 = 0 ;
         /* Using cursor T000L11 */
         pr_default.execute(9, new Object[] {A41ClinicaCodigo, A114TipoMICodigo});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T000L11_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000L11_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000L11_A114TipoMICodigo[0], A114TipoMICodigo) > 0 ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T000L11_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000L11_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000L11_A114TipoMICodigo[0], A114TipoMICodigo) < 0 ) ) )
            {
               A41ClinicaCodigo = T000L11_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A114TipoMICodigo = T000L11_A114TipoMICodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
               RcdFound28 = 1 ;
            }
         }
         pr_default.close(2);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0L28( ) ;
         if ( RcdFound28 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A114TipoMICodigo, Z114TipoMICodigo) != 0 ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A114TipoMICodigo = Z114TipoMICodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
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
               Update0L28( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A114TipoMICodigo, Z114TipoMICodigo) != 0 ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert0L28( ) ;
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
                  Insert0L28( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A114TipoMICodigo, Z114TipoMICodigo) != 0 ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A114TipoMICodigo = Z114TipoMICodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
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
         if ( RcdFound28 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtTipoMIDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0L28( ) ;
         if ( RcdFound28 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTipoMIDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0L28( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound28 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTipoMIDescripcion_Internalname ;
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
         if ( RcdFound28 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTipoMIDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0L28( ) ;
         if ( RcdFound28 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound28 != 0 )
            {
               ScanNext0L28( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTipoMIDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0L28( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0L28( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000L12 */
            pr_default.execute(10, new Object[] {A41ClinicaCodigo, A114TipoMICodigo});
            if ( (pr_default.getStatus(10) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TipoMovInventario"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(10) == 101) || ( StringUtil.StrCmp(Z115TipoMIDescripcion, T000L12_A115TipoMIDescripcion[0]) != 0 ) || ( Z116TipoMIOperacion != T000L12_A116TipoMIOperacion[0] ) || ( Z117TipoMIAfectaCosto != T000L12_A117TipoMIAfectaCosto[0] ) || ( Z118TipoMIEstado != T000L12_A118TipoMIEstado[0] ) || ( Z287TipoMIRestringe != T000L12_A287TipoMIRestringe[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TipoMovInventario"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0L28( )
      {
         BeforeValidate0L28( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0L28( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0L28( 0) ;
            CheckOptimisticConcurrency0L28( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0L28( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0L28( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000L13 */
                     pr_default.execute(11, new Object[] {A114TipoMICodigo, A115TipoMIDescripcion, A116TipoMIOperacion, A117TipoMIAfectaCosto, A118TipoMIEstado, A287TipoMIRestringe, A41ClinicaCodigo});
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
                           ProcessLevel0L28( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                              ResetCaption0L0( ) ;
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
               Load0L28( ) ;
            }
            EndLevel0L28( ) ;
         }
         CloseExtendedTableCursors0L28( ) ;
      }

      protected void Update0L28( )
      {
         BeforeValidate0L28( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0L28( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0L28( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0L28( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0L28( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000L14 */
                     pr_default.execute(12, new Object[] {A115TipoMIDescripcion, A116TipoMIOperacion, A117TipoMIAfectaCosto, A118TipoMIEstado, A287TipoMIRestringe, A41ClinicaCodigo, A114TipoMICodigo});
                     pr_default.close(12);
                     if ( (pr_default.getStatus(12) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TipoMovInventario"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0L28( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0L28( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                              ResetCaption0L0( ) ;
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
            EndLevel0L28( ) ;
         }
         CloseExtendedTableCursors0L28( ) ;
      }

      protected void DeferredUpdate0L28( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0L28( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0L28( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0L28( ) ;
            AfterConfirm0L28( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0L28( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart0L29( ) ;
                  while ( RcdFound29 != 0 )
                  {
                     getByPrimaryKey0L29( ) ;
                     Delete0L29( ) ;
                     ScanNext0L29( ) ;
                  }
                  ScanEnd0L29( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000L15 */
                     pr_default.execute(13, new Object[] {A41ClinicaCodigo, A114TipoMICodigo});
                     pr_default.close(13);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound28 == 0 )
                           {
                              InitAll0L28( ) ;
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
                           ResetCaption0L0( ) ;
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
         sMode28 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0L28( ) ;
         Gx_mode = sMode28 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0L28( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000L16 */
            pr_default.execute(14, new Object[] {A41ClinicaCodigo, A114TipoMICodigo});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Encabezado de movimiento de inventario"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(14);
         }
      }

      protected void ProcessNestedLevel0L29( )
      {
         nGXsfl_75_idx = 0 ;
         while ( nGXsfl_75_idx < nRC_Gridtipomovinventario_tipomovinventariodet )
         {
            ReadRow0L29( ) ;
            if ( ( nRcdExists_29 != 0 ) || ( nIsMod_29 != 0 ) )
            {
               standaloneNotModal0L29( ) ;
               GetKey0L29( ) ;
               if ( ( nRcdExists_29 == 0 ) && ( nRcdDeleted_29 == 0 ) )
               {
                  if ( RcdFound29 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Insert0L29( ) ;
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtTipoMIAnio_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound29 != 0 )
                  {
                     if ( ( nRcdDeleted_29 != 0 ) && ( nRcdExists_29 != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete0L29( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_29 != 0 ) && ( nRcdExists_29 != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update0L29( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_29 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtTipoMIAnio_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtTipoMIAnio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A119TipoMIAnio), 4, 0, ".", ""))) ;
            ChangePostValue( edtTipoMICorrelativo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A120TipoMICorrelativo), 9, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z119TipoMIAnio_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z119TipoMIAnio), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z120TipoMICorrelativo_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z120TipoMICorrelativo), 9, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_29_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_29), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_29_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_29), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_29_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_29), 4, 0, ".", ""))) ;
            if ( nIsMod_29 != 0 )
            {
               ChangePostValue( "TIPOMIANIO_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoMIAnio_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPOMICORRELATIVO_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoMICorrelativo_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0L29( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_29 = 0 ;
         nIsMod_29 = 0 ;
         nRcdDeleted_29 = 0 ;
      }

      protected void ProcessLevel0L28( )
      {
         /* Save parent mode. */
         sMode28 = Gx_mode ;
         ProcessNestedLevel0L29( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode28 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel0L28( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0L28( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(9);
            pr_default.close(8);
            pr_default.close(1);
            pr_default.close(0);
            context.CommitDataStores("TipoMovInventario");
            if ( AnyError == 0 )
            {
               ConfirmValues0L0( ) ;
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
            context.RollbackDataStores("TipoMovInventario");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0L28( )
      {
         /* Using cursor T000L17 */
         pr_default.execute(15);
         RcdFound28 = 0 ;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound28 = 1 ;
            A41ClinicaCodigo = T000L17_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A114TipoMICodigo = T000L17_A114TipoMICodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0L28( )
      {
         pr_default.readNext(15);
         RcdFound28 = 0 ;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound28 = 1 ;
            A41ClinicaCodigo = T000L17_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A114TipoMICodigo = T000L17_A114TipoMICodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
         }
      }

      protected void ScanEnd0L28( )
      {
      }

      protected void AfterConfirm0L28( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0L28( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0L28( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0L28( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0L28( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0L28( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0L28( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtTipoMICodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoMICodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoMICodigo_Enabled), 5, 0)));
         edtTipoMIDescripcion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoMIDescripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoMIDescripcion_Enabled), 5, 0)));
         cmbTipoMIOperacion.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoMIOperacion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTipoMIOperacion.Enabled), 5, 0)));
         cmbTipoMIAfectaCosto.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoMIAfectaCosto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTipoMIAfectaCosto.Enabled), 5, 0)));
         cmbTipoMIEstado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoMIEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTipoMIEstado.Enabled), 5, 0)));
         cmbTipoMIRestringe.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoMIRestringe_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTipoMIRestringe.Enabled), 5, 0)));
      }

      protected void ZM0L29( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z120TipoMICorrelativo = T000L3_A120TipoMICorrelativo[0] ;
            }
            else
            {
               Z120TipoMICorrelativo = A120TipoMICorrelativo ;
            }
         }
         if ( GX_JID == -6 )
         {
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z114TipoMICodigo = A114TipoMICodigo ;
            Z119TipoMIAnio = A119TipoMIAnio ;
            Z120TipoMICorrelativo = A120TipoMICorrelativo ;
         }
      }

      protected void standaloneNotModal0L29( )
      {
      }

      protected void standaloneModal0L29( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtTipoMIAnio_Enabled = 0 ;
         }
         else
         {
            edtTipoMIAnio_Enabled = 1 ;
         }
         if ( ( StringUtil.StrCmp(sMode29, "DSP") == 0 ) || ( StringUtil.StrCmp(sMode29, "DLT") == 0 ) )
         {
            DisableAttributes0L29( ) ;
         }
      }

      protected void Load0L29( )
      {
         /* Using cursor T000L18 */
         pr_default.execute(16, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A119TipoMIAnio});
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound29 = 1 ;
            A120TipoMICorrelativo = T000L18_A120TipoMICorrelativo[0] ;
            ZM0L29( -6) ;
         }
         pr_default.close(16);
         OnLoadActions0L29( ) ;
      }

      protected void OnLoadActions0L29( )
      {
      }

      protected void CheckExtendedTable0L29( )
      {
         Gx_BScreen = 1 ;
         standaloneModal0L29( ) ;
      }

      protected void CloseExtendedTableCursors0L29( )
      {
      }

      protected void enableDisable0L29( )
      {
      }

      protected void GetKey0L29( )
      {
         /* Using cursor T000L19 */
         pr_default.execute(17, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A119TipoMIAnio});
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound29 = 1 ;
         }
         else
         {
            RcdFound29 = 0 ;
         }
         pr_default.close(17);
      }

      protected void getByPrimaryKey0L29( )
      {
         /* Using cursor T000L3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A119TipoMIAnio});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0L29( 6) ;
            RcdFound29 = 1 ;
            InitializeNonKey0L29( ) ;
            A119TipoMIAnio = T000L3_A119TipoMIAnio[0] ;
            A120TipoMICorrelativo = T000L3_A120TipoMICorrelativo[0] ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z114TipoMICodigo = A114TipoMICodigo ;
            Z119TipoMIAnio = A119TipoMIAnio ;
            sMode29 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0L29( ) ;
            Load0L29( ) ;
            Gx_mode = sMode29 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound29 = 0 ;
            InitializeNonKey0L29( ) ;
            sMode29 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0L29( ) ;
            Gx_mode = sMode29 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0L29( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000L2 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A119TipoMIAnio});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TipoMovInventarioDet"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z120TipoMICorrelativo != T000L2_A120TipoMICorrelativo[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TipoMovInventarioDet"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0L29( )
      {
         BeforeValidate0L29( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0L29( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0L29( 0) ;
            CheckOptimisticConcurrency0L29( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0L29( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0L29( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000L20 */
                     pr_default.execute(18, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A119TipoMIAnio, A120TipoMICorrelativo});
                     pr_default.close(18);
                     if ( (pr_default.getStatus(18) == 1) )
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
               Load0L29( ) ;
            }
            EndLevel0L29( ) ;
         }
         CloseExtendedTableCursors0L29( ) ;
      }

      protected void Update0L29( )
      {
         BeforeValidate0L29( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0L29( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0L29( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0L29( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0L29( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000L21 */
                     pr_default.execute(19, new Object[] {A120TipoMICorrelativo, A41ClinicaCodigo, A114TipoMICodigo, A119TipoMIAnio});
                     pr_default.close(19);
                     if ( (pr_default.getStatus(19) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TipoMovInventarioDet"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0L29( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0L29( ) ;
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
            EndLevel0L29( ) ;
         }
         CloseExtendedTableCursors0L29( ) ;
      }

      protected void DeferredUpdate0L29( )
      {
      }

      protected void Delete0L29( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0L29( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0L29( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0L29( ) ;
            AfterConfirm0L29( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0L29( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000L22 */
                  pr_default.execute(20, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A119TipoMIAnio});
                  pr_default.close(20);
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
         sMode29 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0L29( ) ;
         Gx_mode = sMode29 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0L29( )
      {
         standaloneModal0L29( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0L29( )
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

      protected void ScanStart0L29( )
      {
         /* Using cursor T000L23 */
         pr_default.execute(21, new Object[] {A41ClinicaCodigo, A114TipoMICodigo});
         RcdFound29 = 0 ;
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound29 = 1 ;
            A119TipoMIAnio = T000L23_A119TipoMIAnio[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0L29( )
      {
         pr_default.readNext(21);
         RcdFound29 = 0 ;
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound29 = 1 ;
            A119TipoMIAnio = T000L23_A119TipoMIAnio[0] ;
         }
      }

      protected void ScanEnd0L29( )
      {
         pr_default.close(1);
      }

      protected void AfterConfirm0L29( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0L29( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0L29( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0L29( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0L29( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0L29( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0L29( )
      {
         edtTipoMIAnio_Enabled = 0 ;
         edtTipoMICorrelativo_Enabled = 0 ;
      }

      protected void AddRow0L29( )
      {
         nGXsfl_75_idx = (short)(nGXsfl_75_idx+1) ;
         sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx), 4, 0)), 4, "0") ;
         edtTipoMIAnio_Internalname = "TIPOMIANIO_"+sGXsfl_75_idx ;
         edtTipoMICorrelativo_Internalname = "TIPOMICORRELATIVO_"+sGXsfl_75_idx ;
         SendRow0L29( ) ;
      }

      protected void SendRow0L29( )
      {
         Gridtipomovinventario_tipomovinventariodetRow = GXWebRow.GetNew(context) ;
         if ( subGridtipomovinventario_tipomovinventariodet_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridtipomovinventario_tipomovinventariodet_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGridtipomovinventario_tipomovinventariodet_Class, "") != 0 )
            {
               subGridtipomovinventario_tipomovinventariodet_Linesclass = subGridtipomovinventario_tipomovinventariodet_Class+"Odd" ;
            }
         }
         else if ( subGridtipomovinventario_tipomovinventariodet_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridtipomovinventario_tipomovinventariodet_Backstyle = 0 ;
            subGridtipomovinventario_tipomovinventariodet_Backcolor = subGridtipomovinventario_tipomovinventariodet_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridtipomovinventario_tipomovinventariodetContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridtipomovinventario_tipomovinventariodet_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGridtipomovinventario_tipomovinventariodet_Class, "") != 0 )
            {
               subGridtipomovinventario_tipomovinventariodet_Linesclass = subGridtipomovinventario_tipomovinventariodet_Class+"Uniform" ;
            }
         }
         else if ( subGridtipomovinventario_tipomovinventariodet_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridtipomovinventario_tipomovinventariodet_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGridtipomovinventario_tipomovinventariodet_Class, "") != 0 )
            {
               subGridtipomovinventario_tipomovinventariodet_Linesclass = subGridtipomovinventario_tipomovinventariodet_Class+"Odd" ;
            }
            subGridtipomovinventario_tipomovinventariodet_Backcolor = (int)(0xFFFFFF) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridtipomovinventario_tipomovinventariodetContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridtipomovinventario_tipomovinventariodet_Backcolor), 9, 0)));
         }
         else if ( subGridtipomovinventario_tipomovinventariodet_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridtipomovinventario_tipomovinventariodet_Backstyle = 1 ;
            if ( ((int)(nGXsfl_75_idx) % (2)) == 0 )
            {
               subGridtipomovinventario_tipomovinventariodet_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridtipomovinventario_tipomovinventariodetContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridtipomovinventario_tipomovinventariodet_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridtipomovinventario_tipomovinventariodet_Class, "") != 0 )
               {
                  subGridtipomovinventario_tipomovinventariodet_Linesclass = subGridtipomovinventario_tipomovinventariodet_Class+"Even" ;
               }
            }
            else
            {
               subGridtipomovinventario_tipomovinventariodet_Backcolor = (int)(0xFFFFFF) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridtipomovinventario_tipomovinventariodetContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridtipomovinventario_tipomovinventariodet_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridtipomovinventario_tipomovinventariodet_Class, "") != 0 )
               {
                  subGridtipomovinventario_tipomovinventariodet_Linesclass = subGridtipomovinventario_tipomovinventariodet_Class+"Odd" ;
               }
            }
         }
         /* * Property Link not supported in */
         /* * Property Link not supported in */
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_29_" + sGXsfl_75_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_75_idx + "',75)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridtipomovinventario_tipomovinventariodetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoMIAnio_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A119TipoMIAnio), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A119TipoMIAnio), "ZZZ9")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(76);\"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoMIAnio_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtTipoMIAnio_Enabled,(short)1,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)75,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_29_" + sGXsfl_75_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 77,'',false,'" + sGXsfl_75_idx + "',75)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridtipomovinventario_tipomovinventariodetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoMICorrelativo_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A120TipoMICorrelativo), 9, 0, ".", "")),((edtTipoMICorrelativo_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A120TipoMICorrelativo), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A120TipoMICorrelativo), "ZZZZZZZZ9")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(77);\"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoMICorrelativo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtTipoMICorrelativo_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)75,(short)1,(short)-1,(bool)true,(String)"right"});
         context.httpAjaxContext.ajax_sending_grid_row(Gridtipomovinventario_tipomovinventariodetRow);
         GXCCtl = "Z119TipoMIAnio_" + sGXsfl_75_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z119TipoMIAnio), 4, 0, ".", "")));
         GXCCtl = "Z120TipoMICorrelativo_" + sGXsfl_75_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z120TipoMICorrelativo), 9, 0, ".", "")));
         GXCCtl = "nRcdDeleted_29_" + sGXsfl_75_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_29), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_29_" + sGXsfl_75_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_29), 4, 0, ".", "")));
         GXCCtl = "nIsMod_29_" + sGXsfl_75_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_29), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TIPOMIANIO_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoMIAnio_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TIPOMICORRELATIVO_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoMICorrelativo_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridtipomovinventario_tipomovinventariodetContainer.AddRow(Gridtipomovinventario_tipomovinventariodetRow);
      }

      protected void ReadRow0L29( )
      {
         nGXsfl_75_idx = (short)(nGXsfl_75_idx+1) ;
         sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx), 4, 0)), 4, "0") ;
         edtTipoMIAnio_Internalname = "TIPOMIANIO_"+sGXsfl_75_idx ;
         edtTipoMICorrelativo_Internalname = "TIPOMICORRELATIVO_"+sGXsfl_75_idx ;
         edtTipoMIAnio_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPOMIANIO_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
         edtTipoMICorrelativo_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPOMICORRELATIVO_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
         if ( ( ( context.localUtil.CToN( cgiGet( edtTipoMIAnio_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtTipoMIAnio_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "TIPOMIANIO");
            AnyError = 1 ;
            GX_FocusControl = edtTipoMIAnio_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A119TipoMIAnio = 0 ;
         }
         else
         {
            A119TipoMIAnio = (short)(context.localUtil.CToN( cgiGet( edtTipoMIAnio_Internalname), ".", ",")) ;
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtTipoMICorrelativo_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtTipoMICorrelativo_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "TIPOMICORRELATIVO");
            AnyError = 1 ;
            GX_FocusControl = edtTipoMICorrelativo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A120TipoMICorrelativo = 0 ;
         }
         else
         {
            A120TipoMICorrelativo = (int)(context.localUtil.CToN( cgiGet( edtTipoMICorrelativo_Internalname), ".", ",")) ;
         }
         GXCCtl = "Z119TipoMIAnio_" + sGXsfl_75_idx ;
         Z119TipoMIAnio = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "Z120TipoMICorrelativo_" + sGXsfl_75_idx ;
         Z120TipoMICorrelativo = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdDeleted_29_" + sGXsfl_75_idx ;
         nRcdDeleted_29 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdExists_29_" + sGXsfl_75_idx ;
         nRcdExists_29 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nIsMod_29_" + sGXsfl_75_idx ;
         nIsMod_29 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
      }

      protected void assign_properties_default( )
      {
         defedtTipoMIAnio_Enabled = edtTipoMIAnio_Enabled ;
      }

      protected void ConfirmValues0L0( )
      {
         nGXsfl_75_idx = 0 ;
         sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx), 4, 0)), 4, "0") ;
         edtTipoMIAnio_Internalname = "TIPOMIANIO_"+sGXsfl_75_idx ;
         edtTipoMICorrelativo_Internalname = "TIPOMICORRELATIVO_"+sGXsfl_75_idx ;
         while ( nGXsfl_75_idx < nRC_Gridtipomovinventario_tipomovinventariodet )
         {
            nGXsfl_75_idx = (short)(nGXsfl_75_idx+1) ;
            sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx), 4, 0)), 4, "0") ;
            edtTipoMIAnio_Internalname = "TIPOMIANIO_"+sGXsfl_75_idx ;
            edtTipoMICorrelativo_Internalname = "TIPOMICORRELATIVO_"+sGXsfl_75_idx ;
            ChangePostValue( "Z119TipoMIAnio_"+sGXsfl_75_idx, cgiGet( "ZT_"+"Z119TipoMIAnio_"+sGXsfl_75_idx)) ;
            DeletePostValue( "ZT_"+"Z119TipoMIAnio_"+sGXsfl_75_idx) ;
            ChangePostValue( "Z120TipoMICorrelativo_"+sGXsfl_75_idx, cgiGet( "ZT_"+"Z120TipoMICorrelativo_"+sGXsfl_75_idx)) ;
            DeletePostValue( "ZT_"+"Z120TipoMICorrelativo_"+sGXsfl_75_idx) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tipomovinventario.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z114TipoMICodigo", StringUtil.RTrim( Z114TipoMICodigo));
         GxWebStd.gx_hidden_field( context, "Z115TipoMIDescripcion", StringUtil.RTrim( Z115TipoMIDescripcion));
         GxWebStd.gx_hidden_field( context, "Z116TipoMIOperacion", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z116TipoMIOperacion), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z117TipoMIAfectaCosto", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z117TipoMIAfectaCosto), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z118TipoMIEstado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z118TipoMIEstado), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z287TipoMIRestringe", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z287TipoMIRestringe), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_Gridtipomovinventario_tipomovinventariodet", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_75_idx), 4, 0, ".", "")));
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
         return "TipoMovInventario" ;
      }

      public override String GetPgmdesc( )
      {
         return "Tipos de Movimientos de Inventario" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("tipomovinventario.aspx")  ;
      }

      protected void InitializeNonKey0L28( )
      {
         A115TipoMIDescripcion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A115TipoMIDescripcion", A115TipoMIDescripcion);
         A116TipoMIOperacion = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116TipoMIOperacion", StringUtil.Str( (decimal)(A116TipoMIOperacion), 1, 0));
         A117TipoMIAfectaCosto = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117TipoMIAfectaCosto", StringUtil.Str( (decimal)(A117TipoMIAfectaCosto), 1, 0));
         A118TipoMIEstado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118TipoMIEstado", StringUtil.Str( (decimal)(A118TipoMIEstado), 1, 0));
         A287TipoMIRestringe = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A287TipoMIRestringe", StringUtil.Str( (decimal)(A287TipoMIRestringe), 1, 0));
      }

      protected void InitAll0L28( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A114TipoMICodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
         InitializeNonKey0L28( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0L29( )
      {
         A120TipoMICorrelativo = 0 ;
      }

      protected void InitAll0L29( )
      {
         A119TipoMIAnio = 0 ;
         InitializeNonKey0L29( ) ;
      }

      protected void StandaloneModalInsert0L29( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1551671");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("tipomovinventario.js", "?1551672");
         /* End function include_jscripts */
      }

      protected void init_level_properties29( )
      {
         edtTipoMIAnio_Enabled = defedtTipoMIAnio_Enabled ;
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
         lblTextblocktipomicodigo_Internalname = "TEXTBLOCKTIPOMICODIGO" ;
         edtTipoMICodigo_Internalname = "TIPOMICODIGO" ;
         lblTextblocktipomidescripcion_Internalname = "TEXTBLOCKTIPOMIDESCRIPCION" ;
         edtTipoMIDescripcion_Internalname = "TIPOMIDESCRIPCION" ;
         lblTextblocktipomioperacion_Internalname = "TEXTBLOCKTIPOMIOPERACION" ;
         cmbTipoMIOperacion_Internalname = "TIPOMIOPERACION" ;
         lblTextblocktipomiafectacosto_Internalname = "TEXTBLOCKTIPOMIAFECTACOSTO" ;
         cmbTipoMIAfectaCosto_Internalname = "TIPOMIAFECTACOSTO" ;
         lblTextblocktipomiestado_Internalname = "TEXTBLOCKTIPOMIESTADO" ;
         cmbTipoMIEstado_Internalname = "TIPOMIESTADO" ;
         lblTextblocktipomirestringe_Internalname = "TEXTBLOCKTIPOMIRESTRINGE" ;
         cmbTipoMIRestringe_Internalname = "TIPOMIRESTRINGE" ;
         lblTitletipomovinventariodet_Internalname = "TITLETIPOMOVINVENTARIODET" ;
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
         subGridtipomovinventario_tipomovinventariodet_Internalname = "GRIDTIPOMOVINVENTARIO_TIPOMOVINVENTARIODET" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Tipos de Movimientos de Inventario" ;
         edtTipoMICorrelativo_Jsonclick = "" ;
         edtTipoMIAnio_Jsonclick = "" ;
         subGridtipomovinventario_tipomovinventariodet_Class = "Grid" ;
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
         subGridtipomovinventario_tipomovinventariodet_Allowcollapsing = 0 ;
         edtTipoMICorrelativo_Enabled = 1 ;
         edtTipoMIAnio_Enabled = 1 ;
         subGridtipomovinventario_tipomovinventariodet_Backcolorstyle = 2 ;
         cmbTipoMIRestringe_Jsonclick = "" ;
         cmbTipoMIRestringe.Enabled = 1 ;
         cmbTipoMIEstado_Jsonclick = "" ;
         cmbTipoMIEstado.Enabled = 1 ;
         cmbTipoMIAfectaCosto_Jsonclick = "" ;
         cmbTipoMIAfectaCosto.Enabled = 1 ;
         cmbTipoMIOperacion_Jsonclick = "" ;
         cmbTipoMIOperacion.Enabled = 1 ;
         edtTipoMIDescripcion_Jsonclick = "" ;
         edtTipoMIDescripcion_Enabled = 1 ;
         edtTipoMICodigo_Jsonclick = "" ;
         edtTipoMICodigo_Enabled = 1 ;
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

      protected void gxnrGridtipomovinventario_tipomovinventariodet_newrow( short nRC_Gridtipomovinventario_tipomovinventariodet ,
                                                                            short nGXsfl_75_idx ,
                                                                            String sGXsfl_75_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         edtTipoMIAnio_Internalname = "TIPOMIANIO_"+sGXsfl_75_idx ;
         edtTipoMICorrelativo_Internalname = "TIPOMICORRELATIVO_"+sGXsfl_75_idx ;
         while ( nGXsfl_75_idx <= nRC_Gridtipomovinventario_tipomovinventariodet )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0L29( ) ;
            standaloneModal0L29( ) ;
            cmbTipoMIOperacion.Name = "TIPOMIOPERACION" ;
            cmbTipoMIOperacion.WebTags = "" ;
            cmbTipoMIOperacion.addItem("0", "Resta", 0);
            cmbTipoMIOperacion.addItem("1", "Suma", 0);
            if ( ( cmbTipoMIOperacion.ItemCount > 0 ) && (0==A116TipoMIOperacion) )
            {
               A116TipoMIOperacion = (short)(NumberUtil.Val( cmbTipoMIOperacion.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116TipoMIOperacion", StringUtil.Str( (decimal)(A116TipoMIOperacion), 1, 0));
            }
            cmbTipoMIAfectaCosto.Name = "TIPOMIAFECTACOSTO" ;
            cmbTipoMIAfectaCosto.WebTags = "" ;
            cmbTipoMIAfectaCosto.addItem("0", "No", 0);
            cmbTipoMIAfectaCosto.addItem("1", "Si", 0);
            if ( ( cmbTipoMIAfectaCosto.ItemCount > 0 ) && (0==A117TipoMIAfectaCosto) )
            {
               A117TipoMIAfectaCosto = (short)(NumberUtil.Val( cmbTipoMIAfectaCosto.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117TipoMIAfectaCosto", StringUtil.Str( (decimal)(A117TipoMIAfectaCosto), 1, 0));
            }
            cmbTipoMIEstado.Name = "TIPOMIESTADO" ;
            cmbTipoMIEstado.WebTags = "" ;
            cmbTipoMIEstado.addItem("0", "De baja", 0);
            cmbTipoMIEstado.addItem("1", "Activo", 0);
            if ( ( cmbTipoMIEstado.ItemCount > 0 ) && (0==A118TipoMIEstado) )
            {
               A118TipoMIEstado = (short)(NumberUtil.Val( cmbTipoMIEstado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118TipoMIEstado", StringUtil.Str( (decimal)(A118TipoMIEstado), 1, 0));
            }
            cmbTipoMIRestringe.Name = "TIPOMIRESTRINGE" ;
            cmbTipoMIRestringe.WebTags = "" ;
            cmbTipoMIRestringe.addItem("0", "No", 0);
            cmbTipoMIRestringe.addItem("1", "Si", 0);
            if ( ( cmbTipoMIRestringe.ItemCount > 0 ) && (0==A287TipoMIRestringe) )
            {
               A287TipoMIRestringe = (short)(NumberUtil.Val( cmbTipoMIRestringe.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A287TipoMIRestringe", StringUtil.Str( (decimal)(A287TipoMIRestringe), 1, 0));
            }
            dynload_actions( ) ;
            SendRow0L29( ) ;
            nGXsfl_75_idx = (short)(nGXsfl_75_idx+1) ;
            sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx), 4, 0)), 4, "0") ;
            edtTipoMIAnio_Internalname = "TIPOMIANIO_"+sGXsfl_75_idx ;
            edtTipoMICorrelativo_Internalname = "TIPOMICORRELATIVO_"+sGXsfl_75_idx ;
         }
         context.GX_webresponse.AddString(Gridtipomovinventario_tipomovinventariodetContainer.ToJavascriptSource());
         /* End function gxnrGridtipomovinventario_tipomovinventariodet_newrow */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         /* Using cursor T000L24 */
         pr_default.execute(22, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(22) == 101) )
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
         pr_default.close(22);
         GX_FocusControl = edtTipoMIDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Clinicacodigo( String GX_Parm1 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         /* Using cursor T000L24 */
         pr_default.execute(22, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(22) == 101) )
         {
            AnyError41 = 1 ;
            GX_msglist.addItem("No existe 'Clínica Médica'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( AnyError41 == 0 )
         {
         }
         pr_default.close(22);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Tipomicodigo( String GX_Parm1 ,
                                      String GX_Parm2 ,
                                      String GX_Parm3 ,
                                      String GX_Parm4 ,
                                      GXCombobox cmbGX_Parm5 ,
                                      GXCombobox cmbGX_Parm6 ,
                                      GXCombobox cmbGX_Parm7 ,
                                      GXCombobox cmbGX_Parm8 )
      {
         AV8ClinicaCodigo = GX_Parm1 ;
         A41ClinicaCodigo = GX_Parm2 ;
         A114TipoMICodigo = GX_Parm3 ;
         A115TipoMIDescripcion = GX_Parm4 ;
         cmbTipoMIOperacion = cmbGX_Parm5 ;
         A116TipoMIOperacion = (short)(NumberUtil.Val( cmbTipoMIOperacion.CurrentValue, ".")) ;
         cmbTipoMIOperacion.CurrentValue = StringUtil.Str( (decimal)(A116TipoMIOperacion), 1, 0) ;
         cmbTipoMIAfectaCosto = cmbGX_Parm6 ;
         A117TipoMIAfectaCosto = (short)(NumberUtil.Val( cmbTipoMIAfectaCosto.CurrentValue, ".")) ;
         cmbTipoMIAfectaCosto.CurrentValue = StringUtil.Str( (decimal)(A117TipoMIAfectaCosto), 1, 0) ;
         cmbTipoMIEstado = cmbGX_Parm7 ;
         A118TipoMIEstado = (short)(NumberUtil.Val( cmbTipoMIEstado.CurrentValue, ".")) ;
         cmbTipoMIEstado.CurrentValue = StringUtil.Str( (decimal)(A118TipoMIEstado), 1, 0) ;
         cmbTipoMIRestringe = cmbGX_Parm8 ;
         A287TipoMIRestringe = (short)(NumberUtil.Val( cmbTipoMIRestringe.CurrentValue, ".")) ;
         cmbTipoMIRestringe.CurrentValue = StringUtil.Str( (decimal)(A287TipoMIRestringe), 1, 0) ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A115TipoMIDescripcion)));
         cmbTipoMIOperacion.CurrentValue = StringUtil.Str( (decimal)(A116TipoMIOperacion), 1, 0) ;
         isValidOutput.Add((Object)(cmbTipoMIOperacion));
         cmbTipoMIAfectaCosto.CurrentValue = StringUtil.Str( (decimal)(A117TipoMIAfectaCosto), 1, 0) ;
         isValidOutput.Add((Object)(cmbTipoMIAfectaCosto));
         cmbTipoMIEstado.CurrentValue = StringUtil.Str( (decimal)(A118TipoMIEstado), 1, 0) ;
         isValidOutput.Add((Object)(cmbTipoMIEstado));
         cmbTipoMIRestringe.CurrentValue = StringUtil.Str( (decimal)(A287TipoMIRestringe), 1, 0) ;
         isValidOutput.Add((Object)(cmbTipoMIRestringe));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z114TipoMICodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z115TipoMIDescripcion)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z116TipoMIOperacion), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z117TipoMIAfectaCosto), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z118TipoMIEstado), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z287TipoMIRestringe), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(Gridtipomovinventario_tipomovinventariodetContainer));
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
         pr_default.close(21);
         pr_default.close(15);
         pr_default.close(9);
         pr_default.close(8);
         pr_default.close(22);
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
         lblTextblocktipomicodigo_Jsonclick = "" ;
         A114TipoMICodigo = "" ;
         lblTextblocktipomidescripcion_Jsonclick = "" ;
         A115TipoMIDescripcion = "" ;
         lblTextblocktipomioperacion_Jsonclick = "" ;
         lblTextblocktipomiafectacosto_Jsonclick = "" ;
         lblTextblocktipomiestado_Jsonclick = "" ;
         lblTextblocktipomirestringe_Jsonclick = "" ;
         Gridtipomovinventario_tipomovinventariodetContainer = new GXWebGrid( context);
         Gridtipomovinventario_tipomovinventariodetColumn = new GXWebColumn();
         Gx_mode = "" ;
         sMode29 = "" ;
         edtTipoMIAnio_Internalname = "" ;
         lblTitletipomovinventariodet_Jsonclick = "" ;
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
         Z114TipoMICodigo = "" ;
         Z115TipoMIDescripcion = "" ;
         AV8ClinicaCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtTipoMICorrelativo_Internalname = "" ;
         AV7Parametros = new SdtParametros(context);
         GXt_SdtParametros6 = new SdtParametros(context);
         T000L7_A114TipoMICodigo = new String[] {""} ;
         T000L7_A115TipoMIDescripcion = new String[] {""} ;
         T000L7_A116TipoMIOperacion = new short[1] ;
         T000L7_A117TipoMIAfectaCosto = new short[1] ;
         T000L7_A118TipoMIEstado = new short[1] ;
         T000L7_A287TipoMIRestringe = new short[1] ;
         T000L7_A41ClinicaCodigo = new String[] {""} ;
         T000L6_A41ClinicaCodigo = new String[] {""} ;
         T000L8_A41ClinicaCodigo = new String[] {""} ;
         T000L9_A41ClinicaCodigo = new String[] {""} ;
         T000L9_A114TipoMICodigo = new String[] {""} ;
         T000L5_A114TipoMICodigo = new String[] {""} ;
         T000L5_A115TipoMIDescripcion = new String[] {""} ;
         T000L5_A116TipoMIOperacion = new short[1] ;
         T000L5_A117TipoMIAfectaCosto = new short[1] ;
         T000L5_A118TipoMIEstado = new short[1] ;
         T000L5_A287TipoMIRestringe = new short[1] ;
         T000L5_A41ClinicaCodigo = new String[] {""} ;
         sMode28 = "" ;
         T000L10_A41ClinicaCodigo = new String[] {""} ;
         T000L10_A114TipoMICodigo = new String[] {""} ;
         T000L11_A41ClinicaCodigo = new String[] {""} ;
         T000L11_A114TipoMICodigo = new String[] {""} ;
         T000L12_A114TipoMICodigo = new String[] {""} ;
         T000L12_A115TipoMIDescripcion = new String[] {""} ;
         T000L12_A116TipoMIOperacion = new short[1] ;
         T000L12_A117TipoMIAfectaCosto = new short[1] ;
         T000L12_A118TipoMIEstado = new short[1] ;
         T000L12_A287TipoMIRestringe = new short[1] ;
         T000L12_A41ClinicaCodigo = new String[] {""} ;
         T000L16_A41ClinicaCodigo = new String[] {""} ;
         T000L16_A114TipoMICodigo = new String[] {""} ;
         T000L16_A267MovimientoId = new int[1] ;
         T000L17_A41ClinicaCodigo = new String[] {""} ;
         T000L17_A114TipoMICodigo = new String[] {""} ;
         T000L18_A41ClinicaCodigo = new String[] {""} ;
         T000L18_A114TipoMICodigo = new String[] {""} ;
         T000L18_A119TipoMIAnio = new short[1] ;
         T000L18_A120TipoMICorrelativo = new int[1] ;
         T000L19_A41ClinicaCodigo = new String[] {""} ;
         T000L19_A114TipoMICodigo = new String[] {""} ;
         T000L19_A119TipoMIAnio = new short[1] ;
         T000L3_A41ClinicaCodigo = new String[] {""} ;
         T000L3_A114TipoMICodigo = new String[] {""} ;
         T000L3_A119TipoMIAnio = new short[1] ;
         T000L3_A120TipoMICorrelativo = new int[1] ;
         T000L2_A41ClinicaCodigo = new String[] {""} ;
         T000L2_A114TipoMICodigo = new String[] {""} ;
         T000L2_A119TipoMIAnio = new short[1] ;
         T000L2_A120TipoMICorrelativo = new int[1] ;
         T000L23_A41ClinicaCodigo = new String[] {""} ;
         T000L23_A114TipoMICodigo = new String[] {""} ;
         T000L23_A119TipoMIAnio = new short[1] ;
         Gridtipomovinventario_tipomovinventariodetRow = new GXWebRow();
         subGridtipomovinventario_tipomovinventariodet_Linesclass = "" ;
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
         T000L24_A41ClinicaCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tipomovinventario__default(),
            new Object[][] {
                new Object[] {
               T000L2_A41ClinicaCodigo, T000L2_A114TipoMICodigo, T000L2_A119TipoMIAnio, T000L2_A120TipoMICorrelativo
               }
               , new Object[] {
               T000L3_A41ClinicaCodigo, T000L3_A114TipoMICodigo, T000L3_A119TipoMIAnio, T000L3_A120TipoMICorrelativo
               }
               , new Object[] {
               T000L4_A114TipoMICodigo, T000L4_A115TipoMIDescripcion, T000L4_A116TipoMIOperacion, T000L4_A117TipoMIAfectaCosto, T000L4_A118TipoMIEstado, T000L4_A287TipoMIRestringe, T000L4_A41ClinicaCodigo
               }
               , new Object[] {
               T000L5_A114TipoMICodigo, T000L5_A115TipoMIDescripcion, T000L5_A116TipoMIOperacion, T000L5_A117TipoMIAfectaCosto, T000L5_A118TipoMIEstado, T000L5_A287TipoMIRestringe, T000L5_A41ClinicaCodigo
               }
               , new Object[] {
               T000L6_A41ClinicaCodigo
               }
               , new Object[] {
               T000L7_A114TipoMICodigo, T000L7_A115TipoMIDescripcion, T000L7_A116TipoMIOperacion, T000L7_A117TipoMIAfectaCosto, T000L7_A118TipoMIEstado, T000L7_A287TipoMIRestringe, T000L7_A41ClinicaCodigo
               }
               , new Object[] {
               T000L8_A41ClinicaCodigo
               }
               , new Object[] {
               T000L9_A41ClinicaCodigo, T000L9_A114TipoMICodigo
               }
               , new Object[] {
               T000L10_A41ClinicaCodigo, T000L10_A114TipoMICodigo
               }
               , new Object[] {
               T000L11_A41ClinicaCodigo, T000L11_A114TipoMICodigo
               }
               , new Object[] {
               T000L12_A114TipoMICodigo, T000L12_A115TipoMIDescripcion, T000L12_A116TipoMIOperacion, T000L12_A117TipoMIAfectaCosto, T000L12_A118TipoMIEstado, T000L12_A287TipoMIRestringe, T000L12_A41ClinicaCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000L16_A41ClinicaCodigo, T000L16_A114TipoMICodigo, T000L16_A267MovimientoId
               }
               , new Object[] {
               T000L17_A41ClinicaCodigo, T000L17_A114TipoMICodigo
               }
               , new Object[] {
               T000L18_A41ClinicaCodigo, T000L18_A114TipoMICodigo, T000L18_A119TipoMIAnio, T000L18_A120TipoMICorrelativo
               }
               , new Object[] {
               T000L19_A41ClinicaCodigo, T000L19_A114TipoMICodigo, T000L19_A119TipoMIAnio
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000L23_A41ClinicaCodigo, T000L23_A114TipoMICodigo, T000L23_A119TipoMIAnio
               }
               , new Object[] {
               T000L24_A41ClinicaCodigo
               }
            }
         );
      }

      private short GxWebError ;
      private short nRC_Gridtipomovinventario_tipomovinventariodet ;
      private short nGXsfl_75_idx=1 ;
      private short gxcookieaux ;
      private short A116TipoMIOperacion ;
      private short A117TipoMIAfectaCosto ;
      private short A118TipoMIEstado ;
      private short A287TipoMIRestringe ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGridtipomovinventario_tipomovinventariodet_Backcolorstyle ;
      private short A119TipoMIAnio ;
      private short subGridtipomovinventario_tipomovinventariodet_Allowcollapsing ;
      private short subGridtipomovinventario_tipomovinventariodet_Collapsed ;
      private short nBlankRcdCount29 ;
      private short nRcdExists_29 ;
      private short RcdFound29 ;
      private short nIsMod_29 ;
      private short nBlankRcdUsr29 ;
      private short Z116TipoMIOperacion ;
      private short Z117TipoMIAfectaCosto ;
      private short Z118TipoMIEstado ;
      private short Z287TipoMIRestringe ;
      private short nRcdDeleted_29 ;
      private short Z119TipoMIAnio ;
      private short GX_JID ;
      private short RcdFound28 ;
      private short Gx_BScreen ;
      private short subGridtipomovinventario_tipomovinventariodet_Backstyle ;
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
      private int edtTipoMICodigo_Enabled ;
      private int edtTipoMIDescripcion_Enabled ;
      private int edtTipoMIAnio_Enabled ;
      private int A120TipoMICorrelativo ;
      private int edtTipoMICorrelativo_Enabled ;
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
      private int GRIDTIPOMOVINVENTARIO_TIPOMOVINVENTARIODET_nFirstRecordOnPage ;
      private int Z120TipoMICorrelativo ;
      private int AnyError41 ;
      private int subGridtipomovinventario_tipomovinventariodet_Backcolor ;
      private int subGridtipomovinventario_tipomovinventariodet_Allbackcolor ;
      private int defedtTipoMIAnio_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_75_idx="0001" ;
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
      private String lblTextblocktipomicodigo_Internalname ;
      private String lblTextblocktipomicodigo_Jsonclick ;
      private String edtTipoMICodigo_Internalname ;
      private String edtTipoMICodigo_Jsonclick ;
      private String lblTextblocktipomidescripcion_Internalname ;
      private String lblTextblocktipomidescripcion_Jsonclick ;
      private String edtTipoMIDescripcion_Internalname ;
      private String edtTipoMIDescripcion_Jsonclick ;
      private String lblTextblocktipomioperacion_Internalname ;
      private String lblTextblocktipomioperacion_Jsonclick ;
      private String cmbTipoMIOperacion_Internalname ;
      private String cmbTipoMIOperacion_Jsonclick ;
      private String lblTextblocktipomiafectacosto_Internalname ;
      private String lblTextblocktipomiafectacosto_Jsonclick ;
      private String cmbTipoMIAfectaCosto_Internalname ;
      private String cmbTipoMIAfectaCosto_Jsonclick ;
      private String lblTextblocktipomiestado_Internalname ;
      private String lblTextblocktipomiestado_Jsonclick ;
      private String cmbTipoMIEstado_Internalname ;
      private String cmbTipoMIEstado_Jsonclick ;
      private String lblTextblocktipomirestringe_Internalname ;
      private String lblTextblocktipomirestringe_Jsonclick ;
      private String cmbTipoMIRestringe_Internalname ;
      private String cmbTipoMIRestringe_Jsonclick ;
      private String Gx_mode ;
      private String sMode29 ;
      private String edtTipoMIAnio_Internalname ;
      private String tblTable3_Internalname ;
      private String lblTitletipomovinventariodet_Internalname ;
      private String lblTitletipomovinventariodet_Jsonclick ;
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
      private String edtTipoMICorrelativo_Internalname ;
      private String sMode28 ;
      private String subGridtipomovinventario_tipomovinventariodet_Class ;
      private String subGridtipomovinventario_tipomovinventariodet_Linesclass ;
      private String ROClassString ;
      private String edtTipoMIAnio_Jsonclick ;
      private String edtTipoMICorrelativo_Jsonclick ;
      private String GXCCtl ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char7 ;
      private String GXt_char5 ;
      private String subGridtipomovinventario_tipomovinventariodet_Internalname ;
      private String GXt_char8 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A41ClinicaCodigo ;
      private String A114TipoMICodigo ;
      private String A115TipoMIDescripcion ;
      private String Z41ClinicaCodigo ;
      private String Z114TipoMICodigo ;
      private String Z115TipoMIDescripcion ;
      private String AV8ClinicaCodigo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Gridtipomovinventario_tipomovinventariodetContainer ;
      private GXWebRow Gridtipomovinventario_tipomovinventariodetRow ;
      private GXWebColumn Gridtipomovinventario_tipomovinventariodetColumn ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbTipoMIOperacion ;
      private GXCombobox cmbTipoMIAfectaCosto ;
      private GXCombobox cmbTipoMIEstado ;
      private GXCombobox cmbTipoMIRestringe ;
      private IDataStoreProvider pr_default ;
      private String[] T000L7_A114TipoMICodigo ;
      private String[] T000L7_A115TipoMIDescripcion ;
      private short[] T000L7_A116TipoMIOperacion ;
      private short[] T000L7_A117TipoMIAfectaCosto ;
      private short[] T000L7_A118TipoMIEstado ;
      private short[] T000L7_A287TipoMIRestringe ;
      private String[] T000L7_A41ClinicaCodigo ;
      private String[] T000L6_A41ClinicaCodigo ;
      private String[] T000L8_A41ClinicaCodigo ;
      private String[] T000L9_A41ClinicaCodigo ;
      private String[] T000L9_A114TipoMICodigo ;
      private String[] T000L5_A114TipoMICodigo ;
      private String[] T000L5_A115TipoMIDescripcion ;
      private short[] T000L5_A116TipoMIOperacion ;
      private short[] T000L5_A117TipoMIAfectaCosto ;
      private short[] T000L5_A118TipoMIEstado ;
      private short[] T000L5_A287TipoMIRestringe ;
      private String[] T000L5_A41ClinicaCodigo ;
      private String[] T000L10_A41ClinicaCodigo ;
      private String[] T000L10_A114TipoMICodigo ;
      private String[] T000L11_A41ClinicaCodigo ;
      private String[] T000L11_A114TipoMICodigo ;
      private String[] T000L12_A114TipoMICodigo ;
      private String[] T000L12_A115TipoMIDescripcion ;
      private short[] T000L12_A116TipoMIOperacion ;
      private short[] T000L12_A117TipoMIAfectaCosto ;
      private short[] T000L12_A118TipoMIEstado ;
      private short[] T000L12_A287TipoMIRestringe ;
      private String[] T000L12_A41ClinicaCodigo ;
      private String[] T000L16_A41ClinicaCodigo ;
      private String[] T000L16_A114TipoMICodigo ;
      private int[] T000L16_A267MovimientoId ;
      private String[] T000L17_A41ClinicaCodigo ;
      private String[] T000L17_A114TipoMICodigo ;
      private String[] T000L18_A41ClinicaCodigo ;
      private String[] T000L18_A114TipoMICodigo ;
      private short[] T000L18_A119TipoMIAnio ;
      private int[] T000L18_A120TipoMICorrelativo ;
      private String[] T000L19_A41ClinicaCodigo ;
      private String[] T000L19_A114TipoMICodigo ;
      private short[] T000L19_A119TipoMIAnio ;
      private String[] T000L3_A41ClinicaCodigo ;
      private String[] T000L3_A114TipoMICodigo ;
      private short[] T000L3_A119TipoMIAnio ;
      private int[] T000L3_A120TipoMICorrelativo ;
      private String[] T000L2_A41ClinicaCodigo ;
      private String[] T000L2_A114TipoMICodigo ;
      private short[] T000L2_A119TipoMIAnio ;
      private int[] T000L2_A120TipoMICorrelativo ;
      private String[] T000L23_A41ClinicaCodigo ;
      private String[] T000L23_A114TipoMICodigo ;
      private short[] T000L23_A119TipoMIAnio ;
      private String[] T000L24_A41ClinicaCodigo ;
      private String[] T000L4_A114TipoMICodigo ;
      private String[] T000L4_A115TipoMIDescripcion ;
      private short[] T000L4_A116TipoMIOperacion ;
      private short[] T000L4_A117TipoMIAfectaCosto ;
      private short[] T000L4_A118TipoMIEstado ;
      private short[] T000L4_A287TipoMIRestringe ;
      private String[] T000L4_A41ClinicaCodigo ;
      private GXWebForm Form ;
      private SdtParametros AV7Parametros ;
      private SdtParametros GXt_SdtParametros6 ;
   }

   public class tipomovinventario__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new UpdateCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000L4 ;
          prmT000L4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000L7 ;
          prmT000L7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000L6 ;
          prmT000L6 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000L8 ;
          prmT000L8 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000L9 ;
          prmT000L9 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000L5 ;
          prmT000L5 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000L10 ;
          prmT000L10 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000L11 ;
          prmT000L11 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000L12 ;
          prmT000L12 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000L13 ;
          prmT000L13 = new Object[] {
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMIDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@TipoMIOperacion",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TipoMIAfectaCosto",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TipoMIEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TipoMIRestringe",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000L14 ;
          prmT000L14 = new Object[] {
          new Object[] {"@TipoMIDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@TipoMIOperacion",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TipoMIAfectaCosto",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TipoMIEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TipoMIRestringe",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000L15 ;
          prmT000L15 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000L16 ;
          prmT000L16 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000L17 ;
          prmT000L17 = new Object[] {
          } ;
          Object[] prmT000L18 ;
          prmT000L18 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMIAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000L19 ;
          prmT000L19 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMIAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000L3 ;
          prmT000L3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMIAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000L2 ;
          prmT000L2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMIAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000L20 ;
          prmT000L20 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMIAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoMICorrelativo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000L21 ;
          prmT000L21 = new Object[] {
          new Object[] {"@TipoMICorrelativo",SqlDbType.Int,9,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMIAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000L22 ;
          prmT000L22 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMIAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000L23 ;
          prmT000L23 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000L24 ;
          prmT000L24 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000L2", "SELECT [ClinicaCodigo], [TipoMICodigo], [TipoMIAnio], [TipoMICorrelativo] FROM [TipoMovInventarioDet] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo AND [TipoMIAnio] = @TipoMIAnio ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L2,1,0,true,false )
             ,new CursorDef("T000L3", "SELECT [ClinicaCodigo], [TipoMICodigo], [TipoMIAnio], [TipoMICorrelativo] FROM [TipoMovInventarioDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo AND [TipoMIAnio] = @TipoMIAnio ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L3,1,0,true,false )
             ,new CursorDef("T000L4", "SELECT [TipoMICodigo], [TipoMIDescripcion], [TipoMIOperacion], [TipoMIAfectaCosto], [TipoMIEstado], [TipoMIRestringe], [ClinicaCodigo] FROM [TipoMovInventario] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L4,1,0,true,false )
             ,new CursorDef("T000L5", "SELECT [TipoMICodigo], [TipoMIDescripcion], [TipoMIOperacion], [TipoMIAfectaCosto], [TipoMIEstado], [TipoMIRestringe], [ClinicaCodigo] FROM [TipoMovInventario] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L5,1,0,true,false )
             ,new CursorDef("T000L6", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L6,1,0,true,false )
             ,new CursorDef("T000L7", "SELECT TM1.[TipoMICodigo], TM1.[TipoMIDescripcion], TM1.[TipoMIOperacion], TM1.[TipoMIAfectaCosto], TM1.[TipoMIEstado], TM1.[TipoMIRestringe], TM1.[ClinicaCodigo] FROM [TipoMovInventario] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[TipoMICodigo] = @TipoMICodigo ORDER BY TM1.[ClinicaCodigo], TM1.[TipoMICodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000L7,100,0,true,false )
             ,new CursorDef("T000L8", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L8,1,0,true,false )
             ,new CursorDef("T000L9", "SELECT [ClinicaCodigo], [TipoMICodigo] FROM [TipoMovInventario] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000L9,1,0,true,false )
             ,new CursorDef("T000L10", "SELECT TOP 1 [ClinicaCodigo], [TipoMICodigo] FROM [TipoMovInventario] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [TipoMICodigo] > @TipoMICodigo) ORDER BY [ClinicaCodigo], [TipoMICodigo]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000L10,1,0,true,true )
             ,new CursorDef("T000L11", "SELECT TOP 1 [ClinicaCodigo], [TipoMICodigo] FROM [TipoMovInventario] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [TipoMICodigo] < @TipoMICodigo) ORDER BY [ClinicaCodigo] DESC, [TipoMICodigo] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000L11,1,0,true,true )
             ,new CursorDef("T000L12", "SELECT [TipoMICodigo], [TipoMIDescripcion], [TipoMIOperacion], [TipoMIAfectaCosto], [TipoMIEstado], [TipoMIRestringe], [ClinicaCodigo] FROM [TipoMovInventario] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L12,1,0,true,false )
             ,new CursorDef("T000L13", "INSERT INTO [TipoMovInventario] ([TipoMICodigo], [TipoMIDescripcion], [TipoMIOperacion], [TipoMIAfectaCosto], [TipoMIEstado], [TipoMIRestringe], [ClinicaCodigo]) VALUES (@TipoMICodigo, @TipoMIDescripcion, @TipoMIOperacion, @TipoMIAfectaCosto, @TipoMIEstado, @TipoMIRestringe, @ClinicaCodigo)", GxErrorMask.GX_NOMASK,prmT000L13)
             ,new CursorDef("T000L14", "UPDATE [TipoMovInventario] SET [TipoMIDescripcion]=@TipoMIDescripcion, [TipoMIOperacion]=@TipoMIOperacion, [TipoMIAfectaCosto]=@TipoMIAfectaCosto, [TipoMIEstado]=@TipoMIEstado, [TipoMIRestringe]=@TipoMIRestringe  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo", GxErrorMask.GX_NOMASK,prmT000L14)
             ,new CursorDef("T000L15", "DELETE FROM [TipoMovInventario]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo", GxErrorMask.GX_NOMASK,prmT000L15)
             ,new CursorDef("T000L16", "SELECT TOP 1 [ClinicaCodigo], [TipoMICodigo], [MovimientoId] FROM [MovimientoInv] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L16,1,0,true,true )
             ,new CursorDef("T000L17", "SELECT [ClinicaCodigo], [TipoMICodigo] FROM [TipoMovInventario] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [TipoMICodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000L17,100,0,true,false )
             ,new CursorDef("T000L18", "SELECT [ClinicaCodigo], [TipoMICodigo], [TipoMIAnio], [TipoMICorrelativo] FROM [TipoMovInventarioDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [TipoMICodigo] = @TipoMICodigo and [TipoMIAnio] = @TipoMIAnio ORDER BY [ClinicaCodigo], [TipoMICodigo], [TipoMIAnio] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L18,11,0,true,false )
             ,new CursorDef("T000L19", "SELECT [ClinicaCodigo], [TipoMICodigo], [TipoMIAnio] FROM [TipoMovInventarioDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo AND [TipoMIAnio] = @TipoMIAnio ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L19,1,0,true,false )
             ,new CursorDef("T000L20", "INSERT INTO [TipoMovInventarioDet] ([ClinicaCodigo], [TipoMICodigo], [TipoMIAnio], [TipoMICorrelativo]) VALUES (@ClinicaCodigo, @TipoMICodigo, @TipoMIAnio, @TipoMICorrelativo)", GxErrorMask.GX_NOMASK,prmT000L20)
             ,new CursorDef("T000L21", "UPDATE [TipoMovInventarioDet] SET [TipoMICorrelativo]=@TipoMICorrelativo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo AND [TipoMIAnio] = @TipoMIAnio", GxErrorMask.GX_NOMASK,prmT000L21)
             ,new CursorDef("T000L22", "DELETE FROM [TipoMovInventarioDet]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo AND [TipoMIAnio] = @TipoMIAnio", GxErrorMask.GX_NOMASK,prmT000L22)
             ,new CursorDef("T000L23", "SELECT [ClinicaCodigo], [TipoMICodigo], [TipoMIAnio] FROM [TipoMovInventarioDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [TipoMICodigo] = @TipoMICodigo ORDER BY [ClinicaCodigo], [TipoMICodigo], [TipoMIAnio] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L23,11,0,true,false )
             ,new CursorDef("T000L24", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L24,1,0,true,false )
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
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
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
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
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
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 22 :
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
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
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
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 19 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 20 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 21 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 22 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
