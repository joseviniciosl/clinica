/*
               File: Receta
        Description: Recetas de pacientes
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:5:11.17
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
   public class receta : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_3") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A91ConsultaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_3( A41ClinicaCodigo, A91ConsultaId) ;
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
         Form.Meta.addItem("Description", "Recetas de pacientes", 0) ;
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

      public receta( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public receta( IGxContext context )
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
            wb_table1_2_0K27( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0K27e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0K27( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0K27( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0K27e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Recetas de pacientes"+"</legend>") ;
            wb_table3_27_0K27( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0K27e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0K27e( true) ;
         }
         else
         {
            wb_table1_2_0K27e( false) ;
         }
      }

      protected void wb_table3_27_0K27( bool wbgen )
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
            wb_table4_33_0K27( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0K27e( bool wbgen )
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Receta.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Receta.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Receta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0K27e( true) ;
         }
         else
         {
            wb_table3_27_0K27e( false) ;
         }
      }

      protected void wb_table4_33_0K27( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Receta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Receta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockconsultaid_Internalname, "Consulta", "", "", lblTextblockconsultaid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Receta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtConsultaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A91ConsultaId), 9, 0, ".", "")), ((edtConsultaId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A91ConsultaId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A91ConsultaId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(43);\"", "", "", "", "", edtConsultaId_Jsonclick, 0, ClassString, StyleString, "", 1, edtConsultaId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Receta.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_91_Internalname, "prompt.gif", imgprompt_41_91_Link, "", "", "Fantastic", imgprompt_41_91_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Receta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockrecetaid_Internalname, "Receta", "", "", lblTextblockrecetaid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Receta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109RecetaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A109RecetaId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRecetaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A109RecetaId), 9, 0, ".", "")), ((edtRecetaId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A109RecetaId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A109RecetaId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(48);\"", "", "", "", "", edtRecetaId_Jsonclick, 0, ClassString, StyleString, "", 1, edtRecetaId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Receta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockrecetafecha_Internalname, "Fecha", "", "", lblTextblockrecetafecha_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Receta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110RecetaFecha", context.localUtil.Format(A110RecetaFecha, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtRecetaFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtRecetaFecha_Internalname, context.localUtil.Format(A110RecetaFecha, "99/99/99"), context.localUtil.Format( A110RecetaFecha, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(53);\"", "", "", "", "", edtRecetaFecha_Jsonclick, 0, ClassString, StyleString, "", 1, edtRecetaFecha_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_Receta.htm");
            GxWebStd.gx_bitmap( context, edtRecetaFecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtRecetaFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Receta.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockrecetahora_Internalname, "Hora", "", "", lblTextblockrecetahora_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Receta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A111RecetaHora", A111RecetaHora);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRecetaHora_Internalname, StringUtil.RTrim( A111RecetaHora), StringUtil.RTrim( context.localUtil.Format( A111RecetaHora, "XXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", "", "", "", "", edtRecetaHora_Jsonclick, 0, ClassString, StyleString, "", 1, edtRecetaHora_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "left", "HLP_Receta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmedicocodigo_Internalname, "Código", "", "", lblTextblockmedicocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Receta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMedicoCodigo_Internalname, StringUtil.RTrim( A19MedicoCodigo), StringUtil.RTrim( context.localUtil.Format( A19MedicoCodigo, "")), "", "", "", "", "", edtMedicoCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtMedicoCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Receta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockrecetaobs_Internalname, "Receta", "", "", lblTextblockrecetaobs_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Receta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112RecetaObs", A112RecetaObs);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtRecetaObs_Internalname, StringUtil.RTrim( A112RecetaObs), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", 0, 1, edtRecetaObs_Enabled, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_Receta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0K27e( true) ;
         }
         else
         {
            wb_table4_33_0K27e( false) ;
         }
      }

      protected void wb_table2_5_0K27( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Receta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Receta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Receta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Receta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Receta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Receta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Receta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Receta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00r0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CONSULTAID"+"'), id:'"+"CONSULTAID"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"RECETAID"+"'), id:'"+"RECETAID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Receta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00r0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CONSULTAID"+"'), id:'"+"CONSULTAID"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"RECETAID"+"'), id:'"+"RECETAID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Receta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Receta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Receta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Receta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Receta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Receta.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Receta.htm");
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
            wb_table2_5_0K27e( true) ;
         }
         else
         {
            wb_table2_5_0K27e( false) ;
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtRecetaId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtRecetaId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "RECETAID");
                  AnyError = 1 ;
                  GX_FocusControl = edtRecetaId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A109RecetaId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109RecetaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A109RecetaId), 9, 0)));
               }
               else
               {
                  A109RecetaId = (int)(context.localUtil.CToN( cgiGet( edtRecetaId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109RecetaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A109RecetaId), 9, 0)));
               }
               if ( context.localUtil.VCDate( cgiGet( edtRecetaFecha_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, "RECETAFECHA");
                  AnyError = 1 ;
                  GX_FocusControl = edtRecetaFecha_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A110RecetaFecha = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110RecetaFecha", context.localUtil.Format(A110RecetaFecha, "99/99/99"));
               }
               else
               {
                  A110RecetaFecha = context.localUtil.CToD( cgiGet( edtRecetaFecha_Internalname), 2) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110RecetaFecha", context.localUtil.Format(A110RecetaFecha, "99/99/99"));
               }
               A111RecetaHora = cgiGet( edtRecetaHora_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A111RecetaHora", A111RecetaHora);
               A19MedicoCodigo = cgiGet( edtMedicoCodigo_Internalname) ;
               n19MedicoCodigo = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
               A112RecetaObs = cgiGet( edtRecetaObs_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112RecetaObs", A112RecetaObs);
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z91ConsultaId = (int)(context.localUtil.CToN( cgiGet( "Z91ConsultaId"), ".", ",")) ;
               Z109RecetaId = (int)(context.localUtil.CToN( cgiGet( "Z109RecetaId"), ".", ",")) ;
               Z110RecetaFecha = context.localUtil.CToD( cgiGet( "Z110RecetaFecha"), 0) ;
               Z111RecetaHora = cgiGet( "Z111RecetaHora") ;
               Z112RecetaObs = cgiGet( "Z112RecetaObs") ;
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
                  A91ConsultaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
                  A109RecetaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109RecetaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A109RecetaId), 9, 0)));
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
               InitAll0K27( ) ;
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
         DisableAttributes0K27( ) ;
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

      protected void ResetCaption0K0( )
      {
      }

      protected void ZM0K27( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z110RecetaFecha = T000K3_A110RecetaFecha[0] ;
               Z111RecetaHora = T000K3_A111RecetaHora[0] ;
               Z112RecetaObs = T000K3_A112RecetaObs[0] ;
            }
            else
            {
               Z110RecetaFecha = A110RecetaFecha ;
               Z111RecetaHora = A111RecetaHora ;
               Z112RecetaObs = A112RecetaObs ;
            }
         }
         if ( GX_JID == -2 )
         {
            Z109RecetaId = A109RecetaId ;
            Z110RecetaFecha = A110RecetaFecha ;
            Z111RecetaHora = A111RecetaHora ;
            Z112RecetaObs = A112RecetaObs ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z91ConsultaId = A91ConsultaId ;
            Z19MedicoCodigo = A19MedicoCodigo ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_41_91_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00p0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CONSULTAID"+"'), id:'"+"CONSULTAID"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"true"+");") ;
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

      protected void Load0K27( )
      {
         /* Using cursor T000K5 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A91ConsultaId, A109RecetaId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound27 = 1 ;
            A110RecetaFecha = T000K5_A110RecetaFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110RecetaFecha", context.localUtil.Format(A110RecetaFecha, "99/99/99"));
            A111RecetaHora = T000K5_A111RecetaHora[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A111RecetaHora", A111RecetaHora);
            A112RecetaObs = T000K5_A112RecetaObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112RecetaObs", A112RecetaObs);
            A19MedicoCodigo = T000K5_A19MedicoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
            n19MedicoCodigo = T000K5_n19MedicoCodigo[0] ;
            ZM0K27( -2) ;
         }
         pr_default.close(3);
         OnLoadActions0K27( ) ;
      }

      protected void OnLoadActions0K27( )
      {
      }

      protected void CheckExtendedTable0K27( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T000K4 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo, A91ConsultaId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError41 = 1 ;
            AnyError91 = 1 ;
            GX_msglist.addItem("No existe 'Consulta de pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError91 == 0 ) )
         {
            A19MedicoCodigo = T000K4_A19MedicoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
            n19MedicoCodigo = T000K4_n19MedicoCodigo[0] ;
         }
         pr_default.close(2);
         if ( ! ( (DateTime.MinValue==A110RecetaFecha) || ( A110RecetaFecha >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors0K27( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_3( String A41ClinicaCodigo ,
                               int A91ConsultaId )
      {
         /* Using cursor T000K6 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo, A91ConsultaId});
         if ( (pr_default.getStatus(4) == 101) )
         {
            AnyError41 = 1 ;
            AnyError91 = 1 ;
            GX_msglist.addItem("No existe 'Consulta de pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError91 == 0 ) )
         {
            A19MedicoCodigo = T000K6_A19MedicoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
            n19MedicoCodigo = T000K6_n19MedicoCodigo[0] ;
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A19MedicoCodigo))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(4);
      }

      protected void GetKey0K27( )
      {
         /* Using cursor T000K7 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A91ConsultaId, A109RecetaId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound27 = 1 ;
         }
         else
         {
            RcdFound27 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000K3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A91ConsultaId, A109RecetaId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0K27( 2) ;
            RcdFound27 = 1 ;
            A109RecetaId = T000K3_A109RecetaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109RecetaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A109RecetaId), 9, 0)));
            A110RecetaFecha = T000K3_A110RecetaFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110RecetaFecha", context.localUtil.Format(A110RecetaFecha, "99/99/99"));
            A111RecetaHora = T000K3_A111RecetaHora[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A111RecetaHora", A111RecetaHora);
            A112RecetaObs = T000K3_A112RecetaObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112RecetaObs", A112RecetaObs);
            A41ClinicaCodigo = T000K3_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A91ConsultaId = T000K3_A91ConsultaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z91ConsultaId = A91ConsultaId ;
            Z109RecetaId = A109RecetaId ;
            sMode27 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0K27( ) ;
            Gx_mode = sMode27 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound27 = 0 ;
            InitializeNonKey0K27( ) ;
            sMode27 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode27 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0K27( ) ;
         if ( RcdFound27 == 0 )
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
         RcdFound27 = 0 ;
         /* Using cursor T000K8 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, A91ConsultaId, A109RecetaId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T000K8_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000K8_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000K8_A91ConsultaId[0] < A91ConsultaId ) || ( T000K8_A91ConsultaId[0] == A91ConsultaId ) && ( StringUtil.StrCmp(T000K8_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000K8_A109RecetaId[0] < A109RecetaId ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T000K8_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000K8_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000K8_A91ConsultaId[0] > A91ConsultaId ) || ( T000K8_A91ConsultaId[0] == A91ConsultaId ) && ( StringUtil.StrCmp(T000K8_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000K8_A109RecetaId[0] > A109RecetaId ) ) )
            {
               A41ClinicaCodigo = T000K8_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A91ConsultaId = T000K8_A91ConsultaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
               A109RecetaId = T000K8_A109RecetaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109RecetaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A109RecetaId), 9, 0)));
               RcdFound27 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound27 = 0 ;
         /* Using cursor T000K9 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A91ConsultaId, A109RecetaId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T000K9_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000K9_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000K9_A91ConsultaId[0] > A91ConsultaId ) || ( T000K9_A91ConsultaId[0] == A91ConsultaId ) && ( StringUtil.StrCmp(T000K9_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000K9_A109RecetaId[0] > A109RecetaId ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T000K9_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000K9_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000K9_A91ConsultaId[0] < A91ConsultaId ) || ( T000K9_A91ConsultaId[0] == A91ConsultaId ) && ( StringUtil.StrCmp(T000K9_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000K9_A109RecetaId[0] < A109RecetaId ) ) )
            {
               A41ClinicaCodigo = T000K9_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A91ConsultaId = T000K9_A91ConsultaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
               A109RecetaId = T000K9_A109RecetaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109RecetaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A109RecetaId), 9, 0)));
               RcdFound27 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0K27( ) ;
         if ( RcdFound27 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A91ConsultaId != Z91ConsultaId ) || ( A109RecetaId != Z109RecetaId ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A91ConsultaId = Z91ConsultaId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
               A109RecetaId = Z109RecetaId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109RecetaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A109RecetaId), 9, 0)));
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
               Update0K27( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A91ConsultaId != Z91ConsultaId ) || ( A109RecetaId != Z109RecetaId ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert0K27( ) ;
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
                  Insert0K27( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A91ConsultaId != Z91ConsultaId ) || ( A109RecetaId != Z109RecetaId ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A91ConsultaId = Z91ConsultaId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
            A109RecetaId = Z109RecetaId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109RecetaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A109RecetaId), 9, 0)));
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
         if ( RcdFound27 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtRecetaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0K27( ) ;
         if ( RcdFound27 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtRecetaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0K27( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound27 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtRecetaFecha_Internalname ;
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
         if ( RcdFound27 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtRecetaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0K27( ) ;
         if ( RcdFound27 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound27 != 0 )
            {
               ScanNext0K27( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtRecetaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0K27( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0K27( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000K10 */
            pr_default.execute(8, new Object[] {A41ClinicaCodigo, A91ConsultaId, A109RecetaId});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Receta"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(8) == 101) || ( Z110RecetaFecha != T000K10_A110RecetaFecha[0] ) || ( StringUtil.StrCmp(Z111RecetaHora, T000K10_A111RecetaHora[0]) != 0 ) || ( StringUtil.StrCmp(Z112RecetaObs, T000K10_A112RecetaObs[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Receta"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0K27( )
      {
         BeforeValidate0K27( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0K27( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0K27( 0) ;
            CheckOptimisticConcurrency0K27( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0K27( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0K27( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000K11 */
                     pr_default.execute(9, new Object[] {A109RecetaId, A110RecetaFecha, A111RecetaHora, A112RecetaObs, A41ClinicaCodigo, A91ConsultaId});
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
                           ResetCaption0K0( ) ;
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
               Load0K27( ) ;
            }
            EndLevel0K27( ) ;
         }
         CloseExtendedTableCursors0K27( ) ;
      }

      protected void Update0K27( )
      {
         BeforeValidate0K27( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0K27( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0K27( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0K27( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0K27( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000K12 */
                     pr_default.execute(10, new Object[] {A110RecetaFecha, A111RecetaHora, A112RecetaObs, A41ClinicaCodigo, A91ConsultaId, A109RecetaId});
                     pr_default.close(10);
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Receta"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0K27( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                           ResetCaption0K0( ) ;
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
            EndLevel0K27( ) ;
         }
         CloseExtendedTableCursors0K27( ) ;
      }

      protected void DeferredUpdate0K27( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0K27( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0K27( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0K27( ) ;
            AfterConfirm0K27( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0K27( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000K13 */
                  pr_default.execute(11, new Object[] {A41ClinicaCodigo, A91ConsultaId, A109RecetaId});
                  pr_default.close(11);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound27 == 0 )
                        {
                           InitAll0K27( ) ;
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
                        ResetCaption0K0( ) ;
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
         sMode27 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0K27( ) ;
         Gx_mode = sMode27 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0K27( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000K14 */
            pr_default.execute(12, new Object[] {A41ClinicaCodigo, A91ConsultaId});
            A19MedicoCodigo = T000K14_A19MedicoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
            n19MedicoCodigo = T000K14_n19MedicoCodigo[0] ;
            pr_default.close(12);
         }
      }

      protected void EndLevel0K27( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0K27( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(6);
            pr_default.close(12);
            context.CommitDataStores("Receta");
            if ( AnyError == 0 )
            {
               ConfirmValues0K0( ) ;
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
            context.RollbackDataStores("Receta");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0K27( )
      {
         /* Using cursor T000K15 */
         pr_default.execute(13);
         RcdFound27 = 0 ;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound27 = 1 ;
            A41ClinicaCodigo = T000K15_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A91ConsultaId = T000K15_A91ConsultaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
            A109RecetaId = T000K15_A109RecetaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109RecetaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A109RecetaId), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0K27( )
      {
         pr_default.readNext(13);
         RcdFound27 = 0 ;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound27 = 1 ;
            A41ClinicaCodigo = T000K15_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A91ConsultaId = T000K15_A91ConsultaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
            A109RecetaId = T000K15_A109RecetaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109RecetaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A109RecetaId), 9, 0)));
         }
      }

      protected void ScanEnd0K27( )
      {
      }

      protected void AfterConfirm0K27( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0K27( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0K27( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0K27( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0K27( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0K27( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0K27( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtConsultaId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConsultaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConsultaId_Enabled), 5, 0)));
         edtRecetaId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRecetaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRecetaId_Enabled), 5, 0)));
         edtRecetaFecha_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRecetaFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRecetaFecha_Enabled), 5, 0)));
         edtRecetaHora_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRecetaHora_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRecetaHora_Enabled), 5, 0)));
         edtMedicoCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMedicoCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMedicoCodigo_Enabled), 5, 0)));
         edtRecetaObs_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRecetaObs_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRecetaObs_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0K0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("receta.aspx") +"\" class=\""+"Form"+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z109RecetaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z109RecetaId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z110RecetaFecha", context.localUtil.DToC( Z110RecetaFecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z111RecetaHora", StringUtil.RTrim( Z111RecetaHora));
         GxWebStd.gx_hidden_field( context, "Z112RecetaObs", StringUtil.RTrim( Z112RecetaObs));
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
         return "Receta" ;
      }

      public override String GetPgmdesc( )
      {
         return "Recetas de pacientes" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("receta.aspx")  ;
      }

      protected void InitializeNonKey0K27( )
      {
         A110RecetaFecha = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110RecetaFecha", context.localUtil.Format(A110RecetaFecha, "99/99/99"));
         A111RecetaHora = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A111RecetaHora", A111RecetaHora);
         A19MedicoCodigo = "" ;
         n19MedicoCodigo = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
         A112RecetaObs = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112RecetaObs", A112RecetaObs);
      }

      protected void InitAll0K27( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A91ConsultaId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
         A109RecetaId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109RecetaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A109RecetaId), 9, 0)));
         InitializeNonKey0K27( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1551279");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("receta.js", "?1551279");
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
         lblTextblockconsultaid_Internalname = "TEXTBLOCKCONSULTAID" ;
         edtConsultaId_Internalname = "CONSULTAID" ;
         lblTextblockrecetaid_Internalname = "TEXTBLOCKRECETAID" ;
         edtRecetaId_Internalname = "RECETAID" ;
         lblTextblockrecetafecha_Internalname = "TEXTBLOCKRECETAFECHA" ;
         edtRecetaFecha_Internalname = "RECETAFECHA" ;
         lblTextblockrecetahora_Internalname = "TEXTBLOCKRECETAHORA" ;
         edtRecetaHora_Internalname = "RECETAHORA" ;
         lblTextblockmedicocodigo_Internalname = "TEXTBLOCKMEDICOCODIGO" ;
         edtMedicoCodigo_Internalname = "MEDICOCODIGO" ;
         lblTextblockrecetaobs_Internalname = "TEXTBLOCKRECETAOBS" ;
         edtRecetaObs_Internalname = "RECETAOBS" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_91_Internalname = "PROMPT_41_91" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Recetas de pacientes" ;
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
         edtRecetaObs_Enabled = 1 ;
         edtMedicoCodigo_Jsonclick = "" ;
         edtMedicoCodigo_Enabled = 0 ;
         edtRecetaHora_Jsonclick = "" ;
         edtRecetaHora_Enabled = 1 ;
         edtRecetaFecha_Jsonclick = "" ;
         edtRecetaFecha_Enabled = 1 ;
         edtRecetaId_Jsonclick = "" ;
         edtRecetaId_Enabled = 1 ;
         imgprompt_41_91_Visible = 1 ;
         imgprompt_41_91_Link = "" ;
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

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         /* Using cursor T000K14 */
         pr_default.execute(12, new Object[] {A41ClinicaCodigo, A91ConsultaId});
         if ( (pr_default.getStatus(12) == 101) )
         {
            AnyError41 = 1 ;
            AnyError91 = 1 ;
            GX_msglist.addItem("No existe 'Consulta de pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError91 == 0 ) )
         {
            A19MedicoCodigo = T000K14_A19MedicoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
            n19MedicoCodigo = T000K14_n19MedicoCodigo[0] ;
         }
         pr_default.close(12);
         GX_FocusControl = edtRecetaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Consultaid( String GX_Parm1 ,
                                    int GX_Parm2 ,
                                    String GX_Parm3 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A91ConsultaId = GX_Parm2 ;
         A19MedicoCodigo = GX_Parm3 ;
         n19MedicoCodigo = false ;
         /* Using cursor T000K14 */
         pr_default.execute(12, new Object[] {A41ClinicaCodigo, A91ConsultaId});
         if ( (pr_default.getStatus(12) == 101) )
         {
            AnyError41 = 1 ;
            AnyError91 = 1 ;
            GX_msglist.addItem("No existe 'Consulta de pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError91 == 0 ) )
         {
            A19MedicoCodigo = T000K14_A19MedicoCodigo[0] ;
            n19MedicoCodigo = T000K14_n19MedicoCodigo[0] ;
         }
         pr_default.close(12);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A19MedicoCodigo = "" ;
            n19MedicoCodigo = false ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A19MedicoCodigo)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Recetaid( String GX_Parm1 ,
                                  int GX_Parm2 ,
                                  int GX_Parm3 ,
                                  DateTime GX_Parm4 ,
                                  String GX_Parm5 ,
                                  String GX_Parm6 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A91ConsultaId = GX_Parm2 ;
         A109RecetaId = GX_Parm3 ;
         A110RecetaFecha = GX_Parm4 ;
         A111RecetaHora = GX_Parm5 ;
         A112RecetaObs = GX_Parm6 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A19MedicoCodigo = "" ;
            n19MedicoCodigo = false ;
         }
         isValidOutput.Add((Object)(context.localUtil.Format(A110RecetaFecha, "99/99/99")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A111RecetaHora)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A112RecetaObs)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A19MedicoCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z91ConsultaId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z109RecetaId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z110RecetaFecha, 0, "/")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z111RecetaHora)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z112RecetaObs)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z19MedicoCodigo)));
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
         pr_default.close(13);
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
         lblTextblockconsultaid_Jsonclick = "" ;
         lblTextblockrecetaid_Jsonclick = "" ;
         lblTextblockrecetafecha_Jsonclick = "" ;
         A110RecetaFecha = DateTime.MinValue ;
         lblTextblockrecetahora_Jsonclick = "" ;
         A111RecetaHora = "" ;
         lblTextblockmedicocodigo_Jsonclick = "" ;
         A19MedicoCodigo = "" ;
         lblTextblockrecetaobs_Jsonclick = "" ;
         A112RecetaObs = "" ;
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
         Z110RecetaFecha = DateTime.MinValue ;
         Z111RecetaHora = "" ;
         Z112RecetaObs = "" ;
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         Z19MedicoCodigo = "" ;
         T000K5_A109RecetaId = new int[1] ;
         T000K5_A110RecetaFecha = new DateTime[] {DateTime.MinValue} ;
         T000K5_A111RecetaHora = new String[] {""} ;
         T000K5_A112RecetaObs = new String[] {""} ;
         T000K5_A41ClinicaCodigo = new String[] {""} ;
         T000K5_A91ConsultaId = new int[1] ;
         T000K5_A19MedicoCodigo = new String[] {""} ;
         T000K5_n19MedicoCodigo = new bool[] {false} ;
         T000K4_A19MedicoCodigo = new String[] {""} ;
         T000K4_n19MedicoCodigo = new bool[] {false} ;
         T000K6_A19MedicoCodigo = new String[] {""} ;
         T000K6_n19MedicoCodigo = new bool[] {false} ;
         T000K7_A41ClinicaCodigo = new String[] {""} ;
         T000K7_A91ConsultaId = new int[1] ;
         T000K7_A109RecetaId = new int[1] ;
         T000K3_A109RecetaId = new int[1] ;
         T000K3_A110RecetaFecha = new DateTime[] {DateTime.MinValue} ;
         T000K3_A111RecetaHora = new String[] {""} ;
         T000K3_A112RecetaObs = new String[] {""} ;
         T000K3_A41ClinicaCodigo = new String[] {""} ;
         T000K3_A91ConsultaId = new int[1] ;
         sMode27 = "" ;
         T000K8_A41ClinicaCodigo = new String[] {""} ;
         T000K8_A91ConsultaId = new int[1] ;
         T000K8_A109RecetaId = new int[1] ;
         T000K9_A41ClinicaCodigo = new String[] {""} ;
         T000K9_A91ConsultaId = new int[1] ;
         T000K9_A109RecetaId = new int[1] ;
         T000K10_A109RecetaId = new int[1] ;
         T000K10_A110RecetaFecha = new DateTime[] {DateTime.MinValue} ;
         T000K10_A111RecetaHora = new String[] {""} ;
         T000K10_A112RecetaObs = new String[] {""} ;
         T000K10_A41ClinicaCodigo = new String[] {""} ;
         T000K10_A91ConsultaId = new int[1] ;
         T000K14_A19MedicoCodigo = new String[] {""} ;
         T000K14_n19MedicoCodigo = new bool[] {false} ;
         T000K15_A41ClinicaCodigo = new String[] {""} ;
         T000K15_A91ConsultaId = new int[1] ;
         T000K15_A109RecetaId = new int[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.receta__default(),
            new Object[][] {
                new Object[] {
               T000K2_A109RecetaId, T000K2_A110RecetaFecha, T000K2_A111RecetaHora, T000K2_A112RecetaObs, T000K2_A41ClinicaCodigo, T000K2_A91ConsultaId
               }
               , new Object[] {
               T000K3_A109RecetaId, T000K3_A110RecetaFecha, T000K3_A111RecetaHora, T000K3_A112RecetaObs, T000K3_A41ClinicaCodigo, T000K3_A91ConsultaId
               }
               , new Object[] {
               T000K4_A19MedicoCodigo, T000K4_n19MedicoCodigo
               }
               , new Object[] {
               T000K5_A109RecetaId, T000K5_A110RecetaFecha, T000K5_A111RecetaHora, T000K5_A112RecetaObs, T000K5_A41ClinicaCodigo, T000K5_A91ConsultaId, T000K5_A19MedicoCodigo, T000K5_n19MedicoCodigo
               }
               , new Object[] {
               T000K6_A19MedicoCodigo, T000K6_n19MedicoCodigo
               }
               , new Object[] {
               T000K7_A41ClinicaCodigo, T000K7_A91ConsultaId, T000K7_A109RecetaId
               }
               , new Object[] {
               T000K8_A41ClinicaCodigo, T000K8_A91ConsultaId, T000K8_A109RecetaId
               }
               , new Object[] {
               T000K9_A41ClinicaCodigo, T000K9_A91ConsultaId, T000K9_A109RecetaId
               }
               , new Object[] {
               T000K10_A109RecetaId, T000K10_A110RecetaFecha, T000K10_A111RecetaHora, T000K10_A112RecetaObs, T000K10_A41ClinicaCodigo, T000K10_A91ConsultaId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000K14_A19MedicoCodigo, T000K14_n19MedicoCodigo
               }
               , new Object[] {
               T000K15_A41ClinicaCodigo, T000K15_A91ConsultaId, T000K15_A109RecetaId
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
      private short GX_JID ;
      private short RcdFound27 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int A91ConsultaId ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int edtConsultaId_Enabled ;
      private int imgprompt_41_91_Visible ;
      private int A109RecetaId ;
      private int edtRecetaId_Enabled ;
      private int edtRecetaFecha_Enabled ;
      private int edtRecetaHora_Enabled ;
      private int edtMedicoCodigo_Enabled ;
      private int edtRecetaObs_Enabled ;
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
      private int Z109RecetaId ;
      private int AnyError41 ;
      private int AnyError91 ;
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
      private String lblTextblockconsultaid_Internalname ;
      private String lblTextblockconsultaid_Jsonclick ;
      private String edtConsultaId_Internalname ;
      private String edtConsultaId_Jsonclick ;
      private String imgprompt_41_91_Internalname ;
      private String imgprompt_41_91_Link ;
      private String lblTextblockrecetaid_Internalname ;
      private String lblTextblockrecetaid_Jsonclick ;
      private String edtRecetaId_Internalname ;
      private String edtRecetaId_Jsonclick ;
      private String lblTextblockrecetafecha_Internalname ;
      private String lblTextblockrecetafecha_Jsonclick ;
      private String edtRecetaFecha_Internalname ;
      private String edtRecetaFecha_Jsonclick ;
      private String lblTextblockrecetahora_Internalname ;
      private String lblTextblockrecetahora_Jsonclick ;
      private String A111RecetaHora ;
      private String edtRecetaHora_Internalname ;
      private String edtRecetaHora_Jsonclick ;
      private String lblTextblockmedicocodigo_Internalname ;
      private String lblTextblockmedicocodigo_Jsonclick ;
      private String edtMedicoCodigo_Internalname ;
      private String edtMedicoCodigo_Jsonclick ;
      private String lblTextblockrecetaobs_Internalname ;
      private String lblTextblockrecetaobs_Jsonclick ;
      private String edtRecetaObs_Internalname ;
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
      private String Z111RecetaHora ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode27 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private DateTime A110RecetaFecha ;
      private DateTime Z110RecetaFecha ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n19MedicoCodigo ;
      private String A41ClinicaCodigo ;
      private String A19MedicoCodigo ;
      private String A112RecetaObs ;
      private String Z41ClinicaCodigo ;
      private String Z112RecetaObs ;
      private String Z19MedicoCodigo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T000K5_A109RecetaId ;
      private DateTime[] T000K5_A110RecetaFecha ;
      private String[] T000K5_A111RecetaHora ;
      private String[] T000K5_A112RecetaObs ;
      private String[] T000K5_A41ClinicaCodigo ;
      private int[] T000K5_A91ConsultaId ;
      private String[] T000K5_A19MedicoCodigo ;
      private bool[] T000K5_n19MedicoCodigo ;
      private String[] T000K4_A19MedicoCodigo ;
      private bool[] T000K4_n19MedicoCodigo ;
      private String[] T000K6_A19MedicoCodigo ;
      private bool[] T000K6_n19MedicoCodigo ;
      private String[] T000K7_A41ClinicaCodigo ;
      private int[] T000K7_A91ConsultaId ;
      private int[] T000K7_A109RecetaId ;
      private int[] T000K3_A109RecetaId ;
      private DateTime[] T000K3_A110RecetaFecha ;
      private String[] T000K3_A111RecetaHora ;
      private String[] T000K3_A112RecetaObs ;
      private String[] T000K3_A41ClinicaCodigo ;
      private int[] T000K3_A91ConsultaId ;
      private String[] T000K8_A41ClinicaCodigo ;
      private int[] T000K8_A91ConsultaId ;
      private int[] T000K8_A109RecetaId ;
      private String[] T000K9_A41ClinicaCodigo ;
      private int[] T000K9_A91ConsultaId ;
      private int[] T000K9_A109RecetaId ;
      private int[] T000K10_A109RecetaId ;
      private DateTime[] T000K10_A110RecetaFecha ;
      private String[] T000K10_A111RecetaHora ;
      private String[] T000K10_A112RecetaObs ;
      private String[] T000K10_A41ClinicaCodigo ;
      private int[] T000K10_A91ConsultaId ;
      private String[] T000K14_A19MedicoCodigo ;
      private bool[] T000K14_n19MedicoCodigo ;
      private String[] T000K15_A41ClinicaCodigo ;
      private int[] T000K15_A91ConsultaId ;
      private int[] T000K15_A109RecetaId ;
      private int[] T000K2_A109RecetaId ;
      private DateTime[] T000K2_A110RecetaFecha ;
      private String[] T000K2_A111RecetaHora ;
      private String[] T000K2_A112RecetaObs ;
      private String[] T000K2_A41ClinicaCodigo ;
      private int[] T000K2_A91ConsultaId ;
      private GXWebForm Form ;
   }

   public class receta__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000K2 ;
          prmT000K2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@RecetaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000K5 ;
          prmT000K5 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@RecetaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000K4 ;
          prmT000K4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000K6 ;
          prmT000K6 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000K7 ;
          prmT000K7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@RecetaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000K3 ;
          prmT000K3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@RecetaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000K8 ;
          prmT000K8 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@RecetaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000K9 ;
          prmT000K9 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@RecetaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000K10 ;
          prmT000K10 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@RecetaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000K11 ;
          prmT000K11 = new Object[] {
          new Object[] {"@RecetaId",SqlDbType.Int,9,0} ,
          new Object[] {"@RecetaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@RecetaHora",SqlDbType.Char,8,0} ,
          new Object[] {"@RecetaObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000K12 ;
          prmT000K12 = new Object[] {
          new Object[] {"@RecetaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@RecetaHora",SqlDbType.Char,8,0} ,
          new Object[] {"@RecetaObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@RecetaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000K13 ;
          prmT000K13 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@RecetaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000K15 ;
          prmT000K15 = new Object[] {
          } ;
          Object[] prmT000K14 ;
          prmT000K14 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000K2", "SELECT [RecetaId], [RecetaFecha], [RecetaHora], [RecetaObs], [ClinicaCodigo], [ConsultaId] FROM [Receta] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId AND [RecetaId] = @RecetaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K2,1,0,true,false )
             ,new CursorDef("T000K3", "SELECT [RecetaId], [RecetaFecha], [RecetaHora], [RecetaObs], [ClinicaCodigo], [ConsultaId] FROM [Receta] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId AND [RecetaId] = @RecetaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K3,1,0,true,false )
             ,new CursorDef("T000K4", "SELECT [MedicoCodigo] FROM [Consulta] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K4,1,0,true,false )
             ,new CursorDef("T000K5", "SELECT TM1.[RecetaId], TM1.[RecetaFecha], TM1.[RecetaHora], TM1.[RecetaObs], TM1.[ClinicaCodigo], TM1.[ConsultaId], T2.[MedicoCodigo] FROM ([Receta] TM1 WITH (NOLOCK) INNER JOIN [Consulta] T2 WITH (NOLOCK) ON T2.[ClinicaCodigo] = TM1.[ClinicaCodigo] AND T2.[ConsultaId] = TM1.[ConsultaId]) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[ConsultaId] = @ConsultaId and TM1.[RecetaId] = @RecetaId ORDER BY TM1.[ClinicaCodigo], TM1.[ConsultaId], TM1.[RecetaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000K5,100,0,true,false )
             ,new CursorDef("T000K6", "SELECT [MedicoCodigo] FROM [Consulta] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K6,1,0,true,false )
             ,new CursorDef("T000K7", "SELECT [ClinicaCodigo], [ConsultaId], [RecetaId] FROM [Receta] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId AND [RecetaId] = @RecetaId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000K7,1,0,true,false )
             ,new CursorDef("T000K8", "SELECT TOP 1 [ClinicaCodigo], [ConsultaId], [RecetaId] FROM [Receta] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [ConsultaId] > @ConsultaId or [ConsultaId] = @ConsultaId and [ClinicaCodigo] = @ClinicaCodigo and [RecetaId] > @RecetaId) ORDER BY [ClinicaCodigo], [ConsultaId], [RecetaId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000K8,1,0,true,true )
             ,new CursorDef("T000K9", "SELECT TOP 1 [ClinicaCodigo], [ConsultaId], [RecetaId] FROM [Receta] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [ConsultaId] < @ConsultaId or [ConsultaId] = @ConsultaId and [ClinicaCodigo] = @ClinicaCodigo and [RecetaId] < @RecetaId) ORDER BY [ClinicaCodigo] DESC, [ConsultaId] DESC, [RecetaId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000K9,1,0,true,true )
             ,new CursorDef("T000K10", "SELECT [RecetaId], [RecetaFecha], [RecetaHora], [RecetaObs], [ClinicaCodigo], [ConsultaId] FROM [Receta] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId AND [RecetaId] = @RecetaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K10,1,0,true,false )
             ,new CursorDef("T000K11", "INSERT INTO [Receta] ([RecetaId], [RecetaFecha], [RecetaHora], [RecetaObs], [ClinicaCodigo], [ConsultaId]) VALUES (@RecetaId, @RecetaFecha, @RecetaHora, @RecetaObs, @ClinicaCodigo, @ConsultaId)", GxErrorMask.GX_NOMASK,prmT000K11)
             ,new CursorDef("T000K12", "UPDATE [Receta] SET [RecetaFecha]=@RecetaFecha, [RecetaHora]=@RecetaHora, [RecetaObs]=@RecetaObs  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId AND [RecetaId] = @RecetaId", GxErrorMask.GX_NOMASK,prmT000K12)
             ,new CursorDef("T000K13", "DELETE FROM [Receta]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId AND [RecetaId] = @RecetaId", GxErrorMask.GX_NOMASK,prmT000K13)
             ,new CursorDef("T000K14", "SELECT [MedicoCodigo] FROM [Consulta] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K14,1,0,true,false )
             ,new CursorDef("T000K15", "SELECT [ClinicaCodigo], [ConsultaId], [RecetaId] FROM [Receta] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [ConsultaId], [RecetaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000K15,100,0,true,false )
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 8 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
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
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                break;
             case 10 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
       }
    }

 }

}
