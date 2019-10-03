/*
               File: ListPrograms
        Description: List Programs
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:42.41
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class listprograms : GXProcedure
   {
      public listprograms( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public listprograms( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out IGxCollection aP0_ProgramNames )
      {
         this.AV10ProgramNames = new GxObjectCollection( context, "ProgramNames.ProgramName", "Clinica", "SdtProgramNames_ProgramName", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP0_ProgramNames=this.AV10ProgramNames;
      }

      public IGxCollection executeUdp( )
      {
         this.AV10ProgramNames = new GxObjectCollection( context, "ProgramNames.ProgramName", "Clinica", "SdtProgramNames_ProgramName", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP0_ProgramNames=this.AV10ProgramNames;
         return AV10ProgramNames ;
      }

      public void executeSubmit( out IGxCollection aP0_ProgramNames )
      {
         listprograms objlistprograms;
         objlistprograms = new listprograms();
         objlistprograms.AV10ProgramNames = new GxObjectCollection( context, "ProgramNames.ProgramName", "Clinica", "SdtProgramNames_ProgramName", "GeneXus.Programs") ;
         objlistprograms.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objlistprograms);
         aP0_ProgramNames=this.AV10ProgramNames;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((listprograms)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         AV10ProgramNames = new GxObjectCollection( context, "ProgramNames.ProgramName", "Clinica", "SdtProgramNames_ProgramName", "GeneXus.Programs") ;
         this.cleanup();
      }

      protected void S114( )
      {
         /* 'ADDPROGRAM' Routine */
         AV8IsAuthorized = true ;
         new isauthorized(context ).execute(  AV12name, out  AV8IsAuthorized) ;
         if ( AV8IsAuthorized )
         {
            AV11ProgramName = new SdtProgramNames_ProgramName(context) ;
            AV11ProgramName.gxTpr_Name = AV12name ;
            AV11ProgramName.gxTpr_Description = AV13description ;
            AV11ProgramName.gxTpr_Link = AV14link ;
            AV10ProgramNames.Add(AV11ProgramName, 0);
         }
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         AV12name = "" ;
         AV11ProgramName = new SdtProgramNames_ProgramName(context);
         AV13description = "" ;
         AV14link = "" ;
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private bool AV8IsAuthorized ;
      private String AV12name ;
      private String AV13description ;
      private String AV14link ;
      private IGxCollection aP0_ProgramNames ;
      [ObjectCollection(ItemType=typeof( SdtProgramNames_ProgramName ))]
      private IGxCollection AV10ProgramNames ;
      private SdtProgramNames_ProgramName AV11ProgramName ;
   }

}
