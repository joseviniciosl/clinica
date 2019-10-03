/*
               File: CuentaContable
        Description: Catálogo de Cuentas Contables
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:6:13.47
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
   public class cuentacontable : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         cmbCtaContableNivel.Name = "CTACONTABLENIVEL" ;
         cmbCtaContableNivel.WebTags = "" ;
         cmbCtaContableNivel.addItem("1", "Nivel 1", 0);
         cmbCtaContableNivel.addItem("2", "Nivel 2", 0);
         cmbCtaContableNivel.addItem("3", "Nivel 3", 0);
         cmbCtaContableNivel.addItem("4", "Nivel 4", 0);
         cmbCtaContableNivel.addItem("5", "Nivel 5", 0);
         if ( ( cmbCtaContableNivel.ItemCount > 0 ) && (0==A195CtaContableNivel) )
         {
            A195CtaContableNivel = (short)(NumberUtil.Val( cmbCtaContableNivel.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195CtaContableNivel", StringUtil.Str( (decimal)(A195CtaContableNivel), 1, 0));
         }
         cmbCtaContableGrupo.Name = "CTACONTABLEGRUPO" ;
         cmbCtaContableGrupo.WebTags = "" ;
         cmbCtaContableGrupo.addItem("Activo", "Activo", 0);
         cmbCtaContableGrupo.addItem("Pasivo", "Pasivo", 0);
         cmbCtaContableGrupo.addItem("Capital", "Capital", 0);
         cmbCtaContableGrupo.addItem("Ingresos", "Ingresos", 0);
         cmbCtaContableGrupo.addItem("Costos", "Costos", 0);
         cmbCtaContableGrupo.addItem("Gastos", "Gastos", 0);
         cmbCtaContableGrupo.addItem("PF", "Productos Financieros", 0);
         if ( ( cmbCtaContableGrupo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A196CtaContableGrupo)) )
         {
            A196CtaContableGrupo = cmbCtaContableGrupo.getItemValue(1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A196CtaContableGrupo", A196CtaContableGrupo);
         }
         cmbCtaContableManual.Name = "CTACONTABLEMANUAL" ;
         cmbCtaContableManual.WebTags = "" ;
         cmbCtaContableManual.addItem("0", "No", 0);
         cmbCtaContableManual.addItem("1", "Si", 0);
         if ( ( cmbCtaContableManual.ItemCount > 0 ) && (0==A197CtaContableManual) )
         {
            A197CtaContableManual = (short)(NumberUtil.Val( cmbCtaContableManual.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A197CtaContableManual", StringUtil.Str( (decimal)(A197CtaContableManual), 1, 0));
         }
         cmbCtaContableEstado.Name = "CTACONTABLEESTADO" ;
         cmbCtaContableEstado.WebTags = "" ;
         cmbCtaContableEstado.addItem("0", "De baja", 0);
         cmbCtaContableEstado.addItem("1", "Activo", 0);
         if ( ( cmbCtaContableEstado.ItemCount > 0 ) && (0==A198CtaContableEstado) )
         {
            A198CtaContableEstado = (short)(NumberUtil.Val( cmbCtaContableEstado.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A198CtaContableEstado", StringUtil.Str( (decimal)(A198CtaContableEstado), 1, 0));
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Catálogo de Cuentas Contables", 0) ;
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

      public cuentacontable( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public cuentacontable( IGxContext context )
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
         cmbCtaContableNivel = new GXCombobox();
         cmbCtaContableGrupo = new GXCombobox();
         cmbCtaContableManual = new GXCombobox();
         cmbCtaContableEstado = new GXCombobox();
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
            wb_table1_2_1350( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1350e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1350( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1350( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1350e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Catálogo de Cuentas Contables"+"</legend>") ;
            wb_table3_27_1350( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_1350e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1350e( true) ;
         }
         else
         {
            wb_table1_2_1350e( false) ;
         }
      }

      protected void wb_table3_27_1350( bool wbgen )
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
            wb_table4_33_1350( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_1350e( bool wbgen )
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_CuentaContable.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_CuentaContable.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_CuentaContable.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_1350e( true) ;
         }
         else
         {
            wb_table3_27_1350e( false) ;
         }
      }

      protected void wb_table4_33_1350( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", lblTextblockclinicacodigo_Visible, 1, 0, "HLP_CuentaContable.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", edtClinicaCodigo_Visible, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_CuentaContable.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_Internalname, "prompt.gif", imgprompt_41_Link, "", "", "Fantastic", imgprompt_41_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_CuentaContable.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockctacontablecodigo_Internalname, "Contable", "", "", lblTextblockctacontablecodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CuentaContable.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCtaContableCodigo_Internalname, StringUtil.RTrim( A193CtaContableCodigo), StringUtil.RTrim( context.localUtil.Format( A193CtaContableCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtCtaContableCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtCtaContableCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_CuentaContable.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockctacontablenombre_Internalname, "Nombre", "", "", lblTextblockctacontablenombre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CuentaContable.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194CtaContableNombre", A194CtaContableNombre);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCtaContableNombre_Internalname, StringUtil.RTrim( A194CtaContableNombre), StringUtil.RTrim( context.localUtil.Format( A194CtaContableNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", "", "", "", edtCtaContableNombre_Jsonclick, 0, ClassString, StyleString, "", 1, edtCtaContableNombre_Enabled, 0, 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, true, "left", "HLP_CuentaContable.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockctacontablenivel_Internalname, "Nivel", "", "", lblTextblockctacontablenivel_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CuentaContable.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195CtaContableNivel", StringUtil.Str( (decimal)(A195CtaContableNivel), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbCtaContableNivel, cmbCtaContableNivel_Internalname, StringUtil.Str( (decimal)(A195CtaContableNivel), 1, 0), 1, cmbCtaContableNivel_Jsonclick, 0, "", "int", "", 1, cmbCtaContableNivel.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "", true, "HLP_CuentaContable.htm");
            cmbCtaContableNivel.CurrentValue = StringUtil.Str( (decimal)(A195CtaContableNivel), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCtaContableNivel_Internalname, "Values", (String)(cmbCtaContableNivel.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockctacontablegrupo_Internalname, "Grupo", "", "", lblTextblockctacontablegrupo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CuentaContable.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A196CtaContableGrupo", A196CtaContableGrupo);
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbCtaContableGrupo, cmbCtaContableGrupo_Internalname, A196CtaContableGrupo, 1, cmbCtaContableGrupo_Jsonclick, 0, "", "svchar", "", 1, cmbCtaContableGrupo.Enabled, 0, 0, 15, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", "", true, "HLP_CuentaContable.htm");
            cmbCtaContableGrupo.CurrentValue = A196CtaContableGrupo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCtaContableGrupo_Internalname, "Values", (String)(cmbCtaContableGrupo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockctacontablemanual_Internalname, "Manual", "", "", lblTextblockctacontablemanual_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CuentaContable.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A197CtaContableManual", StringUtil.Str( (decimal)(A197CtaContableManual), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbCtaContableManual, cmbCtaContableManual_Internalname, StringUtil.Str( (decimal)(A197CtaContableManual), 1, 0), 1, cmbCtaContableManual_Jsonclick, 0, "", "int", "", 1, cmbCtaContableManual.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", "", true, "HLP_CuentaContable.htm");
            cmbCtaContableManual.CurrentValue = StringUtil.Str( (decimal)(A197CtaContableManual), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCtaContableManual_Internalname, "Values", (String)(cmbCtaContableManual.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockctacontableestado_Internalname, "Estado", "", "", lblTextblockctacontableestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CuentaContable.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A198CtaContableEstado", StringUtil.Str( (decimal)(A198CtaContableEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbCtaContableEstado, cmbCtaContableEstado_Internalname, StringUtil.Str( (decimal)(A198CtaContableEstado), 1, 0), 1, cmbCtaContableEstado_Jsonclick, 0, "", "int", "", 1, cmbCtaContableEstado.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", "", true, "HLP_CuentaContable.htm");
            cmbCtaContableEstado.CurrentValue = StringUtil.Str( (decimal)(A198CtaContableEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCtaContableEstado_Internalname, "Values", (String)(cmbCtaContableEstado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_1350e( true) ;
         }
         else
         {
            wb_table4_33_1350e( false) ;
         }
      }

      protected void wb_table2_5_1350( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaContable.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaContable.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaContable.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaContable.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaContable.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaContable.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaContable.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaContable.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01e0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CTACONTABLECODIGO"+"'), id:'"+"CTACONTABLECODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_CuentaContable.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01e0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CTACONTABLECODIGO"+"'), id:'"+"CTACONTABLECODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_CuentaContable.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaContable.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaContable.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaContable.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaContable.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaContable.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CuentaContable.htm");
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
            wb_table2_5_1350e( true) ;
         }
         else
         {
            wb_table2_5_1350e( false) ;
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
         /* Execute user event: E11132 */
         E11132 ();
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
               A193CtaContableCodigo = cgiGet( edtCtaContableCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
               A194CtaContableNombre = cgiGet( edtCtaContableNombre_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194CtaContableNombre", A194CtaContableNombre);
               cmbCtaContableNivel.CurrentValue = cgiGet( cmbCtaContableNivel_Internalname) ;
               A195CtaContableNivel = (short)(NumberUtil.Val( cgiGet( cmbCtaContableNivel_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195CtaContableNivel", StringUtil.Str( (decimal)(A195CtaContableNivel), 1, 0));
               cmbCtaContableGrupo.CurrentValue = cgiGet( cmbCtaContableGrupo_Internalname) ;
               A196CtaContableGrupo = cgiGet( cmbCtaContableGrupo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A196CtaContableGrupo", A196CtaContableGrupo);
               cmbCtaContableManual.CurrentValue = cgiGet( cmbCtaContableManual_Internalname) ;
               A197CtaContableManual = (short)(NumberUtil.Val( cgiGet( cmbCtaContableManual_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A197CtaContableManual", StringUtil.Str( (decimal)(A197CtaContableManual), 1, 0));
               cmbCtaContableEstado.CurrentValue = cgiGet( cmbCtaContableEstado_Internalname) ;
               A198CtaContableEstado = (short)(NumberUtil.Val( cgiGet( cmbCtaContableEstado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A198CtaContableEstado", StringUtil.Str( (decimal)(A198CtaContableEstado), 1, 0));
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z193CtaContableCodigo = cgiGet( "Z193CtaContableCodigo") ;
               Z194CtaContableNombre = cgiGet( "Z194CtaContableNombre") ;
               Z195CtaContableNivel = (short)(context.localUtil.CToN( cgiGet( "Z195CtaContableNivel"), ".", ",")) ;
               Z196CtaContableGrupo = cgiGet( "Z196CtaContableGrupo") ;
               Z197CtaContableManual = (short)(context.localUtil.CToN( cgiGet( "Z197CtaContableManual"), ".", ",")) ;
               Z198CtaContableEstado = (short)(context.localUtil.CToN( cgiGet( "Z198CtaContableEstado"), ".", ",")) ;
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
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E11132 */
                           E11132 ();
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
               InitAll1350( ) ;
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
         DisableAttributes1350( ) ;
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

      protected void ResetCaption130( )
      {
      }

      protected void E11132( )
      {
         /* Start Routine */
         GXt_SdtParametros3 = AV8Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros3) ;
         AV8Parametros = GXt_SdtParametros3 ;
         AV7ClinicaCodigo = AV8Parametros.gxTpr_Pclinicacodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ClinicaCodigo", AV7ClinicaCodigo);
      }

      protected void ZM1350( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z194CtaContableNombre = T00133_A194CtaContableNombre[0] ;
               Z195CtaContableNivel = T00133_A195CtaContableNivel[0] ;
               Z196CtaContableGrupo = T00133_A196CtaContableGrupo[0] ;
               Z197CtaContableManual = T00133_A197CtaContableManual[0] ;
               Z198CtaContableEstado = T00133_A198CtaContableEstado[0] ;
            }
            else
            {
               Z194CtaContableNombre = A194CtaContableNombre ;
               Z195CtaContableNivel = A195CtaContableNivel ;
               Z196CtaContableGrupo = A196CtaContableGrupo ;
               Z197CtaContableManual = A197CtaContableManual ;
               Z198CtaContableEstado = A198CtaContableEstado ;
            }
         }
         if ( GX_JID == -4 )
         {
            Z193CtaContableCodigo = A193CtaContableCodigo ;
            Z194CtaContableNombre = A194CtaContableNombre ;
            Z195CtaContableNivel = A195CtaContableNivel ;
            Z196CtaContableGrupo = A196CtaContableGrupo ;
            Z197CtaContableManual = A197CtaContableManual ;
            Z198CtaContableEstado = A198CtaContableEstado ;
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
      }

      protected void Load1350( )
      {
         /* Using cursor T00135 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound50 = 1 ;
            A194CtaContableNombre = T00135_A194CtaContableNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194CtaContableNombre", A194CtaContableNombre);
            A195CtaContableNivel = T00135_A195CtaContableNivel[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195CtaContableNivel", StringUtil.Str( (decimal)(A195CtaContableNivel), 1, 0));
            A196CtaContableGrupo = T00135_A196CtaContableGrupo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A196CtaContableGrupo", A196CtaContableGrupo);
            A197CtaContableManual = T00135_A197CtaContableManual[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A197CtaContableManual", StringUtil.Str( (decimal)(A197CtaContableManual), 1, 0));
            A198CtaContableEstado = T00135_A198CtaContableEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A198CtaContableEstado", StringUtil.Str( (decimal)(A198CtaContableEstado), 1, 0));
            ZM1350( -4) ;
         }
         pr_default.close(3);
         OnLoadActions1350( ) ;
      }

      protected void OnLoadActions1350( )
      {
      }

      protected void CheckExtendedTable1350( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T00134 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(2) == 101) )
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
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors1350( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_5( String A41ClinicaCodigo )
      {
         /* Using cursor T00136 */
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

      protected void GetKey1350( )
      {
         /* Using cursor T00137 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound50 = 1 ;
         }
         else
         {
            RcdFound50 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00133 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1350( 4) ;
            RcdFound50 = 1 ;
            A193CtaContableCodigo = T00133_A193CtaContableCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
            A194CtaContableNombre = T00133_A194CtaContableNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194CtaContableNombre", A194CtaContableNombre);
            A195CtaContableNivel = T00133_A195CtaContableNivel[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195CtaContableNivel", StringUtil.Str( (decimal)(A195CtaContableNivel), 1, 0));
            A196CtaContableGrupo = T00133_A196CtaContableGrupo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A196CtaContableGrupo", A196CtaContableGrupo);
            A197CtaContableManual = T00133_A197CtaContableManual[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A197CtaContableManual", StringUtil.Str( (decimal)(A197CtaContableManual), 1, 0));
            A198CtaContableEstado = T00133_A198CtaContableEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A198CtaContableEstado", StringUtil.Str( (decimal)(A198CtaContableEstado), 1, 0));
            A41ClinicaCodigo = T00133_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z193CtaContableCodigo = A193CtaContableCodigo ;
            sMode50 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1350( ) ;
            Gx_mode = sMode50 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound50 = 0 ;
            InitializeNonKey1350( ) ;
            sMode50 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode50 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1350( ) ;
         if ( RcdFound50 == 0 )
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
         RcdFound50 = 0 ;
         /* Using cursor T00138 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T00138_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T00138_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T00138_A193CtaContableCodigo[0], A193CtaContableCodigo) < 0 ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T00138_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T00138_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T00138_A193CtaContableCodigo[0], A193CtaContableCodigo) > 0 ) ) )
            {
               A41ClinicaCodigo = T00138_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A193CtaContableCodigo = T00138_A193CtaContableCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
               RcdFound50 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound50 = 0 ;
         /* Using cursor T00139 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T00139_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T00139_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T00139_A193CtaContableCodigo[0], A193CtaContableCodigo) > 0 ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T00139_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T00139_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T00139_A193CtaContableCodigo[0], A193CtaContableCodigo) < 0 ) ) )
            {
               A41ClinicaCodigo = T00139_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A193CtaContableCodigo = T00139_A193CtaContableCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
               RcdFound50 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1350( ) ;
         if ( RcdFound50 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A193CtaContableCodigo, Z193CtaContableCodigo) != 0 ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
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
               Update1350( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A193CtaContableCodigo, Z193CtaContableCodigo) != 0 ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert1350( ) ;
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
                  Insert1350( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A193CtaContableCodigo, Z193CtaContableCodigo) != 0 ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
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
         if ( RcdFound50 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtCtaContableNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1350( ) ;
         if ( RcdFound50 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCtaContableNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1350( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound50 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCtaContableNombre_Internalname ;
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
         if ( RcdFound50 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCtaContableNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1350( ) ;
         if ( RcdFound50 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound50 != 0 )
            {
               ScanNext1350( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCtaContableNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1350( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1350( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001310 */
            pr_default.execute(8, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CuentaContable"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(8) == 101) || ( StringUtil.StrCmp(Z194CtaContableNombre, T001310_A194CtaContableNombre[0]) != 0 ) || ( Z195CtaContableNivel != T001310_A195CtaContableNivel[0] ) || ( StringUtil.StrCmp(Z196CtaContableGrupo, T001310_A196CtaContableGrupo[0]) != 0 ) || ( Z197CtaContableManual != T001310_A197CtaContableManual[0] ) || ( Z198CtaContableEstado != T001310_A198CtaContableEstado[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"CuentaContable"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1350( )
      {
         BeforeValidate1350( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1350( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1350( 0) ;
            CheckOptimisticConcurrency1350( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1350( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1350( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001311 */
                     pr_default.execute(9, new Object[] {A193CtaContableCodigo, A194CtaContableNombre, A195CtaContableNivel, A196CtaContableGrupo, A197CtaContableManual, A198CtaContableEstado, A41ClinicaCodigo});
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
                           ResetCaption130( ) ;
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
               Load1350( ) ;
            }
            EndLevel1350( ) ;
         }
         CloseExtendedTableCursors1350( ) ;
      }

      protected void Update1350( )
      {
         BeforeValidate1350( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1350( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1350( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1350( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1350( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001312 */
                     pr_default.execute(10, new Object[] {A194CtaContableNombre, A195CtaContableNivel, A196CtaContableGrupo, A197CtaContableManual, A198CtaContableEstado, A41ClinicaCodigo, A193CtaContableCodigo});
                     pr_default.close(10);
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CuentaContable"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1350( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                           ResetCaption130( ) ;
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
            EndLevel1350( ) ;
         }
         CloseExtendedTableCursors1350( ) ;
      }

      protected void DeferredUpdate1350( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1350( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1350( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1350( ) ;
            AfterConfirm1350( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1350( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001313 */
                  pr_default.execute(11, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
                  pr_default.close(11);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound50 == 0 )
                        {
                           InitAll1350( ) ;
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
                        ResetCaption130( ) ;
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
         sMode50 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1350( ) ;
         Gx_mode = sMode50 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1350( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T001314 */
            pr_default.execute(12, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Movimiento Contable Reversado"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(12);
            /* Using cursor T001315 */
            pr_default.execute(13, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Cierre mensual de contabilidad"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(13);
            /* Using cursor T001316 */
            pr_default.execute(14, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Movimiento mayorizado de partidas contables"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(14);
            /* Using cursor T001317 */
            pr_default.execute(15, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Detalle de partida contable"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(15);
         }
      }

      protected void EndLevel1350( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1350( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(6);
            context.CommitDataStores("CuentaContable");
            if ( AnyError == 0 )
            {
               ConfirmValues130( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(6);
            context.RollbackDataStores("CuentaContable");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1350( )
      {
         /* Using cursor T001318 */
         pr_default.execute(16);
         RcdFound50 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound50 = 1 ;
            A41ClinicaCodigo = T001318_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A193CtaContableCodigo = T001318_A193CtaContableCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1350( )
      {
         pr_default.readNext(16);
         RcdFound50 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound50 = 1 ;
            A41ClinicaCodigo = T001318_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A193CtaContableCodigo = T001318_A193CtaContableCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
         }
      }

      protected void ScanEnd1350( )
      {
      }

      protected void AfterConfirm1350( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1350( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1350( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1350( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1350( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1350( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1350( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtCtaContableCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCtaContableCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCtaContableCodigo_Enabled), 5, 0)));
         edtCtaContableNombre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCtaContableNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCtaContableNombre_Enabled), 5, 0)));
         cmbCtaContableNivel.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCtaContableNivel_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbCtaContableNivel.Enabled), 5, 0)));
         cmbCtaContableGrupo.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCtaContableGrupo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbCtaContableGrupo.Enabled), 5, 0)));
         cmbCtaContableManual.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCtaContableManual_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbCtaContableManual.Enabled), 5, 0)));
         cmbCtaContableEstado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCtaContableEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbCtaContableEstado.Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues130( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("cuentacontable.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z193CtaContableCodigo", StringUtil.RTrim( Z193CtaContableCodigo));
         GxWebStd.gx_hidden_field( context, "Z194CtaContableNombre", StringUtil.RTrim( Z194CtaContableNombre));
         GxWebStd.gx_hidden_field( context, "Z195CtaContableNivel", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z195CtaContableNivel), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z196CtaContableGrupo", StringUtil.RTrim( Z196CtaContableGrupo));
         GxWebStd.gx_hidden_field( context, "Z197CtaContableManual", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z197CtaContableManual), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z198CtaContableEstado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z198CtaContableEstado), 1, 0, ".", "")));
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
         return "CuentaContable" ;
      }

      public override String GetPgmdesc( )
      {
         return "Catálogo de Cuentas Contables" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("cuentacontable.aspx")  ;
      }

      protected void InitializeNonKey1350( )
      {
         A194CtaContableNombre = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194CtaContableNombre", A194CtaContableNombre);
         A195CtaContableNivel = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195CtaContableNivel", StringUtil.Str( (decimal)(A195CtaContableNivel), 1, 0));
         A196CtaContableGrupo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A196CtaContableGrupo", A196CtaContableGrupo);
         A197CtaContableManual = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A197CtaContableManual", StringUtil.Str( (decimal)(A197CtaContableManual), 1, 0));
         A198CtaContableEstado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A198CtaContableEstado", StringUtil.Str( (decimal)(A198CtaContableEstado), 1, 0));
      }

      protected void InitAll1350( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A193CtaContableCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
         InitializeNonKey1350( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?156156");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("cuentacontable.js", "?156156");
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
         lblTextblockctacontablecodigo_Internalname = "TEXTBLOCKCTACONTABLECODIGO" ;
         edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO" ;
         lblTextblockctacontablenombre_Internalname = "TEXTBLOCKCTACONTABLENOMBRE" ;
         edtCtaContableNombre_Internalname = "CTACONTABLENOMBRE" ;
         lblTextblockctacontablenivel_Internalname = "TEXTBLOCKCTACONTABLENIVEL" ;
         cmbCtaContableNivel_Internalname = "CTACONTABLENIVEL" ;
         lblTextblockctacontablegrupo_Internalname = "TEXTBLOCKCTACONTABLEGRUPO" ;
         cmbCtaContableGrupo_Internalname = "CTACONTABLEGRUPO" ;
         lblTextblockctacontablemanual_Internalname = "TEXTBLOCKCTACONTABLEMANUAL" ;
         cmbCtaContableManual_Internalname = "CTACONTABLEMANUAL" ;
         lblTextblockctacontableestado_Internalname = "TEXTBLOCKCTACONTABLEESTADO" ;
         cmbCtaContableEstado_Internalname = "CTACONTABLEESTADO" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_Internalname = "PROMPT_41" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Catálogo de Cuentas Contables" ;
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
         cmbCtaContableEstado_Jsonclick = "" ;
         cmbCtaContableEstado.Enabled = 1 ;
         cmbCtaContableManual_Jsonclick = "" ;
         cmbCtaContableManual.Enabled = 1 ;
         cmbCtaContableGrupo_Jsonclick = "" ;
         cmbCtaContableGrupo.Enabled = 1 ;
         cmbCtaContableNivel_Jsonclick = "" ;
         cmbCtaContableNivel.Enabled = 1 ;
         edtCtaContableNombre_Jsonclick = "" ;
         edtCtaContableNombre_Enabled = 1 ;
         edtCtaContableCodigo_Jsonclick = "" ;
         edtCtaContableCodigo_Enabled = 1 ;
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

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         /* Using cursor T001319 */
         pr_default.execute(17, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(17) == 101) )
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
         pr_default.close(17);
         GX_FocusControl = edtCtaContableNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Clinicacodigo( String GX_Parm1 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         /* Using cursor T001319 */
         pr_default.execute(17, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(17) == 101) )
         {
            AnyError41 = 1 ;
            GX_msglist.addItem("No existe 'Clínica Médica'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( AnyError41 == 0 )
         {
         }
         pr_default.close(17);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Ctacontablecodigo( String GX_Parm1 ,
                                           String GX_Parm2 ,
                                           String GX_Parm3 ,
                                           String GX_Parm4 ,
                                           GXCombobox cmbGX_Parm5 ,
                                           GXCombobox cmbGX_Parm6 ,
                                           GXCombobox cmbGX_Parm7 ,
                                           GXCombobox cmbGX_Parm8 )
      {
         AV7ClinicaCodigo = GX_Parm1 ;
         A41ClinicaCodigo = GX_Parm2 ;
         A193CtaContableCodigo = GX_Parm3 ;
         A194CtaContableNombre = GX_Parm4 ;
         cmbCtaContableNivel = cmbGX_Parm5 ;
         A195CtaContableNivel = (short)(NumberUtil.Val( cmbCtaContableNivel.CurrentValue, ".")) ;
         cmbCtaContableNivel.CurrentValue = StringUtil.Str( (decimal)(A195CtaContableNivel), 1, 0) ;
         cmbCtaContableGrupo = cmbGX_Parm6 ;
         A196CtaContableGrupo = cmbCtaContableGrupo.CurrentValue ;
         cmbCtaContableGrupo.CurrentValue = A196CtaContableGrupo ;
         cmbCtaContableManual = cmbGX_Parm7 ;
         A197CtaContableManual = (short)(NumberUtil.Val( cmbCtaContableManual.CurrentValue, ".")) ;
         cmbCtaContableManual.CurrentValue = StringUtil.Str( (decimal)(A197CtaContableManual), 1, 0) ;
         cmbCtaContableEstado = cmbGX_Parm8 ;
         A198CtaContableEstado = (short)(NumberUtil.Val( cmbCtaContableEstado.CurrentValue, ".")) ;
         cmbCtaContableEstado.CurrentValue = StringUtil.Str( (decimal)(A198CtaContableEstado), 1, 0) ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A194CtaContableNombre)));
         cmbCtaContableNivel.CurrentValue = StringUtil.Str( (decimal)(A195CtaContableNivel), 1, 0) ;
         isValidOutput.Add((Object)(cmbCtaContableNivel));
         cmbCtaContableGrupo.CurrentValue = A196CtaContableGrupo ;
         isValidOutput.Add((Object)(cmbCtaContableGrupo));
         cmbCtaContableManual.CurrentValue = StringUtil.Str( (decimal)(A197CtaContableManual), 1, 0) ;
         isValidOutput.Add((Object)(cmbCtaContableManual));
         cmbCtaContableEstado.CurrentValue = StringUtil.Str( (decimal)(A198CtaContableEstado), 1, 0) ;
         isValidOutput.Add((Object)(cmbCtaContableEstado));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z193CtaContableCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z194CtaContableNombre)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z195CtaContableNivel), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z196CtaContableGrupo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z197CtaContableManual), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z198CtaContableEstado), 1, 0, ".", ""))));
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
         pr_default.close(16);
         pr_default.close(7);
         pr_default.close(6);
         pr_default.close(17);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
         GXKey = "" ;
         A196CtaContableGrupo = "" ;
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
         lblTextblockctacontablecodigo_Jsonclick = "" ;
         A193CtaContableCodigo = "" ;
         lblTextblockctacontablenombre_Jsonclick = "" ;
         A194CtaContableNombre = "" ;
         lblTextblockctacontablenivel_Jsonclick = "" ;
         lblTextblockctacontablegrupo_Jsonclick = "" ;
         lblTextblockctacontablemanual_Jsonclick = "" ;
         lblTextblockctacontableestado_Jsonclick = "" ;
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
         Z194CtaContableNombre = "" ;
         Z196CtaContableGrupo = "" ;
         Gx_mode = "" ;
         AV7ClinicaCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV8Parametros = new SdtParametros(context);
         GXt_SdtParametros3 = new SdtParametros(context);
         T00135_A193CtaContableCodigo = new String[] {""} ;
         T00135_A194CtaContableNombre = new String[] {""} ;
         T00135_A195CtaContableNivel = new short[1] ;
         T00135_A196CtaContableGrupo = new String[] {""} ;
         T00135_A197CtaContableManual = new short[1] ;
         T00135_A198CtaContableEstado = new short[1] ;
         T00135_A41ClinicaCodigo = new String[] {""} ;
         T00134_A41ClinicaCodigo = new String[] {""} ;
         T00136_A41ClinicaCodigo = new String[] {""} ;
         T00137_A41ClinicaCodigo = new String[] {""} ;
         T00137_A193CtaContableCodigo = new String[] {""} ;
         T00133_A193CtaContableCodigo = new String[] {""} ;
         T00133_A194CtaContableNombre = new String[] {""} ;
         T00133_A195CtaContableNivel = new short[1] ;
         T00133_A196CtaContableGrupo = new String[] {""} ;
         T00133_A197CtaContableManual = new short[1] ;
         T00133_A198CtaContableEstado = new short[1] ;
         T00133_A41ClinicaCodigo = new String[] {""} ;
         sMode50 = "" ;
         T00138_A41ClinicaCodigo = new String[] {""} ;
         T00138_A193CtaContableCodigo = new String[] {""} ;
         T00139_A41ClinicaCodigo = new String[] {""} ;
         T00139_A193CtaContableCodigo = new String[] {""} ;
         T001310_A193CtaContableCodigo = new String[] {""} ;
         T001310_A194CtaContableNombre = new String[] {""} ;
         T001310_A195CtaContableNivel = new short[1] ;
         T001310_A196CtaContableGrupo = new String[] {""} ;
         T001310_A197CtaContableManual = new short[1] ;
         T001310_A198CtaContableEstado = new short[1] ;
         T001310_A41ClinicaCodigo = new String[] {""} ;
         T001314_A41ClinicaCodigo = new String[] {""} ;
         T001314_A199TipoParCodigo = new String[] {""} ;
         T001314_A290MovReversadoId = new int[1] ;
         T001314_A291MovReversadoLinea = new short[1] ;
         T001315_A41ClinicaCodigo = new String[] {""} ;
         T001315_A225CierreMCAnio = new short[1] ;
         T001315_A226CierreMCMes = new short[1] ;
         T001315_A193CtaContableCodigo = new String[] {""} ;
         T001316_A41ClinicaCodigo = new String[] {""} ;
         T001316_A199TipoParCodigo = new String[] {""} ;
         T001316_A217MovMayorizadoId = new int[1] ;
         T001316_A218MovMayorizadoLinea = new short[1] ;
         T001317_A41ClinicaCodigo = new String[] {""} ;
         T001317_A199TipoParCodigo = new String[] {""} ;
         T001317_A207PartidaId = new int[1] ;
         T001317_A214PartidaLinea = new short[1] ;
         T001318_A41ClinicaCodigo = new String[] {""} ;
         T001318_A193CtaContableCodigo = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         T001319_A41ClinicaCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cuentacontable__default(),
            new Object[][] {
                new Object[] {
               T00132_A193CtaContableCodigo, T00132_A194CtaContableNombre, T00132_A195CtaContableNivel, T00132_A196CtaContableGrupo, T00132_A197CtaContableManual, T00132_A198CtaContableEstado, T00132_A41ClinicaCodigo
               }
               , new Object[] {
               T00133_A193CtaContableCodigo, T00133_A194CtaContableNombre, T00133_A195CtaContableNivel, T00133_A196CtaContableGrupo, T00133_A197CtaContableManual, T00133_A198CtaContableEstado, T00133_A41ClinicaCodigo
               }
               , new Object[] {
               T00134_A41ClinicaCodigo
               }
               , new Object[] {
               T00135_A193CtaContableCodigo, T00135_A194CtaContableNombre, T00135_A195CtaContableNivel, T00135_A196CtaContableGrupo, T00135_A197CtaContableManual, T00135_A198CtaContableEstado, T00135_A41ClinicaCodigo
               }
               , new Object[] {
               T00136_A41ClinicaCodigo
               }
               , new Object[] {
               T00137_A41ClinicaCodigo, T00137_A193CtaContableCodigo
               }
               , new Object[] {
               T00138_A41ClinicaCodigo, T00138_A193CtaContableCodigo
               }
               , new Object[] {
               T00139_A41ClinicaCodigo, T00139_A193CtaContableCodigo
               }
               , new Object[] {
               T001310_A193CtaContableCodigo, T001310_A194CtaContableNombre, T001310_A195CtaContableNivel, T001310_A196CtaContableGrupo, T001310_A197CtaContableManual, T001310_A198CtaContableEstado, T001310_A41ClinicaCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001314_A41ClinicaCodigo, T001314_A199TipoParCodigo, T001314_A290MovReversadoId, T001314_A291MovReversadoLinea
               }
               , new Object[] {
               T001315_A41ClinicaCodigo, T001315_A225CierreMCAnio, T001315_A226CierreMCMes, T001315_A193CtaContableCodigo
               }
               , new Object[] {
               T001316_A41ClinicaCodigo, T001316_A199TipoParCodigo, T001316_A217MovMayorizadoId, T001316_A218MovMayorizadoLinea
               }
               , new Object[] {
               T001317_A41ClinicaCodigo, T001317_A199TipoParCodigo, T001317_A207PartidaId, T001317_A214PartidaLinea
               }
               , new Object[] {
               T001318_A41ClinicaCodigo, T001318_A193CtaContableCodigo
               }
               , new Object[] {
               T001319_A41ClinicaCodigo
               }
            }
         );
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short A195CtaContableNivel ;
      private short A197CtaContableManual ;
      private short A198CtaContableEstado ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Z195CtaContableNivel ;
      private short Z197CtaContableManual ;
      private short Z198CtaContableEstado ;
      private short GX_JID ;
      private short RcdFound50 ;
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
      private int imgprompt_41_Visible ;
      private int edtCtaContableCodigo_Enabled ;
      private int edtCtaContableNombre_Enabled ;
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
      private String imgprompt_41_Internalname ;
      private String imgprompt_41_Link ;
      private String lblTextblockctacontablecodigo_Internalname ;
      private String lblTextblockctacontablecodigo_Jsonclick ;
      private String edtCtaContableCodigo_Internalname ;
      private String edtCtaContableCodigo_Jsonclick ;
      private String lblTextblockctacontablenombre_Internalname ;
      private String lblTextblockctacontablenombre_Jsonclick ;
      private String edtCtaContableNombre_Internalname ;
      private String edtCtaContableNombre_Jsonclick ;
      private String lblTextblockctacontablenivel_Internalname ;
      private String lblTextblockctacontablenivel_Jsonclick ;
      private String cmbCtaContableNivel_Internalname ;
      private String cmbCtaContableNivel_Jsonclick ;
      private String lblTextblockctacontablegrupo_Internalname ;
      private String lblTextblockctacontablegrupo_Jsonclick ;
      private String cmbCtaContableGrupo_Internalname ;
      private String cmbCtaContableGrupo_Jsonclick ;
      private String lblTextblockctacontablemanual_Internalname ;
      private String lblTextblockctacontablemanual_Jsonclick ;
      private String cmbCtaContableManual_Internalname ;
      private String cmbCtaContableManual_Jsonclick ;
      private String lblTextblockctacontableestado_Internalname ;
      private String lblTextblockctacontableestado_Jsonclick ;
      private String cmbCtaContableEstado_Internalname ;
      private String cmbCtaContableEstado_Jsonclick ;
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
      private String sMode50 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char4 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A41ClinicaCodigo ;
      private String A196CtaContableGrupo ;
      private String A193CtaContableCodigo ;
      private String A194CtaContableNombre ;
      private String Z41ClinicaCodigo ;
      private String Z193CtaContableCodigo ;
      private String Z194CtaContableNombre ;
      private String Z196CtaContableGrupo ;
      private String AV7ClinicaCodigo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbCtaContableNivel ;
      private GXCombobox cmbCtaContableGrupo ;
      private GXCombobox cmbCtaContableManual ;
      private GXCombobox cmbCtaContableEstado ;
      private IDataStoreProvider pr_default ;
      private String[] T00135_A193CtaContableCodigo ;
      private String[] T00135_A194CtaContableNombre ;
      private short[] T00135_A195CtaContableNivel ;
      private String[] T00135_A196CtaContableGrupo ;
      private short[] T00135_A197CtaContableManual ;
      private short[] T00135_A198CtaContableEstado ;
      private String[] T00135_A41ClinicaCodigo ;
      private String[] T00134_A41ClinicaCodigo ;
      private String[] T00136_A41ClinicaCodigo ;
      private String[] T00137_A41ClinicaCodigo ;
      private String[] T00137_A193CtaContableCodigo ;
      private String[] T00133_A193CtaContableCodigo ;
      private String[] T00133_A194CtaContableNombre ;
      private short[] T00133_A195CtaContableNivel ;
      private String[] T00133_A196CtaContableGrupo ;
      private short[] T00133_A197CtaContableManual ;
      private short[] T00133_A198CtaContableEstado ;
      private String[] T00133_A41ClinicaCodigo ;
      private String[] T00138_A41ClinicaCodigo ;
      private String[] T00138_A193CtaContableCodigo ;
      private String[] T00139_A41ClinicaCodigo ;
      private String[] T00139_A193CtaContableCodigo ;
      private String[] T001310_A193CtaContableCodigo ;
      private String[] T001310_A194CtaContableNombre ;
      private short[] T001310_A195CtaContableNivel ;
      private String[] T001310_A196CtaContableGrupo ;
      private short[] T001310_A197CtaContableManual ;
      private short[] T001310_A198CtaContableEstado ;
      private String[] T001310_A41ClinicaCodigo ;
      private String[] T001314_A41ClinicaCodigo ;
      private String[] T001314_A199TipoParCodigo ;
      private int[] T001314_A290MovReversadoId ;
      private short[] T001314_A291MovReversadoLinea ;
      private String[] T001315_A41ClinicaCodigo ;
      private short[] T001315_A225CierreMCAnio ;
      private short[] T001315_A226CierreMCMes ;
      private String[] T001315_A193CtaContableCodigo ;
      private String[] T001316_A41ClinicaCodigo ;
      private String[] T001316_A199TipoParCodigo ;
      private int[] T001316_A217MovMayorizadoId ;
      private short[] T001316_A218MovMayorizadoLinea ;
      private String[] T001317_A41ClinicaCodigo ;
      private String[] T001317_A199TipoParCodigo ;
      private int[] T001317_A207PartidaId ;
      private short[] T001317_A214PartidaLinea ;
      private String[] T001318_A41ClinicaCodigo ;
      private String[] T001318_A193CtaContableCodigo ;
      private String[] T001319_A41ClinicaCodigo ;
      private String[] T00132_A193CtaContableCodigo ;
      private String[] T00132_A194CtaContableNombre ;
      private short[] T00132_A195CtaContableNivel ;
      private String[] T00132_A196CtaContableGrupo ;
      private short[] T00132_A197CtaContableManual ;
      private short[] T00132_A198CtaContableEstado ;
      private String[] T00132_A41ClinicaCodigo ;
      private GXWebForm Form ;
      private SdtParametros AV8Parametros ;
      private SdtParametros GXt_SdtParametros3 ;
   }

   public class cuentacontable__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00132 ;
          prmT00132 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00135 ;
          prmT00135 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00134 ;
          prmT00134 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00136 ;
          prmT00136 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00137 ;
          prmT00137 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00133 ;
          prmT00133 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00138 ;
          prmT00138 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00139 ;
          prmT00139 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001310 ;
          prmT001310 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001311 ;
          prmT001311 = new Object[] {
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableNombre",SqlDbType.VarChar,80,0} ,
          new Object[] {"@CtaContableNivel",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@CtaContableGrupo",SqlDbType.VarChar,15,0} ,
          new Object[] {"@CtaContableManual",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@CtaContableEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001312 ;
          prmT001312 = new Object[] {
          new Object[] {"@CtaContableNombre",SqlDbType.VarChar,80,0} ,
          new Object[] {"@CtaContableNivel",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@CtaContableGrupo",SqlDbType.VarChar,15,0} ,
          new Object[] {"@CtaContableManual",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@CtaContableEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001313 ;
          prmT001313 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001314 ;
          prmT001314 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001315 ;
          prmT001315 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001316 ;
          prmT001316 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001317 ;
          prmT001317 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001318 ;
          prmT001318 = new Object[] {
          } ;
          Object[] prmT001319 ;
          prmT001319 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00132", "SELECT [CtaContableCodigo], [CtaContableNombre], [CtaContableNivel], [CtaContableGrupo], [CtaContableManual], [CtaContableEstado], [ClinicaCodigo] FROM [CuentaContable] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00132,1,0,true,false )
             ,new CursorDef("T00133", "SELECT [CtaContableCodigo], [CtaContableNombre], [CtaContableNivel], [CtaContableGrupo], [CtaContableManual], [CtaContableEstado], [ClinicaCodigo] FROM [CuentaContable] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00133,1,0,true,false )
             ,new CursorDef("T00134", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00134,1,0,true,false )
             ,new CursorDef("T00135", "SELECT TM1.[CtaContableCodigo], TM1.[CtaContableNombre], TM1.[CtaContableNivel], TM1.[CtaContableGrupo], TM1.[CtaContableManual], TM1.[CtaContableEstado], TM1.[ClinicaCodigo] FROM [CuentaContable] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[CtaContableCodigo] = @CtaContableCodigo ORDER BY TM1.[ClinicaCodigo], TM1.[CtaContableCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00135,100,0,true,false )
             ,new CursorDef("T00136", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00136,1,0,true,false )
             ,new CursorDef("T00137", "SELECT [ClinicaCodigo], [CtaContableCodigo] FROM [CuentaContable] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00137,1,0,true,false )
             ,new CursorDef("T00138", "SELECT TOP 1 [ClinicaCodigo], [CtaContableCodigo] FROM [CuentaContable] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [CtaContableCodigo] > @CtaContableCodigo) ORDER BY [ClinicaCodigo], [CtaContableCodigo]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00138,1,0,true,true )
             ,new CursorDef("T00139", "SELECT TOP 1 [ClinicaCodigo], [CtaContableCodigo] FROM [CuentaContable] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [CtaContableCodigo] < @CtaContableCodigo) ORDER BY [ClinicaCodigo] DESC, [CtaContableCodigo] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00139,1,0,true,true )
             ,new CursorDef("T001310", "SELECT [CtaContableCodigo], [CtaContableNombre], [CtaContableNivel], [CtaContableGrupo], [CtaContableManual], [CtaContableEstado], [ClinicaCodigo] FROM [CuentaContable] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001310,1,0,true,false )
             ,new CursorDef("T001311", "INSERT INTO [CuentaContable] ([CtaContableCodigo], [CtaContableNombre], [CtaContableNivel], [CtaContableGrupo], [CtaContableManual], [CtaContableEstado], [ClinicaCodigo]) VALUES (@CtaContableCodigo, @CtaContableNombre, @CtaContableNivel, @CtaContableGrupo, @CtaContableManual, @CtaContableEstado, @ClinicaCodigo)", GxErrorMask.GX_NOMASK,prmT001311)
             ,new CursorDef("T001312", "UPDATE [CuentaContable] SET [CtaContableNombre]=@CtaContableNombre, [CtaContableNivel]=@CtaContableNivel, [CtaContableGrupo]=@CtaContableGrupo, [CtaContableManual]=@CtaContableManual, [CtaContableEstado]=@CtaContableEstado  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo", GxErrorMask.GX_NOMASK,prmT001312)
             ,new CursorDef("T001313", "DELETE FROM [CuentaContable]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo", GxErrorMask.GX_NOMASK,prmT001313)
             ,new CursorDef("T001314", "SELECT TOP 1 [ClinicaCodigo], [TipoParCodigo], [MovReversadoId], [MovReversadoLinea] FROM [MovimientoReversado] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001314,1,0,true,true )
             ,new CursorDef("T001315", "SELECT TOP 1 [ClinicaCodigo], [CierreMCAnio], [CierreMCMes], [CtaContableCodigo] FROM [CierreMensualC] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001315,1,0,true,true )
             ,new CursorDef("T001316", "SELECT TOP 1 [ClinicaCodigo], [TipoParCodigo], [MovMayorizadoId], [MovMayorizadoLinea] FROM [MovimientoMayorizado] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001316,1,0,true,true )
             ,new CursorDef("T001317", "SELECT TOP 1 [ClinicaCodigo], [TipoParCodigo], [PartidaId], [PartidaLinea] FROM [PartidaDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001317,1,0,true,true )
             ,new CursorDef("T001318", "SELECT [ClinicaCodigo], [CtaContableCodigo] FROM [CuentaContable] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [CtaContableCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001318,100,0,true,false )
             ,new CursorDef("T001319", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001319,1,0,true,false )
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
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
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
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
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
                break;
             case 17 :
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
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
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
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
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
                break;
       }
    }

 }

}
