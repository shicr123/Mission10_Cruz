export type crew = {
    bowlerId: number;
    bowlerFirstName: string;
    bowlerMiddleInit: string | null;
    bowlerLastName: string;
    bowlerAddress: string;
    bowlerCity: string;
    bowlerState: string;
    bowlerZip: string;
    bowlerPhoneNumber: string;
    teamId: number;
    team: {
      // Add this part
      teamId: number;
      teamName: string;
    } | null; // Ensure this part is nullable in case there is no team
  };
  