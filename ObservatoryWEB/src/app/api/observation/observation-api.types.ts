export interface ObservationDto {
  name: string;
  sceduledTime: Date;
  spaceObjectId: number;
  equipmentId: number;
  userId: number;
}

export interface Observation {
  id: number;
  name: string;
  description: string;
  properties: string;
  sceduledTime: Date;
  spaceObjectId: number;
  equipmentId: number;
}
