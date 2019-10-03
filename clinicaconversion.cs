/*
               File: ClinicaConversion
        Description: Conversion for table Clinica
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:23.97
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
   public class clinicaconversion : GXProcedure
   {
      public clinicaconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public clinicaconversion( IGxContext context )
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
         clinicaconversion objclinicaconversion;
         objclinicaconversion = new clinicaconversion();
         objclinicaconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objclinicaconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((clinicaconversion)stateInfo).executePrivate();
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
         /* Using cursor CLINICACON2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A206ClinicaIva = CLINICACON2_A206ClinicaIva[0] ;
            A49ClinicaPropietario = CLINICACON2_A49ClinicaPropietario[0] ;
            A48ClinicaZona = CLINICACON2_A48ClinicaZona[0] ;
            A39MunCodigo = CLINICACON2_A39MunCodigo[0] ;
            A37DepCodigo = CLINICACON2_A37DepCodigo[0] ;
            A35PaisCodigo = CLINICACON2_A35PaisCodigo[0] ;
            A47ClinicaDireccion = CLINICACON2_A47ClinicaDireccion[0] ;
            A46ClinicaCorreo = CLINICACON2_A46ClinicaCorreo[0] ;
            A45ClinicaTelefono2 = CLINICACON2_A45ClinicaTelefono2[0] ;
            A44ClinicaTelefono1 = CLINICACON2_A44ClinicaTelefono1[0] ;
            A43ClinicaNit = CLINICACON2_A43ClinicaNit[0] ;
            A42ClinicaNombre = CLINICACON2_A42ClinicaNombre[0] ;
            A41ClinicaCodigo = CLINICACON2_A41ClinicaCodigo[0] ;
            A40000GXC1 = CLINICACON2_A40000GXC1[0] ;
            A53ClinicaLogo = CLINICACON2_A53ClinicaLogo[0] ;
            /*
               INSERT RECORD ON TABLE GXA0016

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3ClinicaNombre = A42ClinicaNombre ;
            AV4ClinicaNit = A43ClinicaNit ;
            AV5ClinicaTelefono1 = A44ClinicaTelefono1 ;
            AV6ClinicaTelefono2 = A45ClinicaTelefono2 ;
            AV7ClinicaCorreo = A46ClinicaCorreo ;
            AV8ClinicaDireccion = A47ClinicaDireccion ;
            AV9PaisCodigo = A35PaisCodigo ;
            AV10DepCodigo = A37DepCodigo ;
            AV11MunCodigo = A39MunCodigo ;
            AV12ClinicaZona = A48ClinicaZona ;
            AV13ClinicaPropietario = A49ClinicaPropietario ;
            AV14ClinicaLogo = A53ClinicaLogo ;
            AV15ClinicaIva = A206ClinicaIva ;
            /* Using cursor CLINICACON3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3ClinicaNombre, AV4ClinicaNit, AV5ClinicaTelefono1, AV6ClinicaTelefono2, AV7ClinicaCorreo, AV8ClinicaDireccion, AV9PaisCodigo, AV10DepCodigo, AV11MunCodigo, AV12ClinicaZona, AV13ClinicaPropietario, AV14ClinicaLogo, AV15ClinicaIva});
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
         CLINICACON2_A206ClinicaIva = new decimal[1] ;
         CLINICACON2_A49ClinicaPropietario = new String[] {""} ;
         CLINICACON2_A48ClinicaZona = new short[1] ;
         CLINICACON2_A39MunCodigo = new String[] {""} ;
         CLINICACON2_A37DepCodigo = new String[] {""} ;
         CLINICACON2_A35PaisCodigo = new String[] {""} ;
         CLINICACON2_A47ClinicaDireccion = new String[] {""} ;
         CLINICACON2_A46ClinicaCorreo = new String[] {""} ;
         CLINICACON2_A45ClinicaTelefono2 = new String[] {""} ;
         CLINICACON2_A44ClinicaTelefono1 = new String[] {""} ;
         CLINICACON2_A43ClinicaNit = new String[] {""} ;
         CLINICACON2_A42ClinicaNombre = new String[] {""} ;
         CLINICACON2_A41ClinicaCodigo = new String[] {""} ;
         CLINICACON2_A40000GXC1 = new int[1] ;
         CLINICACON2_A53ClinicaLogo = new String[] {""} ;
         A49ClinicaPropietario = "" ;
         A39MunCodigo = "" ;
         A37DepCodigo = "" ;
         A35PaisCodigo = "" ;
         A47ClinicaDireccion = "" ;
         A46ClinicaCorreo = "" ;
         A45ClinicaTelefono2 = "" ;
         A44ClinicaTelefono1 = "" ;
         A43ClinicaNit = "" ;
         A42ClinicaNombre = "" ;
         A41ClinicaCodigo = "" ;
         A53ClinicaLogo = "" ;
         AV3ClinicaNombre = "" ;
         AV4ClinicaNit = "" ;
         AV5ClinicaTelefono1 = "" ;
         AV6ClinicaTelefono2 = "" ;
         AV7ClinicaCorreo = "" ;
         AV8ClinicaDireccion = "" ;
         AV9PaisCodigo = "" ;
         AV10DepCodigo = "" ;
         AV11MunCodigo = "" ;
         AV13ClinicaPropietario = "" ;
         AV14ClinicaLogo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.clinicaconversion__default(),
            new Object[][] {
                new Object[] {
               CLINICACON2_A206ClinicaIva, CLINICACON2_A49ClinicaPropietario, CLINICACON2_A48ClinicaZona, CLINICACON2_A39MunCodigo, CLINICACON2_A37DepCodigo, CLINICACON2_A35PaisCodigo, CLINICACON2_A47ClinicaDireccion, CLINICACON2_A46ClinicaCorreo, CLINICACON2_A45ClinicaTelefono2, CLINICACON2_A44ClinicaTelefono1,
               CLINICACON2_A43ClinicaNit, CLINICACON2_A42ClinicaNombre, CLINICACON2_A41ClinicaCodigo, CLINICACON2_A40000GXC1, CLINICACON2_A53ClinicaLogo
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A48ClinicaZona ;
      private short AV12ClinicaZona ;
      private int A40000GXC1 ;
      private int GIGXA0016 ;
      private int AV2ClinicaCodigo ;
      private decimal A206ClinicaIva ;
      private decimal AV15ClinicaIva ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A49ClinicaPropietario ;
      private String A39MunCodigo ;
      private String A37DepCodigo ;
      private String A35PaisCodigo ;
      private String A47ClinicaDireccion ;
      private String A46ClinicaCorreo ;
      private String A45ClinicaTelefono2 ;
      private String A44ClinicaTelefono1 ;
      private String A43ClinicaNit ;
      private String A42ClinicaNombre ;
      private String A41ClinicaCodigo ;
      private String AV3ClinicaNombre ;
      private String AV4ClinicaNit ;
      private String AV5ClinicaTelefono1 ;
      private String AV6ClinicaTelefono2 ;
      private String AV7ClinicaCorreo ;
      private String AV8ClinicaDireccion ;
      private String AV9PaisCodigo ;
      private String AV10DepCodigo ;
      private String AV11MunCodigo ;
      private String AV13ClinicaPropietario ;
      private String A53ClinicaLogo ;
      private String AV14ClinicaLogo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private decimal[] CLINICACON2_A206ClinicaIva ;
      private String[] CLINICACON2_A49ClinicaPropietario ;
      private short[] CLINICACON2_A48ClinicaZona ;
      private String[] CLINICACON2_A39MunCodigo ;
      private String[] CLINICACON2_A37DepCodigo ;
      private String[] CLINICACON2_A35PaisCodigo ;
      private String[] CLINICACON2_A47ClinicaDireccion ;
      private String[] CLINICACON2_A46ClinicaCorreo ;
      private String[] CLINICACON2_A45ClinicaTelefono2 ;
      private String[] CLINICACON2_A44ClinicaTelefono1 ;
      private String[] CLINICACON2_A43ClinicaNit ;
      private String[] CLINICACON2_A42ClinicaNombre ;
      private String[] CLINICACON2_A41ClinicaCodigo ;
      private int[] CLINICACON2_A40000GXC1 ;
      private String[] CLINICACON2_A53ClinicaLogo ;
   }

   public class clinicaconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmCLINICACON2 ;
          prmCLINICACON2 = new Object[] {
          } ;
          Object[] prmCLINICACON3 ;
          prmCLINICACON3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3ClinicaNombre",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV4ClinicaNit",SqlDbType.VarChar,20,0} ,
          new Object[] {"@AV5ClinicaTelefono1",SqlDbType.VarChar,9,0} ,
          new Object[] {"@AV6ClinicaTelefono2",SqlDbType.VarChar,9,0} ,
          new Object[] {"@AV7ClinicaCorreo",SqlDbType.VarChar,80,0} ,
          new Object[] {"@AV8ClinicaDireccion",SqlDbType.VarChar,80,0} ,
          new Object[] {"@AV9PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV10DepCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV11MunCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV12ClinicaZona",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13ClinicaPropietario",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV14ClinicaLogo",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@AV15ClinicaIva",SqlDbType.Decimal,17,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("CLINICACON2", "SELECT [ClinicaIva], [ClinicaPropietario], [ClinicaZona], [MunCodigo], [DepCodigo], [PaisCodigo], [ClinicaDireccion], [ClinicaCorreo], [ClinicaTelefono2], [ClinicaTelefono1], [ClinicaNit], [ClinicaNombre], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1, [ClinicaLogo] FROM [Clinica] ORDER BY [ClinicaCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCLINICACON2,1,0,true,false )
             ,new CursorDef("CLINICACON3", "INSERT INTO [GXA0016] ([ClinicaCodigo], [ClinicaNombre], [ClinicaNit], [ClinicaTelefono1], [ClinicaTelefono2], [ClinicaCorreo], [ClinicaDireccion], [PaisCodigo], [DepCodigo], [MunCodigo], [ClinicaZona], [ClinicaPropietario], [ClinicaLogo], [ClinicaIva]) VALUES (@AV2ClinicaCodigo, @AV3ClinicaNombre, @AV4ClinicaNit, @AV5ClinicaTelefono1, @AV6ClinicaTelefono2, @AV7ClinicaCorreo, @AV8ClinicaDireccion, @AV9PaisCodigo, @AV10DepCodigo, @AV11MunCodigo, @AV12ClinicaZona, @AV13ClinicaPropietario, @AV14ClinicaLogo, @AV15ClinicaIva)", GxErrorMask.GX_NOMASK,prmCLINICACON3)
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((int[]) buf[13])[0] = rslt.getInt(14) ;
                ((String[]) buf[14])[0] = rslt.getBLOBFile(15, "JPG", "") ;
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
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                stmt.SetParameter(11, (short)parms[10]);
                stmt.SetParameter(12, (String)parms[11]);
                stmt.SetParameter(13, (String)parms[12]);
                stmt.SetParameter(14, (decimal)parms[13]);
                break;
       }
    }

 }

}
