﻿namespace NSaga
{
    public interface IPipelineHook
    {
        /// <summary>
        /// Hook executed before the saga have been initialised
        /// </summary>
        /// <param name="context">Context containing objects and data related to the operation</param>
        void BeforeInitialisation(PipelineContext context);

        /// <summary>
        /// After the saga is initialised and preserved to the storage
        /// </summary>
        /// <param name="context">Context containing objects and data related to the operation</param>
        void AfterInitialisation(PipelineContext context);

        /// <summary>
        /// Hook executed before it the message is consumed by the saga
        /// </summary>
        /// <param name="context">Context containing objects and data related to the operation</param>
        void BeforeConsuming(PipelineContext context);

        /// <summary>
        /// Hook executed after the message is consimed by the saga
        /// </summary>
        /// <param name="context">Context containing objects and data related to the operation</param>
        void AfterConsuming(PipelineContext context);
    }

    public class BasePipelineHook : IPipelineHook
    {
        public virtual void BeforeInitialisation(PipelineContext context)
        {
        }

        public virtual void AfterInitialisation(PipelineContext context)
        {
        }

        public virtual void BeforeConsuming(PipelineContext context)
        {
        }

        public virtual void AfterConsuming(PipelineContext context)
        {
        }
    }
}
