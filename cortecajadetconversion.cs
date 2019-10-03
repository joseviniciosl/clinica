/*
               File: CorteCajaDetConversion
        Description: Conversion for table CorteCajaDet
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:24.64
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
   public class cortecajadetconversion : GXProcedure
   {
      public cortecajadetconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public cortecajadetconversion( IGxContext context )
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
         cortecajadetconversion objcortecajadetconversion;
         objcortecajadetconversion = new cortecajadetconversion();
         objcortecajadetconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcortecajadetconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((cortecajadetconversion)stateInfo).executePrivate();
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
         /* Using cursor CORTECAJAD2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A156CorteCajaValor = CORTECAJAD2_A156CorteCajaValor[0] ;
            A65FormaPagoCodigo = CORTECAJAD2_A65FormaPagoCodigo[0] ;
            A153CorteCajaId = CORTECAJAD2_A153CorteCajaId[0] ;
            A132CajaCodigo = CORTECAJAD2_A132CajaCodigo[0] ;
            A41ClinicaCodigo = CORTECAJAD2_A41ClinicaCodigo[0] ;
            A40000GXC1 = CORTECAJAD2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0044

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3CajaCodigo = A132CajaCodigo ;
            AV4CorteCajaId = A153CorteCajaId ;
            AV5FormaPagoCodigo = A65FormaPagoCodigo ;
            AV6CorteCajaValor = A156CorteCajaValor ;
            /* Using cursor CORTECAJAD3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3CajaCodigo, AV4CorteCajaId, AV5FormaPagoCodigo, AV6CorteCajaValor});
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
         CORTECAJAD2_A156CorteCajaValor = new decimal[1] ;
         CORTECAJAD2_A65FormaPagoCodigo = new String[] {""} ;
         CORTECAJAD2_A153CorteCajaId = new int[1] ;
         CORTECAJAD2_A132CajaCodigo = new String[] {""} ;
         CORTECAJAD2_A41ClinicaCodigo = new String[] {""} ;
         CORTECAJAD2_A40000GXC1 = new int[1] ;
         A65FormaPagoCodigo = "" ;
         A132CajaCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3CajaCodigo = "" ;
         AV5FormaPagoCodigo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cortecajadetconversion__default(),
            new Object[][] {
                new Object[] {
               CORTECAJAD2_A156CorteCajaValor, CORTECAJAD2_A65FormaPagoCodigo, CORTECAJAD2_A153CorteCajaId, CORTECAJAD2_A132CajaCodigo, CORTECAJAD2_A41ClinicaCodigo, CORTECAJAD2_A40000GXC1
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
      private int GIGXA0044 ;
      private int AV2ClinicaCodigo ;
      private int AV4CorteCajaId ;
      private decimal A156CorteCajaValor ;
      private decimal AV6CorteCajaValor ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A65FormaPagoCodigo ;
      private String A132CajaCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3CajaCodigo ;
      private String AV5FormaPagoCodigo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private decimal[] CORTECAJAD2_A156CorteCajaValor ;
      private String[] CORTECAJAD2_A65FormaPagoCodigo ;
      private int[] CORTECAJAD2_A153CorteCajaId ;
      private String[] CORTECAJAD2_A132CajaCodigo ;
      private String[] CORTECAJAD2_A41ClinicaCodigo ;
      private int[] CORTECAJAD2_A40000GXC1 ;
   }

   public class cortecajadetconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmCORTECAJAD2 ;
          prmCORTECAJAD2 = new Object[] {
          } ;
          Object[] prmCORTECAJAD3 ;
          prmCORTECAJAD3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4CorteCajaId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV5FormaPagoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV6CorteCajaValor",SqlDbType.Decimal,17,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("CORTECAJAD2", "SELECT [CorteCajaValor], [FormaPagoCodigo], [CorteCajaId], [CajaCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [CorteCajaDet] ORDER BY [ClinicaCodigo], [CajaCodigo], [CorteCajaId], [FormaPagoCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCORTECAJAD2,100,0,true,false )
             ,new CursorDef("CORTECAJAD3", "INSERT INTO [GXA0044] ([ClinicaCodigo], [CajaCodigo], [CorteCajaId], [FormaPagoCodigo], [CorteCajaValor]) VALUES (@AV2ClinicaCodigo, @AV3CajaCodigo, @AV4CorteCajaId, @AV5FormaPagoCodigo, @AV6CorteCajaValor)", GxErrorMask.GX_NOMASK,prmCORTECAJAD3)
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
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
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
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                break;
       }
    }

 }

}
