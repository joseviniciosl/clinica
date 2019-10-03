/*
               File: UnidadMedidaConversion
        Description: Conversion for table UnidadMedida
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 9/24/2019 12:38:17.57
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
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
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class unidadmedidaconversion : GXProcedure
   {
      public unidadmedidaconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public unidadmedidaconversion( IGxContext context )
      {
         this.DisconnectAtCleanup = true;
         context = context.UtlClone();
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         unidadmedidaconversion objunidadmedidaconversion;
         objunidadmedidaconversion = new unidadmedidaconversion();
         objunidadmedidaconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objunidadmedidaconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((unidadmedidaconversion)stateInfo).executePrivate();
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
         /* Optimized copy (Insert w/Subselect). */
         /* Using cursor UNIDADMEDI2 */
         pr_default.execute(0);
         pr_default.close(0);
         /* End optimized group. */
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.unidadmedidaconversion__default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
   }

   public class unidadmedidaconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmUNIDADMEDI2 ;
          prmUNIDADMEDI2 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("UNIDADMEDI2", "INSERT INTO [GXA0078] ([ClinicaCodigo], [UnidadMedidaCodigo], [UnidadMedidaDescripcion]) SELECT [ClinicaCodigo], [UnidadMedidaCodigo], [UnidadMedidaDescripcion]  FROM [UnidadMedida]", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmUNIDADMEDI2)
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
