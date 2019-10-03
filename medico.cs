/*
               File: Medico
        Description: Médicos
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:4:18.29
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
   public class medico : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_7") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A17EspCodigo = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_7( A41ClinicaCodigo, A17EspCodigo) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridmedico_medicoesp") == 0 )
         {
            nRC_Gridmedico_medicoesp = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            nGXsfl_80_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_80_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGridmedico_medicoesp_newrow( nRC_Gridmedico_medicoesp, nGXsfl_80_idx, sGXsfl_80_idx) ;
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
         Form.Meta.addItem("Description", "Médicos", 0) ;
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

      public medico( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public medico( IGxContext context )
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
            wb_table1_2_068( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_068e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_068( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_068( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_068e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Médicos"+"</legend>") ;
            wb_table3_27_068( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_068e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_068e( true) ;
         }
         else
         {
            wb_table1_2_068e( false) ;
         }
      }

      protected void wb_table3_27_068( bool wbgen )
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
            wb_table4_33_068( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_068e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Medico.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Medico.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 87,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Medico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_068e( true) ;
         }
         else
         {
            wb_table3_27_068e( false) ;
         }
      }

      protected void wb_table4_33_068( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", lblTextblockclinicacodigo_Visible, 1, 0, "HLP_Medico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", edtClinicaCodigo_Visible, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Medico.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_Internalname, "prompt.gif", imgprompt_41_Link, "", "", "Fantastic", imgprompt_41_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Medico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmedicocodigo_Internalname, "Código", "", "", lblTextblockmedicocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Medico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMedicoCodigo_Internalname, StringUtil.RTrim( A19MedicoCodigo), StringUtil.RTrim( context.localUtil.Format( A19MedicoCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtMedicoCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtMedicoCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Medico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmediconombre_Internalname, "Médico", "", "", lblTextblockmediconombre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Medico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20MedicoNombre", A20MedicoNombre);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMedicoNombre_Internalname, StringUtil.RTrim( A20MedicoNombre), StringUtil.RTrim( context.localUtil.Format( A20MedicoNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", "", "", "", edtMedicoNombre_Jsonclick, 0, ClassString, StyleString, "", 1, edtMedicoNombre_Enabled, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_Medico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmedicocolegiado_Internalname, "Colegiado", "", "", lblTextblockmedicocolegiado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Medico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21MedicoColegiado", A21MedicoColegiado);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMedicoColegiado_Internalname, StringUtil.RTrim( A21MedicoColegiado), StringUtil.RTrim( context.localUtil.Format( A21MedicoColegiado, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "", "", "", "", edtMedicoColegiado_Jsonclick, 0, ClassString, StyleString, "", 1, edtMedicoColegiado_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Medico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmedicodireccion_Internalname, "Dirección", "", "", lblTextblockmedicodireccion_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Medico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22MedicoDireccion", A22MedicoDireccion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMedicoDireccion_Internalname, StringUtil.RTrim( A22MedicoDireccion), StringUtil.RTrim( context.localUtil.Format( A22MedicoDireccion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", "", "", "", "", edtMedicoDireccion_Jsonclick, 0, ClassString, StyleString, "", 1, edtMedicoDireccion_Enabled, 0, 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, true, "left", "HLP_Medico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmedicotelefono1_Internalname, "Teléfono_1", "", "", lblTextblockmedicotelefono1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Medico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23MedicoTelefono1", A23MedicoTelefono1);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMedicoTelefono1_Internalname, StringUtil.RTrim( A23MedicoTelefono1), StringUtil.RTrim( context.localUtil.Format( A23MedicoTelefono1, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", "", "", "", "", edtMedicoTelefono1_Jsonclick, 0, ClassString, StyleString, "", 1, edtMedicoTelefono1_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "left", "HLP_Medico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmedicotelefono2_Internalname, "Teléfono_2", "", "", lblTextblockmedicotelefono2_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Medico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24MedicoTelefono2", A24MedicoTelefono2);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMedicoTelefono2_Internalname, StringUtil.RTrim( A24MedicoTelefono2), StringUtil.RTrim( context.localUtil.Format( A24MedicoTelefono2, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", "", "", "", "", edtMedicoTelefono2_Jsonclick, 0, ClassString, StyleString, "", 1, edtMedicoTelefono2_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "left", "HLP_Medico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmedicocorreo_Internalname, "Correo", "", "", lblTextblockmedicocorreo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Medico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25MedicoCorreo", A25MedicoCorreo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMedicoCorreo_Internalname, StringUtil.RTrim( A25MedicoCorreo), StringUtil.RTrim( context.localUtil.Format( A25MedicoCorreo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(73);\"", "", "", "", "", edtMedicoCorreo_Jsonclick, 0, ClassString, StyleString, "", 1, edtMedicoCorreo_Enabled, 0, 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, true, "left", "HLP_Medico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "<br>") ;
            wb_table5_76_068( true) ;
         }
         return  ;
      }

      protected void wb_table5_76_068e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<hr class=\"HRDefault\">") ;
            /*  Grid Control  */
            Gridmedico_medicoespContainer.AddObjectProperty("GridName", "Gridmedico_medicoesp");
            Gridmedico_medicoespContainer.AddObjectProperty("Class", "Grid");
            Gridmedico_medicoespContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Gridmedico_medicoespContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Gridmedico_medicoespContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmedico_medicoesp_Backcolorstyle), 1, 0, ".", "")));
            Gridmedico_medicoespContainer.AddObjectProperty("CmpContext", "");
            Gridmedico_medicoespContainer.AddObjectProperty("InMasterPage", "false");
            Gridmedico_medicoespColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridmedico_medicoespColumn.AddObjectProperty("Value", StringUtil.RTrim( A17EspCodigo));
            Gridmedico_medicoespColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEspCodigo_Enabled), 5, 0, ".", "")));
            Gridmedico_medicoespContainer.AddColumnProperties(Gridmedico_medicoespColumn);
            Gridmedico_medicoespColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridmedico_medicoespContainer.AddColumnProperties(Gridmedico_medicoespColumn);
            Gridmedico_medicoespColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridmedico_medicoespColumn.AddObjectProperty("Value", StringUtil.RTrim( A18EspDescripcion));
            Gridmedico_medicoespColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEspDescripcion_Enabled), 5, 0, ".", "")));
            Gridmedico_medicoespContainer.AddColumnProperties(Gridmedico_medicoespColumn);
            Gridmedico_medicoespContainer.AddObjectProperty("Allowselection", "false");
            Gridmedico_medicoespContainer.AddObjectProperty("Allowcollapsing", ((subGridmedico_medicoesp_Allowcollapsing==1) ? "true" : "false"));
            Gridmedico_medicoespContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmedico_medicoesp_Collapsed), 9, 0, ".", "")));
            nGXsfl_80_idx = 0 ;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount32 = 5 ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_32 = 1 ;
                  ScanStart0632( ) ;
                  while ( RcdFound32 != 0 )
                  {
                     init_level_properties32( ) ;
                     getByPrimaryKey0632( ) ;
                     AddRow0632( ) ;
                     ScanNext0632( ) ;
                  }
                  ScanEnd0632( ) ;
                  nBlankRcdCount32 = 5 ;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               standaloneNotModal0632( ) ;
               standaloneModal0632( ) ;
               sMode32 = Gx_mode ;
               while ( nGXsfl_80_idx < nRC_Gridmedico_medicoesp )
               {
                  ReadRow0632( ) ;
                  edtEspCodigo_Enabled = (int)(context.localUtil.CToN( cgiGet( "ESPCODIGO_"+sGXsfl_80_idx+"Enabled"), ".", ",")) ;
                  edtEspDescripcion_Enabled = (int)(context.localUtil.CToN( cgiGet( "ESPDESCRIPCION_"+sGXsfl_80_idx+"Enabled"), ".", ",")) ;
                  imgprompt_41_Link = cgiGet( "PROMPT_17_"+sGXsfl_80_idx+"Link") ;
                  if ( ( nRcdExists_32 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal0632( ) ;
                  }
                  SendRow0632( ) ;
               }
               Gx_mode = sMode32 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount32 = 5 ;
               nRcdExists_32 = 1 ;
               ScanStart0632( ) ;
               while ( RcdFound32 != 0 )
               {
                  init_level_properties32( ) ;
                  getByPrimaryKey0632( ) ;
                  standaloneNotModal0632( ) ;
                  standaloneModal0632( ) ;
                  AddRow0632( ) ;
                  ScanNext0632( ) ;
               }
               ScanEnd0632( ) ;
            }
            /* Initialize fields for 'new' records and send them. */
            sMode32 = Gx_mode ;
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            InitAll0632( ) ;
            init_level_properties32( ) ;
            standaloneNotModal0632( ) ;
            standaloneModal0632( ) ;
            nRcdExists_32 = 0 ;
            nIsMod_32 = 0 ;
            nBlankRcdCount32 = (short)(nBlankRcdUsr32+nBlankRcdCount32) ;
            fRowAdded = 0 ;
            while ( nBlankRcdCount32 > 0 )
            {
               AddRow0632( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1 ;
                  GX_FocusControl = edtEspCodigo_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount32 = (short)(nBlankRcdCount32-1) ;
            }
            Gx_mode = sMode32 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            sStyleString = " style=\"display:none;\"" ;
            sStyleString = "" ;
            context.WriteHtmlText( "<div id=\""+"Gridmedico_medicoespContainer"+"Div\" "+sStyleString+">"+"</div>") ;
            context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridmedico_medicoesp", (Object)(Gridmedico_medicoespContainer));
            GxWebStd.gx_hidden_field( context, "Gridmedico_medicoespContainerData", Gridmedico_medicoespContainer.ToJavascriptSource());
            if ( context.isAjaxRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Gridmedico_medicoespContainerData"+"V", Gridmedico_medicoespContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridmedico_medicoespContainerData"+"V"+"\" value='"+Gridmedico_medicoespContainer.GridValuesHidden()+"'>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_068e( true) ;
         }
         else
         {
            wb_table4_33_068e( false) ;
         }
      }

      protected void wb_table5_76_068( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTitlemedicoesp_Internalname, "Especialidades", "", "", lblTitlemedicoesp_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Medico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_76_068e( true) ;
         }
         else
         {
            wb_table5_76_068e( false) ;
         }
      }

      protected void wb_table2_5_068( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Medico.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Medico.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Medico.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Medico.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Medico.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Medico.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Medico.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Medico.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0080.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"MEDICOCODIGO"+"'), id:'"+"MEDICOCODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Medico.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0080.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"MEDICOCODIGO"+"'), id:'"+"MEDICOCODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Medico.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Medico.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Medico.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Medico.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Medico.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Medico.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Medico.htm");
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
            wb_table2_5_068e( true) ;
         }
         else
         {
            wb_table2_5_068e( false) ;
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
         /* Execute user event: E11062 */
         E11062 ();
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
               A19MedicoCodigo = cgiGet( edtMedicoCodigo_Internalname) ;
               n19MedicoCodigo = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
               A20MedicoNombre = cgiGet( edtMedicoNombre_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20MedicoNombre", A20MedicoNombre);
               A21MedicoColegiado = cgiGet( edtMedicoColegiado_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21MedicoColegiado", A21MedicoColegiado);
               A22MedicoDireccion = cgiGet( edtMedicoDireccion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22MedicoDireccion", A22MedicoDireccion);
               A23MedicoTelefono1 = cgiGet( edtMedicoTelefono1_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23MedicoTelefono1", A23MedicoTelefono1);
               A24MedicoTelefono2 = cgiGet( edtMedicoTelefono2_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24MedicoTelefono2", A24MedicoTelefono2);
               A25MedicoCorreo = cgiGet( edtMedicoCorreo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25MedicoCorreo", A25MedicoCorreo);
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z19MedicoCodigo = cgiGet( "Z19MedicoCodigo") ;
               Z20MedicoNombre = cgiGet( "Z20MedicoNombre") ;
               Z21MedicoColegiado = cgiGet( "Z21MedicoColegiado") ;
               Z22MedicoDireccion = cgiGet( "Z22MedicoDireccion") ;
               Z23MedicoTelefono1 = cgiGet( "Z23MedicoTelefono1") ;
               Z24MedicoTelefono2 = cgiGet( "Z24MedicoTelefono2") ;
               Z25MedicoCorreo = cgiGet( "Z25MedicoCorreo") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               nRC_Gridmedico_medicoesp = (short)(context.localUtil.CToN( cgiGet( "nRC_Gridmedico_medicoesp"), ".", ",")) ;
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
                  A19MedicoCodigo = GetNextPar( ) ;
                  n19MedicoCodigo = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
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
                           /* Execute user event: E11062 */
                           E11062 ();
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
               InitAll068( ) ;
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
         DisableAttributes068( ) ;
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

      protected void CONFIRM_0632( )
      {
         nGXsfl_80_idx = 0 ;
         while ( nGXsfl_80_idx < nRC_Gridmedico_medicoesp )
         {
            ReadRow0632( ) ;
            if ( ( nRcdExists_32 != 0 ) || ( nIsMod_32 != 0 ) )
            {
               GetKey0632( ) ;
               if ( ( nRcdExists_32 == 0 ) && ( nRcdDeleted_32 == 0 ) )
               {
                  if ( RcdFound32 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate0632( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0632( ) ;
                        CloseExtendedTableCursors0632( ) ;
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
                     GX_FocusControl = edtEspCodigo_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound32 != 0 )
                  {
                     if ( nRcdDeleted_32 != 0 )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey0632( ) ;
                        Load0632( ) ;
                        BeforeValidate0632( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0632( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_32 != 0 )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate0632( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0632( ) ;
                              CloseExtendedTableCursors0632( ) ;
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
                     if ( nRcdDeleted_32 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtEspCodigo_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtEspCodigo_Internalname, StringUtil.RTrim( A17EspCodigo)) ;
            ChangePostValue( edtEspDescripcion_Internalname, StringUtil.RTrim( A18EspDescripcion)) ;
            ChangePostValue( "ZT_"+"Z17EspCodigo_"+sGXsfl_80_idx, StringUtil.RTrim( Z17EspCodigo)) ;
            ChangePostValue( "nRcdDeleted_32_"+sGXsfl_80_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_32), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_32_"+sGXsfl_80_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_32), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_32_"+sGXsfl_80_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_32), 4, 0, ".", ""))) ;
            if ( nIsMod_32 != 0 )
            {
               ChangePostValue( "ESPCODIGO_"+sGXsfl_80_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEspCodigo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ESPDESCRIPCION_"+sGXsfl_80_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEspDescripcion_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption060( )
      {
      }

      protected void E11062( )
      {
         /* Start Routine */
         GXt_SdtParametros5 = AV7Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros5) ;
         AV7Parametros = GXt_SdtParametros5 ;
         AV8ClinicaCodigo = AV7Parametros.gxTpr_Pclinicacodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClinicaCodigo", AV8ClinicaCodigo);
      }

      protected void ZM068( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z20MedicoNombre = T00066_A20MedicoNombre[0] ;
               Z21MedicoColegiado = T00066_A21MedicoColegiado[0] ;
               Z22MedicoDireccion = T00066_A22MedicoDireccion[0] ;
               Z23MedicoTelefono1 = T00066_A23MedicoTelefono1[0] ;
               Z24MedicoTelefono2 = T00066_A24MedicoTelefono2[0] ;
               Z25MedicoCorreo = T00066_A25MedicoCorreo[0] ;
            }
            else
            {
               Z20MedicoNombre = A20MedicoNombre ;
               Z21MedicoColegiado = A21MedicoColegiado ;
               Z22MedicoDireccion = A22MedicoDireccion ;
               Z23MedicoTelefono1 = A23MedicoTelefono1 ;
               Z24MedicoTelefono2 = A24MedicoTelefono2 ;
               Z25MedicoCorreo = A25MedicoCorreo ;
            }
         }
         if ( GX_JID == -4 )
         {
            Z19MedicoCodigo = A19MedicoCodigo ;
            Z20MedicoNombre = A20MedicoNombre ;
            Z21MedicoColegiado = A21MedicoColegiado ;
            Z22MedicoDireccion = A22MedicoDireccion ;
            Z23MedicoTelefono1 = A23MedicoTelefono1 ;
            Z24MedicoTelefono2 = A24MedicoTelefono2 ;
            Z25MedicoCorreo = A25MedicoCorreo ;
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

      protected void Load068( )
      {
         /* Using cursor T00068 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, n19MedicoCodigo, A19MedicoCodigo});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound8 = 1 ;
            A20MedicoNombre = T00068_A20MedicoNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20MedicoNombre", A20MedicoNombre);
            A21MedicoColegiado = T00068_A21MedicoColegiado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21MedicoColegiado", A21MedicoColegiado);
            A22MedicoDireccion = T00068_A22MedicoDireccion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22MedicoDireccion", A22MedicoDireccion);
            A23MedicoTelefono1 = T00068_A23MedicoTelefono1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23MedicoTelefono1", A23MedicoTelefono1);
            A24MedicoTelefono2 = T00068_A24MedicoTelefono2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24MedicoTelefono2", A24MedicoTelefono2);
            A25MedicoCorreo = T00068_A25MedicoCorreo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25MedicoCorreo", A25MedicoCorreo);
            ZM068( -4) ;
         }
         pr_default.close(6);
         OnLoadActions068( ) ;
      }

      protected void OnLoadActions068( )
      {
      }

      protected void CheckExtendedTable068( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T00067 */
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
         pr_default.close(5);
      }

      protected void CloseExtendedTableCursors068( )
      {
         pr_default.close(5);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_5( String A41ClinicaCodigo )
      {
         /* Using cursor T00069 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(7) == 101) )
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
         if ( (pr_default.getStatus(7) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(7);
      }

      protected void GetKey068( )
      {
         /* Using cursor T000610 */
         pr_default.execute(8, new Object[] {A41ClinicaCodigo, n19MedicoCodigo, A19MedicoCodigo});
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound8 = 1 ;
         }
         else
         {
            RcdFound8 = 0 ;
         }
         pr_default.close(8);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00066 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo, n19MedicoCodigo, A19MedicoCodigo});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM068( 4) ;
            RcdFound8 = 1 ;
            A19MedicoCodigo = T00066_A19MedicoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
            n19MedicoCodigo = T00066_n19MedicoCodigo[0] ;
            A20MedicoNombre = T00066_A20MedicoNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20MedicoNombre", A20MedicoNombre);
            A21MedicoColegiado = T00066_A21MedicoColegiado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21MedicoColegiado", A21MedicoColegiado);
            A22MedicoDireccion = T00066_A22MedicoDireccion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22MedicoDireccion", A22MedicoDireccion);
            A23MedicoTelefono1 = T00066_A23MedicoTelefono1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23MedicoTelefono1", A23MedicoTelefono1);
            A24MedicoTelefono2 = T00066_A24MedicoTelefono2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24MedicoTelefono2", A24MedicoTelefono2);
            A25MedicoCorreo = T00066_A25MedicoCorreo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25MedicoCorreo", A25MedicoCorreo);
            A41ClinicaCodigo = T00066_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z19MedicoCodigo = A19MedicoCodigo ;
            sMode8 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load068( ) ;
            Gx_mode = sMode8 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound8 = 0 ;
            InitializeNonKey068( ) ;
            sMode8 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode8 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey068( ) ;
         if ( RcdFound8 == 0 )
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
         RcdFound8 = 0 ;
         /* Using cursor T000611 */
         pr_default.execute(9, new Object[] {A41ClinicaCodigo, n19MedicoCodigo, A19MedicoCodigo});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T000611_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000611_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000611_A19MedicoCodigo[0], A19MedicoCodigo) < 0 ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T000611_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000611_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000611_A19MedicoCodigo[0], A19MedicoCodigo) > 0 ) ) )
            {
               A41ClinicaCodigo = T000611_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A19MedicoCodigo = T000611_A19MedicoCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
               n19MedicoCodigo = T000611_n19MedicoCodigo[0] ;
               RcdFound8 = 1 ;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound8 = 0 ;
         /* Using cursor T000612 */
         pr_default.execute(10, new Object[] {A41ClinicaCodigo, n19MedicoCodigo, A19MedicoCodigo});
         if ( (pr_default.getStatus(10) != 101) )
         {
            while ( (pr_default.getStatus(10) != 101) && ( ( StringUtil.StrCmp(T000612_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000612_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000612_A19MedicoCodigo[0], A19MedicoCodigo) > 0 ) ) )
            {
               pr_default.readNext(10);
            }
            if ( (pr_default.getStatus(10) != 101) && ( ( StringUtil.StrCmp(T000612_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000612_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000612_A19MedicoCodigo[0], A19MedicoCodigo) < 0 ) ) )
            {
               A41ClinicaCodigo = T000612_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A19MedicoCodigo = T000612_A19MedicoCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
               n19MedicoCodigo = T000612_n19MedicoCodigo[0] ;
               RcdFound8 = 1 ;
            }
         }
         pr_default.close(3);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey068( ) ;
         if ( RcdFound8 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A19MedicoCodigo, Z19MedicoCodigo) != 0 ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A19MedicoCodigo = Z19MedicoCodigo ;
               n19MedicoCodigo = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
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
               Update068( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A19MedicoCodigo, Z19MedicoCodigo) != 0 ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert068( ) ;
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
                  Insert068( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A19MedicoCodigo, Z19MedicoCodigo) != 0 ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A19MedicoCodigo = Z19MedicoCodigo ;
            n19MedicoCodigo = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
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
         if ( RcdFound8 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtMedicoNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart068( ) ;
         if ( RcdFound8 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMedicoNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd068( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound8 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMedicoNombre_Internalname ;
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
         if ( RcdFound8 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMedicoNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart068( ) ;
         if ( RcdFound8 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound8 != 0 )
            {
               ScanNext068( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMedicoNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd068( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency068( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000613 */
            pr_default.execute(11, new Object[] {A41ClinicaCodigo, n19MedicoCodigo, A19MedicoCodigo});
            if ( (pr_default.getStatus(11) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Medico"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(11) == 101) || ( StringUtil.StrCmp(Z20MedicoNombre, T000613_A20MedicoNombre[0]) != 0 ) || ( StringUtil.StrCmp(Z21MedicoColegiado, T000613_A21MedicoColegiado[0]) != 0 ) || ( StringUtil.StrCmp(Z22MedicoDireccion, T000613_A22MedicoDireccion[0]) != 0 ) || ( StringUtil.StrCmp(Z23MedicoTelefono1, T000613_A23MedicoTelefono1[0]) != 0 ) || ( StringUtil.StrCmp(Z24MedicoTelefono2, T000613_A24MedicoTelefono2[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z25MedicoCorreo, T000613_A25MedicoCorreo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Medico"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert068( )
      {
         BeforeValidate068( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable068( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM068( 0) ;
            CheckOptimisticConcurrency068( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm068( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert068( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000614 */
                     pr_default.execute(12, new Object[] {n19MedicoCodigo, A19MedicoCodigo, A20MedicoNombre, A21MedicoColegiado, A22MedicoDireccion, A23MedicoTelefono1, A24MedicoTelefono2, A25MedicoCorreo, A41ClinicaCodigo});
                     pr_default.close(12);
                     if ( (pr_default.getStatus(12) == 1) )
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
                           ProcessLevel068( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                              ResetCaption060( ) ;
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
               Load068( ) ;
            }
            EndLevel068( ) ;
         }
         CloseExtendedTableCursors068( ) ;
      }

      protected void Update068( )
      {
         BeforeValidate068( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable068( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency068( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm068( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate068( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000615 */
                     pr_default.execute(13, new Object[] {A20MedicoNombre, A21MedicoColegiado, A22MedicoDireccion, A23MedicoTelefono1, A24MedicoTelefono2, A25MedicoCorreo, A41ClinicaCodigo, n19MedicoCodigo, A19MedicoCodigo});
                     pr_default.close(13);
                     if ( (pr_default.getStatus(13) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Medico"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate068( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel068( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                              ResetCaption060( ) ;
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
            EndLevel068( ) ;
         }
         CloseExtendedTableCursors068( ) ;
      }

      protected void DeferredUpdate068( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate068( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency068( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls068( ) ;
            AfterConfirm068( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete068( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart0632( ) ;
                  while ( RcdFound32 != 0 )
                  {
                     getByPrimaryKey0632( ) ;
                     Delete0632( ) ;
                     ScanNext0632( ) ;
                  }
                  ScanEnd0632( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000616 */
                     pr_default.execute(14, new Object[] {A41ClinicaCodigo, n19MedicoCodigo, A19MedicoCodigo});
                     pr_default.close(14);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound8 == 0 )
                           {
                              InitAll068( ) ;
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
                           ResetCaption060( ) ;
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
         sMode8 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel068( ) ;
         Gx_mode = sMode8 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls068( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000617 */
            pr_default.execute(15, new Object[] {A41ClinicaCodigo, n19MedicoCodigo, A19MedicoCodigo});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Consulta de pacientes"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(15);
         }
      }

      protected void ProcessNestedLevel0632( )
      {
         nGXsfl_80_idx = 0 ;
         while ( nGXsfl_80_idx < nRC_Gridmedico_medicoesp )
         {
            ReadRow0632( ) ;
            if ( ( nRcdExists_32 != 0 ) || ( nIsMod_32 != 0 ) )
            {
               standaloneNotModal0632( ) ;
               GetKey0632( ) ;
               if ( ( nRcdExists_32 == 0 ) && ( nRcdDeleted_32 == 0 ) )
               {
                  if ( RcdFound32 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Insert0632( ) ;
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtEspCodigo_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound32 != 0 )
                  {
                     if ( ( nRcdDeleted_32 != 0 ) && ( nRcdExists_32 != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete0632( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_32 != 0 ) && ( nRcdExists_32 != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update0632( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_32 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtEspCodigo_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtEspCodigo_Internalname, StringUtil.RTrim( A17EspCodigo)) ;
            ChangePostValue( edtEspDescripcion_Internalname, StringUtil.RTrim( A18EspDescripcion)) ;
            ChangePostValue( "ZT_"+"Z17EspCodigo_"+sGXsfl_80_idx, StringUtil.RTrim( Z17EspCodigo)) ;
            ChangePostValue( "nRcdDeleted_32_"+sGXsfl_80_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_32), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_32_"+sGXsfl_80_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_32), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_32_"+sGXsfl_80_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_32), 4, 0, ".", ""))) ;
            if ( nIsMod_32 != 0 )
            {
               ChangePostValue( "ESPCODIGO_"+sGXsfl_80_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEspCodigo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ESPDESCRIPCION_"+sGXsfl_80_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEspDescripcion_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0632( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_32 = 0 ;
         nIsMod_32 = 0 ;
         nRcdDeleted_32 = 0 ;
      }

      protected void ProcessLevel068( )
      {
         /* Save parent mode. */
         sMode8 = Gx_mode ;
         ProcessNestedLevel0632( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode8 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel068( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(11);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete068( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(10);
            pr_default.close(9);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(2);
            context.CommitDataStores("Medico");
            if ( AnyError == 0 )
            {
               ConfirmValues060( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(10);
            pr_default.close(9);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(2);
            context.RollbackDataStores("Medico");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart068( )
      {
         /* Using cursor T000618 */
         pr_default.execute(16);
         RcdFound8 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound8 = 1 ;
            A41ClinicaCodigo = T000618_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A19MedicoCodigo = T000618_A19MedicoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
            n19MedicoCodigo = T000618_n19MedicoCodigo[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext068( )
      {
         pr_default.readNext(16);
         RcdFound8 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound8 = 1 ;
            A41ClinicaCodigo = T000618_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A19MedicoCodigo = T000618_A19MedicoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
            n19MedicoCodigo = T000618_n19MedicoCodigo[0] ;
         }
      }

      protected void ScanEnd068( )
      {
      }

      protected void AfterConfirm068( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert068( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate068( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete068( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete068( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate068( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes068( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtMedicoCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMedicoCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMedicoCodigo_Enabled), 5, 0)));
         edtMedicoNombre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMedicoNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMedicoNombre_Enabled), 5, 0)));
         edtMedicoColegiado_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMedicoColegiado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMedicoColegiado_Enabled), 5, 0)));
         edtMedicoDireccion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMedicoDireccion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMedicoDireccion_Enabled), 5, 0)));
         edtMedicoTelefono1_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMedicoTelefono1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMedicoTelefono1_Enabled), 5, 0)));
         edtMedicoTelefono2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMedicoTelefono2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMedicoTelefono2_Enabled), 5, 0)));
         edtMedicoCorreo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMedicoCorreo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMedicoCorreo_Enabled), 5, 0)));
      }

      protected void ZM0632( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
            }
            else
            {
            }
         }
         if ( GX_JID == -6 )
         {
            Z19MedicoCodigo = A19MedicoCodigo ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z17EspCodigo = A17EspCodigo ;
            Z18EspDescripcion = A18EspDescripcion ;
         }
      }

      protected void standaloneNotModal0632( )
      {
      }

      protected void standaloneModal0632( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtEspCodigo_Enabled = 0 ;
         }
         else
         {
            edtEspCodigo_Enabled = 1 ;
         }
         if ( ( StringUtil.StrCmp(sMode32, "DSP") == 0 ) || ( StringUtil.StrCmp(sMode32, "DLT") == 0 ) )
         {
            DisableAttributes0632( ) ;
         }
      }

      protected void Load0632( )
      {
         /* Using cursor T000619 */
         pr_default.execute(17, new Object[] {A41ClinicaCodigo, n19MedicoCodigo, A19MedicoCodigo, A17EspCodigo});
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound32 = 1 ;
            A18EspDescripcion = T000619_A18EspDescripcion[0] ;
            ZM0632( -6) ;
         }
         pr_default.close(17);
         OnLoadActions0632( ) ;
      }

      protected void OnLoadActions0632( )
      {
      }

      protected void CheckExtendedTable0632( )
      {
         Gx_BScreen = 1 ;
         standaloneModal0632( ) ;
         /* Using cursor T00064 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo, A17EspCodigo});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError41 = 1 ;
            AnyError17 = 1 ;
            GX_msglist.addItem("No existe 'Especialidades'.", "ForeignKeyNotFound", 1, "ESPCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtEspCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError17 == 0 ) )
         {
            A18EspDescripcion = T00064_A18EspDescripcion[0] ;
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0632( )
      {
         pr_default.close(2);
      }

      protected void enableDisable0632( )
      {
      }

      protected void gxLoad_7( String A41ClinicaCodigo ,
                               String A17EspCodigo )
      {
         /* Using cursor T000620 */
         pr_default.execute(18, new Object[] {A41ClinicaCodigo, A17EspCodigo});
         if ( (pr_default.getStatus(18) == 101) )
         {
            AnyError41 = 1 ;
            AnyError17 = 1 ;
            GX_msglist.addItem("No existe 'Especialidades'.", "ForeignKeyNotFound", 1, "ESPCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtEspCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError17 == 0 ) )
         {
            A18EspDescripcion = T000620_A18EspDescripcion[0] ;
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A18EspDescripcion))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(18) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(18);
      }

      protected void GetKey0632( )
      {
         /* Using cursor T000621 */
         pr_default.execute(19, new Object[] {A41ClinicaCodigo, n19MedicoCodigo, A19MedicoCodigo, A17EspCodigo});
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound32 = 1 ;
         }
         else
         {
            RcdFound32 = 0 ;
         }
         pr_default.close(19);
      }

      protected void getByPrimaryKey0632( )
      {
         /* Using cursor T00063 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, n19MedicoCodigo, A19MedicoCodigo, A17EspCodigo});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0632( 6) ;
            RcdFound32 = 1 ;
            InitializeNonKey0632( ) ;
            A17EspCodigo = T00063_A17EspCodigo[0] ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z19MedicoCodigo = A19MedicoCodigo ;
            Z17EspCodigo = A17EspCodigo ;
            sMode32 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0632( ) ;
            Load0632( ) ;
            Gx_mode = sMode32 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound32 = 0 ;
            InitializeNonKey0632( ) ;
            sMode32 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0632( ) ;
            Gx_mode = sMode32 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0632( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00062 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, n19MedicoCodigo, A19MedicoCodigo, A17EspCodigo});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MedicoEsp"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"MedicoEsp"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0632( )
      {
         BeforeValidate0632( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0632( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0632( 0) ;
            CheckOptimisticConcurrency0632( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0632( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0632( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000622 */
                     pr_default.execute(20, new Object[] {n19MedicoCodigo, A19MedicoCodigo, A41ClinicaCodigo, A17EspCodigo});
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
               Load0632( ) ;
            }
            EndLevel0632( ) ;
         }
         CloseExtendedTableCursors0632( ) ;
      }

      protected void Update0632( )
      {
         BeforeValidate0632( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0632( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0632( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0632( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0632( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [MedicoEsp] */
                     DeferredUpdate0632( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0632( ) ;
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
            EndLevel0632( ) ;
         }
         CloseExtendedTableCursors0632( ) ;
      }

      protected void DeferredUpdate0632( )
      {
      }

      protected void Delete0632( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0632( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0632( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0632( ) ;
            AfterConfirm0632( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0632( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000623 */
                  pr_default.execute(21, new Object[] {A41ClinicaCodigo, n19MedicoCodigo, A19MedicoCodigo, A17EspCodigo});
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
         sMode32 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0632( ) ;
         Gx_mode = sMode32 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0632( )
      {
         standaloneModal0632( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000624 */
            pr_default.execute(22, new Object[] {A41ClinicaCodigo, A17EspCodigo});
            A18EspDescripcion = T000624_A18EspDescripcion[0] ;
            pr_default.close(22);
         }
      }

      protected void EndLevel0632( )
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

      protected void ScanStart0632( )
      {
         /* Using cursor T000625 */
         pr_default.execute(23, new Object[] {A41ClinicaCodigo, n19MedicoCodigo, A19MedicoCodigo});
         RcdFound32 = 0 ;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound32 = 1 ;
            A17EspCodigo = T000625_A17EspCodigo[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0632( )
      {
         pr_default.readNext(23);
         RcdFound32 = 0 ;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound32 = 1 ;
            A17EspCodigo = T000625_A17EspCodigo[0] ;
         }
      }

      protected void ScanEnd0632( )
      {
         pr_default.close(1);
      }

      protected void AfterConfirm0632( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0632( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0632( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0632( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0632( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0632( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0632( )
      {
         edtEspCodigo_Enabled = 0 ;
         edtEspDescripcion_Enabled = 0 ;
      }

      protected void AddRow0632( )
      {
         nGXsfl_80_idx = (short)(nGXsfl_80_idx+1) ;
         sGXsfl_80_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_80_idx), 4, 0)), 4, "0") ;
         edtEspCodigo_Internalname = "ESPCODIGO_"+sGXsfl_80_idx ;
         imgprompt_17_Internalname = "PROMPT_17_"+sGXsfl_80_idx ;
         edtEspDescripcion_Internalname = "ESPDESCRIPCION_"+sGXsfl_80_idx ;
         SendRow0632( ) ;
      }

      protected void SendRow0632( )
      {
         Gridmedico_medicoespRow = GXWebRow.GetNew(context) ;
         if ( subGridmedico_medicoesp_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridmedico_medicoesp_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGridmedico_medicoesp_Class, "") != 0 )
            {
               subGridmedico_medicoesp_Linesclass = subGridmedico_medicoesp_Class+"Odd" ;
            }
         }
         else if ( subGridmedico_medicoesp_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridmedico_medicoesp_Backstyle = 0 ;
            subGridmedico_medicoesp_Backcolor = subGridmedico_medicoesp_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridmedico_medicoespContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridmedico_medicoesp_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGridmedico_medicoesp_Class, "") != 0 )
            {
               subGridmedico_medicoesp_Linesclass = subGridmedico_medicoesp_Class+"Uniform" ;
            }
         }
         else if ( subGridmedico_medicoesp_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridmedico_medicoesp_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGridmedico_medicoesp_Class, "") != 0 )
            {
               subGridmedico_medicoesp_Linesclass = subGridmedico_medicoesp_Class+"Odd" ;
            }
            subGridmedico_medicoesp_Backcolor = (int)(0xFFFFFF) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridmedico_medicoespContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridmedico_medicoesp_Backcolor), 9, 0)));
         }
         else if ( subGridmedico_medicoesp_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridmedico_medicoesp_Backstyle = 1 ;
            if ( ((int)(nGXsfl_80_idx) % (2)) == 0 )
            {
               subGridmedico_medicoesp_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridmedico_medicoespContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridmedico_medicoesp_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridmedico_medicoesp_Class, "") != 0 )
               {
                  subGridmedico_medicoesp_Linesclass = subGridmedico_medicoesp_Class+"Even" ;
               }
            }
            else
            {
               subGridmedico_medicoesp_Backcolor = (int)(0xFFFFFF) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridmedico_medicoespContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridmedico_medicoesp_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridmedico_medicoesp_Class, "") != 0 )
               {
                  subGridmedico_medicoesp_Linesclass = subGridmedico_medicoesp_Class+"Odd" ;
               }
            }
         }
         imgprompt_17_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0)||(StringUtil.StrCmp(Gx_mode, "UPD")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00v1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+"}"+","+"{Ctrl:gx.dom.el('"+"ESPCODIGO_"+sGXsfl_80_idx+"'), id:'"+"ESPCODIGO_"+sGXsfl_80_idx+"'"+",isOut: true}"+"],"+"gx.dom.form()."+"nIsMod_32_"+sGXsfl_80_idx+","+"'', false"+","+"false"+");") ;
         /* * Property Link not supported in */
         /* * Property Link not supported in */
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_32_" + sGXsfl_80_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 81,'',false,'" + sGXsfl_80_idx + "',80)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridmedico_medicoespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEspCodigo_Internalname,StringUtil.RTrim( A17EspCodigo),(String)"",TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(81);\"",(String)"",(String)"",(String)"",(String)"",(String)edtEspCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtEspCodigo_Enabled,(short)1,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)80,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "Image" ;
         StyleString = "" ;
         Gridmedico_medicoespRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_17_Internalname,"prompt.gif",(String)imgprompt_17_Link,(String)"",(String)"",(String)"Fantastic",(int)imgprompt_17_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
         /* Subfile cell */
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridmedico_medicoespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEspDescripcion_Internalname,StringUtil.RTrim( A18EspDescripcion),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtEspDescripcion_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtEspDescripcion_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)80,(short)1,(short)-1,(bool)true,(String)"left"});
         context.httpAjaxContext.ajax_sending_grid_row(Gridmedico_medicoespRow);
         GXCCtl = "Z17EspCodigo_" + sGXsfl_80_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z17EspCodigo));
         GXCCtl = "nRcdDeleted_32_" + sGXsfl_80_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_32), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_32_" + sGXsfl_80_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_32), 4, 0, ".", "")));
         GXCCtl = "nIsMod_32_" + sGXsfl_80_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_32), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ESPCODIGO_"+sGXsfl_80_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEspCodigo_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ESPDESCRIPCION_"+sGXsfl_80_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEspDescripcion_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_17_"+sGXsfl_80_idx+"Link", StringUtil.RTrim( imgprompt_17_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridmedico_medicoespContainer.AddRow(Gridmedico_medicoespRow);
      }

      protected void ReadRow0632( )
      {
         nGXsfl_80_idx = (short)(nGXsfl_80_idx+1) ;
         sGXsfl_80_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_80_idx), 4, 0)), 4, "0") ;
         edtEspCodigo_Internalname = "ESPCODIGO_"+sGXsfl_80_idx ;
         imgprompt_17_Internalname = "PROMPT_17_"+sGXsfl_80_idx ;
         edtEspDescripcion_Internalname = "ESPDESCRIPCION_"+sGXsfl_80_idx ;
         edtEspCodigo_Enabled = (int)(context.localUtil.CToN( cgiGet( "ESPCODIGO_"+sGXsfl_80_idx+"Enabled"), ".", ",")) ;
         edtEspDescripcion_Enabled = (int)(context.localUtil.CToN( cgiGet( "ESPDESCRIPCION_"+sGXsfl_80_idx+"Enabled"), ".", ",")) ;
         imgprompt_41_Link = cgiGet( "PROMPT_17_"+sGXsfl_80_idx+"Link") ;
         A17EspCodigo = cgiGet( edtEspCodigo_Internalname) ;
         A18EspDescripcion = cgiGet( edtEspDescripcion_Internalname) ;
         GXCCtl = "Z17EspCodigo_" + sGXsfl_80_idx ;
         Z17EspCodigo = cgiGet( GXCCtl) ;
         GXCCtl = "nRcdDeleted_32_" + sGXsfl_80_idx ;
         nRcdDeleted_32 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdExists_32_" + sGXsfl_80_idx ;
         nRcdExists_32 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nIsMod_32_" + sGXsfl_80_idx ;
         nIsMod_32 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
      }

      protected void assign_properties_default( )
      {
         defedtEspCodigo_Enabled = edtEspCodigo_Enabled ;
      }

      protected void ConfirmValues060( )
      {
         nGXsfl_80_idx = 0 ;
         sGXsfl_80_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_80_idx), 4, 0)), 4, "0") ;
         edtEspCodigo_Internalname = "ESPCODIGO_"+sGXsfl_80_idx ;
         imgprompt_17_Internalname = "PROMPT_17_"+sGXsfl_80_idx ;
         edtEspDescripcion_Internalname = "ESPDESCRIPCION_"+sGXsfl_80_idx ;
         while ( nGXsfl_80_idx < nRC_Gridmedico_medicoesp )
         {
            nGXsfl_80_idx = (short)(nGXsfl_80_idx+1) ;
            sGXsfl_80_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_80_idx), 4, 0)), 4, "0") ;
            edtEspCodigo_Internalname = "ESPCODIGO_"+sGXsfl_80_idx ;
            imgprompt_17_Internalname = "PROMPT_17_"+sGXsfl_80_idx ;
            edtEspDescripcion_Internalname = "ESPDESCRIPCION_"+sGXsfl_80_idx ;
            ChangePostValue( "Z17EspCodigo_"+sGXsfl_80_idx, cgiGet( "ZT_"+"Z17EspCodigo_"+sGXsfl_80_idx)) ;
            DeletePostValue( "ZT_"+"Z17EspCodigo_"+sGXsfl_80_idx) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("medico.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z19MedicoCodigo", StringUtil.RTrim( Z19MedicoCodigo));
         GxWebStd.gx_hidden_field( context, "Z20MedicoNombre", StringUtil.RTrim( Z20MedicoNombre));
         GxWebStd.gx_hidden_field( context, "Z21MedicoColegiado", StringUtil.RTrim( Z21MedicoColegiado));
         GxWebStd.gx_hidden_field( context, "Z22MedicoDireccion", StringUtil.RTrim( Z22MedicoDireccion));
         GxWebStd.gx_hidden_field( context, "Z23MedicoTelefono1", StringUtil.RTrim( Z23MedicoTelefono1));
         GxWebStd.gx_hidden_field( context, "Z24MedicoTelefono2", StringUtil.RTrim( Z24MedicoTelefono2));
         GxWebStd.gx_hidden_field( context, "Z25MedicoCorreo", StringUtil.RTrim( Z25MedicoCorreo));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_Gridmedico_medicoesp", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_80_idx), 4, 0, ".", "")));
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
         return "Medico" ;
      }

      public override String GetPgmdesc( )
      {
         return "Médicos" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("medico.aspx")  ;
      }

      protected void InitializeNonKey068( )
      {
         A20MedicoNombre = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20MedicoNombre", A20MedicoNombre);
         A21MedicoColegiado = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21MedicoColegiado", A21MedicoColegiado);
         A22MedicoDireccion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22MedicoDireccion", A22MedicoDireccion);
         A23MedicoTelefono1 = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23MedicoTelefono1", A23MedicoTelefono1);
         A24MedicoTelefono2 = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24MedicoTelefono2", A24MedicoTelefono2);
         A25MedicoCorreo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25MedicoCorreo", A25MedicoCorreo);
      }

      protected void InitAll068( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A19MedicoCodigo = "" ;
         n19MedicoCodigo = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
         InitializeNonKey068( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0632( )
      {
         A18EspDescripcion = "" ;
      }

      protected void InitAll0632( )
      {
         A17EspCodigo = "" ;
         InitializeNonKey0632( ) ;
      }

      protected void StandaloneModalInsert0632( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1542081");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("medico.js", "?1542082");
         /* End function include_jscripts */
      }

      protected void init_level_properties32( )
      {
         edtEspCodigo_Enabled = defedtEspCodigo_Enabled ;
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
         lblTextblockmedicocodigo_Internalname = "TEXTBLOCKMEDICOCODIGO" ;
         edtMedicoCodigo_Internalname = "MEDICOCODIGO" ;
         lblTextblockmediconombre_Internalname = "TEXTBLOCKMEDICONOMBRE" ;
         edtMedicoNombre_Internalname = "MEDICONOMBRE" ;
         lblTextblockmedicocolegiado_Internalname = "TEXTBLOCKMEDICOCOLEGIADO" ;
         edtMedicoColegiado_Internalname = "MEDICOCOLEGIADO" ;
         lblTextblockmedicodireccion_Internalname = "TEXTBLOCKMEDICODIRECCION" ;
         edtMedicoDireccion_Internalname = "MEDICODIRECCION" ;
         lblTextblockmedicotelefono1_Internalname = "TEXTBLOCKMEDICOTELEFONO1" ;
         edtMedicoTelefono1_Internalname = "MEDICOTELEFONO1" ;
         lblTextblockmedicotelefono2_Internalname = "TEXTBLOCKMEDICOTELEFONO2" ;
         edtMedicoTelefono2_Internalname = "MEDICOTELEFONO2" ;
         lblTextblockmedicocorreo_Internalname = "TEXTBLOCKMEDICOCORREO" ;
         edtMedicoCorreo_Internalname = "MEDICOCORREO" ;
         lblTitlemedicoesp_Internalname = "TITLEMEDICOESP" ;
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
         subGridmedico_medicoesp_Internalname = "GRIDMEDICO_MEDICOESP" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Médicos" ;
         edtEspDescripcion_Jsonclick = "" ;
         imgprompt_17_Visible = 1 ;
         imgprompt_17_Link = "" ;
         imgprompt_41_Visible = 1 ;
         edtEspCodigo_Jsonclick = "" ;
         subGridmedico_medicoesp_Class = "Grid" ;
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
         subGridmedico_medicoesp_Allowcollapsing = 0 ;
         edtEspDescripcion_Enabled = 0 ;
         edtEspCodigo_Enabled = 1 ;
         subGridmedico_medicoesp_Backcolorstyle = 2 ;
         edtMedicoCorreo_Jsonclick = "" ;
         edtMedicoCorreo_Enabled = 1 ;
         edtMedicoTelefono2_Jsonclick = "" ;
         edtMedicoTelefono2_Enabled = 1 ;
         edtMedicoTelefono1_Jsonclick = "" ;
         edtMedicoTelefono1_Enabled = 1 ;
         edtMedicoDireccion_Jsonclick = "" ;
         edtMedicoDireccion_Enabled = 1 ;
         edtMedicoColegiado_Jsonclick = "" ;
         edtMedicoColegiado_Enabled = 1 ;
         edtMedicoNombre_Jsonclick = "" ;
         edtMedicoNombre_Enabled = 1 ;
         edtMedicoCodigo_Jsonclick = "" ;
         edtMedicoCodigo_Enabled = 1 ;
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

      protected void gxnrGridmedico_medicoesp_newrow( short nRC_Gridmedico_medicoesp ,
                                                      short nGXsfl_80_idx ,
                                                      String sGXsfl_80_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         edtEspCodigo_Internalname = "ESPCODIGO_"+sGXsfl_80_idx ;
         imgprompt_17_Internalname = "PROMPT_17_"+sGXsfl_80_idx ;
         edtEspDescripcion_Internalname = "ESPDESCRIPCION_"+sGXsfl_80_idx ;
         while ( nGXsfl_80_idx <= nRC_Gridmedico_medicoesp )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0632( ) ;
            standaloneModal0632( ) ;
            dynload_actions( ) ;
            SendRow0632( ) ;
            nGXsfl_80_idx = (short)(nGXsfl_80_idx+1) ;
            sGXsfl_80_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_80_idx), 4, 0)), 4, "0") ;
            edtEspCodigo_Internalname = "ESPCODIGO_"+sGXsfl_80_idx ;
            imgprompt_17_Internalname = "PROMPT_17_"+sGXsfl_80_idx ;
            edtEspDescripcion_Internalname = "ESPDESCRIPCION_"+sGXsfl_80_idx ;
         }
         context.GX_webresponse.AddString(Gridmedico_medicoespContainer.ToJavascriptSource());
         /* End function gxnrGridmedico_medicoesp_newrow */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         /* Using cursor T000626 */
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
         GX_FocusControl = edtMedicoNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Clinicacodigo( String GX_Parm1 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         /* Using cursor T000626 */
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

      public void Valid_Medicocodigo( String GX_Parm1 ,
                                      String GX_Parm2 ,
                                      String GX_Parm3 ,
                                      String GX_Parm4 ,
                                      String GX_Parm5 ,
                                      String GX_Parm6 ,
                                      String GX_Parm7 ,
                                      String GX_Parm8 ,
                                      String GX_Parm9 )
      {
         AV8ClinicaCodigo = GX_Parm1 ;
         A41ClinicaCodigo = GX_Parm2 ;
         A19MedicoCodigo = GX_Parm3 ;
         n19MedicoCodigo = false ;
         A20MedicoNombre = GX_Parm4 ;
         A21MedicoColegiado = GX_Parm5 ;
         A22MedicoDireccion = GX_Parm6 ;
         A23MedicoTelefono1 = GX_Parm7 ;
         A24MedicoTelefono2 = GX_Parm8 ;
         A25MedicoCorreo = GX_Parm9 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A20MedicoNombre)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A21MedicoColegiado)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A22MedicoDireccion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A23MedicoTelefono1)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A24MedicoTelefono2)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A25MedicoCorreo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z19MedicoCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z20MedicoNombre)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z21MedicoColegiado)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z22MedicoDireccion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z23MedicoTelefono1)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z24MedicoTelefono2)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z25MedicoCorreo)));
         isValidOutput.Add((Object)(Gridmedico_medicoespContainer));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Espcodigo( String GX_Parm1 ,
                                   String GX_Parm2 ,
                                   String GX_Parm3 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A17EspCodigo = GX_Parm2 ;
         A18EspDescripcion = GX_Parm3 ;
         /* Using cursor T000624 */
         pr_default.execute(22, new Object[] {A41ClinicaCodigo, A17EspCodigo});
         if ( (pr_default.getStatus(22) == 101) )
         {
            AnyError41 = 1 ;
            AnyError17 = 1 ;
            GX_msglist.addItem("No existe 'Especialidades'.", "ForeignKeyNotFound", 1, "ESPCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtEspCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError17 == 0 ) )
         {
            A18EspDescripcion = T000624_A18EspDescripcion[0] ;
         }
         pr_default.close(22);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A18EspDescripcion = "" ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A18EspDescripcion)));
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
         pr_default.close(22);
         pr_default.close(16);
         pr_default.close(10);
         pr_default.close(9);
         pr_default.close(24);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
         A17EspCodigo = "" ;
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
         lblTextblockmedicocodigo_Jsonclick = "" ;
         A19MedicoCodigo = "" ;
         lblTextblockmediconombre_Jsonclick = "" ;
         A20MedicoNombre = "" ;
         lblTextblockmedicocolegiado_Jsonclick = "" ;
         A21MedicoColegiado = "" ;
         lblTextblockmedicodireccion_Jsonclick = "" ;
         A22MedicoDireccion = "" ;
         lblTextblockmedicotelefono1_Jsonclick = "" ;
         A23MedicoTelefono1 = "" ;
         lblTextblockmedicotelefono2_Jsonclick = "" ;
         A24MedicoTelefono2 = "" ;
         lblTextblockmedicocorreo_Jsonclick = "" ;
         A25MedicoCorreo = "" ;
         Gridmedico_medicoespContainer = new GXWebGrid( context);
         Gridmedico_medicoespColumn = new GXWebColumn();
         A18EspDescripcion = "" ;
         Gx_mode = "" ;
         sMode32 = "" ;
         edtEspCodigo_Internalname = "" ;
         lblTitlemedicoesp_Jsonclick = "" ;
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
         Z19MedicoCodigo = "" ;
         Z20MedicoNombre = "" ;
         Z21MedicoColegiado = "" ;
         Z22MedicoDireccion = "" ;
         Z23MedicoTelefono1 = "" ;
         Z24MedicoTelefono2 = "" ;
         Z25MedicoCorreo = "" ;
         AV8ClinicaCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtEspDescripcion_Internalname = "" ;
         Z17EspCodigo = "" ;
         AV7Parametros = new SdtParametros(context);
         GXt_SdtParametros5 = new SdtParametros(context);
         T00068_A19MedicoCodigo = new String[] {""} ;
         T00068_n19MedicoCodigo = new bool[] {false} ;
         T00068_A20MedicoNombre = new String[] {""} ;
         T00068_A21MedicoColegiado = new String[] {""} ;
         T00068_A22MedicoDireccion = new String[] {""} ;
         T00068_A23MedicoTelefono1 = new String[] {""} ;
         T00068_A24MedicoTelefono2 = new String[] {""} ;
         T00068_A25MedicoCorreo = new String[] {""} ;
         T00068_A41ClinicaCodigo = new String[] {""} ;
         T00067_A41ClinicaCodigo = new String[] {""} ;
         T00069_A41ClinicaCodigo = new String[] {""} ;
         T000610_A41ClinicaCodigo = new String[] {""} ;
         T000610_A19MedicoCodigo = new String[] {""} ;
         T000610_n19MedicoCodigo = new bool[] {false} ;
         T00066_A19MedicoCodigo = new String[] {""} ;
         T00066_n19MedicoCodigo = new bool[] {false} ;
         T00066_A20MedicoNombre = new String[] {""} ;
         T00066_A21MedicoColegiado = new String[] {""} ;
         T00066_A22MedicoDireccion = new String[] {""} ;
         T00066_A23MedicoTelefono1 = new String[] {""} ;
         T00066_A24MedicoTelefono2 = new String[] {""} ;
         T00066_A25MedicoCorreo = new String[] {""} ;
         T00066_A41ClinicaCodigo = new String[] {""} ;
         sMode8 = "" ;
         T000611_A41ClinicaCodigo = new String[] {""} ;
         T000611_A19MedicoCodigo = new String[] {""} ;
         T000611_n19MedicoCodigo = new bool[] {false} ;
         T000612_A41ClinicaCodigo = new String[] {""} ;
         T000612_A19MedicoCodigo = new String[] {""} ;
         T000612_n19MedicoCodigo = new bool[] {false} ;
         T000613_A19MedicoCodigo = new String[] {""} ;
         T000613_n19MedicoCodigo = new bool[] {false} ;
         T000613_A20MedicoNombre = new String[] {""} ;
         T000613_A21MedicoColegiado = new String[] {""} ;
         T000613_A22MedicoDireccion = new String[] {""} ;
         T000613_A23MedicoTelefono1 = new String[] {""} ;
         T000613_A24MedicoTelefono2 = new String[] {""} ;
         T000613_A25MedicoCorreo = new String[] {""} ;
         T000613_A41ClinicaCodigo = new String[] {""} ;
         T000617_A41ClinicaCodigo = new String[] {""} ;
         T000617_A91ConsultaId = new int[1] ;
         T000618_A41ClinicaCodigo = new String[] {""} ;
         T000618_A19MedicoCodigo = new String[] {""} ;
         T000618_n19MedicoCodigo = new bool[] {false} ;
         Z18EspDescripcion = "" ;
         T000619_A19MedicoCodigo = new String[] {""} ;
         T000619_n19MedicoCodigo = new bool[] {false} ;
         T000619_A18EspDescripcion = new String[] {""} ;
         T000619_A41ClinicaCodigo = new String[] {""} ;
         T000619_A17EspCodigo = new String[] {""} ;
         T00064_A18EspDescripcion = new String[] {""} ;
         T000620_A18EspDescripcion = new String[] {""} ;
         T000621_A41ClinicaCodigo = new String[] {""} ;
         T000621_A19MedicoCodigo = new String[] {""} ;
         T000621_n19MedicoCodigo = new bool[] {false} ;
         T000621_A17EspCodigo = new String[] {""} ;
         T00063_A19MedicoCodigo = new String[] {""} ;
         T00063_n19MedicoCodigo = new bool[] {false} ;
         T00063_A41ClinicaCodigo = new String[] {""} ;
         T00063_A17EspCodigo = new String[] {""} ;
         T00062_A19MedicoCodigo = new String[] {""} ;
         T00062_n19MedicoCodigo = new bool[] {false} ;
         T00062_A41ClinicaCodigo = new String[] {""} ;
         T00062_A17EspCodigo = new String[] {""} ;
         T000624_A18EspDescripcion = new String[] {""} ;
         T000625_A41ClinicaCodigo = new String[] {""} ;
         T000625_A19MedicoCodigo = new String[] {""} ;
         T000625_n19MedicoCodigo = new bool[] {false} ;
         T000625_A17EspCodigo = new String[] {""} ;
         imgprompt_17_Internalname = "" ;
         Gridmedico_medicoespRow = new GXWebRow();
         subGridmedico_medicoesp_Linesclass = "" ;
         ROClassString = "" ;
         GXCCtl = "" ;
         GXt_char1 = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char4 = "" ;
         T000626_A41ClinicaCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.medico__default(),
            new Object[][] {
                new Object[] {
               T00062_A19MedicoCodigo, T00062_A41ClinicaCodigo, T00062_A17EspCodigo
               }
               , new Object[] {
               T00063_A19MedicoCodigo, T00063_A41ClinicaCodigo, T00063_A17EspCodigo
               }
               , new Object[] {
               T00064_A18EspDescripcion
               }
               , new Object[] {
               T00065_A19MedicoCodigo, T00065_A20MedicoNombre, T00065_A21MedicoColegiado, T00065_A22MedicoDireccion, T00065_A23MedicoTelefono1, T00065_A24MedicoTelefono2, T00065_A25MedicoCorreo, T00065_A41ClinicaCodigo
               }
               , new Object[] {
               T00066_A19MedicoCodigo, T00066_A20MedicoNombre, T00066_A21MedicoColegiado, T00066_A22MedicoDireccion, T00066_A23MedicoTelefono1, T00066_A24MedicoTelefono2, T00066_A25MedicoCorreo, T00066_A41ClinicaCodigo
               }
               , new Object[] {
               T00067_A41ClinicaCodigo
               }
               , new Object[] {
               T00068_A19MedicoCodigo, T00068_A20MedicoNombre, T00068_A21MedicoColegiado, T00068_A22MedicoDireccion, T00068_A23MedicoTelefono1, T00068_A24MedicoTelefono2, T00068_A25MedicoCorreo, T00068_A41ClinicaCodigo
               }
               , new Object[] {
               T00069_A41ClinicaCodigo
               }
               , new Object[] {
               T000610_A41ClinicaCodigo, T000610_A19MedicoCodigo
               }
               , new Object[] {
               T000611_A41ClinicaCodigo, T000611_A19MedicoCodigo
               }
               , new Object[] {
               T000612_A41ClinicaCodigo, T000612_A19MedicoCodigo
               }
               , new Object[] {
               T000613_A19MedicoCodigo, T000613_A20MedicoNombre, T000613_A21MedicoColegiado, T000613_A22MedicoDireccion, T000613_A23MedicoTelefono1, T000613_A24MedicoTelefono2, T000613_A25MedicoCorreo, T000613_A41ClinicaCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000617_A41ClinicaCodigo, T000617_A91ConsultaId
               }
               , new Object[] {
               T000618_A41ClinicaCodigo, T000618_A19MedicoCodigo
               }
               , new Object[] {
               T000619_A19MedicoCodigo, T000619_A18EspDescripcion, T000619_A41ClinicaCodigo, T000619_A17EspCodigo
               }
               , new Object[] {
               T000620_A18EspDescripcion
               }
               , new Object[] {
               T000621_A41ClinicaCodigo, T000621_A19MedicoCodigo, T000621_A17EspCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000624_A18EspDescripcion
               }
               , new Object[] {
               T000625_A41ClinicaCodigo, T000625_A19MedicoCodigo, T000625_A17EspCodigo
               }
               , new Object[] {
               T000626_A41ClinicaCodigo
               }
            }
         );
      }

      private short nIsMod_32 ;
      private short GxWebError ;
      private short nRC_Gridmedico_medicoesp ;
      private short nGXsfl_80_idx=1 ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGridmedico_medicoesp_Backcolorstyle ;
      private short subGridmedico_medicoesp_Allowcollapsing ;
      private short subGridmedico_medicoesp_Collapsed ;
      private short nBlankRcdCount32 ;
      private short nRcdExists_32 ;
      private short RcdFound32 ;
      private short nBlankRcdUsr32 ;
      private short nRcdDeleted_32 ;
      private short GX_JID ;
      private short RcdFound8 ;
      private short Gx_BScreen ;
      private short subGridmedico_medicoesp_Backstyle ;
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
      private int edtMedicoCodigo_Enabled ;
      private int edtMedicoNombre_Enabled ;
      private int edtMedicoColegiado_Enabled ;
      private int edtMedicoDireccion_Enabled ;
      private int edtMedicoTelefono1_Enabled ;
      private int edtMedicoTelefono2_Enabled ;
      private int edtMedicoCorreo_Enabled ;
      private int edtEspCodigo_Enabled ;
      private int edtEspDescripcion_Enabled ;
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
      private int GRIDMEDICO_MEDICOESP_nFirstRecordOnPage ;
      private int AnyError41 ;
      private int AnyError17 ;
      private int subGridmedico_medicoesp_Backcolor ;
      private int subGridmedico_medicoesp_Allbackcolor ;
      private int imgprompt_17_Visible ;
      private int defedtEspCodigo_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String sGXsfl_80_idx="0001" ;
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
      private String lblTextblockmedicocodigo_Internalname ;
      private String lblTextblockmedicocodigo_Jsonclick ;
      private String edtMedicoCodigo_Internalname ;
      private String edtMedicoCodigo_Jsonclick ;
      private String lblTextblockmediconombre_Internalname ;
      private String lblTextblockmediconombre_Jsonclick ;
      private String edtMedicoNombre_Internalname ;
      private String edtMedicoNombre_Jsonclick ;
      private String lblTextblockmedicocolegiado_Internalname ;
      private String lblTextblockmedicocolegiado_Jsonclick ;
      private String edtMedicoColegiado_Internalname ;
      private String edtMedicoColegiado_Jsonclick ;
      private String lblTextblockmedicodireccion_Internalname ;
      private String lblTextblockmedicodireccion_Jsonclick ;
      private String edtMedicoDireccion_Internalname ;
      private String edtMedicoDireccion_Jsonclick ;
      private String lblTextblockmedicotelefono1_Internalname ;
      private String lblTextblockmedicotelefono1_Jsonclick ;
      private String edtMedicoTelefono1_Internalname ;
      private String edtMedicoTelefono1_Jsonclick ;
      private String lblTextblockmedicotelefono2_Internalname ;
      private String lblTextblockmedicotelefono2_Jsonclick ;
      private String edtMedicoTelefono2_Internalname ;
      private String edtMedicoTelefono2_Jsonclick ;
      private String lblTextblockmedicocorreo_Internalname ;
      private String lblTextblockmedicocorreo_Jsonclick ;
      private String edtMedicoCorreo_Internalname ;
      private String edtMedicoCorreo_Jsonclick ;
      private String Gx_mode ;
      private String sMode32 ;
      private String edtEspCodigo_Internalname ;
      private String tblTable3_Internalname ;
      private String lblTitlemedicoesp_Internalname ;
      private String lblTitlemedicoesp_Jsonclick ;
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
      private String edtEspDescripcion_Internalname ;
      private String sMode8 ;
      private String imgprompt_17_Internalname ;
      private String subGridmedico_medicoesp_Class ;
      private String subGridmedico_medicoesp_Linesclass ;
      private String imgprompt_17_Link ;
      private String ROClassString ;
      private String edtEspCodigo_Jsonclick ;
      private String edtEspDescripcion_Jsonclick ;
      private String GXCCtl ;
      private String GXt_char1 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String subGridmedico_medicoesp_Internalname ;
      private String GXt_char4 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n19MedicoCodigo ;
      private bool Gx_longc ;
      private String A41ClinicaCodigo ;
      private String A17EspCodigo ;
      private String A19MedicoCodigo ;
      private String A20MedicoNombre ;
      private String A21MedicoColegiado ;
      private String A22MedicoDireccion ;
      private String A23MedicoTelefono1 ;
      private String A24MedicoTelefono2 ;
      private String A25MedicoCorreo ;
      private String A18EspDescripcion ;
      private String Z41ClinicaCodigo ;
      private String Z19MedicoCodigo ;
      private String Z20MedicoNombre ;
      private String Z21MedicoColegiado ;
      private String Z22MedicoDireccion ;
      private String Z23MedicoTelefono1 ;
      private String Z24MedicoTelefono2 ;
      private String Z25MedicoCorreo ;
      private String AV8ClinicaCodigo ;
      private String Z17EspCodigo ;
      private String Z18EspDescripcion ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Gridmedico_medicoespContainer ;
      private GXWebRow Gridmedico_medicoespRow ;
      private GXWebColumn Gridmedico_medicoespColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00068_A19MedicoCodigo ;
      private bool[] T00068_n19MedicoCodigo ;
      private String[] T00068_A20MedicoNombre ;
      private String[] T00068_A21MedicoColegiado ;
      private String[] T00068_A22MedicoDireccion ;
      private String[] T00068_A23MedicoTelefono1 ;
      private String[] T00068_A24MedicoTelefono2 ;
      private String[] T00068_A25MedicoCorreo ;
      private String[] T00068_A41ClinicaCodigo ;
      private String[] T00067_A41ClinicaCodigo ;
      private String[] T00069_A41ClinicaCodigo ;
      private String[] T000610_A41ClinicaCodigo ;
      private String[] T000610_A19MedicoCodigo ;
      private bool[] T000610_n19MedicoCodigo ;
      private String[] T00066_A19MedicoCodigo ;
      private bool[] T00066_n19MedicoCodigo ;
      private String[] T00066_A20MedicoNombre ;
      private String[] T00066_A21MedicoColegiado ;
      private String[] T00066_A22MedicoDireccion ;
      private String[] T00066_A23MedicoTelefono1 ;
      private String[] T00066_A24MedicoTelefono2 ;
      private String[] T00066_A25MedicoCorreo ;
      private String[] T00066_A41ClinicaCodigo ;
      private String[] T000611_A41ClinicaCodigo ;
      private String[] T000611_A19MedicoCodigo ;
      private bool[] T000611_n19MedicoCodigo ;
      private String[] T000612_A41ClinicaCodigo ;
      private String[] T000612_A19MedicoCodigo ;
      private bool[] T000612_n19MedicoCodigo ;
      private String[] T000613_A19MedicoCodigo ;
      private bool[] T000613_n19MedicoCodigo ;
      private String[] T000613_A20MedicoNombre ;
      private String[] T000613_A21MedicoColegiado ;
      private String[] T000613_A22MedicoDireccion ;
      private String[] T000613_A23MedicoTelefono1 ;
      private String[] T000613_A24MedicoTelefono2 ;
      private String[] T000613_A25MedicoCorreo ;
      private String[] T000613_A41ClinicaCodigo ;
      private String[] T000617_A41ClinicaCodigo ;
      private int[] T000617_A91ConsultaId ;
      private String[] T000618_A41ClinicaCodigo ;
      private String[] T000618_A19MedicoCodigo ;
      private bool[] T000618_n19MedicoCodigo ;
      private String[] T000619_A19MedicoCodigo ;
      private bool[] T000619_n19MedicoCodigo ;
      private String[] T000619_A18EspDescripcion ;
      private String[] T000619_A41ClinicaCodigo ;
      private String[] T000619_A17EspCodigo ;
      private String[] T00064_A18EspDescripcion ;
      private String[] T000620_A18EspDescripcion ;
      private String[] T000621_A41ClinicaCodigo ;
      private String[] T000621_A19MedicoCodigo ;
      private bool[] T000621_n19MedicoCodigo ;
      private String[] T000621_A17EspCodigo ;
      private String[] T00063_A19MedicoCodigo ;
      private bool[] T00063_n19MedicoCodigo ;
      private String[] T00063_A41ClinicaCodigo ;
      private String[] T00063_A17EspCodigo ;
      private String[] T00062_A19MedicoCodigo ;
      private bool[] T00062_n19MedicoCodigo ;
      private String[] T00062_A41ClinicaCodigo ;
      private String[] T00062_A17EspCodigo ;
      private String[] T000624_A18EspDescripcion ;
      private String[] T000625_A41ClinicaCodigo ;
      private String[] T000625_A19MedicoCodigo ;
      private bool[] T000625_n19MedicoCodigo ;
      private String[] T000625_A17EspCodigo ;
      private String[] T000626_A41ClinicaCodigo ;
      private String[] T00065_A19MedicoCodigo ;
      private String[] T00065_A20MedicoNombre ;
      private String[] T00065_A21MedicoColegiado ;
      private String[] T00065_A22MedicoDireccion ;
      private String[] T00065_A23MedicoTelefono1 ;
      private String[] T00065_A24MedicoTelefono2 ;
      private String[] T00065_A25MedicoCorreo ;
      private String[] T00065_A41ClinicaCodigo ;
      private GXWebForm Form ;
      private SdtParametros AV7Parametros ;
      private SdtParametros GXt_SdtParametros5 ;
   }

   public class medico__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[12])
         ,new UpdateCursor(def[13])
         ,new UpdateCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new UpdateCursor(def[20])
         ,new UpdateCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new ForEachCursor(def[24])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00065 ;
          prmT00065 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00068 ;
          prmT00068 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00067 ;
          prmT00067 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00069 ;
          prmT00069 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000610 ;
          prmT000610 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00066 ;
          prmT00066 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000611 ;
          prmT000611 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000612 ;
          prmT000612 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000613 ;
          prmT000613 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000614 ;
          prmT000614 = new Object[] {
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoNombre",SqlDbType.VarChar,100,0} ,
          new Object[] {"@MedicoColegiado",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoDireccion",SqlDbType.VarChar,120,0} ,
          new Object[] {"@MedicoTelefono1",SqlDbType.VarChar,9,0} ,
          new Object[] {"@MedicoTelefono2",SqlDbType.VarChar,9,0} ,
          new Object[] {"@MedicoCorreo",SqlDbType.VarChar,80,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000615 ;
          prmT000615 = new Object[] {
          new Object[] {"@MedicoNombre",SqlDbType.VarChar,100,0} ,
          new Object[] {"@MedicoColegiado",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoDireccion",SqlDbType.VarChar,120,0} ,
          new Object[] {"@MedicoTelefono1",SqlDbType.VarChar,9,0} ,
          new Object[] {"@MedicoTelefono2",SqlDbType.VarChar,9,0} ,
          new Object[] {"@MedicoCorreo",SqlDbType.VarChar,80,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000616 ;
          prmT000616 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000617 ;
          prmT000617 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000618 ;
          prmT000618 = new Object[] {
          } ;
          Object[] prmT000619 ;
          prmT000619 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@EspCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00064 ;
          prmT00064 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@EspCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000620 ;
          prmT000620 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@EspCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000621 ;
          prmT000621 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@EspCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00063 ;
          prmT00063 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@EspCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00062 ;
          prmT00062 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@EspCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000622 ;
          prmT000622 = new Object[] {
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@EspCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000623 ;
          prmT000623 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@EspCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000625 ;
          prmT000625 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000626 ;
          prmT000626 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000624 ;
          prmT000624 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@EspCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00062", "SELECT [MedicoCodigo], [ClinicaCodigo], [EspCodigo] FROM [MedicoEsp] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [MedicoCodigo] = @MedicoCodigo AND [EspCodigo] = @EspCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00062,1,0,true,false )
             ,new CursorDef("T00063", "SELECT [MedicoCodigo], [ClinicaCodigo], [EspCodigo] FROM [MedicoEsp] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [MedicoCodigo] = @MedicoCodigo AND [EspCodigo] = @EspCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00063,1,0,true,false )
             ,new CursorDef("T00064", "SELECT [EspDescripcion] FROM [Especialidad] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [EspCodigo] = @EspCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00064,1,0,true,false )
             ,new CursorDef("T00065", "SELECT [MedicoCodigo], [MedicoNombre], [MedicoColegiado], [MedicoDireccion], [MedicoTelefono1], [MedicoTelefono2], [MedicoCorreo], [ClinicaCodigo] FROM [Medico] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [MedicoCodigo] = @MedicoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00065,1,0,true,false )
             ,new CursorDef("T00066", "SELECT [MedicoCodigo], [MedicoNombre], [MedicoColegiado], [MedicoDireccion], [MedicoTelefono1], [MedicoTelefono2], [MedicoCorreo], [ClinicaCodigo] FROM [Medico] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [MedicoCodigo] = @MedicoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00066,1,0,true,false )
             ,new CursorDef("T00067", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00067,1,0,true,false )
             ,new CursorDef("T00068", "SELECT TM1.[MedicoCodigo], TM1.[MedicoNombre], TM1.[MedicoColegiado], TM1.[MedicoDireccion], TM1.[MedicoTelefono1], TM1.[MedicoTelefono2], TM1.[MedicoCorreo], TM1.[ClinicaCodigo] FROM [Medico] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[MedicoCodigo] = @MedicoCodigo ORDER BY TM1.[ClinicaCodigo], TM1.[MedicoCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00068,100,0,true,false )
             ,new CursorDef("T00069", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00069,1,0,true,false )
             ,new CursorDef("T000610", "SELECT [ClinicaCodigo], [MedicoCodigo] FROM [Medico] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [MedicoCodigo] = @MedicoCodigo  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000610,1,0,true,false )
             ,new CursorDef("T000611", "SELECT TOP 1 [ClinicaCodigo], [MedicoCodigo] FROM [Medico] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [MedicoCodigo] > @MedicoCodigo) ORDER BY [ClinicaCodigo], [MedicoCodigo]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000611,1,0,true,true )
             ,new CursorDef("T000612", "SELECT TOP 1 [ClinicaCodigo], [MedicoCodigo] FROM [Medico] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [MedicoCodigo] < @MedicoCodigo) ORDER BY [ClinicaCodigo] DESC, [MedicoCodigo] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000612,1,0,true,true )
             ,new CursorDef("T000613", "SELECT [MedicoCodigo], [MedicoNombre], [MedicoColegiado], [MedicoDireccion], [MedicoTelefono1], [MedicoTelefono2], [MedicoCorreo], [ClinicaCodigo] FROM [Medico] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [MedicoCodigo] = @MedicoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000613,1,0,true,false )
             ,new CursorDef("T000614", "INSERT INTO [Medico] ([MedicoCodigo], [MedicoNombre], [MedicoColegiado], [MedicoDireccion], [MedicoTelefono1], [MedicoTelefono2], [MedicoCorreo], [ClinicaCodigo]) VALUES (@MedicoCodigo, @MedicoNombre, @MedicoColegiado, @MedicoDireccion, @MedicoTelefono1, @MedicoTelefono2, @MedicoCorreo, @ClinicaCodigo)", GxErrorMask.GX_NOMASK,prmT000614)
             ,new CursorDef("T000615", "UPDATE [Medico] SET [MedicoNombre]=@MedicoNombre, [MedicoColegiado]=@MedicoColegiado, [MedicoDireccion]=@MedicoDireccion, [MedicoTelefono1]=@MedicoTelefono1, [MedicoTelefono2]=@MedicoTelefono2, [MedicoCorreo]=@MedicoCorreo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [MedicoCodigo] = @MedicoCodigo", GxErrorMask.GX_NOMASK,prmT000615)
             ,new CursorDef("T000616", "DELETE FROM [Medico]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [MedicoCodigo] = @MedicoCodigo", GxErrorMask.GX_NOMASK,prmT000616)
             ,new CursorDef("T000617", "SELECT TOP 1 [ClinicaCodigo], [ConsultaId] FROM [Consulta] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [MedicoCodigo] = @MedicoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000617,1,0,true,true )
             ,new CursorDef("T000618", "SELECT [ClinicaCodigo], [MedicoCodigo] FROM [Medico] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [MedicoCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000618,100,0,true,false )
             ,new CursorDef("T000619", "SELECT T1.[MedicoCodigo], T2.[EspDescripcion], T1.[ClinicaCodigo], T1.[EspCodigo] FROM ([MedicoEsp] T1 WITH (NOLOCK) INNER JOIN [Especialidad] T2 WITH (NOLOCK) ON T2.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T2.[EspCodigo] = T1.[EspCodigo]) WHERE T1.[ClinicaCodigo] = @ClinicaCodigo and T1.[MedicoCodigo] = @MedicoCodigo and T1.[EspCodigo] = @EspCodigo ORDER BY T1.[ClinicaCodigo], T1.[MedicoCodigo], T1.[EspCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000619,11,0,true,false )
             ,new CursorDef("T000620", "SELECT [EspDescripcion] FROM [Especialidad] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [EspCodigo] = @EspCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000620,1,0,true,false )
             ,new CursorDef("T000621", "SELECT [ClinicaCodigo], [MedicoCodigo], [EspCodigo] FROM [MedicoEsp] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [MedicoCodigo] = @MedicoCodigo AND [EspCodigo] = @EspCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000621,1,0,true,false )
             ,new CursorDef("T000622", "INSERT INTO [MedicoEsp] ([MedicoCodigo], [ClinicaCodigo], [EspCodigo]) VALUES (@MedicoCodigo, @ClinicaCodigo, @EspCodigo)", GxErrorMask.GX_NOMASK,prmT000622)
             ,new CursorDef("T000623", "DELETE FROM [MedicoEsp]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [MedicoCodigo] = @MedicoCodigo AND [EspCodigo] = @EspCodigo", GxErrorMask.GX_NOMASK,prmT000623)
             ,new CursorDef("T000624", "SELECT [EspDescripcion] FROM [Especialidad] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [EspCodigo] = @EspCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000624,1,0,true,false )
             ,new CursorDef("T000625", "SELECT [ClinicaCodigo], [MedicoCodigo], [EspCodigo] FROM [MedicoEsp] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [MedicoCodigo] = @MedicoCodigo ORDER BY [ClinicaCodigo], [MedicoCodigo], [EspCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000625,11,0,true,false )
             ,new CursorDef("T000626", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000626,1,0,true,false )
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
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
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
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
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
                break;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 23 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
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
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                stmt.SetParameter(3, (String)parms[3]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                stmt.SetParameter(3, (String)parms[3]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                break;
             case 12 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                stmt.SetParameter(2, (String)parms[2]);
                stmt.SetParameter(3, (String)parms[3]);
                stmt.SetParameter(4, (String)parms[4]);
                stmt.SetParameter(5, (String)parms[5]);
                stmt.SetParameter(6, (String)parms[6]);
                stmt.SetParameter(7, (String)parms[7]);
                stmt.SetParameter(8, (String)parms[8]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 8 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[8]);
                }
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                break;
             case 15 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                break;
             case 17 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                stmt.SetParameter(3, (String)parms[3]);
                break;
             case 18 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 19 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                stmt.SetParameter(3, (String)parms[3]);
                break;
             case 20 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                stmt.SetParameter(2, (String)parms[2]);
                stmt.SetParameter(3, (String)parms[3]);
                break;
             case 21 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                stmt.SetParameter(3, (String)parms[3]);
                break;
             case 22 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 23 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                break;
             case 24 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
