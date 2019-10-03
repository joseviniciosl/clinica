/*
               File: FacturaConversion
        Description: Conversion for table Factura
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:25.17
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
   public class facturaconversion : GXProcedure
   {
      public facturaconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public facturaconversion( IGxContext context )
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
         facturaconversion objfacturaconversion;
         objfacturaconversion = new facturaconversion();
         objfacturaconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objfacturaconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((facturaconversion)stateInfo).executePrivate();
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
         /* Using cursor FACTURACON2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A67PacienteId = FACTURACON2_A67PacienteId[0] ;
            A229FacturaCae2 = FACTURACON2_A229FacturaCae2[0] ;
            A192FacturaCae1 = FACTURACON2_A192FacturaCae1[0] ;
            A191FacturaIva = FACTURACON2_A191FacturaIva[0] ;
            A190FacturaSerie = FACTURACON2_A190FacturaSerie[0] ;
            A189FacturaDocto = FACTURACON2_A189FacturaDocto[0] ;
            A178ClienteCodigo = FACTURACON2_A178ClienteCodigo[0] ;
            A188FacturaEstado = FACTURACON2_A188FacturaEstado[0] ;
            A187FacturaHora = FACTURACON2_A187FacturaHora[0] ;
            A186FacturaFecha = FACTURACON2_A186FacturaFecha[0] ;
            A185FacturaId = FACTURACON2_A185FacturaId[0] ;
            A41ClinicaCodigo = FACTURACON2_A41ClinicaCodigo[0] ;
            A40000GXC1 = FACTURACON2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0049

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3FacturaId = A185FacturaId ;
            AV4FacturaFecha = A186FacturaFecha ;
            AV5FacturaHora = A187FacturaHora ;
            AV6FacturaEstado = A188FacturaEstado ;
            AV7ClienteCodigo = A178ClienteCodigo ;
            AV8FacturaDocto = A189FacturaDocto ;
            AV9FacturaSerie = A190FacturaSerie ;
            AV10FacturaIva = A191FacturaIva ;
            AV11FacturaCae1 = A192FacturaCae1 ;
            AV12FacturaCae2 = A229FacturaCae2 ;
            AV13PacienteId = A67PacienteId ;
            /* Using cursor FACTURACON3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3FacturaId, AV4FacturaFecha, AV5FacturaHora, AV6FacturaEstado, AV7ClienteCodigo, AV8FacturaDocto, AV9FacturaSerie, AV10FacturaIva, AV11FacturaCae1, AV12FacturaCae2, AV13PacienteId});
            pr_default.close(1);
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1 ;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate")) ;
            }
            else
            {
               context.Gx_err = 0 ;
               Gx_emsg = "" ;
            }
            /* End Insert */
            pr_default.readNext(0);
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
         FACTURACON2_A67PacienteId = new int[1] ;
         FACTURACON2_A229FacturaCae2 = new String[] {""} ;
         FACTURACON2_A192FacturaCae1 = new String[] {""} ;
         FACTURACON2_A191FacturaIva = new decimal[1] ;
         FACTURACON2_A190FacturaSerie = new String[] {""} ;
         FACTURACON2_A189FacturaDocto = new String[] {""} ;
         FACTURACON2_A178ClienteCodigo = new String[] {""} ;
         FACTURACON2_A188FacturaEstado = new short[1] ;
         FACTURACON2_A187FacturaHora = new String[] {""} ;
         FACTURACON2_A186FacturaFecha = new DateTime[] {DateTime.MinValue} ;
         FACTURACON2_A185FacturaId = new int[1] ;
         FACTURACON2_A41ClinicaCodigo = new String[] {""} ;
         FACTURACON2_A40000GXC1 = new int[1] ;
         A229FacturaCae2 = "" ;
         A192FacturaCae1 = "" ;
         A190FacturaSerie = "" ;
         A189FacturaDocto = "" ;
         A178ClienteCodigo = "" ;
         A187FacturaHora = "" ;
         A186FacturaFecha = DateTime.MinValue ;
         A41ClinicaCodigo = "" ;
         AV4FacturaFecha = DateTime.MinValue ;
         AV5FacturaHora = "" ;
         AV7ClienteCodigo = "" ;
         AV8FacturaDocto = "" ;
         AV9FacturaSerie = "" ;
         AV11FacturaCae1 = "" ;
         AV12FacturaCae2 = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.facturaconversion__default(),
            new Object[][] {
                new Object[] {
               FACTURACON2_A67PacienteId, FACTURACON2_A229FacturaCae2, FACTURACON2_A192FacturaCae1, FACTURACON2_A191FacturaIva, FACTURACON2_A190FacturaSerie, FACTURACON2_A189FacturaDocto, FACTURACON2_A178ClienteCodigo, FACTURACON2_A188FacturaEstado, FACTURACON2_A187FacturaHora, FACTURACON2_A186FacturaFecha,
               FACTURACON2_A185FacturaId, FACTURACON2_A41ClinicaCodigo, FACTURACON2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A188FacturaEstado ;
      private short AV6FacturaEstado ;
      private int A67PacienteId ;
      private int A185FacturaId ;
      private int A40000GXC1 ;
      private int GIGXA0049 ;
      private int AV2ClinicaCodigo ;
      private int AV3FacturaId ;
      private int AV13PacienteId ;
      private decimal A191FacturaIva ;
      private decimal AV10FacturaIva ;
      private String scmdbuf ;
      private String A187FacturaHora ;
      private String AV5FacturaHora ;
      private String Gx_emsg ;
      private DateTime A186FacturaFecha ;
      private DateTime AV4FacturaFecha ;
      private String A229FacturaCae2 ;
      private String A192FacturaCae1 ;
      private String A190FacturaSerie ;
      private String A189FacturaDocto ;
      private String A178ClienteCodigo ;
      private String A41ClinicaCodigo ;
      private String AV7ClienteCodigo ;
      private String AV8FacturaDocto ;
      private String AV9FacturaSerie ;
      private String AV11FacturaCae1 ;
      private String AV12FacturaCae2 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] FACTURACON2_A67PacienteId ;
      private String[] FACTURACON2_A229FacturaCae2 ;
      private String[] FACTURACON2_A192FacturaCae1 ;
      private decimal[] FACTURACON2_A191FacturaIva ;
      private String[] FACTURACON2_A190FacturaSerie ;
      private String[] FACTURACON2_A189FacturaDocto ;
      private String[] FACTURACON2_A178ClienteCodigo ;
      private short[] FACTURACON2_A188FacturaEstado ;
      private String[] FACTURACON2_A187FacturaHora ;
      private DateTime[] FACTURACON2_A186FacturaFecha ;
      private int[] FACTURACON2_A185FacturaId ;
      private String[] FACTURACON2_A41ClinicaCodigo ;
      private int[] FACTURACON2_A40000GXC1 ;
   }

   public class facturaconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmFACTURACON2 ;
          prmFACTURACON2 = new Object[] {
          } ;
          Object[] prmFACTURACON3 ;
          prmFACTURACON3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV4FacturaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV5FacturaHora",SqlDbType.Char,8,0} ,
          new Object[] {"@AV6FacturaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV7ClienteCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV8FacturaDocto",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV9FacturaSerie",SqlDbType.VarChar,20,0} ,
          new Object[] {"@AV10FacturaIva",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV11FacturaCae1",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@AV12FacturaCae2",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@AV13PacienteId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("FACTURACON2", "SELECT [PacienteId], [FacturaCae2], [FacturaCae1], [FacturaIva], [FacturaSerie], [FacturaDocto], [ClienteCodigo], [FacturaEstado], [FacturaHora], [FacturaFecha], [FacturaId], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [Factura] ORDER BY [ClinicaCodigo], [FacturaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmFACTURACON2,100,0,true,false )
             ,new CursorDef("FACTURACON3", "INSERT INTO [GXA0049] ([ClinicaCodigo], [FacturaId], [FacturaFecha], [FacturaHora], [FacturaEstado], [ClienteCodigo], [FacturaDocto], [FacturaSerie], [FacturaIva], [FacturaCae1], [FacturaCae2], [PacienteId]) VALUES (@AV2ClinicaCodigo, @AV3FacturaId, @AV4FacturaFecha, @AV5FacturaHora, @AV6FacturaEstado, @AV7ClienteCodigo, @AV8FacturaDocto, @AV9FacturaSerie, @AV10FacturaIva, @AV11FacturaCae1, @AV12FacturaCae2, @AV13PacienteId)", GxErrorMask.GX_NOMASK,prmFACTURACON3)
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
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((String[]) buf[8])[0] = rslt.getString(9, 8) ;
                ((DateTime[]) buf[9])[0] = rslt.getGXDate(10) ;
                ((int[]) buf[10])[0] = rslt.getInt(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((int[]) buf[12])[0] = rslt.getInt(13) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (decimal)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                stmt.SetParameter(11, (String)parms[10]);
                stmt.SetParameter(12, (int)parms[11]);
                break;
       }
    }

 }

}
