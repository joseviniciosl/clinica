/*
               File: CorteCajaConversion
        Description: Conversion for table CorteCaja
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:24.56
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
   public class cortecajaconversion : GXProcedure
   {
      public cortecajaconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public cortecajaconversion( IGxContext context )
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
         cortecajaconversion objcortecajaconversion;
         objcortecajaconversion = new cortecajaconversion();
         objcortecajaconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcortecajaconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((cortecajaconversion)stateInfo).executePrivate();
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
         /* Using cursor CORTECAJAC2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A4UsuarioCodigo = CORTECAJAC2_A4UsuarioCodigo[0] ;
            A155CorteCajaHora = CORTECAJAC2_A155CorteCajaHora[0] ;
            A154CorteCajaFecha = CORTECAJAC2_A154CorteCajaFecha[0] ;
            A153CorteCajaId = CORTECAJAC2_A153CorteCajaId[0] ;
            A132CajaCodigo = CORTECAJAC2_A132CajaCodigo[0] ;
            A41ClinicaCodigo = CORTECAJAC2_A41ClinicaCodigo[0] ;
            A40000GXC1 = CORTECAJAC2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0043

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3CajaCodigo = A132CajaCodigo ;
            AV4CorteCajaId = A153CorteCajaId ;
            AV5CorteCajaFecha = A154CorteCajaFecha ;
            AV6CorteCajaHora = A155CorteCajaHora ;
            AV7UsuarioCodigo = A4UsuarioCodigo ;
            /* Using cursor CORTECAJAC3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3CajaCodigo, AV4CorteCajaId, AV5CorteCajaFecha, AV6CorteCajaHora, AV7UsuarioCodigo});
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
         CORTECAJAC2_A4UsuarioCodigo = new String[] {""} ;
         CORTECAJAC2_A155CorteCajaHora = new String[] {""} ;
         CORTECAJAC2_A154CorteCajaFecha = new DateTime[] {DateTime.MinValue} ;
         CORTECAJAC2_A153CorteCajaId = new int[1] ;
         CORTECAJAC2_A132CajaCodigo = new String[] {""} ;
         CORTECAJAC2_A41ClinicaCodigo = new String[] {""} ;
         CORTECAJAC2_A40000GXC1 = new int[1] ;
         A4UsuarioCodigo = "" ;
         A155CorteCajaHora = "" ;
         A154CorteCajaFecha = DateTime.MinValue ;
         A132CajaCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3CajaCodigo = "" ;
         AV5CorteCajaFecha = DateTime.MinValue ;
         AV6CorteCajaHora = "" ;
         AV7UsuarioCodigo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cortecajaconversion__default(),
            new Object[][] {
                new Object[] {
               CORTECAJAC2_A4UsuarioCodigo, CORTECAJAC2_A155CorteCajaHora, CORTECAJAC2_A154CorteCajaFecha, CORTECAJAC2_A153CorteCajaId, CORTECAJAC2_A132CajaCodigo, CORTECAJAC2_A41ClinicaCodigo, CORTECAJAC2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int A153CorteCajaId ;
      private int A40000GXC1 ;
      private int GIGXA0043 ;
      private int AV2ClinicaCodigo ;
      private int AV4CorteCajaId ;
      private String scmdbuf ;
      private String A155CorteCajaHora ;
      private String AV6CorteCajaHora ;
      private String Gx_emsg ;
      private DateTime A154CorteCajaFecha ;
      private DateTime AV5CorteCajaFecha ;
      private String A4UsuarioCodigo ;
      private String A132CajaCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3CajaCodigo ;
      private String AV7UsuarioCodigo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] CORTECAJAC2_A4UsuarioCodigo ;
      private String[] CORTECAJAC2_A155CorteCajaHora ;
      private DateTime[] CORTECAJAC2_A154CorteCajaFecha ;
      private int[] CORTECAJAC2_A153CorteCajaId ;
      private String[] CORTECAJAC2_A132CajaCodigo ;
      private String[] CORTECAJAC2_A41ClinicaCodigo ;
      private int[] CORTECAJAC2_A40000GXC1 ;
   }

   public class cortecajaconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmCORTECAJAC2 ;
          prmCORTECAJAC2 = new Object[] {
          } ;
          Object[] prmCORTECAJAC3 ;
          prmCORTECAJAC3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4CorteCajaId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV5CorteCajaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV6CorteCajaHora",SqlDbType.Char,8,0} ,
          new Object[] {"@AV7UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("CORTECAJAC2", "SELECT [UsuarioCodigo], [CorteCajaHora], [CorteCajaFecha], [CorteCajaId], [CajaCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [CorteCaja] ORDER BY [ClinicaCodigo], [CajaCodigo], [CorteCajaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCORTECAJAC2,100,0,true,false )
             ,new CursorDef("CORTECAJAC3", "INSERT INTO [GXA0043] ([ClinicaCodigo], [CajaCodigo], [CorteCajaId], [CorteCajaFecha], [CorteCajaHora], [UsuarioCodigo]) VALUES (@AV2ClinicaCodigo, @AV3CajaCodigo, @AV4CorteCajaId, @AV5CorteCajaFecha, @AV6CorteCajaHora, @AV7UsuarioCodigo)", GxErrorMask.GX_NOMASK,prmCORTECAJAC3)
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
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
       }
    }

 }

}
