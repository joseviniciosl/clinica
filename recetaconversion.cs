/*
               File: RecetaConversion
        Description: Conversion for table Receta
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:26.5
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
   public class recetaconversion : GXProcedure
   {
      public recetaconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public recetaconversion( IGxContext context )
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
         recetaconversion objrecetaconversion;
         objrecetaconversion = new recetaconversion();
         objrecetaconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objrecetaconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((recetaconversion)stateInfo).executePrivate();
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
         /* Using cursor RECETACONV2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A112RecetaObs = RECETACONV2_A112RecetaObs[0] ;
            A111RecetaHora = RECETACONV2_A111RecetaHora[0] ;
            A110RecetaFecha = RECETACONV2_A110RecetaFecha[0] ;
            A109RecetaId = RECETACONV2_A109RecetaId[0] ;
            A91ConsultaId = RECETACONV2_A91ConsultaId[0] ;
            A41ClinicaCodigo = RECETACONV2_A41ClinicaCodigo[0] ;
            A40000GXC1 = RECETACONV2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0027

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3ConsultaId = A91ConsultaId ;
            AV4RecetaId = A109RecetaId ;
            AV5RecetaFecha = A110RecetaFecha ;
            AV6RecetaHora = A111RecetaHora ;
            AV7RecetaObs = A112RecetaObs ;
            /* Using cursor RECETACONV3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3ConsultaId, AV4RecetaId, AV5RecetaFecha, AV6RecetaHora, AV7RecetaObs});
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
         RECETACONV2_A112RecetaObs = new String[] {""} ;
         RECETACONV2_A111RecetaHora = new String[] {""} ;
         RECETACONV2_A110RecetaFecha = new DateTime[] {DateTime.MinValue} ;
         RECETACONV2_A109RecetaId = new int[1] ;
         RECETACONV2_A91ConsultaId = new int[1] ;
         RECETACONV2_A41ClinicaCodigo = new String[] {""} ;
         RECETACONV2_A40000GXC1 = new int[1] ;
         A112RecetaObs = "" ;
         A111RecetaHora = "" ;
         A110RecetaFecha = DateTime.MinValue ;
         A41ClinicaCodigo = "" ;
         AV5RecetaFecha = DateTime.MinValue ;
         AV6RecetaHora = "" ;
         AV7RecetaObs = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.recetaconversion__default(),
            new Object[][] {
                new Object[] {
               RECETACONV2_A112RecetaObs, RECETACONV2_A111RecetaHora, RECETACONV2_A110RecetaFecha, RECETACONV2_A109RecetaId, RECETACONV2_A91ConsultaId, RECETACONV2_A41ClinicaCodigo, RECETACONV2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int A109RecetaId ;
      private int A91ConsultaId ;
      private int A40000GXC1 ;
      private int GIGXA0027 ;
      private int AV2ClinicaCodigo ;
      private int AV3ConsultaId ;
      private int AV4RecetaId ;
      private String scmdbuf ;
      private String A111RecetaHora ;
      private String AV6RecetaHora ;
      private String Gx_emsg ;
      private DateTime A110RecetaFecha ;
      private DateTime AV5RecetaFecha ;
      private String A112RecetaObs ;
      private String A41ClinicaCodigo ;
      private String AV7RecetaObs ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] RECETACONV2_A112RecetaObs ;
      private String[] RECETACONV2_A111RecetaHora ;
      private DateTime[] RECETACONV2_A110RecetaFecha ;
      private int[] RECETACONV2_A109RecetaId ;
      private int[] RECETACONV2_A91ConsultaId ;
      private String[] RECETACONV2_A41ClinicaCodigo ;
      private int[] RECETACONV2_A40000GXC1 ;
   }

   public class recetaconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmRECETACONV2 ;
          prmRECETACONV2 = new Object[] {
          } ;
          Object[] prmRECETACONV3 ;
          prmRECETACONV3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV4RecetaId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV5RecetaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV6RecetaHora",SqlDbType.Char,8,0} ,
          new Object[] {"@AV7RecetaObs",SqlDbType.VarChar,600,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("RECETACONV2", "SELECT [RecetaObs], [RecetaHora], [RecetaFecha], [RecetaId], [ConsultaId], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [Receta] ORDER BY [ClinicaCodigo], [ConsultaId], [RecetaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmRECETACONV2,100,0,true,false )
             ,new CursorDef("RECETACONV3", "INSERT INTO [GXA0027] ([ClinicaCodigo], [ConsultaId], [RecetaId], [RecetaFecha], [RecetaHora], [RecetaObs]) VALUES (@AV2ClinicaCodigo, @AV3ConsultaId, @AV4RecetaId, @AV5RecetaFecha, @AV6RecetaHora, @AV7RecetaObs)", GxErrorMask.GX_NOMASK,prmRECETACONV3)
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
                ((String[]) buf[1])[0] = rslt.getString(2, 8) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
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
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
       }
    }

 }

}
