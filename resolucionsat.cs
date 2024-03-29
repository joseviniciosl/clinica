/*
               File: ResolucionSAT
        Description: Resoluciones de Facturas SAT
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:6:37.78
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
   public class resolucionsat : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_7") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_7( A41ClinicaCodigo) ;
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
         Form.Meta.addItem("Description", "Resoluciones de Facturas SAT", 0) ;
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

      public resolucionsat( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public resolucionsat( IGxContext context )
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
            wb_table1_2_1C61( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1C61e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1C61( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1C61( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1C61e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Resoluciones de Facturas SAT"+"</legend>") ;
            wb_table3_27_1C61( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_1C61e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1C61e( true) ;
         }
         else
         {
            wb_table1_2_1C61e( false) ;
         }
      }

      protected void wb_table3_27_1C61( bool wbgen )
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
            wb_table4_33_1C61( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_1C61e( bool wbgen )
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_ResolucionSAT.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_ResolucionSAT.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_ResolucionSAT.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_1C61e( true) ;
         }
         else
         {
            wb_table3_27_1C61e( false) ;
         }
      }

      protected void wb_table4_33_1C61( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "C�digo", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", lblTextblockclinicacodigo_Visible, 1, 0, "HLP_ResolucionSAT.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", edtClinicaCodigo_Visible, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_ResolucionSAT.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_Internalname, "prompt.gif", imgprompt_41_Link, "", "", "Fantastic", imgprompt_41_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_ResolucionSAT.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockresolucioncodigo_Internalname, "Resoluci�n", "", "", lblTextblockresolucioncodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_ResolucionSAT.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A252ResolucionCodigo", A252ResolucionCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtResolucionCodigo_Internalname, StringUtil.RTrim( A252ResolucionCodigo), StringUtil.RTrim( context.localUtil.Format( A252ResolucionCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtResolucionCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtResolucionCodigo_Enabled, 0, 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, true, "left", "HLP_ResolucionSAT.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockresolucionfecha_Internalname, "Fecha", "", "", lblTextblockresolucionfecha_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_ResolucionSAT.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A253ResolucionFecha", context.localUtil.Format(A253ResolucionFecha, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtResolucionFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtResolucionFecha_Internalname, context.localUtil.Format(A253ResolucionFecha, "99/99/99"), context.localUtil.Format( A253ResolucionFecha, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(48);\"", "", "", "", "", edtResolucionFecha_Jsonclick, 0, ClassString, StyleString, "", 1, edtResolucionFecha_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_ResolucionSAT.htm");
            GxWebStd.gx_bitmap( context, edtResolucionFecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtResolucionFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_ResolucionSAT.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockresolucionvencimiento_Internalname, "Vencimiento", "", "", lblTextblockresolucionvencimiento_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_ResolucionSAT.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A254ResolucionVencimiento", context.localUtil.Format(A254ResolucionVencimiento, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtResolucionVencimiento_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtResolucionVencimiento_Internalname, context.localUtil.Format(A254ResolucionVencimiento, "99/99/99"), context.localUtil.Format( A254ResolucionVencimiento, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(53);\"", "", "", "", "", edtResolucionVencimiento_Jsonclick, 0, ClassString, StyleString, "", 1, edtResolucionVencimiento_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_ResolucionSAT.htm");
            GxWebStd.gx_bitmap( context, edtResolucionVencimiento_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtResolucionVencimiento_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_ResolucionSAT.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockresolucionserie_Internalname, "Serie", "", "", lblTextblockresolucionserie_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_ResolucionSAT.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A255ResolucionSerie", A255ResolucionSerie);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtResolucionSerie_Internalname, StringUtil.RTrim( A255ResolucionSerie), StringUtil.RTrim( context.localUtil.Format( A255ResolucionSerie, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", "", "", "", "", edtResolucionSerie_Jsonclick, 0, ClassString, StyleString, "", 1, edtResolucionSerie_Enabled, 0, 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, true, "left", "HLP_ResolucionSAT.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockresolucioninicial_Internalname, "Inicial", "", "", lblTextblockresolucioninicial_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_ResolucionSAT.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A256ResolucionInicial", StringUtil.LTrim( StringUtil.Str( (decimal)(A256ResolucionInicial), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtResolucionInicial_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A256ResolucionInicial), 9, 0, ".", "")), ((edtResolucionInicial_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A256ResolucionInicial), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A256ResolucionInicial), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(63);\"", "", "", "", "", edtResolucionInicial_Jsonclick, 0, ClassString, StyleString, "", 1, edtResolucionInicial_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_ResolucionSAT.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockresolucionfinal_Internalname, "Final", "", "", lblTextblockresolucionfinal_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_ResolucionSAT.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A257ResolucionFinal", StringUtil.LTrim( StringUtil.Str( (decimal)(A257ResolucionFinal), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtResolucionFinal_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A257ResolucionFinal), 9, 0, ".", "")), ((edtResolucionFinal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A257ResolucionFinal), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A257ResolucionFinal), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(68);\"", "", "", "", "", edtResolucionFinal_Jsonclick, 0, ClassString, StyleString, "", 1, edtResolucionFinal_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_ResolucionSAT.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockresolucionsiguiente_Internalname, "Siguiente", "", "", lblTextblockresolucionsiguiente_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_ResolucionSAT.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A258ResolucionSiguiente", StringUtil.LTrim( StringUtil.Str( (decimal)(A258ResolucionSiguiente), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtResolucionSiguiente_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A258ResolucionSiguiente), 9, 0, ".", "")), ((edtResolucionSiguiente_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A258ResolucionSiguiente), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A258ResolucionSiguiente), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(73);\"", "", "", "", "", edtResolucionSiguiente_Jsonclick, 0, ClassString, StyleString, "", 1, edtResolucionSiguiente_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_ResolucionSAT.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_1C61e( true) ;
         }
         else
         {
            wb_table4_33_1C61e( false) ;
         }
      }

      protected void wb_table2_5_1C61( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_ResolucionSAT.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_ResolucionSAT.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_ResolucionSAT.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_ResolucionSAT.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_ResolucionSAT.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_ResolucionSAT.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_ResolucionSAT.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_ResolucionSAT.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01p0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"RESOLUCIONCODIGO"+"'), id:'"+"RESOLUCIONCODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_ResolucionSAT.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01p0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"RESOLUCIONCODIGO"+"'), id:'"+"RESOLUCIONCODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_ResolucionSAT.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_ResolucionSAT.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_ResolucionSAT.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_ResolucionSAT.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_ResolucionSAT.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_ResolucionSAT.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_ResolucionSAT.htm");
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
            wb_table2_5_1C61e( true) ;
         }
         else
         {
            wb_table2_5_1C61e( false) ;
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
         /* Execute user event: E111C2 */
         E111C2 ();
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
               A252ResolucionCodigo = cgiGet( edtResolucionCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A252ResolucionCodigo", A252ResolucionCodigo);
               if ( context.localUtil.VCDate( cgiGet( edtResolucionFecha_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, "RESOLUCIONFECHA");
                  AnyError = 1 ;
                  GX_FocusControl = edtResolucionFecha_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A253ResolucionFecha = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A253ResolucionFecha", context.localUtil.Format(A253ResolucionFecha, "99/99/99"));
               }
               else
               {
                  A253ResolucionFecha = context.localUtil.CToD( cgiGet( edtResolucionFecha_Internalname), 2) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A253ResolucionFecha", context.localUtil.Format(A253ResolucionFecha, "99/99/99"));
               }
               if ( context.localUtil.VCDate( cgiGet( edtResolucionVencimiento_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Vencimiento"}), 1, "RESOLUCIONVENCIMIENTO");
                  AnyError = 1 ;
                  GX_FocusControl = edtResolucionVencimiento_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A254ResolucionVencimiento = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A254ResolucionVencimiento", context.localUtil.Format(A254ResolucionVencimiento, "99/99/99"));
               }
               else
               {
                  A254ResolucionVencimiento = context.localUtil.CToD( cgiGet( edtResolucionVencimiento_Internalname), 2) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A254ResolucionVencimiento", context.localUtil.Format(A254ResolucionVencimiento, "99/99/99"));
               }
               A255ResolucionSerie = cgiGet( edtResolucionSerie_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A255ResolucionSerie", A255ResolucionSerie);
               if ( ( ( context.localUtil.CToN( cgiGet( edtResolucionInicial_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtResolucionInicial_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "RESOLUCIONINICIAL");
                  AnyError = 1 ;
                  GX_FocusControl = edtResolucionInicial_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A256ResolucionInicial = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A256ResolucionInicial", StringUtil.LTrim( StringUtil.Str( (decimal)(A256ResolucionInicial), 9, 0)));
               }
               else
               {
                  A256ResolucionInicial = (int)(context.localUtil.CToN( cgiGet( edtResolucionInicial_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A256ResolucionInicial", StringUtil.LTrim( StringUtil.Str( (decimal)(A256ResolucionInicial), 9, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtResolucionFinal_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtResolucionFinal_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "RESOLUCIONFINAL");
                  AnyError = 1 ;
                  GX_FocusControl = edtResolucionFinal_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A257ResolucionFinal = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A257ResolucionFinal", StringUtil.LTrim( StringUtil.Str( (decimal)(A257ResolucionFinal), 9, 0)));
               }
               else
               {
                  A257ResolucionFinal = (int)(context.localUtil.CToN( cgiGet( edtResolucionFinal_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A257ResolucionFinal", StringUtil.LTrim( StringUtil.Str( (decimal)(A257ResolucionFinal), 9, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtResolucionSiguiente_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtResolucionSiguiente_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "RESOLUCIONSIGUIENTE");
                  AnyError = 1 ;
                  GX_FocusControl = edtResolucionSiguiente_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A258ResolucionSiguiente = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A258ResolucionSiguiente", StringUtil.LTrim( StringUtil.Str( (decimal)(A258ResolucionSiguiente), 9, 0)));
               }
               else
               {
                  A258ResolucionSiguiente = (int)(context.localUtil.CToN( cgiGet( edtResolucionSiguiente_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A258ResolucionSiguiente", StringUtil.LTrim( StringUtil.Str( (decimal)(A258ResolucionSiguiente), 9, 0)));
               }
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z252ResolucionCodigo = cgiGet( "Z252ResolucionCodigo") ;
               Z253ResolucionFecha = context.localUtil.CToD( cgiGet( "Z253ResolucionFecha"), 0) ;
               Z254ResolucionVencimiento = context.localUtil.CToD( cgiGet( "Z254ResolucionVencimiento"), 0) ;
               Z255ResolucionSerie = cgiGet( "Z255ResolucionSerie") ;
               Z256ResolucionInicial = (int)(context.localUtil.CToN( cgiGet( "Z256ResolucionInicial"), ".", ",")) ;
               Z257ResolucionFinal = (int)(context.localUtil.CToN( cgiGet( "Z257ResolucionFinal"), ".", ",")) ;
               Z258ResolucionSiguiente = (int)(context.localUtil.CToN( cgiGet( "Z258ResolucionSiguiente"), ".", ",")) ;
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
                  A252ResolucionCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A252ResolucionCodigo", A252ResolucionCodigo);
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
                           /* Execute user event: E111C2 */
                           E111C2 ();
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
               InitAll1C61( ) ;
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
         DisableAttributes1C61( ) ;
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

      protected void ResetCaption1C0( )
      {
      }

      protected void E111C2( )
      {
         /* Start Routine */
         GXt_SdtParametros4 = AV7Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros4) ;
         AV7Parametros = GXt_SdtParametros4 ;
         AV8ClinicaCodigo = AV7Parametros.gxTpr_Pclinicacodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClinicaCodigo", AV8ClinicaCodigo);
      }

      protected void ZM1C61( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z253ResolucionFecha = T001C3_A253ResolucionFecha[0] ;
               Z254ResolucionVencimiento = T001C3_A254ResolucionVencimiento[0] ;
               Z255ResolucionSerie = T001C3_A255ResolucionSerie[0] ;
               Z256ResolucionInicial = T001C3_A256ResolucionInicial[0] ;
               Z257ResolucionFinal = T001C3_A257ResolucionFinal[0] ;
               Z258ResolucionSiguiente = T001C3_A258ResolucionSiguiente[0] ;
            }
            else
            {
               Z253ResolucionFecha = A253ResolucionFecha ;
               Z254ResolucionVencimiento = A254ResolucionVencimiento ;
               Z255ResolucionSerie = A255ResolucionSerie ;
               Z256ResolucionInicial = A256ResolucionInicial ;
               Z257ResolucionFinal = A257ResolucionFinal ;
               Z258ResolucionSiguiente = A258ResolucionSiguiente ;
            }
         }
         if ( GX_JID == -6 )
         {
            Z252ResolucionCodigo = A252ResolucionCodigo ;
            Z253ResolucionFecha = A253ResolucionFecha ;
            Z254ResolucionVencimiento = A254ResolucionVencimiento ;
            Z255ResolucionSerie = A255ResolucionSerie ;
            Z256ResolucionInicial = A256ResolucionInicial ;
            Z257ResolucionFinal = A257ResolucionFinal ;
            Z258ResolucionSiguiente = A258ResolucionSiguiente ;
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

      protected void Load1C61( )
      {
         /* Using cursor T001C5 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A252ResolucionCodigo});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound61 = 1 ;
            A253ResolucionFecha = T001C5_A253ResolucionFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A253ResolucionFecha", context.localUtil.Format(A253ResolucionFecha, "99/99/99"));
            A254ResolucionVencimiento = T001C5_A254ResolucionVencimiento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A254ResolucionVencimiento", context.localUtil.Format(A254ResolucionVencimiento, "99/99/99"));
            A255ResolucionSerie = T001C5_A255ResolucionSerie[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A255ResolucionSerie", A255ResolucionSerie);
            A256ResolucionInicial = T001C5_A256ResolucionInicial[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A256ResolucionInicial", StringUtil.LTrim( StringUtil.Str( (decimal)(A256ResolucionInicial), 9, 0)));
            A257ResolucionFinal = T001C5_A257ResolucionFinal[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A257ResolucionFinal", StringUtil.LTrim( StringUtil.Str( (decimal)(A257ResolucionFinal), 9, 0)));
            A258ResolucionSiguiente = T001C5_A258ResolucionSiguiente[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A258ResolucionSiguiente", StringUtil.LTrim( StringUtil.Str( (decimal)(A258ResolucionSiguiente), 9, 0)));
            ZM1C61( -6) ;
         }
         pr_default.close(3);
         OnLoadActions1C61( ) ;
      }

      protected void OnLoadActions1C61( )
      {
      }

      protected void CheckExtendedTable1C61( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T001C4 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError41 = 1 ;
            GX_msglist.addItem("No existe 'Cl�nica M�dica'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError41 == 0 )
         {
         }
         pr_default.close(2);
         if ( ! ( (DateTime.MinValue==A253ResolucionFecha) || ( A253ResolucionFecha >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A254ResolucionVencimiento) || ( A254ResolucionVencimiento >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Vencimiento fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors1C61( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_7( String A41ClinicaCodigo )
      {
         /* Using cursor T001C6 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(4) == 101) )
         {
            AnyError41 = 1 ;
            GX_msglist.addItem("No existe 'Cl�nica M�dica'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
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

      protected void GetKey1C61( )
      {
         /* Using cursor T001C7 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A252ResolucionCodigo});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound61 = 1 ;
         }
         else
         {
            RcdFound61 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001C3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A252ResolucionCodigo});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1C61( 6) ;
            RcdFound61 = 1 ;
            A252ResolucionCodigo = T001C3_A252ResolucionCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A252ResolucionCodigo", A252ResolucionCodigo);
            A253ResolucionFecha = T001C3_A253ResolucionFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A253ResolucionFecha", context.localUtil.Format(A253ResolucionFecha, "99/99/99"));
            A254ResolucionVencimiento = T001C3_A254ResolucionVencimiento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A254ResolucionVencimiento", context.localUtil.Format(A254ResolucionVencimiento, "99/99/99"));
            A255ResolucionSerie = T001C3_A255ResolucionSerie[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A255ResolucionSerie", A255ResolucionSerie);
            A256ResolucionInicial = T001C3_A256ResolucionInicial[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A256ResolucionInicial", StringUtil.LTrim( StringUtil.Str( (decimal)(A256ResolucionInicial), 9, 0)));
            A257ResolucionFinal = T001C3_A257ResolucionFinal[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A257ResolucionFinal", StringUtil.LTrim( StringUtil.Str( (decimal)(A257ResolucionFinal), 9, 0)));
            A258ResolucionSiguiente = T001C3_A258ResolucionSiguiente[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A258ResolucionSiguiente", StringUtil.LTrim( StringUtil.Str( (decimal)(A258ResolucionSiguiente), 9, 0)));
            A41ClinicaCodigo = T001C3_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z252ResolucionCodigo = A252ResolucionCodigo ;
            sMode61 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1C61( ) ;
            Gx_mode = sMode61 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound61 = 0 ;
            InitializeNonKey1C61( ) ;
            sMode61 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode61 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1C61( ) ;
         if ( RcdFound61 == 0 )
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
         RcdFound61 = 0 ;
         /* Using cursor T001C8 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, A252ResolucionCodigo});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T001C8_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001C8_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001C8_A252ResolucionCodigo[0], A252ResolucionCodigo) < 0 ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T001C8_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001C8_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001C8_A252ResolucionCodigo[0], A252ResolucionCodigo) > 0 ) ) )
            {
               A41ClinicaCodigo = T001C8_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A252ResolucionCodigo = T001C8_A252ResolucionCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A252ResolucionCodigo", A252ResolucionCodigo);
               RcdFound61 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound61 = 0 ;
         /* Using cursor T001C9 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A252ResolucionCodigo});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T001C9_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001C9_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001C9_A252ResolucionCodigo[0], A252ResolucionCodigo) > 0 ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T001C9_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001C9_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001C9_A252ResolucionCodigo[0], A252ResolucionCodigo) < 0 ) ) )
            {
               A41ClinicaCodigo = T001C9_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A252ResolucionCodigo = T001C9_A252ResolucionCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A252ResolucionCodigo", A252ResolucionCodigo);
               RcdFound61 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1C61( ) ;
         if ( RcdFound61 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A252ResolucionCodigo, Z252ResolucionCodigo) != 0 ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A252ResolucionCodigo = Z252ResolucionCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A252ResolucionCodigo", A252ResolucionCodigo);
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
               Update1C61( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A252ResolucionCodigo, Z252ResolucionCodigo) != 0 ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert1C61( ) ;
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
                  Insert1C61( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A252ResolucionCodigo, Z252ResolucionCodigo) != 0 ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A252ResolucionCodigo = Z252ResolucionCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A252ResolucionCodigo", A252ResolucionCodigo);
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
         if ( RcdFound61 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtResolucionFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1C61( ) ;
         if ( RcdFound61 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtResolucionFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1C61( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound61 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtResolucionFecha_Internalname ;
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
         if ( RcdFound61 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtResolucionFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1C61( ) ;
         if ( RcdFound61 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound61 != 0 )
            {
               ScanNext1C61( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtResolucionFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1C61( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1C61( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001C10 */
            pr_default.execute(8, new Object[] {A41ClinicaCodigo, A252ResolucionCodigo});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ResolucionSAT"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(8) == 101) || ( Z253ResolucionFecha != T001C10_A253ResolucionFecha[0] ) || ( Z254ResolucionVencimiento != T001C10_A254ResolucionVencimiento[0] ) || ( StringUtil.StrCmp(Z255ResolucionSerie, T001C10_A255ResolucionSerie[0]) != 0 ) || ( Z256ResolucionInicial != T001C10_A256ResolucionInicial[0] ) || ( Z257ResolucionFinal != T001C10_A257ResolucionFinal[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z258ResolucionSiguiente != T001C10_A258ResolucionSiguiente[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ResolucionSAT"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1C61( )
      {
         BeforeValidate1C61( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1C61( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1C61( 0) ;
            CheckOptimisticConcurrency1C61( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1C61( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1C61( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001C11 */
                     pr_default.execute(9, new Object[] {A252ResolucionCodigo, A253ResolucionFecha, A254ResolucionVencimiento, A255ResolucionSerie, A256ResolucionInicial, A257ResolucionFinal, A258ResolucionSiguiente, A41ClinicaCodigo});
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
                           ResetCaption1C0( ) ;
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
               Load1C61( ) ;
            }
            EndLevel1C61( ) ;
         }
         CloseExtendedTableCursors1C61( ) ;
      }

      protected void Update1C61( )
      {
         BeforeValidate1C61( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1C61( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1C61( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1C61( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1C61( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001C12 */
                     pr_default.execute(10, new Object[] {A253ResolucionFecha, A254ResolucionVencimiento, A255ResolucionSerie, A256ResolucionInicial, A257ResolucionFinal, A258ResolucionSiguiente, A41ClinicaCodigo, A252ResolucionCodigo});
                     pr_default.close(10);
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ResolucionSAT"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1C61( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                           ResetCaption1C0( ) ;
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
            EndLevel1C61( ) ;
         }
         CloseExtendedTableCursors1C61( ) ;
      }

      protected void DeferredUpdate1C61( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1C61( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1C61( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1C61( ) ;
            AfterConfirm1C61( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1C61( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001C13 */
                  pr_default.execute(11, new Object[] {A41ClinicaCodigo, A252ResolucionCodigo});
                  pr_default.close(11);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound61 == 0 )
                        {
                           InitAll1C61( ) ;
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
                        ResetCaption1C0( ) ;
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
         sMode61 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1C61( ) ;
         Gx_mode = sMode61 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1C61( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T001C14 */
            pr_default.execute(12, new Object[] {A41ClinicaCodigo, A252ResolucionCodigo});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Cajas"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(12);
         }
      }

      protected void EndLevel1C61( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1C61( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(6);
            context.CommitDataStores("ResolucionSAT");
            if ( AnyError == 0 )
            {
               ConfirmValues1C0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(6);
            context.RollbackDataStores("ResolucionSAT");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1C61( )
      {
         /* Using cursor T001C15 */
         pr_default.execute(13);
         RcdFound61 = 0 ;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound61 = 1 ;
            A41ClinicaCodigo = T001C15_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A252ResolucionCodigo = T001C15_A252ResolucionCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A252ResolucionCodigo", A252ResolucionCodigo);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1C61( )
      {
         pr_default.readNext(13);
         RcdFound61 = 0 ;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound61 = 1 ;
            A41ClinicaCodigo = T001C15_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A252ResolucionCodigo = T001C15_A252ResolucionCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A252ResolucionCodigo", A252ResolucionCodigo);
         }
      }

      protected void ScanEnd1C61( )
      {
      }

      protected void AfterConfirm1C61( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1C61( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1C61( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1C61( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1C61( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1C61( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1C61( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtResolucionCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtResolucionCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtResolucionCodigo_Enabled), 5, 0)));
         edtResolucionFecha_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtResolucionFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtResolucionFecha_Enabled), 5, 0)));
         edtResolucionVencimiento_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtResolucionVencimiento_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtResolucionVencimiento_Enabled), 5, 0)));
         edtResolucionSerie_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtResolucionSerie_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtResolucionSerie_Enabled), 5, 0)));
         edtResolucionInicial_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtResolucionInicial_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtResolucionInicial_Enabled), 5, 0)));
         edtResolucionFinal_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtResolucionFinal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtResolucionFinal_Enabled), 5, 0)));
         edtResolucionSiguiente_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtResolucionSiguiente_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtResolucionSiguiente_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1C0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("resolucionsat.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z252ResolucionCodigo", StringUtil.RTrim( Z252ResolucionCodigo));
         GxWebStd.gx_hidden_field( context, "Z253ResolucionFecha", context.localUtil.DToC( Z253ResolucionFecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z254ResolucionVencimiento", context.localUtil.DToC( Z254ResolucionVencimiento, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z255ResolucionSerie", StringUtil.RTrim( Z255ResolucionSerie));
         GxWebStd.gx_hidden_field( context, "Z256ResolucionInicial", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z256ResolucionInicial), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z257ResolucionFinal", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z257ResolucionFinal), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z258ResolucionSiguiente", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z258ResolucionSiguiente), 9, 0, ".", "")));
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
         return "ResolucionSAT" ;
      }

      public override String GetPgmdesc( )
      {
         return "Resoluciones de Facturas SAT" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("resolucionsat.aspx")  ;
      }

      protected void InitializeNonKey1C61( )
      {
         A253ResolucionFecha = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A253ResolucionFecha", context.localUtil.Format(A253ResolucionFecha, "99/99/99"));
         A254ResolucionVencimiento = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A254ResolucionVencimiento", context.localUtil.Format(A254ResolucionVencimiento, "99/99/99"));
         A255ResolucionSerie = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A255ResolucionSerie", A255ResolucionSerie);
         A256ResolucionInicial = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A256ResolucionInicial", StringUtil.LTrim( StringUtil.Str( (decimal)(A256ResolucionInicial), 9, 0)));
         A257ResolucionFinal = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A257ResolucionFinal", StringUtil.LTrim( StringUtil.Str( (decimal)(A257ResolucionFinal), 9, 0)));
         A258ResolucionSiguiente = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A258ResolucionSiguiente", StringUtil.LTrim( StringUtil.Str( (decimal)(A258ResolucionSiguiente), 9, 0)));
      }

      protected void InitAll1C61( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A252ResolucionCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A252ResolucionCodigo", A252ResolucionCodigo);
         InitializeNonKey1C61( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1563950");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("resolucionsat.js", "?1563950");
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
         lblTextblockresolucioncodigo_Internalname = "TEXTBLOCKRESOLUCIONCODIGO" ;
         edtResolucionCodigo_Internalname = "RESOLUCIONCODIGO" ;
         lblTextblockresolucionfecha_Internalname = "TEXTBLOCKRESOLUCIONFECHA" ;
         edtResolucionFecha_Internalname = "RESOLUCIONFECHA" ;
         lblTextblockresolucionvencimiento_Internalname = "TEXTBLOCKRESOLUCIONVENCIMIENTO" ;
         edtResolucionVencimiento_Internalname = "RESOLUCIONVENCIMIENTO" ;
         lblTextblockresolucionserie_Internalname = "TEXTBLOCKRESOLUCIONSERIE" ;
         edtResolucionSerie_Internalname = "RESOLUCIONSERIE" ;
         lblTextblockresolucioninicial_Internalname = "TEXTBLOCKRESOLUCIONINICIAL" ;
         edtResolucionInicial_Internalname = "RESOLUCIONINICIAL" ;
         lblTextblockresolucionfinal_Internalname = "TEXTBLOCKRESOLUCIONFINAL" ;
         edtResolucionFinal_Internalname = "RESOLUCIONFINAL" ;
         lblTextblockresolucionsiguiente_Internalname = "TEXTBLOCKRESOLUCIONSIGUIENTE" ;
         edtResolucionSiguiente_Internalname = "RESOLUCIONSIGUIENTE" ;
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
         Form.Caption = "Resoluciones de Facturas SAT" ;
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
         edtResolucionSiguiente_Jsonclick = "" ;
         edtResolucionSiguiente_Enabled = 1 ;
         edtResolucionFinal_Jsonclick = "" ;
         edtResolucionFinal_Enabled = 1 ;
         edtResolucionInicial_Jsonclick = "" ;
         edtResolucionInicial_Enabled = 1 ;
         edtResolucionSerie_Jsonclick = "" ;
         edtResolucionSerie_Enabled = 1 ;
         edtResolucionVencimiento_Jsonclick = "" ;
         edtResolucionVencimiento_Enabled = 1 ;
         edtResolucionFecha_Jsonclick = "" ;
         edtResolucionFecha_Enabled = 1 ;
         edtResolucionCodigo_Jsonclick = "" ;
         edtResolucionCodigo_Enabled = 1 ;
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
         /* Using cursor T001C16 */
         pr_default.execute(14, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(14) == 101) )
         {
            AnyError41 = 1 ;
            GX_msglist.addItem("No existe 'Cl�nica M�dica'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError41 == 0 )
         {
         }
         pr_default.close(14);
         GX_FocusControl = edtResolucionFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Clinicacodigo( String GX_Parm1 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         /* Using cursor T001C16 */
         pr_default.execute(14, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(14) == 101) )
         {
            AnyError41 = 1 ;
            GX_msglist.addItem("No existe 'Cl�nica M�dica'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( AnyError41 == 0 )
         {
         }
         pr_default.close(14);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Resolucioncodigo( String GX_Parm1 ,
                                          String GX_Parm2 ,
                                          String GX_Parm3 ,
                                          DateTime GX_Parm4 ,
                                          DateTime GX_Parm5 ,
                                          String GX_Parm6 ,
                                          int GX_Parm7 ,
                                          int GX_Parm8 ,
                                          int GX_Parm9 )
      {
         AV8ClinicaCodigo = GX_Parm1 ;
         A41ClinicaCodigo = GX_Parm2 ;
         A252ResolucionCodigo = GX_Parm3 ;
         A253ResolucionFecha = GX_Parm4 ;
         A254ResolucionVencimiento = GX_Parm5 ;
         A255ResolucionSerie = GX_Parm6 ;
         A256ResolucionInicial = GX_Parm7 ;
         A257ResolucionFinal = GX_Parm8 ;
         A258ResolucionSiguiente = GX_Parm9 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(context.localUtil.Format(A253ResolucionFecha, "99/99/99")));
         isValidOutput.Add((Object)(context.localUtil.Format(A254ResolucionVencimiento, "99/99/99")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A255ResolucionSerie)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A256ResolucionInicial), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A257ResolucionFinal), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A258ResolucionSiguiente), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z252ResolucionCodigo)));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z253ResolucionFecha, 0, "/")));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z254ResolucionVencimiento, 0, "/")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z255ResolucionSerie)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z256ResolucionInicial), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z257ResolucionFinal), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z258ResolucionSiguiente), 9, 0, ".", ""))));
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
         pr_default.close(14);
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
         lblTextblockresolucioncodigo_Jsonclick = "" ;
         A252ResolucionCodigo = "" ;
         lblTextblockresolucionfecha_Jsonclick = "" ;
         A253ResolucionFecha = DateTime.MinValue ;
         lblTextblockresolucionvencimiento_Jsonclick = "" ;
         A254ResolucionVencimiento = DateTime.MinValue ;
         lblTextblockresolucionserie_Jsonclick = "" ;
         A255ResolucionSerie = "" ;
         lblTextblockresolucioninicial_Jsonclick = "" ;
         lblTextblockresolucionfinal_Jsonclick = "" ;
         lblTextblockresolucionsiguiente_Jsonclick = "" ;
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
         Z252ResolucionCodigo = "" ;
         Z253ResolucionFecha = DateTime.MinValue ;
         Z254ResolucionVencimiento = DateTime.MinValue ;
         Z255ResolucionSerie = "" ;
         Gx_mode = "" ;
         AV8ClinicaCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV7Parametros = new SdtParametros(context);
         GXt_SdtParametros4 = new SdtParametros(context);
         T001C5_A252ResolucionCodigo = new String[] {""} ;
         T001C5_A253ResolucionFecha = new DateTime[] {DateTime.MinValue} ;
         T001C5_A254ResolucionVencimiento = new DateTime[] {DateTime.MinValue} ;
         T001C5_A255ResolucionSerie = new String[] {""} ;
         T001C5_A256ResolucionInicial = new int[1] ;
         T001C5_A257ResolucionFinal = new int[1] ;
         T001C5_A258ResolucionSiguiente = new int[1] ;
         T001C5_A41ClinicaCodigo = new String[] {""} ;
         T001C4_A41ClinicaCodigo = new String[] {""} ;
         T001C6_A41ClinicaCodigo = new String[] {""} ;
         T001C7_A41ClinicaCodigo = new String[] {""} ;
         T001C7_A252ResolucionCodigo = new String[] {""} ;
         T001C3_A252ResolucionCodigo = new String[] {""} ;
         T001C3_A253ResolucionFecha = new DateTime[] {DateTime.MinValue} ;
         T001C3_A254ResolucionVencimiento = new DateTime[] {DateTime.MinValue} ;
         T001C3_A255ResolucionSerie = new String[] {""} ;
         T001C3_A256ResolucionInicial = new int[1] ;
         T001C3_A257ResolucionFinal = new int[1] ;
         T001C3_A258ResolucionSiguiente = new int[1] ;
         T001C3_A41ClinicaCodigo = new String[] {""} ;
         sMode61 = "" ;
         T001C8_A41ClinicaCodigo = new String[] {""} ;
         T001C8_A252ResolucionCodigo = new String[] {""} ;
         T001C9_A41ClinicaCodigo = new String[] {""} ;
         T001C9_A252ResolucionCodigo = new String[] {""} ;
         T001C10_A252ResolucionCodigo = new String[] {""} ;
         T001C10_A253ResolucionFecha = new DateTime[] {DateTime.MinValue} ;
         T001C10_A254ResolucionVencimiento = new DateTime[] {DateTime.MinValue} ;
         T001C10_A255ResolucionSerie = new String[] {""} ;
         T001C10_A256ResolucionInicial = new int[1] ;
         T001C10_A257ResolucionFinal = new int[1] ;
         T001C10_A258ResolucionSiguiente = new int[1] ;
         T001C10_A41ClinicaCodigo = new String[] {""} ;
         T001C14_A41ClinicaCodigo = new String[] {""} ;
         T001C14_A132CajaCodigo = new String[] {""} ;
         T001C15_A41ClinicaCodigo = new String[] {""} ;
         T001C15_A252ResolucionCodigo = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         T001C16_A41ClinicaCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.resolucionsat__default(),
            new Object[][] {
                new Object[] {
               T001C2_A252ResolucionCodigo, T001C2_A253ResolucionFecha, T001C2_A254ResolucionVencimiento, T001C2_A255ResolucionSerie, T001C2_A256ResolucionInicial, T001C2_A257ResolucionFinal, T001C2_A258ResolucionSiguiente, T001C2_A41ClinicaCodigo
               }
               , new Object[] {
               T001C3_A252ResolucionCodigo, T001C3_A253ResolucionFecha, T001C3_A254ResolucionVencimiento, T001C3_A255ResolucionSerie, T001C3_A256ResolucionInicial, T001C3_A257ResolucionFinal, T001C3_A258ResolucionSiguiente, T001C3_A41ClinicaCodigo
               }
               , new Object[] {
               T001C4_A41ClinicaCodigo
               }
               , new Object[] {
               T001C5_A252ResolucionCodigo, T001C5_A253ResolucionFecha, T001C5_A254ResolucionVencimiento, T001C5_A255ResolucionSerie, T001C5_A256ResolucionInicial, T001C5_A257ResolucionFinal, T001C5_A258ResolucionSiguiente, T001C5_A41ClinicaCodigo
               }
               , new Object[] {
               T001C6_A41ClinicaCodigo
               }
               , new Object[] {
               T001C7_A41ClinicaCodigo, T001C7_A252ResolucionCodigo
               }
               , new Object[] {
               T001C8_A41ClinicaCodigo, T001C8_A252ResolucionCodigo
               }
               , new Object[] {
               T001C9_A41ClinicaCodigo, T001C9_A252ResolucionCodigo
               }
               , new Object[] {
               T001C10_A252ResolucionCodigo, T001C10_A253ResolucionFecha, T001C10_A254ResolucionVencimiento, T001C10_A255ResolucionSerie, T001C10_A256ResolucionInicial, T001C10_A257ResolucionFinal, T001C10_A258ResolucionSiguiente, T001C10_A41ClinicaCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001C14_A41ClinicaCodigo, T001C14_A132CajaCodigo
               }
               , new Object[] {
               T001C15_A41ClinicaCodigo, T001C15_A252ResolucionCodigo
               }
               , new Object[] {
               T001C16_A41ClinicaCodigo
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
      private short RcdFound61 ;
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
      private int edtResolucionCodigo_Enabled ;
      private int edtResolucionFecha_Enabled ;
      private int edtResolucionVencimiento_Enabled ;
      private int edtResolucionSerie_Enabled ;
      private int A256ResolucionInicial ;
      private int edtResolucionInicial_Enabled ;
      private int A257ResolucionFinal ;
      private int edtResolucionFinal_Enabled ;
      private int A258ResolucionSiguiente ;
      private int edtResolucionSiguiente_Enabled ;
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
      private int Z256ResolucionInicial ;
      private int Z257ResolucionFinal ;
      private int Z258ResolucionSiguiente ;
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
      private String lblTextblockresolucioncodigo_Internalname ;
      private String lblTextblockresolucioncodigo_Jsonclick ;
      private String edtResolucionCodigo_Internalname ;
      private String edtResolucionCodigo_Jsonclick ;
      private String lblTextblockresolucionfecha_Internalname ;
      private String lblTextblockresolucionfecha_Jsonclick ;
      private String edtResolucionFecha_Internalname ;
      private String edtResolucionFecha_Jsonclick ;
      private String lblTextblockresolucionvencimiento_Internalname ;
      private String lblTextblockresolucionvencimiento_Jsonclick ;
      private String edtResolucionVencimiento_Internalname ;
      private String edtResolucionVencimiento_Jsonclick ;
      private String lblTextblockresolucionserie_Internalname ;
      private String lblTextblockresolucionserie_Jsonclick ;
      private String edtResolucionSerie_Internalname ;
      private String edtResolucionSerie_Jsonclick ;
      private String lblTextblockresolucioninicial_Internalname ;
      private String lblTextblockresolucioninicial_Jsonclick ;
      private String edtResolucionInicial_Internalname ;
      private String edtResolucionInicial_Jsonclick ;
      private String lblTextblockresolucionfinal_Internalname ;
      private String lblTextblockresolucionfinal_Jsonclick ;
      private String edtResolucionFinal_Internalname ;
      private String edtResolucionFinal_Jsonclick ;
      private String lblTextblockresolucionsiguiente_Internalname ;
      private String lblTextblockresolucionsiguiente_Jsonclick ;
      private String edtResolucionSiguiente_Internalname ;
      private String edtResolucionSiguiente_Jsonclick ;
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
      private String sMode61 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private DateTime A253ResolucionFecha ;
      private DateTime A254ResolucionVencimiento ;
      private DateTime Z253ResolucionFecha ;
      private DateTime Z254ResolucionVencimiento ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool Gx_longc ;
      private String A41ClinicaCodigo ;
      private String A252ResolucionCodigo ;
      private String A255ResolucionSerie ;
      private String Z41ClinicaCodigo ;
      private String Z252ResolucionCodigo ;
      private String Z255ResolucionSerie ;
      private String AV8ClinicaCodigo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T001C5_A252ResolucionCodigo ;
      private DateTime[] T001C5_A253ResolucionFecha ;
      private DateTime[] T001C5_A254ResolucionVencimiento ;
      private String[] T001C5_A255ResolucionSerie ;
      private int[] T001C5_A256ResolucionInicial ;
      private int[] T001C5_A257ResolucionFinal ;
      private int[] T001C5_A258ResolucionSiguiente ;
      private String[] T001C5_A41ClinicaCodigo ;
      private String[] T001C4_A41ClinicaCodigo ;
      private String[] T001C6_A41ClinicaCodigo ;
      private String[] T001C7_A41ClinicaCodigo ;
      private String[] T001C7_A252ResolucionCodigo ;
      private String[] T001C3_A252ResolucionCodigo ;
      private DateTime[] T001C3_A253ResolucionFecha ;
      private DateTime[] T001C3_A254ResolucionVencimiento ;
      private String[] T001C3_A255ResolucionSerie ;
      private int[] T001C3_A256ResolucionInicial ;
      private int[] T001C3_A257ResolucionFinal ;
      private int[] T001C3_A258ResolucionSiguiente ;
      private String[] T001C3_A41ClinicaCodigo ;
      private String[] T001C8_A41ClinicaCodigo ;
      private String[] T001C8_A252ResolucionCodigo ;
      private String[] T001C9_A41ClinicaCodigo ;
      private String[] T001C9_A252ResolucionCodigo ;
      private String[] T001C10_A252ResolucionCodigo ;
      private DateTime[] T001C10_A253ResolucionFecha ;
      private DateTime[] T001C10_A254ResolucionVencimiento ;
      private String[] T001C10_A255ResolucionSerie ;
      private int[] T001C10_A256ResolucionInicial ;
      private int[] T001C10_A257ResolucionFinal ;
      private int[] T001C10_A258ResolucionSiguiente ;
      private String[] T001C10_A41ClinicaCodigo ;
      private String[] T001C14_A41ClinicaCodigo ;
      private String[] T001C14_A132CajaCodigo ;
      private String[] T001C15_A41ClinicaCodigo ;
      private String[] T001C15_A252ResolucionCodigo ;
      private String[] T001C16_A41ClinicaCodigo ;
      private String[] T001C2_A252ResolucionCodigo ;
      private DateTime[] T001C2_A253ResolucionFecha ;
      private DateTime[] T001C2_A254ResolucionVencimiento ;
      private String[] T001C2_A255ResolucionSerie ;
      private int[] T001C2_A256ResolucionInicial ;
      private int[] T001C2_A257ResolucionFinal ;
      private int[] T001C2_A258ResolucionSiguiente ;
      private String[] T001C2_A41ClinicaCodigo ;
      private GXWebForm Form ;
      private SdtParametros AV7Parametros ;
      private SdtParametros GXt_SdtParametros4 ;
   }

   public class resolucionsat__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT001C2 ;
          prmT001C2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ResolucionCodigo",SqlDbType.VarChar,20,0}
          } ;
          Object[] prmT001C5 ;
          prmT001C5 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ResolucionCodigo",SqlDbType.VarChar,20,0}
          } ;
          Object[] prmT001C4 ;
          prmT001C4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001C6 ;
          prmT001C6 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001C7 ;
          prmT001C7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ResolucionCodigo",SqlDbType.VarChar,20,0}
          } ;
          Object[] prmT001C3 ;
          prmT001C3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ResolucionCodigo",SqlDbType.VarChar,20,0}
          } ;
          Object[] prmT001C8 ;
          prmT001C8 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ResolucionCodigo",SqlDbType.VarChar,20,0}
          } ;
          Object[] prmT001C9 ;
          prmT001C9 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ResolucionCodigo",SqlDbType.VarChar,20,0}
          } ;
          Object[] prmT001C10 ;
          prmT001C10 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ResolucionCodigo",SqlDbType.VarChar,20,0}
          } ;
          Object[] prmT001C11 ;
          prmT001C11 = new Object[] {
          new Object[] {"@ResolucionCodigo",SqlDbType.VarChar,20,0} ,
          new Object[] {"@ResolucionFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ResolucionVencimiento",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ResolucionSerie",SqlDbType.VarChar,20,0} ,
          new Object[] {"@ResolucionInicial",SqlDbType.Int,9,0} ,
          new Object[] {"@ResolucionFinal",SqlDbType.Int,9,0} ,
          new Object[] {"@ResolucionSiguiente",SqlDbType.Int,9,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001C12 ;
          prmT001C12 = new Object[] {
          new Object[] {"@ResolucionFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ResolucionVencimiento",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ResolucionSerie",SqlDbType.VarChar,20,0} ,
          new Object[] {"@ResolucionInicial",SqlDbType.Int,9,0} ,
          new Object[] {"@ResolucionFinal",SqlDbType.Int,9,0} ,
          new Object[] {"@ResolucionSiguiente",SqlDbType.Int,9,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ResolucionCodigo",SqlDbType.VarChar,20,0}
          } ;
          Object[] prmT001C13 ;
          prmT001C13 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ResolucionCodigo",SqlDbType.VarChar,20,0}
          } ;
          Object[] prmT001C14 ;
          prmT001C14 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ResolucionCodigo",SqlDbType.VarChar,20,0}
          } ;
          Object[] prmT001C15 ;
          prmT001C15 = new Object[] {
          } ;
          Object[] prmT001C16 ;
          prmT001C16 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T001C2", "SELECT [ResolucionCodigo], [ResolucionFecha], [ResolucionVencimiento], [ResolucionSerie], [ResolucionInicial], [ResolucionFinal], [ResolucionSiguiente], [ClinicaCodigo] FROM [ResolucionSAT] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ResolucionCodigo] = @ResolucionCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001C2,1,0,true,false )
             ,new CursorDef("T001C3", "SELECT [ResolucionCodigo], [ResolucionFecha], [ResolucionVencimiento], [ResolucionSerie], [ResolucionInicial], [ResolucionFinal], [ResolucionSiguiente], [ClinicaCodigo] FROM [ResolucionSAT] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ResolucionCodigo] = @ResolucionCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001C3,1,0,true,false )
             ,new CursorDef("T001C4", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001C4,1,0,true,false )
             ,new CursorDef("T001C5", "SELECT TM1.[ResolucionCodigo], TM1.[ResolucionFecha], TM1.[ResolucionVencimiento], TM1.[ResolucionSerie], TM1.[ResolucionInicial], TM1.[ResolucionFinal], TM1.[ResolucionSiguiente], TM1.[ClinicaCodigo] FROM [ResolucionSAT] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[ResolucionCodigo] = @ResolucionCodigo ORDER BY TM1.[ClinicaCodigo], TM1.[ResolucionCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001C5,100,0,true,false )
             ,new CursorDef("T001C6", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001C6,1,0,true,false )
             ,new CursorDef("T001C7", "SELECT [ClinicaCodigo], [ResolucionCodigo] FROM [ResolucionSAT] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ResolucionCodigo] = @ResolucionCodigo  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001C7,1,0,true,false )
             ,new CursorDef("T001C8", "SELECT TOP 1 [ClinicaCodigo], [ResolucionCodigo] FROM [ResolucionSAT] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [ResolucionCodigo] > @ResolucionCodigo) ORDER BY [ClinicaCodigo], [ResolucionCodigo]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001C8,1,0,true,true )
             ,new CursorDef("T001C9", "SELECT TOP 1 [ClinicaCodigo], [ResolucionCodigo] FROM [ResolucionSAT] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [ResolucionCodigo] < @ResolucionCodigo) ORDER BY [ClinicaCodigo] DESC, [ResolucionCodigo] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001C9,1,0,true,true )
             ,new CursorDef("T001C10", "SELECT [ResolucionCodigo], [ResolucionFecha], [ResolucionVencimiento], [ResolucionSerie], [ResolucionInicial], [ResolucionFinal], [ResolucionSiguiente], [ClinicaCodigo] FROM [ResolucionSAT] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ResolucionCodigo] = @ResolucionCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001C10,1,0,true,false )
             ,new CursorDef("T001C11", "INSERT INTO [ResolucionSAT] ([ResolucionCodigo], [ResolucionFecha], [ResolucionVencimiento], [ResolucionSerie], [ResolucionInicial], [ResolucionFinal], [ResolucionSiguiente], [ClinicaCodigo]) VALUES (@ResolucionCodigo, @ResolucionFecha, @ResolucionVencimiento, @ResolucionSerie, @ResolucionInicial, @ResolucionFinal, @ResolucionSiguiente, @ClinicaCodigo)", GxErrorMask.GX_NOMASK,prmT001C11)
             ,new CursorDef("T001C12", "UPDATE [ResolucionSAT] SET [ResolucionFecha]=@ResolucionFecha, [ResolucionVencimiento]=@ResolucionVencimiento, [ResolucionSerie]=@ResolucionSerie, [ResolucionInicial]=@ResolucionInicial, [ResolucionFinal]=@ResolucionFinal, [ResolucionSiguiente]=@ResolucionSiguiente  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ResolucionCodigo] = @ResolucionCodigo", GxErrorMask.GX_NOMASK,prmT001C12)
             ,new CursorDef("T001C13", "DELETE FROM [ResolucionSAT]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ResolucionCodigo] = @ResolucionCodigo", GxErrorMask.GX_NOMASK,prmT001C13)
             ,new CursorDef("T001C14", "SELECT TOP 1 [ClinicaCodigo], [CajaCodigo] FROM [Caja] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ResolucionCodigo] = @ResolucionCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001C14,1,0,true,true )
             ,new CursorDef("T001C15", "SELECT [ClinicaCodigo], [ResolucionCodigo] FROM [ResolucionSAT] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [ResolucionCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001C15,100,0,true,false )
             ,new CursorDef("T001C16", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001C16,1,0,true,false )
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 14 :
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
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                break;
             case 10 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
