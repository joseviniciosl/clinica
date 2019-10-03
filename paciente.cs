/*
               File: Paciente
        Description: Pacientes
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:4:56.14
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
   public class paciente : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"TIPOPACCODIGO") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            GXDLATIPOPACCODIGO0H23( A41ClinicaCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"RELIGIONID") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            GXDLARELIGIONID0H23( A41ClinicaCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"PROFESIONID") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            GXDLAPROFESIONID0H23( A41ClinicaCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_9") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A144TipoPacCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144TipoPacCodigo", A144TipoPacCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_9( A41ClinicaCodigo, A144TipoPacCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_10") == 0 )
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
            gxLoad_10( A41ClinicaCodigo, A313ProfesionId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_11") == 0 )
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
            gxLoad_11( A41ClinicaCodigo, A315ReligionId) ;
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
         if ( ! entryPointCalled )
         {
            A67PacienteId = (int)(NumberUtil.Val( gxfirstwebparm, ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               Gx_mode = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               AV10Flag = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10Flag", StringUtil.Str( (decimal)(AV10Flag), 1, 0));
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            GxWebError = 1 ;
            context.HttpContext.Response.StatusDescription = 403.ToString();
            context.WriteHtmlText( "<title>403 Forbidden</title>") ;
            context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
            context.WriteHtmlText( "<p /><hr />") ;
         }
         if ( ( GxWebError == 0 ) && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
         {
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            GXDecQS = Crypto.Decrypt64( context.GetRequestQueryString( ), GXKey) ;
            if ( StringUtil.StrCmp(StringUtil.Right( GXDecQS, 6), Crypto.CheckSum( StringUtil.Left( GXDecQS, (short)(StringUtil.Len( GXDecQS)-6)), 6)) == 0 )
            {
               SetQueryString( StringUtil.Left( GXDecQS, (short)(StringUtil.Len( GXDecQS)-6))) ;
            }
            else
            {
               GxWebError = 1 ;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
            }
         }
         if ( ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
         {
            entryPointCalled = false ;
            gxfirstwebparm = GetNextPar( ) ;
            if ( ! entryPointCalled )
            {
               A67PacienteId = (int)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  Gx_mode = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  AV10Flag = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10Flag", StringUtil.Str( (decimal)(AV10Flag), 1, 0));
               }
            }
         }
         cmbPacienteSexo.Name = "PACIENTESEXO" ;
         cmbPacienteSexo.WebTags = "" ;
         cmbPacienteSexo.addItem("M", "Masculino", 0);
         cmbPacienteSexo.addItem("F", "Femenino", 0);
         if ( ( cmbPacienteSexo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A326PacienteSexo)) )
         {
            A326PacienteSexo = cmbPacienteSexo.getItemValue(1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A326PacienteSexo", A326PacienteSexo);
         }
         dynTipoPacCodigo.Name = "TIPOPACCODIGO" ;
         dynTipoPacCodigo.WebTags = "" ;
         dynReligionId.Name = "RELIGIONID" ;
         dynReligionId.WebTags = "" ;
         dynProfesionId.Name = "PROFESIONID" ;
         dynProfesionId.WebTags = "" ;
         cmbPacienteEstado.Name = "PACIENTEESTADO" ;
         cmbPacienteEstado.WebTags = "" ;
         cmbPacienteEstado.addItem("0", "De baja", 0);
         cmbPacienteEstado.addItem("1", "Activo", 0);
         if ( ( cmbPacienteEstado.ItemCount > 0 ) && (0==A81PacienteEstado) )
         {
            A81PacienteEstado = (short)(NumberUtil.Val( cmbPacienteEstado.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A81PacienteEstado", StringUtil.Str( (decimal)(A81PacienteEstado), 1, 0));
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Pacientes", 0) ;
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

      public paciente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public paciente( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref int aP0_PacienteId ,
                           ref String aP1_Gx_mode ,
                           ref short aP2_Flag )
      {
         this.A67PacienteId = aP0_PacienteId;
         this.Gx_mode = aP1_Gx_mode;
         this.AV10Flag = aP2_Flag;
         executePrivate();
         aP0_PacienteId=this.A67PacienteId;
         aP1_Gx_mode=this.Gx_mode;
         aP2_Flag=this.AV10Flag;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbPacienteSexo = new GXCombobox();
         dynTipoPacCodigo = new GXCombobox();
         dynReligionId = new GXCombobox();
         dynProfesionId = new GXCombobox();
         cmbPacienteEstado = new GXCombobox();
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
            wb_table1_2_0H23( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0H23e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0H23( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0H23( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0H23e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Pacientes"+"</legend>") ;
            wb_table3_27_0H23( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0H23e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0H23e( true) ;
         }
         else
         {
            wb_table1_2_0H23e( false) ;
         }
      }

      protected void wb_table3_27_0H23( bool wbgen )
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
            wb_table4_33_0H23( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0H23e( bool wbgen )
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Paciente.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 132,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Paciente.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 133,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 0, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0H23e( true) ;
         }
         else
         {
            wb_table3_27_0H23e( false) ;
         }
      }

      protected void wb_table4_33_0H23( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", lblTextblockclinicacodigo_Visible, 1, 0, "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", edtClinicaCodigo_Visible, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacienteid_Internalname, "Paciente", "", "", lblTextblockpacienteid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPacienteId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A67PacienteId), 9, 0, ".", "")), ((edtPacienteId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A67PacienteId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A67PacienteId), "ZZZZZZZZ9")), "", "", "", "", "", edtPacienteId_Jsonclick, 0, ClassString, StyleString, "", 1, edtPacienteId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Paciente.htm");
            context.WriteHtmlText( "&nbsp;") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacientenombre1_Internalname, "Primer Nombre", "", "", lblTextblockpacientenombre1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68PacienteNombre1", A68PacienteNombre1);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPacienteNombre1_Internalname, StringUtil.RTrim( A68PacienteNombre1), StringUtil.RTrim( context.localUtil.Format( A68PacienteNombre1, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", "", "", "", edtPacienteNombre1_Jsonclick, 0, ClassString, StyleString, "", 1, edtPacienteNombre1_Enabled, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacientenombre2_Internalname, "Segundo Nombre", "", "", lblTextblockpacientenombre2_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69PacienteNombre2", A69PacienteNombre2);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPacienteNombre2_Internalname, StringUtil.RTrim( A69PacienteNombre2), StringUtil.RTrim( context.localUtil.Format( A69PacienteNombre2, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "", "", "", "", edtPacienteNombre2_Jsonclick, 0, ClassString, StyleString, "", 1, edtPacienteNombre2_Enabled, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacienteapellido1_Internalname, "Primer Apellido", "", "", lblTextblockpacienteapellido1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70PacienteApellido1", A70PacienteApellido1);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPacienteApellido1_Internalname, StringUtil.RTrim( A70PacienteApellido1), StringUtil.RTrim( context.localUtil.Format( A70PacienteApellido1, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", "", "", "", "", edtPacienteApellido1_Jsonclick, 0, ClassString, StyleString, "", 1, edtPacienteApellido1_Enabled, 0, 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, true, "left", "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacienteapellido2_Internalname, "Segundo Apellido", "", "", lblTextblockpacienteapellido2_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71PacienteApellido2", A71PacienteApellido2);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPacienteApellido2_Internalname, StringUtil.RTrim( A71PacienteApellido2), StringUtil.RTrim( context.localUtil.Format( A71PacienteApellido2, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", "", "", "", "", edtPacienteApellido2_Jsonclick, 0, ClassString, StyleString, "", 1, edtPacienteApellido2_Enabled, 0, 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, true, "left", "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacienteapellido3_Internalname, "Apellido de Casada", "", "", lblTextblockpacienteapellido3_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A72PacienteApellido3", A72PacienteApellido3);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPacienteApellido3_Internalname, StringUtil.RTrim( A72PacienteApellido3), StringUtil.RTrim( context.localUtil.Format( A72PacienteApellido3, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", "", "", "", "", edtPacienteApellido3_Jsonclick, 0, ClassString, StyleString, "", 1, edtPacienteApellido3_Enabled, 0, 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, true, "left", "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacientegenero_Internalname, "Sexo", "", "", lblTextblockpacientegenero_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A326PacienteSexo", A326PacienteSexo);
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbPacienteSexo, cmbPacienteSexo_Internalname, A326PacienteSexo, 1, cmbPacienteSexo_Jsonclick, 0, "", "svchar", "", 1, cmbPacienteSexo.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(73);\"", "", true, "HLP_Paciente.htm");
            cmbPacienteSexo.CurrentValue = A326PacienteSexo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPacienteSexo_Internalname, "Values", (String)(cmbPacienteSexo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacientenacimiento_Internalname, "Nacimiento", "", "", lblTextblockpacientenacimiento_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74PacienteNacimiento", context.localUtil.Format(A74PacienteNacimiento, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtPacienteNacimiento_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtPacienteNacimiento_Internalname, context.localUtil.Format(A74PacienteNacimiento, "99/99/99"), context.localUtil.Format( A74PacienteNacimiento, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(78);\"", "", "", "", "", edtPacienteNacimiento_Jsonclick, 0, ClassString, StyleString, "", 1, edtPacienteNacimiento_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_Paciente.htm");
            GxWebStd.gx_bitmap( context, edtPacienteNacimiento_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtPacienteNacimiento_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Paciente.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacientedireccion_Internalname, "Diirección", "", "", lblTextblockpacientedireccion_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A75PacienteDireccion", A75PacienteDireccion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPacienteDireccion_Internalname, StringUtil.RTrim( A75PacienteDireccion), StringUtil.RTrim( context.localUtil.Format( A75PacienteDireccion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(83);\"", "", "", "", "", edtPacienteDireccion_Jsonclick, 0, ClassString, StyleString, "", 1, edtPacienteDireccion_Enabled, 0, 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, true, "left", "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacientetelefono1_Internalname, "Teléfono_1", "", "", lblTextblockpacientetelefono1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A76PacienteTelefono1", A76PacienteTelefono1);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPacienteTelefono1_Internalname, StringUtil.RTrim( A76PacienteTelefono1), StringUtil.RTrim( context.localUtil.Format( A76PacienteTelefono1, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(88);\"", "", "", "", "", edtPacienteTelefono1_Jsonclick, 0, ClassString, StyleString, "", 1, edtPacienteTelefono1_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "left", "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacientetelefono2_Internalname, "Teléfono_2", "", "", lblTextblockpacientetelefono2_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77PacienteTelefono2", A77PacienteTelefono2);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPacienteTelefono2_Internalname, StringUtil.RTrim( A77PacienteTelefono2), StringUtil.RTrim( context.localUtil.Format( A77PacienteTelefono2, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(93);\"", "", "", "", "", edtPacienteTelefono2_Jsonclick, 0, ClassString, StyleString, "", 1, edtPacienteTelefono2_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "left", "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacientecorreo_Internalname, "Correo", "", "", lblTextblockpacientecorreo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A78PacienteCorreo", A78PacienteCorreo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPacienteCorreo_Internalname, StringUtil.RTrim( A78PacienteCorreo), StringUtil.RTrim( context.localUtil.Format( A78PacienteCorreo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(98);\"", "", "", "", "", edtPacienteCorreo_Jsonclick, 0, ClassString, StyleString, "", 1, edtPacienteCorreo_Enabled, 0, 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, true, "left", "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacientedpi_Internalname, "DPI", "", "", lblTextblockpacientedpi_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79PacienteDpi", A79PacienteDpi);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPacienteDpi_Internalname, StringUtil.RTrim( A79PacienteDpi), StringUtil.RTrim( context.localUtil.Format( A79PacienteDpi, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(103);\"", "", "", "", "", edtPacienteDpi_Jsonclick, 0, ClassString, StyleString, "", 1, edtPacienteDpi_Enabled, 0, 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, true, "left", "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacientedpi2_Internalname, "Tipo Paciente", "", "", lblTextblockpacientedpi2_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144TipoPacCodigo", A144TipoPacCodigo);
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 108,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynTipoPacCodigo, dynTipoPacCodigo_Internalname, A144TipoPacCodigo, 1, dynTipoPacCodigo_Jsonclick, 0, "", "svchar", "", 1, dynTipoPacCodigo.Enabled, 0, 0, 80, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(108);\"", "", true, "HLP_Paciente.htm");
            dynTipoPacCodigo.CurrentValue = A144TipoPacCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTipoPacCodigo_Internalname, "Values", (String)(dynTipoPacCodigo.ToJavascriptSource()));
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_144_Internalname, "prompt.gif", imgprompt_41_144_Link, "", "", "Fantastic", imgprompt_41_144_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacientedpi3_Internalname, "Religión", "", "", lblTextblockpacientedpi3_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315ReligionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A315ReligionId), 9, 0)));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 113,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynReligionId, dynReligionId_Internalname, StringUtil.Str( (decimal)(A315ReligionId), 9, 0), 1, dynReligionId_Jsonclick, 0, "", "int", "", 1, dynReligionId.Enabled, 0, 0, 70, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(113);\"", "", true, "HLP_Paciente.htm");
            dynReligionId.CurrentValue = StringUtil.Str( (decimal)(A315ReligionId), 9, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynReligionId_Internalname, "Values", (String)(dynReligionId.ToJavascriptSource()));
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_315_Internalname, "prompt.gif", imgprompt_41_315_Link, "", "", "Fantastic", imgprompt_41_315_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacientedpi4_Internalname, "Profesión", "", "", lblTextblockpacientedpi4_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313ProfesionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A313ProfesionId), 9, 0)));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 118,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynProfesionId, dynProfesionId_Internalname, StringUtil.Str( (decimal)(A313ProfesionId), 9, 0), 1, dynProfesionId_Jsonclick, 0, "", "int", "", 1, dynProfesionId.Enabled, 0, 0, 70, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(118);\"", "", true, "HLP_Paciente.htm");
            dynProfesionId.CurrentValue = StringUtil.Str( (decimal)(A313ProfesionId), 9, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynProfesionId_Internalname, "Values", (String)(dynProfesionId.ToJavascriptSource()));
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_313_Internalname, "prompt.gif", imgprompt_41_313_Link, "", "", "Fantastic", imgprompt_41_313_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacienteobs_Internalname, "Observaciones", "", "", lblTextblockpacienteobs_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A80PacienteObs", A80PacienteObs);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 123,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtPacienteObs_Internalname, StringUtil.RTrim( A80PacienteObs), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(123);\"", 0, 1, edtPacienteObs_Enabled, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacienteestado_Internalname, "Estado", "", "", lblTextblockpacienteestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A81PacienteEstado", StringUtil.Str( (decimal)(A81PacienteEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 128,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbPacienteEstado, cmbPacienteEstado_Internalname, StringUtil.Str( (decimal)(A81PacienteEstado), 1, 0), 1, cmbPacienteEstado_Jsonclick, 0, "", "int", "", 1, cmbPacienteEstado.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(128);\"", "", true, "HLP_Paciente.htm");
            cmbPacienteEstado.CurrentValue = StringUtil.Str( (decimal)(A81PacienteEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPacienteEstado_Internalname, "Values", (String)(cmbPacienteEstado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0H23e( true) ;
         }
         else
         {
            wb_table4_33_0H23e( false) ;
         }
      }

      protected void wb_table2_5_0H23( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Paciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Paciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Paciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Paciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Paciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Paciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Paciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Paciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00n0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"PACIENTEID"+"'), id:'"+"PACIENTEID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Paciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00n0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"PACIENTEID"+"'), id:'"+"PACIENTEID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Paciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Paciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Paciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Paciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Paciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Paciente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Paciente.htm");
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
            wb_table2_5_0H23e( true) ;
         }
         else
         {
            wb_table2_5_0H23e( false) ;
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
         /* Execute user event: E110H2 */
         E110H2 ();
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
               A67PacienteId = (int)(context.localUtil.CToN( cgiGet( edtPacienteId_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
               A68PacienteNombre1 = cgiGet( edtPacienteNombre1_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68PacienteNombre1", A68PacienteNombre1);
               A69PacienteNombre2 = cgiGet( edtPacienteNombre2_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69PacienteNombre2", A69PacienteNombre2);
               A70PacienteApellido1 = cgiGet( edtPacienteApellido1_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70PacienteApellido1", A70PacienteApellido1);
               A71PacienteApellido2 = cgiGet( edtPacienteApellido2_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71PacienteApellido2", A71PacienteApellido2);
               A72PacienteApellido3 = cgiGet( edtPacienteApellido3_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A72PacienteApellido3", A72PacienteApellido3);
               cmbPacienteSexo.CurrentValue = cgiGet( cmbPacienteSexo_Internalname) ;
               A326PacienteSexo = cgiGet( cmbPacienteSexo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A326PacienteSexo", A326PacienteSexo);
               if ( context.localUtil.VCDate( cgiGet( edtPacienteNacimiento_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha_Nacimiento"}), 1, "PACIENTENACIMIENTO");
                  AnyError = 1 ;
                  GX_FocusControl = edtPacienteNacimiento_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A74PacienteNacimiento = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74PacienteNacimiento", context.localUtil.Format(A74PacienteNacimiento, "99/99/99"));
               }
               else
               {
                  A74PacienteNacimiento = context.localUtil.CToD( cgiGet( edtPacienteNacimiento_Internalname), 2) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74PacienteNacimiento", context.localUtil.Format(A74PacienteNacimiento, "99/99/99"));
               }
               A75PacienteDireccion = cgiGet( edtPacienteDireccion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A75PacienteDireccion", A75PacienteDireccion);
               A76PacienteTelefono1 = cgiGet( edtPacienteTelefono1_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A76PacienteTelefono1", A76PacienteTelefono1);
               A77PacienteTelefono2 = cgiGet( edtPacienteTelefono2_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77PacienteTelefono2", A77PacienteTelefono2);
               A78PacienteCorreo = cgiGet( edtPacienteCorreo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A78PacienteCorreo", A78PacienteCorreo);
               A79PacienteDpi = cgiGet( edtPacienteDpi_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79PacienteDpi", A79PacienteDpi);
               dynTipoPacCodigo.CurrentValue = cgiGet( dynTipoPacCodigo_Internalname) ;
               A144TipoPacCodigo = cgiGet( dynTipoPacCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144TipoPacCodigo", A144TipoPacCodigo);
               dynReligionId.CurrentValue = cgiGet( dynReligionId_Internalname) ;
               A315ReligionId = (int)(NumberUtil.Val( cgiGet( dynReligionId_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315ReligionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A315ReligionId), 9, 0)));
               dynProfesionId.CurrentValue = cgiGet( dynProfesionId_Internalname) ;
               A313ProfesionId = (int)(NumberUtil.Val( cgiGet( dynProfesionId_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313ProfesionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A313ProfesionId), 9, 0)));
               A80PacienteObs = cgiGet( edtPacienteObs_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A80PacienteObs", A80PacienteObs);
               cmbPacienteEstado.CurrentValue = cgiGet( cmbPacienteEstado_Internalname) ;
               A81PacienteEstado = (short)(NumberUtil.Val( cgiGet( cmbPacienteEstado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A81PacienteEstado", StringUtil.Str( (decimal)(A81PacienteEstado), 1, 0));
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z67PacienteId = (int)(context.localUtil.CToN( cgiGet( "Z67PacienteId"), ".", ",")) ;
               Z68PacienteNombre1 = cgiGet( "Z68PacienteNombre1") ;
               Z69PacienteNombre2 = cgiGet( "Z69PacienteNombre2") ;
               Z70PacienteApellido1 = cgiGet( "Z70PacienteApellido1") ;
               Z71PacienteApellido2 = cgiGet( "Z71PacienteApellido2") ;
               Z72PacienteApellido3 = cgiGet( "Z72PacienteApellido3") ;
               Z326PacienteSexo = cgiGet( "Z326PacienteSexo") ;
               Z74PacienteNacimiento = context.localUtil.CToD( cgiGet( "Z74PacienteNacimiento"), 0) ;
               Z75PacienteDireccion = cgiGet( "Z75PacienteDireccion") ;
               Z76PacienteTelefono1 = cgiGet( "Z76PacienteTelefono1") ;
               Z77PacienteTelefono2 = cgiGet( "Z77PacienteTelefono2") ;
               Z78PacienteCorreo = cgiGet( "Z78PacienteCorreo") ;
               Z79PacienteDpi = cgiGet( "Z79PacienteDpi") ;
               Z80PacienteObs = cgiGet( "Z80PacienteObs") ;
               Z81PacienteEstado = (short)(context.localUtil.CToN( cgiGet( "Z81PacienteEstado"), ".", ",")) ;
               Z144TipoPacCodigo = cgiGet( "Z144TipoPacCodigo") ;
               Z313ProfesionId = (int)(context.localUtil.CToN( cgiGet( "Z313ProfesionId"), ".", ",")) ;
               Z315ReligionId = (int)(context.localUtil.CToN( cgiGet( "Z315ReligionId"), ".", ",")) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV10Flag = (short)(context.localUtil.CToN( cgiGet( "vFLAG"), ".", ",")) ;
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
                  A67PacienteId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode23 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode23 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound23 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0H0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "CLINICACODIGO");
                        AnyError = 1 ;
                     }
                  }
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
                           /* Execute user event: E110H2 */
                           E110H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E120H2 */
                           E120H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
                           {
                              btn_enter( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
                           {
                              btn_delete( ) ;
                           }
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
            /* Execute user event: E120H2 */
            E120H2 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0H23( ) ;
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
         if ( ( StringUtil.StrCmp(sMode23, "DSP") == 0 ) || ( StringUtil.StrCmp(sMode23, "DLT") == 0 ) )
         {
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
            DisableAttributes0H23( ) ;
         }
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

      protected void CONFIRM_0H0( )
      {
         BeforeValidate0H23( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0H23( ) ;
            }
            else
            {
               CheckExtendedTable0H23( ) ;
               CloseExtendedTableCursors0H23( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void ResetCaption0H0( )
      {
      }

      protected void E110H2( )
      {
         /* Start Routine */
         GXt_SdtParametros4 = AV7Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros4) ;
         AV7Parametros = GXt_SdtParametros4 ;
         AV8ClinicaCodigo = AV7Parametros.gxTpr_Pclinicacodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClinicaCodigo", AV8ClinicaCodigo);
      }

      protected void E120H2( )
      {
         /* After Trn Routine */
         if ( AV10Flag == 1 )
         {
            context.wjLoc = formatLink("wp_paciente.aspx")  ;
         }
         else
         {
            context.wjLoc = formatLink("wp_paciente_emf.aspx")  ;
         }
      }

      protected void ZM0H23( short GX_JID )
      {
         if ( ( GX_JID == 8 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z68PacienteNombre1 = T000H3_A68PacienteNombre1[0] ;
               Z69PacienteNombre2 = T000H3_A69PacienteNombre2[0] ;
               Z70PacienteApellido1 = T000H3_A70PacienteApellido1[0] ;
               Z71PacienteApellido2 = T000H3_A71PacienteApellido2[0] ;
               Z72PacienteApellido3 = T000H3_A72PacienteApellido3[0] ;
               Z326PacienteSexo = T000H3_A326PacienteSexo[0] ;
               Z74PacienteNacimiento = T000H3_A74PacienteNacimiento[0] ;
               Z75PacienteDireccion = T000H3_A75PacienteDireccion[0] ;
               Z76PacienteTelefono1 = T000H3_A76PacienteTelefono1[0] ;
               Z77PacienteTelefono2 = T000H3_A77PacienteTelefono2[0] ;
               Z78PacienteCorreo = T000H3_A78PacienteCorreo[0] ;
               Z79PacienteDpi = T000H3_A79PacienteDpi[0] ;
               Z80PacienteObs = T000H3_A80PacienteObs[0] ;
               Z81PacienteEstado = T000H3_A81PacienteEstado[0] ;
               Z144TipoPacCodigo = T000H3_A144TipoPacCodigo[0] ;
               Z313ProfesionId = T000H3_A313ProfesionId[0] ;
               Z315ReligionId = T000H3_A315ReligionId[0] ;
            }
            else
            {
               Z68PacienteNombre1 = A68PacienteNombre1 ;
               Z69PacienteNombre2 = A69PacienteNombre2 ;
               Z70PacienteApellido1 = A70PacienteApellido1 ;
               Z71PacienteApellido2 = A71PacienteApellido2 ;
               Z72PacienteApellido3 = A72PacienteApellido3 ;
               Z326PacienteSexo = A326PacienteSexo ;
               Z74PacienteNacimiento = A74PacienteNacimiento ;
               Z75PacienteDireccion = A75PacienteDireccion ;
               Z76PacienteTelefono1 = A76PacienteTelefono1 ;
               Z77PacienteTelefono2 = A77PacienteTelefono2 ;
               Z78PacienteCorreo = A78PacienteCorreo ;
               Z79PacienteDpi = A79PacienteDpi ;
               Z80PacienteObs = A80PacienteObs ;
               Z81PacienteEstado = A81PacienteEstado ;
               Z144TipoPacCodigo = A144TipoPacCodigo ;
               Z313ProfesionId = A313ProfesionId ;
               Z315ReligionId = A315ReligionId ;
            }
         }
         if ( GX_JID == -8 )
         {
            Z67PacienteId = A67PacienteId ;
            Z68PacienteNombre1 = A68PacienteNombre1 ;
            Z69PacienteNombre2 = A69PacienteNombre2 ;
            Z70PacienteApellido1 = A70PacienteApellido1 ;
            Z71PacienteApellido2 = A71PacienteApellido2 ;
            Z72PacienteApellido3 = A72PacienteApellido3 ;
            Z326PacienteSexo = A326PacienteSexo ;
            Z74PacienteNacimiento = A74PacienteNacimiento ;
            Z75PacienteDireccion = A75PacienteDireccion ;
            Z76PacienteTelefono1 = A76PacienteTelefono1 ;
            Z77PacienteTelefono2 = A77PacienteTelefono2 ;
            Z78PacienteCorreo = A78PacienteCorreo ;
            Z79PacienteDpi = A79PacienteDpi ;
            Z80PacienteObs = A80PacienteObs ;
            Z81PacienteEstado = A81PacienteEstado ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z144TipoPacCodigo = A144TipoPacCodigo ;
            Z313ProfesionId = A313ProfesionId ;
            Z315ReligionId = A315ReligionId ;
         }
      }

      protected void standaloneNotModal( )
      {
         lblTextblockclinicacodigo_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTextblockclinicacodigo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblTextblockclinicacodigo_Visible), 5, 0)));
         edtClinicaCodigo_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Visible), 5, 0)));
         imgprompt_41_144_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0140.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"TIPOPACCODIGO"+"'), id:'"+"TIPOPACCODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
         imgprompt_41_315_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0210.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"RELIGIONID"+"'), id:'"+"RELIGIONID"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
         imgprompt_41_313_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0200.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"PROFESIONID"+"'), id:'"+"PROFESIONID"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
         imgBtn_delete2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         A41ClinicaCodigo = AV8ClinicaCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
      }

      protected void standaloneModal( )
      {
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            GXATIPOPACCODIGO_html0H23( A41ClinicaCodigo) ;
            GXARELIGIONID_html0H23( A41ClinicaCodigo) ;
            GXAPROFESIONID_html0H23( A41ClinicaCodigo) ;
         }
      }

      protected void Load0H23( )
      {
         /* Using cursor T000H7 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A67PacienteId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound23 = 1 ;
            A68PacienteNombre1 = T000H7_A68PacienteNombre1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68PacienteNombre1", A68PacienteNombre1);
            A69PacienteNombre2 = T000H7_A69PacienteNombre2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69PacienteNombre2", A69PacienteNombre2);
            A70PacienteApellido1 = T000H7_A70PacienteApellido1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70PacienteApellido1", A70PacienteApellido1);
            A71PacienteApellido2 = T000H7_A71PacienteApellido2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71PacienteApellido2", A71PacienteApellido2);
            A72PacienteApellido3 = T000H7_A72PacienteApellido3[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A72PacienteApellido3", A72PacienteApellido3);
            A326PacienteSexo = T000H7_A326PacienteSexo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A326PacienteSexo", A326PacienteSexo);
            A74PacienteNacimiento = T000H7_A74PacienteNacimiento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74PacienteNacimiento", context.localUtil.Format(A74PacienteNacimiento, "99/99/99"));
            A75PacienteDireccion = T000H7_A75PacienteDireccion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A75PacienteDireccion", A75PacienteDireccion);
            A76PacienteTelefono1 = T000H7_A76PacienteTelefono1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A76PacienteTelefono1", A76PacienteTelefono1);
            A77PacienteTelefono2 = T000H7_A77PacienteTelefono2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77PacienteTelefono2", A77PacienteTelefono2);
            A78PacienteCorreo = T000H7_A78PacienteCorreo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A78PacienteCorreo", A78PacienteCorreo);
            A79PacienteDpi = T000H7_A79PacienteDpi[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79PacienteDpi", A79PacienteDpi);
            A80PacienteObs = T000H7_A80PacienteObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A80PacienteObs", A80PacienteObs);
            A81PacienteEstado = T000H7_A81PacienteEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A81PacienteEstado", StringUtil.Str( (decimal)(A81PacienteEstado), 1, 0));
            A144TipoPacCodigo = T000H7_A144TipoPacCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144TipoPacCodigo", A144TipoPacCodigo);
            A313ProfesionId = T000H7_A313ProfesionId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313ProfesionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A313ProfesionId), 9, 0)));
            A315ReligionId = T000H7_A315ReligionId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315ReligionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A315ReligionId), 9, 0)));
            ZM0H23( -8) ;
         }
         pr_default.close(5);
         OnLoadActions0H23( ) ;
      }

      protected void OnLoadActions0H23( )
      {
         GXATIPOPACCODIGO_html0H23( A41ClinicaCodigo) ;
         GXARELIGIONID_html0H23( A41ClinicaCodigo) ;
         GXAPROFESIONID_html0H23( A41ClinicaCodigo) ;
      }

      protected void CheckExtendedTable0H23( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T000H4 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo, A144TipoPacCodigo});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError41 = 1 ;
            AnyError144 = 1 ;
            GX_msglist.addItem("No existe 'Tipos de Pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError144 == 0 ) )
         {
         }
         pr_default.close(2);
         /* Using cursor T000H5 */
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
         /* Using cursor T000H6 */
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
         GXATIPOPACCODIGO_html0H23( A41ClinicaCodigo) ;
         GXARELIGIONID_html0H23( A41ClinicaCodigo) ;
         GXAPROFESIONID_html0H23( A41ClinicaCodigo) ;
         if ( ! ( (DateTime.MinValue==A74PacienteNacimiento) || ( A74PacienteNacimiento >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha_Nacimiento fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors0H23( )
      {
         pr_default.close(2);
         pr_default.close(3);
         pr_default.close(4);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_9( String A41ClinicaCodigo ,
                               String A144TipoPacCodigo )
      {
         /* Using cursor T000H8 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, A144TipoPacCodigo});
         if ( (pr_default.getStatus(6) == 101) )
         {
            AnyError41 = 1 ;
            AnyError144 = 1 ;
            GX_msglist.addItem("No existe 'Tipos de Pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError144 == 0 ) )
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

      protected void gxLoad_10( String A41ClinicaCodigo ,
                                int A313ProfesionId )
      {
         /* Using cursor T000H9 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A313ProfesionId});
         if ( (pr_default.getStatus(7) == 101) )
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
         if ( (pr_default.getStatus(7) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(7);
      }

      protected void gxLoad_11( String A41ClinicaCodigo ,
                                int A315ReligionId )
      {
         /* Using cursor T000H10 */
         pr_default.execute(8, new Object[] {A41ClinicaCodigo, A315ReligionId});
         if ( (pr_default.getStatus(8) == 101) )
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
         if ( (pr_default.getStatus(8) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(8);
      }

      protected void GetKey0H23( )
      {
         /* Using cursor T000H11 */
         pr_default.execute(9, new Object[] {A41ClinicaCodigo, A67PacienteId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound23 = 1 ;
         }
         else
         {
            RcdFound23 = 0 ;
         }
         pr_default.close(9);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000H3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A67PacienteId});
         if ( (pr_default.getStatus(1) != 101) && ( T000H3_A67PacienteId[0] == A67PacienteId ) )
         {
            ZM0H23( 8) ;
            RcdFound23 = 1 ;
            A68PacienteNombre1 = T000H3_A68PacienteNombre1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68PacienteNombre1", A68PacienteNombre1);
            A69PacienteNombre2 = T000H3_A69PacienteNombre2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69PacienteNombre2", A69PacienteNombre2);
            A70PacienteApellido1 = T000H3_A70PacienteApellido1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70PacienteApellido1", A70PacienteApellido1);
            A71PacienteApellido2 = T000H3_A71PacienteApellido2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71PacienteApellido2", A71PacienteApellido2);
            A72PacienteApellido3 = T000H3_A72PacienteApellido3[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A72PacienteApellido3", A72PacienteApellido3);
            A326PacienteSexo = T000H3_A326PacienteSexo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A326PacienteSexo", A326PacienteSexo);
            A74PacienteNacimiento = T000H3_A74PacienteNacimiento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74PacienteNacimiento", context.localUtil.Format(A74PacienteNacimiento, "99/99/99"));
            A75PacienteDireccion = T000H3_A75PacienteDireccion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A75PacienteDireccion", A75PacienteDireccion);
            A76PacienteTelefono1 = T000H3_A76PacienteTelefono1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A76PacienteTelefono1", A76PacienteTelefono1);
            A77PacienteTelefono2 = T000H3_A77PacienteTelefono2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77PacienteTelefono2", A77PacienteTelefono2);
            A78PacienteCorreo = T000H3_A78PacienteCorreo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A78PacienteCorreo", A78PacienteCorreo);
            A79PacienteDpi = T000H3_A79PacienteDpi[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79PacienteDpi", A79PacienteDpi);
            A80PacienteObs = T000H3_A80PacienteObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A80PacienteObs", A80PacienteObs);
            A81PacienteEstado = T000H3_A81PacienteEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A81PacienteEstado", StringUtil.Str( (decimal)(A81PacienteEstado), 1, 0));
            A41ClinicaCodigo = T000H3_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A144TipoPacCodigo = T000H3_A144TipoPacCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144TipoPacCodigo", A144TipoPacCodigo);
            A313ProfesionId = T000H3_A313ProfesionId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313ProfesionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A313ProfesionId), 9, 0)));
            A315ReligionId = T000H3_A315ReligionId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315ReligionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A315ReligionId), 9, 0)));
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z67PacienteId = A67PacienteId ;
            sMode23 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load0H23( ) ;
            Gx_mode = sMode23 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound23 = 0 ;
            InitializeNonKey0H23( ) ;
            sMode23 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode23 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0H23( ) ;
         if ( RcdFound23 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound23 = 0 ;
         /* Using cursor T000H12 */
         pr_default.execute(10, new Object[] {A41ClinicaCodigo, A67PacienteId});
         if ( (pr_default.getStatus(10) != 101) )
         {
            while ( (pr_default.getStatus(10) != 101) && ( ( StringUtil.StrCmp(T000H12_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) ) && ( T000H12_A67PacienteId[0] == A67PacienteId ) )
            {
               pr_default.readNext(10);
            }
            if ( (pr_default.getStatus(10) != 101) && ( ( StringUtil.StrCmp(T000H12_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) ) && ( T000H12_A67PacienteId[0] == A67PacienteId ) )
            {
               A41ClinicaCodigo = T000H12_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               RcdFound23 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound23 = 0 ;
         /* Using cursor T000H13 */
         pr_default.execute(11, new Object[] {A41ClinicaCodigo, A67PacienteId});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( StringUtil.StrCmp(T000H13_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) ) && ( T000H13_A67PacienteId[0] == A67PacienteId ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( StringUtil.StrCmp(T000H13_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) ) && ( T000H13_A67PacienteId[0] == A67PacienteId ) )
            {
               A41ClinicaCodigo = T000H13_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               RcdFound23 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0H23( ) ;
         if ( RcdFound23 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A67PacienteId != Z67PacienteId ) )
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
               /* Update record */
               Update0H23( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A67PacienteId != Z67PacienteId ) )
            {
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert0H23( ) ;
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
                  /* Insert record */
                  GX_FocusControl = edtClinicaCodigo_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0H23( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1 ;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A67PacienteId != Z67PacienteId ) )
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
         }
      }

      protected void CheckOptimisticConcurrency0H23( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000H14 */
            pr_default.execute(12, new Object[] {A41ClinicaCodigo, A67PacienteId});
            if ( (pr_default.getStatus(12) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Paciente"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(12) == 101) || ( StringUtil.StrCmp(Z68PacienteNombre1, T000H14_A68PacienteNombre1[0]) != 0 ) || ( StringUtil.StrCmp(Z69PacienteNombre2, T000H14_A69PacienteNombre2[0]) != 0 ) || ( StringUtil.StrCmp(Z70PacienteApellido1, T000H14_A70PacienteApellido1[0]) != 0 ) || ( StringUtil.StrCmp(Z71PacienteApellido2, T000H14_A71PacienteApellido2[0]) != 0 ) || ( StringUtil.StrCmp(Z72PacienteApellido3, T000H14_A72PacienteApellido3[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z326PacienteSexo, T000H14_A326PacienteSexo[0]) != 0 ) || ( Z74PacienteNacimiento != T000H14_A74PacienteNacimiento[0] ) || ( StringUtil.StrCmp(Z75PacienteDireccion, T000H14_A75PacienteDireccion[0]) != 0 ) || ( StringUtil.StrCmp(Z76PacienteTelefono1, T000H14_A76PacienteTelefono1[0]) != 0 ) || ( StringUtil.StrCmp(Z77PacienteTelefono2, T000H14_A77PacienteTelefono2[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z78PacienteCorreo, T000H14_A78PacienteCorreo[0]) != 0 ) || ( StringUtil.StrCmp(Z79PacienteDpi, T000H14_A79PacienteDpi[0]) != 0 ) || ( StringUtil.StrCmp(Z80PacienteObs, T000H14_A80PacienteObs[0]) != 0 ) || ( Z81PacienteEstado != T000H14_A81PacienteEstado[0] ) || ( StringUtil.StrCmp(Z144TipoPacCodigo, T000H14_A144TipoPacCodigo[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z313ProfesionId != T000H14_A313ProfesionId[0] ) || ( Z315ReligionId != T000H14_A315ReligionId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Paciente"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0H23( )
      {
         BeforeValidate0H23( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0H23( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0H23( 0) ;
            CheckOptimisticConcurrency0H23( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0H23( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0H23( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000H15 */
                     pr_default.execute(13, new Object[] {A67PacienteId, A68PacienteNombre1, A69PacienteNombre2, A70PacienteApellido1, A71PacienteApellido2, A72PacienteApellido3, A326PacienteSexo, A74PacienteNacimiento, A75PacienteDireccion, A76PacienteTelefono1, A77PacienteTelefono2, A78PacienteCorreo, A79PacienteDpi, A80PacienteObs, A81PacienteEstado, A41ClinicaCodigo, A144TipoPacCodigo, A313ProfesionId, A315ReligionId});
                     pr_default.close(13);
                     if ( (pr_default.getStatus(13) == 1) )
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
                           ResetCaption0H0( ) ;
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
               Load0H23( ) ;
            }
            EndLevel0H23( ) ;
         }
         CloseExtendedTableCursors0H23( ) ;
      }

      protected void Update0H23( )
      {
         BeforeValidate0H23( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0H23( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0H23( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0H23( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0H23( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000H16 */
                     pr_default.execute(14, new Object[] {A68PacienteNombre1, A69PacienteNombre2, A70PacienteApellido1, A71PacienteApellido2, A72PacienteApellido3, A326PacienteSexo, A74PacienteNacimiento, A75PacienteDireccion, A76PacienteTelefono1, A77PacienteTelefono2, A78PacienteCorreo, A79PacienteDpi, A80PacienteObs, A81PacienteEstado, A144TipoPacCodigo, A313ProfesionId, A315ReligionId, A41ClinicaCodigo, A67PacienteId});
                     pr_default.close(14);
                     if ( (pr_default.getStatus(14) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Paciente"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0H23( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1 ;
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
            }
            EndLevel0H23( ) ;
         }
         CloseExtendedTableCursors0H23( ) ;
      }

      protected void DeferredUpdate0H23( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0H23( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0H23( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0H23( ) ;
            AfterConfirm0H23( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0H23( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000H17 */
                  pr_default.execute(15, new Object[] {A41ClinicaCodigo, A67PacienteId});
                  pr_default.close(15);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1 ;
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
         }
         sMode23 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0H23( ) ;
         Gx_mode = sMode23 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0H23( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            GXATIPOPACCODIGO_html0H23( A41ClinicaCodigo) ;
            GXARELIGIONID_html0H23( A41ClinicaCodigo) ;
            GXAPROFESIONID_html0H23( A41ClinicaCodigo) ;
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000H18 */
            pr_default.execute(16, new Object[] {A41ClinicaCodigo, A67PacienteId});
            if ( (pr_default.getStatus(16) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Expediente Médico Físico"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(16);
            /* Using cursor T000H19 */
            pr_default.execute(17, new Object[] {A41ClinicaCodigo, A67PacienteId});
            if ( (pr_default.getStatus(17) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Consulta de pacientes"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(17);
         }
      }

      protected void EndLevel0H23( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(12);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0H23( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(11);
            pr_default.close(10);
            context.CommitDataStores("Paciente");
            if ( AnyError == 0 )
            {
               ConfirmValues0H0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(11);
            pr_default.close(10);
            context.RollbackDataStores("Paciente");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0H23( )
      {
         /* Using cursor T000H20 */
         pr_default.execute(18, new Object[] {A67PacienteId});
         RcdFound23 = 0 ;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound23 = 1 ;
            A41ClinicaCodigo = T000H20_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0H23( )
      {
         pr_default.readNext(18);
         RcdFound23 = 0 ;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound23 = 1 ;
            A41ClinicaCodigo = T000H20_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         }
      }

      protected void ScanEnd0H23( )
      {
      }

      protected void AfterConfirm0H23( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0H23( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0H23( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0H23( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0H23( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0H23( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0H23( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtPacienteId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPacienteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPacienteId_Enabled), 5, 0)));
         edtPacienteNombre1_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPacienteNombre1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPacienteNombre1_Enabled), 5, 0)));
         edtPacienteNombre2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPacienteNombre2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPacienteNombre2_Enabled), 5, 0)));
         edtPacienteApellido1_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPacienteApellido1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPacienteApellido1_Enabled), 5, 0)));
         edtPacienteApellido2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPacienteApellido2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPacienteApellido2_Enabled), 5, 0)));
         edtPacienteApellido3_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPacienteApellido3_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPacienteApellido3_Enabled), 5, 0)));
         cmbPacienteSexo.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPacienteSexo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbPacienteSexo.Enabled), 5, 0)));
         edtPacienteNacimiento_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPacienteNacimiento_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPacienteNacimiento_Enabled), 5, 0)));
         edtPacienteDireccion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPacienteDireccion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPacienteDireccion_Enabled), 5, 0)));
         edtPacienteTelefono1_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPacienteTelefono1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPacienteTelefono1_Enabled), 5, 0)));
         edtPacienteTelefono2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPacienteTelefono2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPacienteTelefono2_Enabled), 5, 0)));
         edtPacienteCorreo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPacienteCorreo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPacienteCorreo_Enabled), 5, 0)));
         edtPacienteDpi_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPacienteDpi_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPacienteDpi_Enabled), 5, 0)));
         dynTipoPacCodigo.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTipoPacCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynTipoPacCodigo.Enabled), 5, 0)));
         dynReligionId.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynReligionId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynReligionId.Enabled), 5, 0)));
         dynProfesionId.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynProfesionId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynProfesionId.Enabled), 5, 0)));
         edtPacienteObs_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPacienteObs_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPacienteObs_Enabled), 5, 0)));
         cmbPacienteEstado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPacienteEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbPacienteEstado.Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0H0( )
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
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode("" +A67PacienteId) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV10Flag) ;
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("paciente.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z67PacienteId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z67PacienteId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z68PacienteNombre1", StringUtil.RTrim( Z68PacienteNombre1));
         GxWebStd.gx_hidden_field( context, "Z69PacienteNombre2", StringUtil.RTrim( Z69PacienteNombre2));
         GxWebStd.gx_hidden_field( context, "Z70PacienteApellido1", StringUtil.RTrim( Z70PacienteApellido1));
         GxWebStd.gx_hidden_field( context, "Z71PacienteApellido2", StringUtil.RTrim( Z71PacienteApellido2));
         GxWebStd.gx_hidden_field( context, "Z72PacienteApellido3", StringUtil.RTrim( Z72PacienteApellido3));
         GxWebStd.gx_hidden_field( context, "Z326PacienteSexo", StringUtil.RTrim( Z326PacienteSexo));
         GxWebStd.gx_hidden_field( context, "Z74PacienteNacimiento", context.localUtil.DToC( Z74PacienteNacimiento, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z75PacienteDireccion", StringUtil.RTrim( Z75PacienteDireccion));
         GxWebStd.gx_hidden_field( context, "Z76PacienteTelefono1", StringUtil.RTrim( Z76PacienteTelefono1));
         GxWebStd.gx_hidden_field( context, "Z77PacienteTelefono2", StringUtil.RTrim( Z77PacienteTelefono2));
         GxWebStd.gx_hidden_field( context, "Z78PacienteCorreo", StringUtil.RTrim( Z78PacienteCorreo));
         GxWebStd.gx_hidden_field( context, "Z79PacienteDpi", StringUtil.RTrim( Z79PacienteDpi));
         GxWebStd.gx_hidden_field( context, "Z80PacienteObs", StringUtil.RTrim( Z80PacienteObs));
         GxWebStd.gx_hidden_field( context, "Z81PacienteEstado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z81PacienteEstado), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z144TipoPacCodigo", StringUtil.RTrim( Z144TipoPacCodigo));
         GxWebStd.gx_hidden_field( context, "Z313ProfesionId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z313ProfesionId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z315ReligionId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z315ReligionId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vFLAG", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10Flag), 1, 0, ".", "")));
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
         return "Paciente" ;
      }

      public override String GetPgmdesc( )
      {
         return "Pacientes" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode("" +A67PacienteId) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV10Flag) ;
         return formatLink("paciente.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void InitializeNonKey0H23( )
      {
         A68PacienteNombre1 = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68PacienteNombre1", A68PacienteNombre1);
         A69PacienteNombre2 = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69PacienteNombre2", A69PacienteNombre2);
         A70PacienteApellido1 = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70PacienteApellido1", A70PacienteApellido1);
         A71PacienteApellido2 = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71PacienteApellido2", A71PacienteApellido2);
         A72PacienteApellido3 = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A72PacienteApellido3", A72PacienteApellido3);
         A326PacienteSexo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A326PacienteSexo", A326PacienteSexo);
         A74PacienteNacimiento = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74PacienteNacimiento", context.localUtil.Format(A74PacienteNacimiento, "99/99/99"));
         A75PacienteDireccion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A75PacienteDireccion", A75PacienteDireccion);
         A76PacienteTelefono1 = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A76PacienteTelefono1", A76PacienteTelefono1);
         A77PacienteTelefono2 = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77PacienteTelefono2", A77PacienteTelefono2);
         A78PacienteCorreo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A78PacienteCorreo", A78PacienteCorreo);
         A79PacienteDpi = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79PacienteDpi", A79PacienteDpi);
         A80PacienteObs = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A80PacienteObs", A80PacienteObs);
         A313ProfesionId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313ProfesionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A313ProfesionId), 9, 0)));
         A315ReligionId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315ReligionId", StringUtil.LTrim( StringUtil.Str( (decimal)(A315ReligionId), 9, 0)));
         A144TipoPacCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144TipoPacCodigo", A144TipoPacCodigo);
         A81PacienteEstado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A81PacienteEstado", StringUtil.Str( (decimal)(A81PacienteEstado), 1, 0));
      }

      protected void InitAll0H23( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         InitializeNonKey0H23( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1545912");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("paciente.js", "?1545912");
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
         lblTextblockpacienteid_Internalname = "TEXTBLOCKPACIENTEID" ;
         edtPacienteId_Internalname = "PACIENTEID" ;
         lblTextblockpacientenombre1_Internalname = "TEXTBLOCKPACIENTENOMBRE1" ;
         edtPacienteNombre1_Internalname = "PACIENTENOMBRE1" ;
         lblTextblockpacientenombre2_Internalname = "TEXTBLOCKPACIENTENOMBRE2" ;
         edtPacienteNombre2_Internalname = "PACIENTENOMBRE2" ;
         lblTextblockpacienteapellido1_Internalname = "TEXTBLOCKPACIENTEAPELLIDO1" ;
         edtPacienteApellido1_Internalname = "PACIENTEAPELLIDO1" ;
         lblTextblockpacienteapellido2_Internalname = "TEXTBLOCKPACIENTEAPELLIDO2" ;
         edtPacienteApellido2_Internalname = "PACIENTEAPELLIDO2" ;
         lblTextblockpacienteapellido3_Internalname = "TEXTBLOCKPACIENTEAPELLIDO3" ;
         edtPacienteApellido3_Internalname = "PACIENTEAPELLIDO3" ;
         lblTextblockpacientegenero_Internalname = "TEXTBLOCKPACIENTEGENERO" ;
         cmbPacienteSexo_Internalname = "PACIENTESEXO" ;
         lblTextblockpacientenacimiento_Internalname = "TEXTBLOCKPACIENTENACIMIENTO" ;
         edtPacienteNacimiento_Internalname = "PACIENTENACIMIENTO" ;
         lblTextblockpacientedireccion_Internalname = "TEXTBLOCKPACIENTEDIRECCION" ;
         edtPacienteDireccion_Internalname = "PACIENTEDIRECCION" ;
         lblTextblockpacientetelefono1_Internalname = "TEXTBLOCKPACIENTETELEFONO1" ;
         edtPacienteTelefono1_Internalname = "PACIENTETELEFONO1" ;
         lblTextblockpacientetelefono2_Internalname = "TEXTBLOCKPACIENTETELEFONO2" ;
         edtPacienteTelefono2_Internalname = "PACIENTETELEFONO2" ;
         lblTextblockpacientecorreo_Internalname = "TEXTBLOCKPACIENTECORREO" ;
         edtPacienteCorreo_Internalname = "PACIENTECORREO" ;
         lblTextblockpacientedpi_Internalname = "TEXTBLOCKPACIENTEDPI" ;
         edtPacienteDpi_Internalname = "PACIENTEDPI" ;
         lblTextblockpacientedpi2_Internalname = "TEXTBLOCKPACIENTEDPI2" ;
         dynTipoPacCodigo_Internalname = "TIPOPACCODIGO" ;
         lblTextblockpacientedpi3_Internalname = "TEXTBLOCKPACIENTEDPI3" ;
         dynReligionId_Internalname = "RELIGIONID" ;
         lblTextblockpacientedpi4_Internalname = "TEXTBLOCKPACIENTEDPI4" ;
         dynProfesionId_Internalname = "PROFESIONID" ;
         lblTextblockpacienteobs_Internalname = "TEXTBLOCKPACIENTEOBS" ;
         edtPacienteObs_Internalname = "PACIENTEOBS" ;
         lblTextblockpacienteestado_Internalname = "TEXTBLOCKPACIENTEESTADO" ;
         cmbPacienteEstado_Internalname = "PACIENTEESTADO" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_144_Internalname = "PROMPT_41_144" ;
         imgprompt_41_315_Internalname = "PROMPT_41_315" ;
         imgprompt_41_313_Internalname = "PROMPT_41_313" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Pacientes" ;
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
         cmbPacienteEstado_Jsonclick = "" ;
         cmbPacienteEstado.Enabled = 1 ;
         edtPacienteObs_Enabled = 1 ;
         imgprompt_41_313_Visible = 1 ;
         imgprompt_41_313_Link = "" ;
         dynProfesionId_Jsonclick = "" ;
         dynProfesionId.Enabled = 1 ;
         imgprompt_41_315_Visible = 1 ;
         imgprompt_41_315_Link = "" ;
         dynReligionId_Jsonclick = "" ;
         dynReligionId.Enabled = 1 ;
         imgprompt_41_144_Visible = 1 ;
         imgprompt_41_144_Link = "" ;
         dynTipoPacCodigo_Jsonclick = "" ;
         dynTipoPacCodigo.Enabled = 1 ;
         edtPacienteDpi_Jsonclick = "" ;
         edtPacienteDpi_Enabled = 1 ;
         edtPacienteCorreo_Jsonclick = "" ;
         edtPacienteCorreo_Enabled = 1 ;
         edtPacienteTelefono2_Jsonclick = "" ;
         edtPacienteTelefono2_Enabled = 1 ;
         edtPacienteTelefono1_Jsonclick = "" ;
         edtPacienteTelefono1_Enabled = 1 ;
         edtPacienteDireccion_Jsonclick = "" ;
         edtPacienteDireccion_Enabled = 1 ;
         edtPacienteNacimiento_Jsonclick = "" ;
         edtPacienteNacimiento_Enabled = 1 ;
         cmbPacienteSexo_Jsonclick = "" ;
         cmbPacienteSexo.Enabled = 1 ;
         edtPacienteApellido3_Jsonclick = "" ;
         edtPacienteApellido3_Enabled = 1 ;
         edtPacienteApellido2_Jsonclick = "" ;
         edtPacienteApellido2_Enabled = 1 ;
         edtPacienteApellido1_Jsonclick = "" ;
         edtPacienteApellido1_Enabled = 1 ;
         edtPacienteNombre2_Jsonclick = "" ;
         edtPacienteNombre2_Enabled = 1 ;
         edtPacienteNombre1_Jsonclick = "" ;
         edtPacienteNombre1_Enabled = 1 ;
         edtPacienteId_Jsonclick = "" ;
         edtPacienteId_Enabled = 0 ;
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
         GXATIPOPACCODIGO_html0H23( A41ClinicaCodigo) ;
         GXARELIGIONID_html0H23( A41ClinicaCodigo) ;
         GXAPROFESIONID_html0H23( A41ClinicaCodigo) ;
         /* End function dynload_actions */
      }

      protected void GXDLATIPOPACCODIGO0H23( String A41ClinicaCodigo )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLATIPOPACCODIGO_data0H23( A41ClinicaCodigo) ;
         gxdynajaxindex = 1 ;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( gxdynajaxctrlcodr.Item(gxdynajaxindex))+"\",d:\""+GXUtil.EncodeJSConstant( gxdynajaxctrldescr.Item(gxdynajaxindex))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
            gxwrpcisep = "," ;
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXATIPOPACCODIGO_html0H23( String A41ClinicaCodigo )
      {
         String gxdynajaxvalue ;
         GXDLATIPOPACCODIGO_data0H23( A41ClinicaCodigo) ;
         gxdynajaxindex = 1 ;
         dynTipoPacCodigo.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = gxdynajaxctrlcodr.Item(gxdynajaxindex) ;
            dynTipoPacCodigo.addItem(gxdynajaxvalue, gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
      }

      protected void GXDLATIPOPACCODIGO_data0H23( String A41ClinicaCodigo )
      {
         /* Using cursor T000H21 */
         pr_default.execute(19, new Object[] {A41ClinicaCodigo});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(19) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( T000H21_A144TipoPacCodigo[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000H21_A145TipoPacDescripcion[0]));
            pr_default.readNext(19);
         }
         pr_default.close(19);
      }

      protected void GXDLARELIGIONID0H23( String A41ClinicaCodigo )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLARELIGIONID_data0H23( A41ClinicaCodigo) ;
         gxdynajaxindex = 1 ;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( gxdynajaxctrlcodr.Item(gxdynajaxindex))+"\",d:\""+GXUtil.EncodeJSConstant( gxdynajaxctrldescr.Item(gxdynajaxindex))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
            gxwrpcisep = "," ;
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXARELIGIONID_html0H23( String A41ClinicaCodigo )
      {
         int gxdynajaxvalue ;
         GXDLARELIGIONID_data0H23( A41ClinicaCodigo) ;
         gxdynajaxindex = 1 ;
         dynReligionId.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (int)(NumberUtil.Val( gxdynajaxctrlcodr.Item(gxdynajaxindex), ".")) ;
            dynReligionId.addItem(StringUtil.Str( (decimal)(gxdynajaxvalue), 9, 0), gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
      }

      protected void GXDLARELIGIONID_data0H23( String A41ClinicaCodigo )
      {
         /* Using cursor T000H22 */
         pr_default.execute(20, new Object[] {A41ClinicaCodigo});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(20) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000H22_A315ReligionId[0]), 9, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000H22_A316ReligionNombre[0]));
            pr_default.readNext(20);
         }
         pr_default.close(20);
      }

      protected void GXDLAPROFESIONID0H23( String A41ClinicaCodigo )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLAPROFESIONID_data0H23( A41ClinicaCodigo) ;
         gxdynajaxindex = 1 ;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( gxdynajaxctrlcodr.Item(gxdynajaxindex))+"\",d:\""+GXUtil.EncodeJSConstant( gxdynajaxctrldescr.Item(gxdynajaxindex))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
            gxwrpcisep = "," ;
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXAPROFESIONID_html0H23( String A41ClinicaCodigo )
      {
         int gxdynajaxvalue ;
         GXDLAPROFESIONID_data0H23( A41ClinicaCodigo) ;
         gxdynajaxindex = 1 ;
         dynProfesionId.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (int)(NumberUtil.Val( gxdynajaxctrlcodr.Item(gxdynajaxindex), ".")) ;
            dynProfesionId.addItem(StringUtil.Str( (decimal)(gxdynajaxvalue), 9, 0), gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
      }

      protected void GXDLAPROFESIONID_data0H23( String A41ClinicaCodigo )
      {
         /* Using cursor T000H23 */
         pr_default.execute(21, new Object[] {A41ClinicaCodigo});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(21) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000H23_A313ProfesionId[0]), 9, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000H23_A314ProfesionNombre[0]));
            pr_default.readNext(21);
         }
         pr_default.close(21);
      }

      public void Valid_Clinicacodigo( String GX_Parm1 ,
                                       GXCombobox dynGX_Parm2 ,
                                       GXCombobox dynGX_Parm3 ,
                                       GXCombobox dynGX_Parm4 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         dynTipoPacCodigo = dynGX_Parm2 ;
         A144TipoPacCodigo = dynTipoPacCodigo.CurrentValue ;
         dynReligionId = dynGX_Parm3 ;
         A315ReligionId = (int)(NumberUtil.Val( dynReligionId.CurrentValue, ".")) ;
         dynProfesionId = dynGX_Parm4 ;
         A313ProfesionId = (int)(NumberUtil.Val( dynProfesionId.CurrentValue, ".")) ;
         GXATIPOPACCODIGO_html0H23( A41ClinicaCodigo) ;
         GXARELIGIONID_html0H23( A41ClinicaCodigo) ;
         GXAPROFESIONID_html0H23( A41ClinicaCodigo) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         dynTipoPacCodigo.CurrentValue = A144TipoPacCodigo ;
         dynReligionId.CurrentValue = StringUtil.Str( (decimal)(A315ReligionId), 9, 0) ;
         dynProfesionId.CurrentValue = StringUtil.Str( (decimal)(A313ProfesionId), 9, 0) ;
         isValidOutput.Add((Object)(dynTipoPacCodigo));
         isValidOutput.Add((Object)(dynReligionId));
         isValidOutput.Add((Object)(dynProfesionId));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Tipopaccodigo( String GX_Parm1 ,
                                       GXCombobox dynGX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         dynTipoPacCodigo = dynGX_Parm2 ;
         A144TipoPacCodigo = dynTipoPacCodigo.CurrentValue ;
         /* Using cursor T000H24 */
         pr_default.execute(22, new Object[] {A41ClinicaCodigo, A144TipoPacCodigo});
         if ( (pr_default.getStatus(22) == 101) )
         {
            AnyError41 = 1 ;
            AnyError144 = 1 ;
            GX_msglist.addItem("No existe 'Tipos de Pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError144 == 0 ) )
         {
         }
         pr_default.close(22);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Religionid( String GX_Parm1 ,
                                    GXCombobox dynGX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         dynReligionId = dynGX_Parm2 ;
         A315ReligionId = (int)(NumberUtil.Val( dynReligionId.CurrentValue, ".")) ;
         /* Using cursor T000H25 */
         pr_default.execute(23, new Object[] {A41ClinicaCodigo, A315ReligionId});
         if ( (pr_default.getStatus(23) == 101) )
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
         pr_default.close(23);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Profesionid( String GX_Parm1 ,
                                     GXCombobox dynGX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         dynProfesionId = dynGX_Parm2 ;
         A313ProfesionId = (int)(NumberUtil.Val( dynProfesionId.CurrentValue, ".")) ;
         /* Using cursor T000H26 */
         pr_default.execute(24, new Object[] {A41ClinicaCodigo, A313ProfesionId});
         if ( (pr_default.getStatus(24) == 101) )
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
         pr_default.close(24);
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
         pr_default.close(18);
         pr_default.close(11);
         pr_default.close(10);
         pr_default.close(22);
         pr_default.close(24);
         pr_default.close(23);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         wcpOGx_mode = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
         A144TipoPacCodigo = "" ;
         GXKey = "" ;
         GXDecQS = "" ;
         A326PacienteSexo = "" ;
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
         lblTextblockpacienteid_Jsonclick = "" ;
         lblTextblockpacientenombre1_Jsonclick = "" ;
         A68PacienteNombre1 = "" ;
         lblTextblockpacientenombre2_Jsonclick = "" ;
         A69PacienteNombre2 = "" ;
         lblTextblockpacienteapellido1_Jsonclick = "" ;
         A70PacienteApellido1 = "" ;
         lblTextblockpacienteapellido2_Jsonclick = "" ;
         A71PacienteApellido2 = "" ;
         lblTextblockpacienteapellido3_Jsonclick = "" ;
         A72PacienteApellido3 = "" ;
         lblTextblockpacientegenero_Jsonclick = "" ;
         lblTextblockpacientenacimiento_Jsonclick = "" ;
         A74PacienteNacimiento = DateTime.MinValue ;
         GXt_char1 = "" ;
         lblTextblockpacientedireccion_Jsonclick = "" ;
         A75PacienteDireccion = "" ;
         lblTextblockpacientetelefono1_Jsonclick = "" ;
         A76PacienteTelefono1 = "" ;
         lblTextblockpacientetelefono2_Jsonclick = "" ;
         A77PacienteTelefono2 = "" ;
         lblTextblockpacientecorreo_Jsonclick = "" ;
         A78PacienteCorreo = "" ;
         lblTextblockpacientedpi_Jsonclick = "" ;
         A79PacienteDpi = "" ;
         lblTextblockpacientedpi2_Jsonclick = "" ;
         lblTextblockpacientedpi3_Jsonclick = "" ;
         lblTextblockpacientedpi4_Jsonclick = "" ;
         lblTextblockpacienteobs_Jsonclick = "" ;
         A80PacienteObs = "" ;
         lblTextblockpacienteestado_Jsonclick = "" ;
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
         Z68PacienteNombre1 = "" ;
         Z69PacienteNombre2 = "" ;
         Z70PacienteApellido1 = "" ;
         Z71PacienteApellido2 = "" ;
         Z72PacienteApellido3 = "" ;
         Z326PacienteSexo = "" ;
         Z74PacienteNacimiento = DateTime.MinValue ;
         Z75PacienteDireccion = "" ;
         Z76PacienteTelefono1 = "" ;
         Z77PacienteTelefono2 = "" ;
         Z78PacienteCorreo = "" ;
         Z79PacienteDpi = "" ;
         Z80PacienteObs = "" ;
         Z144TipoPacCodigo = "" ;
         AV8ClinicaCodigo = "" ;
         sMode23 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV7Parametros = new SdtParametros(context);
         GXt_SdtParametros4 = new SdtParametros(context);
         T000H7_A67PacienteId = new int[1] ;
         T000H7_A68PacienteNombre1 = new String[] {""} ;
         T000H7_A69PacienteNombre2 = new String[] {""} ;
         T000H7_A70PacienteApellido1 = new String[] {""} ;
         T000H7_A71PacienteApellido2 = new String[] {""} ;
         T000H7_A72PacienteApellido3 = new String[] {""} ;
         T000H7_A326PacienteSexo = new String[] {""} ;
         T000H7_A74PacienteNacimiento = new DateTime[] {DateTime.MinValue} ;
         T000H7_A75PacienteDireccion = new String[] {""} ;
         T000H7_A76PacienteTelefono1 = new String[] {""} ;
         T000H7_A77PacienteTelefono2 = new String[] {""} ;
         T000H7_A78PacienteCorreo = new String[] {""} ;
         T000H7_A79PacienteDpi = new String[] {""} ;
         T000H7_A80PacienteObs = new String[] {""} ;
         T000H7_A81PacienteEstado = new short[1] ;
         T000H7_A41ClinicaCodigo = new String[] {""} ;
         T000H7_A144TipoPacCodigo = new String[] {""} ;
         T000H7_A313ProfesionId = new int[1] ;
         T000H7_A315ReligionId = new int[1] ;
         T000H4_A41ClinicaCodigo = new String[] {""} ;
         T000H5_A41ClinicaCodigo = new String[] {""} ;
         T000H6_A41ClinicaCodigo = new String[] {""} ;
         T000H8_A41ClinicaCodigo = new String[] {""} ;
         T000H9_A41ClinicaCodigo = new String[] {""} ;
         T000H10_A41ClinicaCodigo = new String[] {""} ;
         T000H11_A41ClinicaCodigo = new String[] {""} ;
         T000H11_A67PacienteId = new int[1] ;
         T000H3_A67PacienteId = new int[1] ;
         T000H3_A68PacienteNombre1 = new String[] {""} ;
         T000H3_A69PacienteNombre2 = new String[] {""} ;
         T000H3_A70PacienteApellido1 = new String[] {""} ;
         T000H3_A71PacienteApellido2 = new String[] {""} ;
         T000H3_A72PacienteApellido3 = new String[] {""} ;
         T000H3_A326PacienteSexo = new String[] {""} ;
         T000H3_A74PacienteNacimiento = new DateTime[] {DateTime.MinValue} ;
         T000H3_A75PacienteDireccion = new String[] {""} ;
         T000H3_A76PacienteTelefono1 = new String[] {""} ;
         T000H3_A77PacienteTelefono2 = new String[] {""} ;
         T000H3_A78PacienteCorreo = new String[] {""} ;
         T000H3_A79PacienteDpi = new String[] {""} ;
         T000H3_A80PacienteObs = new String[] {""} ;
         T000H3_A81PacienteEstado = new short[1] ;
         T000H3_A41ClinicaCodigo = new String[] {""} ;
         T000H3_A144TipoPacCodigo = new String[] {""} ;
         T000H3_A313ProfesionId = new int[1] ;
         T000H3_A315ReligionId = new int[1] ;
         T000H12_A41ClinicaCodigo = new String[] {""} ;
         T000H12_A67PacienteId = new int[1] ;
         T000H13_A41ClinicaCodigo = new String[] {""} ;
         T000H13_A67PacienteId = new int[1] ;
         T000H14_A67PacienteId = new int[1] ;
         T000H14_A68PacienteNombre1 = new String[] {""} ;
         T000H14_A69PacienteNombre2 = new String[] {""} ;
         T000H14_A70PacienteApellido1 = new String[] {""} ;
         T000H14_A71PacienteApellido2 = new String[] {""} ;
         T000H14_A72PacienteApellido3 = new String[] {""} ;
         T000H14_A326PacienteSexo = new String[] {""} ;
         T000H14_A74PacienteNacimiento = new DateTime[] {DateTime.MinValue} ;
         T000H14_A75PacienteDireccion = new String[] {""} ;
         T000H14_A76PacienteTelefono1 = new String[] {""} ;
         T000H14_A77PacienteTelefono2 = new String[] {""} ;
         T000H14_A78PacienteCorreo = new String[] {""} ;
         T000H14_A79PacienteDpi = new String[] {""} ;
         T000H14_A80PacienteObs = new String[] {""} ;
         T000H14_A81PacienteEstado = new short[1] ;
         T000H14_A41ClinicaCodigo = new String[] {""} ;
         T000H14_A144TipoPacCodigo = new String[] {""} ;
         T000H14_A313ProfesionId = new int[1] ;
         T000H14_A315ReligionId = new int[1] ;
         T000H18_A41ClinicaCodigo = new String[] {""} ;
         T000H18_A167ExpedienteId = new int[1] ;
         T000H19_A41ClinicaCodigo = new String[] {""} ;
         T000H19_A91ConsultaId = new int[1] ;
         T000H20_A41ClinicaCodigo = new String[] {""} ;
         T000H20_A67PacienteId = new int[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXEncryptionTmp = "" ;
         GXt_char2 = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         T000H21_A41ClinicaCodigo = new String[] {""} ;
         T000H21_A144TipoPacCodigo = new String[] {""} ;
         T000H21_A145TipoPacDescripcion = new String[] {""} ;
         T000H21_A146TipoPacEstado = new short[1] ;
         T000H22_A41ClinicaCodigo = new String[] {""} ;
         T000H22_A315ReligionId = new int[1] ;
         T000H22_A316ReligionNombre = new String[] {""} ;
         GXt_char3 = "" ;
         T000H23_A41ClinicaCodigo = new String[] {""} ;
         T000H23_A313ProfesionId = new int[1] ;
         T000H23_A314ProfesionNombre = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         T000H24_A41ClinicaCodigo = new String[] {""} ;
         T000H25_A41ClinicaCodigo = new String[] {""} ;
         T000H26_A41ClinicaCodigo = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.paciente__default(),
            new Object[][] {
                new Object[] {
               T000H2_A67PacienteId, T000H2_A68PacienteNombre1, T000H2_A69PacienteNombre2, T000H2_A70PacienteApellido1, T000H2_A71PacienteApellido2, T000H2_A72PacienteApellido3, T000H2_A326PacienteSexo, T000H2_A74PacienteNacimiento, T000H2_A75PacienteDireccion, T000H2_A76PacienteTelefono1,
               T000H2_A77PacienteTelefono2, T000H2_A78PacienteCorreo, T000H2_A79PacienteDpi, T000H2_A80PacienteObs, T000H2_A81PacienteEstado, T000H2_A41ClinicaCodigo, T000H2_A144TipoPacCodigo, T000H2_A313ProfesionId, T000H2_A315ReligionId
               }
               , new Object[] {
               T000H3_A67PacienteId, T000H3_A68PacienteNombre1, T000H3_A69PacienteNombre2, T000H3_A70PacienteApellido1, T000H3_A71PacienteApellido2, T000H3_A72PacienteApellido3, T000H3_A326PacienteSexo, T000H3_A74PacienteNacimiento, T000H3_A75PacienteDireccion, T000H3_A76PacienteTelefono1,
               T000H3_A77PacienteTelefono2, T000H3_A78PacienteCorreo, T000H3_A79PacienteDpi, T000H3_A80PacienteObs, T000H3_A81PacienteEstado, T000H3_A41ClinicaCodigo, T000H3_A144TipoPacCodigo, T000H3_A313ProfesionId, T000H3_A315ReligionId
               }
               , new Object[] {
               T000H4_A41ClinicaCodigo
               }
               , new Object[] {
               T000H5_A41ClinicaCodigo
               }
               , new Object[] {
               T000H6_A41ClinicaCodigo
               }
               , new Object[] {
               T000H7_A67PacienteId, T000H7_A68PacienteNombre1, T000H7_A69PacienteNombre2, T000H7_A70PacienteApellido1, T000H7_A71PacienteApellido2, T000H7_A72PacienteApellido3, T000H7_A326PacienteSexo, T000H7_A74PacienteNacimiento, T000H7_A75PacienteDireccion, T000H7_A76PacienteTelefono1,
               T000H7_A77PacienteTelefono2, T000H7_A78PacienteCorreo, T000H7_A79PacienteDpi, T000H7_A80PacienteObs, T000H7_A81PacienteEstado, T000H7_A41ClinicaCodigo, T000H7_A144TipoPacCodigo, T000H7_A313ProfesionId, T000H7_A315ReligionId
               }
               , new Object[] {
               T000H8_A41ClinicaCodigo
               }
               , new Object[] {
               T000H9_A41ClinicaCodigo
               }
               , new Object[] {
               T000H10_A41ClinicaCodigo
               }
               , new Object[] {
               T000H11_A41ClinicaCodigo, T000H11_A67PacienteId
               }
               , new Object[] {
               T000H12_A41ClinicaCodigo, T000H12_A67PacienteId
               }
               , new Object[] {
               T000H13_A41ClinicaCodigo, T000H13_A67PacienteId
               }
               , new Object[] {
               T000H14_A67PacienteId, T000H14_A68PacienteNombre1, T000H14_A69PacienteNombre2, T000H14_A70PacienteApellido1, T000H14_A71PacienteApellido2, T000H14_A72PacienteApellido3, T000H14_A326PacienteSexo, T000H14_A74PacienteNacimiento, T000H14_A75PacienteDireccion, T000H14_A76PacienteTelefono1,
               T000H14_A77PacienteTelefono2, T000H14_A78PacienteCorreo, T000H14_A79PacienteDpi, T000H14_A80PacienteObs, T000H14_A81PacienteEstado, T000H14_A41ClinicaCodigo, T000H14_A144TipoPacCodigo, T000H14_A313ProfesionId, T000H14_A315ReligionId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000H18_A41ClinicaCodigo, T000H18_A167ExpedienteId
               }
               , new Object[] {
               T000H19_A41ClinicaCodigo, T000H19_A91ConsultaId
               }
               , new Object[] {
               T000H20_A41ClinicaCodigo, T000H20_A67PacienteId
               }
               , new Object[] {
               T000H21_A41ClinicaCodigo, T000H21_A144TipoPacCodigo, T000H21_A145TipoPacDescripcion, T000H21_A146TipoPacEstado
               }
               , new Object[] {
               T000H22_A41ClinicaCodigo, T000H22_A315ReligionId, T000H22_A316ReligionNombre
               }
               , new Object[] {
               T000H23_A41ClinicaCodigo, T000H23_A313ProfesionId, T000H23_A314ProfesionNombre
               }
               , new Object[] {
               T000H24_A41ClinicaCodigo
               }
               , new Object[] {
               T000H25_A41ClinicaCodigo
               }
               , new Object[] {
               T000H26_A41ClinicaCodigo
               }
            }
         );
         Z67PacienteId = 0 ;
      }

      private short wcpOAV10Flag ;
      private short GxWebError ;
      private short AV10Flag ;
      private short A81PacienteEstado ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Z81PacienteEstado ;
      private short RcdFound23 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int wcpOA67PacienteId ;
      private int A313ProfesionId ;
      private int A315ReligionId ;
      private int A67PacienteId ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int lblTextblockclinicacodigo_Visible ;
      private int edtClinicaCodigo_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int edtPacienteId_Enabled ;
      private int edtPacienteNombre1_Enabled ;
      private int edtPacienteNombre2_Enabled ;
      private int edtPacienteApellido1_Enabled ;
      private int edtPacienteApellido2_Enabled ;
      private int edtPacienteApellido3_Enabled ;
      private int edtPacienteNacimiento_Enabled ;
      private int edtPacienteDireccion_Enabled ;
      private int edtPacienteTelefono1_Enabled ;
      private int edtPacienteTelefono2_Enabled ;
      private int edtPacienteCorreo_Enabled ;
      private int edtPacienteDpi_Enabled ;
      private int imgprompt_41_144_Visible ;
      private int imgprompt_41_315_Visible ;
      private int imgprompt_41_313_Visible ;
      private int edtPacienteObs_Enabled ;
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
      private int Z67PacienteId ;
      private int Z313ProfesionId ;
      private int Z315ReligionId ;
      private int AnyError41 ;
      private int AnyError144 ;
      private int AnyError313 ;
      private int AnyError315 ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String GXDecQS ;
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
      private String lblTextblockpacienteid_Internalname ;
      private String lblTextblockpacienteid_Jsonclick ;
      private String edtPacienteId_Internalname ;
      private String edtPacienteId_Jsonclick ;
      private String lblTextblockpacientenombre1_Internalname ;
      private String lblTextblockpacientenombre1_Jsonclick ;
      private String edtPacienteNombre1_Internalname ;
      private String edtPacienteNombre1_Jsonclick ;
      private String lblTextblockpacientenombre2_Internalname ;
      private String lblTextblockpacientenombre2_Jsonclick ;
      private String edtPacienteNombre2_Internalname ;
      private String edtPacienteNombre2_Jsonclick ;
      private String lblTextblockpacienteapellido1_Internalname ;
      private String lblTextblockpacienteapellido1_Jsonclick ;
      private String edtPacienteApellido1_Internalname ;
      private String edtPacienteApellido1_Jsonclick ;
      private String lblTextblockpacienteapellido2_Internalname ;
      private String lblTextblockpacienteapellido2_Jsonclick ;
      private String edtPacienteApellido2_Internalname ;
      private String edtPacienteApellido2_Jsonclick ;
      private String lblTextblockpacienteapellido3_Internalname ;
      private String lblTextblockpacienteapellido3_Jsonclick ;
      private String edtPacienteApellido3_Internalname ;
      private String edtPacienteApellido3_Jsonclick ;
      private String lblTextblockpacientegenero_Internalname ;
      private String lblTextblockpacientegenero_Jsonclick ;
      private String cmbPacienteSexo_Internalname ;
      private String cmbPacienteSexo_Jsonclick ;
      private String lblTextblockpacientenacimiento_Internalname ;
      private String lblTextblockpacientenacimiento_Jsonclick ;
      private String edtPacienteNacimiento_Internalname ;
      private String GXt_char1 ;
      private String edtPacienteNacimiento_Jsonclick ;
      private String lblTextblockpacientedireccion_Internalname ;
      private String lblTextblockpacientedireccion_Jsonclick ;
      private String edtPacienteDireccion_Internalname ;
      private String edtPacienteDireccion_Jsonclick ;
      private String lblTextblockpacientetelefono1_Internalname ;
      private String lblTextblockpacientetelefono1_Jsonclick ;
      private String edtPacienteTelefono1_Internalname ;
      private String edtPacienteTelefono1_Jsonclick ;
      private String lblTextblockpacientetelefono2_Internalname ;
      private String lblTextblockpacientetelefono2_Jsonclick ;
      private String edtPacienteTelefono2_Internalname ;
      private String edtPacienteTelefono2_Jsonclick ;
      private String lblTextblockpacientecorreo_Internalname ;
      private String lblTextblockpacientecorreo_Jsonclick ;
      private String edtPacienteCorreo_Internalname ;
      private String edtPacienteCorreo_Jsonclick ;
      private String lblTextblockpacientedpi_Internalname ;
      private String lblTextblockpacientedpi_Jsonclick ;
      private String edtPacienteDpi_Internalname ;
      private String edtPacienteDpi_Jsonclick ;
      private String lblTextblockpacientedpi2_Internalname ;
      private String lblTextblockpacientedpi2_Jsonclick ;
      private String dynTipoPacCodigo_Internalname ;
      private String dynTipoPacCodigo_Jsonclick ;
      private String imgprompt_41_144_Internalname ;
      private String imgprompt_41_144_Link ;
      private String lblTextblockpacientedpi3_Internalname ;
      private String lblTextblockpacientedpi3_Jsonclick ;
      private String dynReligionId_Internalname ;
      private String dynReligionId_Jsonclick ;
      private String imgprompt_41_315_Internalname ;
      private String imgprompt_41_315_Link ;
      private String lblTextblockpacientedpi4_Internalname ;
      private String lblTextblockpacientedpi4_Jsonclick ;
      private String dynProfesionId_Internalname ;
      private String dynProfesionId_Jsonclick ;
      private String imgprompt_41_313_Internalname ;
      private String imgprompt_41_313_Link ;
      private String lblTextblockpacienteobs_Internalname ;
      private String lblTextblockpacienteobs_Jsonclick ;
      private String edtPacienteObs_Internalname ;
      private String lblTextblockpacienteestado_Internalname ;
      private String lblTextblockpacienteestado_Jsonclick ;
      private String cmbPacienteEstado_Internalname ;
      private String cmbPacienteEstado_Jsonclick ;
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
      private String sMode23 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXEncryptionTmp ;
      private String GXt_char2 ;
      private String gxwrpcisep ;
      private String GXt_char3 ;
      private DateTime A74PacienteNacimiento ;
      private DateTime Z74PacienteNacimiento ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool Gx_longc ;
      private String A41ClinicaCodigo ;
      private String A144TipoPacCodigo ;
      private String A326PacienteSexo ;
      private String A68PacienteNombre1 ;
      private String A69PacienteNombre2 ;
      private String A70PacienteApellido1 ;
      private String A71PacienteApellido2 ;
      private String A72PacienteApellido3 ;
      private String A75PacienteDireccion ;
      private String A76PacienteTelefono1 ;
      private String A77PacienteTelefono2 ;
      private String A78PacienteCorreo ;
      private String A79PacienteDpi ;
      private String A80PacienteObs ;
      private String Z41ClinicaCodigo ;
      private String Z68PacienteNombre1 ;
      private String Z69PacienteNombre2 ;
      private String Z70PacienteApellido1 ;
      private String Z71PacienteApellido2 ;
      private String Z72PacienteApellido3 ;
      private String Z326PacienteSexo ;
      private String Z75PacienteDireccion ;
      private String Z76PacienteTelefono1 ;
      private String Z77PacienteTelefono2 ;
      private String Z78PacienteCorreo ;
      private String Z79PacienteDpi ;
      private String Z80PacienteObs ;
      private String Z144TipoPacCodigo ;
      private String AV8ClinicaCodigo ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private int aP0_PacienteId ;
      private String aP1_Gx_mode ;
      private short aP2_Flag ;
      private GXCombobox cmbPacienteSexo ;
      private GXCombobox dynTipoPacCodigo ;
      private GXCombobox dynReligionId ;
      private GXCombobox dynProfesionId ;
      private GXCombobox cmbPacienteEstado ;
      private IDataStoreProvider pr_default ;
      private int[] T000H7_A67PacienteId ;
      private String[] T000H7_A68PacienteNombre1 ;
      private String[] T000H7_A69PacienteNombre2 ;
      private String[] T000H7_A70PacienteApellido1 ;
      private String[] T000H7_A71PacienteApellido2 ;
      private String[] T000H7_A72PacienteApellido3 ;
      private String[] T000H7_A326PacienteSexo ;
      private DateTime[] T000H7_A74PacienteNacimiento ;
      private String[] T000H7_A75PacienteDireccion ;
      private String[] T000H7_A76PacienteTelefono1 ;
      private String[] T000H7_A77PacienteTelefono2 ;
      private String[] T000H7_A78PacienteCorreo ;
      private String[] T000H7_A79PacienteDpi ;
      private String[] T000H7_A80PacienteObs ;
      private short[] T000H7_A81PacienteEstado ;
      private String[] T000H7_A41ClinicaCodigo ;
      private String[] T000H7_A144TipoPacCodigo ;
      private int[] T000H7_A313ProfesionId ;
      private int[] T000H7_A315ReligionId ;
      private String[] T000H4_A41ClinicaCodigo ;
      private String[] T000H5_A41ClinicaCodigo ;
      private String[] T000H6_A41ClinicaCodigo ;
      private String[] T000H8_A41ClinicaCodigo ;
      private String[] T000H9_A41ClinicaCodigo ;
      private String[] T000H10_A41ClinicaCodigo ;
      private String[] T000H11_A41ClinicaCodigo ;
      private int[] T000H11_A67PacienteId ;
      private int[] T000H3_A67PacienteId ;
      private String[] T000H3_A68PacienteNombre1 ;
      private String[] T000H3_A69PacienteNombre2 ;
      private String[] T000H3_A70PacienteApellido1 ;
      private String[] T000H3_A71PacienteApellido2 ;
      private String[] T000H3_A72PacienteApellido3 ;
      private String[] T000H3_A326PacienteSexo ;
      private DateTime[] T000H3_A74PacienteNacimiento ;
      private String[] T000H3_A75PacienteDireccion ;
      private String[] T000H3_A76PacienteTelefono1 ;
      private String[] T000H3_A77PacienteTelefono2 ;
      private String[] T000H3_A78PacienteCorreo ;
      private String[] T000H3_A79PacienteDpi ;
      private String[] T000H3_A80PacienteObs ;
      private short[] T000H3_A81PacienteEstado ;
      private String[] T000H3_A41ClinicaCodigo ;
      private String[] T000H3_A144TipoPacCodigo ;
      private int[] T000H3_A313ProfesionId ;
      private int[] T000H3_A315ReligionId ;
      private String[] T000H12_A41ClinicaCodigo ;
      private int[] T000H12_A67PacienteId ;
      private String[] T000H13_A41ClinicaCodigo ;
      private int[] T000H13_A67PacienteId ;
      private int[] T000H14_A67PacienteId ;
      private String[] T000H14_A68PacienteNombre1 ;
      private String[] T000H14_A69PacienteNombre2 ;
      private String[] T000H14_A70PacienteApellido1 ;
      private String[] T000H14_A71PacienteApellido2 ;
      private String[] T000H14_A72PacienteApellido3 ;
      private String[] T000H14_A326PacienteSexo ;
      private DateTime[] T000H14_A74PacienteNacimiento ;
      private String[] T000H14_A75PacienteDireccion ;
      private String[] T000H14_A76PacienteTelefono1 ;
      private String[] T000H14_A77PacienteTelefono2 ;
      private String[] T000H14_A78PacienteCorreo ;
      private String[] T000H14_A79PacienteDpi ;
      private String[] T000H14_A80PacienteObs ;
      private short[] T000H14_A81PacienteEstado ;
      private String[] T000H14_A41ClinicaCodigo ;
      private String[] T000H14_A144TipoPacCodigo ;
      private int[] T000H14_A313ProfesionId ;
      private int[] T000H14_A315ReligionId ;
      private String[] T000H18_A41ClinicaCodigo ;
      private int[] T000H18_A167ExpedienteId ;
      private String[] T000H19_A41ClinicaCodigo ;
      private int[] T000H19_A91ConsultaId ;
      private String[] T000H20_A41ClinicaCodigo ;
      private int[] T000H20_A67PacienteId ;
      private String[] T000H21_A41ClinicaCodigo ;
      private String[] T000H21_A144TipoPacCodigo ;
      private String[] T000H21_A145TipoPacDescripcion ;
      private short[] T000H21_A146TipoPacEstado ;
      private String[] T000H22_A41ClinicaCodigo ;
      private int[] T000H22_A315ReligionId ;
      private String[] T000H22_A316ReligionNombre ;
      private String[] T000H23_A41ClinicaCodigo ;
      private int[] T000H23_A313ProfesionId ;
      private String[] T000H23_A314ProfesionNombre ;
      private String[] T000H24_A41ClinicaCodigo ;
      private String[] T000H25_A41ClinicaCodigo ;
      private String[] T000H26_A41ClinicaCodigo ;
      private int[] T000H2_A67PacienteId ;
      private String[] T000H2_A68PacienteNombre1 ;
      private String[] T000H2_A69PacienteNombre2 ;
      private String[] T000H2_A70PacienteApellido1 ;
      private String[] T000H2_A71PacienteApellido2 ;
      private String[] T000H2_A72PacienteApellido3 ;
      private String[] T000H2_A326PacienteSexo ;
      private DateTime[] T000H2_A74PacienteNacimiento ;
      private String[] T000H2_A75PacienteDireccion ;
      private String[] T000H2_A76PacienteTelefono1 ;
      private String[] T000H2_A77PacienteTelefono2 ;
      private String[] T000H2_A78PacienteCorreo ;
      private String[] T000H2_A79PacienteDpi ;
      private String[] T000H2_A80PacienteObs ;
      private short[] T000H2_A81PacienteEstado ;
      private String[] T000H2_A41ClinicaCodigo ;
      private String[] T000H2_A144TipoPacCodigo ;
      private int[] T000H2_A313ProfesionId ;
      private int[] T000H2_A315ReligionId ;
      private GXWebForm Form ;
      private SdtParametros AV7Parametros ;
      private SdtParametros GXt_SdtParametros4 ;
   }

   public class paciente__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[13])
         ,new UpdateCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
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
          Object[] prmT000H2 ;
          prmT000H2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000H7 ;
          prmT000H7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000H4 ;
          prmT000H4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoPacCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000H5 ;
          prmT000H5 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ProfesionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000H6 ;
          prmT000H6 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ReligionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000H8 ;
          prmT000H8 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoPacCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000H9 ;
          prmT000H9 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ProfesionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000H10 ;
          prmT000H10 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ReligionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000H11 ;
          prmT000H11 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000H3 ;
          prmT000H3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000H12 ;
          prmT000H12 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000H13 ;
          prmT000H13 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000H14 ;
          prmT000H14 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000H15 ;
          prmT000H15 = new Object[] {
          new Object[] {"@PacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@PacienteNombre1",SqlDbType.VarChar,70,0} ,
          new Object[] {"@PacienteNombre2",SqlDbType.VarChar,70,0} ,
          new Object[] {"@PacienteApellido1",SqlDbType.VarChar,30,0} ,
          new Object[] {"@PacienteApellido2",SqlDbType.VarChar,30,0} ,
          new Object[] {"@PacienteApellido3",SqlDbType.VarChar,30,0} ,
          new Object[] {"@PacienteSexo",SqlDbType.VarChar,1,0} ,
          new Object[] {"@PacienteNacimiento",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PacienteDireccion",SqlDbType.VarChar,120,0} ,
          new Object[] {"@PacienteTelefono1",SqlDbType.VarChar,9,0} ,
          new Object[] {"@PacienteTelefono2",SqlDbType.VarChar,9,0} ,
          new Object[] {"@PacienteCorreo",SqlDbType.VarChar,80,0} ,
          new Object[] {"@PacienteDpi",SqlDbType.VarChar,20,0} ,
          new Object[] {"@PacienteObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@PacienteEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoPacCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ProfesionId",SqlDbType.Int,9,0} ,
          new Object[] {"@ReligionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000H16 ;
          prmT000H16 = new Object[] {
          new Object[] {"@PacienteNombre1",SqlDbType.VarChar,70,0} ,
          new Object[] {"@PacienteNombre2",SqlDbType.VarChar,70,0} ,
          new Object[] {"@PacienteApellido1",SqlDbType.VarChar,30,0} ,
          new Object[] {"@PacienteApellido2",SqlDbType.VarChar,30,0} ,
          new Object[] {"@PacienteApellido3",SqlDbType.VarChar,30,0} ,
          new Object[] {"@PacienteSexo",SqlDbType.VarChar,1,0} ,
          new Object[] {"@PacienteNacimiento",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PacienteDireccion",SqlDbType.VarChar,120,0} ,
          new Object[] {"@PacienteTelefono1",SqlDbType.VarChar,9,0} ,
          new Object[] {"@PacienteTelefono2",SqlDbType.VarChar,9,0} ,
          new Object[] {"@PacienteCorreo",SqlDbType.VarChar,80,0} ,
          new Object[] {"@PacienteDpi",SqlDbType.VarChar,20,0} ,
          new Object[] {"@PacienteObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@PacienteEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TipoPacCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ProfesionId",SqlDbType.Int,9,0} ,
          new Object[] {"@ReligionId",SqlDbType.Int,9,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000H17 ;
          prmT000H17 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000H18 ;
          prmT000H18 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000H19 ;
          prmT000H19 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000H20 ;
          prmT000H20 = new Object[] {
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000H21 ;
          prmT000H21 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000H22 ;
          prmT000H22 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000H23 ;
          prmT000H23 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000H24 ;
          prmT000H24 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoPacCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000H25 ;
          prmT000H25 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ReligionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000H26 ;
          prmT000H26 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ProfesionId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000H2", "SELECT [PacienteId], [PacienteNombre1], [PacienteNombre2], [PacienteApellido1], [PacienteApellido2], [PacienteApellido3], [PacienteSexo], [PacienteNacimiento], [PacienteDireccion], [PacienteTelefono1], [PacienteTelefono2], [PacienteCorreo], [PacienteDpi], [PacienteObs], [PacienteEstado], [ClinicaCodigo], [TipoPacCodigo], [ProfesionId], [ReligionId] FROM [Paciente] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [PacienteId] = @PacienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H2,1,0,true,false )
             ,new CursorDef("T000H3", "SELECT [PacienteId], [PacienteNombre1], [PacienteNombre2], [PacienteApellido1], [PacienteApellido2], [PacienteApellido3], [PacienteSexo], [PacienteNacimiento], [PacienteDireccion], [PacienteTelefono1], [PacienteTelefono2], [PacienteCorreo], [PacienteDpi], [PacienteObs], [PacienteEstado], [ClinicaCodigo], [TipoPacCodigo], [ProfesionId], [ReligionId] FROM [Paciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [PacienteId] = @PacienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H3,1,0,true,false )
             ,new CursorDef("T000H4", "SELECT [ClinicaCodigo] FROM [TipoPaciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoPacCodigo] = @TipoPacCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H4,1,0,true,false )
             ,new CursorDef("T000H5", "SELECT [ClinicaCodigo] FROM [Profesion] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ProfesionId] = @ProfesionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H5,1,0,true,false )
             ,new CursorDef("T000H6", "SELECT [ClinicaCodigo] FROM [Religion] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ReligionId] = @ReligionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H6,1,0,true,false )
             ,new CursorDef("T000H7", "SELECT TM1.[PacienteId], TM1.[PacienteNombre1], TM1.[PacienteNombre2], TM1.[PacienteApellido1], TM1.[PacienteApellido2], TM1.[PacienteApellido3], TM1.[PacienteSexo], TM1.[PacienteNacimiento], TM1.[PacienteDireccion], TM1.[PacienteTelefono1], TM1.[PacienteTelefono2], TM1.[PacienteCorreo], TM1.[PacienteDpi], TM1.[PacienteObs], TM1.[PacienteEstado], TM1.[ClinicaCodigo], TM1.[TipoPacCodigo], TM1.[ProfesionId], TM1.[ReligionId] FROM [Paciente] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[PacienteId] = @PacienteId ORDER BY TM1.[ClinicaCodigo], TM1.[PacienteId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000H7,100,0,true,false )
             ,new CursorDef("T000H8", "SELECT [ClinicaCodigo] FROM [TipoPaciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoPacCodigo] = @TipoPacCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H8,1,0,true,false )
             ,new CursorDef("T000H9", "SELECT [ClinicaCodigo] FROM [Profesion] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ProfesionId] = @ProfesionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H9,1,0,true,false )
             ,new CursorDef("T000H10", "SELECT [ClinicaCodigo] FROM [Religion] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ReligionId] = @ReligionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H10,1,0,true,false )
             ,new CursorDef("T000H11", "SELECT [ClinicaCodigo], [PacienteId] FROM [Paciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [PacienteId] = @PacienteId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000H11,1,0,true,false )
             ,new CursorDef("T000H12", "SELECT TOP 1 [ClinicaCodigo], [PacienteId] FROM [Paciente] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo) and [PacienteId] = @PacienteId ORDER BY [ClinicaCodigo], [PacienteId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000H12,1,0,true,true )
             ,new CursorDef("T000H13", "SELECT TOP 1 [ClinicaCodigo], [PacienteId] FROM [Paciente] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo) and [PacienteId] = @PacienteId ORDER BY [ClinicaCodigo] DESC, [PacienteId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000H13,1,0,true,true )
             ,new CursorDef("T000H14", "SELECT [PacienteId], [PacienteNombre1], [PacienteNombre2], [PacienteApellido1], [PacienteApellido2], [PacienteApellido3], [PacienteSexo], [PacienteNacimiento], [PacienteDireccion], [PacienteTelefono1], [PacienteTelefono2], [PacienteCorreo], [PacienteDpi], [PacienteObs], [PacienteEstado], [ClinicaCodigo], [TipoPacCodigo], [ProfesionId], [ReligionId] FROM [Paciente] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [PacienteId] = @PacienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H14,1,0,true,false )
             ,new CursorDef("T000H15", "INSERT INTO [Paciente] ([PacienteId], [PacienteNombre1], [PacienteNombre2], [PacienteApellido1], [PacienteApellido2], [PacienteApellido3], [PacienteSexo], [PacienteNacimiento], [PacienteDireccion], [PacienteTelefono1], [PacienteTelefono2], [PacienteCorreo], [PacienteDpi], [PacienteObs], [PacienteEstado], [ClinicaCodigo], [TipoPacCodigo], [ProfesionId], [ReligionId]) VALUES (@PacienteId, @PacienteNombre1, @PacienteNombre2, @PacienteApellido1, @PacienteApellido2, @PacienteApellido3, @PacienteSexo, @PacienteNacimiento, @PacienteDireccion, @PacienteTelefono1, @PacienteTelefono2, @PacienteCorreo, @PacienteDpi, @PacienteObs, @PacienteEstado, @ClinicaCodigo, @TipoPacCodigo, @ProfesionId, @ReligionId)", GxErrorMask.GX_NOMASK,prmT000H15)
             ,new CursorDef("T000H16", "UPDATE [Paciente] SET [PacienteNombre1]=@PacienteNombre1, [PacienteNombre2]=@PacienteNombre2, [PacienteApellido1]=@PacienteApellido1, [PacienteApellido2]=@PacienteApellido2, [PacienteApellido3]=@PacienteApellido3, [PacienteSexo]=@PacienteSexo, [PacienteNacimiento]=@PacienteNacimiento, [PacienteDireccion]=@PacienteDireccion, [PacienteTelefono1]=@PacienteTelefono1, [PacienteTelefono2]=@PacienteTelefono2, [PacienteCorreo]=@PacienteCorreo, [PacienteDpi]=@PacienteDpi, [PacienteObs]=@PacienteObs, [PacienteEstado]=@PacienteEstado, [TipoPacCodigo]=@TipoPacCodigo, [ProfesionId]=@ProfesionId, [ReligionId]=@ReligionId  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [PacienteId] = @PacienteId", GxErrorMask.GX_NOMASK,prmT000H16)
             ,new CursorDef("T000H17", "DELETE FROM [Paciente]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [PacienteId] = @PacienteId", GxErrorMask.GX_NOMASK,prmT000H17)
             ,new CursorDef("T000H18", "SELECT TOP 1 [ClinicaCodigo], [ExpedienteId] FROM [Expediente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [PacienteId] = @PacienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H18,1,0,true,true )
             ,new CursorDef("T000H19", "SELECT TOP 1 [ClinicaCodigo], [ConsultaId] FROM [Consulta] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [PacienteId] = @PacienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H19,1,0,true,true )
             ,new CursorDef("T000H20", "SELECT [ClinicaCodigo], [PacienteId] FROM [Paciente] WITH (NOLOCK) WHERE [PacienteId] = @PacienteId ORDER BY [ClinicaCodigo], [PacienteId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000H20,100,0,true,false )
             ,new CursorDef("T000H21", "SELECT [ClinicaCodigo], [TipoPacCodigo], [TipoPacDescripcion], [TipoPacEstado] FROM [TipoPaciente] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @ClinicaCodigo) AND ([TipoPacEstado] = 1) ORDER BY [TipoPacDescripcion] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H21,0,0,true,false )
             ,new CursorDef("T000H22", "SELECT [ClinicaCodigo], [ReligionId], [ReligionNombre] FROM [Religion] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ORDER BY [ReligionNombre] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H22,0,0,true,false )
             ,new CursorDef("T000H23", "SELECT [ClinicaCodigo], [ProfesionId], [ProfesionNombre] FROM [Profesion] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ORDER BY [ProfesionNombre] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H23,0,0,true,false )
             ,new CursorDef("T000H24", "SELECT [ClinicaCodigo] FROM [TipoPaciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoPacCodigo] = @TipoPacCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H24,1,0,true,false )
             ,new CursorDef("T000H25", "SELECT [ClinicaCodigo] FROM [Religion] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ReligionId] = @ReligionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H25,1,0,true,false )
             ,new CursorDef("T000H26", "SELECT [ClinicaCodigo] FROM [Profesion] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ProfesionId] = @ProfesionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H26,1,0,true,false )
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
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                ((short[]) buf[14])[0] = rslt.getShort(15) ;
                ((String[]) buf[15])[0] = rslt.getVarchar(16) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(17) ;
                ((int[]) buf[17])[0] = rslt.getInt(18) ;
                ((int[]) buf[18])[0] = rslt.getInt(19) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                ((short[]) buf[14])[0] = rslt.getShort(15) ;
                ((String[]) buf[15])[0] = rslt.getVarchar(16) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(17) ;
                ((int[]) buf[17])[0] = rslt.getInt(18) ;
                ((int[]) buf[18])[0] = rslt.getInt(19) ;
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                ((short[]) buf[14])[0] = rslt.getShort(15) ;
                ((String[]) buf[15])[0] = rslt.getVarchar(16) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(17) ;
                ((int[]) buf[17])[0] = rslt.getInt(18) ;
                ((int[]) buf[18])[0] = rslt.getInt(19) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 12 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                ((short[]) buf[14])[0] = rslt.getShort(15) ;
                ((String[]) buf[15])[0] = rslt.getVarchar(16) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(17) ;
                ((int[]) buf[17])[0] = rslt.getInt(18) ;
                ((int[]) buf[18])[0] = rslt.getInt(19) ;
                break;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
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
                stmt.SetParameter(2, (String)parms[1]);
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
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
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
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 13 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (DateTime)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                stmt.SetParameter(11, (String)parms[10]);
                stmt.SetParameter(12, (String)parms[11]);
                stmt.SetParameter(13, (String)parms[12]);
                stmt.SetParameter(14, (String)parms[13]);
                stmt.SetParameter(15, (short)parms[14]);
                stmt.SetParameter(16, (String)parms[15]);
                stmt.SetParameter(17, (String)parms[16]);
                stmt.SetParameter(18, (int)parms[17]);
                stmt.SetParameter(19, (int)parms[18]);
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (DateTime)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                stmt.SetParameter(11, (String)parms[10]);
                stmt.SetParameter(12, (String)parms[11]);
                stmt.SetParameter(13, (String)parms[12]);
                stmt.SetParameter(14, (short)parms[13]);
                stmt.SetParameter(15, (String)parms[14]);
                stmt.SetParameter(16, (int)parms[15]);
                stmt.SetParameter(17, (int)parms[16]);
                stmt.SetParameter(18, (String)parms[17]);
                stmt.SetParameter(19, (int)parms[18]);
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 18 :
                stmt.SetParameter(1, (int)parms[0]);
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
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 23 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 24 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
       }
    }

 }

}
