/*
               File: pEliminaFacturaPago
        Description: Elimina Forma de Pago de Factura
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:47.5
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
   public class peliminafacturapago : GXProcedure
   {
      public peliminafacturapago( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public peliminafacturapago( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref int aP1_FacturaId ,
                           ref int aP2_FacturaPId )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A185FacturaId = aP1_FacturaId;
         this.AV9FacturaPId = aP2_FacturaPId;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_FacturaId=this.A185FacturaId;
         aP2_FacturaPId=this.AV9FacturaPId;
      }

      public int executeUdp( ref String aP0_ClinicaCodigo ,
                             ref int aP1_FacturaId )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A185FacturaId = aP1_FacturaId;
         this.AV9FacturaPId = aP2_FacturaPId;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_FacturaId=this.A185FacturaId;
         aP2_FacturaPId=this.AV9FacturaPId;
         return AV9FacturaPId ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref int aP1_FacturaId ,
                                 ref int aP2_FacturaPId )
      {
         peliminafacturapago objpeliminafacturapago;
         objpeliminafacturapago = new peliminafacturapago();
         objpeliminafacturapago.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objpeliminafacturapago.A185FacturaId = aP1_FacturaId;
         objpeliminafacturapago.AV9FacturaPId = aP2_FacturaPId;
         objpeliminafacturapago.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpeliminafacturapago);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_FacturaId=this.A185FacturaId;
         aP2_FacturaPId=this.AV9FacturaPId;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((peliminafacturapago)stateInfo).executePrivate();
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
         /* Optimized DELETE. */
         /* Using cursor P000S2 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A185FacturaId, AV9FacturaPId});
         pr_default.close(0);
         /* End optimized DELETE. */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("pEliminaFacturaPago");
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.peliminafacturapago__default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int A185FacturaId ;
      private int AV9FacturaPId ;
      private String A41ClinicaCodigo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private int aP1_FacturaId ;
      private int aP2_FacturaPId ;
      private IDataStoreProvider pr_default ;
   }

   public class peliminafacturapago__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000S2 ;
          prmP000S2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV9FacturaPId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000S2", "DELETE FROM [FacturaPago]  WHERE [ClinicaCodigo] = @ClinicaCodigo and [FacturaId] = @FacturaId and [FacturaPId] = @AV9FacturaPId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000S2)
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
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
       }
    }

 }

}
