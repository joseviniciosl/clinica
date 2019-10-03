/*
               File: ArticuloConversion
        Description: Conversion for table Articulo
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 9/24/2019 12:38:13.80
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
   public class articuloconversion : GXProcedure
   {
      public articuloconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public articuloconversion( IGxContext context )
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
         articuloconversion objarticuloconversion;
         objarticuloconversion = new articuloconversion();
         objarticuloconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objarticuloconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((articuloconversion)stateInfo).executePrivate();
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
         /* Using cursor ARTICULOCO2 */
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.articuloconversion__default(),
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

   public class articuloconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmARTICULOCO2 ;
          prmARTICULOCO2 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("ARTICULOCO2", "INSERT INTO [GXA0012] ([ClinicaCodigo], [ArticuloCodigo], [ArticuloDescripcion], [ArticuloPrecio], [ArticuloCosto], [CategoriaCodigo], [SubCategoriaCodigo], [ArticuloTipo], [ArticuloEstado], [UnidadMedidaCodigo]) SELECT [ClinicaCodigo], [ArticuloCodigo], [ArticuloDescripcion], [ArticuloPrecio], [ArticuloCosto], [CategoriaCodigo], [SubCategoriaCodigo], [ArticuloTipo], [ArticuloEstado], [UnidadMedidaCodigo]  FROM [Articulo]", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmARTICULOCO2)
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
