namespace PRELIM_E3_MadarangJanWilliam_BSIT32E3.Models

open System

type ErrorViewModel =
    { RequestId: string }

    member this.ShowRequestId =
        not (String.IsNullOrEmpty(this.RequestId))
