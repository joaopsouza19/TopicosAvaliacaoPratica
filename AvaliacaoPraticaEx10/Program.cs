// ./Program.cs
using System;

IReserva reservaRegular = new VooRegular();
reservaRegular.ReservarVoo("AA321", "01/05/2024", 1);
Console.WriteLine(reservaRegular.VerificarStatusReserva("AA321", "01/05/2024", 1));
reservaRegular.CancelarReserva("AA321", "01/05/2024", 1);

Console.WriteLine();

IReserva reservaComUpgrade = new VooUpgrade();
reservaComUpgrade.ReservarVoo("BB567", "02/05/2024", 2);
Console.WriteLine(reservaComUpgrade.VerificarStatusReserva("BB567", "02/05/2024", 2));
reservaComUpgrade.CancelarReserva("BB567", "02/05/2024", 2);

Console.WriteLine();

IReserva reservaGrupoGrande = new VooGrupoG();
reservaGrupoGrande.ReservarVoo("CC987", "03/05/2024", 3);
Console.WriteLine(reservaGrupoGrande.VerificarStatusReserva("CC987", "03/05/2024", 3));
reservaGrupoGrande.CancelarReserva("CC987", "03/05/2024", 3);