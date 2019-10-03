/*
               File: pValidaPagoFactura
        Description: Valida Pago Total de la Factura
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:46.23
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
   public class pvalidapagofactura : GXProcedure
   {
      public pvalidapagofactura( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public pvalidapagofactura( IGxContext context )
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
                           ref short aP2_Flag )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A185FacturaId = aP1_FacturaId;
         this.AV8Flag = aP2_Flag;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_FacturaId=this.A185FacturaId;
         aP2_Flag=this.AV8Flag;
      }

      public short executeUdp( ref String aP0_ClinicaCodigo ,
                               ref int aP1_FacturaId )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A185FacturaId = aP1_FacturaId;
         this.AV8Flag = aP2_Flag;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_FacturaId=this.A185FacturaId;
         aP2_Flag=this.AV8Flag;
         return AV8Flag ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref int aP1_FacturaId ,
                                 ref short aP2_Flag )
      {
         pvalidapagofactura objpvalidapagofactura;
         objpvalidapagofactura = new pvalidapagofactura();
         objpvalidapagofactura.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objpvalidapagofactura.A185FacturaId = aP1_FacturaId;
         objpvalidapagofactura.AV8Flag = aP2_Flag;
         objpvalidapagofactura.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpvalidapagofactura);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_FacturaId=this.A185FacturaId;
         aP2_Flag=this.AV8Flag;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pvalidapagofactura)stateInfo).executePrivate();
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
         /* Using cursor P000Q4 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A185FacturaId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A188FacturaEstado = P000Q4_A188FacturaEstado[0] ;
            A263FacturaPago = P000Q4_A263FacturaPago[0] ;
            n263FacturaPago = P000Q4_n263FacturaPago[0] ;
            A247FacturaTotal = P000Q4_A247FacturaTotal[0] ;
            n247FacturaTotal = P000Q4_n247FacturaTotal[0] ;
            A263FacturaPago = P000Q4_A263FacturaPago[0] ;
            n263FacturaPago = P000Q4_n263FacturaPago[0] ;
            A247FacturaTotal = P000Q4_A247FacturaTotal[0] ;
            n247FacturaTotal = P000Q4_n247FacturaTotal[0] ;
            if ( A247FacturaTotal == A263FacturaPago )
            {
               AV8Flag = 1 ;
            }
            else
            {
               AV8Flag = 0 ;
            }
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
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
         scmdbuf = "" ;
         P000Q4_A41ClinicaCodigo = new String[] {""} ;
         P000Q4_A185FacturaId = new int[1] ;
         P000Q4_A188FacturaEstado = new short[1] ;
         P000Q4_A263FacturaPago = new decimal[1] ;
         P000Q4_n263FacturaPago = new bool[] {false} ;
         P000Q4_A247FacturaTotal = new decimal[1] ;
         P000Q4_n247FacturaTotal = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pvalidapagofactura__default(),
            new Object[][] {
                new Object[] {
               P000Q4_A41ClinicaCodigo, P000Q4_A185FacturaId, P000Q4_A188FacturaEstado, P000Q4_A263FacturaPago, P000Q4_n263FacturaPago, P000Q4_A247FacturaTotal, P000Q4_n247FacturaTotal
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV8Flag ;
      private short A188FacturaEstado ;
      private int A185FacturaId ;
      private decimal A263FacturaPago ;
      private decimal A247FacturaTotal ;
      private String scmdbuf ;
      private bool n263FacturaPago ;
      private bool n247FacturaTotal ;
      private String A41ClinicaCodigo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private int aP1_FacturaId ;
      private short aP2_Flag ;
      private IDataStoreProvider pr_default ;
      private String[] P000Q4_A41ClinicaCodigo ;
      private int[] P000Q4_A185FacturaId ;
      private short[] P000Q4_A188FacturaEstado ;
      private decimal[] P000Q4_A263FacturaPago ;
      private bool[] P000Q4_n263FacturaPago ;
      private decimal[] P000Q4_A247FacturaTotal ;
      private bool[] P000Q4_n247FacturaTotal ;
   }

   public class pvalidapagofactura__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000Q4 ;
          prmP000Q4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000Q4", "SELECT T1.[ClinicaCodigo], T1.[FacturaId], T1.[FacturaEstado], COALESCE( T2.[FacturaPago], 0) AS FacturaPago, COALESCE( T3.[FacturaTotal], 0) AS FacturaTotal FROM (([Factura] T1 WITH (NOLOCK) LEFT JOIN (SELECT SUM([FacturaPMonto]) AS FacturaPago, [ClinicaCodigo], [FacturaId] FROM [FacturaPago] WITH (NOLOCK) GROUP BY [ClinicaCodigo], [FacturaId] ) T2 ON T2.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T2.[FacturaId] = T1.[FacturaId]) LEFT JOIN (SELECT SUM([FacturaDPrecio] * CAST([FacturaDCantidad] AS decimal( 22, 5))) AS FacturaTotal, [ClinicaCodigo], [FacturaId] FROM [FacturaDetalle] WITH (NOLOCK) GROUP BY [ClinicaCodigo], [FacturaId] ) T3 ON T3.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T3.[FacturaId] = T1.[FacturaId]) WHERE T1.[ClinicaCodigo] = @ClinicaCodigo and T1.[FacturaId] = @FacturaId ORDER BY T1.[ClinicaCodigo], T1.[FacturaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000Q4,1,0,false,true )
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
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
       }
    }

 }

}
