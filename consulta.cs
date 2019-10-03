/*
               File: Consulta
        Description: Consulta de pacientes
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:5:2.47
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
   public class consulta : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A19MedicoCodigo = GetNextPar( ) ;
            n19MedicoCodigo = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_5( A41ClinicaCodigo, A19MedicoCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_6") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A50Cie10Codigo = GetNextPar( ) ;
            n50Cie10Codigo = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50Cie10Codigo", A50Cie10Codigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_6( A41ClinicaCodigo, A50Cie10Codigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_7") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A67PacienteId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_7( A41ClinicaCodigo, A67PacienteId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_8") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A82AsegCodigo = GetNextPar( ) ;
            n82AsegCodigo = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A82AsegCodigo", A82AsegCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_8( A41ClinicaCodigo, A82AsegCodigo) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridconsulta_signo") == 0 )
         {
            nRC_Gridconsulta_signo = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            nGXsfl_115_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_115_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGridconsulta_signo_newrow( nRC_Gridconsulta_signo, nGXsfl_115_idx, sGXsfl_115_idx) ;
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
         cmbConsultaTipo.Name = "CONSULTATIPO" ;
         cmbConsultaTipo.WebTags = "" ;
         cmbConsultaTipo.addItem("1", "Consulta en clínica", 0);
         cmbConsultaTipo.addItem("2", "Consulta telefónica", 0);
         cmbConsultaTipo.addItem("3", "En hospital", 0);
         cmbConsultaTipo.addItem("4", "A domicilio", 0);
         if ( ( cmbConsultaTipo.ItemCount > 0 ) && (0==A94ConsultaTipo) )
         {
            A94ConsultaTipo = (short)(NumberUtil.Val( cmbConsultaTipo.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94ConsultaTipo", StringUtil.Str( (decimal)(A94ConsultaTipo), 1, 0));
         }
         cmbConsultaEstado.Name = "CONSULTAESTADO" ;
         cmbConsultaEstado.WebTags = "" ;
         cmbConsultaEstado.addItem("1", "Creado", 0);
         cmbConsultaEstado.addItem("2", "Finalizado", 0);
         cmbConsultaEstado.addItem("3", "Facturado", 0);
         cmbConsultaEstado.addItem("4", "Cancelado", 0);
         if ( ( cmbConsultaEstado.ItemCount > 0 ) && (0==A159ConsultaEstado) )
         {
            A159ConsultaEstado = (short)(NumberUtil.Val( cmbConsultaEstado.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159ConsultaEstado", StringUtil.Str( (decimal)(A159ConsultaEstado), 1, 0));
         }
         GXCCtl = "SIGNOESTATURAEN_" + sGXsfl_115_idx ;
         cmbSignoEstaturaEn.Name = GXCCtl ;
         cmbSignoEstaturaEn.WebTags = "" ;
         cmbSignoEstaturaEn.addItem("CM", "Centímetros", 0);
         cmbSignoEstaturaEn.addItem("ME", "Metros", 0);
         if ( ( cmbSignoEstaturaEn.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A98SignoEstaturaEn)) )
         {
            A98SignoEstaturaEn = cmbSignoEstaturaEn.getItemValue(1) ;
         }
         GXCCtl = "SIGNOPESOEN_" + sGXsfl_115_idx ;
         cmbSignoPesoEn.Name = GXCCtl ;
         cmbSignoPesoEn.WebTags = "" ;
         cmbSignoPesoEn.addItem("Lb", "Libras", 0);
         cmbSignoPesoEn.addItem("Gr", "Gramos", 0);
         cmbSignoPesoEn.addItem("Kg", "KGramos", 0);
         if ( ( cmbSignoPesoEn.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A100SignoPesoEn)) )
         {
            A100SignoPesoEn = cmbSignoPesoEn.getItemValue(1) ;
         }
         GXCCtl = "SIGNOTEMPERATURADE_" + sGXsfl_115_idx ;
         cmbSignoTemperaturaDe.Name = GXCCtl ;
         cmbSignoTemperaturaDe.WebTags = "" ;
         cmbSignoTemperaturaDe.addItem("Or", "Oral", 0);
         cmbSignoTemperaturaDe.addItem("Ax", "Axilar", 0);
         cmbSignoTemperaturaDe.addItem("Re", "Rectal", 0);
         cmbSignoTemperaturaDe.addItem("Fr", "Frontal", 0);
         if ( ( cmbSignoTemperaturaDe.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A102SignoTemperaturaDe)) )
         {
            A102SignoTemperaturaDe = cmbSignoTemperaturaDe.getItemValue(1) ;
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Consulta de pacientes", 0) ;
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

      public consulta( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public consulta( IGxContext context )
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
         cmbConsultaTipo = new GXCombobox();
         cmbConsultaEstado = new GXCombobox();
         cmbSignoEstaturaEn = new GXCombobox();
         cmbSignoPesoEn = new GXCombobox();
         cmbSignoTemperaturaDe = new GXCombobox();
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
            wb_table1_2_0J25( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0J25e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0J25( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0J25( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0J25e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Consulta de pacientes"+"</legend>") ;
            wb_table3_27_0J25( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0J25e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0J25e( true) ;
         }
         else
         {
            wb_table1_2_0J25e( false) ;
         }
      }

      protected void wb_table3_27_0J25( bool wbgen )
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
            wb_table4_33_0J25( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0J25e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 131,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Consulta.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 132,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Consulta.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 133,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0J25e( true) ;
         }
         else
         {
            wb_table3_27_0J25e( false) ;
         }
      }

      protected void wb_table4_33_0J25( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockconsultaid_Internalname, "Consulta", "", "", lblTextblockconsultaid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtConsultaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A91ConsultaId), 9, 0, ".", "")), ((edtConsultaId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A91ConsultaId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A91ConsultaId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(43);\"", "", "", "", "", edtConsultaId_Jsonclick, 0, ClassString, StyleString, "", 1, edtConsultaId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockconsultafecha_Internalname, "Fecha", "", "", lblTextblockconsultafecha_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92ConsultaFecha", context.localUtil.Format(A92ConsultaFecha, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtConsultaFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtConsultaFecha_Internalname, context.localUtil.Format(A92ConsultaFecha, "99/99/99"), context.localUtil.Format( A92ConsultaFecha, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(48);\"", "", "", "", "", edtConsultaFecha_Jsonclick, 0, ClassString, StyleString, "", 1, edtConsultaFecha_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_Consulta.htm");
            GxWebStd.gx_bitmap( context, edtConsultaFecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtConsultaFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Consulta.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockconsultahora_Internalname, "Hora", "", "", lblTextblockconsultahora_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93ConsultaHora", A93ConsultaHora);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtConsultaHora_Internalname, StringUtil.RTrim( A93ConsultaHora), StringUtil.RTrim( context.localUtil.Format( A93ConsultaHora, "XXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "", "", "", "", edtConsultaHora_Jsonclick, 0, ClassString, StyleString, "", 1, edtConsultaHora_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "left", "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacienteid_Internalname, "Paciente", "", "", lblTextblockpacienteid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPacienteId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A67PacienteId), 9, 0, ".", "")), ((edtPacienteId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A67PacienteId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A67PacienteId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(58);\"", "", "", "", "", edtPacienteId_Jsonclick, 0, ClassString, StyleString, "", 1, edtPacienteId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Consulta.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_67_Internalname, "prompt.gif", imgprompt_41_67_Link, "", "", "Fantastic", imgprompt_41_67_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockconsultaedad_Internalname, "Edad", "", "", lblTextblockconsultaedad_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157ConsultaEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A157ConsultaEdad), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtConsultaEdad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A157ConsultaEdad), 4, 0, ".", "")), ((edtConsultaEdad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A157ConsultaEdad), "ZZZ9")) : context.localUtil.Format( (decimal)(A157ConsultaEdad), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(63);\"", "", "", "", "", edtConsultaEdad_Jsonclick, 0, ClassString, StyleString, "", 1, edtConsultaEdad_Enabled, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockconsultatipo_Internalname, "Consulta", "", "", lblTextblockconsultatipo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94ConsultaTipo", StringUtil.Str( (decimal)(A94ConsultaTipo), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbConsultaTipo, cmbConsultaTipo_Internalname, StringUtil.Str( (decimal)(A94ConsultaTipo), 1, 0), 1, cmbConsultaTipo_Jsonclick, 0, "", "int", "", 1, cmbConsultaTipo.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", "", true, "HLP_Consulta.htm");
            cmbConsultaTipo.CurrentValue = StringUtil.Str( (decimal)(A94ConsultaTipo), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbConsultaTipo_Internalname, "Values", (String)(cmbConsultaTipo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockasegcodigo_Internalname, "Aseguradora", "", "", lblTextblockasegcodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A82AsegCodigo", A82AsegCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtAsegCodigo_Internalname, StringUtil.RTrim( A82AsegCodigo), StringUtil.RTrim( context.localUtil.Format( A82AsegCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(73);\"", "", "", "", "", edtAsegCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtAsegCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Consulta.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_82_Internalname, "prompt.gif", imgprompt_41_82_Link, "", "", "Fantastic", imgprompt_41_82_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockconsultapoliza_Internalname, "Certificado", "", "", lblTextblockconsultapoliza_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158ConsultaPoliza", A158ConsultaPoliza);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtConsultaPoliza_Internalname, StringUtil.RTrim( A158ConsultaPoliza), StringUtil.RTrim( context.localUtil.Format( A158ConsultaPoliza, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(78);\"", "", "", "", "", edtConsultaPoliza_Jsonclick, 0, ClassString, StyleString, "", 1, edtConsultaPoliza_Enabled, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockconsultaobs_Internalname, "Observaciones", "", "", lblTextblockconsultaobs_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A95ConsultaObs", A95ConsultaObs);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtConsultaObs_Internalname, StringUtil.RTrim( A95ConsultaObs), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(83);\"", 0, 1, edtConsultaObs_Enabled, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcie10codigo_Internalname, "Código", "", "", lblTextblockcie10codigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50Cie10Codigo", A50Cie10Codigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCie10Codigo_Internalname, StringUtil.RTrim( A50Cie10Codigo), StringUtil.RTrim( context.localUtil.Format( A50Cie10Codigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(88);\"", "", "", "", "", edtCie10Codigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtCie10Codigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Consulta.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_50_Internalname, "prompt.gif", imgprompt_41_50_Link, "", "", "Fantastic", imgprompt_41_50_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockconsultaestado_Internalname, "Estado", "", "", lblTextblockconsultaestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159ConsultaEstado", StringUtil.Str( (decimal)(A159ConsultaEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbConsultaEstado, cmbConsultaEstado_Internalname, StringUtil.Str( (decimal)(A159ConsultaEstado), 1, 0), 1, cmbConsultaEstado_Jsonclick, 0, "", "int", "", 1, cmbConsultaEstado.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(93);\"", "", true, "HLP_Consulta.htm");
            cmbConsultaEstado.CurrentValue = StringUtil.Str( (decimal)(A159ConsultaEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbConsultaEstado_Internalname, "Values", (String)(cmbConsultaEstado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockconsultafechafin_Internalname, "Finaliza", "", "", lblTextblockconsultafechafin_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A160ConsultaFechaFin", context.localUtil.Format(A160ConsultaFechaFin, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtConsultaFechaFin_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtConsultaFechaFin_Internalname, context.localUtil.Format(A160ConsultaFechaFin, "99/99/99"), context.localUtil.Format( A160ConsultaFechaFin, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(98);\"", "", "", "", "", edtConsultaFechaFin_Jsonclick, 0, ClassString, StyleString, "", 1, edtConsultaFechaFin_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_Consulta.htm");
            GxWebStd.gx_bitmap( context, edtConsultaFechaFin_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtConsultaFechaFin_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Consulta.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockconsultahorafin_Internalname, "Finaliza", "", "", lblTextblockconsultahorafin_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161ConsultaHoraFin", A161ConsultaHoraFin);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtConsultaHoraFin_Internalname, StringUtil.RTrim( A161ConsultaHoraFin), StringUtil.RTrim( context.localUtil.Format( A161ConsultaHoraFin, "XXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(103);\"", "", "", "", "", edtConsultaHoraFin_Jsonclick, 0, ClassString, StyleString, "", 1, edtConsultaHoraFin_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "left", "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmedicocodigo_Internalname, "Código", "", "", lblTextblockmedicocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 108,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMedicoCodigo_Internalname, StringUtil.RTrim( A19MedicoCodigo), StringUtil.RTrim( context.localUtil.Format( A19MedicoCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(108);\"", "", "", "", "", edtMedicoCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtMedicoCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Consulta.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_19_Internalname, "prompt.gif", imgprompt_41_19_Link, "", "", "Fantastic", imgprompt_41_19_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "<br>") ;
            wb_table5_111_0J25( true) ;
         }
         return  ;
      }

      protected void wb_table5_111_0J25e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<hr class=\"HRDefault\">") ;
            /*  Grid Control  */
            Gridconsulta_signoContainer.AddObjectProperty("GridName", "Gridconsulta_signo");
            Gridconsulta_signoContainer.AddObjectProperty("Class", "Grid");
            Gridconsulta_signoContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Gridconsulta_signoContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Gridconsulta_signoContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridconsulta_signo_Backcolorstyle), 1, 0, ".", "")));
            Gridconsulta_signoContainer.AddObjectProperty("CmpContext", "");
            Gridconsulta_signoContainer.AddObjectProperty("InMasterPage", "false");
            Gridconsulta_signoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridconsulta_signoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A96SignoLinea), 4, 0, ".", "")));
            Gridconsulta_signoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoLinea_Enabled), 5, 0, ".", "")));
            Gridconsulta_signoContainer.AddColumnProperties(Gridconsulta_signoColumn);
            Gridconsulta_signoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridconsulta_signoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A97SignoEstatura, 8, 2, ".", "")));
            Gridconsulta_signoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoEstatura_Enabled), 5, 0, ".", "")));
            Gridconsulta_signoContainer.AddColumnProperties(Gridconsulta_signoColumn);
            Gridconsulta_signoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridconsulta_signoColumn.AddObjectProperty("Value", StringUtil.RTrim( A98SignoEstaturaEn));
            Gridconsulta_signoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbSignoEstaturaEn.Enabled), 5, 0, ".", "")));
            Gridconsulta_signoContainer.AddColumnProperties(Gridconsulta_signoColumn);
            Gridconsulta_signoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridconsulta_signoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A99SignoPeso, 8, 2, ".", "")));
            Gridconsulta_signoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoPeso_Enabled), 5, 0, ".", "")));
            Gridconsulta_signoContainer.AddColumnProperties(Gridconsulta_signoColumn);
            Gridconsulta_signoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridconsulta_signoColumn.AddObjectProperty("Value", StringUtil.RTrim( A100SignoPesoEn));
            Gridconsulta_signoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbSignoPesoEn.Enabled), 5, 0, ".", "")));
            Gridconsulta_signoContainer.AddColumnProperties(Gridconsulta_signoColumn);
            Gridconsulta_signoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridconsulta_signoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A101SignoTemperatura, 8, 2, ".", "")));
            Gridconsulta_signoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoTemperatura_Enabled), 5, 0, ".", "")));
            Gridconsulta_signoContainer.AddColumnProperties(Gridconsulta_signoColumn);
            Gridconsulta_signoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridconsulta_signoColumn.AddObjectProperty("Value", StringUtil.RTrim( A102SignoTemperaturaDe));
            Gridconsulta_signoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbSignoTemperaturaDe.Enabled), 5, 0, ".", "")));
            Gridconsulta_signoContainer.AddColumnProperties(Gridconsulta_signoColumn);
            Gridconsulta_signoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridconsulta_signoColumn.AddObjectProperty("Value", StringUtil.RTrim( A103SignoPresionArterial));
            Gridconsulta_signoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoPresionArterial_Enabled), 5, 0, ".", "")));
            Gridconsulta_signoContainer.AddColumnProperties(Gridconsulta_signoColumn);
            Gridconsulta_signoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridconsulta_signoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A104SignoFrecCardiaca, 8, 2, ".", "")));
            Gridconsulta_signoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoFrecCardiaca_Enabled), 5, 0, ".", "")));
            Gridconsulta_signoContainer.AddColumnProperties(Gridconsulta_signoColumn);
            Gridconsulta_signoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridconsulta_signoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A105SignoFrecRespiratoria, 8, 2, ".", "")));
            Gridconsulta_signoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoFrecRespiratoria_Enabled), 5, 0, ".", "")));
            Gridconsulta_signoContainer.AddColumnProperties(Gridconsulta_signoColumn);
            Gridconsulta_signoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridconsulta_signoColumn.AddObjectProperty("Value", context.localUtil.Format(A106SignoFecha, "99/99/99"));
            Gridconsulta_signoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoFecha_Enabled), 5, 0, ".", "")));
            Gridconsulta_signoContainer.AddColumnProperties(Gridconsulta_signoColumn);
            Gridconsulta_signoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridconsulta_signoColumn.AddObjectProperty("Value", StringUtil.RTrim( A107SignoHora));
            Gridconsulta_signoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoHora_Enabled), 5, 0, ".", "")));
            Gridconsulta_signoContainer.AddColumnProperties(Gridconsulta_signoColumn);
            Gridconsulta_signoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridconsulta_signoColumn.AddObjectProperty("Value", StringUtil.RTrim( A108SignoObs));
            Gridconsulta_signoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoObs_Enabled), 5, 0, ".", "")));
            Gridconsulta_signoContainer.AddColumnProperties(Gridconsulta_signoColumn);
            Gridconsulta_signoContainer.AddObjectProperty("Allowselection", "false");
            Gridconsulta_signoContainer.AddObjectProperty("Allowcollapsing", ((subGridconsulta_signo_Allowcollapsing==1) ? "true" : "false"));
            Gridconsulta_signoContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridconsulta_signo_Collapsed), 9, 0, ".", "")));
            nGXsfl_115_idx = 0 ;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount26 = 5 ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_26 = 1 ;
                  ScanStart0J26( ) ;
                  while ( RcdFound26 != 0 )
                  {
                     init_level_properties26( ) ;
                     getByPrimaryKey0J26( ) ;
                     AddRow0J26( ) ;
                     ScanNext0J26( ) ;
                  }
                  ScanEnd0J26( ) ;
                  nBlankRcdCount26 = 5 ;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               standaloneNotModal0J26( ) ;
               standaloneModal0J26( ) ;
               sMode26 = Gx_mode ;
               while ( nGXsfl_115_idx < nRC_Gridconsulta_signo )
               {
                  ReadRow0J26( ) ;
                  edtSignoLinea_Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOLINEA_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
                  edtSignoEstatura_Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOESTATURA_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
                  cmbSignoEstaturaEn.Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOESTATURAEN_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
                  edtSignoPeso_Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOPESO_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
                  cmbSignoPesoEn.Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOPESOEN_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
                  edtSignoTemperatura_Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOTEMPERATURA_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
                  cmbSignoTemperaturaDe.Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOTEMPERATURADE_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
                  edtSignoPresionArterial_Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOPRESIONARTERIAL_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
                  edtSignoFrecCardiaca_Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOFRECCARDIACA_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
                  edtSignoFrecRespiratoria_Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOFRECRESPIRATORIA_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
                  edtSignoFecha_Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOFECHA_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
                  edtSignoHora_Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOHORA_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
                  edtSignoObs_Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOOBS_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
                  if ( ( nRcdExists_26 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal0J26( ) ;
                  }
                  SendRow0J26( ) ;
               }
               Gx_mode = sMode26 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount26 = 5 ;
               nRcdExists_26 = 1 ;
               ScanStart0J26( ) ;
               while ( RcdFound26 != 0 )
               {
                  init_level_properties26( ) ;
                  getByPrimaryKey0J26( ) ;
                  standaloneNotModal0J26( ) ;
                  standaloneModal0J26( ) ;
                  AddRow0J26( ) ;
                  ScanNext0J26( ) ;
               }
               ScanEnd0J26( ) ;
            }
            /* Initialize fields for 'new' records and send them. */
            sMode26 = Gx_mode ;
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            InitAll0J26( ) ;
            init_level_properties26( ) ;
            standaloneNotModal0J26( ) ;
            standaloneModal0J26( ) ;
            nRcdExists_26 = 0 ;
            nIsMod_26 = 0 ;
            nBlankRcdCount26 = (short)(nBlankRcdUsr26+nBlankRcdCount26) ;
            fRowAdded = 0 ;
            while ( nBlankRcdCount26 > 0 )
            {
               AddRow0J26( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1 ;
                  GX_FocusControl = edtSignoLinea_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount26 = (short)(nBlankRcdCount26-1) ;
            }
            Gx_mode = sMode26 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            sStyleString = " style=\"display:none;\"" ;
            sStyleString = "" ;
            context.WriteHtmlText( "<div id=\""+"Gridconsulta_signoContainer"+"Div\" "+sStyleString+">"+"</div>") ;
            context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridconsulta_signo", (Object)(Gridconsulta_signoContainer));
            GxWebStd.gx_hidden_field( context, "Gridconsulta_signoContainerData", Gridconsulta_signoContainer.ToJavascriptSource());
            if ( context.isAjaxRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Gridconsulta_signoContainerData"+"V", Gridconsulta_signoContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridconsulta_signoContainerData"+"V"+"\" value='"+Gridconsulta_signoContainer.GridValuesHidden()+"'>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0J25e( true) ;
         }
         else
         {
            wb_table4_33_0J25e( false) ;
         }
      }

      protected void wb_table5_111_0J25( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTitlesigno_Internalname, "Signos Vitales", "", "", lblTitlesigno_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Consulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_111_0J25e( true) ;
         }
         else
         {
            wb_table5_111_0J25e( false) ;
         }
      }

      protected void wb_table2_5_0J25( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Consulta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Consulta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Consulta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Consulta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Consulta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Consulta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Consulta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Consulta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00p0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CONSULTAID"+"'), id:'"+"CONSULTAID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Consulta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00p0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CONSULTAID"+"'), id:'"+"CONSULTAID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Consulta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Consulta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Consulta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Consulta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Consulta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Consulta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Consulta.htm");
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
            wb_table2_5_0J25e( true) ;
         }
         else
         {
            wb_table2_5_0J25e( false) ;
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtConsultaId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtConsultaId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CONSULTAID");
                  AnyError = 1 ;
                  GX_FocusControl = edtConsultaId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A91ConsultaId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
               }
               else
               {
                  A91ConsultaId = (int)(context.localUtil.CToN( cgiGet( edtConsultaId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
               }
               if ( context.localUtil.VCDate( cgiGet( edtConsultaFecha_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, "CONSULTAFECHA");
                  AnyError = 1 ;
                  GX_FocusControl = edtConsultaFecha_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A92ConsultaFecha = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92ConsultaFecha", context.localUtil.Format(A92ConsultaFecha, "99/99/99"));
               }
               else
               {
                  A92ConsultaFecha = context.localUtil.CToD( cgiGet( edtConsultaFecha_Internalname), 2) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92ConsultaFecha", context.localUtil.Format(A92ConsultaFecha, "99/99/99"));
               }
               A93ConsultaHora = cgiGet( edtConsultaHora_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93ConsultaHora", A93ConsultaHora);
               if ( ( ( context.localUtil.CToN( cgiGet( edtPacienteId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPacienteId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PACIENTEID");
                  AnyError = 1 ;
                  GX_FocusControl = edtPacienteId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A67PacienteId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
               }
               else
               {
                  A67PacienteId = (int)(context.localUtil.CToN( cgiGet( edtPacienteId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtConsultaEdad_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtConsultaEdad_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CONSULTAEDAD");
                  AnyError = 1 ;
                  GX_FocusControl = edtConsultaEdad_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A157ConsultaEdad = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157ConsultaEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A157ConsultaEdad), 4, 0)));
               }
               else
               {
                  A157ConsultaEdad = (short)(context.localUtil.CToN( cgiGet( edtConsultaEdad_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157ConsultaEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A157ConsultaEdad), 4, 0)));
               }
               cmbConsultaTipo.Name = cmbConsultaTipo_Internalname ;
               cmbConsultaTipo.CurrentValue = cgiGet( cmbConsultaTipo_Internalname) ;
               A94ConsultaTipo = (short)(NumberUtil.Val( cgiGet( cmbConsultaTipo_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94ConsultaTipo", StringUtil.Str( (decimal)(A94ConsultaTipo), 1, 0));
               A82AsegCodigo = cgiGet( edtAsegCodigo_Internalname) ;
               n82AsegCodigo = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A82AsegCodigo", A82AsegCodigo);
               n82AsegCodigo = (String.IsNullOrEmpty(StringUtil.RTrim( A82AsegCodigo)) ? true : false) ;
               A158ConsultaPoliza = cgiGet( edtConsultaPoliza_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158ConsultaPoliza", A158ConsultaPoliza);
               A95ConsultaObs = cgiGet( edtConsultaObs_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A95ConsultaObs", A95ConsultaObs);
               A50Cie10Codigo = cgiGet( edtCie10Codigo_Internalname) ;
               n50Cie10Codigo = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50Cie10Codigo", A50Cie10Codigo);
               n50Cie10Codigo = (String.IsNullOrEmpty(StringUtil.RTrim( A50Cie10Codigo)) ? true : false) ;
               cmbConsultaEstado.Name = cmbConsultaEstado_Internalname ;
               cmbConsultaEstado.CurrentValue = cgiGet( cmbConsultaEstado_Internalname) ;
               A159ConsultaEstado = (short)(NumberUtil.Val( cgiGet( cmbConsultaEstado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159ConsultaEstado", StringUtil.Str( (decimal)(A159ConsultaEstado), 1, 0));
               if ( context.localUtil.VCDate( cgiGet( edtConsultaFechaFin_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha_Finaliza"}), 1, "CONSULTAFECHAFIN");
                  AnyError = 1 ;
                  GX_FocusControl = edtConsultaFechaFin_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A160ConsultaFechaFin = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A160ConsultaFechaFin", context.localUtil.Format(A160ConsultaFechaFin, "99/99/99"));
               }
               else
               {
                  A160ConsultaFechaFin = context.localUtil.CToD( cgiGet( edtConsultaFechaFin_Internalname), 2) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A160ConsultaFechaFin", context.localUtil.Format(A160ConsultaFechaFin, "99/99/99"));
               }
               A161ConsultaHoraFin = cgiGet( edtConsultaHoraFin_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161ConsultaHoraFin", A161ConsultaHoraFin);
               A19MedicoCodigo = cgiGet( edtMedicoCodigo_Internalname) ;
               n19MedicoCodigo = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
               n19MedicoCodigo = (String.IsNullOrEmpty(StringUtil.RTrim( A19MedicoCodigo)) ? true : false) ;
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z91ConsultaId = (int)(context.localUtil.CToN( cgiGet( "Z91ConsultaId"), ".", ",")) ;
               Z92ConsultaFecha = context.localUtil.CToD( cgiGet( "Z92ConsultaFecha"), 0) ;
               Z93ConsultaHora = cgiGet( "Z93ConsultaHora") ;
               Z157ConsultaEdad = (short)(context.localUtil.CToN( cgiGet( "Z157ConsultaEdad"), ".", ",")) ;
               Z94ConsultaTipo = (short)(context.localUtil.CToN( cgiGet( "Z94ConsultaTipo"), ".", ",")) ;
               Z158ConsultaPoliza = cgiGet( "Z158ConsultaPoliza") ;
               Z95ConsultaObs = cgiGet( "Z95ConsultaObs") ;
               Z159ConsultaEstado = (short)(context.localUtil.CToN( cgiGet( "Z159ConsultaEstado"), ".", ",")) ;
               Z160ConsultaFechaFin = context.localUtil.CToD( cgiGet( "Z160ConsultaFechaFin"), 0) ;
               Z161ConsultaHoraFin = cgiGet( "Z161ConsultaHoraFin") ;
               Z19MedicoCodigo = cgiGet( "Z19MedicoCodigo") ;
               n19MedicoCodigo = (String.IsNullOrEmpty(StringUtil.RTrim( A19MedicoCodigo)) ? true : false) ;
               Z50Cie10Codigo = cgiGet( "Z50Cie10Codigo") ;
               n50Cie10Codigo = (String.IsNullOrEmpty(StringUtil.RTrim( A50Cie10Codigo)) ? true : false) ;
               Z67PacienteId = (int)(context.localUtil.CToN( cgiGet( "Z67PacienteId"), ".", ",")) ;
               Z82AsegCodigo = cgiGet( "Z82AsegCodigo") ;
               n82AsegCodigo = (String.IsNullOrEmpty(StringUtil.RTrim( A82AsegCodigo)) ? true : false) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               nRC_Gridconsulta_signo = (short)(context.localUtil.CToN( cgiGet( "nRC_Gridconsulta_signo"), ".", ",")) ;
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
                  A91ConsultaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
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
               InitAll0J25( ) ;
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
         DisableAttributes0J25( ) ;
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

      protected void CONFIRM_0J26( )
      {
         nGXsfl_115_idx = 0 ;
         while ( nGXsfl_115_idx < nRC_Gridconsulta_signo )
         {
            ReadRow0J26( ) ;
            if ( ( nRcdExists_26 != 0 ) || ( nIsMod_26 != 0 ) )
            {
               GetKey0J26( ) ;
               if ( ( nRcdExists_26 == 0 ) && ( nRcdDeleted_26 == 0 ) )
               {
                  if ( RcdFound26 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate0J26( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0J26( ) ;
                        CloseExtendedTableCursors0J26( ) ;
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
                     GX_FocusControl = edtSignoLinea_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound26 != 0 )
                  {
                     if ( nRcdDeleted_26 != 0 )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey0J26( ) ;
                        Load0J26( ) ;
                        BeforeValidate0J26( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0J26( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_26 != 0 )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate0J26( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0J26( ) ;
                              CloseExtendedTableCursors0J26( ) ;
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
                     if ( nRcdDeleted_26 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtSignoLinea_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtSignoLinea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A96SignoLinea), 4, 0, ".", ""))) ;
            ChangePostValue( edtSignoEstatura_Internalname, StringUtil.LTrim( StringUtil.NToC( A97SignoEstatura, 8, 2, ".", ""))) ;
            ChangePostValue( cmbSignoEstaturaEn_Internalname, StringUtil.RTrim( A98SignoEstaturaEn)) ;
            ChangePostValue( edtSignoPeso_Internalname, StringUtil.LTrim( StringUtil.NToC( A99SignoPeso, 8, 2, ".", ""))) ;
            ChangePostValue( cmbSignoPesoEn_Internalname, StringUtil.RTrim( A100SignoPesoEn)) ;
            ChangePostValue( edtSignoTemperatura_Internalname, StringUtil.LTrim( StringUtil.NToC( A101SignoTemperatura, 8, 2, ".", ""))) ;
            ChangePostValue( cmbSignoTemperaturaDe_Internalname, StringUtil.RTrim( A102SignoTemperaturaDe)) ;
            ChangePostValue( edtSignoPresionArterial_Internalname, StringUtil.RTrim( A103SignoPresionArterial)) ;
            ChangePostValue( edtSignoFrecCardiaca_Internalname, StringUtil.LTrim( StringUtil.NToC( A104SignoFrecCardiaca, 8, 2, ".", ""))) ;
            ChangePostValue( edtSignoFrecRespiratoria_Internalname, StringUtil.LTrim( StringUtil.NToC( A105SignoFrecRespiratoria, 8, 2, ".", ""))) ;
            ChangePostValue( edtSignoFecha_Internalname, context.localUtil.Format(A106SignoFecha, "99/99/99")) ;
            ChangePostValue( edtSignoHora_Internalname, StringUtil.RTrim( A107SignoHora)) ;
            ChangePostValue( edtSignoObs_Internalname, StringUtil.RTrim( A108SignoObs)) ;
            ChangePostValue( "ZT_"+"Z96SignoLinea_"+sGXsfl_115_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z96SignoLinea), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z97SignoEstatura_"+sGXsfl_115_idx, StringUtil.LTrim( StringUtil.NToC( Z97SignoEstatura, 8, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z98SignoEstaturaEn_"+sGXsfl_115_idx, StringUtil.RTrim( Z98SignoEstaturaEn)) ;
            ChangePostValue( "ZT_"+"Z99SignoPeso_"+sGXsfl_115_idx, StringUtil.LTrim( StringUtil.NToC( Z99SignoPeso, 8, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z100SignoPesoEn_"+sGXsfl_115_idx, StringUtil.RTrim( Z100SignoPesoEn)) ;
            ChangePostValue( "ZT_"+"Z101SignoTemperatura_"+sGXsfl_115_idx, StringUtil.LTrim( StringUtil.NToC( Z101SignoTemperatura, 8, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z102SignoTemperaturaDe_"+sGXsfl_115_idx, StringUtil.RTrim( Z102SignoTemperaturaDe)) ;
            ChangePostValue( "ZT_"+"Z103SignoPresionArterial_"+sGXsfl_115_idx, StringUtil.RTrim( Z103SignoPresionArterial)) ;
            ChangePostValue( "ZT_"+"Z104SignoFrecCardiaca_"+sGXsfl_115_idx, StringUtil.LTrim( StringUtil.NToC( Z104SignoFrecCardiaca, 8, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z105SignoFrecRespiratoria_"+sGXsfl_115_idx, StringUtil.LTrim( StringUtil.NToC( Z105SignoFrecRespiratoria, 8, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z106SignoFecha_"+sGXsfl_115_idx, context.localUtil.DToC( Z106SignoFecha, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z107SignoHora_"+sGXsfl_115_idx, StringUtil.RTrim( Z107SignoHora)) ;
            ChangePostValue( "ZT_"+"Z108SignoObs_"+sGXsfl_115_idx, StringUtil.RTrim( Z108SignoObs)) ;
            ChangePostValue( "nRcdDeleted_26_"+sGXsfl_115_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_26), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_26_"+sGXsfl_115_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_26), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_26_"+sGXsfl_115_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_26), 4, 0, ".", ""))) ;
            if ( nIsMod_26 != 0 )
            {
               ChangePostValue( "SIGNOLINEA_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoLinea_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOESTATURA_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoEstatura_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOESTATURAEN_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbSignoEstaturaEn.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOPESO_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoPeso_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOPESOEN_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbSignoPesoEn.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOTEMPERATURA_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoTemperatura_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOTEMPERATURADE_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbSignoTemperaturaDe.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOPRESIONARTERIAL_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoPresionArterial_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOFRECCARDIACA_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoFrecCardiaca_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOFRECRESPIRATORIA_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoFrecRespiratoria_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOFECHA_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoFecha_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOHORA_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoHora_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOOBS_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoObs_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption0J0( )
      {
      }

      protected void ZM0J25( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z92ConsultaFecha = T000J5_A92ConsultaFecha[0] ;
               Z93ConsultaHora = T000J5_A93ConsultaHora[0] ;
               Z157ConsultaEdad = T000J5_A157ConsultaEdad[0] ;
               Z94ConsultaTipo = T000J5_A94ConsultaTipo[0] ;
               Z158ConsultaPoliza = T000J5_A158ConsultaPoliza[0] ;
               Z95ConsultaObs = T000J5_A95ConsultaObs[0] ;
               Z159ConsultaEstado = T000J5_A159ConsultaEstado[0] ;
               Z160ConsultaFechaFin = T000J5_A160ConsultaFechaFin[0] ;
               Z161ConsultaHoraFin = T000J5_A161ConsultaHoraFin[0] ;
               Z19MedicoCodigo = T000J5_A19MedicoCodigo[0] ;
               Z50Cie10Codigo = T000J5_A50Cie10Codigo[0] ;
               Z67PacienteId = T000J5_A67PacienteId[0] ;
               Z82AsegCodigo = T000J5_A82AsegCodigo[0] ;
            }
            else
            {
               Z92ConsultaFecha = A92ConsultaFecha ;
               Z93ConsultaHora = A93ConsultaHora ;
               Z157ConsultaEdad = A157ConsultaEdad ;
               Z94ConsultaTipo = A94ConsultaTipo ;
               Z158ConsultaPoliza = A158ConsultaPoliza ;
               Z95ConsultaObs = A95ConsultaObs ;
               Z159ConsultaEstado = A159ConsultaEstado ;
               Z160ConsultaFechaFin = A160ConsultaFechaFin ;
               Z161ConsultaHoraFin = A161ConsultaHoraFin ;
               Z19MedicoCodigo = A19MedicoCodigo ;
               Z50Cie10Codigo = A50Cie10Codigo ;
               Z67PacienteId = A67PacienteId ;
               Z82AsegCodigo = A82AsegCodigo ;
            }
         }
         if ( GX_JID == -4 )
         {
            Z91ConsultaId = A91ConsultaId ;
            Z92ConsultaFecha = A92ConsultaFecha ;
            Z93ConsultaHora = A93ConsultaHora ;
            Z157ConsultaEdad = A157ConsultaEdad ;
            Z94ConsultaTipo = A94ConsultaTipo ;
            Z158ConsultaPoliza = A158ConsultaPoliza ;
            Z95ConsultaObs = A95ConsultaObs ;
            Z159ConsultaEstado = A159ConsultaEstado ;
            Z160ConsultaFechaFin = A160ConsultaFechaFin ;
            Z161ConsultaHoraFin = A161ConsultaHoraFin ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z19MedicoCodigo = A19MedicoCodigo ;
            Z50Cie10Codigo = A50Cie10Codigo ;
            Z67PacienteId = A67PacienteId ;
            Z82AsegCodigo = A82AsegCodigo ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_41_67_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00n0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"PACIENTEID"+"'), id:'"+"PACIENTEID"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
         imgprompt_41_82_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00x0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"ASEGCODIGO"+"'), id:'"+"ASEGCODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
         imgprompt_41_50_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00h0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CIE10CODIGO"+"'), id:'"+"CIE10CODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
         imgprompt_41_19_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0080.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"MEDICOCODIGO"+"'), id:'"+"MEDICOCODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
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

      protected void Load0J25( )
      {
         /* Using cursor T000J10 */
         pr_default.execute(8, new Object[] {A41ClinicaCodigo, A91ConsultaId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound25 = 1 ;
            A92ConsultaFecha = T000J10_A92ConsultaFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92ConsultaFecha", context.localUtil.Format(A92ConsultaFecha, "99/99/99"));
            A93ConsultaHora = T000J10_A93ConsultaHora[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93ConsultaHora", A93ConsultaHora);
            A157ConsultaEdad = T000J10_A157ConsultaEdad[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157ConsultaEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A157ConsultaEdad), 4, 0)));
            A94ConsultaTipo = T000J10_A94ConsultaTipo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94ConsultaTipo", StringUtil.Str( (decimal)(A94ConsultaTipo), 1, 0));
            A158ConsultaPoliza = T000J10_A158ConsultaPoliza[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158ConsultaPoliza", A158ConsultaPoliza);
            A95ConsultaObs = T000J10_A95ConsultaObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A95ConsultaObs", A95ConsultaObs);
            A159ConsultaEstado = T000J10_A159ConsultaEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159ConsultaEstado", StringUtil.Str( (decimal)(A159ConsultaEstado), 1, 0));
            A160ConsultaFechaFin = T000J10_A160ConsultaFechaFin[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A160ConsultaFechaFin", context.localUtil.Format(A160ConsultaFechaFin, "99/99/99"));
            A161ConsultaHoraFin = T000J10_A161ConsultaHoraFin[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161ConsultaHoraFin", A161ConsultaHoraFin);
            A19MedicoCodigo = T000J10_A19MedicoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
            n19MedicoCodigo = T000J10_n19MedicoCodigo[0] ;
            A50Cie10Codigo = T000J10_A50Cie10Codigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50Cie10Codigo", A50Cie10Codigo);
            n50Cie10Codigo = T000J10_n50Cie10Codigo[0] ;
            A67PacienteId = T000J10_A67PacienteId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
            A82AsegCodigo = T000J10_A82AsegCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A82AsegCodigo", A82AsegCodigo);
            n82AsegCodigo = T000J10_n82AsegCodigo[0] ;
            ZM0J25( -4) ;
         }
         pr_default.close(8);
         OnLoadActions0J25( ) ;
      }

      protected void OnLoadActions0J25( )
      {
      }

      protected void CheckExtendedTable0J25( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T000J6 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo, n19MedicoCodigo, A19MedicoCodigo});
         if ( (pr_default.getStatus(4) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A41ClinicaCodigo)) || String.IsNullOrEmpty(StringUtil.RTrim( A19MedicoCodigo)) ) )
            {
               AnyError41 = 1 ;
               AnyError19 = 1 ;
               GX_msglist.addItem("No existe 'Médicos'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         if ( ( AnyError41 == 0 ) && ( AnyError19 == 0 ) )
         {
         }
         pr_default.close(4);
         /* Using cursor T000J7 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, n50Cie10Codigo, A50Cie10Codigo});
         if ( (pr_default.getStatus(5) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A41ClinicaCodigo)) || String.IsNullOrEmpty(StringUtil.RTrim( A50Cie10Codigo)) ) )
            {
               AnyError41 = 1 ;
               AnyError50 = 1 ;
               GX_msglist.addItem("No existe 'Clasificación CIE-10'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         if ( ( AnyError41 == 0 ) && ( AnyError50 == 0 ) )
         {
         }
         pr_default.close(5);
         /* Using cursor T000J8 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, A67PacienteId});
         if ( (pr_default.getStatus(6) == 101) )
         {
            AnyError41 = 1 ;
            AnyError67 = 1 ;
            GX_msglist.addItem("No existe 'Pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError67 == 0 ) )
         {
         }
         pr_default.close(6);
         /* Using cursor T000J9 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, n82AsegCodigo, A82AsegCodigo});
         if ( (pr_default.getStatus(7) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A41ClinicaCodigo)) || String.IsNullOrEmpty(StringUtil.RTrim( A82AsegCodigo)) ) )
            {
               AnyError41 = 1 ;
               AnyError82 = 1 ;
               GX_msglist.addItem("No existe 'Aseguradoras'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         if ( ( AnyError41 == 0 ) && ( AnyError82 == 0 ) )
         {
         }
         pr_default.close(7);
         if ( ! ( (DateTime.MinValue==A92ConsultaFecha) || ( A92ConsultaFecha >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A160ConsultaFechaFin) || ( A160ConsultaFechaFin >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha_Finaliza fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors0J25( )
      {
         pr_default.close(4);
         pr_default.close(5);
         pr_default.close(6);
         pr_default.close(7);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_5( String A41ClinicaCodigo ,
                               String A19MedicoCodigo )
      {
         /* Using cursor T000J11 */
         pr_default.execute(9, new Object[] {A41ClinicaCodigo, n19MedicoCodigo, A19MedicoCodigo});
         if ( (pr_default.getStatus(9) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A41ClinicaCodigo)) || String.IsNullOrEmpty(StringUtil.RTrim( A19MedicoCodigo)) ) )
            {
               AnyError41 = 1 ;
               AnyError19 = 1 ;
               GX_msglist.addItem("No existe 'Médicos'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         if ( ( AnyError41 == 0 ) && ( AnyError19 == 0 ) )
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

      protected void gxLoad_6( String A41ClinicaCodigo ,
                               String A50Cie10Codigo )
      {
         /* Using cursor T000J12 */
         pr_default.execute(10, new Object[] {A41ClinicaCodigo, n50Cie10Codigo, A50Cie10Codigo});
         if ( (pr_default.getStatus(10) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A41ClinicaCodigo)) || String.IsNullOrEmpty(StringUtil.RTrim( A50Cie10Codigo)) ) )
            {
               AnyError41 = 1 ;
               AnyError50 = 1 ;
               GX_msglist.addItem("No existe 'Clasificación CIE-10'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         if ( ( AnyError41 == 0 ) && ( AnyError50 == 0 ) )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(10) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(10);
      }

      protected void gxLoad_7( String A41ClinicaCodigo ,
                               int A67PacienteId )
      {
         /* Using cursor T000J13 */
         pr_default.execute(11, new Object[] {A41ClinicaCodigo, A67PacienteId});
         if ( (pr_default.getStatus(11) == 101) )
         {
            AnyError41 = 1 ;
            AnyError67 = 1 ;
            GX_msglist.addItem("No existe 'Pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError67 == 0 ) )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(11) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(11);
      }

      protected void gxLoad_8( String A41ClinicaCodigo ,
                               String A82AsegCodigo )
      {
         /* Using cursor T000J14 */
         pr_default.execute(12, new Object[] {A41ClinicaCodigo, n82AsegCodigo, A82AsegCodigo});
         if ( (pr_default.getStatus(12) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A41ClinicaCodigo)) || String.IsNullOrEmpty(StringUtil.RTrim( A82AsegCodigo)) ) )
            {
               AnyError41 = 1 ;
               AnyError82 = 1 ;
               GX_msglist.addItem("No existe 'Aseguradoras'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         if ( ( AnyError41 == 0 ) && ( AnyError82 == 0 ) )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(12) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(12);
      }

      protected void GetKey0J25( )
      {
         /* Using cursor T000J15 */
         pr_default.execute(13, new Object[] {A41ClinicaCodigo, A91ConsultaId});
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound25 = 1 ;
         }
         else
         {
            RcdFound25 = 0 ;
         }
         pr_default.close(13);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000J5 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A91ConsultaId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM0J25( 4) ;
            RcdFound25 = 1 ;
            A91ConsultaId = T000J5_A91ConsultaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
            A92ConsultaFecha = T000J5_A92ConsultaFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92ConsultaFecha", context.localUtil.Format(A92ConsultaFecha, "99/99/99"));
            A93ConsultaHora = T000J5_A93ConsultaHora[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93ConsultaHora", A93ConsultaHora);
            A157ConsultaEdad = T000J5_A157ConsultaEdad[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157ConsultaEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A157ConsultaEdad), 4, 0)));
            A94ConsultaTipo = T000J5_A94ConsultaTipo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94ConsultaTipo", StringUtil.Str( (decimal)(A94ConsultaTipo), 1, 0));
            A158ConsultaPoliza = T000J5_A158ConsultaPoliza[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158ConsultaPoliza", A158ConsultaPoliza);
            A95ConsultaObs = T000J5_A95ConsultaObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A95ConsultaObs", A95ConsultaObs);
            A159ConsultaEstado = T000J5_A159ConsultaEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159ConsultaEstado", StringUtil.Str( (decimal)(A159ConsultaEstado), 1, 0));
            A160ConsultaFechaFin = T000J5_A160ConsultaFechaFin[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A160ConsultaFechaFin", context.localUtil.Format(A160ConsultaFechaFin, "99/99/99"));
            A161ConsultaHoraFin = T000J5_A161ConsultaHoraFin[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161ConsultaHoraFin", A161ConsultaHoraFin);
            A41ClinicaCodigo = T000J5_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A19MedicoCodigo = T000J5_A19MedicoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
            n19MedicoCodigo = T000J5_n19MedicoCodigo[0] ;
            A50Cie10Codigo = T000J5_A50Cie10Codigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50Cie10Codigo", A50Cie10Codigo);
            n50Cie10Codigo = T000J5_n50Cie10Codigo[0] ;
            A67PacienteId = T000J5_A67PacienteId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
            A82AsegCodigo = T000J5_A82AsegCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A82AsegCodigo", A82AsegCodigo);
            n82AsegCodigo = T000J5_n82AsegCodigo[0] ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z91ConsultaId = A91ConsultaId ;
            sMode25 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0J25( ) ;
            Gx_mode = sMode25 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound25 = 0 ;
            InitializeNonKey0J25( ) ;
            sMode25 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode25 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey0J25( ) ;
         if ( RcdFound25 == 0 )
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
         RcdFound25 = 0 ;
         /* Using cursor T000J16 */
         pr_default.execute(14, new Object[] {A41ClinicaCodigo, A91ConsultaId});
         if ( (pr_default.getStatus(14) != 101) )
         {
            while ( (pr_default.getStatus(14) != 101) && ( ( StringUtil.StrCmp(T000J16_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000J16_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000J16_A91ConsultaId[0] < A91ConsultaId ) ) )
            {
               pr_default.readNext(14);
            }
            if ( (pr_default.getStatus(14) != 101) && ( ( StringUtil.StrCmp(T000J16_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000J16_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000J16_A91ConsultaId[0] > A91ConsultaId ) ) )
            {
               A41ClinicaCodigo = T000J16_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A91ConsultaId = T000J16_A91ConsultaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
               RcdFound25 = 1 ;
            }
         }
         pr_default.close(3);
      }

      protected void move_previous( )
      {
         RcdFound25 = 0 ;
         /* Using cursor T000J17 */
         pr_default.execute(15, new Object[] {A41ClinicaCodigo, A91ConsultaId});
         if ( (pr_default.getStatus(15) != 101) )
         {
            while ( (pr_default.getStatus(15) != 101) && ( ( StringUtil.StrCmp(T000J17_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000J17_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000J17_A91ConsultaId[0] > A91ConsultaId ) ) )
            {
               pr_default.readNext(15);
            }
            if ( (pr_default.getStatus(15) != 101) && ( ( StringUtil.StrCmp(T000J17_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000J17_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000J17_A91ConsultaId[0] < A91ConsultaId ) ) )
            {
               A41ClinicaCodigo = T000J17_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A91ConsultaId = T000J17_A91ConsultaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
               RcdFound25 = 1 ;
            }
         }
         pr_default.close(2);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0J25( ) ;
         if ( RcdFound25 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A91ConsultaId != Z91ConsultaId ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A91ConsultaId = Z91ConsultaId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
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
               Update0J25( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A91ConsultaId != Z91ConsultaId ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert0J25( ) ;
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
                  Insert0J25( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A91ConsultaId != Z91ConsultaId ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A91ConsultaId = Z91ConsultaId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
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
         if ( RcdFound25 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtConsultaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0J25( ) ;
         if ( RcdFound25 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtConsultaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0J25( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound25 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtConsultaFecha_Internalname ;
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
         if ( RcdFound25 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtConsultaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0J25( ) ;
         if ( RcdFound25 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound25 != 0 )
            {
               ScanNext0J25( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtConsultaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0J25( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0J25( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000J18 */
            pr_default.execute(16, new Object[] {A41ClinicaCodigo, A91ConsultaId});
            if ( (pr_default.getStatus(16) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Consulta"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(16) == 101) || ( Z92ConsultaFecha != T000J18_A92ConsultaFecha[0] ) || ( StringUtil.StrCmp(Z93ConsultaHora, T000J18_A93ConsultaHora[0]) != 0 ) || ( Z157ConsultaEdad != T000J18_A157ConsultaEdad[0] ) || ( Z94ConsultaTipo != T000J18_A94ConsultaTipo[0] ) || ( StringUtil.StrCmp(Z158ConsultaPoliza, T000J18_A158ConsultaPoliza[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z95ConsultaObs, T000J18_A95ConsultaObs[0]) != 0 ) || ( Z159ConsultaEstado != T000J18_A159ConsultaEstado[0] ) || ( Z160ConsultaFechaFin != T000J18_A160ConsultaFechaFin[0] ) || ( StringUtil.StrCmp(Z161ConsultaHoraFin, T000J18_A161ConsultaHoraFin[0]) != 0 ) || ( StringUtil.StrCmp(Z19MedicoCodigo, T000J18_A19MedicoCodigo[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z50Cie10Codigo, T000J18_A50Cie10Codigo[0]) != 0 ) || ( Z67PacienteId != T000J18_A67PacienteId[0] ) || ( StringUtil.StrCmp(Z82AsegCodigo, T000J18_A82AsegCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Consulta"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0J25( )
      {
         BeforeValidate0J25( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0J25( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0J25( 0) ;
            CheckOptimisticConcurrency0J25( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0J25( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0J25( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000J19 */
                     pr_default.execute(17, new Object[] {A91ConsultaId, A92ConsultaFecha, A93ConsultaHora, A157ConsultaEdad, A94ConsultaTipo, A158ConsultaPoliza, A95ConsultaObs, A159ConsultaEstado, A160ConsultaFechaFin, A161ConsultaHoraFin, A41ClinicaCodigo, n19MedicoCodigo, A19MedicoCodigo, n50Cie10Codigo, A50Cie10Codigo, A67PacienteId, n82AsegCodigo, A82AsegCodigo});
                     pr_default.close(17);
                     if ( (pr_default.getStatus(17) == 1) )
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
                           ProcessLevel0J25( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                              ResetCaption0J0( ) ;
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
               Load0J25( ) ;
            }
            EndLevel0J25( ) ;
         }
         CloseExtendedTableCursors0J25( ) ;
      }

      protected void Update0J25( )
      {
         BeforeValidate0J25( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0J25( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0J25( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0J25( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0J25( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000J20 */
                     pr_default.execute(18, new Object[] {A92ConsultaFecha, A93ConsultaHora, A157ConsultaEdad, A94ConsultaTipo, A158ConsultaPoliza, A95ConsultaObs, A159ConsultaEstado, A160ConsultaFechaFin, A161ConsultaHoraFin, n19MedicoCodigo, A19MedicoCodigo, n50Cie10Codigo, A50Cie10Codigo, A67PacienteId, n82AsegCodigo, A82AsegCodigo, A41ClinicaCodigo, A91ConsultaId});
                     pr_default.close(18);
                     if ( (pr_default.getStatus(18) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Consulta"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0J25( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0J25( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                              ResetCaption0J0( ) ;
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
            EndLevel0J25( ) ;
         }
         CloseExtendedTableCursors0J25( ) ;
      }

      protected void DeferredUpdate0J25( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0J25( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0J25( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0J25( ) ;
            AfterConfirm0J25( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0J25( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart0J26( ) ;
                  while ( RcdFound26 != 0 )
                  {
                     getByPrimaryKey0J26( ) ;
                     Delete0J26( ) ;
                     ScanNext0J26( ) ;
                  }
                  ScanEnd0J26( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000J21 */
                     pr_default.execute(19, new Object[] {A41ClinicaCodigo, A91ConsultaId});
                     pr_default.close(19);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound25 == 0 )
                           {
                              InitAll0J25( ) ;
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
                           ResetCaption0J0( ) ;
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
         sMode25 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0J25( ) ;
         Gx_mode = sMode25 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0J25( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000J22 */
            pr_default.execute(20, new Object[] {A41ClinicaCodigo, A91ConsultaId});
            if ( (pr_default.getStatus(20) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Factura a Pacientes"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(20);
            /* Using cursor T000J23 */
            pr_default.execute(21, new Object[] {A41ClinicaCodigo, A91ConsultaId});
            if ( (pr_default.getStatus(21) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Cargos de Consulta de Paciente"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(21);
            /* Using cursor T000J24 */
            pr_default.execute(22, new Object[] {A41ClinicaCodigo, A91ConsultaId});
            if ( (pr_default.getStatus(22) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Recetas de pacientes"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(22);
         }
      }

      protected void ProcessNestedLevel0J26( )
      {
         nGXsfl_115_idx = 0 ;
         while ( nGXsfl_115_idx < nRC_Gridconsulta_signo )
         {
            ReadRow0J26( ) ;
            if ( ( nRcdExists_26 != 0 ) || ( nIsMod_26 != 0 ) )
            {
               standaloneNotModal0J26( ) ;
               GetKey0J26( ) ;
               if ( ( nRcdExists_26 == 0 ) && ( nRcdDeleted_26 == 0 ) )
               {
                  if ( RcdFound26 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Insert0J26( ) ;
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtSignoLinea_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound26 != 0 )
                  {
                     if ( ( nRcdDeleted_26 != 0 ) && ( nRcdExists_26 != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete0J26( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_26 != 0 ) && ( nRcdExists_26 != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update0J26( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_26 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtSignoLinea_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtSignoLinea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A96SignoLinea), 4, 0, ".", ""))) ;
            ChangePostValue( edtSignoEstatura_Internalname, StringUtil.LTrim( StringUtil.NToC( A97SignoEstatura, 8, 2, ".", ""))) ;
            ChangePostValue( cmbSignoEstaturaEn_Internalname, StringUtil.RTrim( A98SignoEstaturaEn)) ;
            ChangePostValue( edtSignoPeso_Internalname, StringUtil.LTrim( StringUtil.NToC( A99SignoPeso, 8, 2, ".", ""))) ;
            ChangePostValue( cmbSignoPesoEn_Internalname, StringUtil.RTrim( A100SignoPesoEn)) ;
            ChangePostValue( edtSignoTemperatura_Internalname, StringUtil.LTrim( StringUtil.NToC( A101SignoTemperatura, 8, 2, ".", ""))) ;
            ChangePostValue( cmbSignoTemperaturaDe_Internalname, StringUtil.RTrim( A102SignoTemperaturaDe)) ;
            ChangePostValue( edtSignoPresionArterial_Internalname, StringUtil.RTrim( A103SignoPresionArterial)) ;
            ChangePostValue( edtSignoFrecCardiaca_Internalname, StringUtil.LTrim( StringUtil.NToC( A104SignoFrecCardiaca, 8, 2, ".", ""))) ;
            ChangePostValue( edtSignoFrecRespiratoria_Internalname, StringUtil.LTrim( StringUtil.NToC( A105SignoFrecRespiratoria, 8, 2, ".", ""))) ;
            ChangePostValue( edtSignoFecha_Internalname, context.localUtil.Format(A106SignoFecha, "99/99/99")) ;
            ChangePostValue( edtSignoHora_Internalname, StringUtil.RTrim( A107SignoHora)) ;
            ChangePostValue( edtSignoObs_Internalname, StringUtil.RTrim( A108SignoObs)) ;
            ChangePostValue( "ZT_"+"Z96SignoLinea_"+sGXsfl_115_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z96SignoLinea), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z97SignoEstatura_"+sGXsfl_115_idx, StringUtil.LTrim( StringUtil.NToC( Z97SignoEstatura, 8, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z98SignoEstaturaEn_"+sGXsfl_115_idx, StringUtil.RTrim( Z98SignoEstaturaEn)) ;
            ChangePostValue( "ZT_"+"Z99SignoPeso_"+sGXsfl_115_idx, StringUtil.LTrim( StringUtil.NToC( Z99SignoPeso, 8, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z100SignoPesoEn_"+sGXsfl_115_idx, StringUtil.RTrim( Z100SignoPesoEn)) ;
            ChangePostValue( "ZT_"+"Z101SignoTemperatura_"+sGXsfl_115_idx, StringUtil.LTrim( StringUtil.NToC( Z101SignoTemperatura, 8, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z102SignoTemperaturaDe_"+sGXsfl_115_idx, StringUtil.RTrim( Z102SignoTemperaturaDe)) ;
            ChangePostValue( "ZT_"+"Z103SignoPresionArterial_"+sGXsfl_115_idx, StringUtil.RTrim( Z103SignoPresionArterial)) ;
            ChangePostValue( "ZT_"+"Z104SignoFrecCardiaca_"+sGXsfl_115_idx, StringUtil.LTrim( StringUtil.NToC( Z104SignoFrecCardiaca, 8, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z105SignoFrecRespiratoria_"+sGXsfl_115_idx, StringUtil.LTrim( StringUtil.NToC( Z105SignoFrecRespiratoria, 8, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z106SignoFecha_"+sGXsfl_115_idx, context.localUtil.DToC( Z106SignoFecha, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z107SignoHora_"+sGXsfl_115_idx, StringUtil.RTrim( Z107SignoHora)) ;
            ChangePostValue( "ZT_"+"Z108SignoObs_"+sGXsfl_115_idx, StringUtil.RTrim( Z108SignoObs)) ;
            ChangePostValue( "nRcdDeleted_26_"+sGXsfl_115_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_26), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_26_"+sGXsfl_115_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_26), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_26_"+sGXsfl_115_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_26), 4, 0, ".", ""))) ;
            if ( nIsMod_26 != 0 )
            {
               ChangePostValue( "SIGNOLINEA_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoLinea_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOESTATURA_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoEstatura_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOESTATURAEN_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbSignoEstaturaEn.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOPESO_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoPeso_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOPESOEN_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbSignoPesoEn.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOTEMPERATURA_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoTemperatura_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOTEMPERATURADE_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbSignoTemperaturaDe.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOPRESIONARTERIAL_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoPresionArterial_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOFRECCARDIACA_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoFrecCardiaca_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOFRECRESPIRATORIA_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoFrecRespiratoria_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOFECHA_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoFecha_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOHORA_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoHora_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SIGNOOBS_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoObs_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0J26( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_26 = 0 ;
         nIsMod_26 = 0 ;
         nRcdDeleted_26 = 0 ;
      }

      protected void ProcessLevel0J25( )
      {
         /* Save parent mode. */
         sMode25 = Gx_mode ;
         ProcessNestedLevel0J26( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode25 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel0J25( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(16);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0J25( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(15);
            pr_default.close(14);
            pr_default.close(1);
            pr_default.close(0);
            context.CommitDataStores("Consulta");
            if ( AnyError == 0 )
            {
               ConfirmValues0J0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(15);
            pr_default.close(14);
            pr_default.close(1);
            pr_default.close(0);
            context.RollbackDataStores("Consulta");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0J25( )
      {
         /* Using cursor T000J25 */
         pr_default.execute(23);
         RcdFound25 = 0 ;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound25 = 1 ;
            A41ClinicaCodigo = T000J25_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A91ConsultaId = T000J25_A91ConsultaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0J25( )
      {
         pr_default.readNext(23);
         RcdFound25 = 0 ;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound25 = 1 ;
            A41ClinicaCodigo = T000J25_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A91ConsultaId = T000J25_A91ConsultaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
         }
      }

      protected void ScanEnd0J25( )
      {
      }

      protected void AfterConfirm0J25( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0J25( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0J25( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0J25( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0J25( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0J25( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0J25( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtConsultaId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConsultaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConsultaId_Enabled), 5, 0)));
         edtConsultaFecha_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConsultaFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConsultaFecha_Enabled), 5, 0)));
         edtConsultaHora_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConsultaHora_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConsultaHora_Enabled), 5, 0)));
         edtPacienteId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPacienteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPacienteId_Enabled), 5, 0)));
         edtConsultaEdad_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConsultaEdad_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConsultaEdad_Enabled), 5, 0)));
         cmbConsultaTipo.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbConsultaTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbConsultaTipo.Enabled), 5, 0)));
         edtAsegCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsegCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsegCodigo_Enabled), 5, 0)));
         edtConsultaPoliza_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConsultaPoliza_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConsultaPoliza_Enabled), 5, 0)));
         edtConsultaObs_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConsultaObs_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConsultaObs_Enabled), 5, 0)));
         edtCie10Codigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCie10Codigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCie10Codigo_Enabled), 5, 0)));
         cmbConsultaEstado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbConsultaEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbConsultaEstado.Enabled), 5, 0)));
         edtConsultaFechaFin_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConsultaFechaFin_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConsultaFechaFin_Enabled), 5, 0)));
         edtConsultaHoraFin_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConsultaHoraFin_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConsultaHoraFin_Enabled), 5, 0)));
         edtMedicoCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMedicoCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMedicoCodigo_Enabled), 5, 0)));
      }

      protected void ZM0J26( short GX_JID )
      {
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z97SignoEstatura = T000J3_A97SignoEstatura[0] ;
               Z98SignoEstaturaEn = T000J3_A98SignoEstaturaEn[0] ;
               Z99SignoPeso = T000J3_A99SignoPeso[0] ;
               Z100SignoPesoEn = T000J3_A100SignoPesoEn[0] ;
               Z101SignoTemperatura = T000J3_A101SignoTemperatura[0] ;
               Z102SignoTemperaturaDe = T000J3_A102SignoTemperaturaDe[0] ;
               Z103SignoPresionArterial = T000J3_A103SignoPresionArterial[0] ;
               Z104SignoFrecCardiaca = T000J3_A104SignoFrecCardiaca[0] ;
               Z105SignoFrecRespiratoria = T000J3_A105SignoFrecRespiratoria[0] ;
               Z106SignoFecha = T000J3_A106SignoFecha[0] ;
               Z107SignoHora = T000J3_A107SignoHora[0] ;
               Z108SignoObs = T000J3_A108SignoObs[0] ;
            }
            else
            {
               Z97SignoEstatura = A97SignoEstatura ;
               Z98SignoEstaturaEn = A98SignoEstaturaEn ;
               Z99SignoPeso = A99SignoPeso ;
               Z100SignoPesoEn = A100SignoPesoEn ;
               Z101SignoTemperatura = A101SignoTemperatura ;
               Z102SignoTemperaturaDe = A102SignoTemperaturaDe ;
               Z103SignoPresionArterial = A103SignoPresionArterial ;
               Z104SignoFrecCardiaca = A104SignoFrecCardiaca ;
               Z105SignoFrecRespiratoria = A105SignoFrecRespiratoria ;
               Z106SignoFecha = A106SignoFecha ;
               Z107SignoHora = A107SignoHora ;
               Z108SignoObs = A108SignoObs ;
            }
         }
         if ( GX_JID == -9 )
         {
            Z91ConsultaId = A91ConsultaId ;
            Z96SignoLinea = A96SignoLinea ;
            Z97SignoEstatura = A97SignoEstatura ;
            Z98SignoEstaturaEn = A98SignoEstaturaEn ;
            Z99SignoPeso = A99SignoPeso ;
            Z100SignoPesoEn = A100SignoPesoEn ;
            Z101SignoTemperatura = A101SignoTemperatura ;
            Z102SignoTemperaturaDe = A102SignoTemperaturaDe ;
            Z103SignoPresionArterial = A103SignoPresionArterial ;
            Z104SignoFrecCardiaca = A104SignoFrecCardiaca ;
            Z105SignoFrecRespiratoria = A105SignoFrecRespiratoria ;
            Z106SignoFecha = A106SignoFecha ;
            Z107SignoHora = A107SignoHora ;
            Z108SignoObs = A108SignoObs ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
         }
      }

      protected void standaloneNotModal0J26( )
      {
      }

      protected void standaloneModal0J26( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtSignoLinea_Enabled = 0 ;
         }
         else
         {
            edtSignoLinea_Enabled = 1 ;
         }
         if ( ( StringUtil.StrCmp(sMode26, "DSP") == 0 ) || ( StringUtil.StrCmp(sMode26, "DLT") == 0 ) )
         {
            DisableAttributes0J26( ) ;
         }
      }

      protected void Load0J26( )
      {
         /* Using cursor T000J26 */
         pr_default.execute(24, new Object[] {A41ClinicaCodigo, A91ConsultaId, A96SignoLinea});
         if ( (pr_default.getStatus(24) != 101) )
         {
            RcdFound26 = 1 ;
            A97SignoEstatura = T000J26_A97SignoEstatura[0] ;
            A98SignoEstaturaEn = T000J26_A98SignoEstaturaEn[0] ;
            A99SignoPeso = T000J26_A99SignoPeso[0] ;
            A100SignoPesoEn = T000J26_A100SignoPesoEn[0] ;
            A101SignoTemperatura = T000J26_A101SignoTemperatura[0] ;
            A102SignoTemperaturaDe = T000J26_A102SignoTemperaturaDe[0] ;
            A103SignoPresionArterial = T000J26_A103SignoPresionArterial[0] ;
            A104SignoFrecCardiaca = T000J26_A104SignoFrecCardiaca[0] ;
            A105SignoFrecRespiratoria = T000J26_A105SignoFrecRespiratoria[0] ;
            A106SignoFecha = T000J26_A106SignoFecha[0] ;
            A107SignoHora = T000J26_A107SignoHora[0] ;
            A108SignoObs = T000J26_A108SignoObs[0] ;
            ZM0J26( -9) ;
         }
         pr_default.close(24);
         OnLoadActions0J26( ) ;
      }

      protected void OnLoadActions0J26( )
      {
      }

      protected void CheckExtendedTable0J26( )
      {
         Gx_BScreen = 1 ;
         standaloneModal0J26( ) ;
         if ( ! ( (DateTime.MinValue==A106SignoFecha) || ( A106SignoFecha >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors0J26( )
      {
      }

      protected void enableDisable0J26( )
      {
      }

      protected void GetKey0J26( )
      {
         /* Using cursor T000J27 */
         pr_default.execute(25, new Object[] {A41ClinicaCodigo, A91ConsultaId, A96SignoLinea});
         if ( (pr_default.getStatus(25) != 101) )
         {
            RcdFound26 = 1 ;
         }
         else
         {
            RcdFound26 = 0 ;
         }
         pr_default.close(25);
      }

      protected void getByPrimaryKey0J26( )
      {
         /* Using cursor T000J3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A91ConsultaId, A96SignoLinea});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0J26( 9) ;
            RcdFound26 = 1 ;
            InitializeNonKey0J26( ) ;
            A96SignoLinea = T000J3_A96SignoLinea[0] ;
            A97SignoEstatura = T000J3_A97SignoEstatura[0] ;
            A98SignoEstaturaEn = T000J3_A98SignoEstaturaEn[0] ;
            A99SignoPeso = T000J3_A99SignoPeso[0] ;
            A100SignoPesoEn = T000J3_A100SignoPesoEn[0] ;
            A101SignoTemperatura = T000J3_A101SignoTemperatura[0] ;
            A102SignoTemperaturaDe = T000J3_A102SignoTemperaturaDe[0] ;
            A103SignoPresionArterial = T000J3_A103SignoPresionArterial[0] ;
            A104SignoFrecCardiaca = T000J3_A104SignoFrecCardiaca[0] ;
            A105SignoFrecRespiratoria = T000J3_A105SignoFrecRespiratoria[0] ;
            A106SignoFecha = T000J3_A106SignoFecha[0] ;
            A107SignoHora = T000J3_A107SignoHora[0] ;
            A108SignoObs = T000J3_A108SignoObs[0] ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z91ConsultaId = A91ConsultaId ;
            Z96SignoLinea = A96SignoLinea ;
            sMode26 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0J26( ) ;
            Load0J26( ) ;
            Gx_mode = sMode26 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound26 = 0 ;
            InitializeNonKey0J26( ) ;
            sMode26 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0J26( ) ;
            Gx_mode = sMode26 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0J26( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000J2 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, A91ConsultaId, A96SignoLinea});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ConsultaSigno"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(0) == 101) || ( Z97SignoEstatura != T000J2_A97SignoEstatura[0] ) || ( StringUtil.StrCmp(Z98SignoEstaturaEn, T000J2_A98SignoEstaturaEn[0]) != 0 ) || ( Z99SignoPeso != T000J2_A99SignoPeso[0] ) || ( StringUtil.StrCmp(Z100SignoPesoEn, T000J2_A100SignoPesoEn[0]) != 0 ) || ( Z101SignoTemperatura != T000J2_A101SignoTemperatura[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z102SignoTemperaturaDe, T000J2_A102SignoTemperaturaDe[0]) != 0 ) || ( StringUtil.StrCmp(Z103SignoPresionArterial, T000J2_A103SignoPresionArterial[0]) != 0 ) || ( Z104SignoFrecCardiaca != T000J2_A104SignoFrecCardiaca[0] ) || ( Z105SignoFrecRespiratoria != T000J2_A105SignoFrecRespiratoria[0] ) || ( Z106SignoFecha != T000J2_A106SignoFecha[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z107SignoHora, T000J2_A107SignoHora[0]) != 0 ) || ( StringUtil.StrCmp(Z108SignoObs, T000J2_A108SignoObs[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ConsultaSigno"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0J26( )
      {
         BeforeValidate0J26( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0J26( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0J26( 0) ;
            CheckOptimisticConcurrency0J26( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0J26( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0J26( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000J28 */
                     pr_default.execute(26, new Object[] {A91ConsultaId, A96SignoLinea, A97SignoEstatura, A98SignoEstaturaEn, A99SignoPeso, A100SignoPesoEn, A101SignoTemperatura, A102SignoTemperaturaDe, A103SignoPresionArterial, A104SignoFrecCardiaca, A105SignoFrecRespiratoria, A106SignoFecha, A107SignoHora, A108SignoObs, A41ClinicaCodigo});
                     pr_default.close(26);
                     if ( (pr_default.getStatus(26) == 1) )
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
               Load0J26( ) ;
            }
            EndLevel0J26( ) ;
         }
         CloseExtendedTableCursors0J26( ) ;
      }

      protected void Update0J26( )
      {
         BeforeValidate0J26( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0J26( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0J26( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0J26( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0J26( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000J29 */
                     pr_default.execute(27, new Object[] {A97SignoEstatura, A98SignoEstaturaEn, A99SignoPeso, A100SignoPesoEn, A101SignoTemperatura, A102SignoTemperaturaDe, A103SignoPresionArterial, A104SignoFrecCardiaca, A105SignoFrecRespiratoria, A106SignoFecha, A107SignoHora, A108SignoObs, A41ClinicaCodigo, A91ConsultaId, A96SignoLinea});
                     pr_default.close(27);
                     if ( (pr_default.getStatus(27) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ConsultaSigno"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0J26( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0J26( ) ;
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
            EndLevel0J26( ) ;
         }
         CloseExtendedTableCursors0J26( ) ;
      }

      protected void DeferredUpdate0J26( )
      {
      }

      protected void Delete0J26( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0J26( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0J26( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0J26( ) ;
            AfterConfirm0J26( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0J26( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000J30 */
                  pr_default.execute(28, new Object[] {A41ClinicaCodigo, A91ConsultaId, A96SignoLinea});
                  pr_default.close(28);
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
         sMode26 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0J26( ) ;
         Gx_mode = sMode26 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0J26( )
      {
         standaloneModal0J26( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0J26( )
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

      protected void ScanStart0J26( )
      {
         /* Using cursor T000J31 */
         pr_default.execute(29, new Object[] {A41ClinicaCodigo, A91ConsultaId});
         RcdFound26 = 0 ;
         if ( (pr_default.getStatus(29) != 101) )
         {
            RcdFound26 = 1 ;
            A96SignoLinea = T000J31_A96SignoLinea[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0J26( )
      {
         pr_default.readNext(29);
         RcdFound26 = 0 ;
         if ( (pr_default.getStatus(29) != 101) )
         {
            RcdFound26 = 1 ;
            A96SignoLinea = T000J31_A96SignoLinea[0] ;
         }
      }

      protected void ScanEnd0J26( )
      {
         pr_default.close(1);
      }

      protected void AfterConfirm0J26( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0J26( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0J26( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0J26( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0J26( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0J26( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0J26( )
      {
         edtSignoLinea_Enabled = 0 ;
         edtSignoEstatura_Enabled = 0 ;
         cmbSignoEstaturaEn.Enabled = 0 ;
         edtSignoPeso_Enabled = 0 ;
         cmbSignoPesoEn.Enabled = 0 ;
         edtSignoTemperatura_Enabled = 0 ;
         cmbSignoTemperaturaDe.Enabled = 0 ;
         edtSignoPresionArterial_Enabled = 0 ;
         edtSignoFrecCardiaca_Enabled = 0 ;
         edtSignoFrecRespiratoria_Enabled = 0 ;
         edtSignoFecha_Enabled = 0 ;
         edtSignoHora_Enabled = 0 ;
         edtSignoObs_Enabled = 0 ;
      }

      protected void AddRow0J26( )
      {
         nGXsfl_115_idx = (short)(nGXsfl_115_idx+1) ;
         sGXsfl_115_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_115_idx), 4, 0)), 4, "0") ;
         edtSignoLinea_Internalname = "SIGNOLINEA_"+sGXsfl_115_idx ;
         edtSignoEstatura_Internalname = "SIGNOESTATURA_"+sGXsfl_115_idx ;
         cmbSignoEstaturaEn_Internalname = "SIGNOESTATURAEN_"+sGXsfl_115_idx ;
         edtSignoPeso_Internalname = "SIGNOPESO_"+sGXsfl_115_idx ;
         cmbSignoPesoEn_Internalname = "SIGNOPESOEN_"+sGXsfl_115_idx ;
         edtSignoTemperatura_Internalname = "SIGNOTEMPERATURA_"+sGXsfl_115_idx ;
         cmbSignoTemperaturaDe_Internalname = "SIGNOTEMPERATURADE_"+sGXsfl_115_idx ;
         edtSignoPresionArterial_Internalname = "SIGNOPRESIONARTERIAL_"+sGXsfl_115_idx ;
         edtSignoFrecCardiaca_Internalname = "SIGNOFRECCARDIACA_"+sGXsfl_115_idx ;
         edtSignoFrecRespiratoria_Internalname = "SIGNOFRECRESPIRATORIA_"+sGXsfl_115_idx ;
         edtSignoFecha_Internalname = "SIGNOFECHA_"+sGXsfl_115_idx ;
         edtSignoHora_Internalname = "SIGNOHORA_"+sGXsfl_115_idx ;
         edtSignoObs_Internalname = "SIGNOOBS_"+sGXsfl_115_idx ;
         SendRow0J26( ) ;
      }

      protected void SendRow0J26( )
      {
         Gridconsulta_signoRow = GXWebRow.GetNew(context) ;
         if ( subGridconsulta_signo_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridconsulta_signo_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGridconsulta_signo_Class, "") != 0 )
            {
               subGridconsulta_signo_Linesclass = subGridconsulta_signo_Class+"Odd" ;
            }
         }
         else if ( subGridconsulta_signo_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridconsulta_signo_Backstyle = 0 ;
            subGridconsulta_signo_Backcolor = subGridconsulta_signo_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridconsulta_signoContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridconsulta_signo_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGridconsulta_signo_Class, "") != 0 )
            {
               subGridconsulta_signo_Linesclass = subGridconsulta_signo_Class+"Uniform" ;
            }
         }
         else if ( subGridconsulta_signo_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridconsulta_signo_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGridconsulta_signo_Class, "") != 0 )
            {
               subGridconsulta_signo_Linesclass = subGridconsulta_signo_Class+"Odd" ;
            }
            subGridconsulta_signo_Backcolor = (int)(0xFFFFFF) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridconsulta_signoContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridconsulta_signo_Backcolor), 9, 0)));
         }
         else if ( subGridconsulta_signo_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridconsulta_signo_Backstyle = 1 ;
            if ( ((int)(nGXsfl_115_idx) % (2)) == 0 )
            {
               subGridconsulta_signo_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridconsulta_signoContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridconsulta_signo_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridconsulta_signo_Class, "") != 0 )
               {
                  subGridconsulta_signo_Linesclass = subGridconsulta_signo_Class+"Even" ;
               }
            }
            else
            {
               subGridconsulta_signo_Backcolor = (int)(0xFFFFFF) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridconsulta_signoContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridconsulta_signo_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridconsulta_signo_Class, "") != 0 )
               {
                  subGridconsulta_signo_Linesclass = subGridconsulta_signo_Class+"Odd" ;
               }
            }
         }
         /* * Property Link not supported in */
         /* * Property Link not supported in */
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_26_" + sGXsfl_115_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 116,'',false,'" + sGXsfl_115_idx + "',115)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridconsulta_signoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSignoLinea_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A96SignoLinea), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A96SignoLinea), "ZZZ9")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(116);\"",(String)"",(String)"",(String)"",(String)"",(String)edtSignoLinea_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtSignoLinea_Enabled,(short)1,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)115,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_26_" + sGXsfl_115_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 117,'',false,'" + sGXsfl_115_idx + "',115)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridconsulta_signoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSignoEstatura_Internalname,StringUtil.LTrim( StringUtil.NToC( A97SignoEstatura, 8, 2, ".", "")),((edtSignoEstatura_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A97SignoEstatura, "ZZZZ9.99")) : context.localUtil.Format( A97SignoEstatura, "ZZZZ9.99")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(117);\"",(String)"",(String)"",(String)"",(String)"",(String)edtSignoEstatura_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtSignoEstatura_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)115,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         ClassString = "Attribute" ;
         StyleString = "" ;
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_26_" + sGXsfl_115_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 118,'',false,'" + sGXsfl_115_idx + "',115)\"" ;
         if ( ( nGXsfl_115_idx == 1 ) && isAjaxCallMode( ) )
         {
            GXCCtl = "SIGNOESTATURAEN_" + sGXsfl_115_idx ;
            cmbSignoEstaturaEn.Name = GXCCtl ;
            cmbSignoEstaturaEn.WebTags = "" ;
            cmbSignoEstaturaEn.addItem("CM", "Centímetros", 0);
            cmbSignoEstaturaEn.addItem("ME", "Metros", 0);
            if ( ( cmbSignoEstaturaEn.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A98SignoEstaturaEn)) )
            {
               A98SignoEstaturaEn = cmbSignoEstaturaEn.getItemValue(1) ;
            }
         }
         /* ComboBox */
         Gridconsulta_signoRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbSignoEstaturaEn,(String)cmbSignoEstaturaEn_Internalname,(String)A98SignoEstaturaEn,(short)1,(String)cmbSignoEstaturaEn_Jsonclick,(short)0,(String)"",(String)"svchar",(String)"",(short)-1,cmbSignoEstaturaEn.Enabled,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(118);\"",(String)"",(bool)true});
         cmbSignoEstaturaEn.CurrentValue = A98SignoEstaturaEn ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSignoEstaturaEn_Internalname, "Values", (String)(cmbSignoEstaturaEn.ToJavascriptSource()));
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_26_" + sGXsfl_115_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 119,'',false,'" + sGXsfl_115_idx + "',115)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridconsulta_signoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSignoPeso_Internalname,StringUtil.LTrim( StringUtil.NToC( A99SignoPeso, 8, 2, ".", "")),((edtSignoPeso_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A99SignoPeso, "ZZZZ9.99")) : context.localUtil.Format( A99SignoPeso, "ZZZZ9.99")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(119);\"",(String)"",(String)"",(String)"",(String)"",(String)edtSignoPeso_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtSignoPeso_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)115,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         ClassString = "Attribute" ;
         StyleString = "" ;
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_26_" + sGXsfl_115_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 120,'',false,'" + sGXsfl_115_idx + "',115)\"" ;
         if ( ( nGXsfl_115_idx == 1 ) && isAjaxCallMode( ) )
         {
            GXCCtl = "SIGNOPESOEN_" + sGXsfl_115_idx ;
            cmbSignoPesoEn.Name = GXCCtl ;
            cmbSignoPesoEn.WebTags = "" ;
            cmbSignoPesoEn.addItem("Lb", "Libras", 0);
            cmbSignoPesoEn.addItem("Gr", "Gramos", 0);
            cmbSignoPesoEn.addItem("Kg", "KGramos", 0);
            if ( ( cmbSignoPesoEn.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A100SignoPesoEn)) )
            {
               A100SignoPesoEn = cmbSignoPesoEn.getItemValue(1) ;
            }
         }
         /* ComboBox */
         Gridconsulta_signoRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbSignoPesoEn,(String)cmbSignoPesoEn_Internalname,(String)A100SignoPesoEn,(short)1,(String)cmbSignoPesoEn_Jsonclick,(short)0,(String)"",(String)"svchar",(String)"",(short)-1,cmbSignoPesoEn.Enabled,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(120);\"",(String)"",(bool)true});
         cmbSignoPesoEn.CurrentValue = A100SignoPesoEn ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSignoPesoEn_Internalname, "Values", (String)(cmbSignoPesoEn.ToJavascriptSource()));
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_26_" + sGXsfl_115_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 121,'',false,'" + sGXsfl_115_idx + "',115)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridconsulta_signoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSignoTemperatura_Internalname,StringUtil.LTrim( StringUtil.NToC( A101SignoTemperatura, 8, 2, ".", "")),((edtSignoTemperatura_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A101SignoTemperatura, "ZZZZ9.99")) : context.localUtil.Format( A101SignoTemperatura, "ZZZZ9.99")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(121);\"",(String)"",(String)"",(String)"",(String)"",(String)edtSignoTemperatura_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtSignoTemperatura_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)115,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         ClassString = "Attribute" ;
         StyleString = "" ;
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_26_" + sGXsfl_115_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 122,'',false,'" + sGXsfl_115_idx + "',115)\"" ;
         if ( ( nGXsfl_115_idx == 1 ) && isAjaxCallMode( ) )
         {
            GXCCtl = "SIGNOTEMPERATURADE_" + sGXsfl_115_idx ;
            cmbSignoTemperaturaDe.Name = GXCCtl ;
            cmbSignoTemperaturaDe.WebTags = "" ;
            cmbSignoTemperaturaDe.addItem("Or", "Oral", 0);
            cmbSignoTemperaturaDe.addItem("Ax", "Axilar", 0);
            cmbSignoTemperaturaDe.addItem("Re", "Rectal", 0);
            cmbSignoTemperaturaDe.addItem("Fr", "Frontal", 0);
            if ( ( cmbSignoTemperaturaDe.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A102SignoTemperaturaDe)) )
            {
               A102SignoTemperaturaDe = cmbSignoTemperaturaDe.getItemValue(1) ;
            }
         }
         /* ComboBox */
         Gridconsulta_signoRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbSignoTemperaturaDe,(String)cmbSignoTemperaturaDe_Internalname,(String)A102SignoTemperaturaDe,(short)1,(String)cmbSignoTemperaturaDe_Jsonclick,(short)0,(String)"",(String)"svchar",(String)"",(short)-1,cmbSignoTemperaturaDe.Enabled,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(122);\"",(String)"",(bool)true});
         cmbSignoTemperaturaDe.CurrentValue = A102SignoTemperaturaDe ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSignoTemperaturaDe_Internalname, "Values", (String)(cmbSignoTemperaturaDe.ToJavascriptSource()));
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_26_" + sGXsfl_115_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 123,'',false,'" + sGXsfl_115_idx + "',115)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridconsulta_signoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSignoPresionArterial_Internalname,StringUtil.RTrim( A103SignoPresionArterial),(String)"",TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(123);\"",(String)"",(String)"",(String)"",(String)"",(String)edtSignoPresionArterial_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtSignoPresionArterial_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)6,(short)0,(short)0,(short)115,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_26_" + sGXsfl_115_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 124,'',false,'" + sGXsfl_115_idx + "',115)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridconsulta_signoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSignoFrecCardiaca_Internalname,StringUtil.LTrim( StringUtil.NToC( A104SignoFrecCardiaca, 8, 2, ".", "")),((edtSignoFrecCardiaca_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A104SignoFrecCardiaca, "ZZZZ9.99")) : context.localUtil.Format( A104SignoFrecCardiaca, "ZZZZ9.99")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(124);\"",(String)"",(String)"",(String)"",(String)"",(String)edtSignoFrecCardiaca_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtSignoFrecCardiaca_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)115,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_26_" + sGXsfl_115_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 125,'',false,'" + sGXsfl_115_idx + "',115)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridconsulta_signoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSignoFrecRespiratoria_Internalname,StringUtil.LTrim( StringUtil.NToC( A105SignoFrecRespiratoria, 8, 2, ".", "")),((edtSignoFrecRespiratoria_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A105SignoFrecRespiratoria, "ZZZZ9.99")) : context.localUtil.Format( A105SignoFrecRespiratoria, "ZZZZ9.99")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(125);\"",(String)"",(String)"",(String)"",(String)"",(String)edtSignoFrecRespiratoria_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtSignoFrecRespiratoria_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)115,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_26_" + sGXsfl_115_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 126,'',false,'" + sGXsfl_115_idx + "',115)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridconsulta_signoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSignoFecha_Internalname,context.localUtil.Format(A106SignoFecha, "99/99/99"),context.localUtil.Format( A106SignoFecha, "99/99/99"),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(126);\"",(String)"",(String)"",(String)"",(String)"",(String)edtSignoFecha_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtSignoFecha_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)115,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_26_" + sGXsfl_115_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 127,'',false,'" + sGXsfl_115_idx + "',115)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridconsulta_signoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSignoHora_Internalname,StringUtil.RTrim( A107SignoHora),StringUtil.RTrim( context.localUtil.Format( A107SignoHora, "XXXXXXXX")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(127);\"",(String)"",(String)"",(String)"",(String)"",(String)edtSignoHora_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtSignoHora_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)115,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_26_" + sGXsfl_115_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 128,'',false,'" + sGXsfl_115_idx + "',115)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridconsulta_signoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSignoObs_Internalname,StringUtil.RTrim( A108SignoObs),(String)"",TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(128);\"",(String)"",(String)"",(String)"",(String)"",(String)edtSignoObs_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtSignoObs_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)600,(short)0,(short)0,(short)115,(short)1,(short)-1,(bool)true,(String)"left"});
         context.httpAjaxContext.ajax_sending_grid_row(Gridconsulta_signoRow);
         GXCCtl = "Z96SignoLinea_" + sGXsfl_115_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z96SignoLinea), 4, 0, ".", "")));
         GXCCtl = "Z97SignoEstatura_" + sGXsfl_115_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z97SignoEstatura, 8, 2, ".", "")));
         GXCCtl = "Z98SignoEstaturaEn_" + sGXsfl_115_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z98SignoEstaturaEn));
         GXCCtl = "Z99SignoPeso_" + sGXsfl_115_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z99SignoPeso, 8, 2, ".", "")));
         GXCCtl = "Z100SignoPesoEn_" + sGXsfl_115_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z100SignoPesoEn));
         GXCCtl = "Z101SignoTemperatura_" + sGXsfl_115_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z101SignoTemperatura, 8, 2, ".", "")));
         GXCCtl = "Z102SignoTemperaturaDe_" + sGXsfl_115_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z102SignoTemperaturaDe));
         GXCCtl = "Z103SignoPresionArterial_" + sGXsfl_115_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z103SignoPresionArterial));
         GXCCtl = "Z104SignoFrecCardiaca_" + sGXsfl_115_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z104SignoFrecCardiaca, 8, 2, ".", "")));
         GXCCtl = "Z105SignoFrecRespiratoria_" + sGXsfl_115_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z105SignoFrecRespiratoria, 8, 2, ".", "")));
         GXCCtl = "Z106SignoFecha_" + sGXsfl_115_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, context.localUtil.DToC( Z106SignoFecha, 0, "/"));
         GXCCtl = "Z107SignoHora_" + sGXsfl_115_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z107SignoHora));
         GXCCtl = "Z108SignoObs_" + sGXsfl_115_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z108SignoObs));
         GXCCtl = "nRcdDeleted_26_" + sGXsfl_115_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_26), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_26_" + sGXsfl_115_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_26), 4, 0, ".", "")));
         GXCCtl = "nIsMod_26_" + sGXsfl_115_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_26), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SIGNOLINEA_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoLinea_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SIGNOESTATURA_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoEstatura_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SIGNOESTATURAEN_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbSignoEstaturaEn.Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SIGNOPESO_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoPeso_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SIGNOPESOEN_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbSignoPesoEn.Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SIGNOTEMPERATURA_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoTemperatura_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SIGNOTEMPERATURADE_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbSignoTemperaturaDe.Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SIGNOPRESIONARTERIAL_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoPresionArterial_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SIGNOFRECCARDIACA_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoFrecCardiaca_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SIGNOFRECRESPIRATORIA_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoFrecRespiratoria_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SIGNOFECHA_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoFecha_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SIGNOHORA_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoHora_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SIGNOOBS_"+sGXsfl_115_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSignoObs_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridconsulta_signoContainer.AddRow(Gridconsulta_signoRow);
      }

      protected void ReadRow0J26( )
      {
         nGXsfl_115_idx = (short)(nGXsfl_115_idx+1) ;
         sGXsfl_115_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_115_idx), 4, 0)), 4, "0") ;
         edtSignoLinea_Internalname = "SIGNOLINEA_"+sGXsfl_115_idx ;
         edtSignoEstatura_Internalname = "SIGNOESTATURA_"+sGXsfl_115_idx ;
         cmbSignoEstaturaEn_Internalname = "SIGNOESTATURAEN_"+sGXsfl_115_idx ;
         edtSignoPeso_Internalname = "SIGNOPESO_"+sGXsfl_115_idx ;
         cmbSignoPesoEn_Internalname = "SIGNOPESOEN_"+sGXsfl_115_idx ;
         edtSignoTemperatura_Internalname = "SIGNOTEMPERATURA_"+sGXsfl_115_idx ;
         cmbSignoTemperaturaDe_Internalname = "SIGNOTEMPERATURADE_"+sGXsfl_115_idx ;
         edtSignoPresionArterial_Internalname = "SIGNOPRESIONARTERIAL_"+sGXsfl_115_idx ;
         edtSignoFrecCardiaca_Internalname = "SIGNOFRECCARDIACA_"+sGXsfl_115_idx ;
         edtSignoFrecRespiratoria_Internalname = "SIGNOFRECRESPIRATORIA_"+sGXsfl_115_idx ;
         edtSignoFecha_Internalname = "SIGNOFECHA_"+sGXsfl_115_idx ;
         edtSignoHora_Internalname = "SIGNOHORA_"+sGXsfl_115_idx ;
         edtSignoObs_Internalname = "SIGNOOBS_"+sGXsfl_115_idx ;
         edtSignoLinea_Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOLINEA_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
         edtSignoEstatura_Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOESTATURA_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
         cmbSignoEstaturaEn.Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOESTATURAEN_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
         edtSignoPeso_Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOPESO_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
         cmbSignoPesoEn.Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOPESOEN_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
         edtSignoTemperatura_Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOTEMPERATURA_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
         cmbSignoTemperaturaDe.Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOTEMPERATURADE_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
         edtSignoPresionArterial_Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOPRESIONARTERIAL_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
         edtSignoFrecCardiaca_Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOFRECCARDIACA_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
         edtSignoFrecRespiratoria_Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOFRECRESPIRATORIA_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
         edtSignoFecha_Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOFECHA_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
         edtSignoHora_Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOHORA_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
         edtSignoObs_Enabled = (int)(context.localUtil.CToN( cgiGet( "SIGNOOBS_"+sGXsfl_115_idx+"Enabled"), ".", ",")) ;
         if ( ( ( context.localUtil.CToN( cgiGet( edtSignoLinea_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSignoLinea_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "SIGNOLINEA");
            AnyError = 1 ;
            GX_FocusControl = edtSignoLinea_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A96SignoLinea = 0 ;
         }
         else
         {
            A96SignoLinea = (short)(context.localUtil.CToN( cgiGet( edtSignoLinea_Internalname), ".", ",")) ;
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtSignoEstatura_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSignoEstatura_Internalname), ".", ",") > 99999.99m ) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "SIGNOESTATURA");
            AnyError = 1 ;
            GX_FocusControl = edtSignoEstatura_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A97SignoEstatura = 0 ;
         }
         else
         {
            A97SignoEstatura = context.localUtil.CToN( cgiGet( edtSignoEstatura_Internalname), ".", ",") ;
         }
         cmbSignoEstaturaEn.Name = cmbSignoEstaturaEn_Internalname ;
         cmbSignoEstaturaEn.CurrentValue = cgiGet( cmbSignoEstaturaEn_Internalname) ;
         A98SignoEstaturaEn = cgiGet( cmbSignoEstaturaEn_Internalname) ;
         if ( ( ( context.localUtil.CToN( cgiGet( edtSignoPeso_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSignoPeso_Internalname), ".", ",") > 99999.99m ) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "SIGNOPESO");
            AnyError = 1 ;
            GX_FocusControl = edtSignoPeso_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A99SignoPeso = 0 ;
         }
         else
         {
            A99SignoPeso = context.localUtil.CToN( cgiGet( edtSignoPeso_Internalname), ".", ",") ;
         }
         cmbSignoPesoEn.Name = cmbSignoPesoEn_Internalname ;
         cmbSignoPesoEn.CurrentValue = cgiGet( cmbSignoPesoEn_Internalname) ;
         A100SignoPesoEn = cgiGet( cmbSignoPesoEn_Internalname) ;
         if ( ( ( context.localUtil.CToN( cgiGet( edtSignoTemperatura_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSignoTemperatura_Internalname), ".", ",") > 99999.99m ) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "SIGNOTEMPERATURA");
            AnyError = 1 ;
            GX_FocusControl = edtSignoTemperatura_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A101SignoTemperatura = 0 ;
         }
         else
         {
            A101SignoTemperatura = context.localUtil.CToN( cgiGet( edtSignoTemperatura_Internalname), ".", ",") ;
         }
         cmbSignoTemperaturaDe.Name = cmbSignoTemperaturaDe_Internalname ;
         cmbSignoTemperaturaDe.CurrentValue = cgiGet( cmbSignoTemperaturaDe_Internalname) ;
         A102SignoTemperaturaDe = cgiGet( cmbSignoTemperaturaDe_Internalname) ;
         A103SignoPresionArterial = cgiGet( edtSignoPresionArterial_Internalname) ;
         if ( ( ( context.localUtil.CToN( cgiGet( edtSignoFrecCardiaca_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSignoFrecCardiaca_Internalname), ".", ",") > 99999.99m ) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "SIGNOFRECCARDIACA");
            AnyError = 1 ;
            GX_FocusControl = edtSignoFrecCardiaca_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A104SignoFrecCardiaca = 0 ;
         }
         else
         {
            A104SignoFrecCardiaca = context.localUtil.CToN( cgiGet( edtSignoFrecCardiaca_Internalname), ".", ",") ;
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtSignoFrecRespiratoria_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSignoFrecRespiratoria_Internalname), ".", ",") > 99999.99m ) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "SIGNOFRECRESPIRATORIA");
            AnyError = 1 ;
            GX_FocusControl = edtSignoFrecRespiratoria_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A105SignoFrecRespiratoria = 0 ;
         }
         else
         {
            A105SignoFrecRespiratoria = context.localUtil.CToN( cgiGet( edtSignoFrecRespiratoria_Internalname), ".", ",") ;
         }
         if ( context.localUtil.VCDate( cgiGet( edtSignoFecha_Internalname), 2) == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, "SIGNOFECHA");
            AnyError = 1 ;
            GX_FocusControl = edtSignoFecha_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A106SignoFecha = DateTime.MinValue ;
         }
         else
         {
            A106SignoFecha = context.localUtil.CToD( cgiGet( edtSignoFecha_Internalname), 2) ;
         }
         A107SignoHora = cgiGet( edtSignoHora_Internalname) ;
         A108SignoObs = cgiGet( edtSignoObs_Internalname) ;
         GXCCtl = "Z96SignoLinea_" + sGXsfl_115_idx ;
         Z96SignoLinea = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "Z97SignoEstatura_" + sGXsfl_115_idx ;
         Z97SignoEstatura = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",") ;
         GXCCtl = "Z98SignoEstaturaEn_" + sGXsfl_115_idx ;
         Z98SignoEstaturaEn = cgiGet( GXCCtl) ;
         GXCCtl = "Z99SignoPeso_" + sGXsfl_115_idx ;
         Z99SignoPeso = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",") ;
         GXCCtl = "Z100SignoPesoEn_" + sGXsfl_115_idx ;
         Z100SignoPesoEn = cgiGet( GXCCtl) ;
         GXCCtl = "Z101SignoTemperatura_" + sGXsfl_115_idx ;
         Z101SignoTemperatura = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",") ;
         GXCCtl = "Z102SignoTemperaturaDe_" + sGXsfl_115_idx ;
         Z102SignoTemperaturaDe = cgiGet( GXCCtl) ;
         GXCCtl = "Z103SignoPresionArterial_" + sGXsfl_115_idx ;
         Z103SignoPresionArterial = cgiGet( GXCCtl) ;
         GXCCtl = "Z104SignoFrecCardiaca_" + sGXsfl_115_idx ;
         Z104SignoFrecCardiaca = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",") ;
         GXCCtl = "Z105SignoFrecRespiratoria_" + sGXsfl_115_idx ;
         Z105SignoFrecRespiratoria = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",") ;
         GXCCtl = "Z106SignoFecha_" + sGXsfl_115_idx ;
         Z106SignoFecha = context.localUtil.CToD( cgiGet( GXCCtl), 0) ;
         GXCCtl = "Z107SignoHora_" + sGXsfl_115_idx ;
         Z107SignoHora = cgiGet( GXCCtl) ;
         GXCCtl = "Z108SignoObs_" + sGXsfl_115_idx ;
         Z108SignoObs = cgiGet( GXCCtl) ;
         GXCCtl = "nRcdDeleted_26_" + sGXsfl_115_idx ;
         nRcdDeleted_26 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdExists_26_" + sGXsfl_115_idx ;
         nRcdExists_26 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nIsMod_26_" + sGXsfl_115_idx ;
         nIsMod_26 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
      }

      protected void assign_properties_default( )
      {
         defedtSignoLinea_Enabled = edtSignoLinea_Enabled ;
      }

      protected void ConfirmValues0J0( )
      {
         nGXsfl_115_idx = 0 ;
         sGXsfl_115_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_115_idx), 4, 0)), 4, "0") ;
         edtSignoLinea_Internalname = "SIGNOLINEA_"+sGXsfl_115_idx ;
         edtSignoEstatura_Internalname = "SIGNOESTATURA_"+sGXsfl_115_idx ;
         cmbSignoEstaturaEn_Internalname = "SIGNOESTATURAEN_"+sGXsfl_115_idx ;
         edtSignoPeso_Internalname = "SIGNOPESO_"+sGXsfl_115_idx ;
         cmbSignoPesoEn_Internalname = "SIGNOPESOEN_"+sGXsfl_115_idx ;
         edtSignoTemperatura_Internalname = "SIGNOTEMPERATURA_"+sGXsfl_115_idx ;
         cmbSignoTemperaturaDe_Internalname = "SIGNOTEMPERATURADE_"+sGXsfl_115_idx ;
         edtSignoPresionArterial_Internalname = "SIGNOPRESIONARTERIAL_"+sGXsfl_115_idx ;
         edtSignoFrecCardiaca_Internalname = "SIGNOFRECCARDIACA_"+sGXsfl_115_idx ;
         edtSignoFrecRespiratoria_Internalname = "SIGNOFRECRESPIRATORIA_"+sGXsfl_115_idx ;
         edtSignoFecha_Internalname = "SIGNOFECHA_"+sGXsfl_115_idx ;
         edtSignoHora_Internalname = "SIGNOHORA_"+sGXsfl_115_idx ;
         edtSignoObs_Internalname = "SIGNOOBS_"+sGXsfl_115_idx ;
         while ( nGXsfl_115_idx < nRC_Gridconsulta_signo )
         {
            nGXsfl_115_idx = (short)(nGXsfl_115_idx+1) ;
            sGXsfl_115_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_115_idx), 4, 0)), 4, "0") ;
            edtSignoLinea_Internalname = "SIGNOLINEA_"+sGXsfl_115_idx ;
            edtSignoEstatura_Internalname = "SIGNOESTATURA_"+sGXsfl_115_idx ;
            cmbSignoEstaturaEn_Internalname = "SIGNOESTATURAEN_"+sGXsfl_115_idx ;
            edtSignoPeso_Internalname = "SIGNOPESO_"+sGXsfl_115_idx ;
            cmbSignoPesoEn_Internalname = "SIGNOPESOEN_"+sGXsfl_115_idx ;
            edtSignoTemperatura_Internalname = "SIGNOTEMPERATURA_"+sGXsfl_115_idx ;
            cmbSignoTemperaturaDe_Internalname = "SIGNOTEMPERATURADE_"+sGXsfl_115_idx ;
            edtSignoPresionArterial_Internalname = "SIGNOPRESIONARTERIAL_"+sGXsfl_115_idx ;
            edtSignoFrecCardiaca_Internalname = "SIGNOFRECCARDIACA_"+sGXsfl_115_idx ;
            edtSignoFrecRespiratoria_Internalname = "SIGNOFRECRESPIRATORIA_"+sGXsfl_115_idx ;
            edtSignoFecha_Internalname = "SIGNOFECHA_"+sGXsfl_115_idx ;
            edtSignoHora_Internalname = "SIGNOHORA_"+sGXsfl_115_idx ;
            edtSignoObs_Internalname = "SIGNOOBS_"+sGXsfl_115_idx ;
            ChangePostValue( "Z96SignoLinea_"+sGXsfl_115_idx, cgiGet( "ZT_"+"Z96SignoLinea_"+sGXsfl_115_idx)) ;
            DeletePostValue( "ZT_"+"Z96SignoLinea_"+sGXsfl_115_idx) ;
            ChangePostValue( "Z97SignoEstatura_"+sGXsfl_115_idx, cgiGet( "ZT_"+"Z97SignoEstatura_"+sGXsfl_115_idx)) ;
            DeletePostValue( "ZT_"+"Z97SignoEstatura_"+sGXsfl_115_idx) ;
            ChangePostValue( "Z98SignoEstaturaEn_"+sGXsfl_115_idx, cgiGet( "ZT_"+"Z98SignoEstaturaEn_"+sGXsfl_115_idx)) ;
            DeletePostValue( "ZT_"+"Z98SignoEstaturaEn_"+sGXsfl_115_idx) ;
            ChangePostValue( "Z99SignoPeso_"+sGXsfl_115_idx, cgiGet( "ZT_"+"Z99SignoPeso_"+sGXsfl_115_idx)) ;
            DeletePostValue( "ZT_"+"Z99SignoPeso_"+sGXsfl_115_idx) ;
            ChangePostValue( "Z100SignoPesoEn_"+sGXsfl_115_idx, cgiGet( "ZT_"+"Z100SignoPesoEn_"+sGXsfl_115_idx)) ;
            DeletePostValue( "ZT_"+"Z100SignoPesoEn_"+sGXsfl_115_idx) ;
            ChangePostValue( "Z101SignoTemperatura_"+sGXsfl_115_idx, cgiGet( "ZT_"+"Z101SignoTemperatura_"+sGXsfl_115_idx)) ;
            DeletePostValue( "ZT_"+"Z101SignoTemperatura_"+sGXsfl_115_idx) ;
            ChangePostValue( "Z102SignoTemperaturaDe_"+sGXsfl_115_idx, cgiGet( "ZT_"+"Z102SignoTemperaturaDe_"+sGXsfl_115_idx)) ;
            DeletePostValue( "ZT_"+"Z102SignoTemperaturaDe_"+sGXsfl_115_idx) ;
            ChangePostValue( "Z103SignoPresionArterial_"+sGXsfl_115_idx, cgiGet( "ZT_"+"Z103SignoPresionArterial_"+sGXsfl_115_idx)) ;
            DeletePostValue( "ZT_"+"Z103SignoPresionArterial_"+sGXsfl_115_idx) ;
            ChangePostValue( "Z104SignoFrecCardiaca_"+sGXsfl_115_idx, cgiGet( "ZT_"+"Z104SignoFrecCardiaca_"+sGXsfl_115_idx)) ;
            DeletePostValue( "ZT_"+"Z104SignoFrecCardiaca_"+sGXsfl_115_idx) ;
            ChangePostValue( "Z105SignoFrecRespiratoria_"+sGXsfl_115_idx, cgiGet( "ZT_"+"Z105SignoFrecRespiratoria_"+sGXsfl_115_idx)) ;
            DeletePostValue( "ZT_"+"Z105SignoFrecRespiratoria_"+sGXsfl_115_idx) ;
            ChangePostValue( "Z106SignoFecha_"+sGXsfl_115_idx, cgiGet( "ZT_"+"Z106SignoFecha_"+sGXsfl_115_idx)) ;
            DeletePostValue( "ZT_"+"Z106SignoFecha_"+sGXsfl_115_idx) ;
            ChangePostValue( "Z107SignoHora_"+sGXsfl_115_idx, cgiGet( "ZT_"+"Z107SignoHora_"+sGXsfl_115_idx)) ;
            DeletePostValue( "ZT_"+"Z107SignoHora_"+sGXsfl_115_idx) ;
            ChangePostValue( "Z108SignoObs_"+sGXsfl_115_idx, cgiGet( "ZT_"+"Z108SignoObs_"+sGXsfl_115_idx)) ;
            DeletePostValue( "ZT_"+"Z108SignoObs_"+sGXsfl_115_idx) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("consulta.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z91ConsultaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z91ConsultaId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z92ConsultaFecha", context.localUtil.DToC( Z92ConsultaFecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z93ConsultaHora", StringUtil.RTrim( Z93ConsultaHora));
         GxWebStd.gx_hidden_field( context, "Z157ConsultaEdad", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z157ConsultaEdad), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z94ConsultaTipo", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z94ConsultaTipo), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z158ConsultaPoliza", StringUtil.RTrim( Z158ConsultaPoliza));
         GxWebStd.gx_hidden_field( context, "Z95ConsultaObs", StringUtil.RTrim( Z95ConsultaObs));
         GxWebStd.gx_hidden_field( context, "Z159ConsultaEstado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z159ConsultaEstado), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z160ConsultaFechaFin", context.localUtil.DToC( Z160ConsultaFechaFin, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z161ConsultaHoraFin", StringUtil.RTrim( Z161ConsultaHoraFin));
         GxWebStd.gx_hidden_field( context, "Z19MedicoCodigo", StringUtil.RTrim( Z19MedicoCodigo));
         GxWebStd.gx_hidden_field( context, "Z50Cie10Codigo", StringUtil.RTrim( Z50Cie10Codigo));
         GxWebStd.gx_hidden_field( context, "Z67PacienteId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z67PacienteId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z82AsegCodigo", StringUtil.RTrim( Z82AsegCodigo));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_Gridconsulta_signo", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_115_idx), 4, 0, ".", "")));
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
         return "Consulta" ;
      }

      public override String GetPgmdesc( )
      {
         return "Consulta de pacientes" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("consulta.aspx")  ;
      }

      protected void InitializeNonKey0J25( )
      {
         A92ConsultaFecha = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92ConsultaFecha", context.localUtil.Format(A92ConsultaFecha, "99/99/99"));
         A93ConsultaHora = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93ConsultaHora", A93ConsultaHora);
         A67PacienteId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
         A157ConsultaEdad = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157ConsultaEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A157ConsultaEdad), 4, 0)));
         A94ConsultaTipo = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94ConsultaTipo", StringUtil.Str( (decimal)(A94ConsultaTipo), 1, 0));
         A82AsegCodigo = "" ;
         n82AsegCodigo = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A82AsegCodigo", A82AsegCodigo);
         n82AsegCodigo = (String.IsNullOrEmpty(StringUtil.RTrim( A82AsegCodigo)) ? true : false) ;
         A158ConsultaPoliza = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158ConsultaPoliza", A158ConsultaPoliza);
         A95ConsultaObs = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A95ConsultaObs", A95ConsultaObs);
         A50Cie10Codigo = "" ;
         n50Cie10Codigo = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50Cie10Codigo", A50Cie10Codigo);
         n50Cie10Codigo = (String.IsNullOrEmpty(StringUtil.RTrim( A50Cie10Codigo)) ? true : false) ;
         A159ConsultaEstado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159ConsultaEstado", StringUtil.Str( (decimal)(A159ConsultaEstado), 1, 0));
         A160ConsultaFechaFin = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A160ConsultaFechaFin", context.localUtil.Format(A160ConsultaFechaFin, "99/99/99"));
         A161ConsultaHoraFin = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161ConsultaHoraFin", A161ConsultaHoraFin);
         A19MedicoCodigo = "" ;
         n19MedicoCodigo = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
         n19MedicoCodigo = (String.IsNullOrEmpty(StringUtil.RTrim( A19MedicoCodigo)) ? true : false) ;
      }

      protected void InitAll0J25( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A91ConsultaId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
         InitializeNonKey0J25( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0J26( )
      {
         A97SignoEstatura = 0 ;
         A98SignoEstaturaEn = "" ;
         A99SignoPeso = 0 ;
         A100SignoPesoEn = "" ;
         A101SignoTemperatura = 0 ;
         A102SignoTemperaturaDe = "" ;
         A103SignoPresionArterial = "" ;
         A104SignoFrecCardiaca = 0 ;
         A105SignoFrecRespiratoria = 0 ;
         A106SignoFecha = DateTime.MinValue ;
         A107SignoHora = "" ;
         A108SignoObs = "" ;
      }

      protected void InitAll0J26( )
      {
         A96SignoLinea = 0 ;
         InitializeNonKey0J26( ) ;
      }

      protected void StandaloneModalInsert0J26( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?75080");
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?155824");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("consulta.js", "?155824");
         /* End function include_jscripts */
      }

      protected void init_level_properties26( )
      {
         edtSignoLinea_Enabled = defedtSignoLinea_Enabled ;
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
         lblTextblockconsultaid_Internalname = "TEXTBLOCKCONSULTAID" ;
         edtConsultaId_Internalname = "CONSULTAID" ;
         lblTextblockconsultafecha_Internalname = "TEXTBLOCKCONSULTAFECHA" ;
         edtConsultaFecha_Internalname = "CONSULTAFECHA" ;
         lblTextblockconsultahora_Internalname = "TEXTBLOCKCONSULTAHORA" ;
         edtConsultaHora_Internalname = "CONSULTAHORA" ;
         lblTextblockpacienteid_Internalname = "TEXTBLOCKPACIENTEID" ;
         edtPacienteId_Internalname = "PACIENTEID" ;
         lblTextblockconsultaedad_Internalname = "TEXTBLOCKCONSULTAEDAD" ;
         edtConsultaEdad_Internalname = "CONSULTAEDAD" ;
         lblTextblockconsultatipo_Internalname = "TEXTBLOCKCONSULTATIPO" ;
         cmbConsultaTipo_Internalname = "CONSULTATIPO" ;
         lblTextblockasegcodigo_Internalname = "TEXTBLOCKASEGCODIGO" ;
         edtAsegCodigo_Internalname = "ASEGCODIGO" ;
         lblTextblockconsultapoliza_Internalname = "TEXTBLOCKCONSULTAPOLIZA" ;
         edtConsultaPoliza_Internalname = "CONSULTAPOLIZA" ;
         lblTextblockconsultaobs_Internalname = "TEXTBLOCKCONSULTAOBS" ;
         edtConsultaObs_Internalname = "CONSULTAOBS" ;
         lblTextblockcie10codigo_Internalname = "TEXTBLOCKCIE10CODIGO" ;
         edtCie10Codigo_Internalname = "CIE10CODIGO" ;
         lblTextblockconsultaestado_Internalname = "TEXTBLOCKCONSULTAESTADO" ;
         cmbConsultaEstado_Internalname = "CONSULTAESTADO" ;
         lblTextblockconsultafechafin_Internalname = "TEXTBLOCKCONSULTAFECHAFIN" ;
         edtConsultaFechaFin_Internalname = "CONSULTAFECHAFIN" ;
         lblTextblockconsultahorafin_Internalname = "TEXTBLOCKCONSULTAHORAFIN" ;
         edtConsultaHoraFin_Internalname = "CONSULTAHORAFIN" ;
         lblTextblockmedicocodigo_Internalname = "TEXTBLOCKMEDICOCODIGO" ;
         edtMedicoCodigo_Internalname = "MEDICOCODIGO" ;
         lblTitlesigno_Internalname = "TITLESIGNO" ;
         tblTable3_Internalname = "TABLE3" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_67_Internalname = "PROMPT_41_67" ;
         imgprompt_41_82_Internalname = "PROMPT_41_82" ;
         imgprompt_41_50_Internalname = "PROMPT_41_50" ;
         imgprompt_41_19_Internalname = "PROMPT_41_19" ;
         subGridconsulta_signo_Internalname = "GRIDCONSULTA_SIGNO" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Consulta de pacientes" ;
         edtSignoObs_Jsonclick = "" ;
         edtSignoHora_Jsonclick = "" ;
         edtSignoFecha_Jsonclick = "" ;
         edtSignoFrecRespiratoria_Jsonclick = "" ;
         edtSignoFrecCardiaca_Jsonclick = "" ;
         edtSignoPresionArterial_Jsonclick = "" ;
         cmbSignoTemperaturaDe_Jsonclick = "" ;
         edtSignoTemperatura_Jsonclick = "" ;
         cmbSignoPesoEn_Jsonclick = "" ;
         edtSignoPeso_Jsonclick = "" ;
         cmbSignoEstaturaEn_Jsonclick = "" ;
         edtSignoEstatura_Jsonclick = "" ;
         edtSignoLinea_Jsonclick = "" ;
         subGridconsulta_signo_Class = "Grid" ;
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
         subGridconsulta_signo_Allowcollapsing = 0 ;
         edtSignoObs_Enabled = 1 ;
         edtSignoHora_Enabled = 1 ;
         edtSignoFecha_Enabled = 1 ;
         edtSignoFrecRespiratoria_Enabled = 1 ;
         edtSignoFrecCardiaca_Enabled = 1 ;
         edtSignoPresionArterial_Enabled = 1 ;
         cmbSignoTemperaturaDe.Enabled = 1 ;
         edtSignoTemperatura_Enabled = 1 ;
         cmbSignoPesoEn.Enabled = 1 ;
         edtSignoPeso_Enabled = 1 ;
         cmbSignoEstaturaEn.Enabled = 1 ;
         edtSignoEstatura_Enabled = 1 ;
         edtSignoLinea_Enabled = 1 ;
         subGridconsulta_signo_Backcolorstyle = 2 ;
         imgprompt_41_19_Visible = 1 ;
         imgprompt_41_19_Link = "" ;
         edtMedicoCodigo_Jsonclick = "" ;
         edtMedicoCodigo_Enabled = 1 ;
         edtConsultaHoraFin_Jsonclick = "" ;
         edtConsultaHoraFin_Enabled = 1 ;
         edtConsultaFechaFin_Jsonclick = "" ;
         edtConsultaFechaFin_Enabled = 1 ;
         cmbConsultaEstado_Jsonclick = "" ;
         cmbConsultaEstado.Enabled = 1 ;
         imgprompt_41_50_Visible = 1 ;
         imgprompt_41_50_Link = "" ;
         edtCie10Codigo_Jsonclick = "" ;
         edtCie10Codigo_Enabled = 1 ;
         edtConsultaObs_Enabled = 1 ;
         edtConsultaPoliza_Jsonclick = "" ;
         edtConsultaPoliza_Enabled = 1 ;
         imgprompt_41_82_Visible = 1 ;
         imgprompt_41_82_Link = "" ;
         edtAsegCodigo_Jsonclick = "" ;
         edtAsegCodigo_Enabled = 1 ;
         cmbConsultaTipo_Jsonclick = "" ;
         cmbConsultaTipo.Enabled = 1 ;
         edtConsultaEdad_Jsonclick = "" ;
         edtConsultaEdad_Enabled = 1 ;
         imgprompt_41_67_Visible = 1 ;
         imgprompt_41_67_Link = "" ;
         edtPacienteId_Jsonclick = "" ;
         edtPacienteId_Enabled = 1 ;
         edtConsultaHora_Jsonclick = "" ;
         edtConsultaHora_Enabled = 1 ;
         edtConsultaFecha_Jsonclick = "" ;
         edtConsultaFecha_Enabled = 1 ;
         edtConsultaId_Jsonclick = "" ;
         edtConsultaId_Enabled = 1 ;
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

      protected void gxnrGridconsulta_signo_newrow( short nRC_Gridconsulta_signo ,
                                                    short nGXsfl_115_idx ,
                                                    String sGXsfl_115_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         edtSignoLinea_Internalname = "SIGNOLINEA_"+sGXsfl_115_idx ;
         edtSignoEstatura_Internalname = "SIGNOESTATURA_"+sGXsfl_115_idx ;
         cmbSignoEstaturaEn_Internalname = "SIGNOESTATURAEN_"+sGXsfl_115_idx ;
         edtSignoPeso_Internalname = "SIGNOPESO_"+sGXsfl_115_idx ;
         cmbSignoPesoEn_Internalname = "SIGNOPESOEN_"+sGXsfl_115_idx ;
         edtSignoTemperatura_Internalname = "SIGNOTEMPERATURA_"+sGXsfl_115_idx ;
         cmbSignoTemperaturaDe_Internalname = "SIGNOTEMPERATURADE_"+sGXsfl_115_idx ;
         edtSignoPresionArterial_Internalname = "SIGNOPRESIONARTERIAL_"+sGXsfl_115_idx ;
         edtSignoFrecCardiaca_Internalname = "SIGNOFRECCARDIACA_"+sGXsfl_115_idx ;
         edtSignoFrecRespiratoria_Internalname = "SIGNOFRECRESPIRATORIA_"+sGXsfl_115_idx ;
         edtSignoFecha_Internalname = "SIGNOFECHA_"+sGXsfl_115_idx ;
         edtSignoHora_Internalname = "SIGNOHORA_"+sGXsfl_115_idx ;
         edtSignoObs_Internalname = "SIGNOOBS_"+sGXsfl_115_idx ;
         while ( nGXsfl_115_idx <= nRC_Gridconsulta_signo )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0J26( ) ;
            standaloneModal0J26( ) ;
            cmbConsultaTipo.Name = "CONSULTATIPO" ;
            cmbConsultaTipo.WebTags = "" ;
            cmbConsultaTipo.addItem("1", "Consulta en clínica", 0);
            cmbConsultaTipo.addItem("2", "Consulta telefónica", 0);
            cmbConsultaTipo.addItem("3", "En hospital", 0);
            cmbConsultaTipo.addItem("4", "A domicilio", 0);
            if ( ( cmbConsultaTipo.ItemCount > 0 ) && (0==A94ConsultaTipo) )
            {
               A94ConsultaTipo = (short)(NumberUtil.Val( cmbConsultaTipo.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94ConsultaTipo", StringUtil.Str( (decimal)(A94ConsultaTipo), 1, 0));
            }
            cmbConsultaEstado.Name = "CONSULTAESTADO" ;
            cmbConsultaEstado.WebTags = "" ;
            cmbConsultaEstado.addItem("1", "Creado", 0);
            cmbConsultaEstado.addItem("2", "Finalizado", 0);
            cmbConsultaEstado.addItem("3", "Facturado", 0);
            cmbConsultaEstado.addItem("4", "Cancelado", 0);
            if ( ( cmbConsultaEstado.ItemCount > 0 ) && (0==A159ConsultaEstado) )
            {
               A159ConsultaEstado = (short)(NumberUtil.Val( cmbConsultaEstado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159ConsultaEstado", StringUtil.Str( (decimal)(A159ConsultaEstado), 1, 0));
            }
            GXCCtl = "SIGNOESTATURAEN_" + sGXsfl_115_idx ;
            cmbSignoEstaturaEn.Name = GXCCtl ;
            cmbSignoEstaturaEn.WebTags = "" ;
            cmbSignoEstaturaEn.addItem("CM", "Centímetros", 0);
            cmbSignoEstaturaEn.addItem("ME", "Metros", 0);
            if ( ( cmbSignoEstaturaEn.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A98SignoEstaturaEn)) )
            {
               A98SignoEstaturaEn = cmbSignoEstaturaEn.getItemValue(1) ;
            }
            GXCCtl = "SIGNOPESOEN_" + sGXsfl_115_idx ;
            cmbSignoPesoEn.Name = GXCCtl ;
            cmbSignoPesoEn.WebTags = "" ;
            cmbSignoPesoEn.addItem("Lb", "Libras", 0);
            cmbSignoPesoEn.addItem("Gr", "Gramos", 0);
            cmbSignoPesoEn.addItem("Kg", "KGramos", 0);
            if ( ( cmbSignoPesoEn.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A100SignoPesoEn)) )
            {
               A100SignoPesoEn = cmbSignoPesoEn.getItemValue(1) ;
            }
            GXCCtl = "SIGNOTEMPERATURADE_" + sGXsfl_115_idx ;
            cmbSignoTemperaturaDe.Name = GXCCtl ;
            cmbSignoTemperaturaDe.WebTags = "" ;
            cmbSignoTemperaturaDe.addItem("Or", "Oral", 0);
            cmbSignoTemperaturaDe.addItem("Ax", "Axilar", 0);
            cmbSignoTemperaturaDe.addItem("Re", "Rectal", 0);
            cmbSignoTemperaturaDe.addItem("Fr", "Frontal", 0);
            if ( ( cmbSignoTemperaturaDe.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A102SignoTemperaturaDe)) )
            {
               A102SignoTemperaturaDe = cmbSignoTemperaturaDe.getItemValue(1) ;
            }
            dynload_actions( ) ;
            SendRow0J26( ) ;
            nGXsfl_115_idx = (short)(nGXsfl_115_idx+1) ;
            sGXsfl_115_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_115_idx), 4, 0)), 4, "0") ;
            edtSignoLinea_Internalname = "SIGNOLINEA_"+sGXsfl_115_idx ;
            edtSignoEstatura_Internalname = "SIGNOESTATURA_"+sGXsfl_115_idx ;
            cmbSignoEstaturaEn_Internalname = "SIGNOESTATURAEN_"+sGXsfl_115_idx ;
            edtSignoPeso_Internalname = "SIGNOPESO_"+sGXsfl_115_idx ;
            cmbSignoPesoEn_Internalname = "SIGNOPESOEN_"+sGXsfl_115_idx ;
            edtSignoTemperatura_Internalname = "SIGNOTEMPERATURA_"+sGXsfl_115_idx ;
            cmbSignoTemperaturaDe_Internalname = "SIGNOTEMPERATURADE_"+sGXsfl_115_idx ;
            edtSignoPresionArterial_Internalname = "SIGNOPRESIONARTERIAL_"+sGXsfl_115_idx ;
            edtSignoFrecCardiaca_Internalname = "SIGNOFRECCARDIACA_"+sGXsfl_115_idx ;
            edtSignoFrecRespiratoria_Internalname = "SIGNOFRECRESPIRATORIA_"+sGXsfl_115_idx ;
            edtSignoFecha_Internalname = "SIGNOFECHA_"+sGXsfl_115_idx ;
            edtSignoHora_Internalname = "SIGNOHORA_"+sGXsfl_115_idx ;
            edtSignoObs_Internalname = "SIGNOOBS_"+sGXsfl_115_idx ;
         }
         context.GX_webresponse.AddString(Gridconsulta_signoContainer.ToJavascriptSource());
         /* End function gxnrGridconsulta_signo_newrow */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         GX_FocusControl = edtConsultaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Consultaid( String GX_Parm1 ,
                                    int GX_Parm2 ,
                                    DateTime GX_Parm3 ,
                                    String GX_Parm4 ,
                                    short GX_Parm5 ,
                                    GXCombobox cmbGX_Parm6 ,
                                    String GX_Parm7 ,
                                    String GX_Parm8 ,
                                    GXCombobox cmbGX_Parm9 ,
                                    DateTime GX_Parm10 ,
                                    String GX_Parm11 ,
                                    String GX_Parm12 ,
                                    String GX_Parm13 ,
                                    int GX_Parm14 ,
                                    String GX_Parm15 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A91ConsultaId = GX_Parm2 ;
         A92ConsultaFecha = GX_Parm3 ;
         A93ConsultaHora = GX_Parm4 ;
         A157ConsultaEdad = GX_Parm5 ;
         cmbConsultaTipo = cmbGX_Parm6 ;
         A94ConsultaTipo = (short)(NumberUtil.Val( cmbConsultaTipo.CurrentValue, ".")) ;
         cmbConsultaTipo.CurrentValue = StringUtil.Str( (decimal)(A94ConsultaTipo), 1, 0) ;
         A158ConsultaPoliza = GX_Parm7 ;
         A95ConsultaObs = GX_Parm8 ;
         cmbConsultaEstado = cmbGX_Parm9 ;
         A159ConsultaEstado = (short)(NumberUtil.Val( cmbConsultaEstado.CurrentValue, ".")) ;
         cmbConsultaEstado.CurrentValue = StringUtil.Str( (decimal)(A159ConsultaEstado), 1, 0) ;
         A160ConsultaFechaFin = GX_Parm10 ;
         A161ConsultaHoraFin = GX_Parm11 ;
         A19MedicoCodigo = GX_Parm12 ;
         n19MedicoCodigo = false ;
         A50Cie10Codigo = GX_Parm13 ;
         n50Cie10Codigo = false ;
         A67PacienteId = GX_Parm14 ;
         A82AsegCodigo = GX_Parm15 ;
         n82AsegCodigo = false ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(context.localUtil.Format(A92ConsultaFecha, "99/99/99")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A93ConsultaHora)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A67PacienteId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A157ConsultaEdad), 4, 0, ".", ""))));
         cmbConsultaTipo.CurrentValue = StringUtil.Str( (decimal)(A94ConsultaTipo), 1, 0) ;
         isValidOutput.Add((Object)(cmbConsultaTipo));
         isValidOutput.Add((Object)(StringUtil.RTrim( A82AsegCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A158ConsultaPoliza)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A95ConsultaObs)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A50Cie10Codigo)));
         cmbConsultaEstado.CurrentValue = StringUtil.Str( (decimal)(A159ConsultaEstado), 1, 0) ;
         isValidOutput.Add((Object)(cmbConsultaEstado));
         isValidOutput.Add((Object)(context.localUtil.Format(A160ConsultaFechaFin, "99/99/99")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A161ConsultaHoraFin)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A19MedicoCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z91ConsultaId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z92ConsultaFecha, 0, "/")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z93ConsultaHora)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z67PacienteId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z157ConsultaEdad), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z94ConsultaTipo), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z82AsegCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z158ConsultaPoliza)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z95ConsultaObs)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z50Cie10Codigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z159ConsultaEstado), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z160ConsultaFechaFin, 0, "/")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z161ConsultaHoraFin)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z19MedicoCodigo)));
         isValidOutput.Add((Object)(Gridconsulta_signoContainer));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Pacienteid( String GX_Parm1 ,
                                    int GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A67PacienteId = GX_Parm2 ;
         /* Using cursor T000J32 */
         pr_default.execute(30, new Object[] {A41ClinicaCodigo, A67PacienteId});
         if ( (pr_default.getStatus(30) == 101) )
         {
            AnyError41 = 1 ;
            AnyError67 = 1 ;
            GX_msglist.addItem("No existe 'Pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError67 == 0 ) )
         {
         }
         pr_default.close(30);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Asegcodigo( String GX_Parm1 ,
                                    String GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A82AsegCodigo = GX_Parm2 ;
         n82AsegCodigo = false ;
         /* Using cursor T000J33 */
         pr_default.execute(31, new Object[] {A41ClinicaCodigo, n82AsegCodigo, A82AsegCodigo});
         if ( (pr_default.getStatus(31) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A41ClinicaCodigo)) || String.IsNullOrEmpty(StringUtil.RTrim( A82AsegCodigo)) ) )
            {
               AnyError41 = 1 ;
               AnyError82 = 1 ;
               GX_msglist.addItem("No existe 'Aseguradoras'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
            }
         }
         if ( ( AnyError41 == 0 ) && ( AnyError82 == 0 ) )
         {
         }
         pr_default.close(31);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Cie10codigo( String GX_Parm1 ,
                                     String GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A50Cie10Codigo = GX_Parm2 ;
         n50Cie10Codigo = false ;
         /* Using cursor T000J34 */
         pr_default.execute(32, new Object[] {A41ClinicaCodigo, n50Cie10Codigo, A50Cie10Codigo});
         if ( (pr_default.getStatus(32) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A41ClinicaCodigo)) || String.IsNullOrEmpty(StringUtil.RTrim( A50Cie10Codigo)) ) )
            {
               AnyError41 = 1 ;
               AnyError50 = 1 ;
               GX_msglist.addItem("No existe 'Clasificación CIE-10'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
            }
         }
         if ( ( AnyError41 == 0 ) && ( AnyError50 == 0 ) )
         {
         }
         pr_default.close(32);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Medicocodigo( String GX_Parm1 ,
                                      String GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A19MedicoCodigo = GX_Parm2 ;
         n19MedicoCodigo = false ;
         /* Using cursor T000J35 */
         pr_default.execute(33, new Object[] {A41ClinicaCodigo, n19MedicoCodigo, A19MedicoCodigo});
         if ( (pr_default.getStatus(33) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A41ClinicaCodigo)) || String.IsNullOrEmpty(StringUtil.RTrim( A19MedicoCodigo)) ) )
            {
               AnyError41 = 1 ;
               AnyError19 = 1 ;
               GX_msglist.addItem("No existe 'Médicos'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
            }
         }
         if ( ( AnyError41 == 0 ) && ( AnyError19 == 0 ) )
         {
         }
         pr_default.close(33);
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
         pr_default.close(29);
         pr_default.close(23);
         pr_default.close(15);
         pr_default.close(14);
         pr_default.close(33);
         pr_default.close(32);
         pr_default.close(30);
         pr_default.close(31);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
         A19MedicoCodigo = "" ;
         A50Cie10Codigo = "" ;
         A82AsegCodigo = "" ;
         GXKey = "" ;
         GXCCtl = "" ;
         A98SignoEstaturaEn = "" ;
         A100SignoPesoEn = "" ;
         A102SignoTemperaturaDe = "" ;
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
         lblTextblockconsultaid_Jsonclick = "" ;
         lblTextblockconsultafecha_Jsonclick = "" ;
         A92ConsultaFecha = DateTime.MinValue ;
         lblTextblockconsultahora_Jsonclick = "" ;
         A93ConsultaHora = "" ;
         lblTextblockpacienteid_Jsonclick = "" ;
         lblTextblockconsultaedad_Jsonclick = "" ;
         lblTextblockconsultatipo_Jsonclick = "" ;
         lblTextblockasegcodigo_Jsonclick = "" ;
         lblTextblockconsultapoliza_Jsonclick = "" ;
         A158ConsultaPoliza = "" ;
         lblTextblockconsultaobs_Jsonclick = "" ;
         A95ConsultaObs = "" ;
         lblTextblockcie10codigo_Jsonclick = "" ;
         lblTextblockconsultaestado_Jsonclick = "" ;
         lblTextblockconsultafechafin_Jsonclick = "" ;
         A160ConsultaFechaFin = DateTime.MinValue ;
         lblTextblockconsultahorafin_Jsonclick = "" ;
         A161ConsultaHoraFin = "" ;
         lblTextblockmedicocodigo_Jsonclick = "" ;
         Gridconsulta_signoContainer = new GXWebGrid( context);
         Gridconsulta_signoColumn = new GXWebColumn();
         A103SignoPresionArterial = "" ;
         A106SignoFecha = DateTime.MinValue ;
         A107SignoHora = "" ;
         A108SignoObs = "" ;
         Gx_mode = "" ;
         sMode26 = "" ;
         edtSignoLinea_Internalname = "" ;
         lblTitlesigno_Jsonclick = "" ;
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
         Z92ConsultaFecha = DateTime.MinValue ;
         Z93ConsultaHora = "" ;
         Z158ConsultaPoliza = "" ;
         Z95ConsultaObs = "" ;
         Z160ConsultaFechaFin = DateTime.MinValue ;
         Z161ConsultaHoraFin = "" ;
         Z19MedicoCodigo = "" ;
         Z50Cie10Codigo = "" ;
         Z82AsegCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtSignoEstatura_Internalname = "" ;
         cmbSignoEstaturaEn_Internalname = "" ;
         edtSignoPeso_Internalname = "" ;
         cmbSignoPesoEn_Internalname = "" ;
         edtSignoTemperatura_Internalname = "" ;
         cmbSignoTemperaturaDe_Internalname = "" ;
         edtSignoPresionArterial_Internalname = "" ;
         edtSignoFrecCardiaca_Internalname = "" ;
         edtSignoFrecRespiratoria_Internalname = "" ;
         edtSignoFecha_Internalname = "" ;
         edtSignoHora_Internalname = "" ;
         edtSignoObs_Internalname = "" ;
         Z98SignoEstaturaEn = "" ;
         Z100SignoPesoEn = "" ;
         Z102SignoTemperaturaDe = "" ;
         Z103SignoPresionArterial = "" ;
         Z106SignoFecha = DateTime.MinValue ;
         Z107SignoHora = "" ;
         Z108SignoObs = "" ;
         T000J10_A91ConsultaId = new int[1] ;
         T000J10_A92ConsultaFecha = new DateTime[] {DateTime.MinValue} ;
         T000J10_A93ConsultaHora = new String[] {""} ;
         T000J10_A157ConsultaEdad = new short[1] ;
         T000J10_A94ConsultaTipo = new short[1] ;
         T000J10_A158ConsultaPoliza = new String[] {""} ;
         T000J10_A95ConsultaObs = new String[] {""} ;
         T000J10_A159ConsultaEstado = new short[1] ;
         T000J10_A160ConsultaFechaFin = new DateTime[] {DateTime.MinValue} ;
         T000J10_A161ConsultaHoraFin = new String[] {""} ;
         T000J10_A41ClinicaCodigo = new String[] {""} ;
         T000J10_A19MedicoCodigo = new String[] {""} ;
         T000J10_n19MedicoCodigo = new bool[] {false} ;
         T000J10_A50Cie10Codigo = new String[] {""} ;
         T000J10_n50Cie10Codigo = new bool[] {false} ;
         T000J10_A67PacienteId = new int[1] ;
         T000J10_A82AsegCodigo = new String[] {""} ;
         T000J10_n82AsegCodigo = new bool[] {false} ;
         T000J6_A41ClinicaCodigo = new String[] {""} ;
         T000J7_A41ClinicaCodigo = new String[] {""} ;
         T000J8_A41ClinicaCodigo = new String[] {""} ;
         T000J9_A41ClinicaCodigo = new String[] {""} ;
         T000J11_A41ClinicaCodigo = new String[] {""} ;
         T000J12_A41ClinicaCodigo = new String[] {""} ;
         T000J13_A41ClinicaCodigo = new String[] {""} ;
         T000J14_A41ClinicaCodigo = new String[] {""} ;
         T000J15_A41ClinicaCodigo = new String[] {""} ;
         T000J15_A91ConsultaId = new int[1] ;
         T000J5_A91ConsultaId = new int[1] ;
         T000J5_A92ConsultaFecha = new DateTime[] {DateTime.MinValue} ;
         T000J5_A93ConsultaHora = new String[] {""} ;
         T000J5_A157ConsultaEdad = new short[1] ;
         T000J5_A94ConsultaTipo = new short[1] ;
         T000J5_A158ConsultaPoliza = new String[] {""} ;
         T000J5_A95ConsultaObs = new String[] {""} ;
         T000J5_A159ConsultaEstado = new short[1] ;
         T000J5_A160ConsultaFechaFin = new DateTime[] {DateTime.MinValue} ;
         T000J5_A161ConsultaHoraFin = new String[] {""} ;
         T000J5_A41ClinicaCodigo = new String[] {""} ;
         T000J5_A19MedicoCodigo = new String[] {""} ;
         T000J5_n19MedicoCodigo = new bool[] {false} ;
         T000J5_A50Cie10Codigo = new String[] {""} ;
         T000J5_n50Cie10Codigo = new bool[] {false} ;
         T000J5_A67PacienteId = new int[1] ;
         T000J5_A82AsegCodigo = new String[] {""} ;
         T000J5_n82AsegCodigo = new bool[] {false} ;
         sMode25 = "" ;
         T000J16_A41ClinicaCodigo = new String[] {""} ;
         T000J16_A91ConsultaId = new int[1] ;
         T000J17_A41ClinicaCodigo = new String[] {""} ;
         T000J17_A91ConsultaId = new int[1] ;
         T000J18_A91ConsultaId = new int[1] ;
         T000J18_A92ConsultaFecha = new DateTime[] {DateTime.MinValue} ;
         T000J18_A93ConsultaHora = new String[] {""} ;
         T000J18_A157ConsultaEdad = new short[1] ;
         T000J18_A94ConsultaTipo = new short[1] ;
         T000J18_A158ConsultaPoliza = new String[] {""} ;
         T000J18_A95ConsultaObs = new String[] {""} ;
         T000J18_A159ConsultaEstado = new short[1] ;
         T000J18_A160ConsultaFechaFin = new DateTime[] {DateTime.MinValue} ;
         T000J18_A161ConsultaHoraFin = new String[] {""} ;
         T000J18_A41ClinicaCodigo = new String[] {""} ;
         T000J18_A19MedicoCodigo = new String[] {""} ;
         T000J18_n19MedicoCodigo = new bool[] {false} ;
         T000J18_A50Cie10Codigo = new String[] {""} ;
         T000J18_n50Cie10Codigo = new bool[] {false} ;
         T000J18_A67PacienteId = new int[1] ;
         T000J18_A82AsegCodigo = new String[] {""} ;
         T000J18_n82AsegCodigo = new bool[] {false} ;
         T000J22_A41ClinicaCodigo = new String[] {""} ;
         T000J22_A185FacturaId = new int[1] ;
         T000J23_A41ClinicaCodigo = new String[] {""} ;
         T000J23_A91ConsultaId = new int[1] ;
         T000J23_A162CargoId = new int[1] ;
         T000J24_A41ClinicaCodigo = new String[] {""} ;
         T000J24_A91ConsultaId = new int[1] ;
         T000J24_A109RecetaId = new int[1] ;
         T000J25_A41ClinicaCodigo = new String[] {""} ;
         T000J25_A91ConsultaId = new int[1] ;
         T000J26_A91ConsultaId = new int[1] ;
         T000J26_A96SignoLinea = new short[1] ;
         T000J26_A97SignoEstatura = new decimal[1] ;
         T000J26_A98SignoEstaturaEn = new String[] {""} ;
         T000J26_A99SignoPeso = new decimal[1] ;
         T000J26_A100SignoPesoEn = new String[] {""} ;
         T000J26_A101SignoTemperatura = new decimal[1] ;
         T000J26_A102SignoTemperaturaDe = new String[] {""} ;
         T000J26_A103SignoPresionArterial = new String[] {""} ;
         T000J26_A104SignoFrecCardiaca = new decimal[1] ;
         T000J26_A105SignoFrecRespiratoria = new decimal[1] ;
         T000J26_A106SignoFecha = new DateTime[] {DateTime.MinValue} ;
         T000J26_A107SignoHora = new String[] {""} ;
         T000J26_A108SignoObs = new String[] {""} ;
         T000J26_A41ClinicaCodigo = new String[] {""} ;
         T000J27_A41ClinicaCodigo = new String[] {""} ;
         T000J27_A91ConsultaId = new int[1] ;
         T000J27_A96SignoLinea = new short[1] ;
         T000J3_A91ConsultaId = new int[1] ;
         T000J3_A96SignoLinea = new short[1] ;
         T000J3_A97SignoEstatura = new decimal[1] ;
         T000J3_A98SignoEstaturaEn = new String[] {""} ;
         T000J3_A99SignoPeso = new decimal[1] ;
         T000J3_A100SignoPesoEn = new String[] {""} ;
         T000J3_A101SignoTemperatura = new decimal[1] ;
         T000J3_A102SignoTemperaturaDe = new String[] {""} ;
         T000J3_A103SignoPresionArterial = new String[] {""} ;
         T000J3_A104SignoFrecCardiaca = new decimal[1] ;
         T000J3_A105SignoFrecRespiratoria = new decimal[1] ;
         T000J3_A106SignoFecha = new DateTime[] {DateTime.MinValue} ;
         T000J3_A107SignoHora = new String[] {""} ;
         T000J3_A108SignoObs = new String[] {""} ;
         T000J3_A41ClinicaCodigo = new String[] {""} ;
         T000J2_A91ConsultaId = new int[1] ;
         T000J2_A96SignoLinea = new short[1] ;
         T000J2_A97SignoEstatura = new decimal[1] ;
         T000J2_A98SignoEstaturaEn = new String[] {""} ;
         T000J2_A99SignoPeso = new decimal[1] ;
         T000J2_A100SignoPesoEn = new String[] {""} ;
         T000J2_A101SignoTemperatura = new decimal[1] ;
         T000J2_A102SignoTemperaturaDe = new String[] {""} ;
         T000J2_A103SignoPresionArterial = new String[] {""} ;
         T000J2_A104SignoFrecCardiaca = new decimal[1] ;
         T000J2_A105SignoFrecRespiratoria = new decimal[1] ;
         T000J2_A106SignoFecha = new DateTime[] {DateTime.MinValue} ;
         T000J2_A107SignoHora = new String[] {""} ;
         T000J2_A108SignoObs = new String[] {""} ;
         T000J2_A41ClinicaCodigo = new String[] {""} ;
         T000J31_A41ClinicaCodigo = new String[] {""} ;
         T000J31_A91ConsultaId = new int[1] ;
         T000J31_A96SignoLinea = new short[1] ;
         Gridconsulta_signoRow = new GXWebRow();
         subGridconsulta_signo_Linesclass = "" ;
         ROClassString = "" ;
         GXt_char16 = "" ;
         GXt_char15 = "" ;
         GXt_char14 = "" ;
         GXt_char13 = "" ;
         GXt_char12 = "" ;
         GXt_char11 = "" ;
         GXt_char10 = "" ;
         GXt_char9 = "" ;
         GXt_char8 = "" ;
         GXt_char7 = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char17 = "" ;
         GXt_char18 = "" ;
         GXt_char19 = "" ;
         GXt_char20 = "" ;
         GXt_char21 = "" ;
         GXt_char22 = "" ;
         GXt_char23 = "" ;
         GXt_char24 = "" ;
         GXt_char25 = "" ;
         GXt_char26 = "" ;
         GXt_char27 = "" ;
         GXt_char28 = "" ;
         GXt_char29 = "" ;
         GXt_char30 = "" ;
         GXt_char31 = "" ;
         GXt_char32 = "" ;
         GXt_char33 = "" ;
         GXt_char34 = "" ;
         GXt_char35 = "" ;
         GXt_char36 = "" ;
         GXt_char37 = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char39 = "" ;
         GXt_char38 = "" ;
         GXt_char40 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         T000J32_A41ClinicaCodigo = new String[] {""} ;
         T000J33_A41ClinicaCodigo = new String[] {""} ;
         T000J34_A41ClinicaCodigo = new String[] {""} ;
         T000J35_A41ClinicaCodigo = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.consulta__default(),
            new Object[][] {
                new Object[] {
               T000J2_A91ConsultaId, T000J2_A96SignoLinea, T000J2_A97SignoEstatura, T000J2_A98SignoEstaturaEn, T000J2_A99SignoPeso, T000J2_A100SignoPesoEn, T000J2_A101SignoTemperatura, T000J2_A102SignoTemperaturaDe, T000J2_A103SignoPresionArterial, T000J2_A104SignoFrecCardiaca,
               T000J2_A105SignoFrecRespiratoria, T000J2_A106SignoFecha, T000J2_A107SignoHora, T000J2_A108SignoObs, T000J2_A41ClinicaCodigo
               }
               , new Object[] {
               T000J3_A91ConsultaId, T000J3_A96SignoLinea, T000J3_A97SignoEstatura, T000J3_A98SignoEstaturaEn, T000J3_A99SignoPeso, T000J3_A100SignoPesoEn, T000J3_A101SignoTemperatura, T000J3_A102SignoTemperaturaDe, T000J3_A103SignoPresionArterial, T000J3_A104SignoFrecCardiaca,
               T000J3_A105SignoFrecRespiratoria, T000J3_A106SignoFecha, T000J3_A107SignoHora, T000J3_A108SignoObs, T000J3_A41ClinicaCodigo
               }
               , new Object[] {
               T000J4_A91ConsultaId, T000J4_A92ConsultaFecha, T000J4_A93ConsultaHora, T000J4_A157ConsultaEdad, T000J4_A94ConsultaTipo, T000J4_A158ConsultaPoliza, T000J4_A95ConsultaObs, T000J4_A159ConsultaEstado, T000J4_A160ConsultaFechaFin, T000J4_A161ConsultaHoraFin,
               T000J4_A41ClinicaCodigo, T000J4_A19MedicoCodigo, T000J4_n19MedicoCodigo, T000J4_A50Cie10Codigo, T000J4_n50Cie10Codigo, T000J4_A67PacienteId, T000J4_A82AsegCodigo, T000J4_n82AsegCodigo
               }
               , new Object[] {
               T000J5_A91ConsultaId, T000J5_A92ConsultaFecha, T000J5_A93ConsultaHora, T000J5_A157ConsultaEdad, T000J5_A94ConsultaTipo, T000J5_A158ConsultaPoliza, T000J5_A95ConsultaObs, T000J5_A159ConsultaEstado, T000J5_A160ConsultaFechaFin, T000J5_A161ConsultaHoraFin,
               T000J5_A41ClinicaCodigo, T000J5_A19MedicoCodigo, T000J5_n19MedicoCodigo, T000J5_A50Cie10Codigo, T000J5_n50Cie10Codigo, T000J5_A67PacienteId, T000J5_A82AsegCodigo, T000J5_n82AsegCodigo
               }
               , new Object[] {
               T000J6_A41ClinicaCodigo
               }
               , new Object[] {
               T000J7_A41ClinicaCodigo
               }
               , new Object[] {
               T000J8_A41ClinicaCodigo
               }
               , new Object[] {
               T000J9_A41ClinicaCodigo
               }
               , new Object[] {
               T000J10_A91ConsultaId, T000J10_A92ConsultaFecha, T000J10_A93ConsultaHora, T000J10_A157ConsultaEdad, T000J10_A94ConsultaTipo, T000J10_A158ConsultaPoliza, T000J10_A95ConsultaObs, T000J10_A159ConsultaEstado, T000J10_A160ConsultaFechaFin, T000J10_A161ConsultaHoraFin,
               T000J10_A41ClinicaCodigo, T000J10_A19MedicoCodigo, T000J10_n19MedicoCodigo, T000J10_A50Cie10Codigo, T000J10_n50Cie10Codigo, T000J10_A67PacienteId, T000J10_A82AsegCodigo, T000J10_n82AsegCodigo
               }
               , new Object[] {
               T000J11_A41ClinicaCodigo
               }
               , new Object[] {
               T000J12_A41ClinicaCodigo
               }
               , new Object[] {
               T000J13_A41ClinicaCodigo
               }
               , new Object[] {
               T000J14_A41ClinicaCodigo
               }
               , new Object[] {
               T000J15_A41ClinicaCodigo, T000J15_A91ConsultaId
               }
               , new Object[] {
               T000J16_A41ClinicaCodigo, T000J16_A91ConsultaId
               }
               , new Object[] {
               T000J17_A41ClinicaCodigo, T000J17_A91ConsultaId
               }
               , new Object[] {
               T000J18_A91ConsultaId, T000J18_A92ConsultaFecha, T000J18_A93ConsultaHora, T000J18_A157ConsultaEdad, T000J18_A94ConsultaTipo, T000J18_A158ConsultaPoliza, T000J18_A95ConsultaObs, T000J18_A159ConsultaEstado, T000J18_A160ConsultaFechaFin, T000J18_A161ConsultaHoraFin,
               T000J18_A41ClinicaCodigo, T000J18_A19MedicoCodigo, T000J18_n19MedicoCodigo, T000J18_A50Cie10Codigo, T000J18_n50Cie10Codigo, T000J18_A67PacienteId, T000J18_A82AsegCodigo, T000J18_n82AsegCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000J22_A41ClinicaCodigo, T000J22_A185FacturaId
               }
               , new Object[] {
               T000J23_A41ClinicaCodigo, T000J23_A91ConsultaId, T000J23_A162CargoId
               }
               , new Object[] {
               T000J24_A41ClinicaCodigo, T000J24_A91ConsultaId, T000J24_A109RecetaId
               }
               , new Object[] {
               T000J25_A41ClinicaCodigo, T000J25_A91ConsultaId
               }
               , new Object[] {
               T000J26_A91ConsultaId, T000J26_A96SignoLinea, T000J26_A97SignoEstatura, T000J26_A98SignoEstaturaEn, T000J26_A99SignoPeso, T000J26_A100SignoPesoEn, T000J26_A101SignoTemperatura, T000J26_A102SignoTemperaturaDe, T000J26_A103SignoPresionArterial, T000J26_A104SignoFrecCardiaca,
               T000J26_A105SignoFrecRespiratoria, T000J26_A106SignoFecha, T000J26_A107SignoHora, T000J26_A108SignoObs, T000J26_A41ClinicaCodigo
               }
               , new Object[] {
               T000J27_A41ClinicaCodigo, T000J27_A91ConsultaId, T000J27_A96SignoLinea
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000J31_A41ClinicaCodigo, T000J31_A91ConsultaId, T000J31_A96SignoLinea
               }
               , new Object[] {
               T000J32_A41ClinicaCodigo
               }
               , new Object[] {
               T000J33_A41ClinicaCodigo
               }
               , new Object[] {
               T000J34_A41ClinicaCodigo
               }
               , new Object[] {
               T000J35_A41ClinicaCodigo
               }
            }
         );
      }

      private short GxWebError ;
      private short nRC_Gridconsulta_signo ;
      private short nGXsfl_115_idx=1 ;
      private short gxcookieaux ;
      private short A94ConsultaTipo ;
      private short A159ConsultaEstado ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A157ConsultaEdad ;
      private short subGridconsulta_signo_Backcolorstyle ;
      private short A96SignoLinea ;
      private short subGridconsulta_signo_Allowcollapsing ;
      private short subGridconsulta_signo_Collapsed ;
      private short nBlankRcdCount26 ;
      private short nRcdExists_26 ;
      private short RcdFound26 ;
      private short nIsMod_26 ;
      private short nBlankRcdUsr26 ;
      private short Z157ConsultaEdad ;
      private short Z94ConsultaTipo ;
      private short Z159ConsultaEstado ;
      private short nRcdDeleted_26 ;
      private short Z96SignoLinea ;
      private short GX_JID ;
      private short RcdFound25 ;
      private short Gx_BScreen ;
      private short subGridconsulta_signo_Backstyle ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int A67PacienteId ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int A91ConsultaId ;
      private int edtConsultaId_Enabled ;
      private int edtConsultaFecha_Enabled ;
      private int edtConsultaHora_Enabled ;
      private int edtPacienteId_Enabled ;
      private int imgprompt_41_67_Visible ;
      private int edtConsultaEdad_Enabled ;
      private int edtAsegCodigo_Enabled ;
      private int imgprompt_41_82_Visible ;
      private int edtConsultaPoliza_Enabled ;
      private int edtConsultaObs_Enabled ;
      private int edtCie10Codigo_Enabled ;
      private int imgprompt_41_50_Visible ;
      private int edtConsultaFechaFin_Enabled ;
      private int edtConsultaHoraFin_Enabled ;
      private int edtMedicoCodigo_Enabled ;
      private int imgprompt_41_19_Visible ;
      private int edtSignoLinea_Enabled ;
      private int edtSignoEstatura_Enabled ;
      private int edtSignoPeso_Enabled ;
      private int edtSignoTemperatura_Enabled ;
      private int edtSignoPresionArterial_Enabled ;
      private int edtSignoFrecCardiaca_Enabled ;
      private int edtSignoFrecRespiratoria_Enabled ;
      private int edtSignoFecha_Enabled ;
      private int edtSignoHora_Enabled ;
      private int edtSignoObs_Enabled ;
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
      private int Z91ConsultaId ;
      private int Z67PacienteId ;
      private int GRIDCONSULTA_SIGNO_nFirstRecordOnPage ;
      private int AnyError41 ;
      private int AnyError19 ;
      private int AnyError50 ;
      private int AnyError67 ;
      private int AnyError82 ;
      private int subGridconsulta_signo_Backcolor ;
      private int subGridconsulta_signo_Allbackcolor ;
      private int defedtSignoLinea_Enabled ;
      private int idxLst ;
      private decimal A97SignoEstatura ;
      private decimal A99SignoPeso ;
      private decimal A101SignoTemperatura ;
      private decimal A104SignoFrecCardiaca ;
      private decimal A105SignoFrecRespiratoria ;
      private decimal Z97SignoEstatura ;
      private decimal Z99SignoPeso ;
      private decimal Z101SignoTemperatura ;
      private decimal Z104SignoFrecCardiaca ;
      private decimal Z105SignoFrecRespiratoria ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_115_idx="0001" ;
      private String GXKey ;
      private String GXCCtl ;
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
      private String lblTextblockconsultaid_Internalname ;
      private String lblTextblockconsultaid_Jsonclick ;
      private String edtConsultaId_Internalname ;
      private String edtConsultaId_Jsonclick ;
      private String lblTextblockconsultafecha_Internalname ;
      private String lblTextblockconsultafecha_Jsonclick ;
      private String edtConsultaFecha_Internalname ;
      private String edtConsultaFecha_Jsonclick ;
      private String lblTextblockconsultahora_Internalname ;
      private String lblTextblockconsultahora_Jsonclick ;
      private String A93ConsultaHora ;
      private String edtConsultaHora_Internalname ;
      private String edtConsultaHora_Jsonclick ;
      private String lblTextblockpacienteid_Internalname ;
      private String lblTextblockpacienteid_Jsonclick ;
      private String edtPacienteId_Internalname ;
      private String edtPacienteId_Jsonclick ;
      private String imgprompt_41_67_Internalname ;
      private String imgprompt_41_67_Link ;
      private String lblTextblockconsultaedad_Internalname ;
      private String lblTextblockconsultaedad_Jsonclick ;
      private String edtConsultaEdad_Internalname ;
      private String edtConsultaEdad_Jsonclick ;
      private String lblTextblockconsultatipo_Internalname ;
      private String lblTextblockconsultatipo_Jsonclick ;
      private String cmbConsultaTipo_Internalname ;
      private String cmbConsultaTipo_Jsonclick ;
      private String lblTextblockasegcodigo_Internalname ;
      private String lblTextblockasegcodigo_Jsonclick ;
      private String edtAsegCodigo_Internalname ;
      private String edtAsegCodigo_Jsonclick ;
      private String imgprompt_41_82_Internalname ;
      private String imgprompt_41_82_Link ;
      private String lblTextblockconsultapoliza_Internalname ;
      private String lblTextblockconsultapoliza_Jsonclick ;
      private String edtConsultaPoliza_Internalname ;
      private String edtConsultaPoliza_Jsonclick ;
      private String lblTextblockconsultaobs_Internalname ;
      private String lblTextblockconsultaobs_Jsonclick ;
      private String edtConsultaObs_Internalname ;
      private String lblTextblockcie10codigo_Internalname ;
      private String lblTextblockcie10codigo_Jsonclick ;
      private String edtCie10Codigo_Internalname ;
      private String edtCie10Codigo_Jsonclick ;
      private String imgprompt_41_50_Internalname ;
      private String imgprompt_41_50_Link ;
      private String lblTextblockconsultaestado_Internalname ;
      private String lblTextblockconsultaestado_Jsonclick ;
      private String cmbConsultaEstado_Internalname ;
      private String cmbConsultaEstado_Jsonclick ;
      private String lblTextblockconsultafechafin_Internalname ;
      private String lblTextblockconsultafechafin_Jsonclick ;
      private String edtConsultaFechaFin_Internalname ;
      private String edtConsultaFechaFin_Jsonclick ;
      private String lblTextblockconsultahorafin_Internalname ;
      private String lblTextblockconsultahorafin_Jsonclick ;
      private String A161ConsultaHoraFin ;
      private String edtConsultaHoraFin_Internalname ;
      private String edtConsultaHoraFin_Jsonclick ;
      private String lblTextblockmedicocodigo_Internalname ;
      private String lblTextblockmedicocodigo_Jsonclick ;
      private String edtMedicoCodigo_Internalname ;
      private String edtMedicoCodigo_Jsonclick ;
      private String imgprompt_41_19_Internalname ;
      private String imgprompt_41_19_Link ;
      private String A107SignoHora ;
      private String Gx_mode ;
      private String sMode26 ;
      private String edtSignoLinea_Internalname ;
      private String tblTable3_Internalname ;
      private String lblTitlesigno_Internalname ;
      private String lblTitlesigno_Jsonclick ;
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
      private String Z93ConsultaHora ;
      private String Z161ConsultaHoraFin ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtSignoEstatura_Internalname ;
      private String cmbSignoEstaturaEn_Internalname ;
      private String edtSignoPeso_Internalname ;
      private String cmbSignoPesoEn_Internalname ;
      private String edtSignoTemperatura_Internalname ;
      private String cmbSignoTemperaturaDe_Internalname ;
      private String edtSignoPresionArterial_Internalname ;
      private String edtSignoFrecCardiaca_Internalname ;
      private String edtSignoFrecRespiratoria_Internalname ;
      private String edtSignoFecha_Internalname ;
      private String edtSignoHora_Internalname ;
      private String edtSignoObs_Internalname ;
      private String Z107SignoHora ;
      private String sMode25 ;
      private String subGridconsulta_signo_Class ;
      private String subGridconsulta_signo_Linesclass ;
      private String ROClassString ;
      private String edtSignoLinea_Jsonclick ;
      private String edtSignoEstatura_Jsonclick ;
      private String cmbSignoEstaturaEn_Jsonclick ;
      private String edtSignoPeso_Jsonclick ;
      private String cmbSignoPesoEn_Jsonclick ;
      private String edtSignoTemperatura_Jsonclick ;
      private String cmbSignoTemperaturaDe_Jsonclick ;
      private String edtSignoPresionArterial_Jsonclick ;
      private String edtSignoFrecCardiaca_Jsonclick ;
      private String edtSignoFrecRespiratoria_Jsonclick ;
      private String edtSignoFecha_Jsonclick ;
      private String edtSignoHora_Jsonclick ;
      private String edtSignoObs_Jsonclick ;
      private String GXt_char16 ;
      private String GXt_char15 ;
      private String GXt_char14 ;
      private String GXt_char13 ;
      private String GXt_char12 ;
      private String GXt_char11 ;
      private String GXt_char10 ;
      private String GXt_char9 ;
      private String GXt_char8 ;
      private String GXt_char7 ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char17 ;
      private String GXt_char18 ;
      private String GXt_char19 ;
      private String GXt_char20 ;
      private String GXt_char21 ;
      private String GXt_char22 ;
      private String GXt_char23 ;
      private String GXt_char24 ;
      private String GXt_char25 ;
      private String GXt_char26 ;
      private String GXt_char27 ;
      private String GXt_char28 ;
      private String GXt_char29 ;
      private String GXt_char30 ;
      private String GXt_char31 ;
      private String GXt_char32 ;
      private String GXt_char33 ;
      private String GXt_char34 ;
      private String GXt_char35 ;
      private String GXt_char36 ;
      private String GXt_char37 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char39 ;
      private String GXt_char38 ;
      private String subGridconsulta_signo_Internalname ;
      private String GXt_char40 ;
      private DateTime A92ConsultaFecha ;
      private DateTime A160ConsultaFechaFin ;
      private DateTime A106SignoFecha ;
      private DateTime Z92ConsultaFecha ;
      private DateTime Z160ConsultaFechaFin ;
      private DateTime Z106SignoFecha ;
      private bool entryPointCalled ;
      private bool n19MedicoCodigo ;
      private bool n50Cie10Codigo ;
      private bool n82AsegCodigo ;
      private bool wbErr ;
      private bool Gx_longc ;
      private String A41ClinicaCodigo ;
      private String A19MedicoCodigo ;
      private String A50Cie10Codigo ;
      private String A82AsegCodigo ;
      private String A98SignoEstaturaEn ;
      private String A100SignoPesoEn ;
      private String A102SignoTemperaturaDe ;
      private String A158ConsultaPoliza ;
      private String A95ConsultaObs ;
      private String A103SignoPresionArterial ;
      private String A108SignoObs ;
      private String Z41ClinicaCodigo ;
      private String Z158ConsultaPoliza ;
      private String Z95ConsultaObs ;
      private String Z19MedicoCodigo ;
      private String Z50Cie10Codigo ;
      private String Z82AsegCodigo ;
      private String Z98SignoEstaturaEn ;
      private String Z100SignoPesoEn ;
      private String Z102SignoTemperaturaDe ;
      private String Z103SignoPresionArterial ;
      private String Z108SignoObs ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Gridconsulta_signoContainer ;
      private GXWebRow Gridconsulta_signoRow ;
      private GXWebColumn Gridconsulta_signoColumn ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbConsultaTipo ;
      private GXCombobox cmbConsultaEstado ;
      private GXCombobox cmbSignoEstaturaEn ;
      private GXCombobox cmbSignoPesoEn ;
      private GXCombobox cmbSignoTemperaturaDe ;
      private IDataStoreProvider pr_default ;
      private int[] T000J10_A91ConsultaId ;
      private DateTime[] T000J10_A92ConsultaFecha ;
      private String[] T000J10_A93ConsultaHora ;
      private short[] T000J10_A157ConsultaEdad ;
      private short[] T000J10_A94ConsultaTipo ;
      private String[] T000J10_A158ConsultaPoliza ;
      private String[] T000J10_A95ConsultaObs ;
      private short[] T000J10_A159ConsultaEstado ;
      private DateTime[] T000J10_A160ConsultaFechaFin ;
      private String[] T000J10_A161ConsultaHoraFin ;
      private String[] T000J10_A41ClinicaCodigo ;
      private String[] T000J10_A19MedicoCodigo ;
      private bool[] T000J10_n19MedicoCodigo ;
      private String[] T000J10_A50Cie10Codigo ;
      private bool[] T000J10_n50Cie10Codigo ;
      private int[] T000J10_A67PacienteId ;
      private String[] T000J10_A82AsegCodigo ;
      private bool[] T000J10_n82AsegCodigo ;
      private String[] T000J6_A41ClinicaCodigo ;
      private String[] T000J7_A41ClinicaCodigo ;
      private String[] T000J8_A41ClinicaCodigo ;
      private String[] T000J9_A41ClinicaCodigo ;
      private String[] T000J11_A41ClinicaCodigo ;
      private String[] T000J12_A41ClinicaCodigo ;
      private String[] T000J13_A41ClinicaCodigo ;
      private String[] T000J14_A41ClinicaCodigo ;
      private String[] T000J15_A41ClinicaCodigo ;
      private int[] T000J15_A91ConsultaId ;
      private int[] T000J5_A91ConsultaId ;
      private DateTime[] T000J5_A92ConsultaFecha ;
      private String[] T000J5_A93ConsultaHora ;
      private short[] T000J5_A157ConsultaEdad ;
      private short[] T000J5_A94ConsultaTipo ;
      private String[] T000J5_A158ConsultaPoliza ;
      private String[] T000J5_A95ConsultaObs ;
      private short[] T000J5_A159ConsultaEstado ;
      private DateTime[] T000J5_A160ConsultaFechaFin ;
      private String[] T000J5_A161ConsultaHoraFin ;
      private String[] T000J5_A41ClinicaCodigo ;
      private String[] T000J5_A19MedicoCodigo ;
      private bool[] T000J5_n19MedicoCodigo ;
      private String[] T000J5_A50Cie10Codigo ;
      private bool[] T000J5_n50Cie10Codigo ;
      private int[] T000J5_A67PacienteId ;
      private String[] T000J5_A82AsegCodigo ;
      private bool[] T000J5_n82AsegCodigo ;
      private String[] T000J16_A41ClinicaCodigo ;
      private int[] T000J16_A91ConsultaId ;
      private String[] T000J17_A41ClinicaCodigo ;
      private int[] T000J17_A91ConsultaId ;
      private int[] T000J18_A91ConsultaId ;
      private DateTime[] T000J18_A92ConsultaFecha ;
      private String[] T000J18_A93ConsultaHora ;
      private short[] T000J18_A157ConsultaEdad ;
      private short[] T000J18_A94ConsultaTipo ;
      private String[] T000J18_A158ConsultaPoliza ;
      private String[] T000J18_A95ConsultaObs ;
      private short[] T000J18_A159ConsultaEstado ;
      private DateTime[] T000J18_A160ConsultaFechaFin ;
      private String[] T000J18_A161ConsultaHoraFin ;
      private String[] T000J18_A41ClinicaCodigo ;
      private String[] T000J18_A19MedicoCodigo ;
      private bool[] T000J18_n19MedicoCodigo ;
      private String[] T000J18_A50Cie10Codigo ;
      private bool[] T000J18_n50Cie10Codigo ;
      private int[] T000J18_A67PacienteId ;
      private String[] T000J18_A82AsegCodigo ;
      private bool[] T000J18_n82AsegCodigo ;
      private String[] T000J22_A41ClinicaCodigo ;
      private int[] T000J22_A185FacturaId ;
      private String[] T000J23_A41ClinicaCodigo ;
      private int[] T000J23_A91ConsultaId ;
      private int[] T000J23_A162CargoId ;
      private String[] T000J24_A41ClinicaCodigo ;
      private int[] T000J24_A91ConsultaId ;
      private int[] T000J24_A109RecetaId ;
      private String[] T000J25_A41ClinicaCodigo ;
      private int[] T000J25_A91ConsultaId ;
      private int[] T000J26_A91ConsultaId ;
      private short[] T000J26_A96SignoLinea ;
      private decimal[] T000J26_A97SignoEstatura ;
      private String[] T000J26_A98SignoEstaturaEn ;
      private decimal[] T000J26_A99SignoPeso ;
      private String[] T000J26_A100SignoPesoEn ;
      private decimal[] T000J26_A101SignoTemperatura ;
      private String[] T000J26_A102SignoTemperaturaDe ;
      private String[] T000J26_A103SignoPresionArterial ;
      private decimal[] T000J26_A104SignoFrecCardiaca ;
      private decimal[] T000J26_A105SignoFrecRespiratoria ;
      private DateTime[] T000J26_A106SignoFecha ;
      private String[] T000J26_A107SignoHora ;
      private String[] T000J26_A108SignoObs ;
      private String[] T000J26_A41ClinicaCodigo ;
      private String[] T000J27_A41ClinicaCodigo ;
      private int[] T000J27_A91ConsultaId ;
      private short[] T000J27_A96SignoLinea ;
      private int[] T000J3_A91ConsultaId ;
      private short[] T000J3_A96SignoLinea ;
      private decimal[] T000J3_A97SignoEstatura ;
      private String[] T000J3_A98SignoEstaturaEn ;
      private decimal[] T000J3_A99SignoPeso ;
      private String[] T000J3_A100SignoPesoEn ;
      private decimal[] T000J3_A101SignoTemperatura ;
      private String[] T000J3_A102SignoTemperaturaDe ;
      private String[] T000J3_A103SignoPresionArterial ;
      private decimal[] T000J3_A104SignoFrecCardiaca ;
      private decimal[] T000J3_A105SignoFrecRespiratoria ;
      private DateTime[] T000J3_A106SignoFecha ;
      private String[] T000J3_A107SignoHora ;
      private String[] T000J3_A108SignoObs ;
      private String[] T000J3_A41ClinicaCodigo ;
      private int[] T000J2_A91ConsultaId ;
      private short[] T000J2_A96SignoLinea ;
      private decimal[] T000J2_A97SignoEstatura ;
      private String[] T000J2_A98SignoEstaturaEn ;
      private decimal[] T000J2_A99SignoPeso ;
      private String[] T000J2_A100SignoPesoEn ;
      private decimal[] T000J2_A101SignoTemperatura ;
      private String[] T000J2_A102SignoTemperaturaDe ;
      private String[] T000J2_A103SignoPresionArterial ;
      private decimal[] T000J2_A104SignoFrecCardiaca ;
      private decimal[] T000J2_A105SignoFrecRespiratoria ;
      private DateTime[] T000J2_A106SignoFecha ;
      private String[] T000J2_A107SignoHora ;
      private String[] T000J2_A108SignoObs ;
      private String[] T000J2_A41ClinicaCodigo ;
      private String[] T000J31_A41ClinicaCodigo ;
      private int[] T000J31_A91ConsultaId ;
      private short[] T000J31_A96SignoLinea ;
      private String[] T000J32_A41ClinicaCodigo ;
      private String[] T000J33_A41ClinicaCodigo ;
      private String[] T000J34_A41ClinicaCodigo ;
      private String[] T000J35_A41ClinicaCodigo ;
      private int[] T000J4_A91ConsultaId ;
      private DateTime[] T000J4_A92ConsultaFecha ;
      private String[] T000J4_A93ConsultaHora ;
      private short[] T000J4_A157ConsultaEdad ;
      private short[] T000J4_A94ConsultaTipo ;
      private String[] T000J4_A158ConsultaPoliza ;
      private String[] T000J4_A95ConsultaObs ;
      private short[] T000J4_A159ConsultaEstado ;
      private DateTime[] T000J4_A160ConsultaFechaFin ;
      private String[] T000J4_A161ConsultaHoraFin ;
      private String[] T000J4_A41ClinicaCodigo ;
      private String[] T000J4_A19MedicoCodigo ;
      private String[] T000J4_A50Cie10Codigo ;
      private int[] T000J4_A67PacienteId ;
      private String[] T000J4_A82AsegCodigo ;
      private bool[] T000J4_n19MedicoCodigo ;
      private bool[] T000J4_n50Cie10Codigo ;
      private bool[] T000J4_n82AsegCodigo ;
      private GXWebForm Form ;
   }

   public class consulta__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new ForEachCursor(def[24])
         ,new ForEachCursor(def[25])
         ,new UpdateCursor(def[26])
         ,new UpdateCursor(def[27])
         ,new UpdateCursor(def[28])
         ,new ForEachCursor(def[29])
         ,new ForEachCursor(def[30])
         ,new ForEachCursor(def[31])
         ,new ForEachCursor(def[32])
         ,new ForEachCursor(def[33])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000J4 ;
          prmT000J4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000J10 ;
          prmT000J10 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000J6 ;
          prmT000J6 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000J7 ;
          prmT000J7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@Cie10Codigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000J8 ;
          prmT000J8 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000J9 ;
          prmT000J9 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AsegCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000J11 ;
          prmT000J11 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000J12 ;
          prmT000J12 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@Cie10Codigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000J13 ;
          prmT000J13 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000J14 ;
          prmT000J14 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AsegCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000J15 ;
          prmT000J15 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000J5 ;
          prmT000J5 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000J16 ;
          prmT000J16 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000J17 ;
          prmT000J17 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000J18 ;
          prmT000J18 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000J19 ;
          prmT000J19 = new Object[] {
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@ConsultaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ConsultaHora",SqlDbType.Char,8,0} ,
          new Object[] {"@ConsultaEdad",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ConsultaTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ConsultaPoliza",SqlDbType.VarChar,70,0} ,
          new Object[] {"@ConsultaObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@ConsultaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ConsultaFechaFin",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ConsultaHoraFin",SqlDbType.Char,8,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@Cie10Codigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@AsegCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000J20 ;
          prmT000J20 = new Object[] {
          new Object[] {"@ConsultaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ConsultaHora",SqlDbType.Char,8,0} ,
          new Object[] {"@ConsultaEdad",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ConsultaTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ConsultaPoliza",SqlDbType.VarChar,70,0} ,
          new Object[] {"@ConsultaObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@ConsultaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ConsultaFechaFin",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ConsultaHoraFin",SqlDbType.Char,8,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@Cie10Codigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@AsegCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000J21 ;
          prmT000J21 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000J22 ;
          prmT000J22 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000J23 ;
          prmT000J23 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000J24 ;
          prmT000J24 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000J25 ;
          prmT000J25 = new Object[] {
          } ;
          Object[] prmT000J26 ;
          prmT000J26 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@SignoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000J27 ;
          prmT000J27 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@SignoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000J3 ;
          prmT000J3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@SignoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000J2 ;
          prmT000J2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@SignoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000J28 ;
          prmT000J28 = new Object[] {
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@SignoLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SignoEstatura",SqlDbType.Decimal,8,2} ,
          new Object[] {"@SignoEstaturaEn",SqlDbType.VarChar,2,0} ,
          new Object[] {"@SignoPeso",SqlDbType.Decimal,8,2} ,
          new Object[] {"@SignoPesoEn",SqlDbType.VarChar,2,0} ,
          new Object[] {"@SignoTemperatura",SqlDbType.Decimal,8,2} ,
          new Object[] {"@SignoTemperaturaDe",SqlDbType.VarChar,2,0} ,
          new Object[] {"@SignoPresionArterial",SqlDbType.VarChar,6,0} ,
          new Object[] {"@SignoFrecCardiaca",SqlDbType.Decimal,8,2} ,
          new Object[] {"@SignoFrecRespiratoria",SqlDbType.Decimal,8,2} ,
          new Object[] {"@SignoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@SignoHora",SqlDbType.Char,8,0} ,
          new Object[] {"@SignoObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000J29 ;
          prmT000J29 = new Object[] {
          new Object[] {"@SignoEstatura",SqlDbType.Decimal,8,2} ,
          new Object[] {"@SignoEstaturaEn",SqlDbType.VarChar,2,0} ,
          new Object[] {"@SignoPeso",SqlDbType.Decimal,8,2} ,
          new Object[] {"@SignoPesoEn",SqlDbType.VarChar,2,0} ,
          new Object[] {"@SignoTemperatura",SqlDbType.Decimal,8,2} ,
          new Object[] {"@SignoTemperaturaDe",SqlDbType.VarChar,2,0} ,
          new Object[] {"@SignoPresionArterial",SqlDbType.VarChar,6,0} ,
          new Object[] {"@SignoFrecCardiaca",SqlDbType.Decimal,8,2} ,
          new Object[] {"@SignoFrecRespiratoria",SqlDbType.Decimal,8,2} ,
          new Object[] {"@SignoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@SignoHora",SqlDbType.Char,8,0} ,
          new Object[] {"@SignoObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@SignoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000J30 ;
          prmT000J30 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@SignoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000J31 ;
          prmT000J31 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000J32 ;
          prmT000J32 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000J33 ;
          prmT000J33 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AsegCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000J34 ;
          prmT000J34 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@Cie10Codigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000J35 ;
          prmT000J35 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000J2", "SELECT [ConsultaId], [SignoLinea], [SignoEstatura], [SignoEstaturaEn], [SignoPeso], [SignoPesoEn], [SignoTemperatura], [SignoTemperaturaDe], [SignoPresionArterial], [SignoFrecCardiaca], [SignoFrecRespiratoria], [SignoFecha], [SignoHora], [SignoObs], [ClinicaCodigo] FROM [ConsultaSigno] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId AND [SignoLinea] = @SignoLinea ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J2,1,0,true,false )
             ,new CursorDef("T000J3", "SELECT [ConsultaId], [SignoLinea], [SignoEstatura], [SignoEstaturaEn], [SignoPeso], [SignoPesoEn], [SignoTemperatura], [SignoTemperaturaDe], [SignoPresionArterial], [SignoFrecCardiaca], [SignoFrecRespiratoria], [SignoFecha], [SignoHora], [SignoObs], [ClinicaCodigo] FROM [ConsultaSigno] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId AND [SignoLinea] = @SignoLinea ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J3,1,0,true,false )
             ,new CursorDef("T000J4", "SELECT [ConsultaId], [ConsultaFecha], [ConsultaHora], [ConsultaEdad], [ConsultaTipo], [ConsultaPoliza], [ConsultaObs], [ConsultaEstado], [ConsultaFechaFin], [ConsultaHoraFin], [ClinicaCodigo], [MedicoCodigo], [Cie10Codigo], [PacienteId], [AsegCodigo] FROM [Consulta] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J4,1,0,true,false )
             ,new CursorDef("T000J5", "SELECT [ConsultaId], [ConsultaFecha], [ConsultaHora], [ConsultaEdad], [ConsultaTipo], [ConsultaPoliza], [ConsultaObs], [ConsultaEstado], [ConsultaFechaFin], [ConsultaHoraFin], [ClinicaCodigo], [MedicoCodigo], [Cie10Codigo], [PacienteId], [AsegCodigo] FROM [Consulta] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J5,1,0,true,false )
             ,new CursorDef("T000J6", "SELECT [ClinicaCodigo] FROM [Medico] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [MedicoCodigo] = @MedicoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J6,1,0,true,false )
             ,new CursorDef("T000J7", "SELECT [ClinicaCodigo] FROM [Cie10] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [Cie10Codigo] = @Cie10Codigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J7,1,0,true,false )
             ,new CursorDef("T000J8", "SELECT [ClinicaCodigo] FROM [Paciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [PacienteId] = @PacienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J8,1,0,true,false )
             ,new CursorDef("T000J9", "SELECT [ClinicaCodigo] FROM [Aseguradora] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [AsegCodigo] = @AsegCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J9,1,0,true,false )
             ,new CursorDef("T000J10", "SELECT TM1.[ConsultaId], TM1.[ConsultaFecha], TM1.[ConsultaHora], TM1.[ConsultaEdad], TM1.[ConsultaTipo], TM1.[ConsultaPoliza], TM1.[ConsultaObs], TM1.[ConsultaEstado], TM1.[ConsultaFechaFin], TM1.[ConsultaHoraFin], TM1.[ClinicaCodigo], TM1.[MedicoCodigo], TM1.[Cie10Codigo], TM1.[PacienteId], TM1.[AsegCodigo] FROM [Consulta] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[ConsultaId] = @ConsultaId ORDER BY TM1.[ClinicaCodigo], TM1.[ConsultaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000J10,100,0,true,false )
             ,new CursorDef("T000J11", "SELECT [ClinicaCodigo] FROM [Medico] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [MedicoCodigo] = @MedicoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J11,1,0,true,false )
             ,new CursorDef("T000J12", "SELECT [ClinicaCodigo] FROM [Cie10] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [Cie10Codigo] = @Cie10Codigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J12,1,0,true,false )
             ,new CursorDef("T000J13", "SELECT [ClinicaCodigo] FROM [Paciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [PacienteId] = @PacienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J13,1,0,true,false )
             ,new CursorDef("T000J14", "SELECT [ClinicaCodigo] FROM [Aseguradora] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [AsegCodigo] = @AsegCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J14,1,0,true,false )
             ,new CursorDef("T000J15", "SELECT [ClinicaCodigo], [ConsultaId] FROM [Consulta] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000J15,1,0,true,false )
             ,new CursorDef("T000J16", "SELECT TOP 1 [ClinicaCodigo], [ConsultaId] FROM [Consulta] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [ConsultaId] > @ConsultaId) ORDER BY [ClinicaCodigo], [ConsultaId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000J16,1,0,true,true )
             ,new CursorDef("T000J17", "SELECT TOP 1 [ClinicaCodigo], [ConsultaId] FROM [Consulta] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [ConsultaId] < @ConsultaId) ORDER BY [ClinicaCodigo] DESC, [ConsultaId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000J17,1,0,true,true )
             ,new CursorDef("T000J18", "SELECT [ConsultaId], [ConsultaFecha], [ConsultaHora], [ConsultaEdad], [ConsultaTipo], [ConsultaPoliza], [ConsultaObs], [ConsultaEstado], [ConsultaFechaFin], [ConsultaHoraFin], [ClinicaCodigo], [MedicoCodigo], [Cie10Codigo], [PacienteId], [AsegCodigo] FROM [Consulta] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J18,1,0,true,false )
             ,new CursorDef("T000J19", "INSERT INTO [Consulta] ([ConsultaId], [ConsultaFecha], [ConsultaHora], [ConsultaEdad], [ConsultaTipo], [ConsultaPoliza], [ConsultaObs], [ConsultaEstado], [ConsultaFechaFin], [ConsultaHoraFin], [ClinicaCodigo], [MedicoCodigo], [Cie10Codigo], [PacienteId], [AsegCodigo]) VALUES (@ConsultaId, @ConsultaFecha, @ConsultaHora, @ConsultaEdad, @ConsultaTipo, @ConsultaPoliza, @ConsultaObs, @ConsultaEstado, @ConsultaFechaFin, @ConsultaHoraFin, @ClinicaCodigo, @MedicoCodigo, @Cie10Codigo, @PacienteId, @AsegCodigo)", GxErrorMask.GX_NOMASK,prmT000J19)
             ,new CursorDef("T000J20", "UPDATE [Consulta] SET [ConsultaFecha]=@ConsultaFecha, [ConsultaHora]=@ConsultaHora, [ConsultaEdad]=@ConsultaEdad, [ConsultaTipo]=@ConsultaTipo, [ConsultaPoliza]=@ConsultaPoliza, [ConsultaObs]=@ConsultaObs, [ConsultaEstado]=@ConsultaEstado, [ConsultaFechaFin]=@ConsultaFechaFin, [ConsultaHoraFin]=@ConsultaHoraFin, [MedicoCodigo]=@MedicoCodigo, [Cie10Codigo]=@Cie10Codigo, [PacienteId]=@PacienteId, [AsegCodigo]=@AsegCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId", GxErrorMask.GX_NOMASK,prmT000J20)
             ,new CursorDef("T000J21", "DELETE FROM [Consulta]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId", GxErrorMask.GX_NOMASK,prmT000J21)
             ,new CursorDef("T000J22", "SELECT TOP 1 [ClinicaCodigo], [FacturaId] FROM [Factura] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J22,1,0,true,true )
             ,new CursorDef("T000J23", "SELECT TOP 1 [ClinicaCodigo], [ConsultaId], [CargoId] FROM [Cargo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J23,1,0,true,true )
             ,new CursorDef("T000J24", "SELECT TOP 1 [ClinicaCodigo], [ConsultaId], [RecetaId] FROM [Receta] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J24,1,0,true,true )
             ,new CursorDef("T000J25", "SELECT [ClinicaCodigo], [ConsultaId] FROM [Consulta] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [ConsultaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000J25,100,0,true,false )
             ,new CursorDef("T000J26", "SELECT [ConsultaId], [SignoLinea], [SignoEstatura], [SignoEstaturaEn], [SignoPeso], [SignoPesoEn], [SignoTemperatura], [SignoTemperaturaDe], [SignoPresionArterial], [SignoFrecCardiaca], [SignoFrecRespiratoria], [SignoFecha], [SignoHora], [SignoObs], [ClinicaCodigo] FROM [ConsultaSigno] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [ConsultaId] = @ConsultaId and [SignoLinea] = @SignoLinea ORDER BY [ClinicaCodigo], [ConsultaId], [SignoLinea] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J26,11,0,true,false )
             ,new CursorDef("T000J27", "SELECT [ClinicaCodigo], [ConsultaId], [SignoLinea] FROM [ConsultaSigno] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId AND [SignoLinea] = @SignoLinea ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J27,1,0,true,false )
             ,new CursorDef("T000J28", "INSERT INTO [ConsultaSigno] ([ConsultaId], [SignoLinea], [SignoEstatura], [SignoEstaturaEn], [SignoPeso], [SignoPesoEn], [SignoTemperatura], [SignoTemperaturaDe], [SignoPresionArterial], [SignoFrecCardiaca], [SignoFrecRespiratoria], [SignoFecha], [SignoHora], [SignoObs], [ClinicaCodigo]) VALUES (@ConsultaId, @SignoLinea, @SignoEstatura, @SignoEstaturaEn, @SignoPeso, @SignoPesoEn, @SignoTemperatura, @SignoTemperaturaDe, @SignoPresionArterial, @SignoFrecCardiaca, @SignoFrecRespiratoria, @SignoFecha, @SignoHora, @SignoObs, @ClinicaCodigo)", GxErrorMask.GX_NOMASK,prmT000J28)
             ,new CursorDef("T000J29", "UPDATE [ConsultaSigno] SET [SignoEstatura]=@SignoEstatura, [SignoEstaturaEn]=@SignoEstaturaEn, [SignoPeso]=@SignoPeso, [SignoPesoEn]=@SignoPesoEn, [SignoTemperatura]=@SignoTemperatura, [SignoTemperaturaDe]=@SignoTemperaturaDe, [SignoPresionArterial]=@SignoPresionArterial, [SignoFrecCardiaca]=@SignoFrecCardiaca, [SignoFrecRespiratoria]=@SignoFrecRespiratoria, [SignoFecha]=@SignoFecha, [SignoHora]=@SignoHora, [SignoObs]=@SignoObs  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId AND [SignoLinea] = @SignoLinea", GxErrorMask.GX_NOMASK,prmT000J29)
             ,new CursorDef("T000J30", "DELETE FROM [ConsultaSigno]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId AND [SignoLinea] = @SignoLinea", GxErrorMask.GX_NOMASK,prmT000J30)
             ,new CursorDef("T000J31", "SELECT [ClinicaCodigo], [ConsultaId], [SignoLinea] FROM [ConsultaSigno] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [ConsultaId] = @ConsultaId ORDER BY [ClinicaCodigo], [ConsultaId], [SignoLinea] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J31,11,0,true,false )
             ,new CursorDef("T000J32", "SELECT [ClinicaCodigo] FROM [Paciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [PacienteId] = @PacienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J32,1,0,true,false )
             ,new CursorDef("T000J33", "SELECT [ClinicaCodigo] FROM [Aseguradora] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [AsegCodigo] = @AsegCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J33,1,0,true,false )
             ,new CursorDef("T000J34", "SELECT [ClinicaCodigo] FROM [Cie10] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [Cie10Codigo] = @Cie10Codigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J34,1,0,true,false )
             ,new CursorDef("T000J35", "SELECT [ClinicaCodigo] FROM [Medico] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [MedicoCodigo] = @MedicoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J35,1,0,true,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((decimal[]) buf[9])[0] = rslt.getDecimal(10) ;
                ((decimal[]) buf[10])[0] = rslt.getDecimal(11) ;
                ((DateTime[]) buf[11])[0] = rslt.getGXDate(12) ;
                ((String[]) buf[12])[0] = rslt.getString(13, 8) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                ((String[]) buf[14])[0] = rslt.getVarchar(15) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((decimal[]) buf[9])[0] = rslt.getDecimal(10) ;
                ((decimal[]) buf[10])[0] = rslt.getDecimal(11) ;
                ((DateTime[]) buf[11])[0] = rslt.getGXDate(12) ;
                ((String[]) buf[12])[0] = rslt.getString(13, 8) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                ((String[]) buf[14])[0] = rslt.getVarchar(15) ;
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(9) ;
                ((String[]) buf[9])[0] = rslt.getString(10, 8) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(12);
                ((String[]) buf[13])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(13);
                ((int[]) buf[15])[0] = rslt.getInt(14) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(15);
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(9) ;
                ((String[]) buf[9])[0] = rslt.getString(10, 8) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(12);
                ((String[]) buf[13])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(13);
                ((int[]) buf[15])[0] = rslt.getInt(14) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(15);
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(9) ;
                ((String[]) buf[9])[0] = rslt.getString(10, 8) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(12);
                ((String[]) buf[13])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(13);
                ((int[]) buf[15])[0] = rslt.getInt(14) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(15);
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(9) ;
                ((String[]) buf[9])[0] = rslt.getString(10, 8) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(12);
                ((String[]) buf[13])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(13);
                ((int[]) buf[15])[0] = rslt.getInt(14) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(15);
                break;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 23 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 24 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((decimal[]) buf[9])[0] = rslt.getDecimal(10) ;
                ((decimal[]) buf[10])[0] = rslt.getDecimal(11) ;
                ((DateTime[]) buf[11])[0] = rslt.getGXDate(12) ;
                ((String[]) buf[12])[0] = rslt.getString(13, 8) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                ((String[]) buf[14])[0] = rslt.getVarchar(15) ;
                break;
             case 25 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 29 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 30 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 31 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 32 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 33 :
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
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
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
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 7 :
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
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
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
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 12 :
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
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 15 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 17 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (short)parms[7]);
                stmt.SetParameter(9, (DateTime)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                stmt.SetParameter(11, (String)parms[10]);
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 12 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(12, (String)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 13 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(13, (String)parms[14]);
                }
                stmt.SetParameter(14, (int)parms[15]);
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 15 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(15, (String)parms[17]);
                }
                break;
             case 18 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                stmt.SetParameter(8, (DateTime)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 10 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 11 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(11, (String)parms[12]);
                }
                stmt.SetParameter(12, (int)parms[13]);
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 13 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(13, (String)parms[15]);
                }
                stmt.SetParameter(14, (String)parms[16]);
                stmt.SetParameter(15, (int)parms[17]);
                break;
             case 19 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 20 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 21 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 22 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 24 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 25 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 26 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (decimal)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (decimal)parms[9]);
                stmt.SetParameter(11, (decimal)parms[10]);
                stmt.SetParameter(12, (DateTime)parms[11]);
                stmt.SetParameter(13, (String)parms[12]);
                stmt.SetParameter(14, (String)parms[13]);
                stmt.SetParameter(15, (String)parms[14]);
                break;
             case 27 :
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (decimal)parms[7]);
                stmt.SetParameter(9, (decimal)parms[8]);
                stmt.SetParameter(10, (DateTime)parms[9]);
                stmt.SetParameter(11, (String)parms[10]);
                stmt.SetParameter(12, (String)parms[11]);
                stmt.SetParameter(13, (String)parms[12]);
                stmt.SetParameter(14, (int)parms[13]);
                stmt.SetParameter(15, (short)parms[14]);
                break;
             case 28 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 29 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 30 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 31 :
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
             case 32 :
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
             case 33 :
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
       }
    }

 }

}
