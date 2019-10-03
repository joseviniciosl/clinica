/*
               File: Calendario_BC
        Description: Calendario
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/10/2019 15:21:37.73
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
   public class calendario_bc : GXHttpHandler, IGxSilentTrn
   {
      public calendario_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public calendario_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      protected void INITTRN( )
      {
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: E11192 */
            E11192 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z41ClinicaCodigo = A41ClinicaCodigo ;
               Z233CalendarioCodigo = A233CalendarioCodigo ;
               SetMode( "UPD") ;
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

      public bool Reindex( )
      {
         return true ;
      }

      protected void CONFIRM_190( )
      {
         BeforeValidate1958( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1958( ) ;
            }
            else
            {
               CheckExtendedTable1958( ) ;
               if ( AnyError == 0 )
               {
                  ZM1958( 4) ;
               }
               CloseExtendedTableCursors1958( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void E12192( )
      {
         /* Start Routine */
      }

      protected void E11192( )
      {
         /* After Trn Routine */
      }

      protected void ZM1958( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z234CalendarioObs = A234CalendarioObs ;
            Z235CalendarioInicio = A235CalendarioInicio ;
            Z236CalendarioFinal = A236CalendarioFinal ;
            Z67PacienteId = A67PacienteId ;
         }
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -3 )
         {
            Z233CalendarioCodigo = A233CalendarioCodigo ;
            Z234CalendarioObs = A234CalendarioObs ;
            Z235CalendarioInicio = A235CalendarioInicio ;
            Z236CalendarioFinal = A236CalendarioFinal ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z67PacienteId = A67PacienteId ;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1958( )
      {
         /* Using cursor BC00195 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A233CalendarioCodigo});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound58 = 1 ;
            A234CalendarioObs = BC00195_A234CalendarioObs[0] ;
            A235CalendarioInicio = BC00195_A235CalendarioInicio[0] ;
            A236CalendarioFinal = BC00195_A236CalendarioFinal[0] ;
            A67PacienteId = BC00195_A67PacienteId[0] ;
            ZM1958( -3) ;
         }
         pr_default.close(3);
         OnLoadActions1958( ) ;
      }

      protected void OnLoadActions1958( )
      {
      }

      protected void CheckExtendedTable1958( )
      {
         standaloneModal( ) ;
         /* Using cursor BC00194 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo, A67PacienteId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError41 = 1 ;
            AnyError67 = 1 ;
            GX_msglist.addItem("No existe 'Pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError67 == 0 ) )
         {
         }
         pr_default.close(2);
         if ( ! ( (DateTime.MinValue==A235CalendarioInicio) || ( A235CalendarioInicio >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Inicia fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A236CalendarioFinal) || ( A236CalendarioFinal >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Final fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors1958( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1958( )
      {
         /* Using cursor BC00196 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo, A233CalendarioCodigo});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound58 = 1 ;
         }
         else
         {
            RcdFound58 = 0 ;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00193 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A233CalendarioCodigo});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1958( 3) ;
            RcdFound58 = 1 ;
            A233CalendarioCodigo = BC00193_A233CalendarioCodigo[0] ;
            A234CalendarioObs = BC00193_A234CalendarioObs[0] ;
            A235CalendarioInicio = BC00193_A235CalendarioInicio[0] ;
            A236CalendarioFinal = BC00193_A236CalendarioFinal[0] ;
            A41ClinicaCodigo = BC00193_A41ClinicaCodigo[0] ;
            A67PacienteId = BC00193_A67PacienteId[0] ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z233CalendarioCodigo = A233CalendarioCodigo ;
            sMode58 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Load1958( ) ;
            Gx_mode = sMode58 ;
         }
         else
         {
            RcdFound58 = 0 ;
            InitializeNonKey1958( ) ;
            sMode58 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Gx_mode = sMode58 ;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1958( ) ;
         if ( RcdFound58 == 0 )
         {
            Gx_mode = "INS" ;
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         getByPrimaryKey( ) ;
      }

      protected void insert_Check( )
      {
         CONFIRM_190( ) ;
         IsConfirmed = 0 ;
      }

      protected void update_Check( )
      {
         insert_Check( ) ;
      }

      protected void delete_Check( )
      {
         insert_Check( ) ;
      }

      protected void CheckOptimisticConcurrency1958( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00192 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, A233CalendarioCodigo});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Calendario"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z234CalendarioObs, BC00192_A234CalendarioObs[0]) != 0 ) || ( Z235CalendarioInicio != BC00192_A235CalendarioInicio[0] ) || ( Z236CalendarioFinal != BC00192_A236CalendarioFinal[0] ) || ( Z67PacienteId != BC00192_A67PacienteId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Calendario"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1958( )
      {
         BeforeValidate1958( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1958( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1958( 0) ;
            CheckOptimisticConcurrency1958( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1958( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1958( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00197 */
                     pr_default.execute(5, new Object[] {A233CalendarioCodigo, A234CalendarioObs, A235CalendarioInicio, A236CalendarioFinal, A41ClinicaCodigo, A67PacienteId});
                     pr_default.close(5);
                     if ( (pr_default.getStatus(5) == 1) )
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
               Load1958( ) ;
            }
            EndLevel1958( ) ;
         }
         CloseExtendedTableCursors1958( ) ;
      }

      protected void Update1958( )
      {
         BeforeValidate1958( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1958( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1958( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1958( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1958( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00198 */
                     pr_default.execute(6, new Object[] {A234CalendarioObs, A235CalendarioInicio, A236CalendarioFinal, A67PacienteId, A41ClinicaCodigo, A233CalendarioCodigo});
                     pr_default.close(6);
                     if ( (pr_default.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Calendario"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1958( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
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
            EndLevel1958( ) ;
         }
         CloseExtendedTableCursors1958( ) ;
      }

      protected void DeferredUpdate1958( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         BeforeValidate1958( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1958( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1958( ) ;
            AfterConfirm1958( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1958( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00199 */
                  pr_default.execute(7, new Object[] {A41ClinicaCodigo, A233CalendarioCodigo});
                  pr_default.close(7);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), 0, "");
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
         sMode58 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel1958( ) ;
         Gx_mode = sMode58 ;
      }

      protected void OnDeleteControls1958( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1958( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1958( ) ;
         }
         if ( AnyError == 0 )
         {
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanKeyStart1958( )
      {
         /* Using cursor BC001910 */
         pr_default.execute(8, new Object[] {A41ClinicaCodigo, A233CalendarioCodigo});
         RcdFound58 = 0 ;
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound58 = 1 ;
            A233CalendarioCodigo = BC001910_A233CalendarioCodigo[0] ;
            A234CalendarioObs = BC001910_A234CalendarioObs[0] ;
            A235CalendarioInicio = BC001910_A235CalendarioInicio[0] ;
            A236CalendarioFinal = BC001910_A236CalendarioFinal[0] ;
            A41ClinicaCodigo = BC001910_A41ClinicaCodigo[0] ;
            A67PacienteId = BC001910_A67PacienteId[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1958( )
      {
         pr_default.readNext(8);
         RcdFound58 = 0 ;
         ScanKeyLoad1958( ) ;
      }

      protected void ScanKeyLoad1958( )
      {
         sMode58 = Gx_mode ;
         Gx_mode = "DSP" ;
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound58 = 1 ;
            A233CalendarioCodigo = BC001910_A233CalendarioCodigo[0] ;
            A234CalendarioObs = BC001910_A234CalendarioObs[0] ;
            A235CalendarioInicio = BC001910_A235CalendarioInicio[0] ;
            A236CalendarioFinal = BC001910_A236CalendarioFinal[0] ;
            A41ClinicaCodigo = BC001910_A41ClinicaCodigo[0] ;
            A67PacienteId = BC001910_A67PacienteId[0] ;
         }
         Gx_mode = sMode58 ;
      }

      protected void ScanKeyEnd1958( )
      {
         pr_default.close(8);
      }

      protected void AfterConfirm1958( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1958( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1958( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1958( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1958( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1958( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1958( )
      {
      }

      protected void AddRow1958( )
      {
         VarsToRow58( bcCalendario) ;
      }

      protected void ReadRow1958( )
      {
         RowToVars58( bcCalendario, 1) ;
      }

      protected void InitializeNonKey1958( )
      {
         A234CalendarioObs = "" ;
         A67PacienteId = 0 ;
         A235CalendarioInicio = (DateTime)(DateTime.MinValue) ;
         A236CalendarioFinal = (DateTime)(DateTime.MinValue) ;
      }

      protected void InitAll1958( )
      {
         A41ClinicaCodigo = "" ;
         A233CalendarioCodigo = "" ;
         InitializeNonKey1958( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow58( SdtCalendario obj58 )
      {
         obj58.gxTpr_Mode = Gx_mode ;
         obj58.gxTpr_Calendarioobs = A234CalendarioObs ;
         obj58.gxTpr_Pacienteid = A67PacienteId ;
         obj58.gxTpr_Calendarioinicio = A235CalendarioInicio ;
         obj58.gxTpr_Calendariofinal = A236CalendarioFinal ;
         obj58.gxTpr_Clinicacodigo = A41ClinicaCodigo ;
         obj58.gxTpr_Calendariocodigo = A233CalendarioCodigo ;
         obj58.gxTpr_Clinicacodigo_Z = Z41ClinicaCodigo ;
         obj58.gxTpr_Calendariocodigo_Z = Z233CalendarioCodigo ;
         obj58.gxTpr_Calendarioobs_Z = Z234CalendarioObs ;
         obj58.gxTpr_Pacienteid_Z = Z67PacienteId ;
         obj58.gxTpr_Calendarioinicio_Z = Z235CalendarioInicio ;
         obj58.gxTpr_Calendariofinal_Z = Z236CalendarioFinal ;
         obj58.gxTpr_Mode = Gx_mode ;
         return  ;
      }

      public void RowToVars58( SdtCalendario obj58 ,
                               int forceLoad )
      {
         Gx_mode = obj58.gxTpr_Mode ;
         A234CalendarioObs = obj58.gxTpr_Calendarioobs ;
         A67PacienteId = obj58.gxTpr_Pacienteid ;
         A235CalendarioInicio = obj58.gxTpr_Calendarioinicio ;
         A236CalendarioFinal = obj58.gxTpr_Calendariofinal ;
         A41ClinicaCodigo = obj58.gxTpr_Clinicacodigo ;
         A233CalendarioCodigo = obj58.gxTpr_Calendariocodigo ;
         Z41ClinicaCodigo = obj58.gxTpr_Clinicacodigo_Z ;
         Z233CalendarioCodigo = obj58.gxTpr_Calendariocodigo_Z ;
         Z234CalendarioObs = obj58.gxTpr_Calendarioobs_Z ;
         Z67PacienteId = obj58.gxTpr_Pacienteid_Z ;
         Z235CalendarioInicio = obj58.gxTpr_Calendarioinicio_Z ;
         Z236CalendarioFinal = obj58.gxTpr_Calendariofinal_Z ;
         Gx_mode = obj58.gxTpr_Mode ;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         A41ClinicaCodigo = (String)getParm(obj,0) ;
         A233CalendarioCodigo = (String)getParm(obj,1) ;
         AnyError = 0 ;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1958( ) ;
         ScanKeyStart1958( ) ;
         if ( RcdFound58 == 0 )
         {
            Gx_mode = "INS" ;
         }
         else
         {
            Gx_mode = "UPD" ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z233CalendarioCodigo = A233CalendarioCodigo ;
         }
         ZM1958( -3) ;
         sMode58 = Gx_mode ;
         Gx_mode = "DSP" ;
         OnLoadActions1958( ) ;
         Gx_mode = sMode58 ;
         AddRow1958( ) ;
         ScanKeyEnd1958( ) ;
         if ( RcdFound58 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1 ;
         }
         context.GX_msglist = BackMsgLst ;
      }

      public void Save( )
      {
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         AnyError = 0 ;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1 ;
         RowToVars58( bcCalendario, 0) ;
         nKeyPressed = 1 ;
         GetKey1958( ) ;
         if ( RcdFound58 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1 ;
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A233CalendarioCodigo, Z233CalendarioCodigo) != 0 ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               A233CalendarioCodigo = Z233CalendarioCodigo ;
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
               AnyError = 1 ;
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
            }
            else
            {
               Gx_mode = "UPD" ;
               /* Update record */
               Update1958( ) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
               AnyError = 1 ;
            }
            else
            {
               if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A233CalendarioCodigo, Z233CalendarioCodigo) != 0 ) )
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                  }
                  else
                  {
                     Gx_mode = "INS" ;
                     /* Insert record */
                     Insert1958( ) ;
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                     AnyError = 1 ;
                  }
                  else
                  {
                     Gx_mode = "INS" ;
                     /* Insert record */
                     Insert1958( ) ;
                  }
               }
            }
         }
         AfterTrn( ) ;
         VarsToRow58( bcCalendario) ;
         context.GX_msglist = BackMsgLst ;
         return  ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         AnyError = 0 ;
         context.GX_msglist.removeAllItems();
         RowToVars58( bcCalendario, 0) ;
         nKeyPressed = 3 ;
         IsConfirmed = 0 ;
         GetKey1958( ) ;
         if ( RcdFound58 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1 ;
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A233CalendarioCodigo, Z233CalendarioCodigo) != 0 ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               A233CalendarioCodigo = Z233CalendarioCodigo ;
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1 ;
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete_Check( ) ;
            }
            else
            {
               Gx_mode = "UPD" ;
               update_Check( ) ;
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A233CalendarioCodigo, Z233CalendarioCodigo) != 0 ) )
            {
               Gx_mode = "INS" ;
               insert_Check( ) ;
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                  AnyError = 1 ;
               }
               else
               {
                  Gx_mode = "INS" ;
                  insert_Check( ) ;
               }
            }
         }
         pr_default.close(1);
         context.RollbackDataStores("Calendario_BC");
         VarsToRow58( bcCalendario) ;
         context.GX_msglist = BackMsgLst ;
         return  ;
      }

      public int Errors( )
      {
         if ( AnyError == 0 )
         {
            return (int)(0) ;
         }
         return (int)(1) ;
      }

      public msglist GetMessages( )
      {
         return LclMsgLst ;
      }

      public String GetMode( )
      {
         Gx_mode = bcCalendario.gxTpr_Mode ;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode ;
         bcCalendario.gxTpr_Mode = Gx_mode ;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcCalendario )
         {
            bcCalendario = (SdtCalendario)(sdt) ;
            if ( StringUtil.StrCmp(bcCalendario.gxTpr_Mode, "") == 0 )
            {
               bcCalendario.gxTpr_Mode = "INS" ;
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow58( bcCalendario) ;
            }
            else
            {
               RowToVars58( bcCalendario, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcCalendario.gxTpr_Mode, "") == 0 )
            {
               bcCalendario.gxTpr_Mode = "INS" ;
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars58( bcCalendario, 1) ;
         return  ;
      }

      public SdtCalendario Calendario_BC
      {
         get {
            return bcCalendario ;
         }

      }

      public override void webExecute( )
      {
         createObjects();
         initialize();
      }

      protected override void createObjects( )
      {
      }

      protected void Process( )
      {
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
         pr_default.close(1);
      }

      public override void initialize( )
      {
         scmdbuf = "" ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Gx_mode = "" ;
         Z41ClinicaCodigo = "" ;
         A41ClinicaCodigo = "" ;
         Z233CalendarioCodigo = "" ;
         A233CalendarioCodigo = "" ;
         Z234CalendarioObs = "" ;
         A234CalendarioObs = "" ;
         Z235CalendarioInicio = (DateTime)(DateTime.MinValue) ;
         A235CalendarioInicio = (DateTime)(DateTime.MinValue) ;
         Z236CalendarioFinal = (DateTime)(DateTime.MinValue) ;
         A236CalendarioFinal = (DateTime)(DateTime.MinValue) ;
         BC00195_A233CalendarioCodigo = new String[] {""} ;
         BC00195_A234CalendarioObs = new String[] {""} ;
         BC00195_A235CalendarioInicio = new DateTime[] {DateTime.MinValue} ;
         BC00195_A236CalendarioFinal = new DateTime[] {DateTime.MinValue} ;
         BC00195_A41ClinicaCodigo = new String[] {""} ;
         BC00195_A67PacienteId = new int[1] ;
         BC00194_A41ClinicaCodigo = new String[] {""} ;
         BC00196_A41ClinicaCodigo = new String[] {""} ;
         BC00196_A233CalendarioCodigo = new String[] {""} ;
         BC00193_A233CalendarioCodigo = new String[] {""} ;
         BC00193_A234CalendarioObs = new String[] {""} ;
         BC00193_A235CalendarioInicio = new DateTime[] {DateTime.MinValue} ;
         BC00193_A236CalendarioFinal = new DateTime[] {DateTime.MinValue} ;
         BC00193_A41ClinicaCodigo = new String[] {""} ;
         BC00193_A67PacienteId = new int[1] ;
         sMode58 = "" ;
         BC00192_A233CalendarioCodigo = new String[] {""} ;
         BC00192_A234CalendarioObs = new String[] {""} ;
         BC00192_A235CalendarioInicio = new DateTime[] {DateTime.MinValue} ;
         BC00192_A236CalendarioFinal = new DateTime[] {DateTime.MinValue} ;
         BC00192_A41ClinicaCodigo = new String[] {""} ;
         BC00192_A67PacienteId = new int[1] ;
         BC001910_A233CalendarioCodigo = new String[] {""} ;
         BC001910_A234CalendarioObs = new String[] {""} ;
         BC001910_A235CalendarioInicio = new DateTime[] {DateTime.MinValue} ;
         BC001910_A236CalendarioFinal = new DateTime[] {DateTime.MinValue} ;
         BC001910_A41ClinicaCodigo = new String[] {""} ;
         BC001910_A67PacienteId = new int[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.calendario_bc__default(),
            new Object[][] {
                new Object[] {
               BC00192_A233CalendarioCodigo, BC00192_A234CalendarioObs, BC00192_A235CalendarioInicio, BC00192_A236CalendarioFinal, BC00192_A41ClinicaCodigo, BC00192_A67PacienteId
               }
               , new Object[] {
               BC00193_A233CalendarioCodigo, BC00193_A234CalendarioObs, BC00193_A235CalendarioInicio, BC00193_A236CalendarioFinal, BC00193_A41ClinicaCodigo, BC00193_A67PacienteId
               }
               , new Object[] {
               BC00194_A41ClinicaCodigo
               }
               , new Object[] {
               BC00195_A233CalendarioCodigo, BC00195_A234CalendarioObs, BC00195_A235CalendarioInicio, BC00195_A236CalendarioFinal, BC00195_A41ClinicaCodigo, BC00195_A67PacienteId
               }
               , new Object[] {
               BC00196_A41ClinicaCodigo, BC00196_A233CalendarioCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001910_A233CalendarioCodigo, BC001910_A234CalendarioObs, BC001910_A235CalendarioInicio, BC001910_A236CalendarioFinal, BC001910_A41ClinicaCodigo, BC001910_A67PacienteId
               }
            }
         );
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: E12192 */
         E12192 ();
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound58 ;
      private int trnEnded ;
      private int Z67PacienteId ;
      private int A67PacienteId ;
      private int AnyError41 ;
      private int AnyError67 ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode58 ;
      private DateTime Z235CalendarioInicio ;
      private DateTime A235CalendarioInicio ;
      private DateTime Z236CalendarioFinal ;
      private DateTime A236CalendarioFinal ;
      private String Z41ClinicaCodigo ;
      private String A41ClinicaCodigo ;
      private String Z233CalendarioCodigo ;
      private String A233CalendarioCodigo ;
      private String Z234CalendarioObs ;
      private String A234CalendarioObs ;
      private SdtCalendario bcCalendario ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] BC00195_A233CalendarioCodigo ;
      private String[] BC00195_A234CalendarioObs ;
      private DateTime[] BC00195_A235CalendarioInicio ;
      private DateTime[] BC00195_A236CalendarioFinal ;
      private String[] BC00195_A41ClinicaCodigo ;
      private int[] BC00195_A67PacienteId ;
      private String[] BC00194_A41ClinicaCodigo ;
      private String[] BC00196_A41ClinicaCodigo ;
      private String[] BC00196_A233CalendarioCodigo ;
      private String[] BC00193_A233CalendarioCodigo ;
      private String[] BC00193_A234CalendarioObs ;
      private DateTime[] BC00193_A235CalendarioInicio ;
      private DateTime[] BC00193_A236CalendarioFinal ;
      private String[] BC00193_A41ClinicaCodigo ;
      private int[] BC00193_A67PacienteId ;
      private String[] BC00192_A233CalendarioCodigo ;
      private String[] BC00192_A234CalendarioObs ;
      private DateTime[] BC00192_A235CalendarioInicio ;
      private DateTime[] BC00192_A236CalendarioFinal ;
      private String[] BC00192_A41ClinicaCodigo ;
      private int[] BC00192_A67PacienteId ;
      private String[] BC001910_A233CalendarioCodigo ;
      private String[] BC001910_A234CalendarioObs ;
      private DateTime[] BC001910_A235CalendarioInicio ;
      private DateTime[] BC001910_A236CalendarioFinal ;
      private String[] BC001910_A41ClinicaCodigo ;
      private int[] BC001910_A67PacienteId ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class calendario_bc__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[5])
         ,new UpdateCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new ForEachCursor(def[8])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC00195 ;
          prmBC00195 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CalendarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmBC00194 ;
          prmBC00194 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmBC00196 ;
          prmBC00196 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CalendarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmBC00193 ;
          prmBC00193 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CalendarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmBC00192 ;
          prmBC00192 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CalendarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmBC00197 ;
          prmBC00197 = new Object[] {
          new Object[] {"@CalendarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CalendarioObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@CalendarioInicio",SqlDbType.DateTime,8,5} ,
          new Object[] {"@CalendarioFinal",SqlDbType.DateTime,8,5} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmBC00198 ;
          prmBC00198 = new Object[] {
          new Object[] {"@CalendarioObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@CalendarioInicio",SqlDbType.DateTime,8,5} ,
          new Object[] {"@CalendarioFinal",SqlDbType.DateTime,8,5} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CalendarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmBC00199 ;
          prmBC00199 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CalendarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmBC001910 ;
          prmBC001910 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CalendarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00192", "SELECT [CalendarioCodigo], [CalendarioObs], [CalendarioInicio], [CalendarioFinal], [ClinicaCodigo], [PacienteId] FROM [Calendario] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CalendarioCodigo] = @CalendarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00192,1,0,true,false )
             ,new CursorDef("BC00193", "SELECT [CalendarioCodigo], [CalendarioObs], [CalendarioInicio], [CalendarioFinal], [ClinicaCodigo], [PacienteId] FROM [Calendario] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CalendarioCodigo] = @CalendarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00193,1,0,true,false )
             ,new CursorDef("BC00194", "SELECT [ClinicaCodigo] FROM [Paciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [PacienteId] = @PacienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00194,1,0,true,false )
             ,new CursorDef("BC00195", "SELECT TM1.[CalendarioCodigo], TM1.[CalendarioObs], TM1.[CalendarioInicio], TM1.[CalendarioFinal], TM1.[ClinicaCodigo], TM1.[PacienteId] FROM [Calendario] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[CalendarioCodigo] = @CalendarioCodigo ORDER BY TM1.[ClinicaCodigo], TM1.[CalendarioCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00195,100,0,true,false )
             ,new CursorDef("BC00196", "SELECT [ClinicaCodigo], [CalendarioCodigo] FROM [Calendario] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CalendarioCodigo] = @CalendarioCodigo  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00196,1,0,true,false )
             ,new CursorDef("BC00197", "INSERT INTO [Calendario] ([CalendarioCodigo], [CalendarioObs], [CalendarioInicio], [CalendarioFinal], [ClinicaCodigo], [PacienteId]) VALUES (@CalendarioCodigo, @CalendarioObs, @CalendarioInicio, @CalendarioFinal, @ClinicaCodigo, @PacienteId)", GxErrorMask.GX_NOMASK,prmBC00197)
             ,new CursorDef("BC00198", "UPDATE [Calendario] SET [CalendarioObs]=@CalendarioObs, [CalendarioInicio]=@CalendarioInicio, [CalendarioFinal]=@CalendarioFinal, [PacienteId]=@PacienteId  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CalendarioCodigo] = @CalendarioCodigo", GxErrorMask.GX_NOMASK,prmBC00198)
             ,new CursorDef("BC00199", "DELETE FROM [Calendario]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CalendarioCodigo] = @CalendarioCodigo", GxErrorMask.GX_NOMASK,prmBC00199)
             ,new CursorDef("BC001910", "SELECT TM1.[CalendarioCodigo], TM1.[CalendarioObs], TM1.[CalendarioInicio], TM1.[CalendarioFinal], TM1.[ClinicaCodigo], TM1.[PacienteId] FROM [Calendario] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[CalendarioCodigo] = @CalendarioCodigo ORDER BY TM1.[ClinicaCodigo], TM1.[CalendarioCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001910,100,0,true,false )
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
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
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
                stmt.SetParameter(2, (int)parms[1]);
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
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
