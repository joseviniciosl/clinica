/*
               File: NotaPaciente
        Description: Nota de ingreso del paciente
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:7:22.19
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
   public class notapaciente : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_4") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A144TipoPacCodigo = GetNextPar( ) ;
            n144TipoPacCodigo = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144TipoPacCodigo", A144TipoPacCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_4( A41ClinicaCodigo, A144TipoPacCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_5") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A313ProfesionId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313ProfesionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A313ProfesionId), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_5( A41ClinicaCodigo, A313ProfesionId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_6") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A315ReligionId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315ReligionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A315ReligionId), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_6( A41ClinicaCodigo, A315ReligionId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_7") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A317VendedorCodigo = GetNextPar( ) ;
            n317VendedorCodigo = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317VendedorCodigo", A317VendedorCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_7( A41ClinicaCodigo, A317VendedorCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_8") == 0 )
         {
            A4UsuarioCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_8( A4UsuarioCodigo) ;
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
         cmbNPacienteSexo.Name = "NPACIENTESEXO" ;
         cmbNPacienteSexo.WebTags = "" ;
         cmbNPacienteSexo.addItem("M", "Masculino", 0);
         cmbNPacienteSexo.addItem("F", "Femenino", 0);
         if ( ( cmbNPacienteSexo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A334NPacienteSexo)) )
         {
            A334NPacienteSexo = cmbNPacienteSexo.getItemValue(1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A334NPacienteSexo", A334NPacienteSexo);
         }
         cmbNPacienteEstaturaEn.Name = "NPACIENTEESTATURAEN" ;
         cmbNPacienteEstaturaEn.WebTags = "" ;
         cmbNPacienteEstaturaEn.addItem("ME", "Metros", 0);
         cmbNPacienteEstaturaEn.addItem("CM", "Centímetros", 0);
         if ( ( cmbNPacienteEstaturaEn.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A336NPacienteEstaturaEn)) )
         {
            A336NPacienteEstaturaEn = cmbNPacienteEstaturaEn.getItemValue(1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A336NPacienteEstaturaEn", A336NPacienteEstaturaEn);
         }
         cmbNPacientePesoEn.Name = "NPACIENTEPESOEN" ;
         cmbNPacientePesoEn.WebTags = "" ;
         cmbNPacientePesoEn.addItem("Lb", "Libras", 0);
         cmbNPacientePesoEn.addItem("Gr", "Gramos", 0);
         cmbNPacientePesoEn.addItem("Kg", "Kilogramos", 0);
         if ( ( cmbNPacientePesoEn.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A338NPacientePesoEn)) )
         {
            A338NPacientePesoEn = cmbNPacientePesoEn.getItemValue(1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A338NPacientePesoEn", A338NPacientePesoEn);
         }
         chkNPacienteAnestesiaGeneral.Name = "NPACIENTEANESTESIAGENERAL" ;
         chkNPacienteAnestesiaGeneral.WebTags = "" ;
         chkNPacienteAnestesiaGeneral.Caption = "" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkNPacienteAnestesiaGeneral_Internalname, "Caption", chkNPacienteAnestesiaGeneral.Caption);
         chkNPacienteAnestesiaGeneral.CheckedValue = "0" ;
         chkNPacienteAnestesiaEpidural.Name = "NPACIENTEANESTESIAEPIDURAL" ;
         chkNPacienteAnestesiaEpidural.WebTags = "" ;
         chkNPacienteAnestesiaEpidural.Caption = "" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkNPacienteAnestesiaEpidural_Internalname, "Caption", chkNPacienteAnestesiaEpidural.Caption);
         chkNPacienteAnestesiaEpidural.CheckedValue = "0" ;
         chkNPacienteAnestesiaRaquidea.Name = "NPACIENTEANESTESIARAQUIDEA" ;
         chkNPacienteAnestesiaRaquidea.WebTags = "" ;
         chkNPacienteAnestesiaRaquidea.Caption = "" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkNPacienteAnestesiaRaquidea_Internalname, "Caption", chkNPacienteAnestesiaRaquidea.Caption);
         chkNPacienteAnestesiaRaquidea.CheckedValue = "0" ;
         chkNPacienteFuma.Name = "NPACIENTEFUMA" ;
         chkNPacienteFuma.WebTags = "" ;
         chkNPacienteFuma.Caption = "" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkNPacienteFuma_Internalname, "Caption", chkNPacienteFuma.Caption);
         chkNPacienteFuma.CheckedValue = "0" ;
         chkNPacienteAlcohol.Name = "NPACIENTEALCOHOL" ;
         chkNPacienteAlcohol.WebTags = "" ;
         chkNPacienteAlcohol.Caption = "" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkNPacienteAlcohol_Internalname, "Caption", chkNPacienteAlcohol.Caption);
         chkNPacienteAlcohol.CheckedValue = "0" ;
         cmbNPacienteEstatus.Name = "NPACIENTEESTATUS" ;
         cmbNPacienteEstatus.WebTags = "" ;
         cmbNPacienteEstatus.addItem("1", "Creado", 0);
         cmbNPacienteEstatus.addItem("2", "Evaluado", 0);
         cmbNPacienteEstatus.addItem("3", "Cancelado", 0);
         if ( ( cmbNPacienteEstatus.ItemCount > 0 ) && (0==A364NPacienteEstatus) )
         {
            A364NPacienteEstatus = (short)(NumberUtil.Val( cmbNPacienteEstatus.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364NPacienteEstatus", StringUtil.Str( (decimal)(A364NPacienteEstatus), 1, 0));
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Nota de ingreso del paciente", 0) ;
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

      public notapaciente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public notapaciente( IGxContext context )
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
         cmbNPacienteSexo = new GXCombobox();
         cmbNPacienteEstaturaEn = new GXCombobox();
         cmbNPacientePesoEn = new GXCombobox();
         chkNPacienteAnestesiaGeneral = new GXCheckbox();
         chkNPacienteAnestesiaEpidural = new GXCheckbox();
         chkNPacienteAnestesiaRaquidea = new GXCheckbox();
         chkNPacienteFuma = new GXCheckbox();
         chkNPacienteAlcohol = new GXCheckbox();
         cmbNPacienteEstatus = new GXCombobox();
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
            wb_table1_2_1N75( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1N75e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1N75( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1N75( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1N75e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Nota de ingreso del paciente"+"</legend>") ;
            wb_table3_27_1N75( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_1N75e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1N75e( true) ;
         }
         else
         {
            wb_table1_2_1N75e( false) ;
         }
      }

      protected void wb_table3_27_1N75( bool wbgen )
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
            wb_table4_33_1N75( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_1N75e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 251,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_NotaPaciente.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 252,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_NotaPaciente.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 253,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_1N75e( true) ;
         }
         else
         {
            wb_table3_27_1N75e( false) ;
         }
      }

      protected void wb_table4_33_1N75( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacienteid_Internalname, "Paciente", "", "", lblTextblocknpacienteid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327NPacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A327NPacienteId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A327NPacienteId), 9, 0, ".", "")), ((edtNPacienteId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A327NPacienteId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A327NPacienteId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(43);\"", "", "", "", "", edtNPacienteId_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacientenombre1_Internalname, "Nombre_1", "", "", lblTextblocknpacientenombre1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328NPacienteNombre1", A328NPacienteNombre1);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteNombre1_Internalname, StringUtil.RTrim( A328NPacienteNombre1), StringUtil.RTrim( context.localUtil.Format( A328NPacienteNombre1, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", "", "", "", edtNPacienteNombre1_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteNombre1_Enabled, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacientenombre2_Internalname, "Nombre_2", "", "", lblTextblocknpacientenombre2_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329NPacienteNombre2", A329NPacienteNombre2);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteNombre2_Internalname, StringUtil.RTrim( A329NPacienteNombre2), StringUtil.RTrim( context.localUtil.Format( A329NPacienteNombre2, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "", "", "", "", edtNPacienteNombre2_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteNombre2_Enabled, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacienteapellido1_Internalname, "Apellido_1", "", "", lblTextblocknpacienteapellido1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A330NPacienteApellido1", A330NPacienteApellido1);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteApellido1_Internalname, StringUtil.RTrim( A330NPacienteApellido1), StringUtil.RTrim( context.localUtil.Format( A330NPacienteApellido1, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", "", "", "", "", edtNPacienteApellido1_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteApellido1_Enabled, 0, 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, true, "left", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacienteapellido2_Internalname, "Apellido_2", "", "", lblTextblocknpacienteapellido2_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331NPacienteApellido2", A331NPacienteApellido2);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteApellido2_Internalname, StringUtil.RTrim( A331NPacienteApellido2), StringUtil.RTrim( context.localUtil.Format( A331NPacienteApellido2, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", "", "", "", "", edtNPacienteApellido2_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteApellido2_Enabled, 0, 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, true, "left", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacienteapellido3_Internalname, "Apellido_3", "", "", lblTextblocknpacienteapellido3_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332NPacienteApellido3", A332NPacienteApellido3);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteApellido3_Internalname, StringUtil.RTrim( A332NPacienteApellido3), StringUtil.RTrim( context.localUtil.Format( A332NPacienteApellido3, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", "", "", "", "", edtNPacienteApellido3_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteApellido3_Enabled, 0, 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, true, "left", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacientefechanac_Internalname, "Nacimiento", "", "", lblTextblocknpacientefechanac_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333NPacienteFechaNac", context.localUtil.Format(A333NPacienteFechaNac, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtNPacienteFechaNac_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteFechaNac_Internalname, context.localUtil.Format(A333NPacienteFechaNac, "99/99/99"), context.localUtil.Format( A333NPacienteFechaNac, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(73);\"", "", "", "", "", edtNPacienteFechaNac_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteFechaNac_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_NotaPaciente.htm");
            GxWebStd.gx_bitmap( context, edtNPacienteFechaNac_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtNPacienteFechaNac_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_NotaPaciente.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacientesexo_Internalname, "Sexo", "", "", lblTextblocknpacientesexo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A334NPacienteSexo", A334NPacienteSexo);
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbNPacienteSexo, cmbNPacienteSexo_Internalname, A334NPacienteSexo, 1, cmbNPacienteSexo_Jsonclick, 0, "", "svchar", "", 1, cmbNPacienteSexo.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(78);\"", "", true, "HLP_NotaPaciente.htm");
            cmbNPacienteSexo.CurrentValue = A334NPacienteSexo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbNPacienteSexo_Internalname, "Values", (String)(cmbNPacienteSexo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacienteestatura_Internalname, "Estatura", "", "", lblTextblocknpacienteestatura_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A335NPacienteEstatura", StringUtil.LTrim( StringUtil.Str( A335NPacienteEstatura, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteEstatura_Internalname, StringUtil.LTrim( StringUtil.NToC( A335NPacienteEstatura, 17, 2, ".", "")), ((edtNPacienteEstatura_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A335NPacienteEstatura, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A335NPacienteEstatura, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(83);\"", "", "", "", "", edtNPacienteEstatura_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteEstatura_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacienteestaturaen_Internalname, "Medida", "", "", lblTextblocknpacienteestaturaen_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A336NPacienteEstaturaEn", A336NPacienteEstaturaEn);
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbNPacienteEstaturaEn, cmbNPacienteEstaturaEn_Internalname, A336NPacienteEstaturaEn, 1, cmbNPacienteEstaturaEn_Jsonclick, 0, "", "svchar", "", 1, cmbNPacienteEstaturaEn.Enabled, 0, 0, 2, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(88);\"", "", true, "HLP_NotaPaciente.htm");
            cmbNPacienteEstaturaEn.CurrentValue = A336NPacienteEstaturaEn ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbNPacienteEstaturaEn_Internalname, "Values", (String)(cmbNPacienteEstaturaEn.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacientepeso_Internalname, "Peso", "", "", lblTextblocknpacientepeso_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A337NPacientePeso", StringUtil.LTrim( StringUtil.Str( A337NPacientePeso, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNPacientePeso_Internalname, StringUtil.LTrim( StringUtil.NToC( A337NPacientePeso, 17, 2, ".", "")), ((edtNPacientePeso_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A337NPacientePeso, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A337NPacientePeso, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(93);\"", "", "", "", "", edtNPacientePeso_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacientePeso_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacientepesoen_Internalname, "Medida", "", "", lblTextblocknpacientepesoen_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A338NPacientePesoEn", A338NPacientePesoEn);
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbNPacientePesoEn, cmbNPacientePesoEn_Internalname, A338NPacientePesoEn, 1, cmbNPacientePesoEn_Jsonclick, 0, "", "svchar", "", 1, cmbNPacientePesoEn.Enabled, 0, 0, 2, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(98);\"", "", true, "HLP_NotaPaciente.htm");
            cmbNPacientePesoEn.CurrentValue = A338NPacientePesoEn ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbNPacientePesoEn_Internalname, "Values", (String)(cmbNPacientePesoEn.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprofesionid_Internalname, "Profesión", "", "", lblTextblockprofesionid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313ProfesionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A313ProfesionId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtProfesionId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A313ProfesionId), 9, 0, ".", "")), ((edtProfesionId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A313ProfesionId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A313ProfesionId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(103);\"", "", "", "", "", edtProfesionId_Jsonclick, 0, ClassString, StyleString, "", 1, edtProfesionId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_NotaPaciente.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_313_Internalname, "prompt.gif", imgprompt_41_313_Link, "", "", "Fantastic", imgprompt_41_313_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockreligionid_Internalname, "Religión", "", "", lblTextblockreligionid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315ReligionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A315ReligionId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 108,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtReligionId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A315ReligionId), 9, 0, ".", "")), ((edtReligionId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A315ReligionId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A315ReligionId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(108);\"", "", "", "", "", edtReligionId_Jsonclick, 0, ClassString, StyleString, "", 1, edtReligionId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_NotaPaciente.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_315_Internalname, "prompt.gif", imgprompt_41_315_Link, "", "", "Fantastic", imgprompt_41_315_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacientedireccion_Internalname, "Dirección", "", "", lblTextblocknpacientedireccion_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A339NPacienteDireccion", A339NPacienteDireccion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 113,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteDireccion_Internalname, StringUtil.RTrim( A339NPacienteDireccion), StringUtil.RTrim( context.localUtil.Format( A339NPacienteDireccion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(113);\"", "", "", "", "", edtNPacienteDireccion_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteDireccion_Enabled, 0, 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, true, "left", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacientecorreo_Internalname, "Correo", "", "", lblTextblocknpacientecorreo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A340NPacienteCorreo", A340NPacienteCorreo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 118,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteCorreo_Internalname, StringUtil.RTrim( A340NPacienteCorreo), StringUtil.RTrim( context.localUtil.Format( A340NPacienteCorreo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(118);\"", "", "", "", "", edtNPacienteCorreo_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteCorreo_Enabled, 0, 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, true, "left", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacientefacebook_Internalname, "Facebook", "", "", lblTextblocknpacientefacebook_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A341NPacienteFacebook", A341NPacienteFacebook);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 123,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteFacebook_Internalname, StringUtil.RTrim( A341NPacienteFacebook), StringUtil.RTrim( context.localUtil.Format( A341NPacienteFacebook, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(123);\"", "", "", "", "", edtNPacienteFacebook_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteFacebook_Enabled, 0, 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, true, "left", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacientetelefono_Internalname, "Teléfono", "", "", lblTextblocknpacientetelefono_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A342NPacienteTelefono", A342NPacienteTelefono);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 128,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteTelefono_Internalname, StringUtil.RTrim( A342NPacienteTelefono), StringUtil.RTrim( context.localUtil.Format( A342NPacienteTelefono, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(128);\"", "", "", "", "", edtNPacienteTelefono_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteTelefono_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "left", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacientecelular_Internalname, "Celular", "", "", lblTextblocknpacientecelular_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A343NPacienteCelular", A343NPacienteCelular);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 133,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteCelular_Internalname, StringUtil.RTrim( A343NPacienteCelular), StringUtil.RTrim( context.localUtil.Format( A343NPacienteCelular, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(133);\"", "", "", "", "", edtNPacienteCelular_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteCelular_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "left", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacienteenfermedad_Internalname, "Enfermedades", "", "", lblTextblocknpacienteenfermedad_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A344NPacienteEnfermedad", A344NPacienteEnfermedad);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 138,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtNPacienteEnfermedad_Internalname, StringUtil.RTrim( A344NPacienteEnfermedad), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(138);\"", 0, 1, edtNPacienteEnfermedad_Enabled, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacientemedicamento_Internalname, "Medicamentos", "", "", lblTextblocknpacientemedicamento_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345NPacienteMedicamento", A345NPacienteMedicamento);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 143,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtNPacienteMedicamento_Internalname, StringUtil.RTrim( A345NPacienteMedicamento), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(143);\"", 0, 1, edtNPacienteMedicamento_Enabled, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacienteoperacion_Internalname, "Operaciones", "", "", lblTextblocknpacienteoperacion_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A346NPacienteOperacion", A346NPacienteOperacion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 148,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtNPacienteOperacion_Internalname, StringUtil.RTrim( A346NPacienteOperacion), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(148);\"", 0, 1, edtNPacienteOperacion_Enabled, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacientealergia_Internalname, "Alergías", "", "", lblTextblocknpacientealergia_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347NPacienteAlergia", A347NPacienteAlergia);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 153,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtNPacienteAlergia_Internalname, StringUtil.RTrim( A347NPacienteAlergia), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(153);\"", 0, 1, edtNPacienteAlergia_Enabled, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacientegesta_Internalname, "Gestas?", "", "", lblTextblocknpacientegesta_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348NPacienteGesta", StringUtil.LTrim( StringUtil.Str( (decimal)(A348NPacienteGesta), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 158,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteGesta_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A348NPacienteGesta), 4, 0, ".", "")), ((edtNPacienteGesta_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A348NPacienteGesta), "ZZZ9")) : context.localUtil.Format( (decimal)(A348NPacienteGesta), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(158);\"", "", "", "", "", edtNPacienteGesta_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteGesta_Enabled, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacienteparto_Internalname, "Partos?", "", "", lblTextblocknpacienteparto_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349NPacienteParto", StringUtil.LTrim( StringUtil.Str( (decimal)(A349NPacienteParto), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 163,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteParto_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A349NPacienteParto), 4, 0, ".", "")), ((edtNPacienteParto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A349NPacienteParto), "ZZZ9")) : context.localUtil.Format( (decimal)(A349NPacienteParto), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(163);\"", "", "", "", "", edtNPacienteParto_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteParto_Enabled, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacientecesarea_Internalname, "Cesareas?", "", "", lblTextblocknpacientecesarea_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350NPacienteCesarea", StringUtil.LTrim( StringUtil.Str( (decimal)(A350NPacienteCesarea), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 168,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteCesarea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A350NPacienteCesarea), 4, 0, ".", "")), ((edtNPacienteCesarea_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A350NPacienteCesarea), "ZZZ9")) : context.localUtil.Format( (decimal)(A350NPacienteCesarea), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(168);\"", "", "", "", "", edtNPacienteCesarea_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteCesarea_Enabled, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacienteaborto_Internalname, "Abortos?", "", "", lblTextblocknpacienteaborto_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A351NPacienteAborto", StringUtil.LTrim( StringUtil.Str( (decimal)(A351NPacienteAborto), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 173,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteAborto_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A351NPacienteAborto), 4, 0, ".", "")), ((edtNPacienteAborto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A351NPacienteAborto), "ZZZ9")) : context.localUtil.Format( (decimal)(A351NPacienteAborto), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(173);\"", "", "", "", "", edtNPacienteAborto_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteAborto_Enabled, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacienteanestesiageneral_Internalname, "General?", "", "", lblTextblocknpacienteanestesiageneral_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Check box */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A352NPacienteAnestesiaGeneral", StringUtil.Str( (decimal)(A352NPacienteAnestesiaGeneral), 1, 0));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 178,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_checkbox_ctrl( context, chkNPacienteAnestesiaGeneral_Internalname, StringUtil.Str( (decimal)(A352NPacienteAnestesiaGeneral), 1, 0), "", 1, chkNPacienteAnestesiaGeneral.Enabled, "1", "", StyleString, ClassString, TempTags+" onclick=\"gx.fn.checkboxClick(178, this, 1, 0);gx.evt.onchange(this);\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(178);\"");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacienteanestesiaepidural_Internalname, "Epidural?", "", "", lblTextblocknpacienteanestesiaepidural_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Check box */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353NPacienteAnestesiaEpidural", StringUtil.Str( (decimal)(A353NPacienteAnestesiaEpidural), 1, 0));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 183,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_checkbox_ctrl( context, chkNPacienteAnestesiaEpidural_Internalname, StringUtil.Str( (decimal)(A353NPacienteAnestesiaEpidural), 1, 0), "", 1, chkNPacienteAnestesiaEpidural.Enabled, "1", "", StyleString, ClassString, TempTags+" onclick=\"gx.fn.checkboxClick(183, this, 1, 0);gx.evt.onchange(this);\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(183);\"");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacienteanestesiaraquidea_Internalname, "Raquídea?", "", "", lblTextblocknpacienteanestesiaraquidea_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Check box */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A354NPacienteAnestesiaRaquidea", StringUtil.Str( (decimal)(A354NPacienteAnestesiaRaquidea), 1, 0));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 188,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_checkbox_ctrl( context, chkNPacienteAnestesiaRaquidea_Internalname, StringUtil.Str( (decimal)(A354NPacienteAnestesiaRaquidea), 1, 0), "", 1, chkNPacienteAnestesiaRaquidea.Enabled, "1", "", StyleString, ClassString, TempTags+" onclick=\"gx.fn.checkboxClick(188, this, 1, 0);gx.evt.onchange(this);\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(188);\"");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacienteanestesiaotro_Internalname, "Otros", "", "", lblTextblocknpacienteanestesiaotro_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A355NPacienteAnestesiaOtro", A355NPacienteAnestesiaOtro);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 193,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteAnestesiaOtro_Internalname, StringUtil.RTrim( A355NPacienteAnestesiaOtro), StringUtil.RTrim( context.localUtil.Format( A355NPacienteAnestesiaOtro, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(193);\"", "", "", "", "", edtNPacienteAnestesiaOtro_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteAnestesiaOtro_Enabled, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacienteanestesiacomplica_Internalname, "Complicaciones", "", "", lblTextblocknpacienteanestesiacomplica_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A356NPacienteAnestesiaComplica", A356NPacienteAnestesiaComplica);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 198,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtNPacienteAnestesiaComplica_Internalname, StringUtil.RTrim( A356NPacienteAnestesiaComplica), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(198);\"", 0, 1, edtNPacienteAnestesiaComplica_Enabled, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacientefuma_Internalname, "Fuma?", "", "", lblTextblocknpacientefuma_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Check box */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A357NPacienteFuma", StringUtil.Str( (decimal)(A357NPacienteFuma), 1, 0));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 203,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_checkbox_ctrl( context, chkNPacienteFuma_Internalname, StringUtil.Str( (decimal)(A357NPacienteFuma), 1, 0), "", 1, chkNPacienteFuma.Enabled, "1", "", StyleString, ClassString, TempTags+" onclick=\"gx.fn.checkboxClick(203, this, 1, 0);gx.evt.onchange(this);\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(203);\"");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacientecigarros_Internalname, "Diarios", "", "", lblTextblocknpacientecigarros_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358NPacienteCigarros", StringUtil.LTrim( StringUtil.Str( (decimal)(A358NPacienteCigarros), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 208,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteCigarros_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A358NPacienteCigarros), 4, 0, ".", "")), ((edtNPacienteCigarros_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A358NPacienteCigarros), "ZZZ9")) : context.localUtil.Format( (decimal)(A358NPacienteCigarros), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(208);\"", "", "", "", "", edtNPacienteCigarros_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteCigarros_Enabled, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacientealcohol_Internalname, "Alcohol?", "", "", lblTextblocknpacientealcohol_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Check box */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359NPacienteAlcohol", StringUtil.Str( (decimal)(A359NPacienteAlcohol), 1, 0));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 213,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_checkbox_ctrl( context, chkNPacienteAlcohol_Internalname, StringUtil.Str( (decimal)(A359NPacienteAlcohol), 1, 0), "", 1, chkNPacienteAlcohol.Enabled, "1", "", StyleString, ClassString, TempTags+" onclick=\"gx.fn.checkboxClick(213, this, 1, 0);gx.evt.onchange(this);\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(213);\"");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacienteotros_Internalname, "Otros", "", "", lblTextblocknpacienteotros_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360NPacienteOtros", A360NPacienteOtros);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 218,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteOtros_Internalname, StringUtil.RTrim( A360NPacienteOtros), StringUtil.RTrim( context.localUtil.Format( A360NPacienteOtros, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(218);\"", "", "", "", "", edtNPacienteOtros_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteOtros_Enabled, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacientefecha_Internalname, "Registro", "", "", lblTextblocknpacientefecha_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361NPacienteFecha", context.localUtil.Format(A361NPacienteFecha, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 223,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtNPacienteFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteFecha_Internalname, context.localUtil.Format(A361NPacienteFecha, "99/99/99"), context.localUtil.Format( A361NPacienteFecha, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(223);\"", "", "", "", "", edtNPacienteFecha_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteFecha_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_NotaPaciente.htm");
            GxWebStd.gx_bitmap( context, edtNPacienteFecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtNPacienteFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_NotaPaciente.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacientehora_Internalname, "Registro", "", "", lblTextblocknpacientehora_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362NPacienteHora", A362NPacienteHora);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 228,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNPacienteHora_Internalname, StringUtil.RTrim( A362NPacienteHora), StringUtil.RTrim( context.localUtil.Format( A362NPacienteHora, "XXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(228);\"", "", "", "", "", edtNPacienteHora_Jsonclick, 0, ClassString, StyleString, "", 1, edtNPacienteHora_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "left", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusuariocodigo_Internalname, "Usuario", "", "", lblTextblockusuariocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 233,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUsuarioCodigo_Internalname, StringUtil.RTrim( A4UsuarioCodigo), StringUtil.RTrim( context.localUtil.Format( A4UsuarioCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(233);\"", "", "", "", "", edtUsuarioCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtUsuarioCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_NotaPaciente.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_4_Internalname, "prompt.gif", imgprompt_4_Link, "", "", "Fantastic", imgprompt_4_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipopaccodigo_Internalname, "Tipo_Paciente", "", "", lblTextblocktipopaccodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144TipoPacCodigo", A144TipoPacCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 238,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTipoPacCodigo_Internalname, StringUtil.RTrim( A144TipoPacCodigo), StringUtil.RTrim( context.localUtil.Format( A144TipoPacCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(238);\"", "", "", "", "", edtTipoPacCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtTipoPacCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_NotaPaciente.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_144_Internalname, "prompt.gif", imgprompt_41_144_Link, "", "", "Fantastic", imgprompt_41_144_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockvendedorcodigo_Internalname, "Vendedor", "", "", lblTextblockvendedorcodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317VendedorCodigo", A317VendedorCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 243,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtVendedorCodigo_Internalname, StringUtil.RTrim( A317VendedorCodigo), StringUtil.RTrim( context.localUtil.Format( A317VendedorCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(243);\"", "", "", "", "", edtVendedorCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtVendedorCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_NotaPaciente.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_317_Internalname, "prompt.gif", imgprompt_41_317_Link, "", "", "Fantastic", imgprompt_41_317_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknpacienteestatus_Internalname, "Estatus", "", "", lblTextblocknpacienteestatus_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotaPaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364NPacienteEstatus", StringUtil.Str( (decimal)(A364NPacienteEstatus), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 248,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbNPacienteEstatus, cmbNPacienteEstatus_Internalname, StringUtil.Str( (decimal)(A364NPacienteEstatus), 1, 0), 1, cmbNPacienteEstatus_Jsonclick, 0, "", "int", "", 1, cmbNPacienteEstatus.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(248);\"", "", true, "HLP_NotaPaciente.htm");
            cmbNPacienteEstatus.CurrentValue = StringUtil.Str( (decimal)(A364NPacienteEstatus), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbNPacienteEstatus_Internalname, "Values", (String)(cmbNPacienteEstatus.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_1N75e( true) ;
         }
         else
         {
            wb_table4_33_1N75e( false) ;
         }
      }

      protected void wb_table2_5_1N75( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_NotaPaciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_NotaPaciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_NotaPaciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_NotaPaciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_NotaPaciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_NotaPaciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_NotaPaciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_NotaPaciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0230.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"NPACIENTEID"+"'), id:'"+"NPACIENTEID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_NotaPaciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0230.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"NPACIENTEID"+"'), id:'"+"NPACIENTEID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_NotaPaciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_NotaPaciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_NotaPaciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_NotaPaciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_NotaPaciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_NotaPaciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_NotaPaciente.htm");
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
            wb_table2_5_1N75e( true) ;
         }
         else
         {
            wb_table2_5_1N75e( false) ;
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtNPacienteId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtNPacienteId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "NPACIENTEID");
                  AnyError = 1 ;
                  GX_FocusControl = edtNPacienteId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A327NPacienteId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327NPacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A327NPacienteId), 9, 0)));
               }
               else
               {
                  A327NPacienteId = (int)(context.localUtil.CToN( cgiGet( edtNPacienteId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327NPacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A327NPacienteId), 9, 0)));
               }
               A328NPacienteNombre1 = cgiGet( edtNPacienteNombre1_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328NPacienteNombre1", A328NPacienteNombre1);
               A329NPacienteNombre2 = cgiGet( edtNPacienteNombre2_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329NPacienteNombre2", A329NPacienteNombre2);
               A330NPacienteApellido1 = cgiGet( edtNPacienteApellido1_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A330NPacienteApellido1", A330NPacienteApellido1);
               A331NPacienteApellido2 = cgiGet( edtNPacienteApellido2_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331NPacienteApellido2", A331NPacienteApellido2);
               A332NPacienteApellido3 = cgiGet( edtNPacienteApellido3_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332NPacienteApellido3", A332NPacienteApellido3);
               if ( context.localUtil.VCDate( cgiGet( edtNPacienteFechaNac_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha_Nacimiento"}), 1, "NPACIENTEFECHANAC");
                  AnyError = 1 ;
                  GX_FocusControl = edtNPacienteFechaNac_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A333NPacienteFechaNac = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333NPacienteFechaNac", context.localUtil.Format(A333NPacienteFechaNac, "99/99/99"));
               }
               else
               {
                  A333NPacienteFechaNac = context.localUtil.CToD( cgiGet( edtNPacienteFechaNac_Internalname), 2) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333NPacienteFechaNac", context.localUtil.Format(A333NPacienteFechaNac, "99/99/99"));
               }
               cmbNPacienteSexo.CurrentValue = cgiGet( cmbNPacienteSexo_Internalname) ;
               A334NPacienteSexo = cgiGet( cmbNPacienteSexo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A334NPacienteSexo", A334NPacienteSexo);
               if ( ( ( context.localUtil.CToN( cgiGet( edtNPacienteEstatura_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtNPacienteEstatura_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "NPACIENTEESTATURA");
                  AnyError = 1 ;
                  GX_FocusControl = edtNPacienteEstatura_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A335NPacienteEstatura = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A335NPacienteEstatura", StringUtil.LTrim( StringUtil.Str( A335NPacienteEstatura, 17, 2)));
               }
               else
               {
                  A335NPacienteEstatura = context.localUtil.CToN( cgiGet( edtNPacienteEstatura_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A335NPacienteEstatura", StringUtil.LTrim( StringUtil.Str( A335NPacienteEstatura, 17, 2)));
               }
               cmbNPacienteEstaturaEn.CurrentValue = cgiGet( cmbNPacienteEstaturaEn_Internalname) ;
               A336NPacienteEstaturaEn = cgiGet( cmbNPacienteEstaturaEn_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A336NPacienteEstaturaEn", A336NPacienteEstaturaEn);
               if ( ( ( context.localUtil.CToN( cgiGet( edtNPacientePeso_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtNPacientePeso_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "NPACIENTEPESO");
                  AnyError = 1 ;
                  GX_FocusControl = edtNPacientePeso_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A337NPacientePeso = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A337NPacientePeso", StringUtil.LTrim( StringUtil.Str( A337NPacientePeso, 17, 2)));
               }
               else
               {
                  A337NPacientePeso = context.localUtil.CToN( cgiGet( edtNPacientePeso_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A337NPacientePeso", StringUtil.LTrim( StringUtil.Str( A337NPacientePeso, 17, 2)));
               }
               cmbNPacientePesoEn.CurrentValue = cgiGet( cmbNPacientePesoEn_Internalname) ;
               A338NPacientePesoEn = cgiGet( cmbNPacientePesoEn_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A338NPacientePesoEn", A338NPacientePesoEn);
               if ( ( ( context.localUtil.CToN( cgiGet( edtProfesionId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtProfesionId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PROFESIONID");
                  AnyError = 1 ;
                  GX_FocusControl = edtProfesionId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A313ProfesionId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313ProfesionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A313ProfesionId), 9, 0)));
               }
               else
               {
                  A313ProfesionId = (int)(context.localUtil.CToN( cgiGet( edtProfesionId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313ProfesionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A313ProfesionId), 9, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtReligionId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtReligionId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "RELIGIONID");
                  AnyError = 1 ;
                  GX_FocusControl = edtReligionId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A315ReligionId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315ReligionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A315ReligionId), 9, 0)));
               }
               else
               {
                  A315ReligionId = (int)(context.localUtil.CToN( cgiGet( edtReligionId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315ReligionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A315ReligionId), 9, 0)));
               }
               A339NPacienteDireccion = cgiGet( edtNPacienteDireccion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A339NPacienteDireccion", A339NPacienteDireccion);
               A340NPacienteCorreo = cgiGet( edtNPacienteCorreo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A340NPacienteCorreo", A340NPacienteCorreo);
               A341NPacienteFacebook = cgiGet( edtNPacienteFacebook_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A341NPacienteFacebook", A341NPacienteFacebook);
               A342NPacienteTelefono = cgiGet( edtNPacienteTelefono_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A342NPacienteTelefono", A342NPacienteTelefono);
               A343NPacienteCelular = cgiGet( edtNPacienteCelular_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A343NPacienteCelular", A343NPacienteCelular);
               A344NPacienteEnfermedad = cgiGet( edtNPacienteEnfermedad_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A344NPacienteEnfermedad", A344NPacienteEnfermedad);
               A345NPacienteMedicamento = cgiGet( edtNPacienteMedicamento_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345NPacienteMedicamento", A345NPacienteMedicamento);
               A346NPacienteOperacion = cgiGet( edtNPacienteOperacion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A346NPacienteOperacion", A346NPacienteOperacion);
               A347NPacienteAlergia = cgiGet( edtNPacienteAlergia_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347NPacienteAlergia", A347NPacienteAlergia);
               if ( ( ( context.localUtil.CToN( cgiGet( edtNPacienteGesta_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtNPacienteGesta_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "NPACIENTEGESTA");
                  AnyError = 1 ;
                  GX_FocusControl = edtNPacienteGesta_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A348NPacienteGesta = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348NPacienteGesta", StringUtil.LTrim( StringUtil.Str( (decimal)(A348NPacienteGesta), 4, 0)));
               }
               else
               {
                  A348NPacienteGesta = (short)(context.localUtil.CToN( cgiGet( edtNPacienteGesta_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348NPacienteGesta", StringUtil.LTrim( StringUtil.Str( (decimal)(A348NPacienteGesta), 4, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtNPacienteParto_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtNPacienteParto_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "NPACIENTEPARTO");
                  AnyError = 1 ;
                  GX_FocusControl = edtNPacienteParto_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A349NPacienteParto = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349NPacienteParto", StringUtil.LTrim( StringUtil.Str( (decimal)(A349NPacienteParto), 4, 0)));
               }
               else
               {
                  A349NPacienteParto = (short)(context.localUtil.CToN( cgiGet( edtNPacienteParto_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349NPacienteParto", StringUtil.LTrim( StringUtil.Str( (decimal)(A349NPacienteParto), 4, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtNPacienteCesarea_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtNPacienteCesarea_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "NPACIENTECESAREA");
                  AnyError = 1 ;
                  GX_FocusControl = edtNPacienteCesarea_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A350NPacienteCesarea = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350NPacienteCesarea", StringUtil.LTrim( StringUtil.Str( (decimal)(A350NPacienteCesarea), 4, 0)));
               }
               else
               {
                  A350NPacienteCesarea = (short)(context.localUtil.CToN( cgiGet( edtNPacienteCesarea_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350NPacienteCesarea", StringUtil.LTrim( StringUtil.Str( (decimal)(A350NPacienteCesarea), 4, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtNPacienteAborto_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtNPacienteAborto_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "NPACIENTEABORTO");
                  AnyError = 1 ;
                  GX_FocusControl = edtNPacienteAborto_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A351NPacienteAborto = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A351NPacienteAborto", StringUtil.LTrim( StringUtil.Str( (decimal)(A351NPacienteAborto), 4, 0)));
               }
               else
               {
                  A351NPacienteAborto = (short)(context.localUtil.CToN( cgiGet( edtNPacienteAborto_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A351NPacienteAborto", StringUtil.LTrim( StringUtil.Str( (decimal)(A351NPacienteAborto), 4, 0)));
               }
               if ( ( ( ((StringUtil.StrCmp(cgiGet( chkNPacienteAnestesiaGeneral_Internalname), "1")==0) ? 1 : 0) < 0 ) ) || ( ( ((StringUtil.StrCmp(cgiGet( chkNPacienteAnestesiaGeneral_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "NPACIENTEANESTESIAGENERAL");
                  AnyError = 1 ;
                  GX_FocusControl = chkNPacienteAnestesiaGeneral_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A352NPacienteAnestesiaGeneral = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A352NPacienteAnestesiaGeneral", StringUtil.Str( (decimal)(A352NPacienteAnestesiaGeneral), 1, 0));
               }
               else
               {
                  A352NPacienteAnestesiaGeneral = (short)(((StringUtil.StrCmp(cgiGet( chkNPacienteAnestesiaGeneral_Internalname), "1")==0) ? 1 : 0)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A352NPacienteAnestesiaGeneral", StringUtil.Str( (decimal)(A352NPacienteAnestesiaGeneral), 1, 0));
               }
               if ( ( ( ((StringUtil.StrCmp(cgiGet( chkNPacienteAnestesiaEpidural_Internalname), "1")==0) ? 1 : 0) < 0 ) ) || ( ( ((StringUtil.StrCmp(cgiGet( chkNPacienteAnestesiaEpidural_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "NPACIENTEANESTESIAEPIDURAL");
                  AnyError = 1 ;
                  GX_FocusControl = chkNPacienteAnestesiaEpidural_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A353NPacienteAnestesiaEpidural = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353NPacienteAnestesiaEpidural", StringUtil.Str( (decimal)(A353NPacienteAnestesiaEpidural), 1, 0));
               }
               else
               {
                  A353NPacienteAnestesiaEpidural = (short)(((StringUtil.StrCmp(cgiGet( chkNPacienteAnestesiaEpidural_Internalname), "1")==0) ? 1 : 0)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353NPacienteAnestesiaEpidural", StringUtil.Str( (decimal)(A353NPacienteAnestesiaEpidural), 1, 0));
               }
               if ( ( ( ((StringUtil.StrCmp(cgiGet( chkNPacienteAnestesiaRaquidea_Internalname), "1")==0) ? 1 : 0) < 0 ) ) || ( ( ((StringUtil.StrCmp(cgiGet( chkNPacienteAnestesiaRaquidea_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "NPACIENTEANESTESIARAQUIDEA");
                  AnyError = 1 ;
                  GX_FocusControl = chkNPacienteAnestesiaRaquidea_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A354NPacienteAnestesiaRaquidea = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A354NPacienteAnestesiaRaquidea", StringUtil.Str( (decimal)(A354NPacienteAnestesiaRaquidea), 1, 0));
               }
               else
               {
                  A354NPacienteAnestesiaRaquidea = (short)(((StringUtil.StrCmp(cgiGet( chkNPacienteAnestesiaRaquidea_Internalname), "1")==0) ? 1 : 0)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A354NPacienteAnestesiaRaquidea", StringUtil.Str( (decimal)(A354NPacienteAnestesiaRaquidea), 1, 0));
               }
               A355NPacienteAnestesiaOtro = cgiGet( edtNPacienteAnestesiaOtro_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A355NPacienteAnestesiaOtro", A355NPacienteAnestesiaOtro);
               A356NPacienteAnestesiaComplica = cgiGet( edtNPacienteAnestesiaComplica_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A356NPacienteAnestesiaComplica", A356NPacienteAnestesiaComplica);
               if ( ( ( ((StringUtil.StrCmp(cgiGet( chkNPacienteFuma_Internalname), "1")==0) ? 1 : 0) < 0 ) ) || ( ( ((StringUtil.StrCmp(cgiGet( chkNPacienteFuma_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "NPACIENTEFUMA");
                  AnyError = 1 ;
                  GX_FocusControl = chkNPacienteFuma_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A357NPacienteFuma = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A357NPacienteFuma", StringUtil.Str( (decimal)(A357NPacienteFuma), 1, 0));
               }
               else
               {
                  A357NPacienteFuma = (short)(((StringUtil.StrCmp(cgiGet( chkNPacienteFuma_Internalname), "1")==0) ? 1 : 0)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A357NPacienteFuma", StringUtil.Str( (decimal)(A357NPacienteFuma), 1, 0));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtNPacienteCigarros_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtNPacienteCigarros_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "NPACIENTECIGARROS");
                  AnyError = 1 ;
                  GX_FocusControl = edtNPacienteCigarros_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A358NPacienteCigarros = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358NPacienteCigarros", StringUtil.LTrim( StringUtil.Str( (decimal)(A358NPacienteCigarros), 4, 0)));
               }
               else
               {
                  A358NPacienteCigarros = (short)(context.localUtil.CToN( cgiGet( edtNPacienteCigarros_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358NPacienteCigarros", StringUtil.LTrim( StringUtil.Str( (decimal)(A358NPacienteCigarros), 4, 0)));
               }
               if ( ( ( ((StringUtil.StrCmp(cgiGet( chkNPacienteAlcohol_Internalname), "1")==0) ? 1 : 0) < 0 ) ) || ( ( ((StringUtil.StrCmp(cgiGet( chkNPacienteAlcohol_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "NPACIENTEALCOHOL");
                  AnyError = 1 ;
                  GX_FocusControl = chkNPacienteAlcohol_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A359NPacienteAlcohol = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359NPacienteAlcohol", StringUtil.Str( (decimal)(A359NPacienteAlcohol), 1, 0));
               }
               else
               {
                  A359NPacienteAlcohol = (short)(((StringUtil.StrCmp(cgiGet( chkNPacienteAlcohol_Internalname), "1")==0) ? 1 : 0)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359NPacienteAlcohol", StringUtil.Str( (decimal)(A359NPacienteAlcohol), 1, 0));
               }
               A360NPacienteOtros = cgiGet( edtNPacienteOtros_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360NPacienteOtros", A360NPacienteOtros);
               if ( context.localUtil.VCDate( cgiGet( edtNPacienteFecha_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha_Registro"}), 1, "NPACIENTEFECHA");
                  AnyError = 1 ;
                  GX_FocusControl = edtNPacienteFecha_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A361NPacienteFecha = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361NPacienteFecha", context.localUtil.Format(A361NPacienteFecha, "99/99/99"));
               }
               else
               {
                  A361NPacienteFecha = context.localUtil.CToD( cgiGet( edtNPacienteFecha_Internalname), 2) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361NPacienteFecha", context.localUtil.Format(A361NPacienteFecha, "99/99/99"));
               }
               A362NPacienteHora = cgiGet( edtNPacienteHora_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362NPacienteHora", A362NPacienteHora);
               A4UsuarioCodigo = cgiGet( edtUsuarioCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
               A144TipoPacCodigo = cgiGet( edtTipoPacCodigo_Internalname) ;
               n144TipoPacCodigo = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144TipoPacCodigo", A144TipoPacCodigo);
               n144TipoPacCodigo = (String.IsNullOrEmpty(StringUtil.RTrim( A144TipoPacCodigo)) ? true : false) ;
               A317VendedorCodigo = cgiGet( edtVendedorCodigo_Internalname) ;
               n317VendedorCodigo = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317VendedorCodigo", A317VendedorCodigo);
               n317VendedorCodigo = (String.IsNullOrEmpty(StringUtil.RTrim( A317VendedorCodigo)) ? true : false) ;
               cmbNPacienteEstatus.CurrentValue = cgiGet( cmbNPacienteEstatus_Internalname) ;
               A364NPacienteEstatus = (short)(NumberUtil.Val( cgiGet( cmbNPacienteEstatus_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364NPacienteEstatus", StringUtil.Str( (decimal)(A364NPacienteEstatus), 1, 0));
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z327NPacienteId = (int)(context.localUtil.CToN( cgiGet( "Z327NPacienteId"), ".", ",")) ;
               Z328NPacienteNombre1 = cgiGet( "Z328NPacienteNombre1") ;
               Z329NPacienteNombre2 = cgiGet( "Z329NPacienteNombre2") ;
               Z330NPacienteApellido1 = cgiGet( "Z330NPacienteApellido1") ;
               Z331NPacienteApellido2 = cgiGet( "Z331NPacienteApellido2") ;
               Z332NPacienteApellido3 = cgiGet( "Z332NPacienteApellido3") ;
               Z333NPacienteFechaNac = context.localUtil.CToD( cgiGet( "Z333NPacienteFechaNac"), 0) ;
               Z334NPacienteSexo = cgiGet( "Z334NPacienteSexo") ;
               Z335NPacienteEstatura = context.localUtil.CToN( cgiGet( "Z335NPacienteEstatura"), ".", ",") ;
               Z336NPacienteEstaturaEn = cgiGet( "Z336NPacienteEstaturaEn") ;
               Z337NPacientePeso = context.localUtil.CToN( cgiGet( "Z337NPacientePeso"), ".", ",") ;
               Z338NPacientePesoEn = cgiGet( "Z338NPacientePesoEn") ;
               Z339NPacienteDireccion = cgiGet( "Z339NPacienteDireccion") ;
               Z340NPacienteCorreo = cgiGet( "Z340NPacienteCorreo") ;
               Z341NPacienteFacebook = cgiGet( "Z341NPacienteFacebook") ;
               Z342NPacienteTelefono = cgiGet( "Z342NPacienteTelefono") ;
               Z343NPacienteCelular = cgiGet( "Z343NPacienteCelular") ;
               Z344NPacienteEnfermedad = cgiGet( "Z344NPacienteEnfermedad") ;
               Z345NPacienteMedicamento = cgiGet( "Z345NPacienteMedicamento") ;
               Z346NPacienteOperacion = cgiGet( "Z346NPacienteOperacion") ;
               Z347NPacienteAlergia = cgiGet( "Z347NPacienteAlergia") ;
               Z348NPacienteGesta = (short)(context.localUtil.CToN( cgiGet( "Z348NPacienteGesta"), ".", ",")) ;
               Z349NPacienteParto = (short)(context.localUtil.CToN( cgiGet( "Z349NPacienteParto"), ".", ",")) ;
               Z350NPacienteCesarea = (short)(context.localUtil.CToN( cgiGet( "Z350NPacienteCesarea"), ".", ",")) ;
               Z351NPacienteAborto = (short)(context.localUtil.CToN( cgiGet( "Z351NPacienteAborto"), ".", ",")) ;
               Z352NPacienteAnestesiaGeneral = (short)(context.localUtil.CToN( cgiGet( "Z352NPacienteAnestesiaGeneral"), ".", ",")) ;
               Z353NPacienteAnestesiaEpidural = (short)(context.localUtil.CToN( cgiGet( "Z353NPacienteAnestesiaEpidural"), ".", ",")) ;
               Z354NPacienteAnestesiaRaquidea = (short)(context.localUtil.CToN( cgiGet( "Z354NPacienteAnestesiaRaquidea"), ".", ",")) ;
               Z355NPacienteAnestesiaOtro = cgiGet( "Z355NPacienteAnestesiaOtro") ;
               Z356NPacienteAnestesiaComplica = cgiGet( "Z356NPacienteAnestesiaComplica") ;
               Z357NPacienteFuma = (short)(context.localUtil.CToN( cgiGet( "Z357NPacienteFuma"), ".", ",")) ;
               Z358NPacienteCigarros = (short)(context.localUtil.CToN( cgiGet( "Z358NPacienteCigarros"), ".", ",")) ;
               Z359NPacienteAlcohol = (short)(context.localUtil.CToN( cgiGet( "Z359NPacienteAlcohol"), ".", ",")) ;
               Z360NPacienteOtros = cgiGet( "Z360NPacienteOtros") ;
               Z361NPacienteFecha = context.localUtil.CToD( cgiGet( "Z361NPacienteFecha"), 0) ;
               Z362NPacienteHora = cgiGet( "Z362NPacienteHora") ;
               Z364NPacienteEstatus = (short)(context.localUtil.CToN( cgiGet( "Z364NPacienteEstatus"), ".", ",")) ;
               Z144TipoPacCodigo = cgiGet( "Z144TipoPacCodigo") ;
               n144TipoPacCodigo = (String.IsNullOrEmpty(StringUtil.RTrim( A144TipoPacCodigo)) ? true : false) ;
               Z313ProfesionId = (int)(context.localUtil.CToN( cgiGet( "Z313ProfesionId"), ".", ",")) ;
               Z315ReligionId = (int)(context.localUtil.CToN( cgiGet( "Z315ReligionId"), ".", ",")) ;
               Z317VendedorCodigo = cgiGet( "Z317VendedorCodigo") ;
               n317VendedorCodigo = (String.IsNullOrEmpty(StringUtil.RTrim( A317VendedorCodigo)) ? true : false) ;
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
                  A327NPacienteId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327NPacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A327NPacienteId), 9, 0)));
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
               InitAll1N75( ) ;
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
         DisableAttributes1N75( ) ;
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

      protected void ResetCaption1N0( )
      {
      }

      protected void ZM1N75( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z328NPacienteNombre1 = T001N3_A328NPacienteNombre1[0] ;
               Z329NPacienteNombre2 = T001N3_A329NPacienteNombre2[0] ;
               Z330NPacienteApellido1 = T001N3_A330NPacienteApellido1[0] ;
               Z331NPacienteApellido2 = T001N3_A331NPacienteApellido2[0] ;
               Z332NPacienteApellido3 = T001N3_A332NPacienteApellido3[0] ;
               Z333NPacienteFechaNac = T001N3_A333NPacienteFechaNac[0] ;
               Z334NPacienteSexo = T001N3_A334NPacienteSexo[0] ;
               Z335NPacienteEstatura = T001N3_A335NPacienteEstatura[0] ;
               Z336NPacienteEstaturaEn = T001N3_A336NPacienteEstaturaEn[0] ;
               Z337NPacientePeso = T001N3_A337NPacientePeso[0] ;
               Z338NPacientePesoEn = T001N3_A338NPacientePesoEn[0] ;
               Z339NPacienteDireccion = T001N3_A339NPacienteDireccion[0] ;
               Z340NPacienteCorreo = T001N3_A340NPacienteCorreo[0] ;
               Z341NPacienteFacebook = T001N3_A341NPacienteFacebook[0] ;
               Z342NPacienteTelefono = T001N3_A342NPacienteTelefono[0] ;
               Z343NPacienteCelular = T001N3_A343NPacienteCelular[0] ;
               Z344NPacienteEnfermedad = T001N3_A344NPacienteEnfermedad[0] ;
               Z345NPacienteMedicamento = T001N3_A345NPacienteMedicamento[0] ;
               Z346NPacienteOperacion = T001N3_A346NPacienteOperacion[0] ;
               Z347NPacienteAlergia = T001N3_A347NPacienteAlergia[0] ;
               Z348NPacienteGesta = T001N3_A348NPacienteGesta[0] ;
               Z349NPacienteParto = T001N3_A349NPacienteParto[0] ;
               Z350NPacienteCesarea = T001N3_A350NPacienteCesarea[0] ;
               Z351NPacienteAborto = T001N3_A351NPacienteAborto[0] ;
               Z352NPacienteAnestesiaGeneral = T001N3_A352NPacienteAnestesiaGeneral[0] ;
               Z353NPacienteAnestesiaEpidural = T001N3_A353NPacienteAnestesiaEpidural[0] ;
               Z354NPacienteAnestesiaRaquidea = T001N3_A354NPacienteAnestesiaRaquidea[0] ;
               Z355NPacienteAnestesiaOtro = T001N3_A355NPacienteAnestesiaOtro[0] ;
               Z356NPacienteAnestesiaComplica = T001N3_A356NPacienteAnestesiaComplica[0] ;
               Z357NPacienteFuma = T001N3_A357NPacienteFuma[0] ;
               Z358NPacienteCigarros = T001N3_A358NPacienteCigarros[0] ;
               Z359NPacienteAlcohol = T001N3_A359NPacienteAlcohol[0] ;
               Z360NPacienteOtros = T001N3_A360NPacienteOtros[0] ;
               Z361NPacienteFecha = T001N3_A361NPacienteFecha[0] ;
               Z362NPacienteHora = T001N3_A362NPacienteHora[0] ;
               Z364NPacienteEstatus = T001N3_A364NPacienteEstatus[0] ;
               Z144TipoPacCodigo = T001N3_A144TipoPacCodigo[0] ;
               Z313ProfesionId = T001N3_A313ProfesionId[0] ;
               Z315ReligionId = T001N3_A315ReligionId[0] ;
               Z317VendedorCodigo = T001N3_A317VendedorCodigo[0] ;
               Z4UsuarioCodigo = T001N3_A4UsuarioCodigo[0] ;
            }
            else
            {
               Z328NPacienteNombre1 = A328NPacienteNombre1 ;
               Z329NPacienteNombre2 = A329NPacienteNombre2 ;
               Z330NPacienteApellido1 = A330NPacienteApellido1 ;
               Z331NPacienteApellido2 = A331NPacienteApellido2 ;
               Z332NPacienteApellido3 = A332NPacienteApellido3 ;
               Z333NPacienteFechaNac = A333NPacienteFechaNac ;
               Z334NPacienteSexo = A334NPacienteSexo ;
               Z335NPacienteEstatura = A335NPacienteEstatura ;
               Z336NPacienteEstaturaEn = A336NPacienteEstaturaEn ;
               Z337NPacientePeso = A337NPacientePeso ;
               Z338NPacientePesoEn = A338NPacientePesoEn ;
               Z339NPacienteDireccion = A339NPacienteDireccion ;
               Z340NPacienteCorreo = A340NPacienteCorreo ;
               Z341NPacienteFacebook = A341NPacienteFacebook ;
               Z342NPacienteTelefono = A342NPacienteTelefono ;
               Z343NPacienteCelular = A343NPacienteCelular ;
               Z344NPacienteEnfermedad = A344NPacienteEnfermedad ;
               Z345NPacienteMedicamento = A345NPacienteMedicamento ;
               Z346NPacienteOperacion = A346NPacienteOperacion ;
               Z347NPacienteAlergia = A347NPacienteAlergia ;
               Z348NPacienteGesta = A348NPacienteGesta ;
               Z349NPacienteParto = A349NPacienteParto ;
               Z350NPacienteCesarea = A350NPacienteCesarea ;
               Z351NPacienteAborto = A351NPacienteAborto ;
               Z352NPacienteAnestesiaGeneral = A352NPacienteAnestesiaGeneral ;
               Z353NPacienteAnestesiaEpidural = A353NPacienteAnestesiaEpidural ;
               Z354NPacienteAnestesiaRaquidea = A354NPacienteAnestesiaRaquidea ;
               Z355NPacienteAnestesiaOtro = A355NPacienteAnestesiaOtro ;
               Z356NPacienteAnestesiaComplica = A356NPacienteAnestesiaComplica ;
               Z357NPacienteFuma = A357NPacienteFuma ;
               Z358NPacienteCigarros = A358NPacienteCigarros ;
               Z359NPacienteAlcohol = A359NPacienteAlcohol ;
               Z360NPacienteOtros = A360NPacienteOtros ;
               Z361NPacienteFecha = A361NPacienteFecha ;
               Z362NPacienteHora = A362NPacienteHora ;
               Z364NPacienteEstatus = A364NPacienteEstatus ;
               Z144TipoPacCodigo = A144TipoPacCodigo ;
               Z313ProfesionId = A313ProfesionId ;
               Z315ReligionId = A315ReligionId ;
               Z317VendedorCodigo = A317VendedorCodigo ;
               Z4UsuarioCodigo = A4UsuarioCodigo ;
            }
         }
         if ( GX_JID == -3 )
         {
            Z327NPacienteId = A327NPacienteId ;
            Z328NPacienteNombre1 = A328NPacienteNombre1 ;
            Z329NPacienteNombre2 = A329NPacienteNombre2 ;
            Z330NPacienteApellido1 = A330NPacienteApellido1 ;
            Z331NPacienteApellido2 = A331NPacienteApellido2 ;
            Z332NPacienteApellido3 = A332NPacienteApellido3 ;
            Z333NPacienteFechaNac = A333NPacienteFechaNac ;
            Z334NPacienteSexo = A334NPacienteSexo ;
            Z335NPacienteEstatura = A335NPacienteEstatura ;
            Z336NPacienteEstaturaEn = A336NPacienteEstaturaEn ;
            Z337NPacientePeso = A337NPacientePeso ;
            Z338NPacientePesoEn = A338NPacientePesoEn ;
            Z339NPacienteDireccion = A339NPacienteDireccion ;
            Z340NPacienteCorreo = A340NPacienteCorreo ;
            Z341NPacienteFacebook = A341NPacienteFacebook ;
            Z342NPacienteTelefono = A342NPacienteTelefono ;
            Z343NPacienteCelular = A343NPacienteCelular ;
            Z344NPacienteEnfermedad = A344NPacienteEnfermedad ;
            Z345NPacienteMedicamento = A345NPacienteMedicamento ;
            Z346NPacienteOperacion = A346NPacienteOperacion ;
            Z347NPacienteAlergia = A347NPacienteAlergia ;
            Z348NPacienteGesta = A348NPacienteGesta ;
            Z349NPacienteParto = A349NPacienteParto ;
            Z350NPacienteCesarea = A350NPacienteCesarea ;
            Z351NPacienteAborto = A351NPacienteAborto ;
            Z352NPacienteAnestesiaGeneral = A352NPacienteAnestesiaGeneral ;
            Z353NPacienteAnestesiaEpidural = A353NPacienteAnestesiaEpidural ;
            Z354NPacienteAnestesiaRaquidea = A354NPacienteAnestesiaRaquidea ;
            Z355NPacienteAnestesiaOtro = A355NPacienteAnestesiaOtro ;
            Z356NPacienteAnestesiaComplica = A356NPacienteAnestesiaComplica ;
            Z357NPacienteFuma = A357NPacienteFuma ;
            Z358NPacienteCigarros = A358NPacienteCigarros ;
            Z359NPacienteAlcohol = A359NPacienteAlcohol ;
            Z360NPacienteOtros = A360NPacienteOtros ;
            Z361NPacienteFecha = A361NPacienteFecha ;
            Z362NPacienteHora = A362NPacienteHora ;
            Z364NPacienteEstatus = A364NPacienteEstatus ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z144TipoPacCodigo = A144TipoPacCodigo ;
            Z313ProfesionId = A313ProfesionId ;
            Z315ReligionId = A315ReligionId ;
            Z317VendedorCodigo = A317VendedorCodigo ;
            Z4UsuarioCodigo = A4UsuarioCodigo ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_41_313_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0200.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"PROFESIONID"+"'), id:'"+"PROFESIONID"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
         imgprompt_41_315_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0210.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"RELIGIONID"+"'), id:'"+"RELIGIONID"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
         imgprompt_4_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0020.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USUARIOCODIGO"+"'), id:'"+"USUARIOCODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
         imgprompt_41_144_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0140.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"TIPOPACCODIGO"+"'), id:'"+"TIPOPACCODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
         imgprompt_41_317_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0220.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"VENDEDORCODIGO"+"'), id:'"+"VENDEDORCODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
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

      protected void Load1N75( )
      {
         /* Using cursor T001N9 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A327NPacienteId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound75 = 1 ;
            A328NPacienteNombre1 = T001N9_A328NPacienteNombre1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328NPacienteNombre1", A328NPacienteNombre1);
            A329NPacienteNombre2 = T001N9_A329NPacienteNombre2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329NPacienteNombre2", A329NPacienteNombre2);
            A330NPacienteApellido1 = T001N9_A330NPacienteApellido1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A330NPacienteApellido1", A330NPacienteApellido1);
            A331NPacienteApellido2 = T001N9_A331NPacienteApellido2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331NPacienteApellido2", A331NPacienteApellido2);
            A332NPacienteApellido3 = T001N9_A332NPacienteApellido3[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332NPacienteApellido3", A332NPacienteApellido3);
            A333NPacienteFechaNac = T001N9_A333NPacienteFechaNac[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333NPacienteFechaNac", context.localUtil.Format(A333NPacienteFechaNac, "99/99/99"));
            A334NPacienteSexo = T001N9_A334NPacienteSexo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A334NPacienteSexo", A334NPacienteSexo);
            A335NPacienteEstatura = T001N9_A335NPacienteEstatura[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A335NPacienteEstatura", StringUtil.LTrim( StringUtil.Str( A335NPacienteEstatura, 17, 2)));
            A336NPacienteEstaturaEn = T001N9_A336NPacienteEstaturaEn[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A336NPacienteEstaturaEn", A336NPacienteEstaturaEn);
            A337NPacientePeso = T001N9_A337NPacientePeso[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A337NPacientePeso", StringUtil.LTrim( StringUtil.Str( A337NPacientePeso, 17, 2)));
            A338NPacientePesoEn = T001N9_A338NPacientePesoEn[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A338NPacientePesoEn", A338NPacientePesoEn);
            A339NPacienteDireccion = T001N9_A339NPacienteDireccion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A339NPacienteDireccion", A339NPacienteDireccion);
            A340NPacienteCorreo = T001N9_A340NPacienteCorreo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A340NPacienteCorreo", A340NPacienteCorreo);
            A341NPacienteFacebook = T001N9_A341NPacienteFacebook[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A341NPacienteFacebook", A341NPacienteFacebook);
            A342NPacienteTelefono = T001N9_A342NPacienteTelefono[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A342NPacienteTelefono", A342NPacienteTelefono);
            A343NPacienteCelular = T001N9_A343NPacienteCelular[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A343NPacienteCelular", A343NPacienteCelular);
            A344NPacienteEnfermedad = T001N9_A344NPacienteEnfermedad[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A344NPacienteEnfermedad", A344NPacienteEnfermedad);
            A345NPacienteMedicamento = T001N9_A345NPacienteMedicamento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345NPacienteMedicamento", A345NPacienteMedicamento);
            A346NPacienteOperacion = T001N9_A346NPacienteOperacion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A346NPacienteOperacion", A346NPacienteOperacion);
            A347NPacienteAlergia = T001N9_A347NPacienteAlergia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347NPacienteAlergia", A347NPacienteAlergia);
            A348NPacienteGesta = T001N9_A348NPacienteGesta[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348NPacienteGesta", StringUtil.LTrim( StringUtil.Str( (decimal)(A348NPacienteGesta), 4, 0)));
            A349NPacienteParto = T001N9_A349NPacienteParto[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349NPacienteParto", StringUtil.LTrim( StringUtil.Str( (decimal)(A349NPacienteParto), 4, 0)));
            A350NPacienteCesarea = T001N9_A350NPacienteCesarea[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350NPacienteCesarea", StringUtil.LTrim( StringUtil.Str( (decimal)(A350NPacienteCesarea), 4, 0)));
            A351NPacienteAborto = T001N9_A351NPacienteAborto[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A351NPacienteAborto", StringUtil.LTrim( StringUtil.Str( (decimal)(A351NPacienteAborto), 4, 0)));
            A352NPacienteAnestesiaGeneral = T001N9_A352NPacienteAnestesiaGeneral[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A352NPacienteAnestesiaGeneral", StringUtil.Str( (decimal)(A352NPacienteAnestesiaGeneral), 1, 0));
            A353NPacienteAnestesiaEpidural = T001N9_A353NPacienteAnestesiaEpidural[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353NPacienteAnestesiaEpidural", StringUtil.Str( (decimal)(A353NPacienteAnestesiaEpidural), 1, 0));
            A354NPacienteAnestesiaRaquidea = T001N9_A354NPacienteAnestesiaRaquidea[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A354NPacienteAnestesiaRaquidea", StringUtil.Str( (decimal)(A354NPacienteAnestesiaRaquidea), 1, 0));
            A355NPacienteAnestesiaOtro = T001N9_A355NPacienteAnestesiaOtro[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A355NPacienteAnestesiaOtro", A355NPacienteAnestesiaOtro);
            A356NPacienteAnestesiaComplica = T001N9_A356NPacienteAnestesiaComplica[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A356NPacienteAnestesiaComplica", A356NPacienteAnestesiaComplica);
            A357NPacienteFuma = T001N9_A357NPacienteFuma[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A357NPacienteFuma", StringUtil.Str( (decimal)(A357NPacienteFuma), 1, 0));
            A358NPacienteCigarros = T001N9_A358NPacienteCigarros[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358NPacienteCigarros", StringUtil.LTrim( StringUtil.Str( (decimal)(A358NPacienteCigarros), 4, 0)));
            A359NPacienteAlcohol = T001N9_A359NPacienteAlcohol[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359NPacienteAlcohol", StringUtil.Str( (decimal)(A359NPacienteAlcohol), 1, 0));
            A360NPacienteOtros = T001N9_A360NPacienteOtros[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360NPacienteOtros", A360NPacienteOtros);
            A361NPacienteFecha = T001N9_A361NPacienteFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361NPacienteFecha", context.localUtil.Format(A361NPacienteFecha, "99/99/99"));
            A362NPacienteHora = T001N9_A362NPacienteHora[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362NPacienteHora", A362NPacienteHora);
            A364NPacienteEstatus = T001N9_A364NPacienteEstatus[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364NPacienteEstatus", StringUtil.Str( (decimal)(A364NPacienteEstatus), 1, 0));
            A144TipoPacCodigo = T001N9_A144TipoPacCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144TipoPacCodigo", A144TipoPacCodigo);
            n144TipoPacCodigo = T001N9_n144TipoPacCodigo[0] ;
            A313ProfesionId = T001N9_A313ProfesionId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313ProfesionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A313ProfesionId), 9, 0)));
            A315ReligionId = T001N9_A315ReligionId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315ReligionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A315ReligionId), 9, 0)));
            A317VendedorCodigo = T001N9_A317VendedorCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317VendedorCodigo", A317VendedorCodigo);
            n317VendedorCodigo = T001N9_n317VendedorCodigo[0] ;
            A4UsuarioCodigo = T001N9_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            ZM1N75( -3) ;
         }
         pr_default.close(7);
         OnLoadActions1N75( ) ;
      }

      protected void OnLoadActions1N75( )
      {
      }

      protected void CheckExtendedTable1N75( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T001N4 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo, n144TipoPacCodigo, A144TipoPacCodigo});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A41ClinicaCodigo)) || String.IsNullOrEmpty(StringUtil.RTrim( A144TipoPacCodigo)) ) )
            {
               AnyError41 = 1 ;
               AnyError144 = 1 ;
               GX_msglist.addItem("No existe 'Tipos de Pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         if ( ( AnyError41 == 0 ) && ( AnyError144 == 0 ) )
         {
         }
         pr_default.close(2);
         /* Using cursor T001N5 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A313ProfesionId});
         if ( (pr_default.getStatus(3) == 101) )
         {
            AnyError41 = 1 ;
            AnyError313 = 1 ;
            GX_msglist.addItem("No existe 'Profesiones existentes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError313 == 0 ) )
         {
         }
         pr_default.close(3);
         /* Using cursor T001N6 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo, A315ReligionId});
         if ( (pr_default.getStatus(4) == 101) )
         {
            AnyError41 = 1 ;
            AnyError315 = 1 ;
            GX_msglist.addItem("No existe 'Religiones'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError315 == 0 ) )
         {
         }
         pr_default.close(4);
         /* Using cursor T001N7 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, n317VendedorCodigo, A317VendedorCodigo});
         if ( (pr_default.getStatus(5) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A41ClinicaCodigo)) || String.IsNullOrEmpty(StringUtil.RTrim( A317VendedorCodigo)) ) )
            {
               AnyError41 = 1 ;
               AnyError317 = 1 ;
               GX_msglist.addItem("No existe 'Vendedores'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         if ( ( AnyError41 == 0 ) && ( AnyError317 == 0 ) )
         {
         }
         pr_default.close(5);
         if ( ! ( (DateTime.MinValue==A333NPacienteFechaNac) || ( A333NPacienteFechaNac >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha_Nacimiento fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A361NPacienteFecha) || ( A361NPacienteFecha >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha_Registro fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         /* Using cursor T001N8 */
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

      protected void CloseExtendedTableCursors1N75( )
      {
         pr_default.close(2);
         pr_default.close(3);
         pr_default.close(4);
         pr_default.close(5);
         pr_default.close(6);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_4( String A41ClinicaCodigo ,
                               String A144TipoPacCodigo )
      {
         /* Using cursor T001N10 */
         pr_default.execute(8, new Object[] {A41ClinicaCodigo, n144TipoPacCodigo, A144TipoPacCodigo});
         if ( (pr_default.getStatus(8) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A41ClinicaCodigo)) || String.IsNullOrEmpty(StringUtil.RTrim( A144TipoPacCodigo)) ) )
            {
               AnyError41 = 1 ;
               AnyError144 = 1 ;
               GX_msglist.addItem("No existe 'Tipos de Pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         if ( ( AnyError41 == 0 ) && ( AnyError144 == 0 ) )
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

      protected void gxLoad_5( String A41ClinicaCodigo ,
                               int A313ProfesionId )
      {
         /* Using cursor T001N11 */
         pr_default.execute(9, new Object[] {A41ClinicaCodigo, A313ProfesionId});
         if ( (pr_default.getStatus(9) == 101) )
         {
            AnyError41 = 1 ;
            AnyError313 = 1 ;
            GX_msglist.addItem("No existe 'Profesiones existentes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError313 == 0 ) )
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
                               int A315ReligionId )
      {
         /* Using cursor T001N12 */
         pr_default.execute(10, new Object[] {A41ClinicaCodigo, A315ReligionId});
         if ( (pr_default.getStatus(10) == 101) )
         {
            AnyError41 = 1 ;
            AnyError315 = 1 ;
            GX_msglist.addItem("No existe 'Religiones'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError315 == 0 ) )
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
                               String A317VendedorCodigo )
      {
         /* Using cursor T001N13 */
         pr_default.execute(11, new Object[] {A41ClinicaCodigo, n317VendedorCodigo, A317VendedorCodigo});
         if ( (pr_default.getStatus(11) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A41ClinicaCodigo)) || String.IsNullOrEmpty(StringUtil.RTrim( A317VendedorCodigo)) ) )
            {
               AnyError41 = 1 ;
               AnyError317 = 1 ;
               GX_msglist.addItem("No existe 'Vendedores'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         if ( ( AnyError41 == 0 ) && ( AnyError317 == 0 ) )
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

      protected void gxLoad_8( String A4UsuarioCodigo )
      {
         /* Using cursor T001N14 */
         pr_default.execute(12, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(12) == 101) )
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
         if ( (pr_default.getStatus(12) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(12);
      }

      protected void GetKey1N75( )
      {
         /* Using cursor T001N15 */
         pr_default.execute(13, new Object[] {A41ClinicaCodigo, A327NPacienteId});
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound75 = 1 ;
         }
         else
         {
            RcdFound75 = 0 ;
         }
         pr_default.close(13);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001N3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A327NPacienteId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1N75( 3) ;
            RcdFound75 = 1 ;
            A327NPacienteId = T001N3_A327NPacienteId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327NPacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A327NPacienteId), 9, 0)));
            A328NPacienteNombre1 = T001N3_A328NPacienteNombre1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328NPacienteNombre1", A328NPacienteNombre1);
            A329NPacienteNombre2 = T001N3_A329NPacienteNombre2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329NPacienteNombre2", A329NPacienteNombre2);
            A330NPacienteApellido1 = T001N3_A330NPacienteApellido1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A330NPacienteApellido1", A330NPacienteApellido1);
            A331NPacienteApellido2 = T001N3_A331NPacienteApellido2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331NPacienteApellido2", A331NPacienteApellido2);
            A332NPacienteApellido3 = T001N3_A332NPacienteApellido3[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332NPacienteApellido3", A332NPacienteApellido3);
            A333NPacienteFechaNac = T001N3_A333NPacienteFechaNac[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333NPacienteFechaNac", context.localUtil.Format(A333NPacienteFechaNac, "99/99/99"));
            A334NPacienteSexo = T001N3_A334NPacienteSexo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A334NPacienteSexo", A334NPacienteSexo);
            A335NPacienteEstatura = T001N3_A335NPacienteEstatura[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A335NPacienteEstatura", StringUtil.LTrim( StringUtil.Str( A335NPacienteEstatura, 17, 2)));
            A336NPacienteEstaturaEn = T001N3_A336NPacienteEstaturaEn[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A336NPacienteEstaturaEn", A336NPacienteEstaturaEn);
            A337NPacientePeso = T001N3_A337NPacientePeso[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A337NPacientePeso", StringUtil.LTrim( StringUtil.Str( A337NPacientePeso, 17, 2)));
            A338NPacientePesoEn = T001N3_A338NPacientePesoEn[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A338NPacientePesoEn", A338NPacientePesoEn);
            A339NPacienteDireccion = T001N3_A339NPacienteDireccion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A339NPacienteDireccion", A339NPacienteDireccion);
            A340NPacienteCorreo = T001N3_A340NPacienteCorreo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A340NPacienteCorreo", A340NPacienteCorreo);
            A341NPacienteFacebook = T001N3_A341NPacienteFacebook[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A341NPacienteFacebook", A341NPacienteFacebook);
            A342NPacienteTelefono = T001N3_A342NPacienteTelefono[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A342NPacienteTelefono", A342NPacienteTelefono);
            A343NPacienteCelular = T001N3_A343NPacienteCelular[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A343NPacienteCelular", A343NPacienteCelular);
            A344NPacienteEnfermedad = T001N3_A344NPacienteEnfermedad[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A344NPacienteEnfermedad", A344NPacienteEnfermedad);
            A345NPacienteMedicamento = T001N3_A345NPacienteMedicamento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345NPacienteMedicamento", A345NPacienteMedicamento);
            A346NPacienteOperacion = T001N3_A346NPacienteOperacion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A346NPacienteOperacion", A346NPacienteOperacion);
            A347NPacienteAlergia = T001N3_A347NPacienteAlergia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347NPacienteAlergia", A347NPacienteAlergia);
            A348NPacienteGesta = T001N3_A348NPacienteGesta[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348NPacienteGesta", StringUtil.LTrim( StringUtil.Str( (decimal)(A348NPacienteGesta), 4, 0)));
            A349NPacienteParto = T001N3_A349NPacienteParto[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349NPacienteParto", StringUtil.LTrim( StringUtil.Str( (decimal)(A349NPacienteParto), 4, 0)));
            A350NPacienteCesarea = T001N3_A350NPacienteCesarea[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350NPacienteCesarea", StringUtil.LTrim( StringUtil.Str( (decimal)(A350NPacienteCesarea), 4, 0)));
            A351NPacienteAborto = T001N3_A351NPacienteAborto[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A351NPacienteAborto", StringUtil.LTrim( StringUtil.Str( (decimal)(A351NPacienteAborto), 4, 0)));
            A352NPacienteAnestesiaGeneral = T001N3_A352NPacienteAnestesiaGeneral[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A352NPacienteAnestesiaGeneral", StringUtil.Str( (decimal)(A352NPacienteAnestesiaGeneral), 1, 0));
            A353NPacienteAnestesiaEpidural = T001N3_A353NPacienteAnestesiaEpidural[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353NPacienteAnestesiaEpidural", StringUtil.Str( (decimal)(A353NPacienteAnestesiaEpidural), 1, 0));
            A354NPacienteAnestesiaRaquidea = T001N3_A354NPacienteAnestesiaRaquidea[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A354NPacienteAnestesiaRaquidea", StringUtil.Str( (decimal)(A354NPacienteAnestesiaRaquidea), 1, 0));
            A355NPacienteAnestesiaOtro = T001N3_A355NPacienteAnestesiaOtro[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A355NPacienteAnestesiaOtro", A355NPacienteAnestesiaOtro);
            A356NPacienteAnestesiaComplica = T001N3_A356NPacienteAnestesiaComplica[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A356NPacienteAnestesiaComplica", A356NPacienteAnestesiaComplica);
            A357NPacienteFuma = T001N3_A357NPacienteFuma[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A357NPacienteFuma", StringUtil.Str( (decimal)(A357NPacienteFuma), 1, 0));
            A358NPacienteCigarros = T001N3_A358NPacienteCigarros[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358NPacienteCigarros", StringUtil.LTrim( StringUtil.Str( (decimal)(A358NPacienteCigarros), 4, 0)));
            A359NPacienteAlcohol = T001N3_A359NPacienteAlcohol[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359NPacienteAlcohol", StringUtil.Str( (decimal)(A359NPacienteAlcohol), 1, 0));
            A360NPacienteOtros = T001N3_A360NPacienteOtros[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360NPacienteOtros", A360NPacienteOtros);
            A361NPacienteFecha = T001N3_A361NPacienteFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361NPacienteFecha", context.localUtil.Format(A361NPacienteFecha, "99/99/99"));
            A362NPacienteHora = T001N3_A362NPacienteHora[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362NPacienteHora", A362NPacienteHora);
            A364NPacienteEstatus = T001N3_A364NPacienteEstatus[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364NPacienteEstatus", StringUtil.Str( (decimal)(A364NPacienteEstatus), 1, 0));
            A41ClinicaCodigo = T001N3_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A144TipoPacCodigo = T001N3_A144TipoPacCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144TipoPacCodigo", A144TipoPacCodigo);
            n144TipoPacCodigo = T001N3_n144TipoPacCodigo[0] ;
            A313ProfesionId = T001N3_A313ProfesionId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313ProfesionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A313ProfesionId), 9, 0)));
            A315ReligionId = T001N3_A315ReligionId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315ReligionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A315ReligionId), 9, 0)));
            A317VendedorCodigo = T001N3_A317VendedorCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317VendedorCodigo", A317VendedorCodigo);
            n317VendedorCodigo = T001N3_n317VendedorCodigo[0] ;
            A4UsuarioCodigo = T001N3_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z327NPacienteId = A327NPacienteId ;
            sMode75 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1N75( ) ;
            Gx_mode = sMode75 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound75 = 0 ;
            InitializeNonKey1N75( ) ;
            sMode75 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode75 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1N75( ) ;
         if ( RcdFound75 == 0 )
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
         RcdFound75 = 0 ;
         /* Using cursor T001N16 */
         pr_default.execute(14, new Object[] {A41ClinicaCodigo, A327NPacienteId});
         if ( (pr_default.getStatus(14) != 101) )
         {
            while ( (pr_default.getStatus(14) != 101) && ( ( StringUtil.StrCmp(T001N16_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001N16_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001N16_A327NPacienteId[0] < A327NPacienteId ) ) )
            {
               pr_default.readNext(14);
            }
            if ( (pr_default.getStatus(14) != 101) && ( ( StringUtil.StrCmp(T001N16_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001N16_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001N16_A327NPacienteId[0] > A327NPacienteId ) ) )
            {
               A41ClinicaCodigo = T001N16_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A327NPacienteId = T001N16_A327NPacienteId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327NPacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A327NPacienteId), 9, 0)));
               RcdFound75 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound75 = 0 ;
         /* Using cursor T001N17 */
         pr_default.execute(15, new Object[] {A41ClinicaCodigo, A327NPacienteId});
         if ( (pr_default.getStatus(15) != 101) )
         {
            while ( (pr_default.getStatus(15) != 101) && ( ( StringUtil.StrCmp(T001N17_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001N17_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001N17_A327NPacienteId[0] > A327NPacienteId ) ) )
            {
               pr_default.readNext(15);
            }
            if ( (pr_default.getStatus(15) != 101) && ( ( StringUtil.StrCmp(T001N17_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001N17_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001N17_A327NPacienteId[0] < A327NPacienteId ) ) )
            {
               A41ClinicaCodigo = T001N17_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A327NPacienteId = T001N17_A327NPacienteId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327NPacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A327NPacienteId), 9, 0)));
               RcdFound75 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1N75( ) ;
         if ( RcdFound75 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A327NPacienteId != Z327NPacienteId ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A327NPacienteId = Z327NPacienteId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327NPacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A327NPacienteId), 9, 0)));
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
               Update1N75( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A327NPacienteId != Z327NPacienteId ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert1N75( ) ;
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
                  Insert1N75( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A327NPacienteId != Z327NPacienteId ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A327NPacienteId = Z327NPacienteId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327NPacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A327NPacienteId), 9, 0)));
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
         if ( RcdFound75 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtNPacienteNombre1_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1N75( ) ;
         if ( RcdFound75 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtNPacienteNombre1_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1N75( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound75 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtNPacienteNombre1_Internalname ;
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
         if ( RcdFound75 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtNPacienteNombre1_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1N75( ) ;
         if ( RcdFound75 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound75 != 0 )
            {
               ScanNext1N75( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtNPacienteNombre1_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1N75( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1N75( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001N18 */
            pr_default.execute(16, new Object[] {A41ClinicaCodigo, A327NPacienteId});
            if ( (pr_default.getStatus(16) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"NotaPaciente"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(16) == 101) || ( StringUtil.StrCmp(Z328NPacienteNombre1, T001N18_A328NPacienteNombre1[0]) != 0 ) || ( StringUtil.StrCmp(Z329NPacienteNombre2, T001N18_A329NPacienteNombre2[0]) != 0 ) || ( StringUtil.StrCmp(Z330NPacienteApellido1, T001N18_A330NPacienteApellido1[0]) != 0 ) || ( StringUtil.StrCmp(Z331NPacienteApellido2, T001N18_A331NPacienteApellido2[0]) != 0 ) || ( StringUtil.StrCmp(Z332NPacienteApellido3, T001N18_A332NPacienteApellido3[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z333NPacienteFechaNac != T001N18_A333NPacienteFechaNac[0] ) || ( StringUtil.StrCmp(Z334NPacienteSexo, T001N18_A334NPacienteSexo[0]) != 0 ) || ( Z335NPacienteEstatura != T001N18_A335NPacienteEstatura[0] ) || ( StringUtil.StrCmp(Z336NPacienteEstaturaEn, T001N18_A336NPacienteEstaturaEn[0]) != 0 ) || ( Z337NPacientePeso != T001N18_A337NPacientePeso[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z338NPacientePesoEn, T001N18_A338NPacientePesoEn[0]) != 0 ) || ( StringUtil.StrCmp(Z339NPacienteDireccion, T001N18_A339NPacienteDireccion[0]) != 0 ) || ( StringUtil.StrCmp(Z340NPacienteCorreo, T001N18_A340NPacienteCorreo[0]) != 0 ) || ( StringUtil.StrCmp(Z341NPacienteFacebook, T001N18_A341NPacienteFacebook[0]) != 0 ) || ( StringUtil.StrCmp(Z342NPacienteTelefono, T001N18_A342NPacienteTelefono[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z343NPacienteCelular, T001N18_A343NPacienteCelular[0]) != 0 ) || ( StringUtil.StrCmp(Z344NPacienteEnfermedad, T001N18_A344NPacienteEnfermedad[0]) != 0 ) || ( StringUtil.StrCmp(Z345NPacienteMedicamento, T001N18_A345NPacienteMedicamento[0]) != 0 ) || ( StringUtil.StrCmp(Z346NPacienteOperacion, T001N18_A346NPacienteOperacion[0]) != 0 ) || ( StringUtil.StrCmp(Z347NPacienteAlergia, T001N18_A347NPacienteAlergia[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z348NPacienteGesta != T001N18_A348NPacienteGesta[0] ) || ( Z349NPacienteParto != T001N18_A349NPacienteParto[0] ) || ( Z350NPacienteCesarea != T001N18_A350NPacienteCesarea[0] ) || ( Z351NPacienteAborto != T001N18_A351NPacienteAborto[0] ) || ( Z352NPacienteAnestesiaGeneral != T001N18_A352NPacienteAnestesiaGeneral[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z353NPacienteAnestesiaEpidural != T001N18_A353NPacienteAnestesiaEpidural[0] ) || ( Z354NPacienteAnestesiaRaquidea != T001N18_A354NPacienteAnestesiaRaquidea[0] ) || ( StringUtil.StrCmp(Z355NPacienteAnestesiaOtro, T001N18_A355NPacienteAnestesiaOtro[0]) != 0 ) || ( StringUtil.StrCmp(Z356NPacienteAnestesiaComplica, T001N18_A356NPacienteAnestesiaComplica[0]) != 0 ) || ( Z357NPacienteFuma != T001N18_A357NPacienteFuma[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z358NPacienteCigarros != T001N18_A358NPacienteCigarros[0] ) || ( Z359NPacienteAlcohol != T001N18_A359NPacienteAlcohol[0] ) || ( StringUtil.StrCmp(Z360NPacienteOtros, T001N18_A360NPacienteOtros[0]) != 0 ) || ( Z361NPacienteFecha != T001N18_A361NPacienteFecha[0] ) || ( StringUtil.StrCmp(Z362NPacienteHora, T001N18_A362NPacienteHora[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z364NPacienteEstatus != T001N18_A364NPacienteEstatus[0] ) || ( StringUtil.StrCmp(Z144TipoPacCodigo, T001N18_A144TipoPacCodigo[0]) != 0 ) || ( Z313ProfesionId != T001N18_A313ProfesionId[0] ) || ( Z315ReligionId != T001N18_A315ReligionId[0] ) || ( StringUtil.StrCmp(Z317VendedorCodigo, T001N18_A317VendedorCodigo[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z4UsuarioCodigo, T001N18_A4UsuarioCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"NotaPaciente"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1N75( )
      {
         BeforeValidate1N75( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1N75( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1N75( 0) ;
            CheckOptimisticConcurrency1N75( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1N75( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1N75( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001N19 */
                     pr_default.execute(17, new Object[] {A327NPacienteId, A328NPacienteNombre1, A329NPacienteNombre2, A330NPacienteApellido1, A331NPacienteApellido2, A332NPacienteApellido3, A333NPacienteFechaNac, A334NPacienteSexo, A335NPacienteEstatura, A336NPacienteEstaturaEn, A337NPacientePeso, A338NPacientePesoEn, A339NPacienteDireccion, A340NPacienteCorreo, A341NPacienteFacebook, A342NPacienteTelefono, A343NPacienteCelular, A344NPacienteEnfermedad, A345NPacienteMedicamento, A346NPacienteOperacion, A347NPacienteAlergia, A348NPacienteGesta, A349NPacienteParto, A350NPacienteCesarea, A351NPacienteAborto, A352NPacienteAnestesiaGeneral, A353NPacienteAnestesiaEpidural, A354NPacienteAnestesiaRaquidea, A355NPacienteAnestesiaOtro, A356NPacienteAnestesiaComplica, A357NPacienteFuma, A358NPacienteCigarros, A359NPacienteAlcohol, A360NPacienteOtros, A361NPacienteFecha, A362NPacienteHora, A364NPacienteEstatus, A41ClinicaCodigo, n144TipoPacCodigo, A144TipoPacCodigo, A313ProfesionId, A315ReligionId, n317VendedorCodigo, A317VendedorCodigo, A4UsuarioCodigo});
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
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                           ResetCaption1N0( ) ;
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
               Load1N75( ) ;
            }
            EndLevel1N75( ) ;
         }
         CloseExtendedTableCursors1N75( ) ;
      }

      protected void Update1N75( )
      {
         BeforeValidate1N75( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1N75( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1N75( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1N75( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1N75( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001N20 */
                     pr_default.execute(18, new Object[] {A328NPacienteNombre1, A329NPacienteNombre2, A330NPacienteApellido1, A331NPacienteApellido2, A332NPacienteApellido3, A333NPacienteFechaNac, A334NPacienteSexo, A335NPacienteEstatura, A336NPacienteEstaturaEn, A337NPacientePeso, A338NPacientePesoEn, A339NPacienteDireccion, A340NPacienteCorreo, A341NPacienteFacebook, A342NPacienteTelefono, A343NPacienteCelular, A344NPacienteEnfermedad, A345NPacienteMedicamento, A346NPacienteOperacion, A347NPacienteAlergia, A348NPacienteGesta, A349NPacienteParto, A350NPacienteCesarea, A351NPacienteAborto, A352NPacienteAnestesiaGeneral, A353NPacienteAnestesiaEpidural, A354NPacienteAnestesiaRaquidea, A355NPacienteAnestesiaOtro, A356NPacienteAnestesiaComplica, A357NPacienteFuma, A358NPacienteCigarros, A359NPacienteAlcohol, A360NPacienteOtros, A361NPacienteFecha, A362NPacienteHora, A364NPacienteEstatus, n144TipoPacCodigo, A144TipoPacCodigo, A313ProfesionId, A315ReligionId, n317VendedorCodigo, A317VendedorCodigo, A4UsuarioCodigo, A41ClinicaCodigo, A327NPacienteId});
                     pr_default.close(18);
                     if ( (pr_default.getStatus(18) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"NotaPaciente"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1N75( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                           ResetCaption1N0( ) ;
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
            EndLevel1N75( ) ;
         }
         CloseExtendedTableCursors1N75( ) ;
      }

      protected void DeferredUpdate1N75( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1N75( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1N75( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1N75( ) ;
            AfterConfirm1N75( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1N75( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001N21 */
                  pr_default.execute(19, new Object[] {A41ClinicaCodigo, A327NPacienteId});
                  pr_default.close(19);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound75 == 0 )
                        {
                           InitAll1N75( ) ;
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
                        ResetCaption1N0( ) ;
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
         sMode75 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1N75( ) ;
         Gx_mode = sMode75 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1N75( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1N75( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(16);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1N75( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(15);
            pr_default.close(14);
            context.CommitDataStores("NotaPaciente");
            if ( AnyError == 0 )
            {
               ConfirmValues1N0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(15);
            pr_default.close(14);
            context.RollbackDataStores("NotaPaciente");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1N75( )
      {
         /* Using cursor T001N22 */
         pr_default.execute(20);
         RcdFound75 = 0 ;
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound75 = 1 ;
            A41ClinicaCodigo = T001N22_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A327NPacienteId = T001N22_A327NPacienteId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327NPacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A327NPacienteId), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1N75( )
      {
         pr_default.readNext(20);
         RcdFound75 = 0 ;
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound75 = 1 ;
            A41ClinicaCodigo = T001N22_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A327NPacienteId = T001N22_A327NPacienteId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327NPacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A327NPacienteId), 9, 0)));
         }
      }

      protected void ScanEnd1N75( )
      {
      }

      protected void AfterConfirm1N75( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1N75( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1N75( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1N75( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1N75( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1N75( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1N75( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtNPacienteId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteId_Enabled), 5, 0)));
         edtNPacienteNombre1_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteNombre1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteNombre1_Enabled), 5, 0)));
         edtNPacienteNombre2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteNombre2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteNombre2_Enabled), 5, 0)));
         edtNPacienteApellido1_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteApellido1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteApellido1_Enabled), 5, 0)));
         edtNPacienteApellido2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteApellido2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteApellido2_Enabled), 5, 0)));
         edtNPacienteApellido3_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteApellido3_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteApellido3_Enabled), 5, 0)));
         edtNPacienteFechaNac_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteFechaNac_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteFechaNac_Enabled), 5, 0)));
         cmbNPacienteSexo.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbNPacienteSexo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbNPacienteSexo.Enabled), 5, 0)));
         edtNPacienteEstatura_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteEstatura_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteEstatura_Enabled), 5, 0)));
         cmbNPacienteEstaturaEn.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbNPacienteEstaturaEn_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbNPacienteEstaturaEn.Enabled), 5, 0)));
         edtNPacientePeso_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacientePeso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacientePeso_Enabled), 5, 0)));
         cmbNPacientePesoEn.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbNPacientePesoEn_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbNPacientePesoEn.Enabled), 5, 0)));
         edtProfesionId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProfesionId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProfesionId_Enabled), 5, 0)));
         edtReligionId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtReligionId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtReligionId_Enabled), 5, 0)));
         edtNPacienteDireccion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteDireccion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteDireccion_Enabled), 5, 0)));
         edtNPacienteCorreo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteCorreo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteCorreo_Enabled), 5, 0)));
         edtNPacienteFacebook_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteFacebook_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteFacebook_Enabled), 5, 0)));
         edtNPacienteTelefono_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteTelefono_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteTelefono_Enabled), 5, 0)));
         edtNPacienteCelular_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteCelular_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteCelular_Enabled), 5, 0)));
         edtNPacienteEnfermedad_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteEnfermedad_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteEnfermedad_Enabled), 5, 0)));
         edtNPacienteMedicamento_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteMedicamento_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteMedicamento_Enabled), 5, 0)));
         edtNPacienteOperacion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteOperacion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteOperacion_Enabled), 5, 0)));
         edtNPacienteAlergia_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteAlergia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteAlergia_Enabled), 5, 0)));
         edtNPacienteGesta_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteGesta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteGesta_Enabled), 5, 0)));
         edtNPacienteParto_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteParto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteParto_Enabled), 5, 0)));
         edtNPacienteCesarea_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteCesarea_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteCesarea_Enabled), 5, 0)));
         edtNPacienteAborto_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteAborto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteAborto_Enabled), 5, 0)));
         chkNPacienteAnestesiaGeneral.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkNPacienteAnestesiaGeneral_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkNPacienteAnestesiaGeneral.Enabled), 5, 0)));
         chkNPacienteAnestesiaEpidural.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkNPacienteAnestesiaEpidural_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkNPacienteAnestesiaEpidural.Enabled), 5, 0)));
         chkNPacienteAnestesiaRaquidea.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkNPacienteAnestesiaRaquidea_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkNPacienteAnestesiaRaquidea.Enabled), 5, 0)));
         edtNPacienteAnestesiaOtro_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteAnestesiaOtro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteAnestesiaOtro_Enabled), 5, 0)));
         edtNPacienteAnestesiaComplica_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteAnestesiaComplica_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteAnestesiaComplica_Enabled), 5, 0)));
         chkNPacienteFuma.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkNPacienteFuma_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkNPacienteFuma.Enabled), 5, 0)));
         edtNPacienteCigarros_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteCigarros_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteCigarros_Enabled), 5, 0)));
         chkNPacienteAlcohol.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkNPacienteAlcohol_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkNPacienteAlcohol.Enabled), 5, 0)));
         edtNPacienteOtros_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteOtros_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteOtros_Enabled), 5, 0)));
         edtNPacienteFecha_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteFecha_Enabled), 5, 0)));
         edtNPacienteHora_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNPacienteHora_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNPacienteHora_Enabled), 5, 0)));
         edtUsuarioCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioCodigo_Enabled), 5, 0)));
         edtTipoPacCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoPacCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoPacCodigo_Enabled), 5, 0)));
         edtVendedorCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVendedorCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVendedorCodigo_Enabled), 5, 0)));
         cmbNPacienteEstatus.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbNPacienteEstatus_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbNPacienteEstatus.Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1N0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("notapaciente.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z327NPacienteId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z327NPacienteId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z328NPacienteNombre1", StringUtil.RTrim( Z328NPacienteNombre1));
         GxWebStd.gx_hidden_field( context, "Z329NPacienteNombre2", StringUtil.RTrim( Z329NPacienteNombre2));
         GxWebStd.gx_hidden_field( context, "Z330NPacienteApellido1", StringUtil.RTrim( Z330NPacienteApellido1));
         GxWebStd.gx_hidden_field( context, "Z331NPacienteApellido2", StringUtil.RTrim( Z331NPacienteApellido2));
         GxWebStd.gx_hidden_field( context, "Z332NPacienteApellido3", StringUtil.RTrim( Z332NPacienteApellido3));
         GxWebStd.gx_hidden_field( context, "Z333NPacienteFechaNac", context.localUtil.DToC( Z333NPacienteFechaNac, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z334NPacienteSexo", StringUtil.RTrim( Z334NPacienteSexo));
         GxWebStd.gx_hidden_field( context, "Z335NPacienteEstatura", StringUtil.LTrim( StringUtil.NToC( Z335NPacienteEstatura, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z336NPacienteEstaturaEn", StringUtil.RTrim( Z336NPacienteEstaturaEn));
         GxWebStd.gx_hidden_field( context, "Z337NPacientePeso", StringUtil.LTrim( StringUtil.NToC( Z337NPacientePeso, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z338NPacientePesoEn", StringUtil.RTrim( Z338NPacientePesoEn));
         GxWebStd.gx_hidden_field( context, "Z339NPacienteDireccion", StringUtil.RTrim( Z339NPacienteDireccion));
         GxWebStd.gx_hidden_field( context, "Z340NPacienteCorreo", StringUtil.RTrim( Z340NPacienteCorreo));
         GxWebStd.gx_hidden_field( context, "Z341NPacienteFacebook", StringUtil.RTrim( Z341NPacienteFacebook));
         GxWebStd.gx_hidden_field( context, "Z342NPacienteTelefono", StringUtil.RTrim( Z342NPacienteTelefono));
         GxWebStd.gx_hidden_field( context, "Z343NPacienteCelular", StringUtil.RTrim( Z343NPacienteCelular));
         GxWebStd.gx_hidden_field( context, "Z344NPacienteEnfermedad", StringUtil.RTrim( Z344NPacienteEnfermedad));
         GxWebStd.gx_hidden_field( context, "Z345NPacienteMedicamento", StringUtil.RTrim( Z345NPacienteMedicamento));
         GxWebStd.gx_hidden_field( context, "Z346NPacienteOperacion", StringUtil.RTrim( Z346NPacienteOperacion));
         GxWebStd.gx_hidden_field( context, "Z347NPacienteAlergia", StringUtil.RTrim( Z347NPacienteAlergia));
         GxWebStd.gx_hidden_field( context, "Z348NPacienteGesta", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z348NPacienteGesta), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z349NPacienteParto", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z349NPacienteParto), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z350NPacienteCesarea", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z350NPacienteCesarea), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z351NPacienteAborto", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z351NPacienteAborto), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z352NPacienteAnestesiaGeneral", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z352NPacienteAnestesiaGeneral), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z353NPacienteAnestesiaEpidural", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z353NPacienteAnestesiaEpidural), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z354NPacienteAnestesiaRaquidea", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z354NPacienteAnestesiaRaquidea), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z355NPacienteAnestesiaOtro", StringUtil.RTrim( Z355NPacienteAnestesiaOtro));
         GxWebStd.gx_hidden_field( context, "Z356NPacienteAnestesiaComplica", StringUtil.RTrim( Z356NPacienteAnestesiaComplica));
         GxWebStd.gx_hidden_field( context, "Z357NPacienteFuma", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z357NPacienteFuma), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z358NPacienteCigarros", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z358NPacienteCigarros), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z359NPacienteAlcohol", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z359NPacienteAlcohol), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z360NPacienteOtros", StringUtil.RTrim( Z360NPacienteOtros));
         GxWebStd.gx_hidden_field( context, "Z361NPacienteFecha", context.localUtil.DToC( Z361NPacienteFecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z362NPacienteHora", StringUtil.RTrim( Z362NPacienteHora));
         GxWebStd.gx_hidden_field( context, "Z364NPacienteEstatus", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z364NPacienteEstatus), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z144TipoPacCodigo", StringUtil.RTrim( Z144TipoPacCodigo));
         GxWebStd.gx_hidden_field( context, "Z313ProfesionId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z313ProfesionId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z315ReligionId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z315ReligionId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z317VendedorCodigo", StringUtil.RTrim( Z317VendedorCodigo));
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
         return "NotaPaciente" ;
      }

      public override String GetPgmdesc( )
      {
         return "Nota de ingreso del paciente" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("notapaciente.aspx")  ;
      }

      protected void InitializeNonKey1N75( )
      {
         A328NPacienteNombre1 = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328NPacienteNombre1", A328NPacienteNombre1);
         A329NPacienteNombre2 = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329NPacienteNombre2", A329NPacienteNombre2);
         A330NPacienteApellido1 = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A330NPacienteApellido1", A330NPacienteApellido1);
         A331NPacienteApellido2 = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331NPacienteApellido2", A331NPacienteApellido2);
         A332NPacienteApellido3 = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332NPacienteApellido3", A332NPacienteApellido3);
         A333NPacienteFechaNac = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333NPacienteFechaNac", context.localUtil.Format(A333NPacienteFechaNac, "99/99/99"));
         A334NPacienteSexo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A334NPacienteSexo", A334NPacienteSexo);
         A335NPacienteEstatura = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A335NPacienteEstatura", StringUtil.LTrim( StringUtil.Str( A335NPacienteEstatura, 17, 2)));
         A336NPacienteEstaturaEn = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A336NPacienteEstaturaEn", A336NPacienteEstaturaEn);
         A337NPacientePeso = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A337NPacientePeso", StringUtil.LTrim( StringUtil.Str( A337NPacientePeso, 17, 2)));
         A338NPacientePesoEn = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A338NPacientePesoEn", A338NPacientePesoEn);
         A313ProfesionId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313ProfesionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A313ProfesionId), 9, 0)));
         A315ReligionId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315ReligionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A315ReligionId), 9, 0)));
         A339NPacienteDireccion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A339NPacienteDireccion", A339NPacienteDireccion);
         A340NPacienteCorreo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A340NPacienteCorreo", A340NPacienteCorreo);
         A341NPacienteFacebook = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A341NPacienteFacebook", A341NPacienteFacebook);
         A342NPacienteTelefono = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A342NPacienteTelefono", A342NPacienteTelefono);
         A343NPacienteCelular = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A343NPacienteCelular", A343NPacienteCelular);
         A344NPacienteEnfermedad = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A344NPacienteEnfermedad", A344NPacienteEnfermedad);
         A345NPacienteMedicamento = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345NPacienteMedicamento", A345NPacienteMedicamento);
         A346NPacienteOperacion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A346NPacienteOperacion", A346NPacienteOperacion);
         A347NPacienteAlergia = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347NPacienteAlergia", A347NPacienteAlergia);
         A348NPacienteGesta = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348NPacienteGesta", StringUtil.LTrim( StringUtil.Str( (decimal)(A348NPacienteGesta), 4, 0)));
         A349NPacienteParto = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349NPacienteParto", StringUtil.LTrim( StringUtil.Str( (decimal)(A349NPacienteParto), 4, 0)));
         A350NPacienteCesarea = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350NPacienteCesarea", StringUtil.LTrim( StringUtil.Str( (decimal)(A350NPacienteCesarea), 4, 0)));
         A351NPacienteAborto = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A351NPacienteAborto", StringUtil.LTrim( StringUtil.Str( (decimal)(A351NPacienteAborto), 4, 0)));
         A352NPacienteAnestesiaGeneral = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A352NPacienteAnestesiaGeneral", StringUtil.Str( (decimal)(A352NPacienteAnestesiaGeneral), 1, 0));
         A353NPacienteAnestesiaEpidural = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353NPacienteAnestesiaEpidural", StringUtil.Str( (decimal)(A353NPacienteAnestesiaEpidural), 1, 0));
         A354NPacienteAnestesiaRaquidea = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A354NPacienteAnestesiaRaquidea", StringUtil.Str( (decimal)(A354NPacienteAnestesiaRaquidea), 1, 0));
         A355NPacienteAnestesiaOtro = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A355NPacienteAnestesiaOtro", A355NPacienteAnestesiaOtro);
         A356NPacienteAnestesiaComplica = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A356NPacienteAnestesiaComplica", A356NPacienteAnestesiaComplica);
         A357NPacienteFuma = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A357NPacienteFuma", StringUtil.Str( (decimal)(A357NPacienteFuma), 1, 0));
         A358NPacienteCigarros = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358NPacienteCigarros", StringUtil.LTrim( StringUtil.Str( (decimal)(A358NPacienteCigarros), 4, 0)));
         A359NPacienteAlcohol = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359NPacienteAlcohol", StringUtil.Str( (decimal)(A359NPacienteAlcohol), 1, 0));
         A360NPacienteOtros = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360NPacienteOtros", A360NPacienteOtros);
         A361NPacienteFecha = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361NPacienteFecha", context.localUtil.Format(A361NPacienteFecha, "99/99/99"));
         A362NPacienteHora = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362NPacienteHora", A362NPacienteHora);
         A4UsuarioCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
         A144TipoPacCodigo = "" ;
         n144TipoPacCodigo = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144TipoPacCodigo", A144TipoPacCodigo);
         n144TipoPacCodigo = (String.IsNullOrEmpty(StringUtil.RTrim( A144TipoPacCodigo)) ? true : false) ;
         A317VendedorCodigo = "" ;
         n317VendedorCodigo = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317VendedorCodigo", A317VendedorCodigo);
         n317VendedorCodigo = (String.IsNullOrEmpty(StringUtil.RTrim( A317VendedorCodigo)) ? true : false) ;
         A364NPacienteEstatus = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364NPacienteEstatus", StringUtil.Str( (decimal)(A364NPacienteEstatus), 1, 0));
      }

      protected void InitAll1N75( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A327NPacienteId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327NPacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A327NPacienteId), 9, 0)));
         InitializeNonKey1N75( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?75080");
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1572866");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("notapaciente.js", "?1572867");
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
         lblTextblocknpacienteid_Internalname = "TEXTBLOCKNPACIENTEID" ;
         edtNPacienteId_Internalname = "NPACIENTEID" ;
         lblTextblocknpacientenombre1_Internalname = "TEXTBLOCKNPACIENTENOMBRE1" ;
         edtNPacienteNombre1_Internalname = "NPACIENTENOMBRE1" ;
         lblTextblocknpacientenombre2_Internalname = "TEXTBLOCKNPACIENTENOMBRE2" ;
         edtNPacienteNombre2_Internalname = "NPACIENTENOMBRE2" ;
         lblTextblocknpacienteapellido1_Internalname = "TEXTBLOCKNPACIENTEAPELLIDO1" ;
         edtNPacienteApellido1_Internalname = "NPACIENTEAPELLIDO1" ;
         lblTextblocknpacienteapellido2_Internalname = "TEXTBLOCKNPACIENTEAPELLIDO2" ;
         edtNPacienteApellido2_Internalname = "NPACIENTEAPELLIDO2" ;
         lblTextblocknpacienteapellido3_Internalname = "TEXTBLOCKNPACIENTEAPELLIDO3" ;
         edtNPacienteApellido3_Internalname = "NPACIENTEAPELLIDO3" ;
         lblTextblocknpacientefechanac_Internalname = "TEXTBLOCKNPACIENTEFECHANAC" ;
         edtNPacienteFechaNac_Internalname = "NPACIENTEFECHANAC" ;
         lblTextblocknpacientesexo_Internalname = "TEXTBLOCKNPACIENTESEXO" ;
         cmbNPacienteSexo_Internalname = "NPACIENTESEXO" ;
         lblTextblocknpacienteestatura_Internalname = "TEXTBLOCKNPACIENTEESTATURA" ;
         edtNPacienteEstatura_Internalname = "NPACIENTEESTATURA" ;
         lblTextblocknpacienteestaturaen_Internalname = "TEXTBLOCKNPACIENTEESTATURAEN" ;
         cmbNPacienteEstaturaEn_Internalname = "NPACIENTEESTATURAEN" ;
         lblTextblocknpacientepeso_Internalname = "TEXTBLOCKNPACIENTEPESO" ;
         edtNPacientePeso_Internalname = "NPACIENTEPESO" ;
         lblTextblocknpacientepesoen_Internalname = "TEXTBLOCKNPACIENTEPESOEN" ;
         cmbNPacientePesoEn_Internalname = "NPACIENTEPESOEN" ;
         lblTextblockprofesionid_Internalname = "TEXTBLOCKPROFESIONID" ;
         edtProfesionId_Internalname = "PROFESIONID" ;
         lblTextblockreligionid_Internalname = "TEXTBLOCKRELIGIONID" ;
         edtReligionId_Internalname = "RELIGIONID" ;
         lblTextblocknpacientedireccion_Internalname = "TEXTBLOCKNPACIENTEDIRECCION" ;
         edtNPacienteDireccion_Internalname = "NPACIENTEDIRECCION" ;
         lblTextblocknpacientecorreo_Internalname = "TEXTBLOCKNPACIENTECORREO" ;
         edtNPacienteCorreo_Internalname = "NPACIENTECORREO" ;
         lblTextblocknpacientefacebook_Internalname = "TEXTBLOCKNPACIENTEFACEBOOK" ;
         edtNPacienteFacebook_Internalname = "NPACIENTEFACEBOOK" ;
         lblTextblocknpacientetelefono_Internalname = "TEXTBLOCKNPACIENTETELEFONO" ;
         edtNPacienteTelefono_Internalname = "NPACIENTETELEFONO" ;
         lblTextblocknpacientecelular_Internalname = "TEXTBLOCKNPACIENTECELULAR" ;
         edtNPacienteCelular_Internalname = "NPACIENTECELULAR" ;
         lblTextblocknpacienteenfermedad_Internalname = "TEXTBLOCKNPACIENTEENFERMEDAD" ;
         edtNPacienteEnfermedad_Internalname = "NPACIENTEENFERMEDAD" ;
         lblTextblocknpacientemedicamento_Internalname = "TEXTBLOCKNPACIENTEMEDICAMENTO" ;
         edtNPacienteMedicamento_Internalname = "NPACIENTEMEDICAMENTO" ;
         lblTextblocknpacienteoperacion_Internalname = "TEXTBLOCKNPACIENTEOPERACION" ;
         edtNPacienteOperacion_Internalname = "NPACIENTEOPERACION" ;
         lblTextblocknpacientealergia_Internalname = "TEXTBLOCKNPACIENTEALERGIA" ;
         edtNPacienteAlergia_Internalname = "NPACIENTEALERGIA" ;
         lblTextblocknpacientegesta_Internalname = "TEXTBLOCKNPACIENTEGESTA" ;
         edtNPacienteGesta_Internalname = "NPACIENTEGESTA" ;
         lblTextblocknpacienteparto_Internalname = "TEXTBLOCKNPACIENTEPARTO" ;
         edtNPacienteParto_Internalname = "NPACIENTEPARTO" ;
         lblTextblocknpacientecesarea_Internalname = "TEXTBLOCKNPACIENTECESAREA" ;
         edtNPacienteCesarea_Internalname = "NPACIENTECESAREA" ;
         lblTextblocknpacienteaborto_Internalname = "TEXTBLOCKNPACIENTEABORTO" ;
         edtNPacienteAborto_Internalname = "NPACIENTEABORTO" ;
         lblTextblocknpacienteanestesiageneral_Internalname = "TEXTBLOCKNPACIENTEANESTESIAGENERAL" ;
         chkNPacienteAnestesiaGeneral_Internalname = "NPACIENTEANESTESIAGENERAL" ;
         lblTextblocknpacienteanestesiaepidural_Internalname = "TEXTBLOCKNPACIENTEANESTESIAEPIDURAL" ;
         chkNPacienteAnestesiaEpidural_Internalname = "NPACIENTEANESTESIAEPIDURAL" ;
         lblTextblocknpacienteanestesiaraquidea_Internalname = "TEXTBLOCKNPACIENTEANESTESIARAQUIDEA" ;
         chkNPacienteAnestesiaRaquidea_Internalname = "NPACIENTEANESTESIARAQUIDEA" ;
         lblTextblocknpacienteanestesiaotro_Internalname = "TEXTBLOCKNPACIENTEANESTESIAOTRO" ;
         edtNPacienteAnestesiaOtro_Internalname = "NPACIENTEANESTESIAOTRO" ;
         lblTextblocknpacienteanestesiacomplica_Internalname = "TEXTBLOCKNPACIENTEANESTESIACOMPLICA" ;
         edtNPacienteAnestesiaComplica_Internalname = "NPACIENTEANESTESIACOMPLICA" ;
         lblTextblocknpacientefuma_Internalname = "TEXTBLOCKNPACIENTEFUMA" ;
         chkNPacienteFuma_Internalname = "NPACIENTEFUMA" ;
         lblTextblocknpacientecigarros_Internalname = "TEXTBLOCKNPACIENTECIGARROS" ;
         edtNPacienteCigarros_Internalname = "NPACIENTECIGARROS" ;
         lblTextblocknpacientealcohol_Internalname = "TEXTBLOCKNPACIENTEALCOHOL" ;
         chkNPacienteAlcohol_Internalname = "NPACIENTEALCOHOL" ;
         lblTextblocknpacienteotros_Internalname = "TEXTBLOCKNPACIENTEOTROS" ;
         edtNPacienteOtros_Internalname = "NPACIENTEOTROS" ;
         lblTextblocknpacientefecha_Internalname = "TEXTBLOCKNPACIENTEFECHA" ;
         edtNPacienteFecha_Internalname = "NPACIENTEFECHA" ;
         lblTextblocknpacientehora_Internalname = "TEXTBLOCKNPACIENTEHORA" ;
         edtNPacienteHora_Internalname = "NPACIENTEHORA" ;
         lblTextblockusuariocodigo_Internalname = "TEXTBLOCKUSUARIOCODIGO" ;
         edtUsuarioCodigo_Internalname = "USUARIOCODIGO" ;
         lblTextblocktipopaccodigo_Internalname = "TEXTBLOCKTIPOPACCODIGO" ;
         edtTipoPacCodigo_Internalname = "TIPOPACCODIGO" ;
         lblTextblockvendedorcodigo_Internalname = "TEXTBLOCKVENDEDORCODIGO" ;
         edtVendedorCodigo_Internalname = "VENDEDORCODIGO" ;
         lblTextblocknpacienteestatus_Internalname = "TEXTBLOCKNPACIENTEESTATUS" ;
         cmbNPacienteEstatus_Internalname = "NPACIENTEESTATUS" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_313_Internalname = "PROMPT_41_313" ;
         imgprompt_41_315_Internalname = "PROMPT_41_315" ;
         imgprompt_4_Internalname = "PROMPT_4" ;
         imgprompt_41_144_Internalname = "PROMPT_41_144" ;
         imgprompt_41_317_Internalname = "PROMPT_41_317" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Nota de ingreso del paciente" ;
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
         cmbNPacienteEstatus_Jsonclick = "" ;
         cmbNPacienteEstatus.Enabled = 1 ;
         imgprompt_41_317_Visible = 1 ;
         imgprompt_41_317_Link = "" ;
         edtVendedorCodigo_Jsonclick = "" ;
         edtVendedorCodigo_Enabled = 1 ;
         imgprompt_41_144_Visible = 1 ;
         imgprompt_41_144_Link = "" ;
         edtTipoPacCodigo_Jsonclick = "" ;
         edtTipoPacCodigo_Enabled = 1 ;
         imgprompt_4_Visible = 1 ;
         imgprompt_4_Link = "" ;
         edtUsuarioCodigo_Jsonclick = "" ;
         edtUsuarioCodigo_Enabled = 1 ;
         edtNPacienteHora_Jsonclick = "" ;
         edtNPacienteHora_Enabled = 1 ;
         edtNPacienteFecha_Jsonclick = "" ;
         edtNPacienteFecha_Enabled = 1 ;
         edtNPacienteOtros_Jsonclick = "" ;
         edtNPacienteOtros_Enabled = 1 ;
         chkNPacienteAlcohol.Enabled = 1 ;
         edtNPacienteCigarros_Jsonclick = "" ;
         edtNPacienteCigarros_Enabled = 1 ;
         chkNPacienteFuma.Enabled = 1 ;
         edtNPacienteAnestesiaComplica_Enabled = 1 ;
         edtNPacienteAnestesiaOtro_Jsonclick = "" ;
         edtNPacienteAnestesiaOtro_Enabled = 1 ;
         chkNPacienteAnestesiaRaquidea.Enabled = 1 ;
         chkNPacienteAnestesiaEpidural.Enabled = 1 ;
         chkNPacienteAnestesiaGeneral.Enabled = 1 ;
         edtNPacienteAborto_Jsonclick = "" ;
         edtNPacienteAborto_Enabled = 1 ;
         edtNPacienteCesarea_Jsonclick = "" ;
         edtNPacienteCesarea_Enabled = 1 ;
         edtNPacienteParto_Jsonclick = "" ;
         edtNPacienteParto_Enabled = 1 ;
         edtNPacienteGesta_Jsonclick = "" ;
         edtNPacienteGesta_Enabled = 1 ;
         edtNPacienteAlergia_Enabled = 1 ;
         edtNPacienteOperacion_Enabled = 1 ;
         edtNPacienteMedicamento_Enabled = 1 ;
         edtNPacienteEnfermedad_Enabled = 1 ;
         edtNPacienteCelular_Jsonclick = "" ;
         edtNPacienteCelular_Enabled = 1 ;
         edtNPacienteTelefono_Jsonclick = "" ;
         edtNPacienteTelefono_Enabled = 1 ;
         edtNPacienteFacebook_Jsonclick = "" ;
         edtNPacienteFacebook_Enabled = 1 ;
         edtNPacienteCorreo_Jsonclick = "" ;
         edtNPacienteCorreo_Enabled = 1 ;
         edtNPacienteDireccion_Jsonclick = "" ;
         edtNPacienteDireccion_Enabled = 1 ;
         imgprompt_41_315_Visible = 1 ;
         imgprompt_41_315_Link = "" ;
         edtReligionId_Jsonclick = "" ;
         edtReligionId_Enabled = 1 ;
         imgprompt_41_313_Visible = 1 ;
         imgprompt_41_313_Link = "" ;
         edtProfesionId_Jsonclick = "" ;
         edtProfesionId_Enabled = 1 ;
         cmbNPacientePesoEn_Jsonclick = "" ;
         cmbNPacientePesoEn.Enabled = 1 ;
         edtNPacientePeso_Jsonclick = "" ;
         edtNPacientePeso_Enabled = 1 ;
         cmbNPacienteEstaturaEn_Jsonclick = "" ;
         cmbNPacienteEstaturaEn.Enabled = 1 ;
         edtNPacienteEstatura_Jsonclick = "" ;
         edtNPacienteEstatura_Enabled = 1 ;
         cmbNPacienteSexo_Jsonclick = "" ;
         cmbNPacienteSexo.Enabled = 1 ;
         edtNPacienteFechaNac_Jsonclick = "" ;
         edtNPacienteFechaNac_Enabled = 1 ;
         edtNPacienteApellido3_Jsonclick = "" ;
         edtNPacienteApellido3_Enabled = 1 ;
         edtNPacienteApellido2_Jsonclick = "" ;
         edtNPacienteApellido2_Enabled = 1 ;
         edtNPacienteApellido1_Jsonclick = "" ;
         edtNPacienteApellido1_Enabled = 1 ;
         edtNPacienteNombre2_Jsonclick = "" ;
         edtNPacienteNombre2_Enabled = 1 ;
         edtNPacienteNombre1_Jsonclick = "" ;
         edtNPacienteNombre1_Enabled = 1 ;
         edtNPacienteId_Jsonclick = "" ;
         edtNPacienteId_Enabled = 1 ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtClinicaCodigo_Enabled = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         chkNPacienteAlcohol.Caption = "" ;
         chkNPacienteFuma.Caption = "" ;
         chkNPacienteAnestesiaRaquidea.Caption = "" ;
         chkNPacienteAnestesiaEpidural.Caption = "" ;
         chkNPacienteAnestesiaGeneral.Caption = "" ;
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
         GX_FocusControl = edtNPacienteNombre1_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Npacienteid( String GX_Parm1 ,
                                     int GX_Parm2 ,
                                     String GX_Parm3 ,
                                     String GX_Parm4 ,
                                     String GX_Parm5 ,
                                     String GX_Parm6 ,
                                     String GX_Parm7 ,
                                     DateTime GX_Parm8 ,
                                     GXCombobox cmbGX_Parm9 ,
                                     decimal GX_Parm10 ,
                                     GXCombobox cmbGX_Parm11 ,
                                     decimal GX_Parm12 ,
                                     GXCombobox cmbGX_Parm13 ,
                                     String GX_Parm14 ,
                                     String GX_Parm15 ,
                                     String GX_Parm16 ,
                                     String GX_Parm17 ,
                                     String GX_Parm18 ,
                                     String GX_Parm19 ,
                                     String GX_Parm20 ,
                                     String GX_Parm21 ,
                                     String GX_Parm22 ,
                                     short GX_Parm23 ,
                                     short GX_Parm24 ,
                                     short GX_Parm25 ,
                                     short GX_Parm26 ,
                                     short GX_Parm27 ,
                                     short GX_Parm28 ,
                                     short GX_Parm29 ,
                                     String GX_Parm30 ,
                                     String GX_Parm31 ,
                                     short GX_Parm32 ,
                                     short GX_Parm33 ,
                                     short GX_Parm34 ,
                                     String GX_Parm35 ,
                                     DateTime GX_Parm36 ,
                                     String GX_Parm37 ,
                                     GXCombobox cmbGX_Parm38 ,
                                     String GX_Parm39 ,
                                     int GX_Parm40 ,
                                     int GX_Parm41 ,
                                     String GX_Parm42 ,
                                     String GX_Parm43 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A327NPacienteId = GX_Parm2 ;
         A328NPacienteNombre1 = GX_Parm3 ;
         A329NPacienteNombre2 = GX_Parm4 ;
         A330NPacienteApellido1 = GX_Parm5 ;
         A331NPacienteApellido2 = GX_Parm6 ;
         A332NPacienteApellido3 = GX_Parm7 ;
         A333NPacienteFechaNac = GX_Parm8 ;
         cmbNPacienteSexo = cmbGX_Parm9 ;
         A334NPacienteSexo = cmbNPacienteSexo.CurrentValue ;
         cmbNPacienteSexo.CurrentValue = A334NPacienteSexo ;
         A335NPacienteEstatura = GX_Parm10 ;
         cmbNPacienteEstaturaEn = cmbGX_Parm11 ;
         A336NPacienteEstaturaEn = cmbNPacienteEstaturaEn.CurrentValue ;
         cmbNPacienteEstaturaEn.CurrentValue = A336NPacienteEstaturaEn ;
         A337NPacientePeso = GX_Parm12 ;
         cmbNPacientePesoEn = cmbGX_Parm13 ;
         A338NPacientePesoEn = cmbNPacientePesoEn.CurrentValue ;
         cmbNPacientePesoEn.CurrentValue = A338NPacientePesoEn ;
         A339NPacienteDireccion = GX_Parm14 ;
         A340NPacienteCorreo = GX_Parm15 ;
         A341NPacienteFacebook = GX_Parm16 ;
         A342NPacienteTelefono = GX_Parm17 ;
         A343NPacienteCelular = GX_Parm18 ;
         A344NPacienteEnfermedad = GX_Parm19 ;
         A345NPacienteMedicamento = GX_Parm20 ;
         A346NPacienteOperacion = GX_Parm21 ;
         A347NPacienteAlergia = GX_Parm22 ;
         A348NPacienteGesta = GX_Parm23 ;
         A349NPacienteParto = GX_Parm24 ;
         A350NPacienteCesarea = GX_Parm25 ;
         A351NPacienteAborto = GX_Parm26 ;
         A352NPacienteAnestesiaGeneral = GX_Parm27 ;
         A353NPacienteAnestesiaEpidural = GX_Parm28 ;
         A354NPacienteAnestesiaRaquidea = GX_Parm29 ;
         A355NPacienteAnestesiaOtro = GX_Parm30 ;
         A356NPacienteAnestesiaComplica = GX_Parm31 ;
         A357NPacienteFuma = GX_Parm32 ;
         A358NPacienteCigarros = GX_Parm33 ;
         A359NPacienteAlcohol = GX_Parm34 ;
         A360NPacienteOtros = GX_Parm35 ;
         A361NPacienteFecha = GX_Parm36 ;
         A362NPacienteHora = GX_Parm37 ;
         cmbNPacienteEstatus = cmbGX_Parm38 ;
         A364NPacienteEstatus = (short)(NumberUtil.Val( cmbNPacienteEstatus.CurrentValue, ".")) ;
         cmbNPacienteEstatus.CurrentValue = StringUtil.Str( (decimal)(A364NPacienteEstatus), 1, 0) ;
         A144TipoPacCodigo = GX_Parm39 ;
         n144TipoPacCodigo = false ;
         A313ProfesionId = GX_Parm40 ;
         A315ReligionId = GX_Parm41 ;
         A317VendedorCodigo = GX_Parm42 ;
         n317VendedorCodigo = false ;
         A4UsuarioCodigo = GX_Parm43 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A328NPacienteNombre1)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A329NPacienteNombre2)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A330NPacienteApellido1)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A331NPacienteApellido2)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A332NPacienteApellido3)));
         isValidOutput.Add((Object)(context.localUtil.Format(A333NPacienteFechaNac, "99/99/99")));
         cmbNPacienteSexo.CurrentValue = A334NPacienteSexo ;
         isValidOutput.Add((Object)(cmbNPacienteSexo));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A335NPacienteEstatura, 17, 2, ".", ""))));
         cmbNPacienteEstaturaEn.CurrentValue = A336NPacienteEstaturaEn ;
         isValidOutput.Add((Object)(cmbNPacienteEstaturaEn));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A337NPacientePeso, 17, 2, ".", ""))));
         cmbNPacientePesoEn.CurrentValue = A338NPacientePesoEn ;
         isValidOutput.Add((Object)(cmbNPacientePesoEn));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A313ProfesionId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A315ReligionId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A339NPacienteDireccion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A340NPacienteCorreo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A341NPacienteFacebook)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A342NPacienteTelefono)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A343NPacienteCelular)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A344NPacienteEnfermedad)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A345NPacienteMedicamento)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A346NPacienteOperacion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A347NPacienteAlergia)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A348NPacienteGesta), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A349NPacienteParto), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A350NPacienteCesarea), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A351NPacienteAborto), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A352NPacienteAnestesiaGeneral), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A353NPacienteAnestesiaEpidural), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A354NPacienteAnestesiaRaquidea), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A355NPacienteAnestesiaOtro)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A356NPacienteAnestesiaComplica)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A357NPacienteFuma), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A358NPacienteCigarros), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A359NPacienteAlcohol), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A360NPacienteOtros)));
         isValidOutput.Add((Object)(context.localUtil.Format(A361NPacienteFecha, "99/99/99")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A362NPacienteHora)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A4UsuarioCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A144TipoPacCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A317VendedorCodigo)));
         cmbNPacienteEstatus.CurrentValue = StringUtil.Str( (decimal)(A364NPacienteEstatus), 1, 0) ;
         isValidOutput.Add((Object)(cmbNPacienteEstatus));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z327NPacienteId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z328NPacienteNombre1)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z329NPacienteNombre2)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z330NPacienteApellido1)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z331NPacienteApellido2)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z332NPacienteApellido3)));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z333NPacienteFechaNac, 0, "/")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z334NPacienteSexo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z335NPacienteEstatura, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z336NPacienteEstaturaEn)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z337NPacientePeso, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z338NPacientePesoEn)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z313ProfesionId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z315ReligionId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z339NPacienteDireccion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z340NPacienteCorreo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z341NPacienteFacebook)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z342NPacienteTelefono)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z343NPacienteCelular)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z344NPacienteEnfermedad)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z345NPacienteMedicamento)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z346NPacienteOperacion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z347NPacienteAlergia)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z348NPacienteGesta), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z349NPacienteParto), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z350NPacienteCesarea), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z351NPacienteAborto), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z352NPacienteAnestesiaGeneral), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z353NPacienteAnestesiaEpidural), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z354NPacienteAnestesiaRaquidea), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z355NPacienteAnestesiaOtro)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z356NPacienteAnestesiaComplica)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z357NPacienteFuma), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z358NPacienteCigarros), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z359NPacienteAlcohol), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z360NPacienteOtros)));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z361NPacienteFecha, 0, "/")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z362NPacienteHora)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z4UsuarioCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z144TipoPacCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z317VendedorCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z364NPacienteEstatus), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Profesionid( String GX_Parm1 ,
                                     int GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A313ProfesionId = GX_Parm2 ;
         /* Using cursor T001N23 */
         pr_default.execute(21, new Object[] {A41ClinicaCodigo, A313ProfesionId});
         if ( (pr_default.getStatus(21) == 101) )
         {
            AnyError41 = 1 ;
            AnyError313 = 1 ;
            GX_msglist.addItem("No existe 'Profesiones existentes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError313 == 0 ) )
         {
         }
         pr_default.close(21);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Religionid( String GX_Parm1 ,
                                    int GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A315ReligionId = GX_Parm2 ;
         /* Using cursor T001N24 */
         pr_default.execute(22, new Object[] {A41ClinicaCodigo, A315ReligionId});
         if ( (pr_default.getStatus(22) == 101) )
         {
            AnyError41 = 1 ;
            AnyError315 = 1 ;
            GX_msglist.addItem("No existe 'Religiones'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError315 == 0 ) )
         {
         }
         pr_default.close(22);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Usuariocodigo( String GX_Parm1 )
      {
         A4UsuarioCodigo = GX_Parm1 ;
         /* Using cursor T001N25 */
         pr_default.execute(23, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(23) == 101) )
         {
            AnyError4 = 1 ;
            GX_msglist.addItem("No existe 'Usuarios'.", "ForeignKeyNotFound", 1, "USUARIOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtUsuarioCodigo_Internalname ;
         }
         if ( AnyError4 == 0 )
         {
         }
         pr_default.close(23);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Tipopaccodigo( String GX_Parm1 ,
                                       String GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A144TipoPacCodigo = GX_Parm2 ;
         n144TipoPacCodigo = false ;
         /* Using cursor T001N26 */
         pr_default.execute(24, new Object[] {A41ClinicaCodigo, n144TipoPacCodigo, A144TipoPacCodigo});
         if ( (pr_default.getStatus(24) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A41ClinicaCodigo)) || String.IsNullOrEmpty(StringUtil.RTrim( A144TipoPacCodigo)) ) )
            {
               AnyError41 = 1 ;
               AnyError144 = 1 ;
               GX_msglist.addItem("No existe 'Tipos de Pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
            }
         }
         if ( ( AnyError41 == 0 ) && ( AnyError144 == 0 ) )
         {
         }
         pr_default.close(24);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Vendedorcodigo( String GX_Parm1 ,
                                        String GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A317VendedorCodigo = GX_Parm2 ;
         n317VendedorCodigo = false ;
         /* Using cursor T001N27 */
         pr_default.execute(25, new Object[] {A41ClinicaCodigo, n317VendedorCodigo, A317VendedorCodigo});
         if ( (pr_default.getStatus(25) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A41ClinicaCodigo)) || String.IsNullOrEmpty(StringUtil.RTrim( A317VendedorCodigo)) ) )
            {
               AnyError41 = 1 ;
               AnyError317 = 1 ;
               GX_msglist.addItem("No existe 'Vendedores'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
            }
         }
         if ( ( AnyError41 == 0 ) && ( AnyError317 == 0 ) )
         {
         }
         pr_default.close(25);
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
         pr_default.close(20);
         pr_default.close(15);
         pr_default.close(14);
         pr_default.close(24);
         pr_default.close(21);
         pr_default.close(22);
         pr_default.close(25);
         pr_default.close(23);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
         A144TipoPacCodigo = "" ;
         A317VendedorCodigo = "" ;
         A4UsuarioCodigo = "" ;
         GXKey = "" ;
         A334NPacienteSexo = "" ;
         A336NPacienteEstaturaEn = "" ;
         A338NPacientePesoEn = "" ;
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
         lblTextblocknpacienteid_Jsonclick = "" ;
         lblTextblocknpacientenombre1_Jsonclick = "" ;
         A328NPacienteNombre1 = "" ;
         lblTextblocknpacientenombre2_Jsonclick = "" ;
         A329NPacienteNombre2 = "" ;
         lblTextblocknpacienteapellido1_Jsonclick = "" ;
         A330NPacienteApellido1 = "" ;
         lblTextblocknpacienteapellido2_Jsonclick = "" ;
         A331NPacienteApellido2 = "" ;
         lblTextblocknpacienteapellido3_Jsonclick = "" ;
         A332NPacienteApellido3 = "" ;
         lblTextblocknpacientefechanac_Jsonclick = "" ;
         A333NPacienteFechaNac = DateTime.MinValue ;
         lblTextblocknpacientesexo_Jsonclick = "" ;
         lblTextblocknpacienteestatura_Jsonclick = "" ;
         lblTextblocknpacienteestaturaen_Jsonclick = "" ;
         lblTextblocknpacientepeso_Jsonclick = "" ;
         lblTextblocknpacientepesoen_Jsonclick = "" ;
         lblTextblockprofesionid_Jsonclick = "" ;
         lblTextblockreligionid_Jsonclick = "" ;
         lblTextblocknpacientedireccion_Jsonclick = "" ;
         A339NPacienteDireccion = "" ;
         lblTextblocknpacientecorreo_Jsonclick = "" ;
         A340NPacienteCorreo = "" ;
         lblTextblocknpacientefacebook_Jsonclick = "" ;
         A341NPacienteFacebook = "" ;
         lblTextblocknpacientetelefono_Jsonclick = "" ;
         A342NPacienteTelefono = "" ;
         lblTextblocknpacientecelular_Jsonclick = "" ;
         A343NPacienteCelular = "" ;
         lblTextblocknpacienteenfermedad_Jsonclick = "" ;
         A344NPacienteEnfermedad = "" ;
         lblTextblocknpacientemedicamento_Jsonclick = "" ;
         A345NPacienteMedicamento = "" ;
         lblTextblocknpacienteoperacion_Jsonclick = "" ;
         A346NPacienteOperacion = "" ;
         lblTextblocknpacientealergia_Jsonclick = "" ;
         A347NPacienteAlergia = "" ;
         lblTextblocknpacientegesta_Jsonclick = "" ;
         lblTextblocknpacienteparto_Jsonclick = "" ;
         lblTextblocknpacientecesarea_Jsonclick = "" ;
         lblTextblocknpacienteaborto_Jsonclick = "" ;
         lblTextblocknpacienteanestesiageneral_Jsonclick = "" ;
         lblTextblocknpacienteanestesiaepidural_Jsonclick = "" ;
         lblTextblocknpacienteanestesiaraquidea_Jsonclick = "" ;
         lblTextblocknpacienteanestesiaotro_Jsonclick = "" ;
         A355NPacienteAnestesiaOtro = "" ;
         lblTextblocknpacienteanestesiacomplica_Jsonclick = "" ;
         A356NPacienteAnestesiaComplica = "" ;
         lblTextblocknpacientefuma_Jsonclick = "" ;
         lblTextblocknpacientecigarros_Jsonclick = "" ;
         lblTextblocknpacientealcohol_Jsonclick = "" ;
         lblTextblocknpacienteotros_Jsonclick = "" ;
         A360NPacienteOtros = "" ;
         lblTextblocknpacientefecha_Jsonclick = "" ;
         A361NPacienteFecha = DateTime.MinValue ;
         lblTextblocknpacientehora_Jsonclick = "" ;
         A362NPacienteHora = "" ;
         lblTextblockusuariocodigo_Jsonclick = "" ;
         lblTextblocktipopaccodigo_Jsonclick = "" ;
         lblTextblockvendedorcodigo_Jsonclick = "" ;
         lblTextblocknpacienteestatus_Jsonclick = "" ;
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
         Z328NPacienteNombre1 = "" ;
         Z329NPacienteNombre2 = "" ;
         Z330NPacienteApellido1 = "" ;
         Z331NPacienteApellido2 = "" ;
         Z332NPacienteApellido3 = "" ;
         Z333NPacienteFechaNac = DateTime.MinValue ;
         Z334NPacienteSexo = "" ;
         Z336NPacienteEstaturaEn = "" ;
         Z338NPacientePesoEn = "" ;
         Z339NPacienteDireccion = "" ;
         Z340NPacienteCorreo = "" ;
         Z341NPacienteFacebook = "" ;
         Z342NPacienteTelefono = "" ;
         Z343NPacienteCelular = "" ;
         Z344NPacienteEnfermedad = "" ;
         Z345NPacienteMedicamento = "" ;
         Z346NPacienteOperacion = "" ;
         Z347NPacienteAlergia = "" ;
         Z355NPacienteAnestesiaOtro = "" ;
         Z356NPacienteAnestesiaComplica = "" ;
         Z360NPacienteOtros = "" ;
         Z361NPacienteFecha = DateTime.MinValue ;
         Z362NPacienteHora = "" ;
         Z144TipoPacCodigo = "" ;
         Z317VendedorCodigo = "" ;
         Z4UsuarioCodigo = "" ;
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T001N9_A327NPacienteId = new int[1] ;
         T001N9_A328NPacienteNombre1 = new String[] {""} ;
         T001N9_A329NPacienteNombre2 = new String[] {""} ;
         T001N9_A330NPacienteApellido1 = new String[] {""} ;
         T001N9_A331NPacienteApellido2 = new String[] {""} ;
         T001N9_A332NPacienteApellido3 = new String[] {""} ;
         T001N9_A333NPacienteFechaNac = new DateTime[] {DateTime.MinValue} ;
         T001N9_A334NPacienteSexo = new String[] {""} ;
         T001N9_A335NPacienteEstatura = new decimal[1] ;
         T001N9_A336NPacienteEstaturaEn = new String[] {""} ;
         T001N9_A337NPacientePeso = new decimal[1] ;
         T001N9_A338NPacientePesoEn = new String[] {""} ;
         T001N9_A339NPacienteDireccion = new String[] {""} ;
         T001N9_A340NPacienteCorreo = new String[] {""} ;
         T001N9_A341NPacienteFacebook = new String[] {""} ;
         T001N9_A342NPacienteTelefono = new String[] {""} ;
         T001N9_A343NPacienteCelular = new String[] {""} ;
         T001N9_A344NPacienteEnfermedad = new String[] {""} ;
         T001N9_A345NPacienteMedicamento = new String[] {""} ;
         T001N9_A346NPacienteOperacion = new String[] {""} ;
         T001N9_A347NPacienteAlergia = new String[] {""} ;
         T001N9_A348NPacienteGesta = new short[1] ;
         T001N9_A349NPacienteParto = new short[1] ;
         T001N9_A350NPacienteCesarea = new short[1] ;
         T001N9_A351NPacienteAborto = new short[1] ;
         T001N9_A352NPacienteAnestesiaGeneral = new short[1] ;
         T001N9_A353NPacienteAnestesiaEpidural = new short[1] ;
         T001N9_A354NPacienteAnestesiaRaquidea = new short[1] ;
         T001N9_A355NPacienteAnestesiaOtro = new String[] {""} ;
         T001N9_A356NPacienteAnestesiaComplica = new String[] {""} ;
         T001N9_A357NPacienteFuma = new short[1] ;
         T001N9_A358NPacienteCigarros = new short[1] ;
         T001N9_A359NPacienteAlcohol = new short[1] ;
         T001N9_A360NPacienteOtros = new String[] {""} ;
         T001N9_A361NPacienteFecha = new DateTime[] {DateTime.MinValue} ;
         T001N9_A362NPacienteHora = new String[] {""} ;
         T001N9_A364NPacienteEstatus = new short[1] ;
         T001N9_A41ClinicaCodigo = new String[] {""} ;
         T001N9_A144TipoPacCodigo = new String[] {""} ;
         T001N9_n144TipoPacCodigo = new bool[] {false} ;
         T001N9_A313ProfesionId = new int[1] ;
         T001N9_A315ReligionId = new int[1] ;
         T001N9_A317VendedorCodigo = new String[] {""} ;
         T001N9_n317VendedorCodigo = new bool[] {false} ;
         T001N9_A4UsuarioCodigo = new String[] {""} ;
         T001N4_A41ClinicaCodigo = new String[] {""} ;
         T001N5_A41ClinicaCodigo = new String[] {""} ;
         T001N6_A41ClinicaCodigo = new String[] {""} ;
         T001N7_A41ClinicaCodigo = new String[] {""} ;
         T001N8_A4UsuarioCodigo = new String[] {""} ;
         T001N10_A41ClinicaCodigo = new String[] {""} ;
         T001N11_A41ClinicaCodigo = new String[] {""} ;
         T001N12_A41ClinicaCodigo = new String[] {""} ;
         T001N13_A41ClinicaCodigo = new String[] {""} ;
         T001N14_A4UsuarioCodigo = new String[] {""} ;
         T001N15_A41ClinicaCodigo = new String[] {""} ;
         T001N15_A327NPacienteId = new int[1] ;
         T001N3_A327NPacienteId = new int[1] ;
         T001N3_A328NPacienteNombre1 = new String[] {""} ;
         T001N3_A329NPacienteNombre2 = new String[] {""} ;
         T001N3_A330NPacienteApellido1 = new String[] {""} ;
         T001N3_A331NPacienteApellido2 = new String[] {""} ;
         T001N3_A332NPacienteApellido3 = new String[] {""} ;
         T001N3_A333NPacienteFechaNac = new DateTime[] {DateTime.MinValue} ;
         T001N3_A334NPacienteSexo = new String[] {""} ;
         T001N3_A335NPacienteEstatura = new decimal[1] ;
         T001N3_A336NPacienteEstaturaEn = new String[] {""} ;
         T001N3_A337NPacientePeso = new decimal[1] ;
         T001N3_A338NPacientePesoEn = new String[] {""} ;
         T001N3_A339NPacienteDireccion = new String[] {""} ;
         T001N3_A340NPacienteCorreo = new String[] {""} ;
         T001N3_A341NPacienteFacebook = new String[] {""} ;
         T001N3_A342NPacienteTelefono = new String[] {""} ;
         T001N3_A343NPacienteCelular = new String[] {""} ;
         T001N3_A344NPacienteEnfermedad = new String[] {""} ;
         T001N3_A345NPacienteMedicamento = new String[] {""} ;
         T001N3_A346NPacienteOperacion = new String[] {""} ;
         T001N3_A347NPacienteAlergia = new String[] {""} ;
         T001N3_A348NPacienteGesta = new short[1] ;
         T001N3_A349NPacienteParto = new short[1] ;
         T001N3_A350NPacienteCesarea = new short[1] ;
         T001N3_A351NPacienteAborto = new short[1] ;
         T001N3_A352NPacienteAnestesiaGeneral = new short[1] ;
         T001N3_A353NPacienteAnestesiaEpidural = new short[1] ;
         T001N3_A354NPacienteAnestesiaRaquidea = new short[1] ;
         T001N3_A355NPacienteAnestesiaOtro = new String[] {""} ;
         T001N3_A356NPacienteAnestesiaComplica = new String[] {""} ;
         T001N3_A357NPacienteFuma = new short[1] ;
         T001N3_A358NPacienteCigarros = new short[1] ;
         T001N3_A359NPacienteAlcohol = new short[1] ;
         T001N3_A360NPacienteOtros = new String[] {""} ;
         T001N3_A361NPacienteFecha = new DateTime[] {DateTime.MinValue} ;
         T001N3_A362NPacienteHora = new String[] {""} ;
         T001N3_A364NPacienteEstatus = new short[1] ;
         T001N3_A41ClinicaCodigo = new String[] {""} ;
         T001N3_A144TipoPacCodigo = new String[] {""} ;
         T001N3_n144TipoPacCodigo = new bool[] {false} ;
         T001N3_A313ProfesionId = new int[1] ;
         T001N3_A315ReligionId = new int[1] ;
         T001N3_A317VendedorCodigo = new String[] {""} ;
         T001N3_n317VendedorCodigo = new bool[] {false} ;
         T001N3_A4UsuarioCodigo = new String[] {""} ;
         sMode75 = "" ;
         T001N16_A41ClinicaCodigo = new String[] {""} ;
         T001N16_A327NPacienteId = new int[1] ;
         T001N17_A41ClinicaCodigo = new String[] {""} ;
         T001N17_A327NPacienteId = new int[1] ;
         T001N18_A327NPacienteId = new int[1] ;
         T001N18_A328NPacienteNombre1 = new String[] {""} ;
         T001N18_A329NPacienteNombre2 = new String[] {""} ;
         T001N18_A330NPacienteApellido1 = new String[] {""} ;
         T001N18_A331NPacienteApellido2 = new String[] {""} ;
         T001N18_A332NPacienteApellido3 = new String[] {""} ;
         T001N18_A333NPacienteFechaNac = new DateTime[] {DateTime.MinValue} ;
         T001N18_A334NPacienteSexo = new String[] {""} ;
         T001N18_A335NPacienteEstatura = new decimal[1] ;
         T001N18_A336NPacienteEstaturaEn = new String[] {""} ;
         T001N18_A337NPacientePeso = new decimal[1] ;
         T001N18_A338NPacientePesoEn = new String[] {""} ;
         T001N18_A339NPacienteDireccion = new String[] {""} ;
         T001N18_A340NPacienteCorreo = new String[] {""} ;
         T001N18_A341NPacienteFacebook = new String[] {""} ;
         T001N18_A342NPacienteTelefono = new String[] {""} ;
         T001N18_A343NPacienteCelular = new String[] {""} ;
         T001N18_A344NPacienteEnfermedad = new String[] {""} ;
         T001N18_A345NPacienteMedicamento = new String[] {""} ;
         T001N18_A346NPacienteOperacion = new String[] {""} ;
         T001N18_A347NPacienteAlergia = new String[] {""} ;
         T001N18_A348NPacienteGesta = new short[1] ;
         T001N18_A349NPacienteParto = new short[1] ;
         T001N18_A350NPacienteCesarea = new short[1] ;
         T001N18_A351NPacienteAborto = new short[1] ;
         T001N18_A352NPacienteAnestesiaGeneral = new short[1] ;
         T001N18_A353NPacienteAnestesiaEpidural = new short[1] ;
         T001N18_A354NPacienteAnestesiaRaquidea = new short[1] ;
         T001N18_A355NPacienteAnestesiaOtro = new String[] {""} ;
         T001N18_A356NPacienteAnestesiaComplica = new String[] {""} ;
         T001N18_A357NPacienteFuma = new short[1] ;
         T001N18_A358NPacienteCigarros = new short[1] ;
         T001N18_A359NPacienteAlcohol = new short[1] ;
         T001N18_A360NPacienteOtros = new String[] {""} ;
         T001N18_A361NPacienteFecha = new DateTime[] {DateTime.MinValue} ;
         T001N18_A362NPacienteHora = new String[] {""} ;
         T001N18_A364NPacienteEstatus = new short[1] ;
         T001N18_A41ClinicaCodigo = new String[] {""} ;
         T001N18_A144TipoPacCodigo = new String[] {""} ;
         T001N18_n144TipoPacCodigo = new bool[] {false} ;
         T001N18_A313ProfesionId = new int[1] ;
         T001N18_A315ReligionId = new int[1] ;
         T001N18_A317VendedorCodigo = new String[] {""} ;
         T001N18_n317VendedorCodigo = new bool[] {false} ;
         T001N18_A4UsuarioCodigo = new String[] {""} ;
         T001N22_A41ClinicaCodigo = new String[] {""} ;
         T001N22_A327NPacienteId = new int[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         T001N23_A41ClinicaCodigo = new String[] {""} ;
         T001N24_A41ClinicaCodigo = new String[] {""} ;
         T001N25_A4UsuarioCodigo = new String[] {""} ;
         T001N26_A41ClinicaCodigo = new String[] {""} ;
         T001N27_A41ClinicaCodigo = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.notapaciente__default(),
            new Object[][] {
                new Object[] {
               T001N2_A327NPacienteId, T001N2_A328NPacienteNombre1, T001N2_A329NPacienteNombre2, T001N2_A330NPacienteApellido1, T001N2_A331NPacienteApellido2, T001N2_A332NPacienteApellido3, T001N2_A333NPacienteFechaNac, T001N2_A334NPacienteSexo, T001N2_A335NPacienteEstatura, T001N2_A336NPacienteEstaturaEn,
               T001N2_A337NPacientePeso, T001N2_A338NPacientePesoEn, T001N2_A339NPacienteDireccion, T001N2_A340NPacienteCorreo, T001N2_A341NPacienteFacebook, T001N2_A342NPacienteTelefono, T001N2_A343NPacienteCelular, T001N2_A344NPacienteEnfermedad, T001N2_A345NPacienteMedicamento, T001N2_A346NPacienteOperacion,
               T001N2_A347NPacienteAlergia, T001N2_A348NPacienteGesta, T001N2_A349NPacienteParto, T001N2_A350NPacienteCesarea, T001N2_A351NPacienteAborto, T001N2_A352NPacienteAnestesiaGeneral, T001N2_A353NPacienteAnestesiaEpidural, T001N2_A354NPacienteAnestesiaRaquidea, T001N2_A355NPacienteAnestesiaOtro, T001N2_A356NPacienteAnestesiaComplica,
               T001N2_A357NPacienteFuma, T001N2_A358NPacienteCigarros, T001N2_A359NPacienteAlcohol, T001N2_A360NPacienteOtros, T001N2_A361NPacienteFecha, T001N2_A362NPacienteHora, T001N2_A364NPacienteEstatus, T001N2_A41ClinicaCodigo, T001N2_A144TipoPacCodigo, T001N2_n144TipoPacCodigo,
               T001N2_A313ProfesionId, T001N2_A315ReligionId, T001N2_A317VendedorCodigo, T001N2_n317VendedorCodigo, T001N2_A4UsuarioCodigo
               }
               , new Object[] {
               T001N3_A327NPacienteId, T001N3_A328NPacienteNombre1, T001N3_A329NPacienteNombre2, T001N3_A330NPacienteApellido1, T001N3_A331NPacienteApellido2, T001N3_A332NPacienteApellido3, T001N3_A333NPacienteFechaNac, T001N3_A334NPacienteSexo, T001N3_A335NPacienteEstatura, T001N3_A336NPacienteEstaturaEn,
               T001N3_A337NPacientePeso, T001N3_A338NPacientePesoEn, T001N3_A339NPacienteDireccion, T001N3_A340NPacienteCorreo, T001N3_A341NPacienteFacebook, T001N3_A342NPacienteTelefono, T001N3_A343NPacienteCelular, T001N3_A344NPacienteEnfermedad, T001N3_A345NPacienteMedicamento, T001N3_A346NPacienteOperacion,
               T001N3_A347NPacienteAlergia, T001N3_A348NPacienteGesta, T001N3_A349NPacienteParto, T001N3_A350NPacienteCesarea, T001N3_A351NPacienteAborto, T001N3_A352NPacienteAnestesiaGeneral, T001N3_A353NPacienteAnestesiaEpidural, T001N3_A354NPacienteAnestesiaRaquidea, T001N3_A355NPacienteAnestesiaOtro, T001N3_A356NPacienteAnestesiaComplica,
               T001N3_A357NPacienteFuma, T001N3_A358NPacienteCigarros, T001N3_A359NPacienteAlcohol, T001N3_A360NPacienteOtros, T001N3_A361NPacienteFecha, T001N3_A362NPacienteHora, T001N3_A364NPacienteEstatus, T001N3_A41ClinicaCodigo, T001N3_A144TipoPacCodigo, T001N3_n144TipoPacCodigo,
               T001N3_A313ProfesionId, T001N3_A315ReligionId, T001N3_A317VendedorCodigo, T001N3_n317VendedorCodigo, T001N3_A4UsuarioCodigo
               }
               , new Object[] {
               T001N4_A41ClinicaCodigo
               }
               , new Object[] {
               T001N5_A41ClinicaCodigo
               }
               , new Object[] {
               T001N6_A41ClinicaCodigo
               }
               , new Object[] {
               T001N7_A41ClinicaCodigo
               }
               , new Object[] {
               T001N8_A4UsuarioCodigo
               }
               , new Object[] {
               T001N9_A327NPacienteId, T001N9_A328NPacienteNombre1, T001N9_A329NPacienteNombre2, T001N9_A330NPacienteApellido1, T001N9_A331NPacienteApellido2, T001N9_A332NPacienteApellido3, T001N9_A333NPacienteFechaNac, T001N9_A334NPacienteSexo, T001N9_A335NPacienteEstatura, T001N9_A336NPacienteEstaturaEn,
               T001N9_A337NPacientePeso, T001N9_A338NPacientePesoEn, T001N9_A339NPacienteDireccion, T001N9_A340NPacienteCorreo, T001N9_A341NPacienteFacebook, T001N9_A342NPacienteTelefono, T001N9_A343NPacienteCelular, T001N9_A344NPacienteEnfermedad, T001N9_A345NPacienteMedicamento, T001N9_A346NPacienteOperacion,
               T001N9_A347NPacienteAlergia, T001N9_A348NPacienteGesta, T001N9_A349NPacienteParto, T001N9_A350NPacienteCesarea, T001N9_A351NPacienteAborto, T001N9_A352NPacienteAnestesiaGeneral, T001N9_A353NPacienteAnestesiaEpidural, T001N9_A354NPacienteAnestesiaRaquidea, T001N9_A355NPacienteAnestesiaOtro, T001N9_A356NPacienteAnestesiaComplica,
               T001N9_A357NPacienteFuma, T001N9_A358NPacienteCigarros, T001N9_A359NPacienteAlcohol, T001N9_A360NPacienteOtros, T001N9_A361NPacienteFecha, T001N9_A362NPacienteHora, T001N9_A364NPacienteEstatus, T001N9_A41ClinicaCodigo, T001N9_A144TipoPacCodigo, T001N9_n144TipoPacCodigo,
               T001N9_A313ProfesionId, T001N9_A315ReligionId, T001N9_A317VendedorCodigo, T001N9_n317VendedorCodigo, T001N9_A4UsuarioCodigo
               }
               , new Object[] {
               T001N10_A41ClinicaCodigo
               }
               , new Object[] {
               T001N11_A41ClinicaCodigo
               }
               , new Object[] {
               T001N12_A41ClinicaCodigo
               }
               , new Object[] {
               T001N13_A41ClinicaCodigo
               }
               , new Object[] {
               T001N14_A4UsuarioCodigo
               }
               , new Object[] {
               T001N15_A41ClinicaCodigo, T001N15_A327NPacienteId
               }
               , new Object[] {
               T001N16_A41ClinicaCodigo, T001N16_A327NPacienteId
               }
               , new Object[] {
               T001N17_A41ClinicaCodigo, T001N17_A327NPacienteId
               }
               , new Object[] {
               T001N18_A327NPacienteId, T001N18_A328NPacienteNombre1, T001N18_A329NPacienteNombre2, T001N18_A330NPacienteApellido1, T001N18_A331NPacienteApellido2, T001N18_A332NPacienteApellido3, T001N18_A333NPacienteFechaNac, T001N18_A334NPacienteSexo, T001N18_A335NPacienteEstatura, T001N18_A336NPacienteEstaturaEn,
               T001N18_A337NPacientePeso, T001N18_A338NPacientePesoEn, T001N18_A339NPacienteDireccion, T001N18_A340NPacienteCorreo, T001N18_A341NPacienteFacebook, T001N18_A342NPacienteTelefono, T001N18_A343NPacienteCelular, T001N18_A344NPacienteEnfermedad, T001N18_A345NPacienteMedicamento, T001N18_A346NPacienteOperacion,
               T001N18_A347NPacienteAlergia, T001N18_A348NPacienteGesta, T001N18_A349NPacienteParto, T001N18_A350NPacienteCesarea, T001N18_A351NPacienteAborto, T001N18_A352NPacienteAnestesiaGeneral, T001N18_A353NPacienteAnestesiaEpidural, T001N18_A354NPacienteAnestesiaRaquidea, T001N18_A355NPacienteAnestesiaOtro, T001N18_A356NPacienteAnestesiaComplica,
               T001N18_A357NPacienteFuma, T001N18_A358NPacienteCigarros, T001N18_A359NPacienteAlcohol, T001N18_A360NPacienteOtros, T001N18_A361NPacienteFecha, T001N18_A362NPacienteHora, T001N18_A364NPacienteEstatus, T001N18_A41ClinicaCodigo, T001N18_A144TipoPacCodigo, T001N18_n144TipoPacCodigo,
               T001N18_A313ProfesionId, T001N18_A315ReligionId, T001N18_A317VendedorCodigo, T001N18_n317VendedorCodigo, T001N18_A4UsuarioCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001N22_A41ClinicaCodigo, T001N22_A327NPacienteId
               }
               , new Object[] {
               T001N23_A41ClinicaCodigo
               }
               , new Object[] {
               T001N24_A41ClinicaCodigo
               }
               , new Object[] {
               T001N25_A4UsuarioCodigo
               }
               , new Object[] {
               T001N26_A41ClinicaCodigo
               }
               , new Object[] {
               T001N27_A41ClinicaCodigo
               }
            }
         );
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short A364NPacienteEstatus ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A348NPacienteGesta ;
      private short A349NPacienteParto ;
      private short A350NPacienteCesarea ;
      private short A351NPacienteAborto ;
      private short A352NPacienteAnestesiaGeneral ;
      private short A353NPacienteAnestesiaEpidural ;
      private short A354NPacienteAnestesiaRaquidea ;
      private short A357NPacienteFuma ;
      private short A358NPacienteCigarros ;
      private short A359NPacienteAlcohol ;
      private short Z348NPacienteGesta ;
      private short Z349NPacienteParto ;
      private short Z350NPacienteCesarea ;
      private short Z351NPacienteAborto ;
      private short Z352NPacienteAnestesiaGeneral ;
      private short Z353NPacienteAnestesiaEpidural ;
      private short Z354NPacienteAnestesiaRaquidea ;
      private short Z357NPacienteFuma ;
      private short Z358NPacienteCigarros ;
      private short Z359NPacienteAlcohol ;
      private short Z364NPacienteEstatus ;
      private short GX_JID ;
      private short RcdFound75 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int A313ProfesionId ;
      private int A315ReligionId ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int A327NPacienteId ;
      private int edtNPacienteId_Enabled ;
      private int edtNPacienteNombre1_Enabled ;
      private int edtNPacienteNombre2_Enabled ;
      private int edtNPacienteApellido1_Enabled ;
      private int edtNPacienteApellido2_Enabled ;
      private int edtNPacienteApellido3_Enabled ;
      private int edtNPacienteFechaNac_Enabled ;
      private int edtNPacienteEstatura_Enabled ;
      private int edtNPacientePeso_Enabled ;
      private int edtProfesionId_Enabled ;
      private int imgprompt_41_313_Visible ;
      private int edtReligionId_Enabled ;
      private int imgprompt_41_315_Visible ;
      private int edtNPacienteDireccion_Enabled ;
      private int edtNPacienteCorreo_Enabled ;
      private int edtNPacienteFacebook_Enabled ;
      private int edtNPacienteTelefono_Enabled ;
      private int edtNPacienteCelular_Enabled ;
      private int edtNPacienteEnfermedad_Enabled ;
      private int edtNPacienteMedicamento_Enabled ;
      private int edtNPacienteOperacion_Enabled ;
      private int edtNPacienteAlergia_Enabled ;
      private int edtNPacienteGesta_Enabled ;
      private int edtNPacienteParto_Enabled ;
      private int edtNPacienteCesarea_Enabled ;
      private int edtNPacienteAborto_Enabled ;
      private int edtNPacienteAnestesiaOtro_Enabled ;
      private int edtNPacienteAnestesiaComplica_Enabled ;
      private int edtNPacienteCigarros_Enabled ;
      private int edtNPacienteOtros_Enabled ;
      private int edtNPacienteFecha_Enabled ;
      private int edtNPacienteHora_Enabled ;
      private int edtUsuarioCodigo_Enabled ;
      private int imgprompt_4_Visible ;
      private int edtTipoPacCodigo_Enabled ;
      private int imgprompt_41_144_Visible ;
      private int edtVendedorCodigo_Enabled ;
      private int imgprompt_41_317_Visible ;
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
      private int Z327NPacienteId ;
      private int Z313ProfesionId ;
      private int Z315ReligionId ;
      private int AnyError41 ;
      private int AnyError144 ;
      private int AnyError313 ;
      private int AnyError315 ;
      private int AnyError317 ;
      private int AnyError4 ;
      private int idxLst ;
      private decimal A335NPacienteEstatura ;
      private decimal A337NPacientePeso ;
      private decimal Z335NPacienteEstatura ;
      private decimal Z337NPacientePeso ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String chkNPacienteAnestesiaGeneral_Internalname ;
      private String chkNPacienteAnestesiaEpidural_Internalname ;
      private String chkNPacienteAnestesiaRaquidea_Internalname ;
      private String chkNPacienteFuma_Internalname ;
      private String chkNPacienteAlcohol_Internalname ;
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
      private String lblTextblocknpacienteid_Internalname ;
      private String lblTextblocknpacienteid_Jsonclick ;
      private String edtNPacienteId_Internalname ;
      private String edtNPacienteId_Jsonclick ;
      private String lblTextblocknpacientenombre1_Internalname ;
      private String lblTextblocknpacientenombre1_Jsonclick ;
      private String edtNPacienteNombre1_Internalname ;
      private String edtNPacienteNombre1_Jsonclick ;
      private String lblTextblocknpacientenombre2_Internalname ;
      private String lblTextblocknpacientenombre2_Jsonclick ;
      private String edtNPacienteNombre2_Internalname ;
      private String edtNPacienteNombre2_Jsonclick ;
      private String lblTextblocknpacienteapellido1_Internalname ;
      private String lblTextblocknpacienteapellido1_Jsonclick ;
      private String edtNPacienteApellido1_Internalname ;
      private String edtNPacienteApellido1_Jsonclick ;
      private String lblTextblocknpacienteapellido2_Internalname ;
      private String lblTextblocknpacienteapellido2_Jsonclick ;
      private String edtNPacienteApellido2_Internalname ;
      private String edtNPacienteApellido2_Jsonclick ;
      private String lblTextblocknpacienteapellido3_Internalname ;
      private String lblTextblocknpacienteapellido3_Jsonclick ;
      private String edtNPacienteApellido3_Internalname ;
      private String edtNPacienteApellido3_Jsonclick ;
      private String lblTextblocknpacientefechanac_Internalname ;
      private String lblTextblocknpacientefechanac_Jsonclick ;
      private String edtNPacienteFechaNac_Internalname ;
      private String edtNPacienteFechaNac_Jsonclick ;
      private String lblTextblocknpacientesexo_Internalname ;
      private String lblTextblocknpacientesexo_Jsonclick ;
      private String cmbNPacienteSexo_Internalname ;
      private String cmbNPacienteSexo_Jsonclick ;
      private String lblTextblocknpacienteestatura_Internalname ;
      private String lblTextblocknpacienteestatura_Jsonclick ;
      private String edtNPacienteEstatura_Internalname ;
      private String edtNPacienteEstatura_Jsonclick ;
      private String lblTextblocknpacienteestaturaen_Internalname ;
      private String lblTextblocknpacienteestaturaen_Jsonclick ;
      private String cmbNPacienteEstaturaEn_Internalname ;
      private String cmbNPacienteEstaturaEn_Jsonclick ;
      private String lblTextblocknpacientepeso_Internalname ;
      private String lblTextblocknpacientepeso_Jsonclick ;
      private String edtNPacientePeso_Internalname ;
      private String edtNPacientePeso_Jsonclick ;
      private String lblTextblocknpacientepesoen_Internalname ;
      private String lblTextblocknpacientepesoen_Jsonclick ;
      private String cmbNPacientePesoEn_Internalname ;
      private String cmbNPacientePesoEn_Jsonclick ;
      private String lblTextblockprofesionid_Internalname ;
      private String lblTextblockprofesionid_Jsonclick ;
      private String edtProfesionId_Internalname ;
      private String edtProfesionId_Jsonclick ;
      private String imgprompt_41_313_Internalname ;
      private String imgprompt_41_313_Link ;
      private String lblTextblockreligionid_Internalname ;
      private String lblTextblockreligionid_Jsonclick ;
      private String edtReligionId_Internalname ;
      private String edtReligionId_Jsonclick ;
      private String imgprompt_41_315_Internalname ;
      private String imgprompt_41_315_Link ;
      private String lblTextblocknpacientedireccion_Internalname ;
      private String lblTextblocknpacientedireccion_Jsonclick ;
      private String edtNPacienteDireccion_Internalname ;
      private String edtNPacienteDireccion_Jsonclick ;
      private String lblTextblocknpacientecorreo_Internalname ;
      private String lblTextblocknpacientecorreo_Jsonclick ;
      private String edtNPacienteCorreo_Internalname ;
      private String edtNPacienteCorreo_Jsonclick ;
      private String lblTextblocknpacientefacebook_Internalname ;
      private String lblTextblocknpacientefacebook_Jsonclick ;
      private String edtNPacienteFacebook_Internalname ;
      private String edtNPacienteFacebook_Jsonclick ;
      private String lblTextblocknpacientetelefono_Internalname ;
      private String lblTextblocknpacientetelefono_Jsonclick ;
      private String edtNPacienteTelefono_Internalname ;
      private String edtNPacienteTelefono_Jsonclick ;
      private String lblTextblocknpacientecelular_Internalname ;
      private String lblTextblocknpacientecelular_Jsonclick ;
      private String edtNPacienteCelular_Internalname ;
      private String edtNPacienteCelular_Jsonclick ;
      private String lblTextblocknpacienteenfermedad_Internalname ;
      private String lblTextblocknpacienteenfermedad_Jsonclick ;
      private String edtNPacienteEnfermedad_Internalname ;
      private String lblTextblocknpacientemedicamento_Internalname ;
      private String lblTextblocknpacientemedicamento_Jsonclick ;
      private String edtNPacienteMedicamento_Internalname ;
      private String lblTextblocknpacienteoperacion_Internalname ;
      private String lblTextblocknpacienteoperacion_Jsonclick ;
      private String edtNPacienteOperacion_Internalname ;
      private String lblTextblocknpacientealergia_Internalname ;
      private String lblTextblocknpacientealergia_Jsonclick ;
      private String edtNPacienteAlergia_Internalname ;
      private String lblTextblocknpacientegesta_Internalname ;
      private String lblTextblocknpacientegesta_Jsonclick ;
      private String edtNPacienteGesta_Internalname ;
      private String edtNPacienteGesta_Jsonclick ;
      private String lblTextblocknpacienteparto_Internalname ;
      private String lblTextblocknpacienteparto_Jsonclick ;
      private String edtNPacienteParto_Internalname ;
      private String edtNPacienteParto_Jsonclick ;
      private String lblTextblocknpacientecesarea_Internalname ;
      private String lblTextblocknpacientecesarea_Jsonclick ;
      private String edtNPacienteCesarea_Internalname ;
      private String edtNPacienteCesarea_Jsonclick ;
      private String lblTextblocknpacienteaborto_Internalname ;
      private String lblTextblocknpacienteaborto_Jsonclick ;
      private String edtNPacienteAborto_Internalname ;
      private String edtNPacienteAborto_Jsonclick ;
      private String lblTextblocknpacienteanestesiageneral_Internalname ;
      private String lblTextblocknpacienteanestesiageneral_Jsonclick ;
      private String lblTextblocknpacienteanestesiaepidural_Internalname ;
      private String lblTextblocknpacienteanestesiaepidural_Jsonclick ;
      private String lblTextblocknpacienteanestesiaraquidea_Internalname ;
      private String lblTextblocknpacienteanestesiaraquidea_Jsonclick ;
      private String lblTextblocknpacienteanestesiaotro_Internalname ;
      private String lblTextblocknpacienteanestesiaotro_Jsonclick ;
      private String edtNPacienteAnestesiaOtro_Internalname ;
      private String edtNPacienteAnestesiaOtro_Jsonclick ;
      private String lblTextblocknpacienteanestesiacomplica_Internalname ;
      private String lblTextblocknpacienteanestesiacomplica_Jsonclick ;
      private String edtNPacienteAnestesiaComplica_Internalname ;
      private String lblTextblocknpacientefuma_Internalname ;
      private String lblTextblocknpacientefuma_Jsonclick ;
      private String lblTextblocknpacientecigarros_Internalname ;
      private String lblTextblocknpacientecigarros_Jsonclick ;
      private String edtNPacienteCigarros_Internalname ;
      private String edtNPacienteCigarros_Jsonclick ;
      private String lblTextblocknpacientealcohol_Internalname ;
      private String lblTextblocknpacientealcohol_Jsonclick ;
      private String lblTextblocknpacienteotros_Internalname ;
      private String lblTextblocknpacienteotros_Jsonclick ;
      private String edtNPacienteOtros_Internalname ;
      private String edtNPacienteOtros_Jsonclick ;
      private String lblTextblocknpacientefecha_Internalname ;
      private String lblTextblocknpacientefecha_Jsonclick ;
      private String edtNPacienteFecha_Internalname ;
      private String edtNPacienteFecha_Jsonclick ;
      private String lblTextblocknpacientehora_Internalname ;
      private String lblTextblocknpacientehora_Jsonclick ;
      private String A362NPacienteHora ;
      private String edtNPacienteHora_Internalname ;
      private String edtNPacienteHora_Jsonclick ;
      private String lblTextblockusuariocodigo_Internalname ;
      private String lblTextblockusuariocodigo_Jsonclick ;
      private String edtUsuarioCodigo_Internalname ;
      private String edtUsuarioCodigo_Jsonclick ;
      private String imgprompt_4_Internalname ;
      private String imgprompt_4_Link ;
      private String lblTextblocktipopaccodigo_Internalname ;
      private String lblTextblocktipopaccodigo_Jsonclick ;
      private String edtTipoPacCodigo_Internalname ;
      private String edtTipoPacCodigo_Jsonclick ;
      private String imgprompt_41_144_Internalname ;
      private String imgprompt_41_144_Link ;
      private String lblTextblockvendedorcodigo_Internalname ;
      private String lblTextblockvendedorcodigo_Jsonclick ;
      private String edtVendedorCodigo_Internalname ;
      private String edtVendedorCodigo_Jsonclick ;
      private String imgprompt_41_317_Internalname ;
      private String imgprompt_41_317_Link ;
      private String lblTextblocknpacienteestatus_Internalname ;
      private String lblTextblocknpacienteestatus_Jsonclick ;
      private String cmbNPacienteEstatus_Internalname ;
      private String cmbNPacienteEstatus_Jsonclick ;
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
      private String Z362NPacienteHora ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode75 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private DateTime A333NPacienteFechaNac ;
      private DateTime A361NPacienteFecha ;
      private DateTime Z333NPacienteFechaNac ;
      private DateTime Z361NPacienteFecha ;
      private bool entryPointCalled ;
      private bool n144TipoPacCodigo ;
      private bool n317VendedorCodigo ;
      private bool wbErr ;
      private bool Gx_longc ;
      private String A41ClinicaCodigo ;
      private String A144TipoPacCodigo ;
      private String A317VendedorCodigo ;
      private String A4UsuarioCodigo ;
      private String A334NPacienteSexo ;
      private String A336NPacienteEstaturaEn ;
      private String A338NPacientePesoEn ;
      private String A328NPacienteNombre1 ;
      private String A329NPacienteNombre2 ;
      private String A330NPacienteApellido1 ;
      private String A331NPacienteApellido2 ;
      private String A332NPacienteApellido3 ;
      private String A339NPacienteDireccion ;
      private String A340NPacienteCorreo ;
      private String A341NPacienteFacebook ;
      private String A342NPacienteTelefono ;
      private String A343NPacienteCelular ;
      private String A344NPacienteEnfermedad ;
      private String A345NPacienteMedicamento ;
      private String A346NPacienteOperacion ;
      private String A347NPacienteAlergia ;
      private String A355NPacienteAnestesiaOtro ;
      private String A356NPacienteAnestesiaComplica ;
      private String A360NPacienteOtros ;
      private String Z41ClinicaCodigo ;
      private String Z328NPacienteNombre1 ;
      private String Z329NPacienteNombre2 ;
      private String Z330NPacienteApellido1 ;
      private String Z331NPacienteApellido2 ;
      private String Z332NPacienteApellido3 ;
      private String Z334NPacienteSexo ;
      private String Z336NPacienteEstaturaEn ;
      private String Z338NPacientePesoEn ;
      private String Z339NPacienteDireccion ;
      private String Z340NPacienteCorreo ;
      private String Z341NPacienteFacebook ;
      private String Z342NPacienteTelefono ;
      private String Z343NPacienteCelular ;
      private String Z344NPacienteEnfermedad ;
      private String Z345NPacienteMedicamento ;
      private String Z346NPacienteOperacion ;
      private String Z347NPacienteAlergia ;
      private String Z355NPacienteAnestesiaOtro ;
      private String Z356NPacienteAnestesiaComplica ;
      private String Z360NPacienteOtros ;
      private String Z144TipoPacCodigo ;
      private String Z317VendedorCodigo ;
      private String Z4UsuarioCodigo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbNPacienteSexo ;
      private GXCombobox cmbNPacienteEstaturaEn ;
      private GXCombobox cmbNPacientePesoEn ;
      private GXCheckbox chkNPacienteAnestesiaGeneral ;
      private GXCheckbox chkNPacienteAnestesiaEpidural ;
      private GXCheckbox chkNPacienteAnestesiaRaquidea ;
      private GXCheckbox chkNPacienteFuma ;
      private GXCheckbox chkNPacienteAlcohol ;
      private GXCombobox cmbNPacienteEstatus ;
      private IDataStoreProvider pr_default ;
      private int[] T001N9_A327NPacienteId ;
      private String[] T001N9_A328NPacienteNombre1 ;
      private String[] T001N9_A329NPacienteNombre2 ;
      private String[] T001N9_A330NPacienteApellido1 ;
      private String[] T001N9_A331NPacienteApellido2 ;
      private String[] T001N9_A332NPacienteApellido3 ;
      private DateTime[] T001N9_A333NPacienteFechaNac ;
      private String[] T001N9_A334NPacienteSexo ;
      private decimal[] T001N9_A335NPacienteEstatura ;
      private String[] T001N9_A336NPacienteEstaturaEn ;
      private decimal[] T001N9_A337NPacientePeso ;
      private String[] T001N9_A338NPacientePesoEn ;
      private String[] T001N9_A339NPacienteDireccion ;
      private String[] T001N9_A340NPacienteCorreo ;
      private String[] T001N9_A341NPacienteFacebook ;
      private String[] T001N9_A342NPacienteTelefono ;
      private String[] T001N9_A343NPacienteCelular ;
      private String[] T001N9_A344NPacienteEnfermedad ;
      private String[] T001N9_A345NPacienteMedicamento ;
      private String[] T001N9_A346NPacienteOperacion ;
      private String[] T001N9_A347NPacienteAlergia ;
      private short[] T001N9_A348NPacienteGesta ;
      private short[] T001N9_A349NPacienteParto ;
      private short[] T001N9_A350NPacienteCesarea ;
      private short[] T001N9_A351NPacienteAborto ;
      private short[] T001N9_A352NPacienteAnestesiaGeneral ;
      private short[] T001N9_A353NPacienteAnestesiaEpidural ;
      private short[] T001N9_A354NPacienteAnestesiaRaquidea ;
      private String[] T001N9_A355NPacienteAnestesiaOtro ;
      private String[] T001N9_A356NPacienteAnestesiaComplica ;
      private short[] T001N9_A357NPacienteFuma ;
      private short[] T001N9_A358NPacienteCigarros ;
      private short[] T001N9_A359NPacienteAlcohol ;
      private String[] T001N9_A360NPacienteOtros ;
      private DateTime[] T001N9_A361NPacienteFecha ;
      private String[] T001N9_A362NPacienteHora ;
      private short[] T001N9_A364NPacienteEstatus ;
      private String[] T001N9_A41ClinicaCodigo ;
      private String[] T001N9_A144TipoPacCodigo ;
      private bool[] T001N9_n144TipoPacCodigo ;
      private int[] T001N9_A313ProfesionId ;
      private int[] T001N9_A315ReligionId ;
      private String[] T001N9_A317VendedorCodigo ;
      private bool[] T001N9_n317VendedorCodigo ;
      private String[] T001N9_A4UsuarioCodigo ;
      private String[] T001N4_A41ClinicaCodigo ;
      private String[] T001N5_A41ClinicaCodigo ;
      private String[] T001N6_A41ClinicaCodigo ;
      private String[] T001N7_A41ClinicaCodigo ;
      private String[] T001N8_A4UsuarioCodigo ;
      private String[] T001N10_A41ClinicaCodigo ;
      private String[] T001N11_A41ClinicaCodigo ;
      private String[] T001N12_A41ClinicaCodigo ;
      private String[] T001N13_A41ClinicaCodigo ;
      private String[] T001N14_A4UsuarioCodigo ;
      private String[] T001N15_A41ClinicaCodigo ;
      private int[] T001N15_A327NPacienteId ;
      private int[] T001N3_A327NPacienteId ;
      private String[] T001N3_A328NPacienteNombre1 ;
      private String[] T001N3_A329NPacienteNombre2 ;
      private String[] T001N3_A330NPacienteApellido1 ;
      private String[] T001N3_A331NPacienteApellido2 ;
      private String[] T001N3_A332NPacienteApellido3 ;
      private DateTime[] T001N3_A333NPacienteFechaNac ;
      private String[] T001N3_A334NPacienteSexo ;
      private decimal[] T001N3_A335NPacienteEstatura ;
      private String[] T001N3_A336NPacienteEstaturaEn ;
      private decimal[] T001N3_A337NPacientePeso ;
      private String[] T001N3_A338NPacientePesoEn ;
      private String[] T001N3_A339NPacienteDireccion ;
      private String[] T001N3_A340NPacienteCorreo ;
      private String[] T001N3_A341NPacienteFacebook ;
      private String[] T001N3_A342NPacienteTelefono ;
      private String[] T001N3_A343NPacienteCelular ;
      private String[] T001N3_A344NPacienteEnfermedad ;
      private String[] T001N3_A345NPacienteMedicamento ;
      private String[] T001N3_A346NPacienteOperacion ;
      private String[] T001N3_A347NPacienteAlergia ;
      private short[] T001N3_A348NPacienteGesta ;
      private short[] T001N3_A349NPacienteParto ;
      private short[] T001N3_A350NPacienteCesarea ;
      private short[] T001N3_A351NPacienteAborto ;
      private short[] T001N3_A352NPacienteAnestesiaGeneral ;
      private short[] T001N3_A353NPacienteAnestesiaEpidural ;
      private short[] T001N3_A354NPacienteAnestesiaRaquidea ;
      private String[] T001N3_A355NPacienteAnestesiaOtro ;
      private String[] T001N3_A356NPacienteAnestesiaComplica ;
      private short[] T001N3_A357NPacienteFuma ;
      private short[] T001N3_A358NPacienteCigarros ;
      private short[] T001N3_A359NPacienteAlcohol ;
      private String[] T001N3_A360NPacienteOtros ;
      private DateTime[] T001N3_A361NPacienteFecha ;
      private String[] T001N3_A362NPacienteHora ;
      private short[] T001N3_A364NPacienteEstatus ;
      private String[] T001N3_A41ClinicaCodigo ;
      private String[] T001N3_A144TipoPacCodigo ;
      private bool[] T001N3_n144TipoPacCodigo ;
      private int[] T001N3_A313ProfesionId ;
      private int[] T001N3_A315ReligionId ;
      private String[] T001N3_A317VendedorCodigo ;
      private bool[] T001N3_n317VendedorCodigo ;
      private String[] T001N3_A4UsuarioCodigo ;
      private String[] T001N16_A41ClinicaCodigo ;
      private int[] T001N16_A327NPacienteId ;
      private String[] T001N17_A41ClinicaCodigo ;
      private int[] T001N17_A327NPacienteId ;
      private int[] T001N18_A327NPacienteId ;
      private String[] T001N18_A328NPacienteNombre1 ;
      private String[] T001N18_A329NPacienteNombre2 ;
      private String[] T001N18_A330NPacienteApellido1 ;
      private String[] T001N18_A331NPacienteApellido2 ;
      private String[] T001N18_A332NPacienteApellido3 ;
      private DateTime[] T001N18_A333NPacienteFechaNac ;
      private String[] T001N18_A334NPacienteSexo ;
      private decimal[] T001N18_A335NPacienteEstatura ;
      private String[] T001N18_A336NPacienteEstaturaEn ;
      private decimal[] T001N18_A337NPacientePeso ;
      private String[] T001N18_A338NPacientePesoEn ;
      private String[] T001N18_A339NPacienteDireccion ;
      private String[] T001N18_A340NPacienteCorreo ;
      private String[] T001N18_A341NPacienteFacebook ;
      private String[] T001N18_A342NPacienteTelefono ;
      private String[] T001N18_A343NPacienteCelular ;
      private String[] T001N18_A344NPacienteEnfermedad ;
      private String[] T001N18_A345NPacienteMedicamento ;
      private String[] T001N18_A346NPacienteOperacion ;
      private String[] T001N18_A347NPacienteAlergia ;
      private short[] T001N18_A348NPacienteGesta ;
      private short[] T001N18_A349NPacienteParto ;
      private short[] T001N18_A350NPacienteCesarea ;
      private short[] T001N18_A351NPacienteAborto ;
      private short[] T001N18_A352NPacienteAnestesiaGeneral ;
      private short[] T001N18_A353NPacienteAnestesiaEpidural ;
      private short[] T001N18_A354NPacienteAnestesiaRaquidea ;
      private String[] T001N18_A355NPacienteAnestesiaOtro ;
      private String[] T001N18_A356NPacienteAnestesiaComplica ;
      private short[] T001N18_A357NPacienteFuma ;
      private short[] T001N18_A358NPacienteCigarros ;
      private short[] T001N18_A359NPacienteAlcohol ;
      private String[] T001N18_A360NPacienteOtros ;
      private DateTime[] T001N18_A361NPacienteFecha ;
      private String[] T001N18_A362NPacienteHora ;
      private short[] T001N18_A364NPacienteEstatus ;
      private String[] T001N18_A41ClinicaCodigo ;
      private String[] T001N18_A144TipoPacCodigo ;
      private bool[] T001N18_n144TipoPacCodigo ;
      private int[] T001N18_A313ProfesionId ;
      private int[] T001N18_A315ReligionId ;
      private String[] T001N18_A317VendedorCodigo ;
      private bool[] T001N18_n317VendedorCodigo ;
      private String[] T001N18_A4UsuarioCodigo ;
      private String[] T001N22_A41ClinicaCodigo ;
      private int[] T001N22_A327NPacienteId ;
      private String[] T001N23_A41ClinicaCodigo ;
      private String[] T001N24_A41ClinicaCodigo ;
      private String[] T001N25_A4UsuarioCodigo ;
      private String[] T001N26_A41ClinicaCodigo ;
      private String[] T001N27_A41ClinicaCodigo ;
      private int[] T001N2_A327NPacienteId ;
      private String[] T001N2_A328NPacienteNombre1 ;
      private String[] T001N2_A329NPacienteNombre2 ;
      private String[] T001N2_A330NPacienteApellido1 ;
      private String[] T001N2_A331NPacienteApellido2 ;
      private String[] T001N2_A332NPacienteApellido3 ;
      private DateTime[] T001N2_A333NPacienteFechaNac ;
      private String[] T001N2_A334NPacienteSexo ;
      private decimal[] T001N2_A335NPacienteEstatura ;
      private String[] T001N2_A336NPacienteEstaturaEn ;
      private decimal[] T001N2_A337NPacientePeso ;
      private String[] T001N2_A338NPacientePesoEn ;
      private String[] T001N2_A339NPacienteDireccion ;
      private String[] T001N2_A340NPacienteCorreo ;
      private String[] T001N2_A341NPacienteFacebook ;
      private String[] T001N2_A342NPacienteTelefono ;
      private String[] T001N2_A343NPacienteCelular ;
      private String[] T001N2_A344NPacienteEnfermedad ;
      private String[] T001N2_A345NPacienteMedicamento ;
      private String[] T001N2_A346NPacienteOperacion ;
      private String[] T001N2_A347NPacienteAlergia ;
      private short[] T001N2_A348NPacienteGesta ;
      private short[] T001N2_A349NPacienteParto ;
      private short[] T001N2_A350NPacienteCesarea ;
      private short[] T001N2_A351NPacienteAborto ;
      private short[] T001N2_A352NPacienteAnestesiaGeneral ;
      private short[] T001N2_A353NPacienteAnestesiaEpidural ;
      private short[] T001N2_A354NPacienteAnestesiaRaquidea ;
      private String[] T001N2_A355NPacienteAnestesiaOtro ;
      private String[] T001N2_A356NPacienteAnestesiaComplica ;
      private short[] T001N2_A357NPacienteFuma ;
      private short[] T001N2_A358NPacienteCigarros ;
      private short[] T001N2_A359NPacienteAlcohol ;
      private String[] T001N2_A360NPacienteOtros ;
      private DateTime[] T001N2_A361NPacienteFecha ;
      private String[] T001N2_A362NPacienteHora ;
      private short[] T001N2_A364NPacienteEstatus ;
      private String[] T001N2_A41ClinicaCodigo ;
      private String[] T001N2_A144TipoPacCodigo ;
      private int[] T001N2_A313ProfesionId ;
      private int[] T001N2_A315ReligionId ;
      private String[] T001N2_A317VendedorCodigo ;
      private String[] T001N2_A4UsuarioCodigo ;
      private bool[] T001N2_n144TipoPacCodigo ;
      private bool[] T001N2_n317VendedorCodigo ;
      private GXWebForm Form ;
   }

   public class notapaciente__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT001N2 ;
          prmT001N2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@NPacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001N9 ;
          prmT001N9 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@NPacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001N4 ;
          prmT001N4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoPacCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001N5 ;
          prmT001N5 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ProfesionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001N6 ;
          prmT001N6 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ReligionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001N7 ;
          prmT001N7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@VendedorCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001N8 ;
          prmT001N8 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001N10 ;
          prmT001N10 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoPacCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001N11 ;
          prmT001N11 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ProfesionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001N12 ;
          prmT001N12 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ReligionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001N13 ;
          prmT001N13 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@VendedorCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001N14 ;
          prmT001N14 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001N15 ;
          prmT001N15 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@NPacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001N3 ;
          prmT001N3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@NPacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001N16 ;
          prmT001N16 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@NPacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001N17 ;
          prmT001N17 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@NPacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001N18 ;
          prmT001N18 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@NPacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001N19 ;
          prmT001N19 = new Object[] {
          new Object[] {"@NPacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@NPacienteNombre1",SqlDbType.VarChar,70,0} ,
          new Object[] {"@NPacienteNombre2",SqlDbType.VarChar,70,0} ,
          new Object[] {"@NPacienteApellido1",SqlDbType.VarChar,30,0} ,
          new Object[] {"@NPacienteApellido2",SqlDbType.VarChar,30,0} ,
          new Object[] {"@NPacienteApellido3",SqlDbType.VarChar,30,0} ,
          new Object[] {"@NPacienteFechaNac",SqlDbType.DateTime,8,0} ,
          new Object[] {"@NPacienteSexo",SqlDbType.VarChar,1,0} ,
          new Object[] {"@NPacienteEstatura",SqlDbType.Decimal,17,2} ,
          new Object[] {"@NPacienteEstaturaEn",SqlDbType.VarChar,2,0} ,
          new Object[] {"@NPacientePeso",SqlDbType.Decimal,17,2} ,
          new Object[] {"@NPacientePesoEn",SqlDbType.VarChar,2,0} ,
          new Object[] {"@NPacienteDireccion",SqlDbType.VarChar,120,0} ,
          new Object[] {"@NPacienteCorreo",SqlDbType.VarChar,80,0} ,
          new Object[] {"@NPacienteFacebook",SqlDbType.VarChar,80,0} ,
          new Object[] {"@NPacienteTelefono",SqlDbType.VarChar,9,0} ,
          new Object[] {"@NPacienteCelular",SqlDbType.VarChar,9,0} ,
          new Object[] {"@NPacienteEnfermedad",SqlDbType.VarChar,600,0} ,
          new Object[] {"@NPacienteMedicamento",SqlDbType.VarChar,600,0} ,
          new Object[] {"@NPacienteOperacion",SqlDbType.VarChar,600,0} ,
          new Object[] {"@NPacienteAlergia",SqlDbType.VarChar,600,0} ,
          new Object[] {"@NPacienteGesta",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@NPacienteParto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@NPacienteCesarea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@NPacienteAborto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@NPacienteAnestesiaGeneral",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@NPacienteAnestesiaEpidural",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@NPacienteAnestesiaRaquidea",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@NPacienteAnestesiaOtro",SqlDbType.VarChar,70,0} ,
          new Object[] {"@NPacienteAnestesiaComplica",SqlDbType.VarChar,600,0} ,
          new Object[] {"@NPacienteFuma",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@NPacienteCigarros",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@NPacienteAlcohol",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@NPacienteOtros",SqlDbType.VarChar,70,0} ,
          new Object[] {"@NPacienteFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@NPacienteHora",SqlDbType.Char,8,0} ,
          new Object[] {"@NPacienteEstatus",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoPacCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ProfesionId",SqlDbType.Int,9,0} ,
          new Object[] {"@ReligionId",SqlDbType.Int,9,0} ,
          new Object[] {"@VendedorCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001N20 ;
          prmT001N20 = new Object[] {
          new Object[] {"@NPacienteNombre1",SqlDbType.VarChar,70,0} ,
          new Object[] {"@NPacienteNombre2",SqlDbType.VarChar,70,0} ,
          new Object[] {"@NPacienteApellido1",SqlDbType.VarChar,30,0} ,
          new Object[] {"@NPacienteApellido2",SqlDbType.VarChar,30,0} ,
          new Object[] {"@NPacienteApellido3",SqlDbType.VarChar,30,0} ,
          new Object[] {"@NPacienteFechaNac",SqlDbType.DateTime,8,0} ,
          new Object[] {"@NPacienteSexo",SqlDbType.VarChar,1,0} ,
          new Object[] {"@NPacienteEstatura",SqlDbType.Decimal,17,2} ,
          new Object[] {"@NPacienteEstaturaEn",SqlDbType.VarChar,2,0} ,
          new Object[] {"@NPacientePeso",SqlDbType.Decimal,17,2} ,
          new Object[] {"@NPacientePesoEn",SqlDbType.VarChar,2,0} ,
          new Object[] {"@NPacienteDireccion",SqlDbType.VarChar,120,0} ,
          new Object[] {"@NPacienteCorreo",SqlDbType.VarChar,80,0} ,
          new Object[] {"@NPacienteFacebook",SqlDbType.VarChar,80,0} ,
          new Object[] {"@NPacienteTelefono",SqlDbType.VarChar,9,0} ,
          new Object[] {"@NPacienteCelular",SqlDbType.VarChar,9,0} ,
          new Object[] {"@NPacienteEnfermedad",SqlDbType.VarChar,600,0} ,
          new Object[] {"@NPacienteMedicamento",SqlDbType.VarChar,600,0} ,
          new Object[] {"@NPacienteOperacion",SqlDbType.VarChar,600,0} ,
          new Object[] {"@NPacienteAlergia",SqlDbType.VarChar,600,0} ,
          new Object[] {"@NPacienteGesta",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@NPacienteParto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@NPacienteCesarea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@NPacienteAborto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@NPacienteAnestesiaGeneral",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@NPacienteAnestesiaEpidural",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@NPacienteAnestesiaRaquidea",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@NPacienteAnestesiaOtro",SqlDbType.VarChar,70,0} ,
          new Object[] {"@NPacienteAnestesiaComplica",SqlDbType.VarChar,600,0} ,
          new Object[] {"@NPacienteFuma",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@NPacienteCigarros",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@NPacienteAlcohol",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@NPacienteOtros",SqlDbType.VarChar,70,0} ,
          new Object[] {"@NPacienteFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@NPacienteHora",SqlDbType.Char,8,0} ,
          new Object[] {"@NPacienteEstatus",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TipoPacCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ProfesionId",SqlDbType.Int,9,0} ,
          new Object[] {"@ReligionId",SqlDbType.Int,9,0} ,
          new Object[] {"@VendedorCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@NPacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001N21 ;
          prmT001N21 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@NPacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001N22 ;
          prmT001N22 = new Object[] {
          } ;
          Object[] prmT001N23 ;
          prmT001N23 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ProfesionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001N24 ;
          prmT001N24 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ReligionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001N25 ;
          prmT001N25 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001N26 ;
          prmT001N26 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoPacCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001N27 ;
          prmT001N27 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@VendedorCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T001N2", "SELECT [NPacienteId], [NPacienteNombre1], [NPacienteNombre2], [NPacienteApellido1], [NPacienteApellido2], [NPacienteApellido3], [NPacienteFechaNac], [NPacienteSexo], [NPacienteEstatura], [NPacienteEstaturaEn], [NPacientePeso], [NPacientePesoEn], [NPacienteDireccion], [NPacienteCorreo], [NPacienteFacebook], [NPacienteTelefono], [NPacienteCelular], [NPacienteEnfermedad], [NPacienteMedicamento], [NPacienteOperacion], [NPacienteAlergia], [NPacienteGesta], [NPacienteParto], [NPacienteCesarea], [NPacienteAborto], [NPacienteAnestesiaGeneral], [NPacienteAnestesiaEpidural], [NPacienteAnestesiaRaquidea], [NPacienteAnestesiaOtro], [NPacienteAnestesiaComplica], [NPacienteFuma], [NPacienteCigarros], [NPacienteAlcohol], [NPacienteOtros], [NPacienteFecha], [NPacienteHora], [NPacienteEstatus], [ClinicaCodigo], [TipoPacCodigo], [ProfesionId], [ReligionId], [VendedorCodigo], [UsuarioCodigo] FROM [NotaPaciente] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [NPacienteId] = @NPacienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001N2,1,0,true,false )
             ,new CursorDef("T001N3", "SELECT [NPacienteId], [NPacienteNombre1], [NPacienteNombre2], [NPacienteApellido1], [NPacienteApellido2], [NPacienteApellido3], [NPacienteFechaNac], [NPacienteSexo], [NPacienteEstatura], [NPacienteEstaturaEn], [NPacientePeso], [NPacientePesoEn], [NPacienteDireccion], [NPacienteCorreo], [NPacienteFacebook], [NPacienteTelefono], [NPacienteCelular], [NPacienteEnfermedad], [NPacienteMedicamento], [NPacienteOperacion], [NPacienteAlergia], [NPacienteGesta], [NPacienteParto], [NPacienteCesarea], [NPacienteAborto], [NPacienteAnestesiaGeneral], [NPacienteAnestesiaEpidural], [NPacienteAnestesiaRaquidea], [NPacienteAnestesiaOtro], [NPacienteAnestesiaComplica], [NPacienteFuma], [NPacienteCigarros], [NPacienteAlcohol], [NPacienteOtros], [NPacienteFecha], [NPacienteHora], [NPacienteEstatus], [ClinicaCodigo], [TipoPacCodigo], [ProfesionId], [ReligionId], [VendedorCodigo], [UsuarioCodigo] FROM [NotaPaciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [NPacienteId] = @NPacienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001N3,1,0,true,false )
             ,new CursorDef("T001N4", "SELECT [ClinicaCodigo] FROM [TipoPaciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoPacCodigo] = @TipoPacCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001N4,1,0,true,false )
             ,new CursorDef("T001N5", "SELECT [ClinicaCodigo] FROM [Profesion] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ProfesionId] = @ProfesionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001N5,1,0,true,false )
             ,new CursorDef("T001N6", "SELECT [ClinicaCodigo] FROM [Religion] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ReligionId] = @ReligionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001N6,1,0,true,false )
             ,new CursorDef("T001N7", "SELECT [ClinicaCodigo] FROM [Vendedor] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [VendedorCodigo] = @VendedorCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001N7,1,0,true,false )
             ,new CursorDef("T001N8", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001N8,1,0,true,false )
             ,new CursorDef("T001N9", "SELECT TM1.[NPacienteId], TM1.[NPacienteNombre1], TM1.[NPacienteNombre2], TM1.[NPacienteApellido1], TM1.[NPacienteApellido2], TM1.[NPacienteApellido3], TM1.[NPacienteFechaNac], TM1.[NPacienteSexo], TM1.[NPacienteEstatura], TM1.[NPacienteEstaturaEn], TM1.[NPacientePeso], TM1.[NPacientePesoEn], TM1.[NPacienteDireccion], TM1.[NPacienteCorreo], TM1.[NPacienteFacebook], TM1.[NPacienteTelefono], TM1.[NPacienteCelular], TM1.[NPacienteEnfermedad], TM1.[NPacienteMedicamento], TM1.[NPacienteOperacion], TM1.[NPacienteAlergia], TM1.[NPacienteGesta], TM1.[NPacienteParto], TM1.[NPacienteCesarea], TM1.[NPacienteAborto], TM1.[NPacienteAnestesiaGeneral], TM1.[NPacienteAnestesiaEpidural], TM1.[NPacienteAnestesiaRaquidea], TM1.[NPacienteAnestesiaOtro], TM1.[NPacienteAnestesiaComplica], TM1.[NPacienteFuma], TM1.[NPacienteCigarros], TM1.[NPacienteAlcohol], TM1.[NPacienteOtros], TM1.[NPacienteFecha], TM1.[NPacienteHora], TM1.[NPacienteEstatus], TM1.[ClinicaCodigo], TM1.[TipoPacCodigo], TM1.[ProfesionId], TM1.[ReligionId], TM1.[VendedorCodigo], TM1.[UsuarioCodigo] FROM [NotaPaciente] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[NPacienteId] = @NPacienteId ORDER BY TM1.[ClinicaCodigo], TM1.[NPacienteId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001N9,100,0,true,false )
             ,new CursorDef("T001N10", "SELECT [ClinicaCodigo] FROM [TipoPaciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoPacCodigo] = @TipoPacCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001N10,1,0,true,false )
             ,new CursorDef("T001N11", "SELECT [ClinicaCodigo] FROM [Profesion] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ProfesionId] = @ProfesionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001N11,1,0,true,false )
             ,new CursorDef("T001N12", "SELECT [ClinicaCodigo] FROM [Religion] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ReligionId] = @ReligionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001N12,1,0,true,false )
             ,new CursorDef("T001N13", "SELECT [ClinicaCodigo] FROM [Vendedor] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [VendedorCodigo] = @VendedorCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001N13,1,0,true,false )
             ,new CursorDef("T001N14", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001N14,1,0,true,false )
             ,new CursorDef("T001N15", "SELECT [ClinicaCodigo], [NPacienteId] FROM [NotaPaciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [NPacienteId] = @NPacienteId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001N15,1,0,true,false )
             ,new CursorDef("T001N16", "SELECT TOP 1 [ClinicaCodigo], [NPacienteId] FROM [NotaPaciente] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [NPacienteId] > @NPacienteId) ORDER BY [ClinicaCodigo], [NPacienteId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001N16,1,0,true,true )
             ,new CursorDef("T001N17", "SELECT TOP 1 [ClinicaCodigo], [NPacienteId] FROM [NotaPaciente] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [NPacienteId] < @NPacienteId) ORDER BY [ClinicaCodigo] DESC, [NPacienteId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001N17,1,0,true,true )
             ,new CursorDef("T001N18", "SELECT [NPacienteId], [NPacienteNombre1], [NPacienteNombre2], [NPacienteApellido1], [NPacienteApellido2], [NPacienteApellido3], [NPacienteFechaNac], [NPacienteSexo], [NPacienteEstatura], [NPacienteEstaturaEn], [NPacientePeso], [NPacientePesoEn], [NPacienteDireccion], [NPacienteCorreo], [NPacienteFacebook], [NPacienteTelefono], [NPacienteCelular], [NPacienteEnfermedad], [NPacienteMedicamento], [NPacienteOperacion], [NPacienteAlergia], [NPacienteGesta], [NPacienteParto], [NPacienteCesarea], [NPacienteAborto], [NPacienteAnestesiaGeneral], [NPacienteAnestesiaEpidural], [NPacienteAnestesiaRaquidea], [NPacienteAnestesiaOtro], [NPacienteAnestesiaComplica], [NPacienteFuma], [NPacienteCigarros], [NPacienteAlcohol], [NPacienteOtros], [NPacienteFecha], [NPacienteHora], [NPacienteEstatus], [ClinicaCodigo], [TipoPacCodigo], [ProfesionId], [ReligionId], [VendedorCodigo], [UsuarioCodigo] FROM [NotaPaciente] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [NPacienteId] = @NPacienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001N18,1,0,true,false )
             ,new CursorDef("T001N19", "INSERT INTO [NotaPaciente] ([NPacienteId], [NPacienteNombre1], [NPacienteNombre2], [NPacienteApellido1], [NPacienteApellido2], [NPacienteApellido3], [NPacienteFechaNac], [NPacienteSexo], [NPacienteEstatura], [NPacienteEstaturaEn], [NPacientePeso], [NPacientePesoEn], [NPacienteDireccion], [NPacienteCorreo], [NPacienteFacebook], [NPacienteTelefono], [NPacienteCelular], [NPacienteEnfermedad], [NPacienteMedicamento], [NPacienteOperacion], [NPacienteAlergia], [NPacienteGesta], [NPacienteParto], [NPacienteCesarea], [NPacienteAborto], [NPacienteAnestesiaGeneral], [NPacienteAnestesiaEpidural], [NPacienteAnestesiaRaquidea], [NPacienteAnestesiaOtro], [NPacienteAnestesiaComplica], [NPacienteFuma], [NPacienteCigarros], [NPacienteAlcohol], [NPacienteOtros], [NPacienteFecha], [NPacienteHora], [NPacienteEstatus], [ClinicaCodigo], [TipoPacCodigo], [ProfesionId], [ReligionId], [VendedorCodigo], [UsuarioCodigo]) VALUES (@NPacienteId, @NPacienteNombre1, @NPacienteNombre2, @NPacienteApellido1, @NPacienteApellido2, @NPacienteApellido3, @NPacienteFechaNac, @NPacienteSexo, @NPacienteEstatura, @NPacienteEstaturaEn, @NPacientePeso, @NPacientePesoEn, @NPacienteDireccion, @NPacienteCorreo, @NPacienteFacebook, @NPacienteTelefono, @NPacienteCelular, @NPacienteEnfermedad, @NPacienteMedicamento, @NPacienteOperacion, @NPacienteAlergia, @NPacienteGesta, @NPacienteParto, @NPacienteCesarea, @NPacienteAborto, @NPacienteAnestesiaGeneral, @NPacienteAnestesiaEpidural, @NPacienteAnestesiaRaquidea, @NPacienteAnestesiaOtro, @NPacienteAnestesiaComplica, @NPacienteFuma, @NPacienteCigarros, @NPacienteAlcohol, @NPacienteOtros, @NPacienteFecha, @NPacienteHora, @NPacienteEstatus, @ClinicaCodigo, @TipoPacCodigo, @ProfesionId, @ReligionId, @VendedorCodigo, @UsuarioCodigo)", GxErrorMask.GX_NOMASK,prmT001N19)
             ,new CursorDef("T001N20", "UPDATE [NotaPaciente] SET [NPacienteNombre1]=@NPacienteNombre1, [NPacienteNombre2]=@NPacienteNombre2, [NPacienteApellido1]=@NPacienteApellido1, [NPacienteApellido2]=@NPacienteApellido2, [NPacienteApellido3]=@NPacienteApellido3, [NPacienteFechaNac]=@NPacienteFechaNac, [NPacienteSexo]=@NPacienteSexo, [NPacienteEstatura]=@NPacienteEstatura, [NPacienteEstaturaEn]=@NPacienteEstaturaEn, [NPacientePeso]=@NPacientePeso, [NPacientePesoEn]=@NPacientePesoEn, [NPacienteDireccion]=@NPacienteDireccion, [NPacienteCorreo]=@NPacienteCorreo, [NPacienteFacebook]=@NPacienteFacebook, [NPacienteTelefono]=@NPacienteTelefono, [NPacienteCelular]=@NPacienteCelular, [NPacienteEnfermedad]=@NPacienteEnfermedad, [NPacienteMedicamento]=@NPacienteMedicamento, [NPacienteOperacion]=@NPacienteOperacion, [NPacienteAlergia]=@NPacienteAlergia, [NPacienteGesta]=@NPacienteGesta, [NPacienteParto]=@NPacienteParto, [NPacienteCesarea]=@NPacienteCesarea, [NPacienteAborto]=@NPacienteAborto, [NPacienteAnestesiaGeneral]=@NPacienteAnestesiaGeneral, [NPacienteAnestesiaEpidural]=@NPacienteAnestesiaEpidural, [NPacienteAnestesiaRaquidea]=@NPacienteAnestesiaRaquidea, [NPacienteAnestesiaOtro]=@NPacienteAnestesiaOtro, [NPacienteAnestesiaComplica]=@NPacienteAnestesiaComplica, [NPacienteFuma]=@NPacienteFuma, [NPacienteCigarros]=@NPacienteCigarros, [NPacienteAlcohol]=@NPacienteAlcohol, [NPacienteOtros]=@NPacienteOtros, [NPacienteFecha]=@NPacienteFecha, [NPacienteHora]=@NPacienteHora, [NPacienteEstatus]=@NPacienteEstatus, [TipoPacCodigo]=@TipoPacCodigo, [ProfesionId]=@ProfesionId, [ReligionId]=@ReligionId, [VendedorCodigo]=@VendedorCodigo, [UsuarioCodigo]=@UsuarioCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [NPacienteId] = @NPacienteId", GxErrorMask.GX_NOMASK,prmT001N20)
             ,new CursorDef("T001N21", "DELETE FROM [NotaPaciente]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [NPacienteId] = @NPacienteId", GxErrorMask.GX_NOMASK,prmT001N21)
             ,new CursorDef("T001N22", "SELECT [ClinicaCodigo], [NPacienteId] FROM [NotaPaciente] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [NPacienteId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001N22,100,0,true,false )
             ,new CursorDef("T001N23", "SELECT [ClinicaCodigo] FROM [Profesion] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ProfesionId] = @ProfesionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001N23,1,0,true,false )
             ,new CursorDef("T001N24", "SELECT [ClinicaCodigo] FROM [Religion] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ReligionId] = @ReligionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001N24,1,0,true,false )
             ,new CursorDef("T001N25", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001N25,1,0,true,false )
             ,new CursorDef("T001N26", "SELECT [ClinicaCodigo] FROM [TipoPaciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoPacCodigo] = @TipoPacCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001N26,1,0,true,false )
             ,new CursorDef("T001N27", "SELECT [ClinicaCodigo] FROM [Vendedor] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [VendedorCodigo] = @VendedorCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001N27,1,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((decimal[]) buf[8])[0] = rslt.getDecimal(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                ((decimal[]) buf[10])[0] = rslt.getDecimal(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                ((String[]) buf[14])[0] = rslt.getVarchar(15) ;
                ((String[]) buf[15])[0] = rslt.getVarchar(16) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(17) ;
                ((String[]) buf[17])[0] = rslt.getVarchar(18) ;
                ((String[]) buf[18])[0] = rslt.getVarchar(19) ;
                ((String[]) buf[19])[0] = rslt.getVarchar(20) ;
                ((String[]) buf[20])[0] = rslt.getVarchar(21) ;
                ((short[]) buf[21])[0] = rslt.getShort(22) ;
                ((short[]) buf[22])[0] = rslt.getShort(23) ;
                ((short[]) buf[23])[0] = rslt.getShort(24) ;
                ((short[]) buf[24])[0] = rslt.getShort(25) ;
                ((short[]) buf[25])[0] = rslt.getShort(26) ;
                ((short[]) buf[26])[0] = rslt.getShort(27) ;
                ((short[]) buf[27])[0] = rslt.getShort(28) ;
                ((String[]) buf[28])[0] = rslt.getVarchar(29) ;
                ((String[]) buf[29])[0] = rslt.getVarchar(30) ;
                ((short[]) buf[30])[0] = rslt.getShort(31) ;
                ((short[]) buf[31])[0] = rslt.getShort(32) ;
                ((short[]) buf[32])[0] = rslt.getShort(33) ;
                ((String[]) buf[33])[0] = rslt.getVarchar(34) ;
                ((DateTime[]) buf[34])[0] = rslt.getGXDate(35) ;
                ((String[]) buf[35])[0] = rslt.getString(36, 8) ;
                ((short[]) buf[36])[0] = rslt.getShort(37) ;
                ((String[]) buf[37])[0] = rslt.getVarchar(38) ;
                ((String[]) buf[38])[0] = rslt.getVarchar(39) ;
                ((bool[]) buf[39])[0] = rslt.wasNull(39);
                ((int[]) buf[40])[0] = rslt.getInt(40) ;
                ((int[]) buf[41])[0] = rslt.getInt(41) ;
                ((String[]) buf[42])[0] = rslt.getVarchar(42) ;
                ((bool[]) buf[43])[0] = rslt.wasNull(42);
                ((String[]) buf[44])[0] = rslt.getVarchar(43) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((decimal[]) buf[8])[0] = rslt.getDecimal(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                ((decimal[]) buf[10])[0] = rslt.getDecimal(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                ((String[]) buf[14])[0] = rslt.getVarchar(15) ;
                ((String[]) buf[15])[0] = rslt.getVarchar(16) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(17) ;
                ((String[]) buf[17])[0] = rslt.getVarchar(18) ;
                ((String[]) buf[18])[0] = rslt.getVarchar(19) ;
                ((String[]) buf[19])[0] = rslt.getVarchar(20) ;
                ((String[]) buf[20])[0] = rslt.getVarchar(21) ;
                ((short[]) buf[21])[0] = rslt.getShort(22) ;
                ((short[]) buf[22])[0] = rslt.getShort(23) ;
                ((short[]) buf[23])[0] = rslt.getShort(24) ;
                ((short[]) buf[24])[0] = rslt.getShort(25) ;
                ((short[]) buf[25])[0] = rslt.getShort(26) ;
                ((short[]) buf[26])[0] = rslt.getShort(27) ;
                ((short[]) buf[27])[0] = rslt.getShort(28) ;
                ((String[]) buf[28])[0] = rslt.getVarchar(29) ;
                ((String[]) buf[29])[0] = rslt.getVarchar(30) ;
                ((short[]) buf[30])[0] = rslt.getShort(31) ;
                ((short[]) buf[31])[0] = rslt.getShort(32) ;
                ((short[]) buf[32])[0] = rslt.getShort(33) ;
                ((String[]) buf[33])[0] = rslt.getVarchar(34) ;
                ((DateTime[]) buf[34])[0] = rslt.getGXDate(35) ;
                ((String[]) buf[35])[0] = rslt.getString(36, 8) ;
                ((short[]) buf[36])[0] = rslt.getShort(37) ;
                ((String[]) buf[37])[0] = rslt.getVarchar(38) ;
                ((String[]) buf[38])[0] = rslt.getVarchar(39) ;
                ((bool[]) buf[39])[0] = rslt.wasNull(39);
                ((int[]) buf[40])[0] = rslt.getInt(40) ;
                ((int[]) buf[41])[0] = rslt.getInt(41) ;
                ((String[]) buf[42])[0] = rslt.getVarchar(42) ;
                ((bool[]) buf[43])[0] = rslt.wasNull(42);
                ((String[]) buf[44])[0] = rslt.getVarchar(43) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((decimal[]) buf[8])[0] = rslt.getDecimal(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                ((decimal[]) buf[10])[0] = rslt.getDecimal(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                ((String[]) buf[14])[0] = rslt.getVarchar(15) ;
                ((String[]) buf[15])[0] = rslt.getVarchar(16) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(17) ;
                ((String[]) buf[17])[0] = rslt.getVarchar(18) ;
                ((String[]) buf[18])[0] = rslt.getVarchar(19) ;
                ((String[]) buf[19])[0] = rslt.getVarchar(20) ;
                ((String[]) buf[20])[0] = rslt.getVarchar(21) ;
                ((short[]) buf[21])[0] = rslt.getShort(22) ;
                ((short[]) buf[22])[0] = rslt.getShort(23) ;
                ((short[]) buf[23])[0] = rslt.getShort(24) ;
                ((short[]) buf[24])[0] = rslt.getShort(25) ;
                ((short[]) buf[25])[0] = rslt.getShort(26) ;
                ((short[]) buf[26])[0] = rslt.getShort(27) ;
                ((short[]) buf[27])[0] = rslt.getShort(28) ;
                ((String[]) buf[28])[0] = rslt.getVarchar(29) ;
                ((String[]) buf[29])[0] = rslt.getVarchar(30) ;
                ((short[]) buf[30])[0] = rslt.getShort(31) ;
                ((short[]) buf[31])[0] = rslt.getShort(32) ;
                ((short[]) buf[32])[0] = rslt.getShort(33) ;
                ((String[]) buf[33])[0] = rslt.getVarchar(34) ;
                ((DateTime[]) buf[34])[0] = rslt.getGXDate(35) ;
                ((String[]) buf[35])[0] = rslt.getString(36, 8) ;
                ((short[]) buf[36])[0] = rslt.getShort(37) ;
                ((String[]) buf[37])[0] = rslt.getVarchar(38) ;
                ((String[]) buf[38])[0] = rslt.getVarchar(39) ;
                ((bool[]) buf[39])[0] = rslt.wasNull(39);
                ((int[]) buf[40])[0] = rslt.getInt(40) ;
                ((int[]) buf[41])[0] = rslt.getInt(41) ;
                ((String[]) buf[42])[0] = rslt.getVarchar(42) ;
                ((bool[]) buf[43])[0] = rslt.wasNull(42);
                ((String[]) buf[44])[0] = rslt.getVarchar(43) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((decimal[]) buf[8])[0] = rslt.getDecimal(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                ((decimal[]) buf[10])[0] = rslt.getDecimal(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                ((String[]) buf[14])[0] = rslt.getVarchar(15) ;
                ((String[]) buf[15])[0] = rslt.getVarchar(16) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(17) ;
                ((String[]) buf[17])[0] = rslt.getVarchar(18) ;
                ((String[]) buf[18])[0] = rslt.getVarchar(19) ;
                ((String[]) buf[19])[0] = rslt.getVarchar(20) ;
                ((String[]) buf[20])[0] = rslt.getVarchar(21) ;
                ((short[]) buf[21])[0] = rslt.getShort(22) ;
                ((short[]) buf[22])[0] = rslt.getShort(23) ;
                ((short[]) buf[23])[0] = rslt.getShort(24) ;
                ((short[]) buf[24])[0] = rslt.getShort(25) ;
                ((short[]) buf[25])[0] = rslt.getShort(26) ;
                ((short[]) buf[26])[0] = rslt.getShort(27) ;
                ((short[]) buf[27])[0] = rslt.getShort(28) ;
                ((String[]) buf[28])[0] = rslt.getVarchar(29) ;
                ((String[]) buf[29])[0] = rslt.getVarchar(30) ;
                ((short[]) buf[30])[0] = rslt.getShort(31) ;
                ((short[]) buf[31])[0] = rslt.getShort(32) ;
                ((short[]) buf[32])[0] = rslt.getShort(33) ;
                ((String[]) buf[33])[0] = rslt.getVarchar(34) ;
                ((DateTime[]) buf[34])[0] = rslt.getGXDate(35) ;
                ((String[]) buf[35])[0] = rslt.getString(36, 8) ;
                ((short[]) buf[36])[0] = rslt.getShort(37) ;
                ((String[]) buf[37])[0] = rslt.getVarchar(38) ;
                ((String[]) buf[38])[0] = rslt.getVarchar(39) ;
                ((bool[]) buf[39])[0] = rslt.wasNull(39);
                ((int[]) buf[40])[0] = rslt.getInt(40) ;
                ((int[]) buf[41])[0] = rslt.getInt(41) ;
                ((String[]) buf[42])[0] = rslt.getVarchar(42) ;
                ((bool[]) buf[43])[0] = rslt.wasNull(42);
                ((String[]) buf[44])[0] = rslt.getVarchar(43) ;
                break;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 23 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 24 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 25 :
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
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 2 :
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
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
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
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
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
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
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
                stmt.SetParameter(1, (String)parms[0]);
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (DateTime)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (decimal)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                stmt.SetParameter(11, (decimal)parms[10]);
                stmt.SetParameter(12, (String)parms[11]);
                stmt.SetParameter(13, (String)parms[12]);
                stmt.SetParameter(14, (String)parms[13]);
                stmt.SetParameter(15, (String)parms[14]);
                stmt.SetParameter(16, (String)parms[15]);
                stmt.SetParameter(17, (String)parms[16]);
                stmt.SetParameter(18, (String)parms[17]);
                stmt.SetParameter(19, (String)parms[18]);
                stmt.SetParameter(20, (String)parms[19]);
                stmt.SetParameter(21, (String)parms[20]);
                stmt.SetParameter(22, (short)parms[21]);
                stmt.SetParameter(23, (short)parms[22]);
                stmt.SetParameter(24, (short)parms[23]);
                stmt.SetParameter(25, (short)parms[24]);
                stmt.SetParameter(26, (short)parms[25]);
                stmt.SetParameter(27, (short)parms[26]);
                stmt.SetParameter(28, (short)parms[27]);
                stmt.SetParameter(29, (String)parms[28]);
                stmt.SetParameter(30, (String)parms[29]);
                stmt.SetParameter(31, (short)parms[30]);
                stmt.SetParameter(32, (short)parms[31]);
                stmt.SetParameter(33, (short)parms[32]);
                stmt.SetParameter(34, (String)parms[33]);
                stmt.SetParameter(35, (DateTime)parms[34]);
                stmt.SetParameter(36, (String)parms[35]);
                stmt.SetParameter(37, (short)parms[36]);
                stmt.SetParameter(38, (String)parms[37]);
                if ( (bool)parms[38] )
                {
                   stmt.setNull( 39 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(39, (String)parms[39]);
                }
                stmt.SetParameter(40, (int)parms[40]);
                stmt.SetParameter(41, (int)parms[41]);
                if ( (bool)parms[42] )
                {
                   stmt.setNull( 42 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(42, (String)parms[43]);
                }
                stmt.SetParameter(43, (String)parms[44]);
                break;
             case 18 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (DateTime)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (decimal)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (decimal)parms[9]);
                stmt.SetParameter(11, (String)parms[10]);
                stmt.SetParameter(12, (String)parms[11]);
                stmt.SetParameter(13, (String)parms[12]);
                stmt.SetParameter(14, (String)parms[13]);
                stmt.SetParameter(15, (String)parms[14]);
                stmt.SetParameter(16, (String)parms[15]);
                stmt.SetParameter(17, (String)parms[16]);
                stmt.SetParameter(18, (String)parms[17]);
                stmt.SetParameter(19, (String)parms[18]);
                stmt.SetParameter(20, (String)parms[19]);
                stmt.SetParameter(21, (short)parms[20]);
                stmt.SetParameter(22, (short)parms[21]);
                stmt.SetParameter(23, (short)parms[22]);
                stmt.SetParameter(24, (short)parms[23]);
                stmt.SetParameter(25, (short)parms[24]);
                stmt.SetParameter(26, (short)parms[25]);
                stmt.SetParameter(27, (short)parms[26]);
                stmt.SetParameter(28, (String)parms[27]);
                stmt.SetParameter(29, (String)parms[28]);
                stmt.SetParameter(30, (short)parms[29]);
                stmt.SetParameter(31, (short)parms[30]);
                stmt.SetParameter(32, (short)parms[31]);
                stmt.SetParameter(33, (String)parms[32]);
                stmt.SetParameter(34, (DateTime)parms[33]);
                stmt.SetParameter(35, (String)parms[34]);
                stmt.SetParameter(36, (short)parms[35]);
                if ( (bool)parms[36] )
                {
                   stmt.setNull( 37 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(37, (String)parms[37]);
                }
                stmt.SetParameter(38, (int)parms[38]);
                stmt.SetParameter(39, (int)parms[39]);
                if ( (bool)parms[40] )
                {
                   stmt.setNull( 40 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(40, (String)parms[41]);
                }
                stmt.SetParameter(41, (String)parms[42]);
                stmt.SetParameter(42, (String)parms[43]);
                stmt.SetParameter(43, (int)parms[44]);
                break;
             case 19 :
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
             case 23 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 24 :
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
             case 25 :
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
