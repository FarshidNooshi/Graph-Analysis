import { Injectable } from '@angular/core';

@Injectable()
export class FilterService {
  public startDate: number;
  public endDate: number;
  public startTime: string;
  public endTime: string;
  public minAmount: number;
  public maxAmount: number;
  public accountTypes: string[] = [];
  public name: string;
  public branches: string[] = [];
  public sourceId: string = "";
  public targetId: string = "";

  public getNodeFilter(): string[] {
    let result = [];
    if (this.accountTypes.length != 0) {
      let accountTypesResult: string = `accountType eq`;
      for (let item of this.accountTypes) {
        accountTypesResult += ` ${item}`;
      }
      result.push(accountTypesResult);
    }

    if (this.name) {
      result.push(`ownerName cnt ${this.name}`);
    }

    if (this.branches.length !== 0) {
      console.log('hete')
      let branchResult: string = `branchName eq`;
      for (let item of this.branches) {
        branchResult += ` ${item}`;
      }
      result.push(branchResult);
    }


    return result;

  }
  public getEdgeFilter(): string[] {
    let result = [];
    if (this.startDate) {
      result.push(`date gte ${this.startDate}`);
    }

    if (this.endDate) {
      result.push(`date lte ${this.endDate}`);
    }

    if (this.startTime) {
      result.push(`time gte ${this.startTime}`);
    }

    if (this.endTime) {
      result.push(`time lte ${this.endTime}`);
    }

    if (this.minAmount) {
      result.push(`amount gte ${this.minAmount}`);
    }

    if (this.maxAmount) {
      result.push(`amount lte ${this.maxAmount}`);
    }

    return result;
  }

  public clearVars() {
  this.startDate = null;
  this.endDate = null;
  this.startTime= null;
  this.endTime= null;
  this.minAmount= null;
  this.maxAmount= null;
  this.accountTypes = [];
  this.name= null;
  this.branches= [];
}

}
