/*
               File: pCierreContable
        Description: Ejecuta Cierre Contable
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:58.23
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
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class pcierrecontable : GXProcedure
   {
      public pcierrecontable( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public pcierrecontable( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref short aP1_CierreMCAnio ,
                           ref short aP2_CierreMCMes )
      {
         this.AV8ClinicaCodigo = aP0_ClinicaCodigo;
         this.AV9CierreMCAnio = aP1_CierreMCAnio;
         this.AV10CierreMCMes = aP2_CierreMCMes;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.AV8ClinicaCodigo;
         aP1_CierreMCAnio=this.AV9CierreMCAnio;
         aP2_CierreMCMes=this.AV10CierreMCMes;
      }

      public short executeUdp( ref String aP0_ClinicaCodigo ,
                               ref short aP1_CierreMCAnio )
      {
         this.AV8ClinicaCodigo = aP0_ClinicaCodigo;
         this.AV9CierreMCAnio = aP1_CierreMCAnio;
         this.AV10CierreMCMes = aP2_CierreMCMes;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.AV8ClinicaCodigo;
         aP1_CierreMCAnio=this.AV9CierreMCAnio;
         aP2_CierreMCMes=this.AV10CierreMCMes;
         return AV10CierreMCMes ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref short aP1_CierreMCAnio ,
                                 ref short aP2_CierreMCMes )
      {
         pcierrecontable objpcierrecontable;
         objpcierrecontable = new pcierrecontable();
         objpcierrecontable.AV8ClinicaCodigo = aP0_ClinicaCodigo;
         objpcierrecontable.AV9CierreMCAnio = aP1_CierreMCAnio;
         objpcierrecontable.AV10CierreMCMes = aP2_CierreMCMes;
         objpcierrecontable.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpcierrecontable);
         aP0_ClinicaCodigo=this.AV8ClinicaCodigo;
         aP1_CierreMCAnio=this.AV9CierreMCAnio;
         aP2_CierreMCMes=this.AV10CierreMCMes;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pcierrecontable)stateInfo).executePrivate();
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
         AV11SQLString = " @ClinicaCodigo = '" + AV8ClinicaCodigo + "', @CierreMCAnio = '" + StringUtil.Trim( StringUtil.Str( (decimal)(AV9CierreMCAnio), 10, 0)) + "', @CierreMCMes = '" + StringUtil.Trim( StringUtil.Str( (decimal)(AV10CierreMCMes), 10, 0)) + "' " ;
         /* User SQL Command. */
         cmdBuffer = " execute SP_CierreMensualC " + AV11SQLString ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         context.CommitDataStores("pCierreContable");
         this.cleanup();
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
         AV11SQLString = "" ;
         cmdBuffer = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pcierrecontable__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV9CierreMCAnio ;
      private short AV10CierreMCMes ;
      private String cmdBuffer ;
      private String AV8ClinicaCodigo ;
      private String AV11SQLString ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private short aP1_CierreMCAnio ;
      private short aP2_CierreMCMes ;
      private GxCommand RGZ ;
      private IDataStoreProvider pr_default ;
   }

   public class pcierrecontable__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          def= new CursorDef[] {
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
