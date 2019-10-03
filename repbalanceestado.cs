/*
               File: RepBalanceEstado
        Description: Tabla de reporte de Balance General y Estado de Resultados
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:7:3.76
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
   public class repbalanceestado : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_2( A41ClinicaCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_3") == 0 )
         {
            A4UsuarioCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_3( A4UsuarioCodigo) ;
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
         Form.Meta.addItem("Description", "Tabla de reporte de Balance General y Estado de Resultados", 0) ;
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

      public repbalanceestado( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public repbalanceestado( IGxContext context )
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
            wb_table1_2_1J71( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1J71e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1J71( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1J71( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1J71e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Tabla de reporte de Balance General y Estado de Resultados"+"</legend>") ;
            wb_table3_27_1J71( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_1J71e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1J71e( true) ;
         }
         else
         {
            wb_table1_2_1J71e( false) ;
         }
      }

      protected void wb_table3_27_1J71( bool wbgen )
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
            wb_table4_33_1J71( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_1J71e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_RepBalanceEstado.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 102,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_RepBalanceEstado.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_1J71e( true) ;
         }
         else
         {
            wb_table3_27_1J71e( false) ;
         }
      }

      protected void wb_table4_33_1J71( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_RepBalanceEstado.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_Internalname, "prompt.gif", imgprompt_41_Link, "", "", "Fantastic", imgprompt_41_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockrbectacontablecodigo_Internalname, "Código", "", "", lblTextblockrbectacontablecodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A302RBECtaContableCodigo", A302RBECtaContableCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRBECtaContableCodigo_Internalname, StringUtil.RTrim( A302RBECtaContableCodigo), StringUtil.RTrim( context.localUtil.Format( A302RBECtaContableCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtRBECtaContableCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtRBECtaContableCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockrbectacontablenombre_Internalname, "Nombre", "", "", lblTextblockrbectacontablenombre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A303RBECtaContableNombre", A303RBECtaContableNombre);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRBECtaContableNombre_Internalname, StringUtil.RTrim( A303RBECtaContableNombre), StringUtil.RTrim( context.localUtil.Format( A303RBECtaContableNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", "", "", "", edtRBECtaContableNombre_Jsonclick, 0, ClassString, StyleString, "", 1, edtRBECtaContableNombre_Enabled, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockrbectacontablenivel_Internalname, "Nivel", "", "", lblTextblockrbectacontablenivel_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A304RBECtaContableNivel", StringUtil.Str( (decimal)(A304RBECtaContableNivel), 1, 0));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRBECtaContableNivel_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A304RBECtaContableNivel), 1, 0, ".", "")), ((edtRBECtaContableNivel_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A304RBECtaContableNivel), "9")) : context.localUtil.Format( (decimal)(A304RBECtaContableNivel), "9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(53);\"", "", "", "", "", edtRBECtaContableNivel_Jsonclick, 0, ClassString, StyleString, "", 1, edtRBECtaContableNivel_Enabled, 0, 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, true, "right", "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockrbectacontablegrupo_Internalname, "Grupo", "", "", lblTextblockrbectacontablegrupo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A305RBECtaContableGrupo", A305RBECtaContableGrupo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRBECtaContableGrupo_Internalname, StringUtil.RTrim( A305RBECtaContableGrupo), StringUtil.RTrim( context.localUtil.Format( A305RBECtaContableGrupo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", "", "", "", "", edtRBECtaContableGrupo_Jsonclick, 0, ClassString, StyleString, "", 1, edtRBECtaContableGrupo_Enabled, 0, 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, true, "left", "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockrbectacontablecodigoroot_Internalname, "Root", "", "", lblTextblockrbectacontablecodigoroot_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306RBECtaContableCodigoRoot", A306RBECtaContableCodigoRoot);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRBECtaContableCodigoRoot_Internalname, StringUtil.RTrim( A306RBECtaContableCodigoRoot), StringUtil.RTrim( context.localUtil.Format( A306RBECtaContableCodigoRoot, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", "", "", "", "", edtRBECtaContableCodigoRoot_Jsonclick, 0, ClassString, StyleString, "", 1, edtRBECtaContableCodigoRoot_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockrbectacontablesaldo_Internalname, "Saldo", "", "", lblTextblockrbectacontablesaldo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307RBECtaContableSaldo", StringUtil.LTrim( StringUtil.Str( A307RBECtaContableSaldo, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRBECtaContableSaldo_Internalname, StringUtil.LTrim( StringUtil.NToC( A307RBECtaContableSaldo, 17, 2, ".", "")), ((edtRBECtaContableSaldo_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A307RBECtaContableSaldo, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A307RBECtaContableSaldo, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(68);\"", "", "", "", "", edtRBECtaContableSaldo_Jsonclick, 0, ClassString, StyleString, "", 1, edtRBECtaContableSaldo_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockrbenivel1_Internalname, "Nivel1", "", "", lblTextblockrbenivel1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308RBENivel1", StringUtil.LTrim( StringUtil.Str( A308RBENivel1, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRBENivel1_Internalname, StringUtil.LTrim( StringUtil.NToC( A308RBENivel1, 17, 2, ".", "")), ((edtRBENivel1_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A308RBENivel1, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A308RBENivel1, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(73);\"", "", "", "", "", edtRBENivel1_Jsonclick, 0, ClassString, StyleString, "", 1, edtRBENivel1_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockrbenivel2_Internalname, "Nivel2", "", "", lblTextblockrbenivel2_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309RBENivel2", StringUtil.LTrim( StringUtil.Str( A309RBENivel2, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRBENivel2_Internalname, StringUtil.LTrim( StringUtil.NToC( A309RBENivel2, 17, 2, ".", "")), ((edtRBENivel2_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A309RBENivel2, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A309RBENivel2, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(78);\"", "", "", "", "", edtRBENivel2_Jsonclick, 0, ClassString, StyleString, "", 1, edtRBENivel2_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockrbenivel3_Internalname, "Nivel3", "", "", lblTextblockrbenivel3_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310RBENivel3", StringUtil.LTrim( StringUtil.Str( A310RBENivel3, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRBENivel3_Internalname, StringUtil.LTrim( StringUtil.NToC( A310RBENivel3, 17, 2, ".", "")), ((edtRBENivel3_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A310RBENivel3, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A310RBENivel3, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(83);\"", "", "", "", "", edtRBENivel3_Jsonclick, 0, ClassString, StyleString, "", 1, edtRBENivel3_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockrbenivel4_Internalname, "Nivel4", "", "", lblTextblockrbenivel4_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311RBENivel4", StringUtil.LTrim( StringUtil.Str( A311RBENivel4, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRBENivel4_Internalname, StringUtil.LTrim( StringUtil.NToC( A311RBENivel4, 17, 2, ".", "")), ((edtRBENivel4_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A311RBENivel4, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A311RBENivel4, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(88);\"", "", "", "", "", edtRBENivel4_Jsonclick, 0, ClassString, StyleString, "", 1, edtRBENivel4_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockrbenivel5_Internalname, "Nivel5", "", "", lblTextblockrbenivel5_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312RBENivel5", StringUtil.LTrim( StringUtil.Str( A312RBENivel5, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRBENivel5_Internalname, StringUtil.LTrim( StringUtil.NToC( A312RBENivel5, 17, 2, ".", "")), ((edtRBENivel5_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A312RBENivel5, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A312RBENivel5, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(93);\"", "", "", "", "", edtRBENivel5_Jsonclick, 0, ClassString, StyleString, "", 1, edtRBENivel5_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusuariocodigo_Internalname, "Usuario", "", "", lblTextblockusuariocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUsuarioCodigo_Internalname, StringUtil.RTrim( A4UsuarioCodigo), StringUtil.RTrim( context.localUtil.Format( A4UsuarioCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(98);\"", "", "", "", "", edtUsuarioCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtUsuarioCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_RepBalanceEstado.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_4_Internalname, "prompt.gif", imgprompt_4_Link, "", "", "Fantastic", imgprompt_4_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_RepBalanceEstado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_1J71e( true) ;
         }
         else
         {
            wb_table4_33_1J71e( false) ;
         }
      }

      protected void wb_table2_5_1J71( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_RepBalanceEstado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_RepBalanceEstado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_RepBalanceEstado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_RepBalanceEstado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_RepBalanceEstado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_RepBalanceEstado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_RepBalanceEstado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_RepBalanceEstado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01z0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"RBECTACONTABLECODIGO"+"'), id:'"+"RBECTACONTABLECODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_RepBalanceEstado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01z0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"RBECTACONTABLECODIGO"+"'), id:'"+"RBECTACONTABLECODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_RepBalanceEstado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_RepBalanceEstado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_RepBalanceEstado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_RepBalanceEstado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_RepBalanceEstado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_RepBalanceEstado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_RepBalanceEstado.htm");
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
            wb_table2_5_1J71e( true) ;
         }
         else
         {
            wb_table2_5_1J71e( false) ;
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
               A302RBECtaContableCodigo = cgiGet( edtRBECtaContableCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A302RBECtaContableCodigo", A302RBECtaContableCodigo);
               A303RBECtaContableNombre = cgiGet( edtRBECtaContableNombre_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A303RBECtaContableNombre", A303RBECtaContableNombre);
               if ( ( ( context.localUtil.CToN( cgiGet( edtRBECtaContableNivel_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtRBECtaContableNivel_Internalname), ".", ",") > Convert.ToDecimal( 9 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "RBECTACONTABLENIVEL");
                  AnyError = 1 ;
                  GX_FocusControl = edtRBECtaContableNivel_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A304RBECtaContableNivel = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A304RBECtaContableNivel", StringUtil.Str( (decimal)(A304RBECtaContableNivel), 1, 0));
               }
               else
               {
                  A304RBECtaContableNivel = (short)(context.localUtil.CToN( cgiGet( edtRBECtaContableNivel_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A304RBECtaContableNivel", StringUtil.Str( (decimal)(A304RBECtaContableNivel), 1, 0));
               }
               A305RBECtaContableGrupo = cgiGet( edtRBECtaContableGrupo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A305RBECtaContableGrupo", A305RBECtaContableGrupo);
               A306RBECtaContableCodigoRoot = cgiGet( edtRBECtaContableCodigoRoot_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306RBECtaContableCodigoRoot", A306RBECtaContableCodigoRoot);
               if ( ( ( context.localUtil.CToN( cgiGet( edtRBECtaContableSaldo_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtRBECtaContableSaldo_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "RBECTACONTABLESALDO");
                  AnyError = 1 ;
                  GX_FocusControl = edtRBECtaContableSaldo_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A307RBECtaContableSaldo = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307RBECtaContableSaldo", StringUtil.LTrim( StringUtil.Str( A307RBECtaContableSaldo, 17, 2)));
               }
               else
               {
                  A307RBECtaContableSaldo = context.localUtil.CToN( cgiGet( edtRBECtaContableSaldo_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307RBECtaContableSaldo", StringUtil.LTrim( StringUtil.Str( A307RBECtaContableSaldo, 17, 2)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtRBENivel1_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtRBENivel1_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "RBENIVEL1");
                  AnyError = 1 ;
                  GX_FocusControl = edtRBENivel1_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A308RBENivel1 = 0 ;
                  n308RBENivel1 = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308RBENivel1", StringUtil.LTrim( StringUtil.Str( A308RBENivel1, 17, 2)));
               }
               else
               {
                  A308RBENivel1 = context.localUtil.CToN( cgiGet( edtRBENivel1_Internalname), ".", ",") ;
                  n308RBENivel1 = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308RBENivel1", StringUtil.LTrim( StringUtil.Str( A308RBENivel1, 17, 2)));
               }
               n308RBENivel1 = ((Convert.ToDecimal(0)==A308RBENivel1) ? true : false) ;
               if ( ( ( context.localUtil.CToN( cgiGet( edtRBENivel2_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtRBENivel2_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "RBENIVEL2");
                  AnyError = 1 ;
                  GX_FocusControl = edtRBENivel2_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A309RBENivel2 = 0 ;
                  n309RBENivel2 = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309RBENivel2", StringUtil.LTrim( StringUtil.Str( A309RBENivel2, 17, 2)));
               }
               else
               {
                  A309RBENivel2 = context.localUtil.CToN( cgiGet( edtRBENivel2_Internalname), ".", ",") ;
                  n309RBENivel2 = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309RBENivel2", StringUtil.LTrim( StringUtil.Str( A309RBENivel2, 17, 2)));
               }
               n309RBENivel2 = ((Convert.ToDecimal(0)==A309RBENivel2) ? true : false) ;
               if ( ( ( context.localUtil.CToN( cgiGet( edtRBENivel3_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtRBENivel3_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "RBENIVEL3");
                  AnyError = 1 ;
                  GX_FocusControl = edtRBENivel3_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A310RBENivel3 = 0 ;
                  n310RBENivel3 = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310RBENivel3", StringUtil.LTrim( StringUtil.Str( A310RBENivel3, 17, 2)));
               }
               else
               {
                  A310RBENivel3 = context.localUtil.CToN( cgiGet( edtRBENivel3_Internalname), ".", ",") ;
                  n310RBENivel3 = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310RBENivel3", StringUtil.LTrim( StringUtil.Str( A310RBENivel3, 17, 2)));
               }
               n310RBENivel3 = ((Convert.ToDecimal(0)==A310RBENivel3) ? true : false) ;
               if ( ( ( context.localUtil.CToN( cgiGet( edtRBENivel4_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtRBENivel4_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "RBENIVEL4");
                  AnyError = 1 ;
                  GX_FocusControl = edtRBENivel4_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A311RBENivel4 = 0 ;
                  n311RBENivel4 = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311RBENivel4", StringUtil.LTrim( StringUtil.Str( A311RBENivel4, 17, 2)));
               }
               else
               {
                  A311RBENivel4 = context.localUtil.CToN( cgiGet( edtRBENivel4_Internalname), ".", ",") ;
                  n311RBENivel4 = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311RBENivel4", StringUtil.LTrim( StringUtil.Str( A311RBENivel4, 17, 2)));
               }
               n311RBENivel4 = ((Convert.ToDecimal(0)==A311RBENivel4) ? true : false) ;
               if ( ( ( context.localUtil.CToN( cgiGet( edtRBENivel5_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtRBENivel5_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "RBENIVEL5");
                  AnyError = 1 ;
                  GX_FocusControl = edtRBENivel5_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A312RBENivel5 = 0 ;
                  n312RBENivel5 = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312RBENivel5", StringUtil.LTrim( StringUtil.Str( A312RBENivel5, 17, 2)));
               }
               else
               {
                  A312RBENivel5 = context.localUtil.CToN( cgiGet( edtRBENivel5_Internalname), ".", ",") ;
                  n312RBENivel5 = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312RBENivel5", StringUtil.LTrim( StringUtil.Str( A312RBENivel5, 17, 2)));
               }
               n312RBENivel5 = ((Convert.ToDecimal(0)==A312RBENivel5) ? true : false) ;
               A4UsuarioCodigo = cgiGet( edtUsuarioCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z302RBECtaContableCodigo = cgiGet( "Z302RBECtaContableCodigo") ;
               Z303RBECtaContableNombre = cgiGet( "Z303RBECtaContableNombre") ;
               Z304RBECtaContableNivel = (short)(context.localUtil.CToN( cgiGet( "Z304RBECtaContableNivel"), ".", ",")) ;
               Z305RBECtaContableGrupo = cgiGet( "Z305RBECtaContableGrupo") ;
               Z306RBECtaContableCodigoRoot = cgiGet( "Z306RBECtaContableCodigoRoot") ;
               Z307RBECtaContableSaldo = context.localUtil.CToN( cgiGet( "Z307RBECtaContableSaldo"), ".", ",") ;
               Z308RBENivel1 = context.localUtil.CToN( cgiGet( "Z308RBENivel1"), ".", ",") ;
               n308RBENivel1 = ((Convert.ToDecimal(0)==A308RBENivel1) ? true : false) ;
               Z309RBENivel2 = context.localUtil.CToN( cgiGet( "Z309RBENivel2"), ".", ",") ;
               n309RBENivel2 = ((Convert.ToDecimal(0)==A309RBENivel2) ? true : false) ;
               Z310RBENivel3 = context.localUtil.CToN( cgiGet( "Z310RBENivel3"), ".", ",") ;
               n310RBENivel3 = ((Convert.ToDecimal(0)==A310RBENivel3) ? true : false) ;
               Z311RBENivel4 = context.localUtil.CToN( cgiGet( "Z311RBENivel4"), ".", ",") ;
               n311RBENivel4 = ((Convert.ToDecimal(0)==A311RBENivel4) ? true : false) ;
               Z312RBENivel5 = context.localUtil.CToN( cgiGet( "Z312RBENivel5"), ".", ",") ;
               n312RBENivel5 = ((Convert.ToDecimal(0)==A312RBENivel5) ? true : false) ;
               Z4UsuarioCodigo = cgiGet( "Z4UsuarioCodigo") ;
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
                  A302RBECtaContableCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A302RBECtaContableCodigo", A302RBECtaContableCodigo);
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
               InitAll1J71( ) ;
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
         DisableAttributes1J71( ) ;
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

      protected void ResetCaption1J0( )
      {
      }

      protected void ZM1J71( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z303RBECtaContableNombre = T001J3_A303RBECtaContableNombre[0] ;
               Z304RBECtaContableNivel = T001J3_A304RBECtaContableNivel[0] ;
               Z305RBECtaContableGrupo = T001J3_A305RBECtaContableGrupo[0] ;
               Z306RBECtaContableCodigoRoot = T001J3_A306RBECtaContableCodigoRoot[0] ;
               Z307RBECtaContableSaldo = T001J3_A307RBECtaContableSaldo[0] ;
               Z308RBENivel1 = T001J3_A308RBENivel1[0] ;
               Z309RBENivel2 = T001J3_A309RBENivel2[0] ;
               Z310RBENivel3 = T001J3_A310RBENivel3[0] ;
               Z311RBENivel4 = T001J3_A311RBENivel4[0] ;
               Z312RBENivel5 = T001J3_A312RBENivel5[0] ;
               Z4UsuarioCodigo = T001J3_A4UsuarioCodigo[0] ;
            }
            else
            {
               Z303RBECtaContableNombre = A303RBECtaContableNombre ;
               Z304RBECtaContableNivel = A304RBECtaContableNivel ;
               Z305RBECtaContableGrupo = A305RBECtaContableGrupo ;
               Z306RBECtaContableCodigoRoot = A306RBECtaContableCodigoRoot ;
               Z307RBECtaContableSaldo = A307RBECtaContableSaldo ;
               Z308RBENivel1 = A308RBENivel1 ;
               Z309RBENivel2 = A309RBENivel2 ;
               Z310RBENivel3 = A310RBENivel3 ;
               Z311RBENivel4 = A311RBENivel4 ;
               Z312RBENivel5 = A312RBENivel5 ;
               Z4UsuarioCodigo = A4UsuarioCodigo ;
            }
         }
         if ( GX_JID == -1 )
         {
            Z302RBECtaContableCodigo = A302RBECtaContableCodigo ;
            Z303RBECtaContableNombre = A303RBECtaContableNombre ;
            Z304RBECtaContableNivel = A304RBECtaContableNivel ;
            Z305RBECtaContableGrupo = A305RBECtaContableGrupo ;
            Z306RBECtaContableCodigoRoot = A306RBECtaContableCodigoRoot ;
            Z307RBECtaContableSaldo = A307RBECtaContableSaldo ;
            Z308RBENivel1 = A308RBENivel1 ;
            Z309RBENivel2 = A309RBENivel2 ;
            Z310RBENivel3 = A310RBENivel3 ;
            Z311RBENivel4 = A311RBENivel4 ;
            Z312RBENivel5 = A312RBENivel5 ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z4UsuarioCodigo = A4UsuarioCodigo ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_41_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00g0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"true"+");") ;
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

      protected void Load1J71( )
      {
         /* Using cursor T001J6 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo, A302RBECtaContableCodigo});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound71 = 1 ;
            A303RBECtaContableNombre = T001J6_A303RBECtaContableNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A303RBECtaContableNombre", A303RBECtaContableNombre);
            A304RBECtaContableNivel = T001J6_A304RBECtaContableNivel[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A304RBECtaContableNivel", StringUtil.Str( (decimal)(A304RBECtaContableNivel), 1, 0));
            A305RBECtaContableGrupo = T001J6_A305RBECtaContableGrupo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A305RBECtaContableGrupo", A305RBECtaContableGrupo);
            A306RBECtaContableCodigoRoot = T001J6_A306RBECtaContableCodigoRoot[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306RBECtaContableCodigoRoot", A306RBECtaContableCodigoRoot);
            A307RBECtaContableSaldo = T001J6_A307RBECtaContableSaldo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307RBECtaContableSaldo", StringUtil.LTrim( StringUtil.Str( A307RBECtaContableSaldo, 17, 2)));
            A308RBENivel1 = T001J6_A308RBENivel1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308RBENivel1", StringUtil.LTrim( StringUtil.Str( A308RBENivel1, 17, 2)));
            n308RBENivel1 = T001J6_n308RBENivel1[0] ;
            A309RBENivel2 = T001J6_A309RBENivel2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309RBENivel2", StringUtil.LTrim( StringUtil.Str( A309RBENivel2, 17, 2)));
            n309RBENivel2 = T001J6_n309RBENivel2[0] ;
            A310RBENivel3 = T001J6_A310RBENivel3[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310RBENivel3", StringUtil.LTrim( StringUtil.Str( A310RBENivel3, 17, 2)));
            n310RBENivel3 = T001J6_n310RBENivel3[0] ;
            A311RBENivel4 = T001J6_A311RBENivel4[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311RBENivel4", StringUtil.LTrim( StringUtil.Str( A311RBENivel4, 17, 2)));
            n311RBENivel4 = T001J6_n311RBENivel4[0] ;
            A312RBENivel5 = T001J6_A312RBENivel5[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312RBENivel5", StringUtil.LTrim( StringUtil.Str( A312RBENivel5, 17, 2)));
            n312RBENivel5 = T001J6_n312RBENivel5[0] ;
            A4UsuarioCodigo = T001J6_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            ZM1J71( -1) ;
         }
         pr_default.close(4);
         OnLoadActions1J71( ) ;
      }

      protected void OnLoadActions1J71( )
      {
      }

      protected void CheckExtendedTable1J71( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T001J4 */
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
         /* Using cursor T001J5 */
         pr_default.execute(3, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(3) == 101) )
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
         pr_default.close(3);
      }

      protected void CloseExtendedTableCursors1J71( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_2( String A41ClinicaCodigo )
      {
         /* Using cursor T001J7 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(5) == 101) )
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
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(5);
      }

      protected void gxLoad_3( String A4UsuarioCodigo )
      {
         /* Using cursor T001J8 */
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

      protected void GetKey1J71( )
      {
         /* Using cursor T001J9 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A302RBECtaContableCodigo});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound71 = 1 ;
         }
         else
         {
            RcdFound71 = 0 ;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001J3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A302RBECtaContableCodigo});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1J71( 1) ;
            RcdFound71 = 1 ;
            A302RBECtaContableCodigo = T001J3_A302RBECtaContableCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A302RBECtaContableCodigo", A302RBECtaContableCodigo);
            A303RBECtaContableNombre = T001J3_A303RBECtaContableNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A303RBECtaContableNombre", A303RBECtaContableNombre);
            A304RBECtaContableNivel = T001J3_A304RBECtaContableNivel[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A304RBECtaContableNivel", StringUtil.Str( (decimal)(A304RBECtaContableNivel), 1, 0));
            A305RBECtaContableGrupo = T001J3_A305RBECtaContableGrupo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A305RBECtaContableGrupo", A305RBECtaContableGrupo);
            A306RBECtaContableCodigoRoot = T001J3_A306RBECtaContableCodigoRoot[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306RBECtaContableCodigoRoot", A306RBECtaContableCodigoRoot);
            A307RBECtaContableSaldo = T001J3_A307RBECtaContableSaldo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307RBECtaContableSaldo", StringUtil.LTrim( StringUtil.Str( A307RBECtaContableSaldo, 17, 2)));
            A308RBENivel1 = T001J3_A308RBENivel1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308RBENivel1", StringUtil.LTrim( StringUtil.Str( A308RBENivel1, 17, 2)));
            n308RBENivel1 = T001J3_n308RBENivel1[0] ;
            A309RBENivel2 = T001J3_A309RBENivel2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309RBENivel2", StringUtil.LTrim( StringUtil.Str( A309RBENivel2, 17, 2)));
            n309RBENivel2 = T001J3_n309RBENivel2[0] ;
            A310RBENivel3 = T001J3_A310RBENivel3[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310RBENivel3", StringUtil.LTrim( StringUtil.Str( A310RBENivel3, 17, 2)));
            n310RBENivel3 = T001J3_n310RBENivel3[0] ;
            A311RBENivel4 = T001J3_A311RBENivel4[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311RBENivel4", StringUtil.LTrim( StringUtil.Str( A311RBENivel4, 17, 2)));
            n311RBENivel4 = T001J3_n311RBENivel4[0] ;
            A312RBENivel5 = T001J3_A312RBENivel5[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312RBENivel5", StringUtil.LTrim( StringUtil.Str( A312RBENivel5, 17, 2)));
            n312RBENivel5 = T001J3_n312RBENivel5[0] ;
            A41ClinicaCodigo = T001J3_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A4UsuarioCodigo = T001J3_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z302RBECtaContableCodigo = A302RBECtaContableCodigo ;
            sMode71 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1J71( ) ;
            Gx_mode = sMode71 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound71 = 0 ;
            InitializeNonKey1J71( ) ;
            sMode71 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode71 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1J71( ) ;
         if ( RcdFound71 == 0 )
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
         RcdFound71 = 0 ;
         /* Using cursor T001J10 */
         pr_default.execute(8, new Object[] {A41ClinicaCodigo, A302RBECtaContableCodigo});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T001J10_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001J10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001J10_A302RBECtaContableCodigo[0], A302RBECtaContableCodigo) < 0 ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T001J10_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001J10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001J10_A302RBECtaContableCodigo[0], A302RBECtaContableCodigo) > 0 ) ) )
            {
               A41ClinicaCodigo = T001J10_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A302RBECtaContableCodigo = T001J10_A302RBECtaContableCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A302RBECtaContableCodigo", A302RBECtaContableCodigo);
               RcdFound71 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound71 = 0 ;
         /* Using cursor T001J11 */
         pr_default.execute(9, new Object[] {A41ClinicaCodigo, A302RBECtaContableCodigo});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T001J11_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001J11_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001J11_A302RBECtaContableCodigo[0], A302RBECtaContableCodigo) > 0 ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T001J11_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001J11_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001J11_A302RBECtaContableCodigo[0], A302RBECtaContableCodigo) < 0 ) ) )
            {
               A41ClinicaCodigo = T001J11_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A302RBECtaContableCodigo = T001J11_A302RBECtaContableCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A302RBECtaContableCodigo", A302RBECtaContableCodigo);
               RcdFound71 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1J71( ) ;
         if ( RcdFound71 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A302RBECtaContableCodigo, Z302RBECtaContableCodigo) != 0 ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A302RBECtaContableCodigo = Z302RBECtaContableCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A302RBECtaContableCodigo", A302RBECtaContableCodigo);
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
               Update1J71( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A302RBECtaContableCodigo, Z302RBECtaContableCodigo) != 0 ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert1J71( ) ;
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
                  Insert1J71( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A302RBECtaContableCodigo, Z302RBECtaContableCodigo) != 0 ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A302RBECtaContableCodigo = Z302RBECtaContableCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A302RBECtaContableCodigo", A302RBECtaContableCodigo);
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
         if ( RcdFound71 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtRBECtaContableNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1J71( ) ;
         if ( RcdFound71 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtRBECtaContableNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1J71( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound71 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtRBECtaContableNombre_Internalname ;
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
         if ( RcdFound71 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtRBECtaContableNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1J71( ) ;
         if ( RcdFound71 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound71 != 0 )
            {
               ScanNext1J71( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtRBECtaContableNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1J71( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1J71( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001J12 */
            pr_default.execute(10, new Object[] {A41ClinicaCodigo, A302RBECtaContableCodigo});
            if ( (pr_default.getStatus(10) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"RepBalanceEstado"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(10) == 101) || ( StringUtil.StrCmp(Z303RBECtaContableNombre, T001J12_A303RBECtaContableNombre[0]) != 0 ) || ( Z304RBECtaContableNivel != T001J12_A304RBECtaContableNivel[0] ) || ( StringUtil.StrCmp(Z305RBECtaContableGrupo, T001J12_A305RBECtaContableGrupo[0]) != 0 ) || ( StringUtil.StrCmp(Z306RBECtaContableCodigoRoot, T001J12_A306RBECtaContableCodigoRoot[0]) != 0 ) || ( Z307RBECtaContableSaldo != T001J12_A307RBECtaContableSaldo[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z308RBENivel1 != T001J12_A308RBENivel1[0] ) || ( Z309RBENivel2 != T001J12_A309RBENivel2[0] ) || ( Z310RBENivel3 != T001J12_A310RBENivel3[0] ) || ( Z311RBENivel4 != T001J12_A311RBENivel4[0] ) || ( Z312RBENivel5 != T001J12_A312RBENivel5[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z4UsuarioCodigo, T001J12_A4UsuarioCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"RepBalanceEstado"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1J71( )
      {
         BeforeValidate1J71( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1J71( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1J71( 0) ;
            CheckOptimisticConcurrency1J71( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1J71( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1J71( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001J13 */
                     pr_default.execute(11, new Object[] {A302RBECtaContableCodigo, A303RBECtaContableNombre, A304RBECtaContableNivel, A305RBECtaContableGrupo, A306RBECtaContableCodigoRoot, A307RBECtaContableSaldo, n308RBENivel1, A308RBENivel1, n309RBENivel2, A309RBENivel2, n310RBENivel3, A310RBENivel3, n311RBENivel4, A311RBENivel4, n312RBENivel5, A312RBENivel5, A41ClinicaCodigo, A4UsuarioCodigo});
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
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                           ResetCaption1J0( ) ;
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
               Load1J71( ) ;
            }
            EndLevel1J71( ) ;
         }
         CloseExtendedTableCursors1J71( ) ;
      }

      protected void Update1J71( )
      {
         BeforeValidate1J71( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1J71( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1J71( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1J71( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1J71( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001J14 */
                     pr_default.execute(12, new Object[] {A303RBECtaContableNombre, A304RBECtaContableNivel, A305RBECtaContableGrupo, A306RBECtaContableCodigoRoot, A307RBECtaContableSaldo, n308RBENivel1, A308RBENivel1, n309RBENivel2, A309RBENivel2, n310RBENivel3, A310RBENivel3, n311RBENivel4, A311RBENivel4, n312RBENivel5, A312RBENivel5, A4UsuarioCodigo, A41ClinicaCodigo, A302RBECtaContableCodigo});
                     pr_default.close(12);
                     if ( (pr_default.getStatus(12) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"RepBalanceEstado"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1J71( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                           ResetCaption1J0( ) ;
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
            EndLevel1J71( ) ;
         }
         CloseExtendedTableCursors1J71( ) ;
      }

      protected void DeferredUpdate1J71( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1J71( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1J71( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1J71( ) ;
            AfterConfirm1J71( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1J71( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001J15 */
                  pr_default.execute(13, new Object[] {A41ClinicaCodigo, A302RBECtaContableCodigo});
                  pr_default.close(13);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound71 == 0 )
                        {
                           InitAll1J71( ) ;
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
                        ResetCaption1J0( ) ;
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
         sMode71 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1J71( ) ;
         Gx_mode = sMode71 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1J71( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1J71( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1J71( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(9);
            pr_default.close(8);
            context.CommitDataStores("RepBalanceEstado");
            if ( AnyError == 0 )
            {
               ConfirmValues1J0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(9);
            pr_default.close(8);
            context.RollbackDataStores("RepBalanceEstado");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1J71( )
      {
         /* Using cursor T001J16 */
         pr_default.execute(14);
         RcdFound71 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound71 = 1 ;
            A41ClinicaCodigo = T001J16_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A302RBECtaContableCodigo = T001J16_A302RBECtaContableCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A302RBECtaContableCodigo", A302RBECtaContableCodigo);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1J71( )
      {
         pr_default.readNext(14);
         RcdFound71 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound71 = 1 ;
            A41ClinicaCodigo = T001J16_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A302RBECtaContableCodigo = T001J16_A302RBECtaContableCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A302RBECtaContableCodigo", A302RBECtaContableCodigo);
         }
      }

      protected void ScanEnd1J71( )
      {
      }

      protected void AfterConfirm1J71( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1J71( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1J71( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1J71( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1J71( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1J71( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1J71( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtRBECtaContableCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRBECtaContableCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRBECtaContableCodigo_Enabled), 5, 0)));
         edtRBECtaContableNombre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRBECtaContableNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRBECtaContableNombre_Enabled), 5, 0)));
         edtRBECtaContableNivel_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRBECtaContableNivel_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRBECtaContableNivel_Enabled), 5, 0)));
         edtRBECtaContableGrupo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRBECtaContableGrupo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRBECtaContableGrupo_Enabled), 5, 0)));
         edtRBECtaContableCodigoRoot_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRBECtaContableCodigoRoot_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRBECtaContableCodigoRoot_Enabled), 5, 0)));
         edtRBECtaContableSaldo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRBECtaContableSaldo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRBECtaContableSaldo_Enabled), 5, 0)));
         edtRBENivel1_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRBENivel1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRBENivel1_Enabled), 5, 0)));
         edtRBENivel2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRBENivel2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRBENivel2_Enabled), 5, 0)));
         edtRBENivel3_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRBENivel3_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRBENivel3_Enabled), 5, 0)));
         edtRBENivel4_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRBENivel4_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRBENivel4_Enabled), 5, 0)));
         edtRBENivel5_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRBENivel5_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRBENivel5_Enabled), 5, 0)));
         edtUsuarioCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioCodigo_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1J0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("repbalanceestado.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z302RBECtaContableCodigo", StringUtil.RTrim( Z302RBECtaContableCodigo));
         GxWebStd.gx_hidden_field( context, "Z303RBECtaContableNombre", StringUtil.RTrim( Z303RBECtaContableNombre));
         GxWebStd.gx_hidden_field( context, "Z304RBECtaContableNivel", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z304RBECtaContableNivel), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z305RBECtaContableGrupo", StringUtil.RTrim( Z305RBECtaContableGrupo));
         GxWebStd.gx_hidden_field( context, "Z306RBECtaContableCodigoRoot", StringUtil.RTrim( Z306RBECtaContableCodigoRoot));
         GxWebStd.gx_hidden_field( context, "Z307RBECtaContableSaldo", StringUtil.LTrim( StringUtil.NToC( Z307RBECtaContableSaldo, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z308RBENivel1", StringUtil.LTrim( StringUtil.NToC( Z308RBENivel1, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z309RBENivel2", StringUtil.LTrim( StringUtil.NToC( Z309RBENivel2, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z310RBENivel3", StringUtil.LTrim( StringUtil.NToC( Z310RBENivel3, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z311RBENivel4", StringUtil.LTrim( StringUtil.NToC( Z311RBENivel4, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z312RBENivel5", StringUtil.LTrim( StringUtil.NToC( Z312RBENivel5, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z4UsuarioCodigo", StringUtil.RTrim( Z4UsuarioCodigo));
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
         return "RepBalanceEstado" ;
      }

      public override String GetPgmdesc( )
      {
         return "Tabla de reporte de Balance General y Estado de Resultados" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("repbalanceestado.aspx")  ;
      }

      protected void InitializeNonKey1J71( )
      {
         A303RBECtaContableNombre = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A303RBECtaContableNombre", A303RBECtaContableNombre);
         A304RBECtaContableNivel = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A304RBECtaContableNivel", StringUtil.Str( (decimal)(A304RBECtaContableNivel), 1, 0));
         A305RBECtaContableGrupo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A305RBECtaContableGrupo", A305RBECtaContableGrupo);
         A306RBECtaContableCodigoRoot = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306RBECtaContableCodigoRoot", A306RBECtaContableCodigoRoot);
         A307RBECtaContableSaldo = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307RBECtaContableSaldo", StringUtil.LTrim( StringUtil.Str( A307RBECtaContableSaldo, 17, 2)));
         A308RBENivel1 = 0 ;
         n308RBENivel1 = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308RBENivel1", StringUtil.LTrim( StringUtil.Str( A308RBENivel1, 17, 2)));
         n308RBENivel1 = ((Convert.ToDecimal(0)==A308RBENivel1) ? true : false) ;
         A309RBENivel2 = 0 ;
         n309RBENivel2 = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309RBENivel2", StringUtil.LTrim( StringUtil.Str( A309RBENivel2, 17, 2)));
         n309RBENivel2 = ((Convert.ToDecimal(0)==A309RBENivel2) ? true : false) ;
         A310RBENivel3 = 0 ;
         n310RBENivel3 = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310RBENivel3", StringUtil.LTrim( StringUtil.Str( A310RBENivel3, 17, 2)));
         n310RBENivel3 = ((Convert.ToDecimal(0)==A310RBENivel3) ? true : false) ;
         A311RBENivel4 = 0 ;
         n311RBENivel4 = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311RBENivel4", StringUtil.LTrim( StringUtil.Str( A311RBENivel4, 17, 2)));
         n311RBENivel4 = ((Convert.ToDecimal(0)==A311RBENivel4) ? true : false) ;
         A312RBENivel5 = 0 ;
         n312RBENivel5 = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312RBENivel5", StringUtil.LTrim( StringUtil.Str( A312RBENivel5, 17, 2)));
         n312RBENivel5 = ((Convert.ToDecimal(0)==A312RBENivel5) ? true : false) ;
         A4UsuarioCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
      }

      protected void InitAll1J71( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A302RBECtaContableCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A302RBECtaContableCodigo", A302RBECtaContableCodigo);
         InitializeNonKey1J71( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?157587");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("repbalanceestado.js", "?157587");
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
         lblTextblockrbectacontablecodigo_Internalname = "TEXTBLOCKRBECTACONTABLECODIGO" ;
         edtRBECtaContableCodigo_Internalname = "RBECTACONTABLECODIGO" ;
         lblTextblockrbectacontablenombre_Internalname = "TEXTBLOCKRBECTACONTABLENOMBRE" ;
         edtRBECtaContableNombre_Internalname = "RBECTACONTABLENOMBRE" ;
         lblTextblockrbectacontablenivel_Internalname = "TEXTBLOCKRBECTACONTABLENIVEL" ;
         edtRBECtaContableNivel_Internalname = "RBECTACONTABLENIVEL" ;
         lblTextblockrbectacontablegrupo_Internalname = "TEXTBLOCKRBECTACONTABLEGRUPO" ;
         edtRBECtaContableGrupo_Internalname = "RBECTACONTABLEGRUPO" ;
         lblTextblockrbectacontablecodigoroot_Internalname = "TEXTBLOCKRBECTACONTABLECODIGOROOT" ;
         edtRBECtaContableCodigoRoot_Internalname = "RBECTACONTABLECODIGOROOT" ;
         lblTextblockrbectacontablesaldo_Internalname = "TEXTBLOCKRBECTACONTABLESALDO" ;
         edtRBECtaContableSaldo_Internalname = "RBECTACONTABLESALDO" ;
         lblTextblockrbenivel1_Internalname = "TEXTBLOCKRBENIVEL1" ;
         edtRBENivel1_Internalname = "RBENIVEL1" ;
         lblTextblockrbenivel2_Internalname = "TEXTBLOCKRBENIVEL2" ;
         edtRBENivel2_Internalname = "RBENIVEL2" ;
         lblTextblockrbenivel3_Internalname = "TEXTBLOCKRBENIVEL3" ;
         edtRBENivel3_Internalname = "RBENIVEL3" ;
         lblTextblockrbenivel4_Internalname = "TEXTBLOCKRBENIVEL4" ;
         edtRBENivel4_Internalname = "RBENIVEL4" ;
         lblTextblockrbenivel5_Internalname = "TEXTBLOCKRBENIVEL5" ;
         edtRBENivel5_Internalname = "RBENIVEL5" ;
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
         imgprompt_41_Internalname = "PROMPT_41" ;
         imgprompt_4_Internalname = "PROMPT_4" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Tabla de reporte de Balance General y Estado de Resultados" ;
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
         imgprompt_4_Visible = 1 ;
         imgprompt_4_Link = "" ;
         edtUsuarioCodigo_Jsonclick = "" ;
         edtUsuarioCodigo_Enabled = 1 ;
         edtRBENivel5_Jsonclick = "" ;
         edtRBENivel5_Enabled = 1 ;
         edtRBENivel4_Jsonclick = "" ;
         edtRBENivel4_Enabled = 1 ;
         edtRBENivel3_Jsonclick = "" ;
         edtRBENivel3_Enabled = 1 ;
         edtRBENivel2_Jsonclick = "" ;
         edtRBENivel2_Enabled = 1 ;
         edtRBENivel1_Jsonclick = "" ;
         edtRBENivel1_Enabled = 1 ;
         edtRBECtaContableSaldo_Jsonclick = "" ;
         edtRBECtaContableSaldo_Enabled = 1 ;
         edtRBECtaContableCodigoRoot_Jsonclick = "" ;
         edtRBECtaContableCodigoRoot_Enabled = 1 ;
         edtRBECtaContableGrupo_Jsonclick = "" ;
         edtRBECtaContableGrupo_Enabled = 1 ;
         edtRBECtaContableNivel_Jsonclick = "" ;
         edtRBECtaContableNivel_Enabled = 1 ;
         edtRBECtaContableNombre_Jsonclick = "" ;
         edtRBECtaContableNombre_Enabled = 1 ;
         edtRBECtaContableCodigo_Jsonclick = "" ;
         edtRBECtaContableCodigo_Enabled = 1 ;
         imgprompt_41_Visible = 1 ;
         imgprompt_41_Link = "" ;
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
         /* Using cursor T001J17 */
         pr_default.execute(15, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(15) == 101) )
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
         pr_default.close(15);
         GX_FocusControl = edtRBECtaContableNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Clinicacodigo( String GX_Parm1 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         /* Using cursor T001J17 */
         pr_default.execute(15, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(15) == 101) )
         {
            AnyError41 = 1 ;
            GX_msglist.addItem("No existe 'Clínica Médica'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( AnyError41 == 0 )
         {
         }
         pr_default.close(15);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Rbectacontablecodigo( String GX_Parm1 ,
                                              String GX_Parm2 ,
                                              String GX_Parm3 ,
                                              short GX_Parm4 ,
                                              String GX_Parm5 ,
                                              String GX_Parm6 ,
                                              decimal GX_Parm7 ,
                                              decimal GX_Parm8 ,
                                              decimal GX_Parm9 ,
                                              decimal GX_Parm10 ,
                                              decimal GX_Parm11 ,
                                              decimal GX_Parm12 ,
                                              String GX_Parm13 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A302RBECtaContableCodigo = GX_Parm2 ;
         A303RBECtaContableNombre = GX_Parm3 ;
         A304RBECtaContableNivel = GX_Parm4 ;
         A305RBECtaContableGrupo = GX_Parm5 ;
         A306RBECtaContableCodigoRoot = GX_Parm6 ;
         A307RBECtaContableSaldo = GX_Parm7 ;
         A308RBENivel1 = GX_Parm8 ;
         n308RBENivel1 = false ;
         A309RBENivel2 = GX_Parm9 ;
         n309RBENivel2 = false ;
         A310RBENivel3 = GX_Parm10 ;
         n310RBENivel3 = false ;
         A311RBENivel4 = GX_Parm11 ;
         n311RBENivel4 = false ;
         A312RBENivel5 = GX_Parm12 ;
         n312RBENivel5 = false ;
         A4UsuarioCodigo = GX_Parm13 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A303RBECtaContableNombre)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A304RBECtaContableNivel), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A305RBECtaContableGrupo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A306RBECtaContableCodigoRoot)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A307RBECtaContableSaldo, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A308RBENivel1, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A309RBENivel2, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A310RBENivel3, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A311RBENivel4, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A312RBENivel5, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A4UsuarioCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z302RBECtaContableCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z303RBECtaContableNombre)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z304RBECtaContableNivel), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z305RBECtaContableGrupo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z306RBECtaContableCodigoRoot)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z307RBECtaContableSaldo, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z308RBENivel1, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z309RBENivel2, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z310RBENivel3, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z311RBENivel4, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z312RBENivel5, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z4UsuarioCodigo)));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Usuariocodigo( String GX_Parm1 )
      {
         A4UsuarioCodigo = GX_Parm1 ;
         /* Using cursor T001J18 */
         pr_default.execute(16, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(16) == 101) )
         {
            AnyError4 = 1 ;
            GX_msglist.addItem("No existe 'Usuarios'.", "ForeignKeyNotFound", 1, "USUARIOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtUsuarioCodigo_Internalname ;
         }
         if ( AnyError4 == 0 )
         {
         }
         pr_default.close(16);
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
         pr_default.close(14);
         pr_default.close(9);
         pr_default.close(8);
         pr_default.close(15);
         pr_default.close(16);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
         A4UsuarioCodigo = "" ;
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
         lblTextblockrbectacontablecodigo_Jsonclick = "" ;
         A302RBECtaContableCodigo = "" ;
         lblTextblockrbectacontablenombre_Jsonclick = "" ;
         A303RBECtaContableNombre = "" ;
         lblTextblockrbectacontablenivel_Jsonclick = "" ;
         lblTextblockrbectacontablegrupo_Jsonclick = "" ;
         A305RBECtaContableGrupo = "" ;
         lblTextblockrbectacontablecodigoroot_Jsonclick = "" ;
         A306RBECtaContableCodigoRoot = "" ;
         lblTextblockrbectacontablesaldo_Jsonclick = "" ;
         lblTextblockrbenivel1_Jsonclick = "" ;
         lblTextblockrbenivel2_Jsonclick = "" ;
         lblTextblockrbenivel3_Jsonclick = "" ;
         lblTextblockrbenivel4_Jsonclick = "" ;
         lblTextblockrbenivel5_Jsonclick = "" ;
         lblTextblockusuariocodigo_Jsonclick = "" ;
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
         Z302RBECtaContableCodigo = "" ;
         Z303RBECtaContableNombre = "" ;
         Z305RBECtaContableGrupo = "" ;
         Z306RBECtaContableCodigoRoot = "" ;
         Z4UsuarioCodigo = "" ;
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T001J6_A302RBECtaContableCodigo = new String[] {""} ;
         T001J6_A303RBECtaContableNombre = new String[] {""} ;
         T001J6_A304RBECtaContableNivel = new short[1] ;
         T001J6_A305RBECtaContableGrupo = new String[] {""} ;
         T001J6_A306RBECtaContableCodigoRoot = new String[] {""} ;
         T001J6_A307RBECtaContableSaldo = new decimal[1] ;
         T001J6_A308RBENivel1 = new decimal[1] ;
         T001J6_n308RBENivel1 = new bool[] {false} ;
         T001J6_A309RBENivel2 = new decimal[1] ;
         T001J6_n309RBENivel2 = new bool[] {false} ;
         T001J6_A310RBENivel3 = new decimal[1] ;
         T001J6_n310RBENivel3 = new bool[] {false} ;
         T001J6_A311RBENivel4 = new decimal[1] ;
         T001J6_n311RBENivel4 = new bool[] {false} ;
         T001J6_A312RBENivel5 = new decimal[1] ;
         T001J6_n312RBENivel5 = new bool[] {false} ;
         T001J6_A41ClinicaCodigo = new String[] {""} ;
         T001J6_A4UsuarioCodigo = new String[] {""} ;
         T001J4_A41ClinicaCodigo = new String[] {""} ;
         T001J5_A4UsuarioCodigo = new String[] {""} ;
         T001J7_A41ClinicaCodigo = new String[] {""} ;
         T001J8_A4UsuarioCodigo = new String[] {""} ;
         T001J9_A41ClinicaCodigo = new String[] {""} ;
         T001J9_A302RBECtaContableCodigo = new String[] {""} ;
         T001J3_A302RBECtaContableCodigo = new String[] {""} ;
         T001J3_A303RBECtaContableNombre = new String[] {""} ;
         T001J3_A304RBECtaContableNivel = new short[1] ;
         T001J3_A305RBECtaContableGrupo = new String[] {""} ;
         T001J3_A306RBECtaContableCodigoRoot = new String[] {""} ;
         T001J3_A307RBECtaContableSaldo = new decimal[1] ;
         T001J3_A308RBENivel1 = new decimal[1] ;
         T001J3_n308RBENivel1 = new bool[] {false} ;
         T001J3_A309RBENivel2 = new decimal[1] ;
         T001J3_n309RBENivel2 = new bool[] {false} ;
         T001J3_A310RBENivel3 = new decimal[1] ;
         T001J3_n310RBENivel3 = new bool[] {false} ;
         T001J3_A311RBENivel4 = new decimal[1] ;
         T001J3_n311RBENivel4 = new bool[] {false} ;
         T001J3_A312RBENivel5 = new decimal[1] ;
         T001J3_n312RBENivel5 = new bool[] {false} ;
         T001J3_A41ClinicaCodigo = new String[] {""} ;
         T001J3_A4UsuarioCodigo = new String[] {""} ;
         sMode71 = "" ;
         T001J10_A41ClinicaCodigo = new String[] {""} ;
         T001J10_A302RBECtaContableCodigo = new String[] {""} ;
         T001J11_A41ClinicaCodigo = new String[] {""} ;
         T001J11_A302RBECtaContableCodigo = new String[] {""} ;
         T001J12_A302RBECtaContableCodigo = new String[] {""} ;
         T001J12_A303RBECtaContableNombre = new String[] {""} ;
         T001J12_A304RBECtaContableNivel = new short[1] ;
         T001J12_A305RBECtaContableGrupo = new String[] {""} ;
         T001J12_A306RBECtaContableCodigoRoot = new String[] {""} ;
         T001J12_A307RBECtaContableSaldo = new decimal[1] ;
         T001J12_A308RBENivel1 = new decimal[1] ;
         T001J12_n308RBENivel1 = new bool[] {false} ;
         T001J12_A309RBENivel2 = new decimal[1] ;
         T001J12_n309RBENivel2 = new bool[] {false} ;
         T001J12_A310RBENivel3 = new decimal[1] ;
         T001J12_n310RBENivel3 = new bool[] {false} ;
         T001J12_A311RBENivel4 = new decimal[1] ;
         T001J12_n311RBENivel4 = new bool[] {false} ;
         T001J12_A312RBENivel5 = new decimal[1] ;
         T001J12_n312RBENivel5 = new bool[] {false} ;
         T001J12_A41ClinicaCodigo = new String[] {""} ;
         T001J12_A4UsuarioCodigo = new String[] {""} ;
         T001J16_A41ClinicaCodigo = new String[] {""} ;
         T001J16_A302RBECtaContableCodigo = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         T001J17_A41ClinicaCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         T001J18_A4UsuarioCodigo = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.repbalanceestado__default(),
            new Object[][] {
                new Object[] {
               T001J2_A302RBECtaContableCodigo, T001J2_A303RBECtaContableNombre, T001J2_A304RBECtaContableNivel, T001J2_A305RBECtaContableGrupo, T001J2_A306RBECtaContableCodigoRoot, T001J2_A307RBECtaContableSaldo, T001J2_A308RBENivel1, T001J2_n308RBENivel1, T001J2_A309RBENivel2, T001J2_n309RBENivel2,
               T001J2_A310RBENivel3, T001J2_n310RBENivel3, T001J2_A311RBENivel4, T001J2_n311RBENivel4, T001J2_A312RBENivel5, T001J2_n312RBENivel5, T001J2_A41ClinicaCodigo, T001J2_A4UsuarioCodigo
               }
               , new Object[] {
               T001J3_A302RBECtaContableCodigo, T001J3_A303RBECtaContableNombre, T001J3_A304RBECtaContableNivel, T001J3_A305RBECtaContableGrupo, T001J3_A306RBECtaContableCodigoRoot, T001J3_A307RBECtaContableSaldo, T001J3_A308RBENivel1, T001J3_n308RBENivel1, T001J3_A309RBENivel2, T001J3_n309RBENivel2,
               T001J3_A310RBENivel3, T001J3_n310RBENivel3, T001J3_A311RBENivel4, T001J3_n311RBENivel4, T001J3_A312RBENivel5, T001J3_n312RBENivel5, T001J3_A41ClinicaCodigo, T001J3_A4UsuarioCodigo
               }
               , new Object[] {
               T001J4_A41ClinicaCodigo
               }
               , new Object[] {
               T001J5_A4UsuarioCodigo
               }
               , new Object[] {
               T001J6_A302RBECtaContableCodigo, T001J6_A303RBECtaContableNombre, T001J6_A304RBECtaContableNivel, T001J6_A305RBECtaContableGrupo, T001J6_A306RBECtaContableCodigoRoot, T001J6_A307RBECtaContableSaldo, T001J6_A308RBENivel1, T001J6_n308RBENivel1, T001J6_A309RBENivel2, T001J6_n309RBENivel2,
               T001J6_A310RBENivel3, T001J6_n310RBENivel3, T001J6_A311RBENivel4, T001J6_n311RBENivel4, T001J6_A312RBENivel5, T001J6_n312RBENivel5, T001J6_A41ClinicaCodigo, T001J6_A4UsuarioCodigo
               }
               , new Object[] {
               T001J7_A41ClinicaCodigo
               }
               , new Object[] {
               T001J8_A4UsuarioCodigo
               }
               , new Object[] {
               T001J9_A41ClinicaCodigo, T001J9_A302RBECtaContableCodigo
               }
               , new Object[] {
               T001J10_A41ClinicaCodigo, T001J10_A302RBECtaContableCodigo
               }
               , new Object[] {
               T001J11_A41ClinicaCodigo, T001J11_A302RBECtaContableCodigo
               }
               , new Object[] {
               T001J12_A302RBECtaContableCodigo, T001J12_A303RBECtaContableNombre, T001J12_A304RBECtaContableNivel, T001J12_A305RBECtaContableGrupo, T001J12_A306RBECtaContableCodigoRoot, T001J12_A307RBECtaContableSaldo, T001J12_A308RBENivel1, T001J12_n308RBENivel1, T001J12_A309RBENivel2, T001J12_n309RBENivel2,
               T001J12_A310RBENivel3, T001J12_n310RBENivel3, T001J12_A311RBENivel4, T001J12_n311RBENivel4, T001J12_A312RBENivel5, T001J12_n312RBENivel5, T001J12_A41ClinicaCodigo, T001J12_A4UsuarioCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001J16_A41ClinicaCodigo, T001J16_A302RBECtaContableCodigo
               }
               , new Object[] {
               T001J17_A41ClinicaCodigo
               }
               , new Object[] {
               T001J18_A4UsuarioCodigo
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
      private short A304RBECtaContableNivel ;
      private short Z304RBECtaContableNivel ;
      private short GX_JID ;
      private short RcdFound71 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int imgprompt_41_Visible ;
      private int edtRBECtaContableCodigo_Enabled ;
      private int edtRBECtaContableNombre_Enabled ;
      private int edtRBECtaContableNivel_Enabled ;
      private int edtRBECtaContableGrupo_Enabled ;
      private int edtRBECtaContableCodigoRoot_Enabled ;
      private int edtRBECtaContableSaldo_Enabled ;
      private int edtRBENivel1_Enabled ;
      private int edtRBENivel2_Enabled ;
      private int edtRBENivel3_Enabled ;
      private int edtRBENivel4_Enabled ;
      private int edtRBENivel5_Enabled ;
      private int edtUsuarioCodigo_Enabled ;
      private int imgprompt_4_Visible ;
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
      private int AnyError4 ;
      private int idxLst ;
      private decimal A307RBECtaContableSaldo ;
      private decimal A308RBENivel1 ;
      private decimal A309RBENivel2 ;
      private decimal A310RBENivel3 ;
      private decimal A311RBENivel4 ;
      private decimal A312RBENivel5 ;
      private decimal Z307RBECtaContableSaldo ;
      private decimal Z308RBENivel1 ;
      private decimal Z309RBENivel2 ;
      private decimal Z310RBENivel3 ;
      private decimal Z311RBENivel4 ;
      private decimal Z312RBENivel5 ;
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
      private String lblTextblockrbectacontablecodigo_Internalname ;
      private String lblTextblockrbectacontablecodigo_Jsonclick ;
      private String edtRBECtaContableCodigo_Internalname ;
      private String edtRBECtaContableCodigo_Jsonclick ;
      private String lblTextblockrbectacontablenombre_Internalname ;
      private String lblTextblockrbectacontablenombre_Jsonclick ;
      private String edtRBECtaContableNombre_Internalname ;
      private String edtRBECtaContableNombre_Jsonclick ;
      private String lblTextblockrbectacontablenivel_Internalname ;
      private String lblTextblockrbectacontablenivel_Jsonclick ;
      private String edtRBECtaContableNivel_Internalname ;
      private String edtRBECtaContableNivel_Jsonclick ;
      private String lblTextblockrbectacontablegrupo_Internalname ;
      private String lblTextblockrbectacontablegrupo_Jsonclick ;
      private String edtRBECtaContableGrupo_Internalname ;
      private String edtRBECtaContableGrupo_Jsonclick ;
      private String lblTextblockrbectacontablecodigoroot_Internalname ;
      private String lblTextblockrbectacontablecodigoroot_Jsonclick ;
      private String edtRBECtaContableCodigoRoot_Internalname ;
      private String edtRBECtaContableCodigoRoot_Jsonclick ;
      private String lblTextblockrbectacontablesaldo_Internalname ;
      private String lblTextblockrbectacontablesaldo_Jsonclick ;
      private String edtRBECtaContableSaldo_Internalname ;
      private String edtRBECtaContableSaldo_Jsonclick ;
      private String lblTextblockrbenivel1_Internalname ;
      private String lblTextblockrbenivel1_Jsonclick ;
      private String edtRBENivel1_Internalname ;
      private String edtRBENivel1_Jsonclick ;
      private String lblTextblockrbenivel2_Internalname ;
      private String lblTextblockrbenivel2_Jsonclick ;
      private String edtRBENivel2_Internalname ;
      private String edtRBENivel2_Jsonclick ;
      private String lblTextblockrbenivel3_Internalname ;
      private String lblTextblockrbenivel3_Jsonclick ;
      private String edtRBENivel3_Internalname ;
      private String edtRBENivel3_Jsonclick ;
      private String lblTextblockrbenivel4_Internalname ;
      private String lblTextblockrbenivel4_Jsonclick ;
      private String edtRBENivel4_Internalname ;
      private String edtRBENivel4_Jsonclick ;
      private String lblTextblockrbenivel5_Internalname ;
      private String lblTextblockrbenivel5_Jsonclick ;
      private String edtRBENivel5_Internalname ;
      private String edtRBENivel5_Jsonclick ;
      private String lblTextblockusuariocodigo_Internalname ;
      private String lblTextblockusuariocodigo_Jsonclick ;
      private String edtUsuarioCodigo_Internalname ;
      private String edtUsuarioCodigo_Jsonclick ;
      private String imgprompt_4_Internalname ;
      private String imgprompt_4_Link ;
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
      private String sMode71 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n308RBENivel1 ;
      private bool n309RBENivel2 ;
      private bool n310RBENivel3 ;
      private bool n311RBENivel4 ;
      private bool n312RBENivel5 ;
      private bool Gx_longc ;
      private String A41ClinicaCodigo ;
      private String A4UsuarioCodigo ;
      private String A302RBECtaContableCodigo ;
      private String A303RBECtaContableNombre ;
      private String A305RBECtaContableGrupo ;
      private String A306RBECtaContableCodigoRoot ;
      private String Z41ClinicaCodigo ;
      private String Z302RBECtaContableCodigo ;
      private String Z303RBECtaContableNombre ;
      private String Z305RBECtaContableGrupo ;
      private String Z306RBECtaContableCodigoRoot ;
      private String Z4UsuarioCodigo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T001J6_A302RBECtaContableCodigo ;
      private String[] T001J6_A303RBECtaContableNombre ;
      private short[] T001J6_A304RBECtaContableNivel ;
      private String[] T001J6_A305RBECtaContableGrupo ;
      private String[] T001J6_A306RBECtaContableCodigoRoot ;
      private decimal[] T001J6_A307RBECtaContableSaldo ;
      private decimal[] T001J6_A308RBENivel1 ;
      private bool[] T001J6_n308RBENivel1 ;
      private decimal[] T001J6_A309RBENivel2 ;
      private bool[] T001J6_n309RBENivel2 ;
      private decimal[] T001J6_A310RBENivel3 ;
      private bool[] T001J6_n310RBENivel3 ;
      private decimal[] T001J6_A311RBENivel4 ;
      private bool[] T001J6_n311RBENivel4 ;
      private decimal[] T001J6_A312RBENivel5 ;
      private bool[] T001J6_n312RBENivel5 ;
      private String[] T001J6_A41ClinicaCodigo ;
      private String[] T001J6_A4UsuarioCodigo ;
      private String[] T001J4_A41ClinicaCodigo ;
      private String[] T001J5_A4UsuarioCodigo ;
      private String[] T001J7_A41ClinicaCodigo ;
      private String[] T001J8_A4UsuarioCodigo ;
      private String[] T001J9_A41ClinicaCodigo ;
      private String[] T001J9_A302RBECtaContableCodigo ;
      private String[] T001J3_A302RBECtaContableCodigo ;
      private String[] T001J3_A303RBECtaContableNombre ;
      private short[] T001J3_A304RBECtaContableNivel ;
      private String[] T001J3_A305RBECtaContableGrupo ;
      private String[] T001J3_A306RBECtaContableCodigoRoot ;
      private decimal[] T001J3_A307RBECtaContableSaldo ;
      private decimal[] T001J3_A308RBENivel1 ;
      private bool[] T001J3_n308RBENivel1 ;
      private decimal[] T001J3_A309RBENivel2 ;
      private bool[] T001J3_n309RBENivel2 ;
      private decimal[] T001J3_A310RBENivel3 ;
      private bool[] T001J3_n310RBENivel3 ;
      private decimal[] T001J3_A311RBENivel4 ;
      private bool[] T001J3_n311RBENivel4 ;
      private decimal[] T001J3_A312RBENivel5 ;
      private bool[] T001J3_n312RBENivel5 ;
      private String[] T001J3_A41ClinicaCodigo ;
      private String[] T001J3_A4UsuarioCodigo ;
      private String[] T001J10_A41ClinicaCodigo ;
      private String[] T001J10_A302RBECtaContableCodigo ;
      private String[] T001J11_A41ClinicaCodigo ;
      private String[] T001J11_A302RBECtaContableCodigo ;
      private String[] T001J12_A302RBECtaContableCodigo ;
      private String[] T001J12_A303RBECtaContableNombre ;
      private short[] T001J12_A304RBECtaContableNivel ;
      private String[] T001J12_A305RBECtaContableGrupo ;
      private String[] T001J12_A306RBECtaContableCodigoRoot ;
      private decimal[] T001J12_A307RBECtaContableSaldo ;
      private decimal[] T001J12_A308RBENivel1 ;
      private bool[] T001J12_n308RBENivel1 ;
      private decimal[] T001J12_A309RBENivel2 ;
      private bool[] T001J12_n309RBENivel2 ;
      private decimal[] T001J12_A310RBENivel3 ;
      private bool[] T001J12_n310RBENivel3 ;
      private decimal[] T001J12_A311RBENivel4 ;
      private bool[] T001J12_n311RBENivel4 ;
      private decimal[] T001J12_A312RBENivel5 ;
      private bool[] T001J12_n312RBENivel5 ;
      private String[] T001J12_A41ClinicaCodigo ;
      private String[] T001J12_A4UsuarioCodigo ;
      private String[] T001J16_A41ClinicaCodigo ;
      private String[] T001J16_A302RBECtaContableCodigo ;
      private String[] T001J17_A41ClinicaCodigo ;
      private String[] T001J18_A4UsuarioCodigo ;
      private String[] T001J2_A302RBECtaContableCodigo ;
      private String[] T001J2_A303RBECtaContableNombre ;
      private short[] T001J2_A304RBECtaContableNivel ;
      private String[] T001J2_A305RBECtaContableGrupo ;
      private String[] T001J2_A306RBECtaContableCodigoRoot ;
      private decimal[] T001J2_A307RBECtaContableSaldo ;
      private decimal[] T001J2_A308RBENivel1 ;
      private decimal[] T001J2_A309RBENivel2 ;
      private decimal[] T001J2_A310RBENivel3 ;
      private decimal[] T001J2_A311RBENivel4 ;
      private decimal[] T001J2_A312RBENivel5 ;
      private String[] T001J2_A41ClinicaCodigo ;
      private String[] T001J2_A4UsuarioCodigo ;
      private bool[] T001J2_n308RBENivel1 ;
      private bool[] T001J2_n309RBENivel2 ;
      private bool[] T001J2_n310RBENivel3 ;
      private bool[] T001J2_n311RBENivel4 ;
      private bool[] T001J2_n312RBENivel5 ;
      private GXWebForm Form ;
   }

   public class repbalanceestado__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT001J2 ;
          prmT001J2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@RBECtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001J6 ;
          prmT001J6 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@RBECtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001J4 ;
          prmT001J4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001J5 ;
          prmT001J5 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001J7 ;
          prmT001J7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001J8 ;
          prmT001J8 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001J9 ;
          prmT001J9 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@RBECtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001J3 ;
          prmT001J3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@RBECtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001J10 ;
          prmT001J10 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@RBECtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001J11 ;
          prmT001J11 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@RBECtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001J12 ;
          prmT001J12 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@RBECtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001J13 ;
          prmT001J13 = new Object[] {
          new Object[] {"@RBECtaContableCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@RBECtaContableNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@RBECtaContableNivel",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@RBECtaContableGrupo",SqlDbType.VarChar,15,0} ,
          new Object[] {"@RBECtaContableCodigoRoot",SqlDbType.VarChar,10,0} ,
          new Object[] {"@RBECtaContableSaldo",SqlDbType.Decimal,17,2} ,
          new Object[] {"@RBENivel1",SqlDbType.Decimal,17,2} ,
          new Object[] {"@RBENivel2",SqlDbType.Decimal,17,2} ,
          new Object[] {"@RBENivel3",SqlDbType.Decimal,17,2} ,
          new Object[] {"@RBENivel4",SqlDbType.Decimal,17,2} ,
          new Object[] {"@RBENivel5",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001J14 ;
          prmT001J14 = new Object[] {
          new Object[] {"@RBECtaContableNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@RBECtaContableNivel",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@RBECtaContableGrupo",SqlDbType.VarChar,15,0} ,
          new Object[] {"@RBECtaContableCodigoRoot",SqlDbType.VarChar,10,0} ,
          new Object[] {"@RBECtaContableSaldo",SqlDbType.Decimal,17,2} ,
          new Object[] {"@RBENivel1",SqlDbType.Decimal,17,2} ,
          new Object[] {"@RBENivel2",SqlDbType.Decimal,17,2} ,
          new Object[] {"@RBENivel3",SqlDbType.Decimal,17,2} ,
          new Object[] {"@RBENivel4",SqlDbType.Decimal,17,2} ,
          new Object[] {"@RBENivel5",SqlDbType.Decimal,17,2} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@RBECtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001J15 ;
          prmT001J15 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@RBECtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001J16 ;
          prmT001J16 = new Object[] {
          } ;
          Object[] prmT001J17 ;
          prmT001J17 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001J18 ;
          prmT001J18 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T001J2", "SELECT [RBECtaContableCodigo], [RBECtaContableNombre], [RBECtaContableNivel], [RBECtaContableGrupo], [RBECtaContableCodigoRoot], [RBECtaContableSaldo], [RBENivel1], [RBENivel2], [RBENivel3], [RBENivel4], [RBENivel5], [ClinicaCodigo], [UsuarioCodigo] FROM [RepBalanceEstado] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [RBECtaContableCodigo] = @RBECtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001J2,1,0,true,false )
             ,new CursorDef("T001J3", "SELECT [RBECtaContableCodigo], [RBECtaContableNombre], [RBECtaContableNivel], [RBECtaContableGrupo], [RBECtaContableCodigoRoot], [RBECtaContableSaldo], [RBENivel1], [RBENivel2], [RBENivel3], [RBENivel4], [RBENivel5], [ClinicaCodigo], [UsuarioCodigo] FROM [RepBalanceEstado] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [RBECtaContableCodigo] = @RBECtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001J3,1,0,true,false )
             ,new CursorDef("T001J4", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001J4,1,0,true,false )
             ,new CursorDef("T001J5", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001J5,1,0,true,false )
             ,new CursorDef("T001J6", "SELECT TM1.[RBECtaContableCodigo], TM1.[RBECtaContableNombre], TM1.[RBECtaContableNivel], TM1.[RBECtaContableGrupo], TM1.[RBECtaContableCodigoRoot], TM1.[RBECtaContableSaldo], TM1.[RBENivel1], TM1.[RBENivel2], TM1.[RBENivel3], TM1.[RBENivel4], TM1.[RBENivel5], TM1.[ClinicaCodigo], TM1.[UsuarioCodigo] FROM [RepBalanceEstado] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[RBECtaContableCodigo] = @RBECtaContableCodigo ORDER BY TM1.[ClinicaCodigo], TM1.[RBECtaContableCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001J6,100,0,true,false )
             ,new CursorDef("T001J7", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001J7,1,0,true,false )
             ,new CursorDef("T001J8", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001J8,1,0,true,false )
             ,new CursorDef("T001J9", "SELECT [ClinicaCodigo], [RBECtaContableCodigo] FROM [RepBalanceEstado] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [RBECtaContableCodigo] = @RBECtaContableCodigo  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001J9,1,0,true,false )
             ,new CursorDef("T001J10", "SELECT TOP 1 [ClinicaCodigo], [RBECtaContableCodigo] FROM [RepBalanceEstado] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [RBECtaContableCodigo] > @RBECtaContableCodigo) ORDER BY [ClinicaCodigo], [RBECtaContableCodigo]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001J10,1,0,true,true )
             ,new CursorDef("T001J11", "SELECT TOP 1 [ClinicaCodigo], [RBECtaContableCodigo] FROM [RepBalanceEstado] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [RBECtaContableCodigo] < @RBECtaContableCodigo) ORDER BY [ClinicaCodigo] DESC, [RBECtaContableCodigo] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001J11,1,0,true,true )
             ,new CursorDef("T001J12", "SELECT [RBECtaContableCodigo], [RBECtaContableNombre], [RBECtaContableNivel], [RBECtaContableGrupo], [RBECtaContableCodigoRoot], [RBECtaContableSaldo], [RBENivel1], [RBENivel2], [RBENivel3], [RBENivel4], [RBENivel5], [ClinicaCodigo], [UsuarioCodigo] FROM [RepBalanceEstado] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [RBECtaContableCodigo] = @RBECtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001J12,1,0,true,false )
             ,new CursorDef("T001J13", "INSERT INTO [RepBalanceEstado] ([RBECtaContableCodigo], [RBECtaContableNombre], [RBECtaContableNivel], [RBECtaContableGrupo], [RBECtaContableCodigoRoot], [RBECtaContableSaldo], [RBENivel1], [RBENivel2], [RBENivel3], [RBENivel4], [RBENivel5], [ClinicaCodigo], [UsuarioCodigo]) VALUES (@RBECtaContableCodigo, @RBECtaContableNombre, @RBECtaContableNivel, @RBECtaContableGrupo, @RBECtaContableCodigoRoot, @RBECtaContableSaldo, @RBENivel1, @RBENivel2, @RBENivel3, @RBENivel4, @RBENivel5, @ClinicaCodigo, @UsuarioCodigo)", GxErrorMask.GX_NOMASK,prmT001J13)
             ,new CursorDef("T001J14", "UPDATE [RepBalanceEstado] SET [RBECtaContableNombre]=@RBECtaContableNombre, [RBECtaContableNivel]=@RBECtaContableNivel, [RBECtaContableGrupo]=@RBECtaContableGrupo, [RBECtaContableCodigoRoot]=@RBECtaContableCodigoRoot, [RBECtaContableSaldo]=@RBECtaContableSaldo, [RBENivel1]=@RBENivel1, [RBENivel2]=@RBENivel2, [RBENivel3]=@RBENivel3, [RBENivel4]=@RBENivel4, [RBENivel5]=@RBENivel5, [UsuarioCodigo]=@UsuarioCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [RBECtaContableCodigo] = @RBECtaContableCodigo", GxErrorMask.GX_NOMASK,prmT001J14)
             ,new CursorDef("T001J15", "DELETE FROM [RepBalanceEstado]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [RBECtaContableCodigo] = @RBECtaContableCodigo", GxErrorMask.GX_NOMASK,prmT001J15)
             ,new CursorDef("T001J16", "SELECT [ClinicaCodigo], [RBECtaContableCodigo] FROM [RepBalanceEstado] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [RBECtaContableCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001J16,100,0,true,false )
             ,new CursorDef("T001J17", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001J17,1,0,true,false )
             ,new CursorDef("T001J18", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001J18,1,0,true,false )
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
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((decimal[]) buf[12])[0] = rslt.getDecimal(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(11) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(11);
                ((String[]) buf[16])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[17])[0] = rslt.getVarchar(13) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((decimal[]) buf[12])[0] = rslt.getDecimal(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(11) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(11);
                ((String[]) buf[16])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[17])[0] = rslt.getVarchar(13) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((decimal[]) buf[12])[0] = rslt.getDecimal(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(11) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(11);
                ((String[]) buf[16])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[17])[0] = rslt.getVarchar(13) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
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
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((decimal[]) buf[12])[0] = rslt.getDecimal(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(11) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(11);
                ((String[]) buf[16])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[17])[0] = rslt.getVarchar(13) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 16 :
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
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
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
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 7 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(7, (decimal)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 8 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(8, (decimal)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 9 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(9, (decimal)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 10 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(10, (decimal)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 11 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(11, (decimal)parms[15]);
                }
                stmt.SetParameter(12, (String)parms[16]);
                stmt.SetParameter(13, (String)parms[17]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 6 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(6, (decimal)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 7 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(7, (decimal)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 8 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(8, (decimal)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 9 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(9, (decimal)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 10 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(10, (decimal)parms[14]);
                }
                stmt.SetParameter(11, (String)parms[15]);
                stmt.SetParameter(12, (String)parms[16]);
                stmt.SetParameter(13, (String)parms[17]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 15 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
