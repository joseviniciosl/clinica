/*
               File: Clinica
        Description: Clínica Médica
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:4:38.91
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
   public class clinica : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A35PaisCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PaisCodigo", A35PaisCodigo);
            A37DepCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37DepCodigo", A37DepCodigo);
            A39MunCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39MunCodigo", A39MunCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_2( A35PaisCodigo, A37DepCodigo, A39MunCodigo) ;
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
         Form.Meta.addItem("Description", "Clínica Médica", 0) ;
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

      public clinica( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public clinica( IGxContext context )
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
            wb_table1_2_0B16( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0B16e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0B16( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0B16( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0B16e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Clínica Médica"+"</legend>") ;
            wb_table3_27_0B16( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0B16e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0B16e( true) ;
         }
         else
         {
            wb_table1_2_0B16e( false) ;
         }
      }

      protected void wb_table3_27_0B16( bool wbgen )
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
            wb_table4_33_0B16( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0B16e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 106,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Clinica.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 107,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Clinica.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 108,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0B16e( true) ;
         }
         else
         {
            wb_table3_27_0B16e( false) ;
         }
      }

      protected void wb_table4_33_0B16( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicanombre_Internalname, "Clínica", "", "", lblTextblockclinicanombre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42ClinicaNombre", A42ClinicaNombre);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaNombre_Internalname, StringUtil.RTrim( A42ClinicaNombre), StringUtil.RTrim( context.localUtil.Format( A42ClinicaNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtClinicaNombre_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaNombre_Enabled, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicanit_Internalname, "Nit", "", "", lblTextblockclinicanit_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43ClinicaNit", A43ClinicaNit);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaNit_Internalname, StringUtil.RTrim( A43ClinicaNit), StringUtil.RTrim( context.localUtil.Format( A43ClinicaNit, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", "", "", "", edtClinicaNit_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaNit_Enabled, 0, 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, true, "left", "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicatelefono1_Internalname, "Teléfono_1", "", "", lblTextblockclinicatelefono1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44ClinicaTelefono1", A44ClinicaTelefono1);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaTelefono1_Internalname, StringUtil.RTrim( A44ClinicaTelefono1), StringUtil.RTrim( context.localUtil.Format( A44ClinicaTelefono1, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "", "", "", "", edtClinicaTelefono1_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaTelefono1_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "left", "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicatelefono2_Internalname, "Teléfono_2", "", "", lblTextblockclinicatelefono2_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45ClinicaTelefono2", A45ClinicaTelefono2);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaTelefono2_Internalname, StringUtil.RTrim( A45ClinicaTelefono2), StringUtil.RTrim( context.localUtil.Format( A45ClinicaTelefono2, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", "", "", "", "", edtClinicaTelefono2_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaTelefono2_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "left", "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacorreo_Internalname, "Correo", "", "", lblTextblockclinicacorreo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46ClinicaCorreo", A46ClinicaCorreo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCorreo_Internalname, StringUtil.RTrim( A46ClinicaCorreo), StringUtil.RTrim( context.localUtil.Format( A46ClinicaCorreo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", "", "", "", "", edtClinicaCorreo_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaCorreo_Enabled, 0, 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, true, "left", "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicadireccion_Internalname, "Dirección", "", "", lblTextblockclinicadireccion_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47ClinicaDireccion", A47ClinicaDireccion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaDireccion_Internalname, StringUtil.RTrim( A47ClinicaDireccion), StringUtil.RTrim( context.localUtil.Format( A47ClinicaDireccion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", "", "", "", "", edtClinicaDireccion_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaDireccion_Enabled, 0, 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, true, "left", "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpaiscodigo_Internalname, "País", "", "", lblTextblockpaiscodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PaisCodigo", A35PaisCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPaisCodigo_Internalname, StringUtil.RTrim( A35PaisCodigo), StringUtil.RTrim( context.localUtil.Format( A35PaisCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(73);\"", "", "", "", "", edtPaisCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtPaisCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockdepcodigo_Internalname, "Departamento", "", "", lblTextblockdepcodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37DepCodigo", A37DepCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtDepCodigo_Internalname, StringUtil.RTrim( A37DepCodigo), StringUtil.RTrim( context.localUtil.Format( A37DepCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(78);\"", "", "", "", "", edtDepCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtDepCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmuncodigo_Internalname, "Municipio", "", "", lblTextblockmuncodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39MunCodigo", A39MunCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMunCodigo_Internalname, StringUtil.RTrim( A39MunCodigo), StringUtil.RTrim( context.localUtil.Format( A39MunCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(83);\"", "", "", "", "", edtMunCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtMunCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Clinica.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_35_37_39_Internalname, "prompt.gif", imgprompt_35_37_39_Link, "", "", "Fantastic", imgprompt_35_37_39_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicazona_Internalname, "Zona", "", "", lblTextblockclinicazona_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48ClinicaZona", StringUtil.LTrim( StringUtil.Str( (decimal)(A48ClinicaZona), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaZona_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A48ClinicaZona), 4, 0, ".", "")), ((edtClinicaZona_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A48ClinicaZona), "ZZZ9")) : context.localUtil.Format( (decimal)(A48ClinicaZona), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(88);\"", "", "", "", "", edtClinicaZona_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaZona_Enabled, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicapropietario_Internalname, "Propietario", "", "", lblTextblockclinicapropietario_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49ClinicaPropietario", A49ClinicaPropietario);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaPropietario_Internalname, StringUtil.RTrim( A49ClinicaPropietario), StringUtil.RTrim( context.localUtil.Format( A49ClinicaPropietario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(93);\"", "", "", "", "", edtClinicaPropietario_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaPropietario_Enabled, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicalogo_Internalname, "Logo", "", "", lblTextblockclinicalogo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Image" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"" ;
            edtClinicaLogo_Filetype = "JPG" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaLogo_Internalname, "Filetype", edtClinicaLogo_Filetype);
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A53ClinicaLogo)) )
            {
               gxblobfileaux.Source = A53ClinicaLogo ;
               gxblobfileaux.SetExtension(StringUtil.Trim( edtClinicaLogo_Filetype));
               if ( gxblobfileaux.ErrCode == 0 )
               {
                  A53ClinicaLogo = gxblobfileaux.GetAbsoluteName() ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53ClinicaLogo", A53ClinicaLogo);
               }
            }
            GxWebStd.gx_blob_field( context, edtClinicaLogo_Internalname, StringUtil.RTrim( A53ClinicaLogo), context.PathToRelativeUrl( A53ClinicaLogo), (String.IsNullOrEmpty(StringUtil.RTrim( edtClinicaLogo_Contenttype)) ? context.GetContentType( (String.IsNullOrEmpty(StringUtil.RTrim( edtClinicaLogo_Filetype)) ? A53ClinicaLogo : edtClinicaLogo_Filetype)) : edtClinicaLogo_Contenttype), false, "", edtClinicaLogo_Parameters, 0, edtClinicaLogo_Enabled, 1, "", "", 0, -1, 250, "px", 60, "px", 0, 0, 0, edtClinicaLogo_Jsonclick, "", StyleString, ClassString, ""+TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(98);\"", "", "HLP_Clinica.htm");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaLogo_Internalname, "URL", context.PathToRelativeUrl( A53ClinicaLogo));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicaiva_Internalname, "IVA", "", "", lblTextblockclinicaiva_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A206ClinicaIva", StringUtil.LTrim( StringUtil.Str( A206ClinicaIva, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaIva_Internalname, StringUtil.LTrim( StringUtil.NToC( A206ClinicaIva, 17, 2, ".", "")), ((edtClinicaIva_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A206ClinicaIva, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A206ClinicaIva, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(103);\"", "", "", "", "", edtClinicaIva_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaIva_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Clinica.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0B16e( true) ;
         }
         else
         {
            wb_table4_33_0B16e( false) ;
         }
      }

      protected void wb_table2_5_0B16( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Clinica.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Clinica.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Clinica.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Clinica.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Clinica.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Clinica.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Clinica.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Clinica.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00g0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Clinica.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00g0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Clinica.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Clinica.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Clinica.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Clinica.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Clinica.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Clinica.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Clinica.htm");
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
            wb_table2_5_0B16e( true) ;
         }
         else
         {
            wb_table2_5_0B16e( false) ;
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
               A42ClinicaNombre = cgiGet( edtClinicaNombre_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42ClinicaNombre", A42ClinicaNombre);
               A43ClinicaNit = cgiGet( edtClinicaNit_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43ClinicaNit", A43ClinicaNit);
               A44ClinicaTelefono1 = cgiGet( edtClinicaTelefono1_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44ClinicaTelefono1", A44ClinicaTelefono1);
               A45ClinicaTelefono2 = cgiGet( edtClinicaTelefono2_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45ClinicaTelefono2", A45ClinicaTelefono2);
               A46ClinicaCorreo = cgiGet( edtClinicaCorreo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46ClinicaCorreo", A46ClinicaCorreo);
               A47ClinicaDireccion = cgiGet( edtClinicaDireccion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47ClinicaDireccion", A47ClinicaDireccion);
               A35PaisCodigo = cgiGet( edtPaisCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PaisCodigo", A35PaisCodigo);
               A37DepCodigo = cgiGet( edtDepCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37DepCodigo", A37DepCodigo);
               A39MunCodigo = cgiGet( edtMunCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39MunCodigo", A39MunCodigo);
               if ( ( ( context.localUtil.CToN( cgiGet( edtClinicaZona_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtClinicaZona_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CLINICAZONA");
                  AnyError = 1 ;
                  GX_FocusControl = edtClinicaZona_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A48ClinicaZona = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48ClinicaZona", StringUtil.LTrim( StringUtil.Str( (decimal)(A48ClinicaZona), 4, 0)));
               }
               else
               {
                  A48ClinicaZona = (short)(context.localUtil.CToN( cgiGet( edtClinicaZona_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48ClinicaZona", StringUtil.LTrim( StringUtil.Str( (decimal)(A48ClinicaZona), 4, 0)));
               }
               A49ClinicaPropietario = cgiGet( edtClinicaPropietario_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49ClinicaPropietario", A49ClinicaPropietario);
               A53ClinicaLogo = cgiGet( edtClinicaLogo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53ClinicaLogo", A53ClinicaLogo);
               if ( ( ( context.localUtil.CToN( cgiGet( edtClinicaIva_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtClinicaIva_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CLINICAIVA");
                  AnyError = 1 ;
                  GX_FocusControl = edtClinicaIva_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A206ClinicaIva = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A206ClinicaIva", StringUtil.LTrim( StringUtil.Str( A206ClinicaIva, 17, 2)));
               }
               else
               {
                  A206ClinicaIva = context.localUtil.CToN( cgiGet( edtClinicaIva_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A206ClinicaIva", StringUtil.LTrim( StringUtil.Str( A206ClinicaIva, 17, 2)));
               }
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z42ClinicaNombre = cgiGet( "Z42ClinicaNombre") ;
               Z43ClinicaNit = cgiGet( "Z43ClinicaNit") ;
               Z44ClinicaTelefono1 = cgiGet( "Z44ClinicaTelefono1") ;
               Z45ClinicaTelefono2 = cgiGet( "Z45ClinicaTelefono2") ;
               Z46ClinicaCorreo = cgiGet( "Z46ClinicaCorreo") ;
               Z47ClinicaDireccion = cgiGet( "Z47ClinicaDireccion") ;
               Z48ClinicaZona = (short)(context.localUtil.CToN( cgiGet( "Z48ClinicaZona"), ".", ",")) ;
               Z49ClinicaPropietario = cgiGet( "Z49ClinicaPropietario") ;
               Z206ClinicaIva = context.localUtil.CToN( cgiGet( "Z206ClinicaIva"), ".", ",") ;
               Z35PaisCodigo = cgiGet( "Z35PaisCodigo") ;
               Z37DepCodigo = cgiGet( "Z37DepCodigo") ;
               Z39MunCodigo = cgiGet( "Z39MunCodigo") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               Gx_mode = cgiGet( "vMODE") ;
               edtClinicaLogo_Filename = cgiGet( "CLINICALOGO_Filename") ;
               edtClinicaLogo_Filetype = cgiGet( "CLINICALOGO_Filetype") ;
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A53ClinicaLogo)) )
               {
                  edtClinicaLogo_Filename = (String)(CGIGetFileName(edtClinicaLogo_Internalname)) ;
                  edtClinicaLogo_Filetype = (String)(CGIGetFileType(edtClinicaLogo_Internalname)) ;
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( A53ClinicaLogo)) )
               {
                  A53ClinicaLogo = cgiGet( "gxBlobCLINICALOGO") ;
               }
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
               InitAll0B16( ) ;
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
         DisableAttributes0B16( ) ;
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

      protected void ResetCaption0B0( )
      {
      }

      protected void ZM0B16( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z42ClinicaNombre = T000B3_A42ClinicaNombre[0] ;
               Z43ClinicaNit = T000B3_A43ClinicaNit[0] ;
               Z44ClinicaTelefono1 = T000B3_A44ClinicaTelefono1[0] ;
               Z45ClinicaTelefono2 = T000B3_A45ClinicaTelefono2[0] ;
               Z46ClinicaCorreo = T000B3_A46ClinicaCorreo[0] ;
               Z47ClinicaDireccion = T000B3_A47ClinicaDireccion[0] ;
               Z48ClinicaZona = T000B3_A48ClinicaZona[0] ;
               Z49ClinicaPropietario = T000B3_A49ClinicaPropietario[0] ;
               Z206ClinicaIva = T000B3_A206ClinicaIva[0] ;
               Z35PaisCodigo = T000B3_A35PaisCodigo[0] ;
               Z37DepCodigo = T000B3_A37DepCodigo[0] ;
               Z39MunCodigo = T000B3_A39MunCodigo[0] ;
            }
            else
            {
               Z42ClinicaNombre = A42ClinicaNombre ;
               Z43ClinicaNit = A43ClinicaNit ;
               Z44ClinicaTelefono1 = A44ClinicaTelefono1 ;
               Z45ClinicaTelefono2 = A45ClinicaTelefono2 ;
               Z46ClinicaCorreo = A46ClinicaCorreo ;
               Z47ClinicaDireccion = A47ClinicaDireccion ;
               Z48ClinicaZona = A48ClinicaZona ;
               Z49ClinicaPropietario = A49ClinicaPropietario ;
               Z206ClinicaIva = A206ClinicaIva ;
               Z35PaisCodigo = A35PaisCodigo ;
               Z37DepCodigo = A37DepCodigo ;
               Z39MunCodigo = A39MunCodigo ;
            }
         }
         if ( GX_JID == -1 )
         {
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z42ClinicaNombre = A42ClinicaNombre ;
            Z43ClinicaNit = A43ClinicaNit ;
            Z44ClinicaTelefono1 = A44ClinicaTelefono1 ;
            Z45ClinicaTelefono2 = A45ClinicaTelefono2 ;
            Z46ClinicaCorreo = A46ClinicaCorreo ;
            Z47ClinicaDireccion = A47ClinicaDireccion ;
            Z48ClinicaZona = A48ClinicaZona ;
            Z49ClinicaPropietario = A49ClinicaPropietario ;
            Z53ClinicaLogo = A53ClinicaLogo ;
            Z206ClinicaIva = A206ClinicaIva ;
            Z35PaisCodigo = A35PaisCodigo ;
            Z37DepCodigo = A37DepCodigo ;
            Z39MunCodigo = A39MunCodigo ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_35_37_39_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00f0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PAISCODIGO"+"'), id:'"+"PAISCODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"DEPCODIGO"+"'), id:'"+"DEPCODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"MUNCODIGO"+"'), id:'"+"MUNCODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
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

      protected void Load0B16( )
      {
         /* Using cursor T000B5 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound16 = 1 ;
            A42ClinicaNombre = T000B5_A42ClinicaNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42ClinicaNombre", A42ClinicaNombre);
            A43ClinicaNit = T000B5_A43ClinicaNit[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43ClinicaNit", A43ClinicaNit);
            A44ClinicaTelefono1 = T000B5_A44ClinicaTelefono1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44ClinicaTelefono1", A44ClinicaTelefono1);
            A45ClinicaTelefono2 = T000B5_A45ClinicaTelefono2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45ClinicaTelefono2", A45ClinicaTelefono2);
            A46ClinicaCorreo = T000B5_A46ClinicaCorreo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46ClinicaCorreo", A46ClinicaCorreo);
            A47ClinicaDireccion = T000B5_A47ClinicaDireccion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47ClinicaDireccion", A47ClinicaDireccion);
            A48ClinicaZona = T000B5_A48ClinicaZona[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48ClinicaZona", StringUtil.LTrim( StringUtil.Str( (decimal)(A48ClinicaZona), 4, 0)));
            A49ClinicaPropietario = T000B5_A49ClinicaPropietario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49ClinicaPropietario", A49ClinicaPropietario);
            A206ClinicaIva = T000B5_A206ClinicaIva[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A206ClinicaIva", StringUtil.LTrim( StringUtil.Str( A206ClinicaIva, 17, 2)));
            A35PaisCodigo = T000B5_A35PaisCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PaisCodigo", A35PaisCodigo);
            A37DepCodigo = T000B5_A37DepCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37DepCodigo", A37DepCodigo);
            A39MunCodigo = T000B5_A39MunCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39MunCodigo", A39MunCodigo);
            A53ClinicaLogo = T000B5_A53ClinicaLogo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53ClinicaLogo", A53ClinicaLogo);
            ZM0B16( -1) ;
         }
         pr_default.close(3);
         OnLoadActions0B16( ) ;
      }

      protected void OnLoadActions0B16( )
      {
      }

      protected void CheckExtendedTable0B16( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T000B4 */
         pr_default.execute(2, new Object[] {A35PaisCodigo, A37DepCodigo, A39MunCodigo});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError35 = 1 ;
            AnyError37 = 1 ;
            AnyError39 = 1 ;
            GX_msglist.addItem("No existe 'Municipios'.", "ForeignKeyNotFound", 1, "PAISCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtPaisCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError35 == 0 ) && ( AnyError37 == 0 ) && ( AnyError39 == 0 ) )
         {
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0B16( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_2( String A35PaisCodigo ,
                               String A37DepCodigo ,
                               String A39MunCodigo )
      {
         /* Using cursor T000B6 */
         pr_default.execute(4, new Object[] {A35PaisCodigo, A37DepCodigo, A39MunCodigo});
         if ( (pr_default.getStatus(4) == 101) )
         {
            AnyError35 = 1 ;
            AnyError37 = 1 ;
            AnyError39 = 1 ;
            GX_msglist.addItem("No existe 'Municipios'.", "ForeignKeyNotFound", 1, "PAISCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtPaisCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError35 == 0 ) && ( AnyError37 == 0 ) && ( AnyError39 == 0 ) )
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

      protected void GetKey0B16( )
      {
         /* Using cursor T000B7 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound16 = 1 ;
         }
         else
         {
            RcdFound16 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000B3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0B16( 1) ;
            RcdFound16 = 1 ;
            A41ClinicaCodigo = T000B3_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A42ClinicaNombre = T000B3_A42ClinicaNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42ClinicaNombre", A42ClinicaNombre);
            A43ClinicaNit = T000B3_A43ClinicaNit[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43ClinicaNit", A43ClinicaNit);
            A44ClinicaTelefono1 = T000B3_A44ClinicaTelefono1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44ClinicaTelefono1", A44ClinicaTelefono1);
            A45ClinicaTelefono2 = T000B3_A45ClinicaTelefono2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45ClinicaTelefono2", A45ClinicaTelefono2);
            A46ClinicaCorreo = T000B3_A46ClinicaCorreo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46ClinicaCorreo", A46ClinicaCorreo);
            A47ClinicaDireccion = T000B3_A47ClinicaDireccion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47ClinicaDireccion", A47ClinicaDireccion);
            A48ClinicaZona = T000B3_A48ClinicaZona[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48ClinicaZona", StringUtil.LTrim( StringUtil.Str( (decimal)(A48ClinicaZona), 4, 0)));
            A49ClinicaPropietario = T000B3_A49ClinicaPropietario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49ClinicaPropietario", A49ClinicaPropietario);
            A206ClinicaIva = T000B3_A206ClinicaIva[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A206ClinicaIva", StringUtil.LTrim( StringUtil.Str( A206ClinicaIva, 17, 2)));
            A35PaisCodigo = T000B3_A35PaisCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PaisCodigo", A35PaisCodigo);
            A37DepCodigo = T000B3_A37DepCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37DepCodigo", A37DepCodigo);
            A39MunCodigo = T000B3_A39MunCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39MunCodigo", A39MunCodigo);
            A53ClinicaLogo = T000B3_A53ClinicaLogo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53ClinicaLogo", A53ClinicaLogo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            sMode16 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0B16( ) ;
            Gx_mode = sMode16 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound16 = 0 ;
            InitializeNonKey0B16( ) ;
            sMode16 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode16 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0B16( ) ;
         if ( RcdFound16 == 0 )
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
         RcdFound16 = 0 ;
         /* Using cursor T000B8 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T000B8_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T000B8_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) ) )
            {
               A41ClinicaCodigo = T000B8_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               RcdFound16 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound16 = 0 ;
         /* Using cursor T000B9 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T000B9_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T000B9_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) ) )
            {
               A41ClinicaCodigo = T000B9_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               RcdFound16 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0B16( ) ;
         if ( RcdFound16 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
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
               Update0B16( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert0B16( ) ;
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
                  Insert0B16( ) ;
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
         if ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
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
         if ( RcdFound16 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtClinicaNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0B16( ) ;
         if ( RcdFound16 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtClinicaNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0B16( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound16 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtClinicaNombre_Internalname ;
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
         if ( RcdFound16 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtClinicaNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0B16( ) ;
         if ( RcdFound16 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound16 != 0 )
            {
               ScanNext0B16( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtClinicaNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0B16( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0B16( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000B10 */
            pr_default.execute(8, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Clinica"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(8) == 101) || ( StringUtil.StrCmp(Z42ClinicaNombre, T000B10_A42ClinicaNombre[0]) != 0 ) || ( StringUtil.StrCmp(Z43ClinicaNit, T000B10_A43ClinicaNit[0]) != 0 ) || ( StringUtil.StrCmp(Z44ClinicaTelefono1, T000B10_A44ClinicaTelefono1[0]) != 0 ) || ( StringUtil.StrCmp(Z45ClinicaTelefono2, T000B10_A45ClinicaTelefono2[0]) != 0 ) || ( StringUtil.StrCmp(Z46ClinicaCorreo, T000B10_A46ClinicaCorreo[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z47ClinicaDireccion, T000B10_A47ClinicaDireccion[0]) != 0 ) || ( Z48ClinicaZona != T000B10_A48ClinicaZona[0] ) || ( StringUtil.StrCmp(Z49ClinicaPropietario, T000B10_A49ClinicaPropietario[0]) != 0 ) || ( Z206ClinicaIva != T000B10_A206ClinicaIva[0] ) || ( StringUtil.StrCmp(Z35PaisCodigo, T000B10_A35PaisCodigo[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z37DepCodigo, T000B10_A37DepCodigo[0]) != 0 ) || ( StringUtil.StrCmp(Z39MunCodigo, T000B10_A39MunCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Clinica"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0B16( )
      {
         BeforeValidate0B16( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0B16( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0B16( 0) ;
            CheckOptimisticConcurrency0B16( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0B16( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0B16( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000B11 */
                     pr_default.execute(9, new Object[] {A41ClinicaCodigo, A42ClinicaNombre, A43ClinicaNit, A44ClinicaTelefono1, A45ClinicaTelefono2, A46ClinicaCorreo, A47ClinicaDireccion, A48ClinicaZona, A49ClinicaPropietario, A53ClinicaLogo, A206ClinicaIva, A35PaisCodigo, A37DepCodigo, A39MunCodigo});
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
                           ResetCaption0B0( ) ;
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
               Load0B16( ) ;
            }
            EndLevel0B16( ) ;
         }
         CloseExtendedTableCursors0B16( ) ;
      }

      protected void Update0B16( )
      {
         BeforeValidate0B16( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0B16( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0B16( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0B16( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0B16( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000B12 */
                     pr_default.execute(10, new Object[] {A42ClinicaNombre, A43ClinicaNit, A44ClinicaTelefono1, A45ClinicaTelefono2, A46ClinicaCorreo, A47ClinicaDireccion, A48ClinicaZona, A49ClinicaPropietario, A206ClinicaIva, A35PaisCodigo, A37DepCodigo, A39MunCodigo, A41ClinicaCodigo});
                     pr_default.close(10);
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Clinica"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0B16( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                           ResetCaption0B0( ) ;
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
            EndLevel0B16( ) ;
         }
         CloseExtendedTableCursors0B16( ) ;
      }

      protected void DeferredUpdate0B16( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor T000B13 */
            pr_default.execute(11, new Object[] {A53ClinicaLogo, A41ClinicaCodigo});
            pr_default.close(11);
         }
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0B16( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0B16( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0B16( ) ;
            AfterConfirm0B16( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0B16( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000B14 */
                  pr_default.execute(12, new Object[] {A41ClinicaCodigo});
                  pr_default.close(12);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound16 == 0 )
                        {
                           InitAll0B16( ) ;
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
                        ResetCaption0B0( ) ;
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
         sMode16 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0B16( ) ;
         Gx_mode = sMode16 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0B16( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000B15 */
            pr_default.execute(13, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Unidades de medidas"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(13);
            /* Using cursor T000B16 */
            pr_default.execute(14, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Tipo Vendedor"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(14);
            /* Using cursor T000B17 */
            pr_default.execute(15, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Religiones"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(15);
            /* Using cursor T000B18 */
            pr_default.execute(16, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(16) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Profesiones existentes"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(16);
            /* Using cursor T000B19 */
            pr_default.execute(17, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(17) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Tabla de reporte de Balance General y Estado de Resultados"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(17);
            /* Using cursor T000B20 */
            pr_default.execute(18, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(18) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Depósitos Bancarios de Caja"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(18);
            /* Using cursor T000B21 */
            pr_default.execute(19, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(19) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Emisores de Tarjetas de Crédito"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(19);
            /* Using cursor T000B22 */
            pr_default.execute(20, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(20) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Resoluciones de Facturas SAT"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(20);
            /* Using cursor T000B23 */
            pr_default.execute(21, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(21) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Agenda"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(21);
            /* Using cursor T000B24 */
            pr_default.execute(22, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(22) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Tipos de Partidas Contables"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(22);
            /* Using cursor T000B25 */
            pr_default.execute(23, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(23) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Catálogo de Cuentas Contables"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(23);
            /* Using cursor T000B26 */
            pr_default.execute(24, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(24) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Factura a Pacientes"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(24);
            /* Using cursor T000B27 */
            pr_default.execute(25, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(25) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Expediente Médico Físico"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(25);
            /* Using cursor T000B28 */
            pr_default.execute(26, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(26) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Cargos de Consulta de Paciente"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(26);
            /* Using cursor T000B29 */
            pr_default.execute(27, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(27) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Cortes de Caja"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(27);
            /* Using cursor T000B30 */
            pr_default.execute(28, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(28) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Tipos de Órdenes"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(28);
            /* Using cursor T000B31 */
            pr_default.execute(29, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(29) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Tipos de Admisiones"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(29);
            /* Using cursor T000B32 */
            pr_default.execute(30, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(30) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Tipos de Pacientes"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(30);
            /* Using cursor T000B33 */
            pr_default.execute(31, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(31) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Tipos de Proveedores"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(31);
            /* Using cursor T000B34 */
            pr_default.execute(32, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(32) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Tipos de Clientes"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(32);
            /* Using cursor T000B35 */
            pr_default.execute(33, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(33) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Correlativos de cortes de caja"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(33);
            /* Using cursor T000B36 */
            pr_default.execute(34, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(34) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Bancos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(34);
            /* Using cursor T000B37 */
            pr_default.execute(35, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(35) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Aseguradoras"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(35);
            /* Using cursor T000B38 */
            pr_default.execute(36, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(36) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Especialidades"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(36);
            /* Using cursor T000B39 */
            pr_default.execute(37, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(37) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Bodegas"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(37);
            /* Using cursor T000B40 */
            pr_default.execute(38, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(38) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Tipos de Movimientos de Inventario"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(38);
            /* Using cursor T000B41 */
            pr_default.execute(39, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(39) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Recetas de pacientes"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(39);
            /* Using cursor T000B42 */
            pr_default.execute(40, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(40) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Signos Vitales"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(40);
            /* Using cursor T000B43 */
            pr_default.execute(41, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(41) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Formas de pago"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(41);
            /* Using cursor T000B44 */
            pr_default.execute(42, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(42) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Correlativos del sistema"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(42);
            /* Using cursor T000B45 */
            pr_default.execute(43, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(43) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Tipos de citas"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(43);
            /* Using cursor T000B46 */
            pr_default.execute(44, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(44) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Clasificación CIE-10"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(44);
            /* Using cursor T000B47 */
            pr_default.execute(45, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(45) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Categorías de productos y servicios"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(45);
            /* Using cursor T000B48 */
            pr_default.execute(46, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(46) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Médicos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(46);
         }
      }

      protected void EndLevel0B16( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0B16( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(6);
            context.CommitDataStores("Clinica");
            if ( AnyError == 0 )
            {
               ConfirmValues0B0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(6);
            context.RollbackDataStores("Clinica");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0B16( )
      {
         /* Using cursor T000B49 */
         pr_default.execute(47);
         RcdFound16 = 0 ;
         if ( (pr_default.getStatus(47) != 101) )
         {
            RcdFound16 = 1 ;
            A41ClinicaCodigo = T000B49_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0B16( )
      {
         pr_default.readNext(47);
         RcdFound16 = 0 ;
         if ( (pr_default.getStatus(47) != 101) )
         {
            RcdFound16 = 1 ;
            A41ClinicaCodigo = T000B49_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         }
      }

      protected void ScanEnd0B16( )
      {
      }

      protected void AfterConfirm0B16( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0B16( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0B16( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0B16( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0B16( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0B16( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0B16( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtClinicaNombre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaNombre_Enabled), 5, 0)));
         edtClinicaNit_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaNit_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaNit_Enabled), 5, 0)));
         edtClinicaTelefono1_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaTelefono1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaTelefono1_Enabled), 5, 0)));
         edtClinicaTelefono2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaTelefono2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaTelefono2_Enabled), 5, 0)));
         edtClinicaCorreo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCorreo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCorreo_Enabled), 5, 0)));
         edtClinicaDireccion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaDireccion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaDireccion_Enabled), 5, 0)));
         edtPaisCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPaisCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPaisCodigo_Enabled), 5, 0)));
         edtDepCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDepCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDepCodigo_Enabled), 5, 0)));
         edtMunCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMunCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMunCodigo_Enabled), 5, 0)));
         edtClinicaZona_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaZona_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaZona_Enabled), 5, 0)));
         edtClinicaPropietario_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaPropietario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaPropietario_Enabled), 5, 0)));
         edtClinicaLogo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaLogo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaLogo_Enabled), 5, 0)));
         edtClinicaIva_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaIva_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaIva_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0B0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("clinica.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z42ClinicaNombre", StringUtil.RTrim( Z42ClinicaNombre));
         GxWebStd.gx_hidden_field( context, "Z43ClinicaNit", StringUtil.RTrim( Z43ClinicaNit));
         GxWebStd.gx_hidden_field( context, "Z44ClinicaTelefono1", StringUtil.RTrim( Z44ClinicaTelefono1));
         GxWebStd.gx_hidden_field( context, "Z45ClinicaTelefono2", StringUtil.RTrim( Z45ClinicaTelefono2));
         GxWebStd.gx_hidden_field( context, "Z46ClinicaCorreo", StringUtil.RTrim( Z46ClinicaCorreo));
         GxWebStd.gx_hidden_field( context, "Z47ClinicaDireccion", StringUtil.RTrim( Z47ClinicaDireccion));
         GxWebStd.gx_hidden_field( context, "Z48ClinicaZona", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z48ClinicaZona), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z49ClinicaPropietario", StringUtil.RTrim( Z49ClinicaPropietario));
         GxWebStd.gx_hidden_field( context, "Z206ClinicaIva", StringUtil.LTrim( StringUtil.NToC( Z206ClinicaIva, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z35PaisCodigo", StringUtil.RTrim( Z35PaisCodigo));
         GxWebStd.gx_hidden_field( context, "Z37DepCodigo", StringUtil.RTrim( Z37DepCodigo));
         GxWebStd.gx_hidden_field( context, "Z39MunCodigo", StringUtil.RTrim( Z39MunCodigo));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxBlobCLINICALOGO", StringUtil.RTrim( A53ClinicaLogo));
         GxWebStd.gx_hidden_field( context, "CLINICALOGO_Filename", StringUtil.RTrim( edtClinicaLogo_Filename));
         GxWebStd.gx_hidden_field( context, "CLINICALOGO_Filetype", StringUtil.RTrim( edtClinicaLogo_Filetype));
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
         return "Clinica" ;
      }

      public override String GetPgmdesc( )
      {
         return "Clínica Médica" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("clinica.aspx")  ;
      }

      protected void InitializeNonKey0B16( )
      {
         A42ClinicaNombre = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42ClinicaNombre", A42ClinicaNombre);
         A43ClinicaNit = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43ClinicaNit", A43ClinicaNit);
         A44ClinicaTelefono1 = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44ClinicaTelefono1", A44ClinicaTelefono1);
         A45ClinicaTelefono2 = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45ClinicaTelefono2", A45ClinicaTelefono2);
         A46ClinicaCorreo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46ClinicaCorreo", A46ClinicaCorreo);
         A47ClinicaDireccion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47ClinicaDireccion", A47ClinicaDireccion);
         A35PaisCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PaisCodigo", A35PaisCodigo);
         A37DepCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37DepCodigo", A37DepCodigo);
         A39MunCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39MunCodigo", A39MunCodigo);
         A48ClinicaZona = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48ClinicaZona", StringUtil.LTrim( StringUtil.Str( (decimal)(A48ClinicaZona), 4, 0)));
         A49ClinicaPropietario = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49ClinicaPropietario", A49ClinicaPropietario);
         A53ClinicaLogo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53ClinicaLogo", A53ClinicaLogo);
         A206ClinicaIva = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A206ClinicaIva", StringUtil.LTrim( StringUtil.Str( A206ClinicaIva, 17, 2)));
      }

      protected void InitAll0B16( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         InitializeNonKey0B16( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1544214");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("clinica.js", "?1544214");
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
         lblTextblockclinicanombre_Internalname = "TEXTBLOCKCLINICANOMBRE" ;
         edtClinicaNombre_Internalname = "CLINICANOMBRE" ;
         lblTextblockclinicanit_Internalname = "TEXTBLOCKCLINICANIT" ;
         edtClinicaNit_Internalname = "CLINICANIT" ;
         lblTextblockclinicatelefono1_Internalname = "TEXTBLOCKCLINICATELEFONO1" ;
         edtClinicaTelefono1_Internalname = "CLINICATELEFONO1" ;
         lblTextblockclinicatelefono2_Internalname = "TEXTBLOCKCLINICATELEFONO2" ;
         edtClinicaTelefono2_Internalname = "CLINICATELEFONO2" ;
         lblTextblockclinicacorreo_Internalname = "TEXTBLOCKCLINICACORREO" ;
         edtClinicaCorreo_Internalname = "CLINICACORREO" ;
         lblTextblockclinicadireccion_Internalname = "TEXTBLOCKCLINICADIRECCION" ;
         edtClinicaDireccion_Internalname = "CLINICADIRECCION" ;
         lblTextblockpaiscodigo_Internalname = "TEXTBLOCKPAISCODIGO" ;
         edtPaisCodigo_Internalname = "PAISCODIGO" ;
         lblTextblockdepcodigo_Internalname = "TEXTBLOCKDEPCODIGO" ;
         edtDepCodigo_Internalname = "DEPCODIGO" ;
         lblTextblockmuncodigo_Internalname = "TEXTBLOCKMUNCODIGO" ;
         edtMunCodigo_Internalname = "MUNCODIGO" ;
         lblTextblockclinicazona_Internalname = "TEXTBLOCKCLINICAZONA" ;
         edtClinicaZona_Internalname = "CLINICAZONA" ;
         lblTextblockclinicapropietario_Internalname = "TEXTBLOCKCLINICAPROPIETARIO" ;
         edtClinicaPropietario_Internalname = "CLINICAPROPIETARIO" ;
         lblTextblockclinicalogo_Internalname = "TEXTBLOCKCLINICALOGO" ;
         edtClinicaLogo_Internalname = "CLINICALOGO" ;
         lblTextblockclinicaiva_Internalname = "TEXTBLOCKCLINICAIVA" ;
         edtClinicaIva_Internalname = "CLINICAIVA" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_35_37_39_Internalname = "PROMPT_35_37_39" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtClinicaLogo_Filename = "" ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Clínica Médica" ;
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
         edtClinicaIva_Jsonclick = "" ;
         edtClinicaIva_Enabled = 1 ;
         edtClinicaLogo_Jsonclick = "" ;
         edtClinicaLogo_Parameters = "" ;
         edtClinicaLogo_Contenttype = "" ;
         edtClinicaLogo_Filetype = "" ;
         edtClinicaLogo_Enabled = 1 ;
         edtClinicaPropietario_Jsonclick = "" ;
         edtClinicaPropietario_Enabled = 1 ;
         edtClinicaZona_Jsonclick = "" ;
         edtClinicaZona_Enabled = 1 ;
         imgprompt_35_37_39_Visible = 1 ;
         imgprompt_35_37_39_Link = "" ;
         edtMunCodigo_Jsonclick = "" ;
         edtMunCodigo_Enabled = 1 ;
         edtDepCodigo_Jsonclick = "" ;
         edtDepCodigo_Enabled = 1 ;
         edtPaisCodigo_Jsonclick = "" ;
         edtPaisCodigo_Enabled = 1 ;
         edtClinicaDireccion_Jsonclick = "" ;
         edtClinicaDireccion_Enabled = 1 ;
         edtClinicaCorreo_Jsonclick = "" ;
         edtClinicaCorreo_Enabled = 1 ;
         edtClinicaTelefono2_Jsonclick = "" ;
         edtClinicaTelefono2_Enabled = 1 ;
         edtClinicaTelefono1_Jsonclick = "" ;
         edtClinicaTelefono1_Enabled = 1 ;
         edtClinicaNit_Jsonclick = "" ;
         edtClinicaNit_Enabled = 1 ;
         edtClinicaNombre_Jsonclick = "" ;
         edtClinicaNombre_Enabled = 1 ;
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
         GX_FocusControl = edtClinicaNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Clinicacodigo( String GX_Parm1 ,
                                       String GX_Parm2 ,
                                       String GX_Parm3 ,
                                       String GX_Parm4 ,
                                       String GX_Parm5 ,
                                       String GX_Parm6 ,
                                       String GX_Parm7 ,
                                       short GX_Parm8 ,
                                       String GX_Parm9 ,
                                       String GX_Parm10 ,
                                       decimal GX_Parm11 ,
                                       String GX_Parm12 ,
                                       String GX_Parm13 ,
                                       String GX_Parm14 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A42ClinicaNombre = GX_Parm2 ;
         A43ClinicaNit = GX_Parm3 ;
         A44ClinicaTelefono1 = GX_Parm4 ;
         A45ClinicaTelefono2 = GX_Parm5 ;
         A46ClinicaCorreo = GX_Parm6 ;
         A47ClinicaDireccion = GX_Parm7 ;
         A48ClinicaZona = GX_Parm8 ;
         A49ClinicaPropietario = GX_Parm9 ;
         A53ClinicaLogo = GX_Parm10 ;
         A206ClinicaIva = GX_Parm11 ;
         A35PaisCodigo = GX_Parm12 ;
         A37DepCodigo = GX_Parm13 ;
         A39MunCodigo = GX_Parm14 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A42ClinicaNombre)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A43ClinicaNit)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A44ClinicaTelefono1)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A45ClinicaTelefono2)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A46ClinicaCorreo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A47ClinicaDireccion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A35PaisCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A37DepCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A39MunCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A48ClinicaZona), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A49ClinicaPropietario)));
         isValidOutput.Add((Object)(context.PathToRelativeUrl( A53ClinicaLogo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A206ClinicaIva, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z42ClinicaNombre)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z43ClinicaNit)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z44ClinicaTelefono1)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z45ClinicaTelefono2)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z46ClinicaCorreo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z47ClinicaDireccion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z35PaisCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z37DepCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z39MunCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z48ClinicaZona), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z49ClinicaPropietario)));
         isValidOutput.Add((Object)(context.PathToRelativeUrl( Z53ClinicaLogo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z206ClinicaIva, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Muncodigo( String GX_Parm1 ,
                                   String GX_Parm2 ,
                                   String GX_Parm3 )
      {
         A35PaisCodigo = GX_Parm1 ;
         A37DepCodigo = GX_Parm2 ;
         A39MunCodigo = GX_Parm3 ;
         /* Using cursor T000B50 */
         pr_default.execute(48, new Object[] {A35PaisCodigo, A37DepCodigo, A39MunCodigo});
         if ( (pr_default.getStatus(48) == 101) )
         {
            AnyError35 = 1 ;
            AnyError37 = 1 ;
            AnyError39 = 1 ;
            GX_msglist.addItem("No existe 'Municipios'.", "ForeignKeyNotFound", 1, "PAISCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtPaisCodigo_Internalname ;
         }
         if ( ( AnyError35 == 0 ) && ( AnyError37 == 0 ) && ( AnyError39 == 0 ) )
         {
         }
         pr_default.close(48);
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
         pr_default.close(47);
         pr_default.close(7);
         pr_default.close(6);
         pr_default.close(48);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A35PaisCodigo = "" ;
         A37DepCodigo = "" ;
         A39MunCodigo = "" ;
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
         A41ClinicaCodigo = "" ;
         lblTextblockclinicanombre_Jsonclick = "" ;
         A42ClinicaNombre = "" ;
         lblTextblockclinicanit_Jsonclick = "" ;
         A43ClinicaNit = "" ;
         lblTextblockclinicatelefono1_Jsonclick = "" ;
         A44ClinicaTelefono1 = "" ;
         lblTextblockclinicatelefono2_Jsonclick = "" ;
         A45ClinicaTelefono2 = "" ;
         lblTextblockclinicacorreo_Jsonclick = "" ;
         A46ClinicaCorreo = "" ;
         lblTextblockclinicadireccion_Jsonclick = "" ;
         A47ClinicaDireccion = "" ;
         lblTextblockpaiscodigo_Jsonclick = "" ;
         lblTextblockdepcodigo_Jsonclick = "" ;
         lblTextblockmuncodigo_Jsonclick = "" ;
         lblTextblockclinicazona_Jsonclick = "" ;
         lblTextblockclinicapropietario_Jsonclick = "" ;
         A49ClinicaPropietario = "" ;
         lblTextblockclinicalogo_Jsonclick = "" ;
         gxblobfileaux = new GxFile(context.GetPhysicalPath());
         A53ClinicaLogo = "" ;
         lblTextblockclinicaiva_Jsonclick = "" ;
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
         Z42ClinicaNombre = "" ;
         Z43ClinicaNit = "" ;
         Z44ClinicaTelefono1 = "" ;
         Z45ClinicaTelefono2 = "" ;
         Z46ClinicaCorreo = "" ;
         Z47ClinicaDireccion = "" ;
         Z49ClinicaPropietario = "" ;
         Z35PaisCodigo = "" ;
         Z37DepCodigo = "" ;
         Z39MunCodigo = "" ;
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         Z53ClinicaLogo = "" ;
         T000B5_A41ClinicaCodigo = new String[] {""} ;
         T000B5_A42ClinicaNombre = new String[] {""} ;
         T000B5_A43ClinicaNit = new String[] {""} ;
         T000B5_A44ClinicaTelefono1 = new String[] {""} ;
         T000B5_A45ClinicaTelefono2 = new String[] {""} ;
         T000B5_A46ClinicaCorreo = new String[] {""} ;
         T000B5_A47ClinicaDireccion = new String[] {""} ;
         T000B5_A48ClinicaZona = new short[1] ;
         T000B5_A49ClinicaPropietario = new String[] {""} ;
         T000B5_A206ClinicaIva = new decimal[1] ;
         T000B5_A35PaisCodigo = new String[] {""} ;
         T000B5_A37DepCodigo = new String[] {""} ;
         T000B5_A39MunCodigo = new String[] {""} ;
         T000B5_A53ClinicaLogo = new String[] {""} ;
         T000B4_A35PaisCodigo = new String[] {""} ;
         T000B6_A35PaisCodigo = new String[] {""} ;
         T000B7_A41ClinicaCodigo = new String[] {""} ;
         T000B3_A41ClinicaCodigo = new String[] {""} ;
         T000B3_A42ClinicaNombre = new String[] {""} ;
         T000B3_A43ClinicaNit = new String[] {""} ;
         T000B3_A44ClinicaTelefono1 = new String[] {""} ;
         T000B3_A45ClinicaTelefono2 = new String[] {""} ;
         T000B3_A46ClinicaCorreo = new String[] {""} ;
         T000B3_A47ClinicaDireccion = new String[] {""} ;
         T000B3_A48ClinicaZona = new short[1] ;
         T000B3_A49ClinicaPropietario = new String[] {""} ;
         T000B3_A206ClinicaIva = new decimal[1] ;
         T000B3_A35PaisCodigo = new String[] {""} ;
         T000B3_A37DepCodigo = new String[] {""} ;
         T000B3_A39MunCodigo = new String[] {""} ;
         T000B3_A53ClinicaLogo = new String[] {""} ;
         sMode16 = "" ;
         T000B8_A41ClinicaCodigo = new String[] {""} ;
         T000B9_A41ClinicaCodigo = new String[] {""} ;
         T000B10_A41ClinicaCodigo = new String[] {""} ;
         T000B10_A42ClinicaNombre = new String[] {""} ;
         T000B10_A43ClinicaNit = new String[] {""} ;
         T000B10_A44ClinicaTelefono1 = new String[] {""} ;
         T000B10_A45ClinicaTelefono2 = new String[] {""} ;
         T000B10_A46ClinicaCorreo = new String[] {""} ;
         T000B10_A47ClinicaDireccion = new String[] {""} ;
         T000B10_A48ClinicaZona = new short[1] ;
         T000B10_A49ClinicaPropietario = new String[] {""} ;
         T000B10_A206ClinicaIva = new decimal[1] ;
         T000B10_A35PaisCodigo = new String[] {""} ;
         T000B10_A37DepCodigo = new String[] {""} ;
         T000B10_A39MunCodigo = new String[] {""} ;
         T000B10_A53ClinicaLogo = new String[] {""} ;
         T000B15_A41ClinicaCodigo = new String[] {""} ;
         T000B15_A380UnidadMedidaCodigo = new String[] {""} ;
         T000B16_A41ClinicaCodigo = new String[] {""} ;
         T000B16_A370TipoVendedorId = new int[1] ;
         T000B17_A41ClinicaCodigo = new String[] {""} ;
         T000B17_A315ReligionId = new int[1] ;
         T000B18_A41ClinicaCodigo = new String[] {""} ;
         T000B18_A313ProfesionId = new int[1] ;
         T000B19_A41ClinicaCodigo = new String[] {""} ;
         T000B19_A302RBECtaContableCodigo = new String[] {""} ;
         T000B20_A41ClinicaCodigo = new String[] {""} ;
         T000B20_A128CuentaBancariaCodigo = new String[] {""} ;
         T000B20_A282DepositoId = new int[1] ;
         T000B21_A41ClinicaCodigo = new String[] {""} ;
         T000B21_A265EmisorCodigo = new String[] {""} ;
         T000B22_A41ClinicaCodigo = new String[] {""} ;
         T000B22_A252ResolucionCodigo = new String[] {""} ;
         T000B23_A41ClinicaCodigo = new String[] {""} ;
         T000B23_A56AgendaId = new String[] {""} ;
         T000B24_A41ClinicaCodigo = new String[] {""} ;
         T000B24_A199TipoParCodigo = new String[] {""} ;
         T000B25_A41ClinicaCodigo = new String[] {""} ;
         T000B25_A193CtaContableCodigo = new String[] {""} ;
         T000B26_A41ClinicaCodigo = new String[] {""} ;
         T000B26_A185FacturaId = new int[1] ;
         T000B27_A41ClinicaCodigo = new String[] {""} ;
         T000B27_A167ExpedienteId = new int[1] ;
         T000B28_A41ClinicaCodigo = new String[] {""} ;
         T000B28_A91ConsultaId = new int[1] ;
         T000B28_A162CargoId = new int[1] ;
         T000B29_A41ClinicaCodigo = new String[] {""} ;
         T000B29_A132CajaCodigo = new String[] {""} ;
         T000B29_A153CorteCajaId = new int[1] ;
         T000B30_A41ClinicaCodigo = new String[] {""} ;
         T000B30_A150TipoOrdCodigo = new String[] {""} ;
         T000B31_A41ClinicaCodigo = new String[] {""} ;
         T000B31_A147TipoAdmCodigo = new String[] {""} ;
         T000B32_A41ClinicaCodigo = new String[] {""} ;
         T000B32_A144TipoPacCodigo = new String[] {""} ;
         T000B33_A41ClinicaCodigo = new String[] {""} ;
         T000B33_A141TipoProCodigo = new String[] {""} ;
         T000B34_A41ClinicaCodigo = new String[] {""} ;
         T000B34_A138TipoCliCodigo = new String[] {""} ;
         T000B35_A41ClinicaCodigo = new String[] {""} ;
         T000B35_A132CajaCodigo = new String[] {""} ;
         T000B35_A135CajaAnio = new short[1] ;
         T000B36_A41ClinicaCodigo = new String[] {""} ;
         T000B36_A126BancoCodigo = new String[] {""} ;
         T000B37_A41ClinicaCodigo = new String[] {""} ;
         T000B37_A82AsegCodigo = new String[] {""} ;
         T000B38_A41ClinicaCodigo = new String[] {""} ;
         T000B38_A17EspCodigo = new String[] {""} ;
         T000B39_A41ClinicaCodigo = new String[] {""} ;
         T000B39_A121BodegaCodigo = new String[] {""} ;
         T000B40_A41ClinicaCodigo = new String[] {""} ;
         T000B40_A114TipoMICodigo = new String[] {""} ;
         T000B41_A41ClinicaCodigo = new String[] {""} ;
         T000B41_A91ConsultaId = new int[1] ;
         T000B41_A109RecetaId = new int[1] ;
         T000B42_A41ClinicaCodigo = new String[] {""} ;
         T000B42_A91ConsultaId = new int[1] ;
         T000B42_A96SignoLinea = new short[1] ;
         T000B43_A41ClinicaCodigo = new String[] {""} ;
         T000B43_A65FormaPagoCodigo = new String[] {""} ;
         T000B44_A41ClinicaCodigo = new String[] {""} ;
         T000B44_A61CorrelativoId = new int[1] ;
         T000B45_A41ClinicaCodigo = new String[] {""} ;
         T000B45_A54CitaCodigo = new String[] {""} ;
         T000B46_A41ClinicaCodigo = new String[] {""} ;
         T000B46_A50Cie10Codigo = new String[] {""} ;
         T000B47_A41ClinicaCodigo = new String[] {""} ;
         T000B47_A27CategoriaCodigo = new String[] {""} ;
         T000B48_A41ClinicaCodigo = new String[] {""} ;
         T000B48_A19MedicoCodigo = new String[] {""} ;
         T000B49_A41ClinicaCodigo = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         T000B50_A35PaisCodigo = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.clinica__default(),
            new Object[][] {
                new Object[] {
               T000B2_A41ClinicaCodigo, T000B2_A42ClinicaNombre, T000B2_A43ClinicaNit, T000B2_A44ClinicaTelefono1, T000B2_A45ClinicaTelefono2, T000B2_A46ClinicaCorreo, T000B2_A47ClinicaDireccion, T000B2_A48ClinicaZona, T000B2_A49ClinicaPropietario, T000B2_A206ClinicaIva,
               T000B2_A35PaisCodigo, T000B2_A37DepCodigo, T000B2_A39MunCodigo, T000B2_A53ClinicaLogo
               }
               , new Object[] {
               T000B3_A41ClinicaCodigo, T000B3_A42ClinicaNombre, T000B3_A43ClinicaNit, T000B3_A44ClinicaTelefono1, T000B3_A45ClinicaTelefono2, T000B3_A46ClinicaCorreo, T000B3_A47ClinicaDireccion, T000B3_A48ClinicaZona, T000B3_A49ClinicaPropietario, T000B3_A206ClinicaIva,
               T000B3_A35PaisCodigo, T000B3_A37DepCodigo, T000B3_A39MunCodigo, T000B3_A53ClinicaLogo
               }
               , new Object[] {
               T000B4_A35PaisCodigo
               }
               , new Object[] {
               T000B5_A41ClinicaCodigo, T000B5_A42ClinicaNombre, T000B5_A43ClinicaNit, T000B5_A44ClinicaTelefono1, T000B5_A45ClinicaTelefono2, T000B5_A46ClinicaCorreo, T000B5_A47ClinicaDireccion, T000B5_A48ClinicaZona, T000B5_A49ClinicaPropietario, T000B5_A206ClinicaIva,
               T000B5_A35PaisCodigo, T000B5_A37DepCodigo, T000B5_A39MunCodigo, T000B5_A53ClinicaLogo
               }
               , new Object[] {
               T000B6_A35PaisCodigo
               }
               , new Object[] {
               T000B7_A41ClinicaCodigo
               }
               , new Object[] {
               T000B8_A41ClinicaCodigo
               }
               , new Object[] {
               T000B9_A41ClinicaCodigo
               }
               , new Object[] {
               T000B10_A41ClinicaCodigo, T000B10_A42ClinicaNombre, T000B10_A43ClinicaNit, T000B10_A44ClinicaTelefono1, T000B10_A45ClinicaTelefono2, T000B10_A46ClinicaCorreo, T000B10_A47ClinicaDireccion, T000B10_A48ClinicaZona, T000B10_A49ClinicaPropietario, T000B10_A206ClinicaIva,
               T000B10_A35PaisCodigo, T000B10_A37DepCodigo, T000B10_A39MunCodigo, T000B10_A53ClinicaLogo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000B15_A41ClinicaCodigo, T000B15_A380UnidadMedidaCodigo
               }
               , new Object[] {
               T000B16_A41ClinicaCodigo, T000B16_A370TipoVendedorId
               }
               , new Object[] {
               T000B17_A41ClinicaCodigo, T000B17_A315ReligionId
               }
               , new Object[] {
               T000B18_A41ClinicaCodigo, T000B18_A313ProfesionId
               }
               , new Object[] {
               T000B19_A41ClinicaCodigo, T000B19_A302RBECtaContableCodigo
               }
               , new Object[] {
               T000B20_A41ClinicaCodigo, T000B20_A128CuentaBancariaCodigo, T000B20_A282DepositoId
               }
               , new Object[] {
               T000B21_A41ClinicaCodigo, T000B21_A265EmisorCodigo
               }
               , new Object[] {
               T000B22_A41ClinicaCodigo, T000B22_A252ResolucionCodigo
               }
               , new Object[] {
               T000B23_A41ClinicaCodigo, T000B23_A56AgendaId
               }
               , new Object[] {
               T000B24_A41ClinicaCodigo, T000B24_A199TipoParCodigo
               }
               , new Object[] {
               T000B25_A41ClinicaCodigo, T000B25_A193CtaContableCodigo
               }
               , new Object[] {
               T000B26_A41ClinicaCodigo, T000B26_A185FacturaId
               }
               , new Object[] {
               T000B27_A41ClinicaCodigo, T000B27_A167ExpedienteId
               }
               , new Object[] {
               T000B28_A41ClinicaCodigo, T000B28_A91ConsultaId, T000B28_A162CargoId
               }
               , new Object[] {
               T000B29_A41ClinicaCodigo, T000B29_A132CajaCodigo, T000B29_A153CorteCajaId
               }
               , new Object[] {
               T000B30_A41ClinicaCodigo, T000B30_A150TipoOrdCodigo
               }
               , new Object[] {
               T000B31_A41ClinicaCodigo, T000B31_A147TipoAdmCodigo
               }
               , new Object[] {
               T000B32_A41ClinicaCodigo, T000B32_A144TipoPacCodigo
               }
               , new Object[] {
               T000B33_A41ClinicaCodigo, T000B33_A141TipoProCodigo
               }
               , new Object[] {
               T000B34_A41ClinicaCodigo, T000B34_A138TipoCliCodigo
               }
               , new Object[] {
               T000B35_A41ClinicaCodigo, T000B35_A132CajaCodigo, T000B35_A135CajaAnio
               }
               , new Object[] {
               T000B36_A41ClinicaCodigo, T000B36_A126BancoCodigo
               }
               , new Object[] {
               T000B37_A41ClinicaCodigo, T000B37_A82AsegCodigo
               }
               , new Object[] {
               T000B38_A41ClinicaCodigo, T000B38_A17EspCodigo
               }
               , new Object[] {
               T000B39_A41ClinicaCodigo, T000B39_A121BodegaCodigo
               }
               , new Object[] {
               T000B40_A41ClinicaCodigo, T000B40_A114TipoMICodigo
               }
               , new Object[] {
               T000B41_A41ClinicaCodigo, T000B41_A91ConsultaId, T000B41_A109RecetaId
               }
               , new Object[] {
               T000B42_A41ClinicaCodigo, T000B42_A91ConsultaId, T000B42_A96SignoLinea
               }
               , new Object[] {
               T000B43_A41ClinicaCodigo, T000B43_A65FormaPagoCodigo
               }
               , new Object[] {
               T000B44_A41ClinicaCodigo, T000B44_A61CorrelativoId
               }
               , new Object[] {
               T000B45_A41ClinicaCodigo, T000B45_A54CitaCodigo
               }
               , new Object[] {
               T000B46_A41ClinicaCodigo, T000B46_A50Cie10Codigo
               }
               , new Object[] {
               T000B47_A41ClinicaCodigo, T000B47_A27CategoriaCodigo
               }
               , new Object[] {
               T000B48_A41ClinicaCodigo, T000B48_A19MedicoCodigo
               }
               , new Object[] {
               T000B49_A41ClinicaCodigo
               }
               , new Object[] {
               T000B50_A35PaisCodigo
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
      private short A48ClinicaZona ;
      private short Z48ClinicaZona ;
      private short GX_JID ;
      private short RcdFound16 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int edtClinicaNombre_Enabled ;
      private int edtClinicaNit_Enabled ;
      private int edtClinicaTelefono1_Enabled ;
      private int edtClinicaTelefono2_Enabled ;
      private int edtClinicaCorreo_Enabled ;
      private int edtClinicaDireccion_Enabled ;
      private int edtPaisCodigo_Enabled ;
      private int edtDepCodigo_Enabled ;
      private int edtMunCodigo_Enabled ;
      private int imgprompt_35_37_39_Visible ;
      private int edtClinicaZona_Enabled ;
      private int edtClinicaPropietario_Enabled ;
      private int edtClinicaLogo_Enabled ;
      private int edtClinicaIva_Enabled ;
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
      private int AnyError35 ;
      private int AnyError37 ;
      private int AnyError39 ;
      private int idxLst ;
      private decimal A206ClinicaIva ;
      private decimal Z206ClinicaIva ;
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
      private String lblTextblockclinicanombre_Internalname ;
      private String lblTextblockclinicanombre_Jsonclick ;
      private String edtClinicaNombre_Internalname ;
      private String edtClinicaNombre_Jsonclick ;
      private String lblTextblockclinicanit_Internalname ;
      private String lblTextblockclinicanit_Jsonclick ;
      private String edtClinicaNit_Internalname ;
      private String edtClinicaNit_Jsonclick ;
      private String lblTextblockclinicatelefono1_Internalname ;
      private String lblTextblockclinicatelefono1_Jsonclick ;
      private String edtClinicaTelefono1_Internalname ;
      private String edtClinicaTelefono1_Jsonclick ;
      private String lblTextblockclinicatelefono2_Internalname ;
      private String lblTextblockclinicatelefono2_Jsonclick ;
      private String edtClinicaTelefono2_Internalname ;
      private String edtClinicaTelefono2_Jsonclick ;
      private String lblTextblockclinicacorreo_Internalname ;
      private String lblTextblockclinicacorreo_Jsonclick ;
      private String edtClinicaCorreo_Internalname ;
      private String edtClinicaCorreo_Jsonclick ;
      private String lblTextblockclinicadireccion_Internalname ;
      private String lblTextblockclinicadireccion_Jsonclick ;
      private String edtClinicaDireccion_Internalname ;
      private String edtClinicaDireccion_Jsonclick ;
      private String lblTextblockpaiscodigo_Internalname ;
      private String lblTextblockpaiscodigo_Jsonclick ;
      private String edtPaisCodigo_Internalname ;
      private String edtPaisCodigo_Jsonclick ;
      private String lblTextblockdepcodigo_Internalname ;
      private String lblTextblockdepcodigo_Jsonclick ;
      private String edtDepCodigo_Internalname ;
      private String edtDepCodigo_Jsonclick ;
      private String lblTextblockmuncodigo_Internalname ;
      private String lblTextblockmuncodigo_Jsonclick ;
      private String edtMunCodigo_Internalname ;
      private String edtMunCodigo_Jsonclick ;
      private String imgprompt_35_37_39_Internalname ;
      private String imgprompt_35_37_39_Link ;
      private String lblTextblockclinicazona_Internalname ;
      private String lblTextblockclinicazona_Jsonclick ;
      private String edtClinicaZona_Internalname ;
      private String edtClinicaZona_Jsonclick ;
      private String lblTextblockclinicapropietario_Internalname ;
      private String lblTextblockclinicapropietario_Jsonclick ;
      private String edtClinicaPropietario_Internalname ;
      private String edtClinicaPropietario_Jsonclick ;
      private String lblTextblockclinicalogo_Internalname ;
      private String lblTextblockclinicalogo_Jsonclick ;
      private String edtClinicaLogo_Filetype ;
      private String edtClinicaLogo_Internalname ;
      private String edtClinicaLogo_Contenttype ;
      private String edtClinicaLogo_Parameters ;
      private String edtClinicaLogo_Jsonclick ;
      private String lblTextblockclinicaiva_Internalname ;
      private String lblTextblockclinicaiva_Jsonclick ;
      private String edtClinicaIva_Internalname ;
      private String edtClinicaIva_Jsonclick ;
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
      private String edtClinicaLogo_Filename ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode16 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool Gx_longc ;
      private String A35PaisCodigo ;
      private String A37DepCodigo ;
      private String A39MunCodigo ;
      private String A41ClinicaCodigo ;
      private String A42ClinicaNombre ;
      private String A43ClinicaNit ;
      private String A44ClinicaTelefono1 ;
      private String A45ClinicaTelefono2 ;
      private String A46ClinicaCorreo ;
      private String A47ClinicaDireccion ;
      private String A49ClinicaPropietario ;
      private String Z41ClinicaCodigo ;
      private String Z42ClinicaNombre ;
      private String Z43ClinicaNit ;
      private String Z44ClinicaTelefono1 ;
      private String Z45ClinicaTelefono2 ;
      private String Z46ClinicaCorreo ;
      private String Z47ClinicaDireccion ;
      private String Z49ClinicaPropietario ;
      private String Z35PaisCodigo ;
      private String Z37DepCodigo ;
      private String Z39MunCodigo ;
      private String A53ClinicaLogo ;
      private String Z53ClinicaLogo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GxFile gxblobfileaux ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T000B5_A41ClinicaCodigo ;
      private String[] T000B5_A42ClinicaNombre ;
      private String[] T000B5_A43ClinicaNit ;
      private String[] T000B5_A44ClinicaTelefono1 ;
      private String[] T000B5_A45ClinicaTelefono2 ;
      private String[] T000B5_A46ClinicaCorreo ;
      private String[] T000B5_A47ClinicaDireccion ;
      private short[] T000B5_A48ClinicaZona ;
      private String[] T000B5_A49ClinicaPropietario ;
      private decimal[] T000B5_A206ClinicaIva ;
      private String[] T000B5_A35PaisCodigo ;
      private String[] T000B5_A37DepCodigo ;
      private String[] T000B5_A39MunCodigo ;
      private String[] T000B5_A53ClinicaLogo ;
      private String[] T000B4_A35PaisCodigo ;
      private String[] T000B6_A35PaisCodigo ;
      private String[] T000B7_A41ClinicaCodigo ;
      private String[] T000B3_A41ClinicaCodigo ;
      private String[] T000B3_A42ClinicaNombre ;
      private String[] T000B3_A43ClinicaNit ;
      private String[] T000B3_A44ClinicaTelefono1 ;
      private String[] T000B3_A45ClinicaTelefono2 ;
      private String[] T000B3_A46ClinicaCorreo ;
      private String[] T000B3_A47ClinicaDireccion ;
      private short[] T000B3_A48ClinicaZona ;
      private String[] T000B3_A49ClinicaPropietario ;
      private decimal[] T000B3_A206ClinicaIva ;
      private String[] T000B3_A35PaisCodigo ;
      private String[] T000B3_A37DepCodigo ;
      private String[] T000B3_A39MunCodigo ;
      private String[] T000B3_A53ClinicaLogo ;
      private String[] T000B8_A41ClinicaCodigo ;
      private String[] T000B9_A41ClinicaCodigo ;
      private String[] T000B10_A41ClinicaCodigo ;
      private String[] T000B10_A42ClinicaNombre ;
      private String[] T000B10_A43ClinicaNit ;
      private String[] T000B10_A44ClinicaTelefono1 ;
      private String[] T000B10_A45ClinicaTelefono2 ;
      private String[] T000B10_A46ClinicaCorreo ;
      private String[] T000B10_A47ClinicaDireccion ;
      private short[] T000B10_A48ClinicaZona ;
      private String[] T000B10_A49ClinicaPropietario ;
      private decimal[] T000B10_A206ClinicaIva ;
      private String[] T000B10_A35PaisCodigo ;
      private String[] T000B10_A37DepCodigo ;
      private String[] T000B10_A39MunCodigo ;
      private String[] T000B10_A53ClinicaLogo ;
      private String[] T000B15_A41ClinicaCodigo ;
      private String[] T000B15_A380UnidadMedidaCodigo ;
      private String[] T000B16_A41ClinicaCodigo ;
      private int[] T000B16_A370TipoVendedorId ;
      private String[] T000B17_A41ClinicaCodigo ;
      private int[] T000B17_A315ReligionId ;
      private String[] T000B18_A41ClinicaCodigo ;
      private int[] T000B18_A313ProfesionId ;
      private String[] T000B19_A41ClinicaCodigo ;
      private String[] T000B19_A302RBECtaContableCodigo ;
      private String[] T000B20_A41ClinicaCodigo ;
      private String[] T000B20_A128CuentaBancariaCodigo ;
      private int[] T000B20_A282DepositoId ;
      private String[] T000B21_A41ClinicaCodigo ;
      private String[] T000B21_A265EmisorCodigo ;
      private String[] T000B22_A41ClinicaCodigo ;
      private String[] T000B22_A252ResolucionCodigo ;
      private String[] T000B23_A41ClinicaCodigo ;
      private String[] T000B23_A56AgendaId ;
      private String[] T000B24_A41ClinicaCodigo ;
      private String[] T000B24_A199TipoParCodigo ;
      private String[] T000B25_A41ClinicaCodigo ;
      private String[] T000B25_A193CtaContableCodigo ;
      private String[] T000B26_A41ClinicaCodigo ;
      private int[] T000B26_A185FacturaId ;
      private String[] T000B27_A41ClinicaCodigo ;
      private int[] T000B27_A167ExpedienteId ;
      private String[] T000B28_A41ClinicaCodigo ;
      private int[] T000B28_A91ConsultaId ;
      private int[] T000B28_A162CargoId ;
      private String[] T000B29_A41ClinicaCodigo ;
      private String[] T000B29_A132CajaCodigo ;
      private int[] T000B29_A153CorteCajaId ;
      private String[] T000B30_A41ClinicaCodigo ;
      private String[] T000B30_A150TipoOrdCodigo ;
      private String[] T000B31_A41ClinicaCodigo ;
      private String[] T000B31_A147TipoAdmCodigo ;
      private String[] T000B32_A41ClinicaCodigo ;
      private String[] T000B32_A144TipoPacCodigo ;
      private String[] T000B33_A41ClinicaCodigo ;
      private String[] T000B33_A141TipoProCodigo ;
      private String[] T000B34_A41ClinicaCodigo ;
      private String[] T000B34_A138TipoCliCodigo ;
      private String[] T000B35_A41ClinicaCodigo ;
      private String[] T000B35_A132CajaCodigo ;
      private short[] T000B35_A135CajaAnio ;
      private String[] T000B36_A41ClinicaCodigo ;
      private String[] T000B36_A126BancoCodigo ;
      private String[] T000B37_A41ClinicaCodigo ;
      private String[] T000B37_A82AsegCodigo ;
      private String[] T000B38_A41ClinicaCodigo ;
      private String[] T000B38_A17EspCodigo ;
      private String[] T000B39_A41ClinicaCodigo ;
      private String[] T000B39_A121BodegaCodigo ;
      private String[] T000B40_A41ClinicaCodigo ;
      private String[] T000B40_A114TipoMICodigo ;
      private String[] T000B41_A41ClinicaCodigo ;
      private int[] T000B41_A91ConsultaId ;
      private int[] T000B41_A109RecetaId ;
      private String[] T000B42_A41ClinicaCodigo ;
      private int[] T000B42_A91ConsultaId ;
      private short[] T000B42_A96SignoLinea ;
      private String[] T000B43_A41ClinicaCodigo ;
      private String[] T000B43_A65FormaPagoCodigo ;
      private String[] T000B44_A41ClinicaCodigo ;
      private int[] T000B44_A61CorrelativoId ;
      private String[] T000B45_A41ClinicaCodigo ;
      private String[] T000B45_A54CitaCodigo ;
      private String[] T000B46_A41ClinicaCodigo ;
      private String[] T000B46_A50Cie10Codigo ;
      private String[] T000B47_A41ClinicaCodigo ;
      private String[] T000B47_A27CategoriaCodigo ;
      private String[] T000B48_A41ClinicaCodigo ;
      private String[] T000B48_A19MedicoCodigo ;
      private String[] T000B49_A41ClinicaCodigo ;
      private String[] T000B50_A35PaisCodigo ;
      private String[] T000B2_A41ClinicaCodigo ;
      private String[] T000B2_A42ClinicaNombre ;
      private String[] T000B2_A43ClinicaNit ;
      private String[] T000B2_A44ClinicaTelefono1 ;
      private String[] T000B2_A45ClinicaTelefono2 ;
      private String[] T000B2_A46ClinicaCorreo ;
      private String[] T000B2_A47ClinicaDireccion ;
      private short[] T000B2_A48ClinicaZona ;
      private String[] T000B2_A49ClinicaPropietario ;
      private decimal[] T000B2_A206ClinicaIva ;
      private String[] T000B2_A35PaisCodigo ;
      private String[] T000B2_A37DepCodigo ;
      private String[] T000B2_A39MunCodigo ;
      private String[] T000B2_A53ClinicaLogo ;
      private GXWebForm Form ;
   }

   public class clinica__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new ForEachCursor(def[24])
         ,new ForEachCursor(def[25])
         ,new ForEachCursor(def[26])
         ,new ForEachCursor(def[27])
         ,new ForEachCursor(def[28])
         ,new ForEachCursor(def[29])
         ,new ForEachCursor(def[30])
         ,new ForEachCursor(def[31])
         ,new ForEachCursor(def[32])
         ,new ForEachCursor(def[33])
         ,new ForEachCursor(def[34])
         ,new ForEachCursor(def[35])
         ,new ForEachCursor(def[36])
         ,new ForEachCursor(def[37])
         ,new ForEachCursor(def[38])
         ,new ForEachCursor(def[39])
         ,new ForEachCursor(def[40])
         ,new ForEachCursor(def[41])
         ,new ForEachCursor(def[42])
         ,new ForEachCursor(def[43])
         ,new ForEachCursor(def[44])
         ,new ForEachCursor(def[45])
         ,new ForEachCursor(def[46])
         ,new ForEachCursor(def[47])
         ,new ForEachCursor(def[48])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000B2 ;
          prmT000B2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B5 ;
          prmT000B5 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B4 ;
          prmT000B4 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MunCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B6 ;
          prmT000B6 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MunCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B7 ;
          prmT000B7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B3 ;
          prmT000B3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B8 ;
          prmT000B8 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B9 ;
          prmT000B9 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B10 ;
          prmT000B10 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B11 ;
          prmT000B11 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaNombre",SqlDbType.VarChar,100,0} ,
          new Object[] {"@ClinicaNit",SqlDbType.VarChar,20,0} ,
          new Object[] {"@ClinicaTelefono1",SqlDbType.VarChar,9,0} ,
          new Object[] {"@ClinicaTelefono2",SqlDbType.VarChar,9,0} ,
          new Object[] {"@ClinicaCorreo",SqlDbType.VarChar,80,0} ,
          new Object[] {"@ClinicaDireccion",SqlDbType.VarChar,120,0} ,
          new Object[] {"@ClinicaZona",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClinicaPropietario",SqlDbType.VarChar,100,0} ,
          new Object[] {"@ClinicaLogo",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@ClinicaIva",SqlDbType.Decimal,17,2} ,
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MunCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B12 ;
          prmT000B12 = new Object[] {
          new Object[] {"@ClinicaNombre",SqlDbType.VarChar,100,0} ,
          new Object[] {"@ClinicaNit",SqlDbType.VarChar,20,0} ,
          new Object[] {"@ClinicaTelefono1",SqlDbType.VarChar,9,0} ,
          new Object[] {"@ClinicaTelefono2",SqlDbType.VarChar,9,0} ,
          new Object[] {"@ClinicaCorreo",SqlDbType.VarChar,80,0} ,
          new Object[] {"@ClinicaDireccion",SqlDbType.VarChar,120,0} ,
          new Object[] {"@ClinicaZona",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClinicaPropietario",SqlDbType.VarChar,100,0} ,
          new Object[] {"@ClinicaIva",SqlDbType.Decimal,17,2} ,
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MunCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B13 ;
          prmT000B13 = new Object[] {
          new Object[] {"@ClinicaLogo",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B14 ;
          prmT000B14 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B15 ;
          prmT000B15 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B16 ;
          prmT000B16 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B17 ;
          prmT000B17 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B18 ;
          prmT000B18 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B19 ;
          prmT000B19 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B20 ;
          prmT000B20 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B21 ;
          prmT000B21 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B22 ;
          prmT000B22 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B23 ;
          prmT000B23 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B24 ;
          prmT000B24 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B25 ;
          prmT000B25 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B26 ;
          prmT000B26 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B27 ;
          prmT000B27 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B28 ;
          prmT000B28 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B29 ;
          prmT000B29 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B30 ;
          prmT000B30 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B31 ;
          prmT000B31 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B32 ;
          prmT000B32 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B33 ;
          prmT000B33 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B34 ;
          prmT000B34 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B35 ;
          prmT000B35 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B36 ;
          prmT000B36 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B37 ;
          prmT000B37 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B38 ;
          prmT000B38 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B39 ;
          prmT000B39 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B40 ;
          prmT000B40 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B41 ;
          prmT000B41 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B42 ;
          prmT000B42 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B43 ;
          prmT000B43 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B44 ;
          prmT000B44 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B45 ;
          prmT000B45 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B46 ;
          prmT000B46 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B47 ;
          prmT000B47 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B48 ;
          prmT000B48 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000B49 ;
          prmT000B49 = new Object[] {
          } ;
          Object[] prmT000B50 ;
          prmT000B50 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MunCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000B2", "SELECT [ClinicaCodigo], [ClinicaNombre], [ClinicaNit], [ClinicaTelefono1], [ClinicaTelefono2], [ClinicaCorreo], [ClinicaDireccion], [ClinicaZona], [ClinicaPropietario], [ClinicaIva], [PaisCodigo], [DepCodigo], [MunCodigo], [ClinicaLogo] FROM [Clinica] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B2,1,0,true,false )
             ,new CursorDef("T000B3", "SELECT [ClinicaCodigo], [ClinicaNombre], [ClinicaNit], [ClinicaTelefono1], [ClinicaTelefono2], [ClinicaCorreo], [ClinicaDireccion], [ClinicaZona], [ClinicaPropietario], [ClinicaIva], [PaisCodigo], [DepCodigo], [MunCodigo], [ClinicaLogo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B3,1,0,true,false )
             ,new CursorDef("T000B4", "SELECT [PaisCodigo] FROM [Municipio] WITH (NOLOCK) WHERE [PaisCodigo] = @PaisCodigo AND [DepCodigo] = @DepCodigo AND [MunCodigo] = @MunCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B4,1,0,true,false )
             ,new CursorDef("T000B5", "SELECT TM1.[ClinicaCodigo], TM1.[ClinicaNombre], TM1.[ClinicaNit], TM1.[ClinicaTelefono1], TM1.[ClinicaTelefono2], TM1.[ClinicaCorreo], TM1.[ClinicaDireccion], TM1.[ClinicaZona], TM1.[ClinicaPropietario], TM1.[ClinicaIva], TM1.[PaisCodigo], TM1.[DepCodigo], TM1.[MunCodigo], TM1.[ClinicaLogo] FROM [Clinica] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo ORDER BY TM1.[ClinicaCodigo]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B5,1,0,true,false )
             ,new CursorDef("T000B6", "SELECT [PaisCodigo] FROM [Municipio] WITH (NOLOCK) WHERE [PaisCodigo] = @PaisCodigo AND [DepCodigo] = @DepCodigo AND [MunCodigo] = @MunCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B6,1,0,true,false )
             ,new CursorDef("T000B7", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B7,1,0,true,false )
             ,new CursorDef("T000B8", "SELECT TOP 1 [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo) ORDER BY [ClinicaCodigo]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B8,1,0,true,true )
             ,new CursorDef("T000B9", "SELECT TOP 1 [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo) ORDER BY [ClinicaCodigo] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B9,1,0,true,true )
             ,new CursorDef("T000B10", "SELECT [ClinicaCodigo], [ClinicaNombre], [ClinicaNit], [ClinicaTelefono1], [ClinicaTelefono2], [ClinicaCorreo], [ClinicaDireccion], [ClinicaZona], [ClinicaPropietario], [ClinicaIva], [PaisCodigo], [DepCodigo], [MunCodigo], [ClinicaLogo] FROM [Clinica] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B10,1,0,true,false )
             ,new CursorDef("T000B11", "INSERT INTO [Clinica] ([ClinicaCodigo], [ClinicaNombre], [ClinicaNit], [ClinicaTelefono1], [ClinicaTelefono2], [ClinicaCorreo], [ClinicaDireccion], [ClinicaZona], [ClinicaPropietario], [ClinicaLogo], [ClinicaIva], [PaisCodigo], [DepCodigo], [MunCodigo]) VALUES (@ClinicaCodigo, @ClinicaNombre, @ClinicaNit, @ClinicaTelefono1, @ClinicaTelefono2, @ClinicaCorreo, @ClinicaDireccion, @ClinicaZona, @ClinicaPropietario, @ClinicaLogo, @ClinicaIva, @PaisCodigo, @DepCodigo, @MunCodigo)", GxErrorMask.GX_NOMASK,prmT000B11)
             ,new CursorDef("T000B12", "UPDATE [Clinica] SET [ClinicaNombre]=@ClinicaNombre, [ClinicaNit]=@ClinicaNit, [ClinicaTelefono1]=@ClinicaTelefono1, [ClinicaTelefono2]=@ClinicaTelefono2, [ClinicaCorreo]=@ClinicaCorreo, [ClinicaDireccion]=@ClinicaDireccion, [ClinicaZona]=@ClinicaZona, [ClinicaPropietario]=@ClinicaPropietario, [ClinicaIva]=@ClinicaIva, [PaisCodigo]=@PaisCodigo, [DepCodigo]=@DepCodigo, [MunCodigo]=@MunCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo", GxErrorMask.GX_NOMASK,prmT000B12)
             ,new CursorDef("T000B13", "UPDATE [Clinica] SET [ClinicaLogo]=@ClinicaLogo  WHERE [ClinicaCodigo] = @ClinicaCodigo", GxErrorMask.GX_NOMASK,prmT000B13)
             ,new CursorDef("T000B14", "DELETE FROM [Clinica]  WHERE [ClinicaCodigo] = @ClinicaCodigo", GxErrorMask.GX_NOMASK,prmT000B14)
             ,new CursorDef("T000B15", "SELECT TOP 1 [ClinicaCodigo], [UnidadMedidaCodigo] FROM [UnidadMedida] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B15,1,0,true,true )
             ,new CursorDef("T000B16", "SELECT TOP 1 [ClinicaCodigo], [TipoVendedorId] FROM [TipoVendedor] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B16,1,0,true,true )
             ,new CursorDef("T000B17", "SELECT TOP 1 [ClinicaCodigo], [ReligionId] FROM [Religion] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B17,1,0,true,true )
             ,new CursorDef("T000B18", "SELECT TOP 1 [ClinicaCodigo], [ProfesionId] FROM [Profesion] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B18,1,0,true,true )
             ,new CursorDef("T000B19", "SELECT TOP 1 [ClinicaCodigo], [RBECtaContableCodigo] FROM [RepBalanceEstado] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B19,1,0,true,true )
             ,new CursorDef("T000B20", "SELECT TOP 1 [ClinicaCodigo], [CuentaBancariaCodigo], [DepositoId] FROM [DepositoBancario] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B20,1,0,true,true )
             ,new CursorDef("T000B21", "SELECT TOP 1 [ClinicaCodigo], [EmisorCodigo] FROM [EmisorTarjeta] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B21,1,0,true,true )
             ,new CursorDef("T000B22", "SELECT TOP 1 [ClinicaCodigo], [ResolucionCodigo] FROM [ResolucionSAT] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B22,1,0,true,true )
             ,new CursorDef("T000B23", "SELECT TOP 1 [ClinicaCodigo], [AgendaId] FROM [Agenda] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B23,1,0,true,true )
             ,new CursorDef("T000B24", "SELECT TOP 1 [ClinicaCodigo], [TipoParCodigo] FROM [TipoPartida] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B24,1,0,true,true )
             ,new CursorDef("T000B25", "SELECT TOP 1 [ClinicaCodigo], [CtaContableCodigo] FROM [CuentaContable] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B25,1,0,true,true )
             ,new CursorDef("T000B26", "SELECT TOP 1 [ClinicaCodigo], [FacturaId] FROM [Factura] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B26,1,0,true,true )
             ,new CursorDef("T000B27", "SELECT TOP 1 [ClinicaCodigo], [ExpedienteId] FROM [Expediente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B27,1,0,true,true )
             ,new CursorDef("T000B28", "SELECT TOP 1 [ClinicaCodigo], [ConsultaId], [CargoId] FROM [Cargo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B28,1,0,true,true )
             ,new CursorDef("T000B29", "SELECT TOP 1 [ClinicaCodigo], [CajaCodigo], [CorteCajaId] FROM [CorteCaja] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B29,1,0,true,true )
             ,new CursorDef("T000B30", "SELECT TOP 1 [ClinicaCodigo], [TipoOrdCodigo] FROM [TipoOrden] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B30,1,0,true,true )
             ,new CursorDef("T000B31", "SELECT TOP 1 [ClinicaCodigo], [TipoAdmCodigo] FROM [TipoAdmision] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B31,1,0,true,true )
             ,new CursorDef("T000B32", "SELECT TOP 1 [ClinicaCodigo], [TipoPacCodigo] FROM [TipoPaciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B32,1,0,true,true )
             ,new CursorDef("T000B33", "SELECT TOP 1 [ClinicaCodigo], [TipoProCodigo] FROM [TipoProveedor] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B33,1,0,true,true )
             ,new CursorDef("T000B34", "SELECT TOP 1 [ClinicaCodigo], [TipoCliCodigo] FROM [TipoCliente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B34,1,0,true,true )
             ,new CursorDef("T000B35", "SELECT TOP 1 [ClinicaCodigo], [CajaCodigo], [CajaAnio] FROM [CajaCorrelativo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B35,1,0,true,true )
             ,new CursorDef("T000B36", "SELECT TOP 1 [ClinicaCodigo], [BancoCodigo] FROM [Banco] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B36,1,0,true,true )
             ,new CursorDef("T000B37", "SELECT TOP 1 [ClinicaCodigo], [AsegCodigo] FROM [Aseguradora] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B37,1,0,true,true )
             ,new CursorDef("T000B38", "SELECT TOP 1 [ClinicaCodigo], [EspCodigo] FROM [Especialidad] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B38,1,0,true,true )
             ,new CursorDef("T000B39", "SELECT TOP 1 [ClinicaCodigo], [BodegaCodigo] FROM [Bodega] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B39,1,0,true,true )
             ,new CursorDef("T000B40", "SELECT TOP 1 [ClinicaCodigo], [TipoMICodigo] FROM [TipoMovInventario] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B40,1,0,true,true )
             ,new CursorDef("T000B41", "SELECT TOP 1 [ClinicaCodigo], [ConsultaId], [RecetaId] FROM [Receta] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B41,1,0,true,true )
             ,new CursorDef("T000B42", "SELECT TOP 1 [ClinicaCodigo], [ConsultaId], [SignoLinea] FROM [ConsultaSigno] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B42,1,0,true,true )
             ,new CursorDef("T000B43", "SELECT TOP 1 [ClinicaCodigo], [FormaPagoCodigo] FROM [FormaPago] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B43,1,0,true,true )
             ,new CursorDef("T000B44", "SELECT TOP 1 [ClinicaCodigo], [CorrelativoId] FROM [Correlativo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B44,1,0,true,true )
             ,new CursorDef("T000B45", "SELECT TOP 1 [ClinicaCodigo], [CitaCodigo] FROM [TipoCita] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B45,1,0,true,true )
             ,new CursorDef("T000B46", "SELECT TOP 1 [ClinicaCodigo], [Cie10Codigo] FROM [Cie10] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B46,1,0,true,true )
             ,new CursorDef("T000B47", "SELECT TOP 1 [ClinicaCodigo], [CategoriaCodigo] FROM [Categoria] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B47,1,0,true,true )
             ,new CursorDef("T000B48", "SELECT TOP 1 [ClinicaCodigo], [MedicoCodigo] FROM [Medico] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B48,1,0,true,true )
             ,new CursorDef("T000B49", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) ORDER BY [ClinicaCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B49,100,0,true,false )
             ,new CursorDef("T000B50", "SELECT [PaisCodigo] FROM [Municipio] WITH (NOLOCK) WHERE [PaisCodigo] = @PaisCodigo AND [DepCodigo] = @DepCodigo AND [MunCodigo] = @MunCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B50,1,0,true,false )
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
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((decimal[]) buf[9])[0] = rslt.getDecimal(10) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[13])[0] = rslt.getBLOBFile(14, "JPG", "") ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((decimal[]) buf[9])[0] = rslt.getDecimal(10) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[13])[0] = rslt.getBLOBFile(14, "JPG", "") ;
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
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((decimal[]) buf[9])[0] = rslt.getDecimal(10) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[13])[0] = rslt.getBLOBFile(14, "JPG", "") ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((decimal[]) buf[9])[0] = rslt.getDecimal(10) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[13])[0] = rslt.getBLOBFile(14, "JPG", "") ;
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 23 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 24 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 25 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 26 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 27 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 28 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 29 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 30 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 31 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 32 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 33 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 34 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 35 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 36 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 37 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 38 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 39 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 40 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 41 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 42 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 43 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 44 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 45 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 46 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 47 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 48 :
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
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (short)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                stmt.SetParameter(11, (decimal)parms[10]);
                stmt.SetParameter(12, (String)parms[11]);
                stmt.SetParameter(13, (String)parms[12]);
                stmt.SetParameter(14, (String)parms[13]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (decimal)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                stmt.SetParameter(11, (String)parms[10]);
                stmt.SetParameter(12, (String)parms[11]);
                stmt.SetParameter(13, (String)parms[12]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 15 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 17 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 18 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 19 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 20 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 21 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 22 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 23 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 24 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 25 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 26 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 27 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 28 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 29 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 30 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 31 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 32 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 33 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 34 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 35 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 36 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 37 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 38 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 39 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 40 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 41 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 42 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 43 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 44 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 45 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 46 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 48 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
       }
    }

 }

}
