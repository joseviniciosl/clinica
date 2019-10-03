/*
               File: CuentaBancaria
        Description: Cuentas Bancarias
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:5:28.52
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
   public class cuentabancaria : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A126BancoCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BancoCodigo", A126BancoCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_5( A41ClinicaCodigo, A126BancoCodigo) ;
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
         cmbCuentaBancariaTipo.Name = "CUENTABANCARIATIPO" ;
         cmbCuentaBancariaTipo.WebTags = "" ;
         cmbCuentaBancariaTipo.addItem("M", "Monetaria", 0);
         cmbCuentaBancariaTipo.addItem("A", "Ahorro", 0);
         if ( ( cmbCuentaBancariaTipo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A130CuentaBancariaTipo)) )
         {
            A130CuentaBancariaTipo = cmbCuentaBancariaTipo.getItemValue(1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130CuentaBancariaTipo", A130CuentaBancariaTipo);
         }
         cmbCuentaBancariaEstado.Name = "CUENTABANCARIAESTADO" ;
         cmbCuentaBancariaEstado.WebTags = "" ;
         cmbCuentaBancariaEstado.addItem("0", "De baja", 0);
         cmbCuentaBancariaEstado.addItem("1", "Activo", 0);
         if ( ( cmbCuentaBancariaEstado.ItemCount > 0 ) && (0==A131CuentaBancariaEstado) )
         {
            A131CuentaBancariaEstado = (short)(NumberUtil.Val( cmbCuentaBancariaEstado.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131CuentaBancariaEstado", StringUtil.Str( (decimal)(A131CuentaBancariaEstado), 1, 0));
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Cuentas Bancarias", 0) ;
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

      public cuentabancaria( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public cuentabancaria( IGxContext context )
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
         cmbCuentaBancariaTipo = new GXCombobox();
         cmbCuentaBancariaEstado = new GXCombobox();
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
            wb_table1_2_0R35( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0R35e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0R35( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0R35( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0R35e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Cuentas Bancarias"+"</legend>") ;
            wb_table3_27_0R35( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0R35e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0R35e( true) ;
         }
         else
         {
            wb_table1_2_0R35e( false) ;
         }
      }

      protected void wb_table3_27_0R35( bool wbgen )
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
            wb_table4_33_0R35( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0R35e( bool wbgen )
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_CuentaBancaria.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_CuentaBancaria.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_CuentaBancaria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0R35e( true) ;
         }
         else
         {
            wb_table3_27_0R35e( false) ;
         }
      }

      protected void wb_table4_33_0R35( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", lblTextblockclinicacodigo_Visible, 1, 0, "HLP_CuentaBancaria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", edtClinicaCodigo_Visible, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_CuentaBancaria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcuentabancariacodigo_Internalname, "Código", "", "", lblTextblockcuentabancariacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CuentaBancaria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCuentaBancariaCodigo_Internalname, StringUtil.RTrim( A128CuentaBancariaCodigo), StringUtil.RTrim( context.localUtil.Format( A128CuentaBancariaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtCuentaBancariaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtCuentaBancariaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_CuentaBancaria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcuentabancarianombre_Internalname, "Nombre", "", "", lblTextblockcuentabancarianombre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CuentaBancaria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129CuentaBancariaNombre", A129CuentaBancariaNombre);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCuentaBancariaNombre_Internalname, StringUtil.RTrim( A129CuentaBancariaNombre), StringUtil.RTrim( context.localUtil.Format( A129CuentaBancariaNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", "", "", "", edtCuentaBancariaNombre_Jsonclick, 0, ClassString, StyleString, "", 1, edtCuentaBancariaNombre_Enabled, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_CuentaBancaria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcuentabancariacuenta_Internalname, "Cuenta", "", "", lblTextblockcuentabancariacuenta_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CuentaBancaria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A137CuentaBancariaCuenta", A137CuentaBancariaCuenta);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCuentaBancariaCuenta_Internalname, StringUtil.RTrim( A137CuentaBancariaCuenta), StringUtil.RTrim( context.localUtil.Format( A137CuentaBancariaCuenta, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "", "", "", "", edtCuentaBancariaCuenta_Jsonclick, 0, ClassString, StyleString, "", 1, edtCuentaBancariaCuenta_Enabled, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_CuentaBancaria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcuentabancariatipo_Internalname, "Tipo", "", "", lblTextblockcuentabancariatipo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CuentaBancaria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130CuentaBancariaTipo", A130CuentaBancariaTipo);
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbCuentaBancariaTipo, cmbCuentaBancariaTipo_Internalname, A130CuentaBancariaTipo, 1, cmbCuentaBancariaTipo_Jsonclick, 0, "", "svchar", "", 1, cmbCuentaBancariaTipo.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", "", true, "HLP_CuentaBancaria.htm");
            cmbCuentaBancariaTipo.CurrentValue = A130CuentaBancariaTipo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCuentaBancariaTipo_Internalname, "Values", (String)(cmbCuentaBancariaTipo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbancocodigo_Internalname, "Código", "", "", lblTextblockbancocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CuentaBancaria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BancoCodigo", A126BancoCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBancoCodigo_Internalname, StringUtil.RTrim( A126BancoCodigo), StringUtil.RTrim( context.localUtil.Format( A126BancoCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", "", "", "", "", edtBancoCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtBancoCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_CuentaBancaria.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_126_Internalname, "prompt.gif", imgprompt_41_126_Link, "", "", "Fantastic", imgprompt_41_126_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_CuentaBancaria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbancodescripcion_Internalname, "Banco", "", "", lblTextblockbancodescripcion_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CuentaBancaria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127BancoDescripcion", A127BancoDescripcion);
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBancoDescripcion_Internalname, StringUtil.RTrim( A127BancoDescripcion), StringUtil.RTrim( context.localUtil.Format( A127BancoDescripcion, "")), "", "", "", "", "", edtBancoDescripcion_Jsonclick, 0, ClassString, StyleString, "", 1, edtBancoDescripcion_Enabled, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_CuentaBancaria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcuentabancariaestado_Internalname, "Estado", "", "", lblTextblockcuentabancariaestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CuentaBancaria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131CuentaBancariaEstado", StringUtil.Str( (decimal)(A131CuentaBancariaEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbCuentaBancariaEstado, cmbCuentaBancariaEstado_Internalname, StringUtil.Str( (decimal)(A131CuentaBancariaEstado), 1, 0), 1, cmbCuentaBancariaEstado_Jsonclick, 0, "", "int", "", 1, cmbCuentaBancariaEstado.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(73);\"", "", true, "HLP_CuentaBancaria.htm");
            cmbCuentaBancariaEstado.CurrentValue = StringUtil.Str( (decimal)(A131CuentaBancariaEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCuentaBancariaEstado_Internalname, "Values", (String)(cmbCuentaBancariaEstado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0R35e( true) ;
         }
         else
         {
            wb_table4_33_0R35e( false) ;
         }
      }

      protected void wb_table2_5_0R35( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaBancaria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaBancaria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaBancaria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaBancaria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaBancaria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaBancaria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaBancaria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaBancaria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00z0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CUENTABANCARIACODIGO"+"'), id:'"+"CUENTABANCARIACODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_CuentaBancaria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00z0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CUENTABANCARIACODIGO"+"'), id:'"+"CUENTABANCARIACODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_CuentaBancaria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaBancaria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaBancaria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaBancaria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaBancaria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaBancaria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaBancaria.htm");
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
            wb_table2_5_0R35e( true) ;
         }
         else
         {
            wb_table2_5_0R35e( false) ;
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
         /* Execute user event: E110R2 */
         E110R2 ();
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
               A128CuentaBancariaCodigo = cgiGet( edtCuentaBancariaCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
               A129CuentaBancariaNombre = cgiGet( edtCuentaBancariaNombre_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129CuentaBancariaNombre", A129CuentaBancariaNombre);
               A137CuentaBancariaCuenta = cgiGet( edtCuentaBancariaCuenta_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A137CuentaBancariaCuenta", A137CuentaBancariaCuenta);
               cmbCuentaBancariaTipo.CurrentValue = cgiGet( cmbCuentaBancariaTipo_Internalname) ;
               A130CuentaBancariaTipo = cgiGet( cmbCuentaBancariaTipo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130CuentaBancariaTipo", A130CuentaBancariaTipo);
               A126BancoCodigo = cgiGet( edtBancoCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BancoCodigo", A126BancoCodigo);
               A127BancoDescripcion = cgiGet( edtBancoDescripcion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127BancoDescripcion", A127BancoDescripcion);
               cmbCuentaBancariaEstado.CurrentValue = cgiGet( cmbCuentaBancariaEstado_Internalname) ;
               A131CuentaBancariaEstado = (short)(NumberUtil.Val( cgiGet( cmbCuentaBancariaEstado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131CuentaBancariaEstado", StringUtil.Str( (decimal)(A131CuentaBancariaEstado), 1, 0));
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z128CuentaBancariaCodigo = cgiGet( "Z128CuentaBancariaCodigo") ;
               Z129CuentaBancariaNombre = cgiGet( "Z129CuentaBancariaNombre") ;
               Z137CuentaBancariaCuenta = cgiGet( "Z137CuentaBancariaCuenta") ;
               Z130CuentaBancariaTipo = cgiGet( "Z130CuentaBancariaTipo") ;
               Z131CuentaBancariaEstado = (short)(context.localUtil.CToN( cgiGet( "Z131CuentaBancariaEstado"), ".", ",")) ;
               Z126BancoCodigo = cgiGet( "Z126BancoCodigo") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
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
                  A128CuentaBancariaCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
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
                           /* Execute user event: E110R2 */
                           E110R2 ();
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
               InitAll0R35( ) ;
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
         DisableAttributes0R35( ) ;
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

      protected void ResetCaption0R0( )
      {
      }

      protected void E110R2( )
      {
         /* Start Routine */
         GXt_SdtParametros3 = AV7Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros3) ;
         AV7Parametros = GXt_SdtParametros3 ;
         AV8ClinicaCodigo = AV7Parametros.gxTpr_Pclinicacodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClinicaCodigo", AV8ClinicaCodigo);
      }

      protected void ZM0R35( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z129CuentaBancariaNombre = T000R3_A129CuentaBancariaNombre[0] ;
               Z137CuentaBancariaCuenta = T000R3_A137CuentaBancariaCuenta[0] ;
               Z130CuentaBancariaTipo = T000R3_A130CuentaBancariaTipo[0] ;
               Z131CuentaBancariaEstado = T000R3_A131CuentaBancariaEstado[0] ;
               Z126BancoCodigo = T000R3_A126BancoCodigo[0] ;
            }
            else
            {
               Z129CuentaBancariaNombre = A129CuentaBancariaNombre ;
               Z137CuentaBancariaCuenta = A137CuentaBancariaCuenta ;
               Z130CuentaBancariaTipo = A130CuentaBancariaTipo ;
               Z131CuentaBancariaEstado = A131CuentaBancariaEstado ;
               Z126BancoCodigo = A126BancoCodigo ;
            }
         }
         if ( GX_JID == -4 )
         {
            Z128CuentaBancariaCodigo = A128CuentaBancariaCodigo ;
            Z129CuentaBancariaNombre = A129CuentaBancariaNombre ;
            Z137CuentaBancariaCuenta = A137CuentaBancariaCuenta ;
            Z130CuentaBancariaTipo = A130CuentaBancariaTipo ;
            Z131CuentaBancariaEstado = A131CuentaBancariaEstado ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z126BancoCodigo = A126BancoCodigo ;
            Z127BancoDescripcion = A127BancoDescripcion ;
         }
      }

      protected void standaloneNotModal( )
      {
         lblTextblockclinicacodigo_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTextblockclinicacodigo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblTextblockclinicacodigo_Visible), 5, 0)));
         edtClinicaCodigo_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Visible), 5, 0)));
         imgprompt_41_126_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00y0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"BANCOCODIGO"+"'), id:'"+"BANCOCODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
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

      protected void Load0R35( )
      {
         /* Using cursor T000R5 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A128CuentaBancariaCodigo});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound35 = 1 ;
            A129CuentaBancariaNombre = T000R5_A129CuentaBancariaNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129CuentaBancariaNombre", A129CuentaBancariaNombre);
            A137CuentaBancariaCuenta = T000R5_A137CuentaBancariaCuenta[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A137CuentaBancariaCuenta", A137CuentaBancariaCuenta);
            A130CuentaBancariaTipo = T000R5_A130CuentaBancariaTipo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130CuentaBancariaTipo", A130CuentaBancariaTipo);
            A127BancoDescripcion = T000R5_A127BancoDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127BancoDescripcion", A127BancoDescripcion);
            A131CuentaBancariaEstado = T000R5_A131CuentaBancariaEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131CuentaBancariaEstado", StringUtil.Str( (decimal)(A131CuentaBancariaEstado), 1, 0));
            A126BancoCodigo = T000R5_A126BancoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BancoCodigo", A126BancoCodigo);
            ZM0R35( -4) ;
         }
         pr_default.close(3);
         OnLoadActions0R35( ) ;
      }

      protected void OnLoadActions0R35( )
      {
      }

      protected void CheckExtendedTable0R35( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T000R4 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo, A126BancoCodigo});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError41 = 1 ;
            AnyError126 = 1 ;
            GX_msglist.addItem("No existe 'Bancos'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError126 == 0 ) )
         {
            A127BancoDescripcion = T000R4_A127BancoDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127BancoDescripcion", A127BancoDescripcion);
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0R35( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_5( String A41ClinicaCodigo ,
                               String A126BancoCodigo )
      {
         /* Using cursor T000R6 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo, A126BancoCodigo});
         if ( (pr_default.getStatus(4) == 101) )
         {
            AnyError41 = 1 ;
            AnyError126 = 1 ;
            GX_msglist.addItem("No existe 'Bancos'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError126 == 0 ) )
         {
            A127BancoDescripcion = T000R6_A127BancoDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127BancoDescripcion", A127BancoDescripcion);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A127BancoDescripcion))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(4);
      }

      protected void GetKey0R35( )
      {
         /* Using cursor T000R7 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A128CuentaBancariaCodigo});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound35 = 1 ;
         }
         else
         {
            RcdFound35 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000R3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A128CuentaBancariaCodigo});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0R35( 4) ;
            RcdFound35 = 1 ;
            A128CuentaBancariaCodigo = T000R3_A128CuentaBancariaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
            A129CuentaBancariaNombre = T000R3_A129CuentaBancariaNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129CuentaBancariaNombre", A129CuentaBancariaNombre);
            A137CuentaBancariaCuenta = T000R3_A137CuentaBancariaCuenta[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A137CuentaBancariaCuenta", A137CuentaBancariaCuenta);
            A130CuentaBancariaTipo = T000R3_A130CuentaBancariaTipo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130CuentaBancariaTipo", A130CuentaBancariaTipo);
            A131CuentaBancariaEstado = T000R3_A131CuentaBancariaEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131CuentaBancariaEstado", StringUtil.Str( (decimal)(A131CuentaBancariaEstado), 1, 0));
            A41ClinicaCodigo = T000R3_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A126BancoCodigo = T000R3_A126BancoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BancoCodigo", A126BancoCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z128CuentaBancariaCodigo = A128CuentaBancariaCodigo ;
            sMode35 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0R35( ) ;
            Gx_mode = sMode35 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound35 = 0 ;
            InitializeNonKey0R35( ) ;
            sMode35 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode35 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0R35( ) ;
         if ( RcdFound35 == 0 )
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
         RcdFound35 = 0 ;
         /* Using cursor T000R8 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, A128CuentaBancariaCodigo});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T000R8_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000R8_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000R8_A128CuentaBancariaCodigo[0], A128CuentaBancariaCodigo) < 0 ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T000R8_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000R8_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000R8_A128CuentaBancariaCodigo[0], A128CuentaBancariaCodigo) > 0 ) ) )
            {
               A41ClinicaCodigo = T000R8_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A128CuentaBancariaCodigo = T000R8_A128CuentaBancariaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
               RcdFound35 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound35 = 0 ;
         /* Using cursor T000R9 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A128CuentaBancariaCodigo});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T000R9_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000R9_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000R9_A128CuentaBancariaCodigo[0], A128CuentaBancariaCodigo) > 0 ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T000R9_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000R9_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000R9_A128CuentaBancariaCodigo[0], A128CuentaBancariaCodigo) < 0 ) ) )
            {
               A41ClinicaCodigo = T000R9_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A128CuentaBancariaCodigo = T000R9_A128CuentaBancariaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
               RcdFound35 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0R35( ) ;
         if ( RcdFound35 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A128CuentaBancariaCodigo, Z128CuentaBancariaCodigo) != 0 ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A128CuentaBancariaCodigo = Z128CuentaBancariaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
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
               Update0R35( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A128CuentaBancariaCodigo, Z128CuentaBancariaCodigo) != 0 ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert0R35( ) ;
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
                  Insert0R35( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A128CuentaBancariaCodigo, Z128CuentaBancariaCodigo) != 0 ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A128CuentaBancariaCodigo = Z128CuentaBancariaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
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
         if ( RcdFound35 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtCuentaBancariaNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0R35( ) ;
         if ( RcdFound35 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCuentaBancariaNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0R35( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound35 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCuentaBancariaNombre_Internalname ;
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
         if ( RcdFound35 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCuentaBancariaNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0R35( ) ;
         if ( RcdFound35 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound35 != 0 )
            {
               ScanNext0R35( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCuentaBancariaNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0R35( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0R35( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000R10 */
            pr_default.execute(8, new Object[] {A41ClinicaCodigo, A128CuentaBancariaCodigo});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CuentaBancaria"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(8) == 101) || ( StringUtil.StrCmp(Z129CuentaBancariaNombre, T000R10_A129CuentaBancariaNombre[0]) != 0 ) || ( StringUtil.StrCmp(Z137CuentaBancariaCuenta, T000R10_A137CuentaBancariaCuenta[0]) != 0 ) || ( StringUtil.StrCmp(Z130CuentaBancariaTipo, T000R10_A130CuentaBancariaTipo[0]) != 0 ) || ( Z131CuentaBancariaEstado != T000R10_A131CuentaBancariaEstado[0] ) || ( StringUtil.StrCmp(Z126BancoCodigo, T000R10_A126BancoCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"CuentaBancaria"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0R35( )
      {
         BeforeValidate0R35( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0R35( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0R35( 0) ;
            CheckOptimisticConcurrency0R35( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0R35( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0R35( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000R11 */
                     pr_default.execute(9, new Object[] {A128CuentaBancariaCodigo, A129CuentaBancariaNombre, A137CuentaBancariaCuenta, A130CuentaBancariaTipo, A131CuentaBancariaEstado, A41ClinicaCodigo, A126BancoCodigo});
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
                           ResetCaption0R0( ) ;
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
               Load0R35( ) ;
            }
            EndLevel0R35( ) ;
         }
         CloseExtendedTableCursors0R35( ) ;
      }

      protected void Update0R35( )
      {
         BeforeValidate0R35( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0R35( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0R35( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0R35( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0R35( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000R12 */
                     pr_default.execute(10, new Object[] {A129CuentaBancariaNombre, A137CuentaBancariaCuenta, A130CuentaBancariaTipo, A131CuentaBancariaEstado, A126BancoCodigo, A41ClinicaCodigo, A128CuentaBancariaCodigo});
                     pr_default.close(10);
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CuentaBancaria"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0R35( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                           ResetCaption0R0( ) ;
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
            EndLevel0R35( ) ;
         }
         CloseExtendedTableCursors0R35( ) ;
      }

      protected void DeferredUpdate0R35( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0R35( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0R35( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0R35( ) ;
            AfterConfirm0R35( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0R35( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000R13 */
                  pr_default.execute(11, new Object[] {A41ClinicaCodigo, A128CuentaBancariaCodigo});
                  pr_default.close(11);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound35 == 0 )
                        {
                           InitAll0R35( ) ;
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
                        ResetCaption0R0( ) ;
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
         sMode35 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0R35( ) ;
         Gx_mode = sMode35 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0R35( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000R14 */
            pr_default.execute(12, new Object[] {A41ClinicaCodigo, A126BancoCodigo});
            A127BancoDescripcion = T000R14_A127BancoDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127BancoDescripcion", A127BancoDescripcion);
            pr_default.close(12);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000R15 */
            pr_default.execute(13, new Object[] {A41ClinicaCodigo, A128CuentaBancariaCodigo});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Depósitos Bancarios de Caja"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(13);
         }
      }

      protected void EndLevel0R35( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0R35( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(6);
            pr_default.close(12);
            context.CommitDataStores("CuentaBancaria");
            if ( AnyError == 0 )
            {
               ConfirmValues0R0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(6);
            pr_default.close(12);
            context.RollbackDataStores("CuentaBancaria");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0R35( )
      {
         /* Using cursor T000R16 */
         pr_default.execute(14);
         RcdFound35 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound35 = 1 ;
            A41ClinicaCodigo = T000R16_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A128CuentaBancariaCodigo = T000R16_A128CuentaBancariaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0R35( )
      {
         pr_default.readNext(14);
         RcdFound35 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound35 = 1 ;
            A41ClinicaCodigo = T000R16_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A128CuentaBancariaCodigo = T000R16_A128CuentaBancariaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
         }
      }

      protected void ScanEnd0R35( )
      {
      }

      protected void AfterConfirm0R35( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0R35( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0R35( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0R35( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0R35( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0R35( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0R35( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtCuentaBancariaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCuentaBancariaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCuentaBancariaCodigo_Enabled), 5, 0)));
         edtCuentaBancariaNombre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCuentaBancariaNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCuentaBancariaNombre_Enabled), 5, 0)));
         edtCuentaBancariaCuenta_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCuentaBancariaCuenta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCuentaBancariaCuenta_Enabled), 5, 0)));
         cmbCuentaBancariaTipo.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCuentaBancariaTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbCuentaBancariaTipo.Enabled), 5, 0)));
         edtBancoCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBancoCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBancoCodigo_Enabled), 5, 0)));
         edtBancoDescripcion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBancoDescripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBancoDescripcion_Enabled), 5, 0)));
         cmbCuentaBancariaEstado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCuentaBancariaEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbCuentaBancariaEstado.Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0R0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("cuentabancaria.aspx") +"\" class=\""+"Form"+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z129CuentaBancariaNombre", StringUtil.RTrim( Z129CuentaBancariaNombre));
         GxWebStd.gx_hidden_field( context, "Z137CuentaBancariaCuenta", StringUtil.RTrim( Z137CuentaBancariaCuenta));
         GxWebStd.gx_hidden_field( context, "Z130CuentaBancariaTipo", StringUtil.RTrim( Z130CuentaBancariaTipo));
         GxWebStd.gx_hidden_field( context, "Z131CuentaBancariaEstado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z131CuentaBancariaEstado), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z126BancoCodigo", StringUtil.RTrim( Z126BancoCodigo));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
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
         return "CuentaBancaria" ;
      }

      public override String GetPgmdesc( )
      {
         return "Cuentas Bancarias" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("cuentabancaria.aspx")  ;
      }

      protected void InitializeNonKey0R35( )
      {
         A129CuentaBancariaNombre = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129CuentaBancariaNombre", A129CuentaBancariaNombre);
         A137CuentaBancariaCuenta = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A137CuentaBancariaCuenta", A137CuentaBancariaCuenta);
         A130CuentaBancariaTipo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130CuentaBancariaTipo", A130CuentaBancariaTipo);
         A126BancoCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BancoCodigo", A126BancoCodigo);
         A127BancoDescripcion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127BancoDescripcion", A127BancoDescripcion);
         A131CuentaBancariaEstado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131CuentaBancariaEstado", StringUtil.Str( (decimal)(A131CuentaBancariaEstado), 1, 0));
      }

      protected void InitAll0R35( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A128CuentaBancariaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
         InitializeNonKey0R35( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1553017");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("cuentabancaria.js", "?1553018");
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
         lblTextblockcuentabancariacodigo_Internalname = "TEXTBLOCKCUENTABANCARIACODIGO" ;
         edtCuentaBancariaCodigo_Internalname = "CUENTABANCARIACODIGO" ;
         lblTextblockcuentabancarianombre_Internalname = "TEXTBLOCKCUENTABANCARIANOMBRE" ;
         edtCuentaBancariaNombre_Internalname = "CUENTABANCARIANOMBRE" ;
         lblTextblockcuentabancariacuenta_Internalname = "TEXTBLOCKCUENTABANCARIACUENTA" ;
         edtCuentaBancariaCuenta_Internalname = "CUENTABANCARIACUENTA" ;
         lblTextblockcuentabancariatipo_Internalname = "TEXTBLOCKCUENTABANCARIATIPO" ;
         cmbCuentaBancariaTipo_Internalname = "CUENTABANCARIATIPO" ;
         lblTextblockbancocodigo_Internalname = "TEXTBLOCKBANCOCODIGO" ;
         edtBancoCodigo_Internalname = "BANCOCODIGO" ;
         lblTextblockbancodescripcion_Internalname = "TEXTBLOCKBANCODESCRIPCION" ;
         edtBancoDescripcion_Internalname = "BANCODESCRIPCION" ;
         lblTextblockcuentabancariaestado_Internalname = "TEXTBLOCKCUENTABANCARIAESTADO" ;
         cmbCuentaBancariaEstado_Internalname = "CUENTABANCARIAESTADO" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_126_Internalname = "PROMPT_41_126" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Cuentas Bancarias" ;
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
         cmbCuentaBancariaEstado_Jsonclick = "" ;
         cmbCuentaBancariaEstado.Enabled = 1 ;
         edtBancoDescripcion_Jsonclick = "" ;
         edtBancoDescripcion_Enabled = 0 ;
         imgprompt_41_126_Visible = 1 ;
         imgprompt_41_126_Link = "" ;
         edtBancoCodigo_Jsonclick = "" ;
         edtBancoCodigo_Enabled = 1 ;
         cmbCuentaBancariaTipo_Jsonclick = "" ;
         cmbCuentaBancariaTipo.Enabled = 1 ;
         edtCuentaBancariaCuenta_Jsonclick = "" ;
         edtCuentaBancariaCuenta_Enabled = 1 ;
         edtCuentaBancariaNombre_Jsonclick = "" ;
         edtCuentaBancariaNombre_Enabled = 1 ;
         edtCuentaBancariaCodigo_Jsonclick = "" ;
         edtCuentaBancariaCodigo_Enabled = 1 ;
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
         GX_FocusControl = edtCuentaBancariaNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Cuentabancariacodigo( String GX_Parm1 ,
                                              String GX_Parm2 ,
                                              String GX_Parm3 ,
                                              String GX_Parm4 ,
                                              String GX_Parm5 ,
                                              GXCombobox cmbGX_Parm6 ,
                                              GXCombobox cmbGX_Parm7 ,
                                              String GX_Parm8 )
      {
         AV8ClinicaCodigo = GX_Parm1 ;
         A41ClinicaCodigo = GX_Parm2 ;
         A128CuentaBancariaCodigo = GX_Parm3 ;
         A129CuentaBancariaNombre = GX_Parm4 ;
         A137CuentaBancariaCuenta = GX_Parm5 ;
         cmbCuentaBancariaTipo = cmbGX_Parm6 ;
         A130CuentaBancariaTipo = cmbCuentaBancariaTipo.CurrentValue ;
         cmbCuentaBancariaTipo.CurrentValue = A130CuentaBancariaTipo ;
         cmbCuentaBancariaEstado = cmbGX_Parm7 ;
         A131CuentaBancariaEstado = (short)(NumberUtil.Val( cmbCuentaBancariaEstado.CurrentValue, ".")) ;
         cmbCuentaBancariaEstado.CurrentValue = StringUtil.Str( (decimal)(A131CuentaBancariaEstado), 1, 0) ;
         A126BancoCodigo = GX_Parm8 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A127BancoDescripcion = "" ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A129CuentaBancariaNombre)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A137CuentaBancariaCuenta)));
         cmbCuentaBancariaTipo.CurrentValue = A130CuentaBancariaTipo ;
         isValidOutput.Add((Object)(cmbCuentaBancariaTipo));
         isValidOutput.Add((Object)(StringUtil.RTrim( A126BancoCodigo)));
         cmbCuentaBancariaEstado.CurrentValue = StringUtil.Str( (decimal)(A131CuentaBancariaEstado), 1, 0) ;
         isValidOutput.Add((Object)(cmbCuentaBancariaEstado));
         isValidOutput.Add((Object)(StringUtil.RTrim( A127BancoDescripcion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z128CuentaBancariaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z129CuentaBancariaNombre)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z137CuentaBancariaCuenta)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z130CuentaBancariaTipo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z126BancoCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z131CuentaBancariaEstado), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z127BancoDescripcion)));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Bancocodigo( String GX_Parm1 ,
                                     String GX_Parm2 ,
                                     String GX_Parm3 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A126BancoCodigo = GX_Parm2 ;
         A127BancoDescripcion = GX_Parm3 ;
         /* Using cursor T000R14 */
         pr_default.execute(12, new Object[] {A41ClinicaCodigo, A126BancoCodigo});
         if ( (pr_default.getStatus(12) == 101) )
         {
            AnyError41 = 1 ;
            AnyError126 = 1 ;
            GX_msglist.addItem("No existe 'Bancos'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError126 == 0 ) )
         {
            A127BancoDescripcion = T000R14_A127BancoDescripcion[0] ;
         }
         pr_default.close(12);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A127BancoDescripcion = "" ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A127BancoDescripcion)));
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
         pr_default.close(7);
         pr_default.close(6);
         pr_default.close(12);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
         A126BancoCodigo = "" ;
         GXKey = "" ;
         A130CuentaBancariaTipo = "" ;
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
         lblTextblockcuentabancariacodigo_Jsonclick = "" ;
         A128CuentaBancariaCodigo = "" ;
         lblTextblockcuentabancarianombre_Jsonclick = "" ;
         A129CuentaBancariaNombre = "" ;
         lblTextblockcuentabancariacuenta_Jsonclick = "" ;
         A137CuentaBancariaCuenta = "" ;
         lblTextblockcuentabancariatipo_Jsonclick = "" ;
         lblTextblockbancocodigo_Jsonclick = "" ;
         lblTextblockbancodescripcion_Jsonclick = "" ;
         A127BancoDescripcion = "" ;
         lblTextblockcuentabancariaestado_Jsonclick = "" ;
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
         Z129CuentaBancariaNombre = "" ;
         Z137CuentaBancariaCuenta = "" ;
         Z130CuentaBancariaTipo = "" ;
         Z126BancoCodigo = "" ;
         Gx_mode = "" ;
         AV8ClinicaCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV7Parametros = new SdtParametros(context);
         GXt_SdtParametros3 = new SdtParametros(context);
         Z127BancoDescripcion = "" ;
         T000R5_A128CuentaBancariaCodigo = new String[] {""} ;
         T000R5_A129CuentaBancariaNombre = new String[] {""} ;
         T000R5_A137CuentaBancariaCuenta = new String[] {""} ;
         T000R5_A130CuentaBancariaTipo = new String[] {""} ;
         T000R5_A127BancoDescripcion = new String[] {""} ;
         T000R5_A131CuentaBancariaEstado = new short[1] ;
         T000R5_A41ClinicaCodigo = new String[] {""} ;
         T000R5_A126BancoCodigo = new String[] {""} ;
         T000R4_A127BancoDescripcion = new String[] {""} ;
         T000R6_A127BancoDescripcion = new String[] {""} ;
         T000R7_A41ClinicaCodigo = new String[] {""} ;
         T000R7_A128CuentaBancariaCodigo = new String[] {""} ;
         T000R3_A128CuentaBancariaCodigo = new String[] {""} ;
         T000R3_A129CuentaBancariaNombre = new String[] {""} ;
         T000R3_A137CuentaBancariaCuenta = new String[] {""} ;
         T000R3_A130CuentaBancariaTipo = new String[] {""} ;
         T000R3_A131CuentaBancariaEstado = new short[1] ;
         T000R3_A41ClinicaCodigo = new String[] {""} ;
         T000R3_A126BancoCodigo = new String[] {""} ;
         sMode35 = "" ;
         T000R8_A41ClinicaCodigo = new String[] {""} ;
         T000R8_A128CuentaBancariaCodigo = new String[] {""} ;
         T000R9_A41ClinicaCodigo = new String[] {""} ;
         T000R9_A128CuentaBancariaCodigo = new String[] {""} ;
         T000R10_A128CuentaBancariaCodigo = new String[] {""} ;
         T000R10_A129CuentaBancariaNombre = new String[] {""} ;
         T000R10_A137CuentaBancariaCuenta = new String[] {""} ;
         T000R10_A130CuentaBancariaTipo = new String[] {""} ;
         T000R10_A131CuentaBancariaEstado = new short[1] ;
         T000R10_A41ClinicaCodigo = new String[] {""} ;
         T000R10_A126BancoCodigo = new String[] {""} ;
         T000R14_A127BancoDescripcion = new String[] {""} ;
         T000R15_A41ClinicaCodigo = new String[] {""} ;
         T000R15_A128CuentaBancariaCodigo = new String[] {""} ;
         T000R15_A282DepositoId = new int[1] ;
         T000R16_A41ClinicaCodigo = new String[] {""} ;
         T000R16_A128CuentaBancariaCodigo = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cuentabancaria__default(),
            new Object[][] {
                new Object[] {
               T000R2_A128CuentaBancariaCodigo, T000R2_A129CuentaBancariaNombre, T000R2_A137CuentaBancariaCuenta, T000R2_A130CuentaBancariaTipo, T000R2_A131CuentaBancariaEstado, T000R2_A41ClinicaCodigo, T000R2_A126BancoCodigo
               }
               , new Object[] {
               T000R3_A128CuentaBancariaCodigo, T000R3_A129CuentaBancariaNombre, T000R3_A137CuentaBancariaCuenta, T000R3_A130CuentaBancariaTipo, T000R3_A131CuentaBancariaEstado, T000R3_A41ClinicaCodigo, T000R3_A126BancoCodigo
               }
               , new Object[] {
               T000R4_A127BancoDescripcion
               }
               , new Object[] {
               T000R5_A128CuentaBancariaCodigo, T000R5_A129CuentaBancariaNombre, T000R5_A137CuentaBancariaCuenta, T000R5_A130CuentaBancariaTipo, T000R5_A127BancoDescripcion, T000R5_A131CuentaBancariaEstado, T000R5_A41ClinicaCodigo, T000R5_A126BancoCodigo
               }
               , new Object[] {
               T000R6_A127BancoDescripcion
               }
               , new Object[] {
               T000R7_A41ClinicaCodigo, T000R7_A128CuentaBancariaCodigo
               }
               , new Object[] {
               T000R8_A41ClinicaCodigo, T000R8_A128CuentaBancariaCodigo
               }
               , new Object[] {
               T000R9_A41ClinicaCodigo, T000R9_A128CuentaBancariaCodigo
               }
               , new Object[] {
               T000R10_A128CuentaBancariaCodigo, T000R10_A129CuentaBancariaNombre, T000R10_A137CuentaBancariaCuenta, T000R10_A130CuentaBancariaTipo, T000R10_A131CuentaBancariaEstado, T000R10_A41ClinicaCodigo, T000R10_A126BancoCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000R14_A127BancoDescripcion
               }
               , new Object[] {
               T000R15_A41ClinicaCodigo, T000R15_A128CuentaBancariaCodigo, T000R15_A282DepositoId
               }
               , new Object[] {
               T000R16_A41ClinicaCodigo, T000R16_A128CuentaBancariaCodigo
               }
            }
         );
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short A131CuentaBancariaEstado ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Z131CuentaBancariaEstado ;
      private short GX_JID ;
      private short RcdFound35 ;
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
      private int edtCuentaBancariaCodigo_Enabled ;
      private int edtCuentaBancariaNombre_Enabled ;
      private int edtCuentaBancariaCuenta_Enabled ;
      private int edtBancoCodigo_Enabled ;
      private int imgprompt_41_126_Visible ;
      private int edtBancoDescripcion_Enabled ;
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
      private int AnyError126 ;
      private int idxLst ;
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
      private String lblTextblockcuentabancariacodigo_Internalname ;
      private String lblTextblockcuentabancariacodigo_Jsonclick ;
      private String edtCuentaBancariaCodigo_Internalname ;
      private String edtCuentaBancariaCodigo_Jsonclick ;
      private String lblTextblockcuentabancarianombre_Internalname ;
      private String lblTextblockcuentabancarianombre_Jsonclick ;
      private String edtCuentaBancariaNombre_Internalname ;
      private String edtCuentaBancariaNombre_Jsonclick ;
      private String lblTextblockcuentabancariacuenta_Internalname ;
      private String lblTextblockcuentabancariacuenta_Jsonclick ;
      private String edtCuentaBancariaCuenta_Internalname ;
      private String edtCuentaBancariaCuenta_Jsonclick ;
      private String lblTextblockcuentabancariatipo_Internalname ;
      private String lblTextblockcuentabancariatipo_Jsonclick ;
      private String cmbCuentaBancariaTipo_Internalname ;
      private String cmbCuentaBancariaTipo_Jsonclick ;
      private String lblTextblockbancocodigo_Internalname ;
      private String lblTextblockbancocodigo_Jsonclick ;
      private String edtBancoCodigo_Internalname ;
      private String edtBancoCodigo_Jsonclick ;
      private String imgprompt_41_126_Internalname ;
      private String imgprompt_41_126_Link ;
      private String lblTextblockbancodescripcion_Internalname ;
      private String lblTextblockbancodescripcion_Jsonclick ;
      private String edtBancoDescripcion_Internalname ;
      private String edtBancoDescripcion_Jsonclick ;
      private String lblTextblockcuentabancariaestado_Internalname ;
      private String lblTextblockcuentabancariaestado_Jsonclick ;
      private String cmbCuentaBancariaEstado_Internalname ;
      private String cmbCuentaBancariaEstado_Jsonclick ;
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
      private String sMode35 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char4 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A41ClinicaCodigo ;
      private String A126BancoCodigo ;
      private String A130CuentaBancariaTipo ;
      private String A128CuentaBancariaCodigo ;
      private String A129CuentaBancariaNombre ;
      private String A137CuentaBancariaCuenta ;
      private String A127BancoDescripcion ;
      private String Z41ClinicaCodigo ;
      private String Z128CuentaBancariaCodigo ;
      private String Z129CuentaBancariaNombre ;
      private String Z137CuentaBancariaCuenta ;
      private String Z130CuentaBancariaTipo ;
      private String Z126BancoCodigo ;
      private String AV8ClinicaCodigo ;
      private String Z127BancoDescripcion ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbCuentaBancariaTipo ;
      private GXCombobox cmbCuentaBancariaEstado ;
      private IDataStoreProvider pr_default ;
      private String[] T000R5_A128CuentaBancariaCodigo ;
      private String[] T000R5_A129CuentaBancariaNombre ;
      private String[] T000R5_A137CuentaBancariaCuenta ;
      private String[] T000R5_A130CuentaBancariaTipo ;
      private String[] T000R5_A127BancoDescripcion ;
      private short[] T000R5_A131CuentaBancariaEstado ;
      private String[] T000R5_A41ClinicaCodigo ;
      private String[] T000R5_A126BancoCodigo ;
      private String[] T000R4_A127BancoDescripcion ;
      private String[] T000R6_A127BancoDescripcion ;
      private String[] T000R7_A41ClinicaCodigo ;
      private String[] T000R7_A128CuentaBancariaCodigo ;
      private String[] T000R3_A128CuentaBancariaCodigo ;
      private String[] T000R3_A129CuentaBancariaNombre ;
      private String[] T000R3_A137CuentaBancariaCuenta ;
      private String[] T000R3_A130CuentaBancariaTipo ;
      private short[] T000R3_A131CuentaBancariaEstado ;
      private String[] T000R3_A41ClinicaCodigo ;
      private String[] T000R3_A126BancoCodigo ;
      private String[] T000R8_A41ClinicaCodigo ;
      private String[] T000R8_A128CuentaBancariaCodigo ;
      private String[] T000R9_A41ClinicaCodigo ;
      private String[] T000R9_A128CuentaBancariaCodigo ;
      private String[] T000R10_A128CuentaBancariaCodigo ;
      private String[] T000R10_A129CuentaBancariaNombre ;
      private String[] T000R10_A137CuentaBancariaCuenta ;
      private String[] T000R10_A130CuentaBancariaTipo ;
      private short[] T000R10_A131CuentaBancariaEstado ;
      private String[] T000R10_A41ClinicaCodigo ;
      private String[] T000R10_A126BancoCodigo ;
      private String[] T000R14_A127BancoDescripcion ;
      private String[] T000R15_A41ClinicaCodigo ;
      private String[] T000R15_A128CuentaBancariaCodigo ;
      private int[] T000R15_A282DepositoId ;
      private String[] T000R16_A41ClinicaCodigo ;
      private String[] T000R16_A128CuentaBancariaCodigo ;
      private String[] T000R2_A128CuentaBancariaCodigo ;
      private String[] T000R2_A129CuentaBancariaNombre ;
      private String[] T000R2_A137CuentaBancariaCuenta ;
      private String[] T000R2_A130CuentaBancariaTipo ;
      private short[] T000R2_A131CuentaBancariaEstado ;
      private String[] T000R2_A41ClinicaCodigo ;
      private String[] T000R2_A126BancoCodigo ;
      private GXWebForm Form ;
      private SdtParametros AV7Parametros ;
      private SdtParametros GXt_SdtParametros3 ;
   }

   public class cuentabancaria__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000R2 ;
          prmT000R2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000R5 ;
          prmT000R5 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000R4 ;
          prmT000R4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BancoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000R6 ;
          prmT000R6 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BancoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000R7 ;
          prmT000R7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000R3 ;
          prmT000R3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000R8 ;
          prmT000R8 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000R9 ;
          prmT000R9 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000R10 ;
          prmT000R10 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000R11 ;
          prmT000R11 = new Object[] {
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@CuentaBancariaCuenta",SqlDbType.VarChar,70,0} ,
          new Object[] {"@CuentaBancariaTipo",SqlDbType.VarChar,1,0} ,
          new Object[] {"@CuentaBancariaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BancoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000R12 ;
          prmT000R12 = new Object[] {
          new Object[] {"@CuentaBancariaNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@CuentaBancariaCuenta",SqlDbType.VarChar,70,0} ,
          new Object[] {"@CuentaBancariaTipo",SqlDbType.VarChar,1,0} ,
          new Object[] {"@CuentaBancariaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@BancoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000R13 ;
          prmT000R13 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000R15 ;
          prmT000R15 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CuentaBancariaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000R16 ;
          prmT000R16 = new Object[] {
          } ;
          Object[] prmT000R14 ;
          prmT000R14 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BancoCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000R2", "SELECT [CuentaBancariaCodigo], [CuentaBancariaNombre], [CuentaBancariaCuenta], [CuentaBancariaTipo], [CuentaBancariaEstado], [ClinicaCodigo], [BancoCodigo] FROM [CuentaBancaria] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CuentaBancariaCodigo] = @CuentaBancariaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000R2,1,0,true,false )
             ,new CursorDef("T000R3", "SELECT [CuentaBancariaCodigo], [CuentaBancariaNombre], [CuentaBancariaCuenta], [CuentaBancariaTipo], [CuentaBancariaEstado], [ClinicaCodigo], [BancoCodigo] FROM [CuentaBancaria] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CuentaBancariaCodigo] = @CuentaBancariaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000R3,1,0,true,false )
             ,new CursorDef("T000R4", "SELECT [BancoDescripcion] FROM [Banco] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [BancoCodigo] = @BancoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000R4,1,0,true,false )
             ,new CursorDef("T000R5", "SELECT TM1.[CuentaBancariaCodigo], TM1.[CuentaBancariaNombre], TM1.[CuentaBancariaCuenta], TM1.[CuentaBancariaTipo], T2.[BancoDescripcion], TM1.[CuentaBancariaEstado], TM1.[ClinicaCodigo], TM1.[BancoCodigo] FROM ([CuentaBancaria] TM1 WITH (NOLOCK) INNER JOIN [Banco] T2 WITH (NOLOCK) ON T2.[ClinicaCodigo] = TM1.[ClinicaCodigo] AND T2.[BancoCodigo] = TM1.[BancoCodigo]) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[CuentaBancariaCodigo] = @CuentaBancariaCodigo ORDER BY TM1.[ClinicaCodigo], TM1.[CuentaBancariaCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000R5,100,0,true,false )
             ,new CursorDef("T000R6", "SELECT [BancoDescripcion] FROM [Banco] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [BancoCodigo] = @BancoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000R6,1,0,true,false )
             ,new CursorDef("T000R7", "SELECT [ClinicaCodigo], [CuentaBancariaCodigo] FROM [CuentaBancaria] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CuentaBancariaCodigo] = @CuentaBancariaCodigo  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000R7,1,0,true,false )
             ,new CursorDef("T000R8", "SELECT TOP 1 [ClinicaCodigo], [CuentaBancariaCodigo] FROM [CuentaBancaria] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [CuentaBancariaCodigo] > @CuentaBancariaCodigo) ORDER BY [ClinicaCodigo], [CuentaBancariaCodigo]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000R8,1,0,true,true )
             ,new CursorDef("T000R9", "SELECT TOP 1 [ClinicaCodigo], [CuentaBancariaCodigo] FROM [CuentaBancaria] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [CuentaBancariaCodigo] < @CuentaBancariaCodigo) ORDER BY [ClinicaCodigo] DESC, [CuentaBancariaCodigo] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000R9,1,0,true,true )
             ,new CursorDef("T000R10", "SELECT [CuentaBancariaCodigo], [CuentaBancariaNombre], [CuentaBancariaCuenta], [CuentaBancariaTipo], [CuentaBancariaEstado], [ClinicaCodigo], [BancoCodigo] FROM [CuentaBancaria] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CuentaBancariaCodigo] = @CuentaBancariaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000R10,1,0,true,false )
             ,new CursorDef("T000R11", "INSERT INTO [CuentaBancaria] ([CuentaBancariaCodigo], [CuentaBancariaNombre], [CuentaBancariaCuenta], [CuentaBancariaTipo], [CuentaBancariaEstado], [ClinicaCodigo], [BancoCodigo]) VALUES (@CuentaBancariaCodigo, @CuentaBancariaNombre, @CuentaBancariaCuenta, @CuentaBancariaTipo, @CuentaBancariaEstado, @ClinicaCodigo, @BancoCodigo)", GxErrorMask.GX_NOMASK,prmT000R11)
             ,new CursorDef("T000R12", "UPDATE [CuentaBancaria] SET [CuentaBancariaNombre]=@CuentaBancariaNombre, [CuentaBancariaCuenta]=@CuentaBancariaCuenta, [CuentaBancariaTipo]=@CuentaBancariaTipo, [CuentaBancariaEstado]=@CuentaBancariaEstado, [BancoCodigo]=@BancoCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CuentaBancariaCodigo] = @CuentaBancariaCodigo", GxErrorMask.GX_NOMASK,prmT000R12)
             ,new CursorDef("T000R13", "DELETE FROM [CuentaBancaria]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CuentaBancariaCodigo] = @CuentaBancariaCodigo", GxErrorMask.GX_NOMASK,prmT000R13)
             ,new CursorDef("T000R14", "SELECT [BancoDescripcion] FROM [Banco] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [BancoCodigo] = @BancoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000R14,1,0,true,false )
             ,new CursorDef("T000R15", "SELECT TOP 1 [ClinicaCodigo], [CuentaBancariaCodigo], [DepositoId] FROM [DepositoBancario] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CuentaBancariaCodigo] = @CuentaBancariaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000R15,1,0,true,true )
             ,new CursorDef("T000R16", "SELECT [ClinicaCodigo], [CuentaBancariaCodigo] FROM [CuentaBancaria] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [CuentaBancariaCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000R16,100,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
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
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
