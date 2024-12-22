import { instance } from '../instance';
import {
  ObservationOrder,
  ObservationOrderDto,
} from './observation-order-api.types';

class ObservationOrderApi {
  static async getAll() {
    return await instance.get<ObservationOrder[]>('/ObservationOrder/GetAll');
  }

  async getObservationOrderById(id: number) {
    return await instance.get<ObservationOrder>(`/ObservationOrder/GetById`, {
      params: { id },
    });
  }

  async createObservationOrder(body: ObservationOrderDto) {
    return await instance.post<ObservationOrder>('/ObservationOrder/add', body);
  }

  async updateObservationOrder(id: number, body: ObservationOrderDto) {
    return await instance.put(`/ObservationOrder/Update`, body, {
      params: { id },
    });
  }

  async deleteObservationOrder(id: number) {
    return await instance.delete<string>(`/ObservationOrder/Delete`, {
      params: { id },
    });
  }
}

export const observationOrderApi = new ObservationOrderApi();
